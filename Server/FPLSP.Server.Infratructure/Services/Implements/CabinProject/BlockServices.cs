using AutoMapper;
using AutoMapper.QueryableExtensions;
using FPLSP.Server.Data.Repositories.Interfaces;
using FPLSP.Server.Domain.Dtos;
using FPLSP.Server.Domain.Entities.CabinProject;
using FPLSP.Server.Infrastructure.Services.Interfaces.Cabin;
using FPLSP.Server.Infrastructure.Services.Interfaces.CabinProject;
using FPLSP.Server.Infrastructure.ViewModels.CabinProject;
using Microsoft.EntityFrameworkCore;

namespace FPLSP.Server.Infrastructure.Services.Implements.Cabin
{
    public class BlockServices : IBlockServices
    {
        public IRepository<Block> _blockRes;
        public IMapper _mapper;
        public BlockServices(IRepository<Block> blockRes, IMapper mapper)
        {
            _blockRes = blockRes ?? throw new ArgumentNullException(nameof(blockRes));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        /// <summary>
        /// Phương thức tạo 1 Block
        /// </summary>
        /// <param name="block">Truyền vào đối tượng BlockVM từ trên View xuống để thêm vào Server</param>
        /// <returns>Đúng trả về true sai trả về false</returns>
        public async Task<bool> CreateBlock(BlockVM block)
        {
            try
            {
                var count = _blockRes.AsQueryable().Where(x => x.Status == 0).Count();
                var addBlock = new Block
                {
                    Id = block.Id,
                    NameOfBlock = block.NameOfBlock,
                    IndexOfBlock = count + 1,
                    Status = 0
                };
                await _blockRes.AddAsync(addBlock);
                await _blockRes.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        /// <summary>
        /// Phương thức xóa 1 block
        /// </summary>
        /// <param name="Id">Truyền vào ID để tìm kiếm đối tượng cần xóa</param>
        /// <returns>Đúng trả về true sai trả về false</returns>
        public async Task<bool> DeleteBlock(Guid Id)
        {
            try
            {
                var block = await _blockRes.AsQueryable().Where(x => x.Status == 0).FirstOrDefaultAsync(x => x.Id == Id);
                if (block != null)
                {
                    block.Status = 1;
                }
                await _blockRes.UpdateAsync(block);
                await _blockRes.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        /// <summary>
        /// Phương thức lấy ra tất cả các block
        /// </summary>
        /// <returns>Trả về 1 danh sách block</returns>
        public Task<IQueryable<BlockDto>> GetAll()
        {
            return Task.FromResult(_blockRes.AsQueryable().ProjectTo<BlockDto>(_mapper.ConfigurationProvider));
        }
        /// <summary>
        /// Tìm kiếm 1 block 
        /// </summary>
        /// <param name="Id">Truyền vào Id để tìm ra block</param>
        /// <returns>Nếu tìm thấy sẽ trả về 1 block</returns>
        public async Task<BlockVM> GetById(Guid Id)
        {
            var block = _blockRes.AsQueryable().ProjectTo<BlockVM>(_mapper.ConfigurationProvider).Where(x => x.Status == 0).FirstOrDefaultAsync(x => x.Id == Id);

            return await block;

        }
        /// <summary>
        /// Cập nhật block
        /// </summary>
        /// <param name="block">Truyền vào đối tượng mới và tìm kiếm theo id để thay đổi những thuộc tính của đối tượng cũ bằng những giá trị của những thuộc tính mới</param>
        /// <returns>Đúng trả về true sai trả về false</returns>
        public async Task<bool> UpdateBlock(BlockVM block)
        {
            try
            {
                var UpdateBlock = await _blockRes.AsQueryable().Where(x => x.Status == 0).FirstOrDefaultAsync(x => x.Id == block.Id);
                if (UpdateBlock != null)
                {
                    UpdateBlock.NameOfBlock = block.NameOfBlock;
                    UpdateBlock.IndexOfBlock = block.IndexOfBlock;
                    UpdateBlock.Status = block.Status;
                    await _blockRes.UpdateAsync(UpdateBlock);
                    await _blockRes.SaveChangesAsync();
                }

                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
