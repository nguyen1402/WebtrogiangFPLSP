// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FPLSP.Pages.StudentUPPages
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
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\QuizThePoint.razor"
using FPLSP.Components.SearchMaSV;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\QuizThePoint.razor"
using FPLSP.Data.Securities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\QuizThePoint.razor"
using FPLSP.Repositories.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\QuizThePoint.razor"
using FPLSP.Server.Data.SeedWork;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\QuizThePoint.razor"
using FPLSP.Server.Domain.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\QuizThePoint.razor"
using FPLSP.Server.Domain.Dtos.StudentStatisticVM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\QuizThePoint.razor"
using FPLSP.Server.Infrastructure.ViewModels.StudentStatistics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\QuizThePoint.razor"
           [Authorize(Roles = "Student")]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/Quizthepoint/{idclassNonDecrypt}/{specializedIdNonDecrypt}/{lecuIdNonDecrypt}/{subjectIdNonDecrypt}")]
    public partial class QuizThePoint : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 176 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\QuizThePoint.razor"
 
    [Parameter]
    public string specializedIdNonDecrypt { get; set; }
    [Parameter]
    public string lecuIdNonDecrypt { get; set; }
    [Parameter]
    public string subjectIdNonDecrypt { get; set; }
    [Parameter]
    public string idclassNonDecrypt { get; set; }

    public string specializedId = "";

    public string lecuId = "";

    public string subjectId = "";

    public string idclass = "";


    private Thongtinlop thongtinlop = new Thongtinlop();
    private Thongtinlop listidlesson = new Thongtinlop();
    public string idstudent { get; set; }

    private List<SubmitHomeWorkDtos> _ls = new List<SubmitHomeWorkDtos>();

    public List<QuizSummit> Quiz = new List<QuizSummit>();
    public List<StudentStatisticsDtos> CPList { get; set; } = new List<StudentStatisticsDtos>();
    public MetaData MetaData { get; set; } = new MetaData();
    private List<SubmitHomeWorkDtos> _lsSubmit = new List<SubmitHomeWorkDtos>();
    private StudentStatisticListSearch _parameters = new StudentStatisticListSearch();
    [Inject]
    public NavigationManager NavigationManager { get; set; }
    [Inject]
    public IStudentUPRepo _iStudentUPRepo { get; set; }
    [Inject]
    public ISubmitHomeWorkApiClient _iSubmitHomeWorkApiClient { get; set; }
    [Parameter]
    public EventCallback<StudentStatisticListSearch> OnSearch { set; get; }
    public List<SpecializedDto> lstSpecAll { get; set; } = new List<SpecializedDto>();
    [Inject]
    public ISpecializedCPRepo _iSpecializedClient { get; set; }

    [Inject]
    public IClassSubjectApiClient _iClassSubjectApiClient { get; set; }
    int counttong;
    //private StudentStatisticListSearch lessonContentListSearch = new StudentStatisticListSearch();
    private int encounter;
    public string Error { get; set; }
    bool flag = false;
    [Inject]
    public CryptoServices _cryptoServices { get; set; }
    protected async override Task OnInitializedAsync()
    {
        lecuId = _cryptoServices.Decrypt(lecuIdNonDecrypt.Replace("I0H", "/"));
        subjectId = _cryptoServices.Decrypt(subjectIdNonDecrypt.Replace("I0H", "/"));
        idclass = _cryptoServices.Decrypt(idclassNonDecrypt.Replace("I0H", "/"));
        specializedId = _cryptoServices.Decrypt(specializedIdNonDecrypt.Replace("I0H", "/"));

        thongtinlop = await _iStudentUPRepo.Thongtinlop(Guid.Parse(idclass), Guid.Parse(subjectId));
        listidlesson = await _iStudentUPRepo.Thongtinlop(Guid.Parse(idclass), Guid.Parse(subjectId));
        counttong = await _iClassSubjectApiClient.Soluongsinhvientronglop(Guid.Parse(idclass), Guid.Parse(subjectId));
        await GetTasks();
    }
    public async Task SearchTask(StudentStatisticListSearch lessonContentListSearch)
    {
        flag = true;
        if (lessonContentListSearch.Masv == null)
        {
            listidlesson = new Thongtinlop();
            listidlesson = await _iStudentUPRepo.Thongtinlop(Guid.Parse(idclass), Guid.Parse(subjectId));
        }
        _parameters = lessonContentListSearch;
        await GetTasks();
    }

    private async Task Mon()
    {
        var url = Path.Combine($"/Giaovien/{specializedIdNonDecrypt}/{lecuIdNonDecrypt}/{subjectIdNonDecrypt}");
        NavigationManager.NavigateTo(url);
    }

    private async Task RedirectToBaiHoc()
    {
        var url = Path.Combine($"/ListLessonClassUP/{idclass}/{specializedId}/{lecuId}/{subjectId}");
        NavigationManager.NavigateTo(url);
    }
    private async Task RedirectToDetails()
    {
        var url = Path.Combine($"/ViewChiTitet/{idclassNonDecrypt}/{specializedIdNonDecrypt}/{lecuIdNonDecrypt}/{subjectIdNonDecrypt}");
        NavigationManager.NavigateTo(url);
    }
    private async Task RedirectToChitiet(Guid? idclass)
    {
        var url = Path.Combine($"/StudentStatisticsChitiet/{idclass}/{specializedId}/{lecuId}/{subjectId}");
        NavigationManager.NavigateTo(url);
    }
    private async Task Quaylai()
    {
        var url = Path.Combine($"/ViewChiTitet/{idclassNonDecrypt}/{specializedIdNonDecrypt}/{lecuIdNonDecrypt}/{subjectIdNonDecrypt}");
        NavigationManager.NavigateTo(url);
    }
    private async Task ResToSpec()
    {
        var url = Path.Combine($"/LectuterSpecializedSubjectls/{lecuIdNonDecrypt}/{specializedIdNonDecrypt}");
        NavigationManager.NavigateTo(url);
    }
    private async Task GetTasks()
    {
        try
        {
            flag = true;
            for (var i = 0; i < 15; i++)
            {
                encounter = i;
            }
            lstSpecAll = await _iSpecializedClient.GetAll();
            var pagingResponse = await _iStudentUPRepo.QuizStatisticsDtos(Guid.Parse(idclass), Guid.Parse(subjectId), _parameters);
            CPList = pagingResponse.Items;
            MetaData = pagingResponse.MetaData;
            _lsSubmit = await _iSubmitHomeWorkApiClient.GetALl();
            flag = false;
        }
        catch (Exception ex)
        {
            Error = ex.Message;
        }

    }


    private async Task SelectedPage(int page)
    {
        _parameters.PageNumber = page;
        await GetTasks();
    }

    public async Task SearchCode(string code)
    {
        _parameters.quizid = code;
        await GetTasks();
    }

    private async Task OnConfirmationUpdate(bool submitConfirmed)
    {
        if (submitConfirmed)
        {
            _ls.Clear();
        }
        else
        {
            _ls.Clear();
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591