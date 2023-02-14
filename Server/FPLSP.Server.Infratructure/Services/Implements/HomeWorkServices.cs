using FPLSP.Server.Data.Repositories.Interfaces;
using FPLSP.Server.Data.SeedWork;
using FPLSP.Server.Domain.Entities.UserParts;
using FPLSP.Server.Infrastructure.Services.Interfaces;
using FPLSP.Server.Infrastructure.ViewModels.HomeWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPLSP.Server.Infrastructure.Services.Implements
{
    public class HomeWorkServices : IHomeWorkServices
    {
        private readonly IRepository<HomeWork> _res;
        public HomeWorkServices(IRepository<HomeWork> res)
        {
            _res = res;
        }
        public async Task<int> CreateCP(HomeWorkCreatVM creat)
        {
            var newlink = new HomeWork()
            {
                IdClass = creat.IdClass,
                IdSubject = creat.IdSubject,
                IdLesson = creat.IdLesson,
                IdUser = creat.IdUser,
                LinkHomeWork = creat.LinkHomeWork,
            };
            try
            {
                var check = _res.AsQueryable().Any(c => c.LinkHomeWork == creat.LinkHomeWork);//check trùng
                if (check) return 0;
                var check2 = _res.AsQueryable().Where(c => c.IdClass == creat.IdClass && c.IdSubject == creat.IdSubject
                && c.IdLesson == creat.IdLesson).Count();//check trùng
                if (check2 >= 1) return 0;
                await _res.AddAsync(newlink);
                await _res.SaveChangesAsync();
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public async Task<int> DeleteCP(Guid id)
        {
            var check = _res.AsQueryable().Where(c => c.Id == id).FirstOrDefault();
            try
            {

                await _res.RemoveAsync(check);
                await _res.SaveChangesAsync();
                return 1;
            }
            catch
            {
                return 0;
            }
        }

        public async Task<HomeWork> Getbyid(Guid id)
        {
            var check = _res.AsQueryable().Where(c => c.Id == id).FirstOrDefault();
            return check;
        }

        public async Task<PageList<HomeWork>> GetCPList(Guid idclass, Guid idsubject, Guid idlesson, HomeWorkSeachList SearchVm)
        {
            var ls = _res.AsQueryable().Where(c => c.IdClass == idclass && c.IdSubject == idsubject && c.IdLesson == idlesson);
            if (!string.IsNullOrEmpty(SearchVm.Name))
                ls = ls.Where(x => x.LinkHomeWork.ToLower().Contains(SearchVm.Name.ToLower()));
            var count = ls.Count();
            var data = ls
               .Skip((SearchVm.PageNumber - 1) * SearchVm.PageSize)
               .Take(SearchVm.PageSize)
               .ToList();
            return new PageList<HomeWork>(data, count
                , SearchVm.PageNumber
                , SearchVm.PageSize);
        }

        public async Task<int> UpdateCP(Guid id, HomeWorkUpdateVM update)
        {
            var check = _res.AsQueryable().Where(c => c.Id == id).FirstOrDefault();

            check.LinkHomeWork = update.LinkHomeWork;

            try
            {
                var trung = _res.AsQueryable().Any(c => c.LinkHomeWork == update.LinkHomeWork);//check trùng
                if (trung) return 0;
                await _res.UpdateAsync(check);
                await _res.SaveChangesAsync();
                return 1;
            }
            catch
            {
                return 0;
            }
        }
    }
}
