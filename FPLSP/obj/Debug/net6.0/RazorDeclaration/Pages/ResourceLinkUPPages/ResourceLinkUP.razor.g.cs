// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FPLSP.Pages.ResourceLinkUPPages
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
#line 2 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ResourceLinkUPPages\ResourceLinkUP.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ResourceLinkUPPages\ResourceLinkUP.razor"
using FPLSP.Components.ResourceLinkUPComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ResourceLinkUPPages\ResourceLinkUP.razor"
using FPLSP.Repositories.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ResourceLinkUPPages\ResourceLinkUP.razor"
using FPLSP.Server.Data.SeedWork;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ResourceLinkUPPages\ResourceLinkUP.razor"
using FPLSP.Server.Domain.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ResourceLinkUPPages\ResourceLinkUP.razor"
using FPLSP.Server.Infrastructure.ViewModels.ResourceLinkUP;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/resourceLinkUP")]
    public partial class ResourceLinkUP : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 91 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ResourceLinkUPPages\ResourceLinkUP.razor"
       
    [Inject] private IResourceLinkUPRepo _ResourceLinkUPRepo { get; set; }
    [Inject] private IToastService _toastService { get; set; }
    [Inject] public NavigationManager navigationManager { get; set; }
    public MetaData MetaData { get; set; } = new MetaData();

    private List<ResourceLinkUPDto> _lstResourceLinkUPs = new List<ResourceLinkUPDto>();

    private List<Guid> _listRemove = new List<Guid>();

    private ResourceLinkUPListSearch _resourceLinkUPSearch = new ResourceLinkUPListSearch();

    private bool Check { get; set; }
    private string deleteID { get; set; }
    public string thongBao { get; set; } = "";
    private int _method { get; set; }

    protected Comfirmation DeleteConfirmation { get; set; }

    protected override async Task OnInitializedAsync()
    {
        await GetTasks();
    }
    void DeleteAll(int method)
    {
        _method = method;
        _listRemove = _lstResourceLinkUPs.Where(c => c.IsChecked == true).Select(c => c.Id).ToList();
        DeleteConfirmation.show();
    }
    public async Task SearchResourceLinkUP(ResourceLinkUPListSearch resourceLinkUPSearch)
    {
        _resourceLinkUPSearch = resourceLinkUPSearch;
        await GetTasks();
    }

    public void OnDelete(Guid id)
    {
        deleteID = id.ToString();
        DeleteConfirmation.show();
    }
    private async Task GetTasks()
    {
        try
        {
            var pagingResponse = await _ResourceLinkUPRepo.GetList(_resourceLinkUPSearch);
            _lstResourceLinkUPs = pagingResponse.Items;
            MetaData = pagingResponse.MetaData;
        }
        catch (Exception ex)
        {
            _toastService.ShowError("Đã xảy ra lỗi, thử lại sau");
        }
    }

    void CheckAllExpense(object checkValue)
    {
        if (Convert.ToBoolean(checkValue) == false)
        {
            _lstResourceLinkUPs.ToList().ForEach(e => e.IsChecked = false);
        }
        else
        {
            _lstResourceLinkUPs.ToList().ForEach(e => e.IsChecked = true);
        }
    }

    public async Task OnConfirmationDelete(bool deleteconfirmed)
    {

        if (deleteconfirmed && deleteID != null)
        {
            var result = await _ResourceLinkUPRepo.Delete(Guid.Parse(deleteID));
            if (result)
            {
                _toastService.ShowSuccess("Xóa thành công");
                await GetTasks();
            }
            else
            {
                _toastService.ShowError("Xóa thất bại");
                await GetTasks();
            }
        }
        else if (deleteconfirmed && _listRemove != null)
        {

            var result = await _ResourceLinkUPRepo.DeleteList(_method, _listRemove);
            if (result)
            {
                if (_listRemove.Count > 0)
                {

                    if (_method == 0)
                    {
                        thongBao = "Xóa";
                    }
                    else if (_method == 1)
                    {
                        thongBao = "Ngưng hoạt động";
                    }
                    _toastService.ShowSuccess($"{thongBao} {_listRemove.Count} bản ghi thành công");
                    await GetTasks();
                }
                else
                {
                    _toastService.ShowError($"Bạn chưa chọn video muốn {thongBao}");
                    await GetTasks();
                }

            }
            else
            {
                _toastService.ShowError($"{thongBao} thất bại");

                await GetTasks();
            }
        }
        deleteID = null;
        _listRemove = null;

        Check = false;
    }

    void CheckManual(Guid reportId, bool check)
    {
        if (check == true)
        {
            foreach (var x in _lstResourceLinkUPs.Where(c => c.Id == reportId))
            {
                x.IsChecked = false;
            }
        }
        if (check == false)
        {
            foreach (var x in _lstResourceLinkUPs.Where(c => c.Id == reportId))
            {
                x.IsChecked = true;
            }
        }
    }


    private async Task SelectedPage(int page)
    {
        Check = false;
        _resourceLinkUPSearch.PageNumber = page;
        await GetTasks();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
