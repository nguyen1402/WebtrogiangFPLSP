// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FPLSP.Pages.SpecializeUPPages
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
#line 2 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializeUPPages\SpecializedUP.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializeUPPages\SpecializedUP.razor"
using FPLSP.Components.SpecializedUP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializeUPPages\SpecializedUP.razor"
using FPLSP.Repositories.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializeUPPages\SpecializedUP.razor"
using FPLSP.Server.Data.SeedWork;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializeUPPages\SpecializedUP.razor"
using FPLSP.Server.Domain.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializeUPPages\SpecializedUP.razor"
using FPLSP.Server.Infrastructure.ViewModels.Specialized;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/SpecializedUP")]
    public partial class SpecializedUP : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 78 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializeUPPages\SpecializedUP.razor"
       
    [Inject]
    public ISpecializedUPRepo _specializedUPRepo { get; set; }
    private List<SpecializedDto> _lstSpecializedUP = new List<SpecializedDto>();
    private List<SpecializedDto> _lstAll = new List<SpecializedDto>();


    private List<Guid> _removeSpecializedUP = new List<Guid>();

    [Inject]
    public NavigationManager NavigationManager { get; set; }

    [CascadingParameter]
    private Error _error { get; set; }
    public MetaData MetaData { get; set; } = new MetaData();
    public SpecializedListSearch _specializedListSearch { get; set; } = new SpecializedListSearch();
    protected Comfirmation DeleteConfirmation { get; set; }
    private string deleteID { get; set; }
    [Inject]
    public IToastService ToastService { get; set; }
    private bool Check = false;

    protected override async Task OnInitializedAsync()
    {
        _lstAll = await _specializedUPRepo.GetAll();
        _lstAll = _lstAll.Where(x => x.Level != 0 && x.Status == 0).ToList();
        await GetSpecializedUPList();
    }
    private async Task SelectedPage(int page)
    {
        _specializedListSearch.PageNumber = page;
        Check = false;
        await GetSpecializedUPList();
    }
    public async Task SearchSpecializedUP(SpecializedListSearch search)
    {
        _specializedListSearch = search;
        await GetSpecializedUPList();
    }
    private async Task GetSpecializedUPList()
    {
        try
        {
            var pagingResponse = await _specializedUPRepo.Gets(Guid.Empty, _specializedListSearch);
            _lstSpecializedUP = pagingResponse.Items;
            _lstSpecializedUP = _lstSpecializedUP.OrderBy(x => x.SpecializedCode).ToList();
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
            var result = await _specializedUPRepo.Delete(Guid.Empty, Guid.Parse(deleteID));
            if (result == 1)
            {
                ToastService.ShowSuccess("Đổi trạng thái chuyên ngành thành công", "Success");
                await GetSpecializedUPList();
            }
            else
            {
                ToastService.ShowError("Đổi trạng thái chuyên ngành thất bại", "Error");
            }
        }
    }

    public async Task OnConfirmationDelete(bool deleteconfirmed)
    {
        if (deleteconfirmed && deleteID == null && _removeSpecializedUP.Count == 0)
        {
            ToastService.ShowError("Bạn chưa chọn đối tượng để xóa");
            await GetSpecializedUPList();
            NavigationManager.NavigateTo($"/SpecializedUP");
        }
        else if (deleteconfirmed && deleteID != null)
        {
            var result = await _specializedUPRepo.Delete(Guid.Empty, Guid.Parse(deleteID));
            if (result == 1)
            {
                ToastService.ShowSuccess("Xóa thành công");
                deleteID = null;
                await GetSpecializedUPList();
                NavigationManager.NavigateTo($"/SpecializedUP");
            }
            else
            {
                ToastService.ShowError("Xóa thất bại");
                deleteID = null;
                await GetSpecializedUPList();
                NavigationManager.NavigateTo($"/SpecializedUP");
            }
        }
        else if (deleteconfirmed && _removeSpecializedUP != null)
        {

            //var result = await _specializedCPRepo.RemoveSpecializedCP(_removeSpecializedCP);
            //if (result)
            //{
            //    ToastService.ShowSuccess("Xóa thành công");
            //    deleteID = null;
            //    _removeSpecializedCP = null;
            //    await GetSpecializedCPList();
            //    NavigationManager.NavigateTo($"/SpecializedCP");
            //}
            //else
            //{
            //    ToastService.ShowError("Xóa thất bại");
            //    deleteID = null;
            //    _removeSpecializedCP = null;
            //    await GetSpecializedCPList();
            //    NavigationManager.NavigateTo($"/SpecializedCP");
            //}
        }
        else
        {
            deleteID = null;
            _removeSpecializedUP = null;
        }
        Check = false;
    }

    private void NavigateToSubjectUP(Guid id)
    {
        NavigationManager.NavigateTo($"/listsubjects/{id}");
    }
    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591