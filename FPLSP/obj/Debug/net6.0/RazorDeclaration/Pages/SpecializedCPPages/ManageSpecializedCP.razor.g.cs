// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FPLSP.Pages.SpecializedCPPages
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
#line 2 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializedCPPages\ManageSpecializedCP.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializedCPPages\ManageSpecializedCP.razor"
using FPLSP.Data.Securities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializedCPPages\ManageSpecializedCP.razor"
using FPLSP.Repositories.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializedCPPages\ManageSpecializedCP.razor"
using FPLSP.Server.Data.SeedWork;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializedCPPages\ManageSpecializedCP.razor"
using FPLSP.Server.Domain.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializedCPPages\ManageSpecializedCP.razor"
using FPLSP.Server.Infrastructure.ViewModels.Specialized;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializedCPPages\ManageSpecializedCP.razor"
           [Authorize(Roles = "AdminCore,AdminCS")]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/manageSpecializedCP")]
    public partial class ManageSpecializedCP : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 114 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializedCPPages\ManageSpecializedCP.razor"
       
    [Inject]
    public ISpecializedCPRepo _specializedCPRepo { get; set; }
    private List<SpecializedDto> _lstSpecializedCP = new List<SpecializedDto>();
    private List<SpecializedDto> _lstSpecializedCPAll = new List<SpecializedDto>();
    private List<SpecializedDto> _lstSpecializedLevel0 = new List<SpecializedDto>();
    private List<Guid> _removeSpecializedCP = new List<Guid>();
    [Inject]
    public NavigationManager NavigationManager { get; set; }
    [Inject]
    public CryptoServices _cryptoServices { get; set; }
    [CascadingParameter]
    private Error _error { get; set; }
    public MetaData MetaData { get; set; } = new MetaData();
    public SpecializedListSearch _specializedListSearch { get; set; } = new SpecializedListSearch();
    protected Comfirmation DeleteConfirmation { get; set; }
    private string deleteID { get; set; }
    [Inject]
    public IToastService ToastService { get; set; }
    private bool Check = false;
    private string idTran = string.Empty;
 
    Uri uri;
    string maxlevel = "";
    string IdCoSo = "";
    protected override async Task OnInitializedAsync()
    {
        uri = NavigationManager.ToAbsoluteUri(NavigationManager.Uri);
        if (string.IsNullOrEmpty(uri.Query) == false)
        {
            var urifist = uri.Query.Split("?")[1];
            maxlevel = _cryptoServices.Decrypt(urifist.Split("LDN01")[0].Replace("I0H", "/"));
            IdCoSo = _cryptoServices.Decrypt(urifist.Split("LDN01")[1].Replace("I0H", "/"));
        }
      
        _lstSpecializedCP = await _specializedCPRepo.GetAll();
        _lstSpecializedCPAll = await _specializedCPRepo.GetAll();
        _lstSpecializedLevel0 = await _specializedCPRepo.GetAll();
        _lstSpecializedLevel0 = _lstSpecializedLevel0.Where(x => x.Level == 0).ToList();
        //uri = NavigationManager.ToAbsoluteUri(NavigationManager.Uri);
        //idTran = uri.Query.Split('?')[0];
        await GetSpecializedCPList();
    }

    private async Task SelectedPage(int page)
    {
        _specializedListSearch.PageNumber = page;
        Check = false;
        await GetSpecializedCPList();
    }

    public async Task SearchSpecializedCP(SpecializedListSearch search)
    {
        _specializedListSearch = search;
        await GetSpecializedCPList();
    }

    private async Task GetSpecializedCPList()
    {
        try
        {
            var pagingResponse = await _specializedCPRepo.GetsAll(_specializedListSearch);
            _lstSpecializedCP = pagingResponse.Items;
            _lstSpecializedCP = _lstSpecializedCP.OrderBy(x => x.SpecializedCode).ToList();
            MetaData = pagingResponse.MetaData;
        }
        catch (Exception ex)
        {

            _error.ProcessError(ex);
        }
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
            var result = await _specializedCPRepo.Delete(Guid.Empty, Guid.Parse(deleteID));
            if (result == 1)
            {
                ToastService.ShowSuccess("X??a chuy??n ng??nh th??nh c??ng", "Success");
                await GetSpecializedCPList();
            }
            else
            {
                ToastService.ShowError("X??a chuy??n ng??nh th???t b???i", "Error");
            }
        }
    }
    void CheckManual(Guid reportId, bool check)
    {
        if (check == true)
        {
            foreach (var x in _lstSpecializedCP.Where(c => c.Id == reportId))
            {
                x.IsChecked = false;
            }
        }
        if (check == false)
        {
            foreach (var x in _lstSpecializedCP.Where(c => c.Id == reportId))
            {
                x.IsChecked = true;
            }
        }
    }
    void DeleteAll()
    {
        _removeSpecializedCP = _lstSpecializedCP.Where(c => c.IsChecked == true).Select(c => c.Id).ToList();
        DeleteConfirmation.show();
    }
    void CheckAllExpense(object checkValue)
    {
        if (Convert.ToBoolean(checkValue) == false)
        {
            _lstSpecializedCP.ToList().ForEach(e => e.IsChecked = false);
        }
        else
        {
            _lstSpecializedCP.ToList().ForEach(e => e.IsChecked = true);
        }
    }
    public async Task OnConfirmationDelete(bool deleteconfirmed)
    {
        if (deleteconfirmed && deleteID == null && _removeSpecializedCP.Count == 0)
        {
            ToastService.ShowError("B???n ch??a ch???n ?????i t?????ng ????? x??a");
            await GetSpecializedCPList();
            NavigationManager.NavigateTo($"/manageSpecializedCP");
        }
        else if (deleteconfirmed && deleteID != null)
        {
            var result = await _specializedCPRepo.Delete(Guid.Empty, Guid.Parse(deleteID));
            if (result == 1)
            {
                ToastService.ShowSuccess("X??a th??nh c??ng");
                deleteID = null;
                await GetSpecializedCPList();
                NavigationManager.NavigateTo($"/manageSpecializedCP");
            }
            else
            {
                ToastService.ShowError("X??a th???t b???i");
                deleteID = null;
                await GetSpecializedCPList();
                NavigationManager.NavigateTo($"/manageSpecializedCP");
            }
        }
        else if (deleteconfirmed && _removeSpecializedCP != null)
        {
            //var result = await _specializedCPRepo.RemoveSpecializedCP(_removeSpecializedCP);
            //if (result)
            //{
            //    ToastService.ShowSuccess("X??a th??nh c??ng");
            //    deleteID = null;
            //    _removeSpecializedCP = null;
            //    await GetSpecializedCPList();
            //    NavigationManager.NavigateTo($"/SpecializedCP");
            //}
            //else
            //{
            //    ToastService.ShowError("X??a th???t b???i");
            //    deleteID = null;
            //    _removeSpecializedCP = null;
            //    await GetSpecializedCPList();
            //    NavigationManager.NavigateTo($"/SpecializedCP");
            //}
        }
        else
        {
            deleteID = null;
            _removeSpecializedCP = null;
        }
        Check = false;
    }

    private void RedirectToCreate()
    {
        NavigationManager.NavigateTo("/createSpecializedCP");
    }

    private void NavigateToUpdate(string id)
    {

        var idNonDecrypt = id.Replace("/", "I0H");
        NavigationManager.NavigateTo($"/updateSpecializedCP/{idNonDecrypt}");
    }

    private void NavigateToSubjectCP(string id)
    {
        NavigationManager.NavigateTo($"/subjects/{id}");
    }

    private void RedirectToSpecList()
    {
        NavigationManager.NavigateTo($"/SpecializedCP/{_cryptoServices.Encrypt((maxlevel).ToString()).Replace("/", "I0H")}/{_cryptoServices.Encrypt((IdCoSo).ToString()).Replace("/", "I0H")}");
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
