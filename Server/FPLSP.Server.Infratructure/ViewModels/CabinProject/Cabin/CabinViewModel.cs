using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPLSP.Server.Infrastructure.ViewModels.CabinProject.Cabin
{
    public class CabinViewModel
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Không được bỏ trống tên Cabin")]
        public string CabinName { get; set; }
        public int IndexOfCabin { get; set; }
        public DateTime CreateTime { get; set; }
        [Required(ErrorMessage = "Không được bỏ trống tên Tòa")]
        public string BuildingName { get; set; }
        public Guid IdTrainingFacility { get; set; }
        public bool? Checked { get; set; }
        public int Status { get; set; }
    }
}