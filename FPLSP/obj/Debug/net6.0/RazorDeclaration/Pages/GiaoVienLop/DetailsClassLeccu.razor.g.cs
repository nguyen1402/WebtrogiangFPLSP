// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FPLSP.Pages.GiaoVienLop
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
#line 2 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\GiaoVienLop\DetailsClassLeccu.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\GiaoVienLop\DetailsClassLeccu.razor"
using FPLSP.Components.StudentCPComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\GiaoVienLop\DetailsClassLeccu.razor"
using FPLSP.Data.Securities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\GiaoVienLop\DetailsClassLeccu.razor"
using FPLSP.Repositories.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\GiaoVienLop\DetailsClassLeccu.razor"
using FPLSP.Server.Data.SeedWork;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\GiaoVienLop\DetailsClassLeccu.razor"
using FPLSP.Server.Domain.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\GiaoVienLop\DetailsClassLeccu.razor"
using FPLSP.Server.Domain.Dtos.StudentUPDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\GiaoVienLop\DetailsClassLeccu.razor"
using FPLSP.Server.Domain.Entities.UserParts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\GiaoVienLop\DetailsClassLeccu.razor"
using FPLSP.Server.Infrastructure.Services.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\GiaoVienLop\DetailsClassLeccu.razor"
using FPLSP.Server.Infrastructure.ViewModels.GiaoVienTaoLop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\GiaoVienLop\DetailsClassLeccu.razor"
using FPLSP.Server.Infrastructure.ViewModels.StudentClassUPVm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\GiaoVienLop\DetailsClassLeccu.razor"
using FPLSP.Server.Infrastructure.ViewModels.StudentQuizUPVm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\GiaoVienLop\DetailsClassLeccu.razor"
using FPLSP.Server.Infrastructure.ViewModels.StudentsUPVm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\GiaoVienLop\DetailsClassLeccu.razor"
using FPLSP.Server.Infrastructure.ViewModels.Subject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\GiaoVienLop\DetailsClassLeccu.razor"
           [Authorize(Roles = "LecturerFPLSP")]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/DetailsClassLeccu/{idClassNonDecrypt}/{specializedIdNonDecrypt}/{lecuIdNonDecrypt}/{subjectIdNonDecrypt}")]
    public partial class DetailsClassLeccu : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 118 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\GiaoVienLop\DetailsClassLeccu.razor"
       
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
        DeleConfirmation.show();
    }
    [Parameter]
    public string idClassNonDecrypt { get; set; }
    [Parameter]
    public string specializedIdNonDecrypt { get; set; }
    [Parameter]
    public string lecuIdNonDecrypt { get; set; }
    [Parameter]
    public string subjectIdNonDecrypt { get; set; }


    public string idClass = "";

    public string specializedId = "";
    
    public string lecuId = "";
    
    public string subjectId = "";


    [Parameter]
    public string Error { get; set; }
    [Inject]
