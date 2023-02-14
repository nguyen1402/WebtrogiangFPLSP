// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FPLSP.Pages.TrainingFacilityPages
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
#line 2 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\TrainingFacilityPages\ListTrainingFacility.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\TrainingFacilityPages\ListTrainingFacility.razor"
using FPLSP.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\TrainingFacilityPages\ListTrainingFacility.razor"
using FPLSP.Data.Securities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\TrainingFacilityPages\ListTrainingFacility.razor"
using FPLSP.Repositories.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\TrainingFacilityPages\ListTrainingFacility.razor"
using FPLSP.Server.Data.SeedWork;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\TrainingFacilityPages\ListTrainingFacility.razor"
using FPLSP.Server.Infrastructure.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\TrainingFacilityPages\ListTrainingFacility.razor"
using FPLSP.Server.Infrastructure.ViewModels.TrainingFacilitiesCPVm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\TrainingFacilityPages\ListTrainingFacility.razor"
           [Authorize(Roles = "AdminCore,AdminCS")]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/listtf")]
    public partial class ListTrainingFacility : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 112 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\TrainingFacilityPages\ListTrainingFacility.razor"
       
    [Inject]
    public ITrainingFacilitiesCPRepo tfRepositories { get; set; }
    private List<TrainingFacilitiesCPViewModel> _lstTF;
    private PagingParameters _pagingParameters;
    private int _counter;
    private int stt = 0;
    private List<Guid> _removeSubject = new List<Guid>();

    [Inject]
    public NavigationManager NavigationManager { get; set; }

    [CascadingParameter]
    private Error _error { get; set; }
    public MetaData MetaData { get; set; } = new MetaData();
    public ListTrainingFacility()
    {
        _lstTF = new List<TrainingFacilitiesCPViewModel>();
        _pagingParameters = new PagingParameters();
    }
    protected Comfirmation DeleteConfirmation { get; set; }
    private string deleteID { get; set; }
    public TrainingFacilitiesCPListSearch _trainingFacilitiesCPListSearch { get; set; } = new TrainingFacilitiesCPListSearch();
    [Inject]
    public IToastService ToastService { get; set; }
    private bool Check = false;
    Uri uri;
    string maxlevel = "";
    string IdCoSo = "";
    [Inject]
    public CryptoServices _cryptoServices { get; set; }
    protected override async Task OnInitializedAsync()
    {
        uri = NavigationManager.ToAbsoluteUri(NavigationManager.Uri);
        if (string.IsNullOrEmpty(uri.Query) == false)
        {
            var urifist = uri.Query.Split("?")[1];
            maxlevel = _cryptoServices.Decrypt(urifist.Split("LDN01")[0].Replace("I0H", "/"));
            IdCoSo = _cryptoServices.Decrypt(urifist.Split("LDN01")[1].Replace("I0H", "/"));
        }

        await GetTrainingFacilityList();
    }
    public void OnDelete(Guid id)
    {
        deleteID = id.ToString();
        DeleteConfirmation.show();
    }

    public async Task OnConfirmDelete(bool deleteConfirmed)
    {
        if (deleteConfirmed)
        {
            var result = await tfRepositories.DeleteTrainingFacility(Guid.Parse(deleteID));
            if (result)
            {
                ToastService.ShowSuccess("Đổi trạng thái cơ sở đào tạo thành công", "Success");
                await GetTrainingFacilityList();
            }
            else
            {
                ToastService.ShowError("Đổi trạng thái cơ sở đào tạo thất bại", "Error");
            }
        }
    }

    public async Task SearchTrainingFacilitiesCP(TrainingFacilitiesCPListSearch trainingFacilitiesCPListSearch)
    {
        _trainingFacilitiesCPListSearch = trainingFacilitiesCPListSearch;
        await GetTrainingFacilityList();
    }

    private async Task GetTrainingFacilityList()
    {
        try
        {
            _counter = 4;
            var pagingResponse = await tfRepositories.GetTrainingFacilityList(_trainingFacilitiesCPListSearch);
            _lstTF = pagingResponse.Items;
            if (maxlevel == "6")
            {
                _lstTF = _lstTF.Where(c => c.ID == Guid.Parse(IdCoSo)).ToList();

            }

            _lstTF = _lstTF.OrderBy(x => x.TrainingFacilitiesCode).ToList();
            MetaData = pagingResponse.MetaData;
        }
        catch (Exception ex)
        {

            _error.ProcessError(ex);
        }
    }

    private async Task SelectedPage(int page)
    {
        _trainingFacilitiesCPListSearch.PageNumber = page;
        Check = false;
        await GetTrainingFacilityList();
    }

    private async void NavigateToCreateTrainingFacility()
    {
        NavigationManager.NavigateTo($"createtf?{_cryptoServices.Encrypt((maxlevel).ToString()).Replace("/", "I0H") + "LDN01" + _cryptoServices.Encrypt((IdCoSo).ToString()).Replace("/", "I0H")}");
        GetTrainingFacilityList();
    }
    private async void NavigateToLecturer(Guid Id)
    {
        NavigationManager.NavigateTo($"/lecturercp/{Id}?{_cryptoServices.Encrypt((maxlevel).ToString()).Replace("/", "I0H") + "LDN01" + _cryptoServices.Encrypt((IdCoSo).ToString()).Replace("/", "I0H")}");
    }
    private async void NavigateToUpdateTrainingFacility(TrainingFacilitiesCPViewModel tfCPViewModel)
    {
        var id = tfCPViewModel.ID;

        NavigationManager.NavigateTo($"updatetf/{id}?{_cryptoServices.Encrypt((maxlevel).ToString()).Replace("/", "I0H") + "LDN01" + _cryptoServices.Encrypt((IdCoSo).ToString()).Replace("/", "I0H")}");
        GetTrainingFacilityList();
    }
    private async void Delete(TrainingFacilitiesCPViewModel tfCPViewModel)
    {
        var id = tfCPViewModel.ID;
        await tfRepositories.DeleteTrainingFacility(id);

        NavigationManager.NavigateTo($"listtf?{_cryptoServices.Encrypt((maxlevel).ToString()).Replace("/", "I0H") + "LDN01" + _cryptoServices.Encrypt((IdCoSo).ToString()).Replace("/", "I0H")}", true);
    }
    private async Task<Guid> GetId(TrainingFacilitiesCPViewModel tfCPViewModel)
    {
        var tfCollection = await tfRepositories.GetTrainingFacilitiesAsync();
        var id = tfCollection.First(c => c.TrainingFacilitiesCode == tfCPViewModel.TrainingFacilitiesCode).Id;
        return id;
    }
    void CheckManual(Guid reportId, bool check)
    {
        stt = 0;
        if (check == true)
        {
            foreach (var x in _lstTF.Where(c => c.ID == reportId))
            {
                x.IsChecked = false;
            }
        }
        if (check == false)
        {
            foreach (var x in _lstTF.Where(c => c.ID == reportId))
            {
                x.IsChecked = true;
            }
        }
    }
    void DeleteAll()
    {
        stt = 0;
        _removeSubject = _lstTF.Where(c => c.IsChecked == true).Select(c => c.ID).ToList();
        DeleteConfirmation.show();
    }
    void CheckAllExpense(object checkValue)
    {
        stt = 0;
        if (Convert.ToBoolean(checkValue) == false)
        {
            _lstTF.ToList().ForEach(e => e.IsChecked = false);
        }
        else
        {
            _lstTF.ToList().ForEach(e => e.IsChecked = true);
        }
    }
    public async Task OnConfirmationDelete(bool deleteconfirmed)
    {

        stt = 0;
        if (deleteconfirmed && deleteID == null && _removeSubject.Count == 0)
        {
            ToastService.ShowError("Bạn chưa chọn đối tượng để thay đổi");
            await GetTrainingFacilityList();
            NavigationManager.NavigateTo($"/listtf?{_cryptoServices.Encrypt((maxlevel).ToString()).Replace("/", "I0H") + "LDN01" + _cryptoServices.Encrypt((IdCoSo).ToString()).Replace("/", "I0H")}");
        }
        else if (deleteconfirmed && deleteID != null)
        {
            var result = await tfRepositories.DeleteTrainingFacility(Guid.Parse(deleteID));
            if (result == true)
            {
                ToastService.ShowSuccess("Đổi trạng thái thành công");
                deleteID = null;
                await GetTrainingFacilityList();
                NavigationManager.NavigateTo($"/listtf?{_cryptoServices.Encrypt((maxlevel).ToString()).Replace("/", "I0H") + "LDN01" + _cryptoServices.Encrypt((IdCoSo).ToString()).Replace("/", "I0H")}");
            }
            else
            {
                ToastService.ShowError("Đổi trạng thái thất bại");
                deleteID = null;
                await GetTrainingFacilityList();
                NavigationManager.NavigateTo($"/listtf?{_cryptoServices.Encrypt((maxlevel).ToString()).Replace("/", "I0H") + "LDN01" + _cryptoServices.Encrypt((IdCoSo).ToString()).Replace("/", "I0H")}");
            }
        }
        else if (deleteconfirmed && _removeSubject != null)
        {

            var result = await tfRepositories.RemoveListTF(_removeSubject);
            if (result)
            {
                ToastService.ShowSuccess("Đổi trạng thái thành công");
                deleteID = null;
                _removeSubject = null;
                await GetTrainingFacilityList();
                NavigationManager.NavigateTo($"/listtf?{_cryptoServices.Encrypt((maxlevel).ToString()).Replace("/", "I0H") + "LDN01" + _cryptoServices.Encrypt((IdCoSo).ToString()).Replace("/", "I0H")}");
            }
            else
            {
                ToastService.ShowError("Đổi trạng thái thất bại");
                deleteID = null;
                _removeSubject = null;
                await GetTrainingFacilityList();
                NavigationManager.NavigateTo($"/listtf?{_cryptoServices.Encrypt((maxlevel).ToString()).Replace("/", "I0H") + "LDN01" + _cryptoServices.Encrypt((IdCoSo).ToString()).Replace("/", "I0H")}");
            }
        }
        else
        {
            deleteID = null;
            _removeSubject = null;
        }
        Check = false;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591