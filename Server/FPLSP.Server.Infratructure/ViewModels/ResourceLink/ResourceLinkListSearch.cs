using FPLSP.Server.Data.SeedWork;
using IdentityServer4.Models;
using System.ComponentModel.DataAnnotations;

namespace FPLSP.Server.Infrastructure.ViewModels.ResourceLink
{
    public class ResourceLinkListSearch : PagingParameters
    {
        public string? Name { get; set; }
        public int Status { get; set; }
        public Guid IdSubject { get; set; } = Guid.Empty;
    }
}