public IStudentUPRepo _studentUPRepo { get; set; }

    [Inject]
    public IStudentClassUPRepo _reportClassUPRepo { get; set; }
    [Inject]
    public IStudentQuizUPRepo _studentQuizUPRepo { get; set; }
    [Inject]
    public ICopySubjectInClassRepo ICopySubjectInClassRepo { get; set; }

    [Inject]
    public ISubmitHomeWorkApiClient _IsubmitHomeWorkApiClient { get; set; }

    [Inject]
    public NavigationManager Navigation { get; set; }
    [Inject]
    public IClassSubjectApiClient _iClassSubjectApiClient { get; set; }
    [Inject] private IToastService _toastService { get; set; }
    private int encounter;
    private SubjectClassVM subjectClassVM { get; set; } = new SubjectClassVM();

    public List<StudentUpDto> _lststudentUpDtosALL { get; set; } = new List<StudentUpDto>();

    public List<StudentUpDto> _liststudentClassJoin { get; set; } = new List<StudentUpDto>();
    public List<StudentClassUP> _studentClassUPDtos { get; set; } = new List<StudentClassUP>();
    public List<SubjectClassUP> _lstsubjectClassUPs { get; set; } = new List<SubjectClassUP>();
    public List<ClassUp> _lstClassUps { get; set; } = new List<ClassUp>();
    public List<StudentUpDto> _lstStudentUpDtosExist { get; set; } = new List<StudentUpDto>();
    public List<StudentUpDto> _lstStudentUpDtosShow { get; set; } = new List<StudentUpDto>();
    public List<Guid?> lstGuidIdStudent { get; set; } = new List<Guid?>();



    public ListIdQuiz _listIdQuizzes = new ListIdQuiz();
    private StudentUPListSearchVm studentUPListSearchVm = new StudentUPListSearchVm();
    private StudentClassUPCreateVm _studentClassUPCreateVm = new StudentClassUPCreateVm();
    private StudentQuizCreateUPVM _studentQuizCreateUPVM = new StudentQuizCreateUPVM();
    private Random random = new Random();
    private bool Check = false;


    public bool ShowAuthError { get; set; }

    public MetaData MetaData { get; set; } = new MetaData();

    public List<SpecializedDto> lstSpecAll { get; set; } = new List<SpecializedDto>();
    [Inject]
    public ISpecializedCPRepo _iSpecializedClient { get; set; }

    [Inject] public ISubjectUPRepo _subjectUPRepo { get; set; }
    public List<SubjectDto> SubjectUPList { get; set; } = new List<SubjectDto>();
    private SubjectListSearch SubjectListSearch = new SubjectListSearch();
    [Inject]
    public CryptoServices _cryptoServices { get; set; }
    protected async override Task OnInitializedAsync()
    {
        lecuId = _cryptoServices.Decrypt(lecuIdNonDecrypt.Replace("I0H", "/"));
        subjectId = _cryptoServices.Decrypt(subjectIdNonDecrypt.Replace("I0H", "/"));
        idClass = _cryptoServices.Decrypt(idClassNonDecrypt.Replace("I0H", "/"));
        specializedId = _cryptoServices.Decrypt(specializedIdNonDecrypt.Replace("I0H", "/"));

        _lststudentUpDtosALL = new List<StudentUpDto>();
        studentUPListSearchVm = new StudentUPListSearchVm();
        _lstStudentUpDtosShow = new List<StudentUpDto>();
_lstsubjectClassUPs = await _iClassSubjectApiClient.GetAllSubjectClass();
        await GetTasks();
    }

    private async Task GetTasks()
    {
        try
        {
            for (var i = 0; i < 15; i++)
            {
                encounter = i;
            }
            var SubjectUPListpagingResponse1 = await _subjectUPRepo.GetSubjects(Guid.Parse(specializedId), SubjectListSearch);
            SubjectUPList = SubjectUPListpagingResponse1.Items;
            lstSpecAll = await _iSpecializedClient.GetAll();
            _studentClassUPDtos = await _reportClassUPRepo.GetAllStudentUPAsync();
            var pagingResponse = await _studentUPRepo.GetStudentUPList(studentUPListSearchVm);
            var items = await _studentUPRepo.GetAllStudentDtosAsync();
            _lstClassUps = await _iClassSubjectApiClient.GetlstClassUP(Guid.Parse(subjectId));


            _listIdQuizzes = await _iClassSubjectApiClient.GetListIDQuiz(Guid.Parse(subjectId));

            var joicode = _lstsubjectClassUPs.Where(c => c.SubjectId == Guid.Parse(subjectId) && c.ClassId == Guid.Parse(idClass)).Select(c => c.JoinCode).FirstOrDefault();

            var lstGuidIdClass = _studentClassUPDtos.Where(c => c.ClassId == Guid.Parse(idClass) && c.JoinCodeAsign == joicode).Select(c => c.StudentId).ToList();

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
MetaData = lstpage.MetaData;
        }
        catch (Exception ex)
        {
            Error = ex.Message;
        }
    }
    private async Task RedirectToChitiet(Guid? idclass, Guid? subjectId)
    {
        var url = Path.Combine($"/ViewChiTitet/{idclass}/{specializedId}/{lecuId}/{subjectId}");
        Navigation.NavigateTo(url);
    }
    private async Task SelectedPage(int page)
    {
        studentUPListSearchVm.PageNumber = page;
        Check = false;
        await GetTasks();
    }

    private async Task Remove()
    {

        var joicode = _lstsubjectClassUPs.Where(c => c.SubjectId == Guid.Parse(subjectId) && c.ClassId == Guid.Parse(idClass)).Select(c => c.JoinCode).FirstOrDefault();
        foreach (var x in _lststudentUpDtosALL.Where(c => c.IsChecked == true).ToList())
        {

            if (_studentClassUPDtos.Any(c => c.JoinCodeAsign == joicode && c.StudentId == x.Id))
            {
                _reportClassUPRepo.DeleteStudentUP(joicode, x.Id);
                _IsubmitHomeWorkApiClient.DeleteSubmit(Guid.Parse(idClass), Guid.Parse(subjectId), x.Id);
            }
            //foreach (var quiz in _listIdQuizzes.idquiz)
            //{
            //    _studentQuizUPRepo.Delete(x.Id, quiz);
            //}

        }
        _toastService.ShowSuccess("Xóa thành công " + _lststudentUpDtosALL.Where(c => c.IsChecked == true).ToList().Count() + " sinh viên");
        await GetTasks();
        var url = Path.Combine($"/DetailsClassLeccu/{idClassNonDecrypt}/{specializedIdNonDecrypt}/{lecuIdNonDecrypt}/{subjectIdNonDecrypt}");
        Navigation.NavigateTo(url);
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
    private async Task ResToSpec()
    {
        var url = Path.Combine($"/LectuterSpecializedSubjectls/{lecuIdNonDecrypt}/{specializedIdNonDecrypt}");
        Navigation.NavigateTo(url);
    }
    private async Task Quaylai()
    {
        var url = Path.Combine($"/ViewChiTitet/{idClassNonDecrypt}/{specializedIdNonDecrypt}/{lecuIdNonDecrypt}/{subjectIdNonDecrypt}");
        Navigation.NavigateTo(url);
    }
    private async Task RetoSubject()
    {
        var url = Path.Combine($"/Giaovien/{specializedIdNonDecrypt}/{lecuIdNonDecrypt}/{subjectIdNonDecrypt}");
        Navigation.NavigateTo(url);
    }
private async Task AddStudentInClass()
    {
        var url = Path.Combine($"/AddStudentInClass/{idClassNonDecrypt}/{specializedIdNonDecrypt}/{lecuIdNonDecrypt}/{subjectIdNonDecrypt}");
        Navigation.NavigateTo(url);
    }
    private async Task Mon()
    {
        var url = Path.Combine($"/Giaovien/{specializedIdNonDecrypt}/{lecuIdNonDecrypt}/{subjectIdNonDecrypt}");
        Navigation.NavigateTo(url);
    }
    private async Task RedirectToDetails()
    {
        var url = Path.Combine($"/ViewChiTitet/{idClassNonDecrypt}/{specializedIdNonDecrypt}/{lecuIdNonDecrypt}/{subjectIdNonDecrypt}");
        Navigation.NavigateTo(url);
    }
    public async Task SearchStudentUP(StudentUPListSearchVm studentUPListSearch)
    {
        studentUPListSearchVm = studentUPListSearch;
        await GetTasks();
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591