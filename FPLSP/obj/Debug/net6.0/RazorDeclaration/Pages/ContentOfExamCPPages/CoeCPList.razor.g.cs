// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FPLSP.Pages.ContentOfExamCPPages
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
#line 2 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ContentOfExamCPPages\CoeCPList.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ContentOfExamCPPages\CoeCPList.razor"
using FPLSP.Repositories.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ContentOfExamCPPages\CoeCPList.razor"
using FPLSP.Server.Data.SeedWork;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ContentOfExamCPPages\CoeCPList.razor"
using FPLSP.Server.Domain.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ContentOfExamCPPages\CoeCPList.razor"
using FPLSP.Server.Infrastructure.ViewModels.ContentOfExamsCP;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/CoeCPList")]
    public partial class CoeCPList : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 187 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ContentOfExamCPPages\CoeCPList.razor"
        
    [Inject] private IContentOfExamCPRepo contentOfExamCPRepo { get; set; }
    [Inject] public IToastService NotifiToastService { get; set; }
    [Inject] private IExamCPServicesRepo examApiClient { get; set; }
    [Inject] private NavigationManager _navier { get; set; }
    private List<Guid> _lstIDRemoveRange;
    private bool Check = false;
    private CoeListSearchVm _listSearchVm = new CoeListSearchVm();
    private List<ContentOfExamCPDto> _lstdto;

    public MetaData MetaData { get; set; } = new MetaData();

    public Components.Comfirmation DeleteConfirmation { get; set; } = new Components.Comfirmation();

    private Guid Id;

    public CoeCPList()
    {
        _lstdto = new List<ContentOfExamCPDto>();
        _lstIDRemoveRange = new List<Guid>();
    }

    protected override async Task OnInitializedAsync()
    {
        await GetExams();
    }

    private async Task GetExams()
    {
        var pagingResponse = await contentOfExamCPRepo.GetCoeCPList(_listSearchVm);
        _lstdto = pagingResponse.Items;
        MetaData = pagingResponse.MetaData;
    }
    async void DeleteAll()
    {
        _lstIDRemoveRange = new List<Guid>();
        _lstIDRemoveRange = _lstdto.Where(c => c.IsChecked == true).Select(c => c.Id).ToList();
        DeleteConfirmation.show();
        await GetExams();
    }
    private async Task SelectedPage(int page)
    {
        _listSearchVm.PageNumber = page;
        await GetExams();
    }
    public async Task DeleteStuden(Guid id)
    {
        Id = id;
        DeleteConfirmation.show();
    }

    public async Task OnConfirmationDelete(bool deleteconfirmed)
    {
        //if (deleteconfirmed)
        //{
        //    await contentOfExamCPRepo.DeleteCoeCP(Id);
        //    await GetExams();
        //    _navier.NavigateTo($"/CoeCPList");
        //}

        if (deleteconfirmed && _lstIDRemoveRange.Count == 0)
        {
            NotifiToastService.ShowError("Bạn chưa chọn!");
            await GetExams();
            _navier.NavigateTo($"/CoeCPList");
        }
        else if (deleteconfirmed && _lstIDRemoveRange != null)
        {
            foreach (var VARIABLE in _lstIDRemoveRange)
            {
                var result = await contentOfExamCPRepo.DeleteCoeCP(VARIABLE);
                ;
                if (result)
                {
                    NotifiToastService.ShowSuccess("Xóa thành công");
                }
                else
                {
                    NotifiToastService.ShowError("Xóa thất bại");
                }
            }

            await GetExams();
            _navier.NavigateTo($"/CoeCPList");
            _lstIDRemoveRange = new List<Guid>();
        }
        Check = false;
    }
    public async Task Delete(Guid id)
    {
        _lstIDRemoveRange = new List<Guid>();
        _lstIDRemoveRange.Add(id);
        DeleteConfirmation.show();
        await GetExams();
        Check = false;
    }
    void CheckManual(Guid reportId, bool check)
    {

        if (check == true)
        {
            foreach (var x in _lstdto.Where(c => c.Id == reportId))
            {
                x.IsChecked = false;
            }
        }
        if (check == false)
        {
            foreach (var x in _lstdto.Where(c => c.Id == reportId))
            {
                x.IsChecked = true;
            }
        }
    }
    void CheckAllExpense(object checkValue)
    {

        if (Convert.ToBoolean(checkValue) == false)
        {
            _lstdto.ToList().ForEach(e => e.IsChecked = false);
        }
        else
        {
            _lstdto.ToList().ForEach(e => e.IsChecked = true);
        }
    }
    public async Task Search(CoeListSearchVm coeListSearchVm)
    {
        _listSearchVm = coeListSearchVm;
        await GetExams();
    }



#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
