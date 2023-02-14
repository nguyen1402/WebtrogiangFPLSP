// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FPLSP.Pages.CabinProject.GroupCabin
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
#line 1 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\GroupCabin\GroupCabinUpdate.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\GroupCabin\GroupCabinUpdate.razor"
using FPLSP.Repositories.Interfaces.CabinProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\GroupCabin\GroupCabinUpdate.razor"
using FPLSP.Server.Infrastructure.ViewModels.CabinProject.Cabin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\GroupCabin\GroupCabinUpdate.razor"
using FPLSP.Server.Infrastructure.ViewModels.CabinProject.GroupCabin;

#line default
#line hidden
#nullable disable
    public partial class GroupCabinUpdate : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\GroupCabin\GroupCabinUpdate.razor"
       
    [CascadingParameter] MudDialogInstance MudDialog { get; set; }
    void Submit() => MudDialog.Close(DialogResult.Ok(true));
    void Cancel() => MudDialog.Cancel();
    [Parameter] public string idSpec { get; set; }
    [Parameter] public string idCabin { get; set; }
    [Inject] public ICabinRepo cabinRepo { get; set; }
    [Inject] public IGroupCabinRepo grcabinRepo { get; set; }
    [Inject] public IToastService ToastService { get; set; }
    GroupCabinUpdateViewModel groupCabinUpdateViewModel = new GroupCabinUpdateViewModel();
    GroupCabinViewModel groupCabinViewModel = new GroupCabinViewModel();
    CabinViewModel CabinViewModel = new CabinViewModel();
    List<CabinViewModel> cbvm = new List<CabinViewModel>();
    protected override async Task OnInitializedAsync()
    {
        await GetTask();
    }
    private async Task GetTask(){
        cbvm = await cabinRepo.GetAllCabinAsync();
        cbvm = cbvm.Where(x => x.Status == 0).ToList();
        groupCabinViewModel = await grcabinRepo.GetGroupCabinListById(idSpec,idCabin);
        CabinViewModel = await cabinRepo.GetCabinListById(idCabin);
    }
    private async void Update()
    {
        if (groupCabinViewModel.IdCabin.ToString() == "00000000-0000-0000-0000-000000000000")
        {
            return;
        }
        CabinViewModel = await cabinRepo.GetCabinListById(groupCabinViewModel.IdCabin.ToString());
        groupCabinUpdateViewModel.GroupCabinName = CabinViewModel.CabinName;
        groupCabinUpdateViewModel.IdSpec = groupCabinViewModel.IdSpec;
        groupCabinUpdateViewModel.IdCabin = groupCabinViewModel.IdCabin;
        groupCabinUpdateViewModel.IndexOfGroupCabin = groupCabinViewModel.IndexOfGroupCabin;
        groupCabinUpdateViewModel.Status = groupCabinViewModel.Status;
        groupCabinUpdateViewModel.DateOfGrouping = groupCabinViewModel.DateOfGrouping;
        groupCabinUpdateViewModel.StartTime = groupCabinViewModel.StartTime;
        groupCabinUpdateViewModel.EndTime = groupCabinViewModel.EndTime;

        var check = await grcabinRepo.UpdateGroupCabin(Guid.Parse(idSpec), Guid.Parse(idCabin),groupCabinUpdateViewModel);
        if (check)
        {
            ToastService.ShowSuccess("Sửa thành công");
        }
        else
        {
            ToastService.ShowError("Sửa thất bại");
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
