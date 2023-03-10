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
#line 1 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\GroupCabin\GroupCabinAdd.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\GroupCabin\GroupCabinAdd.razor"
using FPLSP.Repositories.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\GroupCabin\GroupCabinAdd.razor"
using FPLSP.Repositories.Interfaces.CabinProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\GroupCabin\GroupCabinAdd.razor"
using FPLSP.Server.Data.SeedWork;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\GroupCabin\GroupCabinAdd.razor"
using FPLSP.Server.Infrastructure.ViewModels.CabinProject.Cabin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\GroupCabin\GroupCabinAdd.razor"
using FPLSP.Server.Infrastructure.ViewModels.CabinProject.GroupCabin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\GroupCabin\GroupCabinAdd.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
    public partial class GroupCabinAdd : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 130 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\GroupCabin\GroupCabinAdd.razor"
       
    [Parameter] public string idSpec { get; set; }
    [Inject] public ICabinRepo cabinRepo { get; set; }
    [Inject] NavigationManager NavigationManager { get; set; }
    [Inject] public IGroupCabinRepo grcabinRepo { get; set; }
    [Inject] private ICabinRepo _CabinRepo { get; set; }
    [Inject] private ISpecializedUPRepo _specializedUPRepo { get; set; }
    [Inject] public IToastService ToastService { get; set; }

    List<GroupCabinViewModel> groupCabinViewModel = new List<GroupCabinViewModel>();
    GroupCabinSearchViewModel groupCabinSearchViewModel = new GroupCabinSearchViewModel();
    GroupCabinViewModel grcbVm = new GroupCabinViewModel();
    List<GroupCabinListVM> gcabin;
    [Parameter]
    public EventCallback<bool> ConfirmationChanged { get; set; }
    public MetaData MetaData { get; set; } = new MetaData();
    Guid idCabinDel;
    string idCabinDetails;
    GroupCabinCreateViewModel groupCabinCreateViewModel = new GroupCabinCreateViewModel();
    List<CabinViewModel> cbvm1 = new List<CabinViewModel>();
    List<CabinViewModel> cbvm = new List<CabinViewModel>();
    private string bindtextCabin;
    private string nameSpec;
    List<string> lstCabin = new List<string>();
    int count = 0;// d??ng ????? ?????m;
    protected Add AddConfirmation { set; get; }
    protected Comfirmation DeleteConfirmation { get; set; }
    protected override async Task OnInitializedAsync()
    {
        //try
        //{
        //    //Check thay ?????i c???a BookingRequest
        //    string url = "http://localhost:5001/SignalRBookingRequestHub";
        //    HubConnection _connection = null;
        //    bool isConnected = false;
        //    string connectionStatus = "Closed";
        //    _connection = new HubConnectionBuilder()
        //        .WithUrl(url)
        //        .Build();

        //    await _connection.StartAsync();
        //    isConnected = true;
        //    connectionStatus = "Connected :-)";

        //    _connection.Closed += async (s) =>
        //    {
        //        isConnected = false;
        //        connectionStatus = "Disconnected";
        //        await _connection.StartAsync();
        //        isConnected = true;
        //    };

        //    _connection.On<string>("SignalRBookingRequests", async (res) =>
        //    {
        //        if (res == "Done")
        //        {
        //            await GetTask();

        //            await this.InvokeAsync(() => this.StateHasChanged());
        //        }


        //    });
        //}catch{

        //}finally{
          
        //}
        await GetTask();

    }
    private async Task GetId(Guid idCabin)
    {
        idCabinDetails = idCabin.ToString();
    }
    public async Task GetTask()
    {
        lstCabin = new List<string>();//T???o m???i list string ????? th??m c??c cabin name v??o autocomplete
        cbvm1 = await cabinRepo.GetAllCabinAsync(); // L???y ra t???t c??? c??c cabin
        cbvm1 = cbvm1.Where(x => x.Status != 1).ToList();
        var grcb = await grcabinRepo.GetAllGroupCabinAsync();// L???y ra t???t c??? c??c group cabin theo chuy??n ng??nh
        grcb = grcb.Where(x => x.IdSpec == Guid.Parse(idSpec)).ToList();
        foreach (var item in cbvm1)
        {
            foreach (var itemgc in grcb)
            {
                if (item.Id == itemgc.IdCabin && itemgc.Status != 1)
                {
                    lstCabin.Add(item.CabinName); // N???u Cabin c?? ??? trong group cabin v?? tr???ng th??i == 0 th?? s??? th??m v??o lstCabin ????? hi???n th??? tr??n MudChipSet
                }

            }

        }
        var getName = await _specializedUPRepo.GetByIdSpec(Guid.Parse(idSpec));
        nameSpec = getName.SpecializationName;
        var groupViewModel = await grcabinRepo.GetGroupCabinListSearch(groupCabinSearchViewModel);
        var cabinvm = await _CabinRepo.GetAllCabinAsync();
        cabinvm = cabinvm.Where(x => x.Status != 1).ToList();
        groupCabinViewModel = groupViewModel.Items.Where(x => x.IdSpec == Guid.Parse(idSpec)).ToList();

        MetaData = groupViewModel.MetaData;
        gcabin = (from a in cabinvm
                  join b in groupCabinViewModel
                  on a.Id equals b.IdCabin
                  select new GroupCabinListVM
                      {
                          IdCabin = a.Id,
                          CabinName = a.CabinName,
                          DateOfGrouping = b.DateOfGrouping,
                          StartTime = b.StartTime,
                          EndTime = b.EndTime,
                          Status = b.Status,
                      }).ToList();
        //L???y ra groupCabinListVm ????? hi???n th??? l??n form nh???ng th??ng tin c???n thi???t
        //G??n gi?? tr??? true false ????? cho n??t switch tr???ng th??i
        foreach (var item in gcabin)
        {
            if (item.Status == 0)
            {
                item.Checked = true;
            }
            else if (item.Status == 2)
            {
                item.Checked = false;
            }
        }
    }
    private async void ChangedCabinName(ChangeEventArgs args)
    {
        bindtextCabin = Convert.ToString(args.Value); // Nh???n gi?? tr??? t??? s??? ki???n nh???p v??o ??? tr??n th??? input complete
        var cabin = await _CabinRepo.GetAllCabinAsync();
        var cabincheck = cabin.FirstOrDefault(x => x.CabinName == bindtextCabin);// T??m ra cabin theo t??n ????? l???y ra ID ph???c v??? cho vi???c x??a
        if (cabincheck != null)
        {
            groupCabinCreateViewModel.IdCabin = cabincheck.Id;
            AddConfirmation.show();
            // N???u x??a th??nh c??ng s??? clear form

        }

    }
    private async Task UpdateEndTime(Guid idCabin, DateTime date)
    {
        var GroupCabinUpdateViewModel = gcabin.FirstOrDefault(x => x.IdCabin == idCabin);
       
             GroupCabinUpdateViewModel groupCabinUpdate = new GroupCabinUpdateViewModel()
            {
                GroupCabinName = GroupCabinUpdateViewModel.CabinName,
                DateOfGrouping = GroupCabinUpdateViewModel.DateOfGrouping,
                StartTime = GroupCabinUpdateViewModel.StartTime,
                EndTime = date,
                IndexOfGroupCabin = GroupCabinUpdateViewModel.IndexOfGroupCabin,
                Status = 0

            };
        var check = await grcabinRepo.UpdateGroupCabin(Guid.Parse(idSpec), idCabin, groupCabinUpdate);  
    }

    private async Task ChangeStatus(Guid idCabin, bool? Checked)
    {

        var GroupCabinUpdateViewModel = gcabin.FirstOrDefault(x => x.IdCabin == idCabin);
        if (GroupCabinUpdateViewModel != null)
        {
            if ((bool)Checked)
            {
                GroupCabinUpdateViewModel groupCabinUpdate = new GroupCabinUpdateViewModel()
                    {
                        GroupCabinName = GroupCabinUpdateViewModel.CabinName,
                        DateOfGrouping = GroupCabinUpdateViewModel.DateOfGrouping,
                        StartTime = GroupCabinUpdateViewModel.StartTime,
                        EndTime = GroupCabinUpdateViewModel.EndTime,
                        IndexOfGroupCabin = GroupCabinUpdateViewModel.IndexOfGroupCabin,
                        Status = 2

                    };
                var check = await grcabinRepo.UpdateGroupCabin(Guid.Parse(idSpec), idCabin, groupCabinUpdate);
                if (check)
                {
                    ToastService.ShowSuccess("Thay ?????i tr???ng th??i th??nh c??ng");
                    await GetTask();
                }
            }
            else
            {
                GroupCabinUpdateViewModel groupCabinUpdate = new GroupCabinUpdateViewModel()
                    {
                        GroupCabinName = GroupCabinUpdateViewModel.CabinName,
                        DateOfGrouping = GroupCabinUpdateViewModel.DateOfGrouping,
                        StartTime = GroupCabinUpdateViewModel.StartTime,
                        EndTime = GroupCabinUpdateViewModel.EndTime,
                        IndexOfGroupCabin = GroupCabinUpdateViewModel.IndexOfGroupCabin,
                        Status = 0

                    };
                var check = await grcabinRepo.UpdateGroupCabin(Guid.Parse(idSpec), idCabin, groupCabinUpdate);
                if (check)
                {
                    ToastService.ShowSuccess("Thay ?????i tr???ng th??i th??nh c??ng");
                    await GetTask();
                }
            }

        }


    }
    protected async Task OnConfirmationAdd(bool value)
    {
        if (value)
        {
            await Add();
        }
    }
    private async Task Add()
    {
        if (groupCabinCreateViewModel.IdCabin.ToString() == "00000000-0000-0000-0000-000000000000")
        {


            return;
        }
        //Check xem cabin ???? c?? trong chuy??n ng??nh ch??a
        var cbcheck = gcabin.Where(x => x.IdCabin == groupCabinCreateViewModel.IdCabin).Count();
        if (cbcheck == 1)
        {
            ToastService.ShowError("???? t???n t???i Cabin");
            return;
        }
        var cb = await cabinRepo.GetCabinListById(groupCabinCreateViewModel.IdCabin.ToString());
        groupCabinCreateViewModel.GroupCabinName = cb.CabinName;
        groupCabinCreateViewModel.IdSpec = Guid.Parse(idSpec);
        groupCabinCreateViewModel.IndexOfGroupCabin = 0;
        groupCabinCreateViewModel.Status = 0;
        var check = await grcabinRepo.CreateGroupCabin(groupCabinCreateViewModel);
        var check2 = await grcabinRepo.ChangeStatus(idSpec, groupCabinCreateViewModel.IdCabin.ToString());
        if (!check2)
        {

            if (check)
            {
                bindtextCabin = null;
                ToastService.ShowSuccess("Th??m th??nh c??ng");
                await GetTask();
            }
            else
            {

                ToastService.ShowError("Th??m th???t b???i");
            }
        }
        else
        {

            bindtextCabin = null;
            ToastService.ShowSuccess("Th??m th??nh c??ng");
            await GetTask();
        }

    }
    private async Task SelectedPage(int page)
    {
        groupCabinSearchViewModel.PageNumber = page;
        await GetTask();
    }
    private async Task Delete(string CabinName)
    {
        var cabin = await _CabinRepo.GetAllCabinAsync();
        var cabincheck = cabin.FirstOrDefault(x => x.CabinName == CabinName);
        if (cabincheck != null)
        {
            groupCabinCreateViewModel.IdCabin = cabincheck.Id;
            idCabinDel = cabincheck.Id;
            DeleteConfirmation.show();
        }
    }

    private async Task OnConfirmationDelete(bool deleteconfirmed)
    {
        if (deleteconfirmed)
        {
            var check = await grcabinRepo.DeleteGroupCabin(Guid.Parse(idSpec), idCabinDel);
            if (check)
            {
                count++;

                await GetTask();
                ToastService.ShowSuccess("X??a th??nh c??ng");
            }
            else
            {
                ToastService.ShowError("X??a th???t b???i");
            }
        }
    }
    public async void Closed(MudChip chip)
    {
        await Delete(chip.Text);
        if (count != 0)
        {
            lstCabin.Remove(chip.Text);
        }

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDialogService DialogService { get; set; }
    }
}
#pragma warning restore 1591
