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
#line 2 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\ViewChiTiet.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\ViewChiTiet.razor"
using FPLSP.Components.SearchMaSV;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\ViewChiTiet.razor"
using FPLSP.Data.Securities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\ViewChiTiet.razor"
using FPLSP.Repositories.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\ViewChiTiet.razor"
using FPLSP.Server.Data.SeedWork;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\ViewChiTiet.razor"
using FPLSP.Server.Domain.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\ViewChiTiet.razor"
using FPLSP.Server.Domain.Dtos.StudentStatisticVM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\ViewChiTiet.razor"
using FPLSP.Server.Domain.Dtos.StudentUPDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\ViewChiTiet.razor"
using FPLSP.Server.Domain.Entities.UserParts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\ViewChiTiet.razor"
using FPLSP.Server.Infrastructure.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\ViewChiTiet.razor"
using FPLSP.Server.Infrastructure.ViewModels.GiaoVienTaoLop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\ViewChiTiet.razor"
using FPLSP.Server.Infrastructure.ViewModels.LecturerCPVm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\ViewChiTiet.razor"
using FPLSP.Server.Infrastructure.ViewModels.NewFeed;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\ViewChiTiet.razor"
using FPLSP.Server.Infrastructure.ViewModels.StudentStatistics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\ViewChiTiet.razor"
using FPLSP.Server.Infrastructure.ViewModels.StudentsUPVm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\ViewChiTiet.razor"
using FPLSP.Server.Infrastructure.ViewModels.Subject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\ViewChiTiet.razor"
           [Authorize(Roles = "LecturerFPLSP")]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/ViewChiTitet/{idclassNonDecrypt}/{specializedIdNonDecrypt}/{lecuIdNonDecrypt}/{subjectIdNonDecrypt}")]
    public partial class ViewChiTiet : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 629 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\ViewChiTiet.razor"
 
    protected PopUpConfirm DeleConfirmation { set; get; }
    public async Task OnConfirmationDelete(bool deleteconfirmed)
    {
        if (deleteconfirmed)
        {
            await Remove();
        }
    }
    private async Task Removes()
    {
        //var x = _lststudentUpDtosALL.Where(c => c.IsChecked == true).ToList();
        ConfirmationTitle = $"Bạn có chắc muốn xóa sinh viên ra khỏi lớp học";
        DeleConfirmation.show();
    }
    [Parameter]
    public string ConfirmationTitle { get; set; }
    [Parameter]
    public string specializedIdNonDecrypt { get; set; }
    [Parameter]
    public string lecuIdNonDecrypt { get; set; }
    [Parameter]
    public string subjectIdNonDecrypt { get; set; }
    [Parameter]
    public string idclassNonDecrypt { get; set; }
    private Thongtinlop thongtinlop = new Thongtinlop();

    private Thongtinlop listidlesson = new Thongtinlop();
    public string specializedId = "";

    public string lecuId = "";

    public string subjectId = "";

    public string idclass = "";

    public string idstudent { get; set; }

    public string joicode { get; set; }
    public string joicodeNonDecrypt { get; set; }
    [Inject]
    public ILecturersCPRepo _LecturersCPRepo { get; set; }

    public LecturersCPViewModel lecturersCP { get; set; } = new LecturersCPViewModel();

    public List<StudentStatisticsDtos> CPList { get; set; } = new List<StudentStatisticsDtos>();
    public List<StudentStatisticsDtos> CPListQuiz { get; set; } = new List<StudentStatisticsDtos>();

    private SubjectListSearch SubjectListSearch = new SubjectListSearch();

    public List<SubjectDto> SubjectUPList { get; set; } = new List<SubjectDto>();
    public ListIdQuiz _listIdQuizzes = new ListIdQuiz();

    ViewHomeworkStudents viewHomeworkStudents { get; set; }
    [Inject]
    public IStudentUPRepo _studentUPRepo { get; set; }

    List<NewFeedOverView> _lstNews;

    [Inject]
    public IStudentClassUPRepo _reportClassUPRepo { get; set; }
    private List<SubmitHomeWorkDtos> _ls = new List<SubmitHomeWorkDtos>();
    [Inject] private IToastService _toastService { get; set; }
    public List<QuizSummit> Quiz = new List<QuizSummit>();
    public SubjectClassUP TTLop { get; set; } = new SubjectClassUP();
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
    public IStudentQuizUPRepo _studentQuizUPRepo { get; set; }
    [Inject]
    public ISubmitHomeWorkApiClient _IsubmitHomeWorkApiClient { get; set; }
    public List<SubjectClassUP> _lstSubjectClassUPsAll { get; set; } = new List<SubjectClassUP>();
    [Inject]
    public IClassSubjectApiClient _iClassSubjectApiClient { get; set; }

    [Inject] public ISubjectUPRepo _subjectUPRepo { get; set; }
    int counttong;
    int maxlop;
    [Inject]
    public CryptoServices _cryptoServices { get; set; }
    //private StudentStatisticListSearch lessonContentListSearch = new StudentStatisticListSearch();
    private int encounter;
    private int counttailieu { get; set; }
    public string Error { get; set; }
    bool flag = false;
    private bool Check = false;
    public List<StudentUpDto> _lststudentUpDtosALL { get; set; } = new List<StudentUpDto>();

    public List<StudentUpDto> _liststudentClassJoin { get; set; } = new List<StudentUpDto>();
    public List<StudentClassUP> _studentClassUPDtos { get; set; } = new List<StudentClassUP>();
    public List<SubjectClassUP> _lstsubjectClassUPs { get; set; } = new List<SubjectClassUP>();
    public List<ClassUp> _lstClassUps { get; set; } = new List<ClassUp>();
    public List<StudentUpDto> _lstStudentUpDtosExist { get; set; } = new List<StudentUpDto>();
    public List<StudentUpDto> _lstStudentUpDtosShow { get; set; } = new List<StudentUpDto>();
    private StudentUPListSearchVm studentUPListSearchVm = new StudentUPListSearchVm();

    //kho tài liệu
    private bool _isNotLecturer { get; set; }

    [Inject] private INewFeedRepo _newFeedRepo { get; set; }
    [Inject]
    private ITaskRepositories<ClassUPViewModel> _classRepositories { get; set; }
    CreateClassVM classSearch = new CreateClassVM();
    protected async override Task OnInitializedAsync()
    {

        lecuId = _cryptoServices.Decrypt(lecuIdNonDecrypt.Replace("I0H", "/"));
        subjectId = _cryptoServices.Decrypt(subjectIdNonDecrypt.Replace("I0H", "/"));
        idclass = _cryptoServices.Decrypt(idclassNonDecrypt.Replace("I0H", "/"));
        specializedId = _cryptoServices.Decrypt(specializedIdNonDecrypt.Replace("I0H", "/"));
        listidlesson = await _iStudentUPRepo.Thongtinlop(Guid.Parse(idclass), Guid.Parse(subjectId));
        counttong = await _iClassSubjectApiClient.Soluongsinhvientronglop(Guid.Parse(idclass), Guid.Parse(subjectId));
        _lstSubjectClassUPsAll = await _iClassSubjectApiClient.GetAllSubjectClass();
        joicode = _lstSubjectClassUPsAll.Where(c => c.SubjectId == Guid.Parse(subjectId) && c.ClassId == Guid.Parse(idclass)).Select(c => c.JoinCode).FirstOrDefault();
        joicodeNonDecrypt = _cryptoServices.Encrypt(joicode).Replace("/", "I0H");
        maxlop = _lstSubjectClassUPsAll.Where(c => c.SubjectId == Guid.Parse(subjectId) && c.ClassId == Guid.Parse(idclass)).Select(c => c.StudentAmount).FirstOrDefault();
        var pagingResponse = await _iClassSubjectApiClient.GetAllSubjectClass();
        TTLop = pagingResponse.Where(c => c.JoinCode == joicode).FirstOrDefault();
        lecturersCP = await _LecturersCPRepo.GetLecturerListById(Guid.Parse(lecuId));
        await GetTasks();
        ///sinh viên
        _lststudentUpDtosALL = new List<StudentUpDto>();
        studentUPListSearchVm = new StudentUPListSearchVm();
        _lstStudentUpDtosShow = new List<StudentUpDto>();
        _lstsubjectClassUPs = await _iClassSubjectApiClient.GetAllSubjectClass();
        await GetTasksSinhvien();


        ///bài tập
        lstSpecAll = await _iSpecializedClient.GetAll();
        _lsSubmit = await _iSubmitHomeWorkApiClient.GetALl();
        await GetTasksBaitap();
        await GetTasksQuiz();

        //kho tài liệu
        await GetKhotailieu();
    }

    public async Task GetKhotailieu()
    {
        classSearch = await _classRepositories.GetClassById(joicode);
        _lstNews = await _newFeedRepo.GetListNewForClass(classSearch.Id, classSearch.SubjectId);
        counttailieu = _lstNews.Where(c => c.Image == "Resource").OrderBy(c => c.CratedTime).Count();
        await CheckUser(classSearch.HomeroomLecturerId, Guid.Parse(lecuId));
    }
    private async Task RedirectToBaiHoc()
    {
        var url = Path.Combine($"/ListLessonClassUP/{idclass}/{specializedId}/{lecuId}/{subjectId}");
        NavigationManager.NavigateTo(url);
    }

    private async Task RedirectToChitiet(string idclass)
    {
        var url = Path.Combine($"/StudentStatisticsChitiet/{idclass}/{specializedIdNonDecrypt}/{lecuIdNonDecrypt}/{subjectIdNonDecrypt}");
        NavigationManager.NavigateTo(url);
    }
    private async Task Quaylai()
    {
        var url = Path.Combine($"/Giaovien/{specializedIdNonDecrypt}/{lecuIdNonDecrypt}/{subjectIdNonDecrypt}");
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
            for (var i = 0; i < 15; i++)
            {
                encounter = i;
            }

            thongtinlop = await _iStudentUPRepo.Thongtinlop(Guid.Parse(idclass), Guid.Parse(subjectId));

        }
        catch (Exception ex)
        {
            Error = ex.Message;
        }

    }


    //private async Task SelectedPage(int page)
    //{
    //    _parameters.PageNumber = page;
    //    await GetTasks();
    //}



    private async void OnButton(string idclass1, string subjectId, string idlesoon, string idstudent1)
    {
        viewHomeworkStudents.show(idclass1, subjectId, idlesoon, idstudent1);
        //idclass1 = idclass;
    }
    private async Task pushTextAre(string idclass1)
    {
        idclass1 = idclass;
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
    private async Task RedirectToChitiet()
    {

        var url = Path.Combine($"/StudentStatisticsChitiet/{idclassNonDecrypt}/{specializedIdNonDecrypt}/{lecuIdNonDecrypt}/{subjectIdNonDecrypt}");
        NavigationManager.NavigateTo(url);
    }

    private async Task RedirectToDIem()
    {

        var url = Path.Combine($"/Quizthepoint/{idclassNonDecrypt}/{specializedIdNonDecrypt}/{lecuIdNonDecrypt}/{subjectIdNonDecrypt}");
        NavigationManager.NavigateTo(url);
    }
    private async Task RedirectToDetails()
    {
        var url = Path.Combine($"/ViewChiTitet/{idclassNonDecrypt}/{specializedIdNonDecrypt}/{lecuIdNonDecrypt}/{subjectIdNonDecrypt}");
        NavigationManager.NavigateTo(url);
    }
    private async Task Thongtinsinhvien()
    {
        var url = Path.Combine($"/DetailsClassLeccu/{idclassNonDecrypt}/{specializedIdNonDecrypt}/{lecuIdNonDecrypt}/{subjectIdNonDecrypt}");
        NavigationManager.NavigateTo(url);
    }
    private async Task RedirectToKho()
    {
        var url = Path.Combine($"/news/{joicodeNonDecrypt}/{lecuIdNonDecrypt}/{subjectIdNonDecrypt}/{specializedIdNonDecrypt}/{idclassNonDecrypt}");
        NavigationManager.NavigateTo(url);
    }
    /// <summary>
    /// Thông tin sinh viên
    /// </summary>
    /// <returns></returns>

    public MetaData MetaDataSinhvien { get; set; } = new MetaData();
    private async Task GetTasksSinhvien()
    {
        try
        {
            var SubjectUPListpagingResponse1 = await _subjectUPRepo.GetSubjects(Guid.Parse(specializedId), SubjectListSearch);
            SubjectUPList = SubjectUPListpagingResponse1.Items;
            lstSpecAll = await _iSpecializedClient.GetAll();
            _studentClassUPDtos = await _reportClassUPRepo.GetAllStudentUPAsync();
            var pagingResponse = await _studentUPRepo.GetStudentUPList(studentUPListSearchVm);
            var items = await _studentUPRepo.GetAllStudentDtosAsync();
            _lstClassUps = await _iClassSubjectApiClient.GetlstClassUP(Guid.Parse(subjectId));


            _listIdQuizzes = await _iClassSubjectApiClient.GetListIDQuiz(Guid.Parse(subjectId));

            var joicode = _lstsubjectClassUPs.Where(c => c.SubjectId == Guid.Parse(subjectId) && c.ClassId == Guid.Parse(idclass)).Select(c => c.JoinCode).FirstOrDefault();

            var lstGuidIdClass = _studentClassUPDtos.Where(c => c.ClassId == Guid.Parse(idclass) && c.JoinCodeAsign == joicode).Select(c => c.StudentId).ToList();

            _lststudentUpDtosALL = items.Where(c => lstGuidIdClass.Contains(c.Id)).ToList();
            //MetaData = new MetaData()
            //    {
            //        TotalCount = _lststudentUpDtosALL.Count(),
            //        PageSize = studentUPListSearchVm.PageSize,
            //        CurrentPage = studentUPListSearchVm.PageNumber,
            //        TotalPages = (int)Math.Ceiling(_lststudentUpDtosALL.Count() / (double)studentUPListSearchVm.PageSize)
            //    };
            foreach (var item in _lststudentUpDtosALL.Where(c => c.StudentName == null).ToList())
            {
                _lststudentUpDtosALL.Remove(item);
            }
            if (string.IsNullOrEmpty(studentUPListSearchVm.Status) == false)
            {
                _lststudentUpDtosALL = _lststudentUpDtosALL.Where(x => x.Status == Convert.ToInt32(studentUPListSearchVm.Status)).ToList();
            }
            if (studentUPListSearchVm.NameStudent != null)
            {
                _lststudentUpDtosALL = _lststudentUpDtosALL.Where(x => x.StudentName.ToLower().Contains(studentUPListSearchVm.NameStudent.ToLower()) || x.StudentCode.ToLower().Contains(studentUPListSearchVm.NameStudent.ToLower())).ToList();
            }

            var data = _lststudentUpDtosALL.Skip((studentUPListSearchVm.PageNumber - 1) * studentUPListSearchVm.PageSize).Take(studentUPListSearchVm.PageSize).ToList();
            var lstpage = new PageList<StudentUpDto>(data,
                _lststudentUpDtosALL.Count(),
                studentUPListSearchVm.PageNumber,
                studentUPListSearchVm.PageSize);
            _lststudentUpDtosALL = lstpage.Items;
            MetaDataSinhvien = lstpage.MetaData;
        }
        catch (Exception ex)
        {
            Error = ex.Message;
        }
    }
    private async Task Remove()
    {

        var joicode = _lstsubjectClassUPs.Where(c => c.SubjectId == Guid.Parse(subjectId) && c.ClassId == Guid.Parse(idclass)).Select(c => c.JoinCode).FirstOrDefault();
        foreach (var x in _lststudentUpDtosALL.Where(c => c.IsChecked == true).ToList())
        {

            if (_studentClassUPDtos.Any(c => c.JoinCodeAsign == joicode && c.StudentId == x.Id))
            {
                _reportClassUPRepo.DeleteStudentUP(joicode, x.Id);
                _IsubmitHomeWorkApiClient.DeleteSubmit(Guid.Parse(idclass), Guid.Parse(subjectId), x.Id);
            }
            foreach (var quiz in _listIdQuizzes.idquiz)
            {
                _studentQuizUPRepo.Delete(x.Id, quiz);
            }

        }
        _toastService.ShowSuccess("Xóa thành công " + _lststudentUpDtosALL.Where(c => c.IsChecked == true).ToList().Count() + " sinh viên");
        await GetTasksSinhvien();
        await GetTasksBaitap();
        await GetTasksQuiz();
        thongtinlop = await _iStudentUPRepo.Thongtinlop(Guid.Parse(idclass), Guid.Parse(subjectId));
        counttong = await _iClassSubjectApiClient.Soluongsinhvientronglop(Guid.Parse(idclass), Guid.Parse(subjectId));
        maxlop = _lstSubjectClassUPsAll.Where(c => c.SubjectId == Guid.Parse(subjectId) && c.ClassId == Guid.Parse(idclass)).Select(c => c.StudentAmount).FirstOrDefault();
        //var url = Path.Combine($"/DetailsClassLeccu/{idClassNonDecrypt}/{specializedIdNonDecrypt}/{lecuIdNonDecrypt}/{subjectIdNonDecrypt}");
        //Navigation.NavigateTo(url);
    }
    void CheckAllExpense(object checkValue)
    {
        if (Convert.ToBoolean(checkValue) == false)
        {
            _lststudentUpDtosALL.ToList().ForEach(e => e.IsChecked = false);
        }
        else
        {
            _lststudentUpDtosALL.ToList().ForEach(e => e.IsChecked = true);
        }
    }
    void CheckManual(Guid st, bool check)
    {
        if (check == true)
        {
            foreach (var x in _lststudentUpDtosALL.Where(c => c.Id == st))
            {
                x.IsChecked = false;
            }
        }
        if (check == false)
        {
            foreach (var x in _lststudentUpDtosALL.Where(c => c.Id == st))
            {
                x.IsChecked = true;
            }
        }

    }


    private async Task SelectedPageSinhvien(int page)
    {
        studentUPListSearchVm.PageNumber = page;
        Check = false;
        await GetTasksSinhvien();
    }
    public async Task SearchStudentUP(StudentUPListSearchVm studentUPListSearch)
    {
        studentUPListSearchVm = studentUPListSearch;
        await GetTasksSinhvien();
    }
    private async Task AddStudentInClass()
    {
        var url = Path.Combine($"/AddStudentInClass/{idclassNonDecrypt}/{specializedIdNonDecrypt}/{lecuIdNonDecrypt}/{subjectIdNonDecrypt}");
        NavigationManager.NavigateTo(url);
    }
    /// Bài tập về nhà
    /// <summary>
    /// Bài tập về nhà
    /// </summary>
    /// <returns></returns>
    ///
    public MetaData MetaDataBaitap { get; set; } = new MetaData();

    private async Task GetTasksBaitap()
    {
        try
        {
            flag = true;
            for (var i = 0; i < 15; i++)
            {
                encounter = i;
            }
            var pagingResponse = await _iStudentUPRepo.StudentStatisticsDtos(Guid.Parse(idclass), Guid.Parse(subjectId), _parameters);
            CPList = pagingResponse.Items;
            MetaDataBaitap = pagingResponse.MetaData;
            flag = false;
        }
        catch (Exception ex)
        {
            Error = ex.Message;
        }

    }


    private async Task SelectedPageBaitap(int page)
    {
        _parameters.PageNumber = page;
        await GetTasksBaitap();
    }

    public async Task SearchCodeBaitap(string code)
    {
        _parameters.trangthai = code;
        await GetTasksBaitap();
    }
    public async Task SearchTaskBaitap(StudentStatisticListSearch lessonContentListSearch)
    {
        flag = true;
        if (lessonContentListSearch.Masv == null)
        {
            listidlesson = new Thongtinlop();
            listidlesson = await _iStudentUPRepo.Thongtinlop(Guid.Parse(idclass), Guid.Parse(subjectId));
        }
        _parameters = lessonContentListSearch;
        await GetTasksBaitap();
    }
    private async Task Mon()
    {
        var url = Path.Combine($"/Giaovien/{specializedIdNonDecrypt}/{lecuIdNonDecrypt}/{subjectIdNonDecrypt}");
        NavigationManager.NavigateTo(url);
    }
    ///Quiz
    public MetaData MetaDataQuiz { get; set; } = new MetaData();
    private async Task SelectedPageQuiz(int page)
    {
        _parameters.PageNumber = page;
        await GetTasksQuiz();
    }
    public async Task SearchCodeQuiz(string code)
    {
        _parameters.quizid = code;
        await GetTasksQuiz();
    }
    public async Task SearchCodeQuiz(StudentStatisticListSearch lessonContentListSearch)
    {
        flag = true;
        if (lessonContentListSearch.Masv == null)
        {
            listidlesson = new Thongtinlop();
            listidlesson = await _iStudentUPRepo.Thongtinlop(Guid.Parse(idclass), Guid.Parse(subjectId));
        }
        _parameters = lessonContentListSearch;
        await GetTasksQuiz();
    }
    public async Task SelectedQuiz(string code)
    {
        _parameters.quizid = code;
        await GetTasksQuiz();
    }
    private async Task GetTasksQuiz()
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
            CPListQuiz = pagingResponse.Items;
            MetaDataQuiz = pagingResponse.MetaData;
            _lsSubmit = await _iSubmitHomeWorkApiClient.GetALl();
            flag = false;
        }
        catch (Exception ex)
        {
            Error = ex.Message;
        }

    }
    ///Kho tài liệu
    ///
    private async Task CheckUser(Guid idLecturer, Guid idUserInput)
    {
        _isNotLecturer = (idLecturer != idUserInput);

        if (_isNotLecturer)
        {
            _lstNews = _lstNews.Where(c => c.Status == 0).ToList();
        }
    }

    protected async Task ShowOrHide(Guid idNews)
    {
        var newsSearch = _lstNews.Where(c => c.Id == idNews).FirstOrDefault();

        if (newsSearch.Status == 0)
        {
            newsSearch.Status = 1;
        }
        else
        {
            newsSearch.Status = 0;
        }

        await Update(idNews, newsSearch);
    }

    private async Task Update(Guid idNews, NewFeedOverView newFeedOverView)
    {
        var res = await _newFeedRepo.UpdateNewFeed(idNews, new NewFeedVM()
            {
                Id = newFeedOverView.Id,
                Title = newFeedOverView.Title,
                Content = newFeedOverView.Content,
                IdLesson = newFeedOverView.IdLesson,
                Image = newFeedOverView.Image,
                Status = newFeedOverView.Status,
                CratedTime = newFeedOverView.CratedTime,
                EndDate = newFeedOverView.EndDate,
                Priority = newFeedOverView.Priority,
                IsReaded = newFeedOverView.IsReaded,
                IdUser = newFeedOverView.IdUser,
                IdClass = newFeedOverView.IdClass,
                IdSubject = newFeedOverView.IdSubject,
                IdTypeOfNewFeed = newFeedOverView.IdTypeOfNewFeed,
            });
        if (res)
        {
            _toastService.ShowSuccess($"Cập Nhật link tài nguyên thành công");
            await this.OnInitializedAsync();
        }
        else
        {
            _toastService.ShowError($"Cập Nhật link tài nguyên thất bại");
            await this.OnInitializedAsync();
        }
    }
    private async Task RedirectToAddTaiLieu()
    {
        var url = Path.Combine($"/resoucrelinkforstudent/{joicodeNonDecrypt}/{idclassNonDecrypt}/{specializedIdNonDecrypt}/{lecuIdNonDecrypt}/{subjectIdNonDecrypt}");
        NavigationManager.NavigateTo(url);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591