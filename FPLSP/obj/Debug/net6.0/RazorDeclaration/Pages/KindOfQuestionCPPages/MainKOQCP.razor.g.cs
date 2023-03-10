// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FPLSP.Pages.KindOfQuestionCPPages
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
#line 2 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\KindOfQuestionCPPages\MainKOQCP.razor"
using FPLSP.Components.KindOfQuestionCPComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\KindOfQuestionCPPages\MainKOQCP.razor"
using FPLSP.Repositories.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\KindOfQuestionCPPages\MainKOQCP.razor"
using FPLSP.Server.Data.SeedWork;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\KindOfQuestionCPPages\MainKOQCP.razor"
using FPLSP.Server.Domain.Dtos.KindOfQuestionCPDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\KindOfQuestionCPPages\MainKOQCP.razor"
using FPLSP.Server.Infrastructure.ViewModels.K??nOfQuestionCPVm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\KindOfQuestionCPPages\MainKOQCP.razor"
           [Authorize(Roles = "AdminCore,AdminCS")]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/MainKOQSCP")]
    public partial class MainKOQCP : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 70 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\KindOfQuestionCPPages\MainKOQCP.razor"
       
    [Inject]
    public NavigationManager NavigationManager { get; set; }
    public List<KindOfQuestionCPDtos> ListKOQCP { get; set; } = new List<KindOfQuestionCPDtos>();
    private PagingParameters _koqParameters = new PagingParameters();
    public MetaData MetaData { get; set; } = new MetaData();
    public string Error { get; set; }
    [Inject] public IKindoOfQuestionCPRepo _koqCPClient { get; set; }
    private ListKOQCPSearch KOQCPListSearch = new ListKOQCPSearch();

    protected async override Task OnInitializedAsync()
    {
        await GetTasks();
    }
    private async Task GetTasks()
    {
        try
        {
            var pagingResponse = await _koqCPClient.GetKOQList(KOQCPListSearch);
            ListKOQCP = pagingResponse.Items;
            MetaData = pagingResponse.MetaData;
        }
        catch (Exception ex)
        {
            Error = ex.Message;
        }

    }
    private void RedirectToUpdate(Guid id)
    {

        var url = Path.Combine("/UpdateKOQCP/", id.ToString());
        NavigationManager.NavigateTo(url);
    }

    private async Task RedirectToDelete(Guid id)
    {
        var url = Path.Combine("/DeleteKOQCP/", id.ToString());
        NavigationManager.NavigateTo(url);
    }

    private async Task SelectedPage(int page)
    {
        KOQCPListSearch.PageNumber = page;
        await GetTasks();
    }
    public async Task SearchKOQCP(ListKOQCPSearch koq)
    {
        KOQCPListSearch = koq;
        await GetTasks();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
