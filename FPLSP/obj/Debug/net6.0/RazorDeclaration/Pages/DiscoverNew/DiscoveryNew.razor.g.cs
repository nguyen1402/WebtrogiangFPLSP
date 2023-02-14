// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FPLSP.Pages.DiscoverNew
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\_Imports.razor"
using FPLSP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\_Imports.razor"
using FPLSP.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\_Imports.razor"
using FPLSP.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\_Imports.razor"
using Blazored.Typeahead;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\_Imports.razor"
using CurrieTechnologies.Razor.SweetAlert2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\DiscoverNew\DiscoveryNew.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\DiscoverNew\DiscoveryNew.razor"
using FPLSP.Repositories.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\DiscoverNew\DiscoveryNew.razor"
using FPLSP.Server.Data.SeedWork;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\DiscoverNew\DiscoveryNew.razor"
using FPLSP.Server.Domain.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\DiscoverNew\DiscoveryNew.razor"
using FPLSP.Server.Domain.Entities.UsesParts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\DiscoverNew\DiscoveryNew.razor"
using FPLSP.Server.Infrastructure.ViewModels.SubjectsSpecializedVM;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout2))]
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/discoverynew")]
    public partial class DiscoveryNew : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 158 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\DiscoverNew\DiscoveryNew.razor"
       
     [Inject]
        ISubjectsSpecializedUPRepo _subspecUPRepo { get; set; }
        private List<SubjectsSpecializedDtos> _lstSubSpec = new List<SubjectsSpecializedDtos>();

        [Inject]
        ISubjectUPRepo _subUPRepo { get; set; }
        private List<SubjectUP> _lstSub = new List<SubjectUP>();

        [Inject]
        NavigationManager navigationManager { get; set; }
        [Inject]
        ISpecializedUPRepo _specUPRepo { get; set; }
        private List<SpecializedUP> _lstSpec = new List<SpecializedUP>();
    private int encounter;

        private SubjectsSpecializedCPListSearch _searchDTO = new SubjectsSpecializedCPListSearch();
        private string _specializedId = null;
        private Dictionary<SpecializedUP, List<SubjectsSpecializedDtos>> _lstSubOfSpec = new Dictionary<SpecializedUP, List<SubjectsSpecializedDtos>>();
        private List<SubjectsSpecializedDtos> _searchedDTOList = new List<SubjectsSpecializedDtos>();
        public MetaData MetaData { get; set; } = new MetaData();

        private bool isDisable = true;
        protected override async Task OnInitializedAsync()
        {
            _lstSpec = await _subspecUPRepo.GetAllSpecUP();

            _lstSubOfSpec = await _subspecUPRepo.GetSubOfSpecGroupBy();
            _lstSubSpec = await _subspecUPRepo.GetAllAsync();
        for (var i = 0; i < 15; i++)
        {
            encounter = i;
        }
        }

        private void ChangedSubjectName(ChangeEventArgs args)
        {
            if (_lstSubSpec.Any(c => c.SubjectName == Convert.ToString(args.Value)))
            {
                var searchedSub = _lstSubSpec.FirstOrDefault(c => c.SubjectName == Convert.ToString(args.Value));
                NavigateToSubjectDetails(searchedSub.SubjectId);
            }
        }
        private void NavigateToSubjectDetails(Guid subId)
        {
            string url = $"/detailsubjectup/{subId}";
            navigationManager.NavigateTo(url);
        }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
