// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FPLSP.Pages.PagesLectuterSpecializedCP
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
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
#line 2 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesLectuterSpecializedCP\LectuterSpecializedCreate.razor"
using FPLSP.Repositories.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesLectuterSpecializedCP\LectuterSpecializedCreate.razor"
using FPLSP.Server.Domain.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesLectuterSpecializedCP\LectuterSpecializedCreate.razor"
using FPLSP.Server.Domain.Entities.CoresParts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesLectuterSpecializedCP\LectuterSpecializedCreate.razor"
using FPLSP.Server.Infrastructure.ViewModels.LectuterSpecializedCP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesLectuterSpecializedCP\LectuterSpecializedCreate.razor"
           [Authorize(Roles = "AdminCS")]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/lectuterSpecializedCreate/{id}/{idspecialized}")]
    public partial class LectuterSpecializedCreate : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 57 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesLectuterSpecializedCP\LectuterSpecializedCreate.razor"
       
    private LectuterSpecializedCPCreateVM lessonContent = new LectuterSpecializedCPCreateVM();

    [Parameter]
    public string id { get; set; }

    [Parameter]
    public string idspecialized { get; set; }
    [Inject]
    public NavigationManager Navigation { get; set; }

    [Inject]
    public ILectuterSpecializedCPCilents _iLectuterSpecializedCPCilents { get; set; }


    [Inject]
    public ISpecializedCPRepo _iSpecializedClient { get; set; }

    private SpecializedDto _specialized;

    [Inject]
    public ILecturersCPRepo _iLecturersCPRepo { get; set; }

    private List<LecturersCP> lsLectu;
    protected override async Task OnInitializedAsync()
    {
        lsLectu = await _iLecturersCPRepo.GetAllLecturerAsync();
        _specialized = await _iSpecializedClient.GetbyId(Guid.Parse(idspecialized), Guid.Parse(id));
    }

    public bool ShowAuthError { get; set; }
    [Parameter]
    public string Error { get; set; }
    private async Task Create()
    {
        ShowAuthError = false;
        var result = await _iLectuterSpecializedCPCilents.Create(Guid.Parse(id), lessonContent);
        if (result != 1)
        {
            Error = "Lỗi";
            var url = Path.Combine("/lectuterSpecializedCreate", id, idspecialized);
            ShowAuthError = true;
            Navigation.NavigateTo(url);
        }
        else
        {
            var url = Path.Combine("/lectuterSpecialized", idspecialized, id);
            Navigation.NavigateTo(url);
        }
    }
    private async Task Quaylai()
    {
        var url = Path.Combine("/lectuterSpecialized", idspecialized, id);
        Navigation.NavigateTo(url);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
