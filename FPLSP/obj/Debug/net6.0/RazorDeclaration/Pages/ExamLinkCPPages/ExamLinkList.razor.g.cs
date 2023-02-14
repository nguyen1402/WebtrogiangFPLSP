// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FPLSP.Pages.ExamLinkCPPages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
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
#line 2 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ExamLinkCPPages\ExamLinkList.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ExamLinkCPPages\ExamLinkList.razor"
using FPLSP.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ExamLinkCPPages\ExamLinkList.razor"
using FPLSP.Repositories.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ExamLinkCPPages\ExamLinkList.razor"
using FPLSP.Server.Data.SeedWork;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ExamLinkCPPages\ExamLinkList.razor"
using FPLSP.Server.Domain.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ExamLinkCPPages\ExamLinkList.razor"
using FPLSP.Server.Infrastructure.ViewModels.ExamLinks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ExamLinkCPPages\ExamLinkList.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/ExamLinkList")]
    public partial class ExamLinkList : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 113 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ExamLinkCPPages\ExamLinkList.razor"
       
    [Inject] private IExamLinkCPRepo _examLinkApiClient { get; set; }
    [Inject] public IToastService NotifiToastService { get; set; }
    [Inject] private IExamCPServicesRepo _examApiClient { get; set; }
    [Inject] private NavigationManager _navier { get; set; }

    private ExamLinkListSearchVm _examLinkListSearch;
    private List<ExamLinkDto> _lstdto;
    private List<Guid> _lstIDRemoveRange;
    public MetaData MetaData { get; set; } = new MetaData();

    protected Comfirmation DeleteConfirmation { get; set; }
    private bool Check = false;
    private Guid idExam;

    public ExamLinkList()
    {
        _examLinkListSearch = new ExamLinkListSearchVm();
        _lstdto = new List<ExamLinkDto>();
    }
    protected override async Task OnInitializedAsync()
    {
        await GetExams();
    }

    private async Task GetExams()
    {
        var pagingResponse = await _examLinkApiClient.GetExamLinkCPList(_examLinkListSearch);
        _lstdto = pagingResponse.Items;
        MetaData = pagingResponse.MetaData;
    }

    private async Task SelectedPage(int page)
    {
        _examLinkListSearch.PageNumber = page;
        await GetExams();
    }
    async void DeleteAll()
    {
        _lstIDRemoveRange = new List<Guid>();
        _lstIDRemoveRange = _lstdto.Where(c => c.IsChecked == true).Select(c => c.Id).ToList();
        DeleteConfirmation.show();
        await GetExams();
    }
    public async Task OnConfirmationDelete(bool deleteconfirmed)
    {
        if (deleteconfirmed && _lstIDRemoveRange.Count == 0)
        {
            NotifiToastService.ShowError("Bạn chưa chọn!");
            await GetExams();
            _navier.NavigateTo($"/ExamLinkList");
        }
        else if (deleteconfirmed && _lstIDRemoveRange != null)
        {
            foreach (var VARIABLE in _lstIDRemoveRange)
            {
                var result = await _examLinkApiClient.DeleteExamLinkCP(VARIABLE);
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
            _navier.NavigateTo($"/ExamLinkList");
            _lstIDRemoveRange = new List<Guid>();
        }
        Check = false;
    }

    public async Task Search(ExamLinkListSearchVm examLinkListSearch)
    {
        _examLinkListSearch = examLinkListSearch;
        await GetExams();
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


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591