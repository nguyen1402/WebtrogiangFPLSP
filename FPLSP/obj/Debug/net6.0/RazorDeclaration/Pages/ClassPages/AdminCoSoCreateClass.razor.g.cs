// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FPLSP.Pages.ClassPages
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
#line 2 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ClassPages\AdminCoSoCreateClass.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ClassPages\AdminCoSoCreateClass.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ClassPages\AdminCoSoCreateClass.razor"
using FPLSP.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ClassPages\AdminCoSoCreateClass.razor"
using FPLSP.Repositories.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ClassPages\AdminCoSoCreateClass.razor"
using FPLSP.Server.Data.SeedWork;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ClassPages\AdminCoSoCreateClass.razor"
using FPLSP.Server.Domain.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ClassPages\AdminCoSoCreateClass.razor"
using FPLSP.Server.Domain.Entities.CoresParts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ClassPages\AdminCoSoCreateClass.razor"
using FPLSP.Server.Domain.Entities.UserParts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ClassPages\AdminCoSoCreateClass.razor"
using FPLSP.Server.Domain.Entities.UsesParts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ClassPages\AdminCoSoCreateClass.razor"
using FPLSP.Server.Infrastructure.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/createclass/{idTrainingFacility}")]
    public partial class AdminCoSoCreateClass : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 131 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ClassPages\AdminCoSoCreateClass.razor"
       
    [Parameter]
    public string idTrainingFacility { get; set; }

    [Inject] IToastService _toast { get; set; }
    [Inject] NavigationManager _navigationManager { get; set; }
    [Inject]
    public ITaskRepositories<ClassUPViewModel> _taskRepositories { get; set; }
    [Inject]
    public ILecturersCPRepo _lecturersCPRepo { get; set; }

    private CreateClassVM _classUp;
    public LecturersCP lecturer = new LecturersCP();
    private SubjectUP _SubjectUP;
    private LecturersCP _lecturersCP;
    private List<ClassUPViewModel> _lstClass;
    private SpecializedUP _specializedUP;
    private ClassSearchDTO _classSearchDTO = new ClassSearchDTO();
    private List<StudentViewModel> _lstStudents;
    private List<ExcelErrors> _lstErrr = new List<ExcelErrors>();
    private bool IsDisabled = false;
    //ElementReference MyList { get; set; }
    public MetaData MetaData { get; set; } = new MetaData();
    private List<SubjectDto> _lstSub;
    private List<SubjectDto> _lstSubDemo;
    private List<Guid> _lstSubDemoID;
    private List<ClassUp> ClassUPList;
    private List<LecturersCP> _lstLec;
    private List<LectuterSpecializedCPDto> _lstLecSpec;
    private List<SpecializedDto> _lstSpec;
    private List<SubjectsSpecializedDtos> _lstSubSpec;
    private RadioModel _radioModel = new RadioModel();

    private ClassUPViewModel _classUPViewModel = new ClassUPViewModel();
    //
    private List<StudentViewModel> _lstStuForSearch = new List<StudentViewModel>();

    [Inject]
    public ISubjectsSpecializedUPRepo _subSpecUPRepo { get; set; }
    [Inject]
    public ISubjectUPRepo _iSubjectUPRepo { get; set; }
    [Inject]
    public ISpecializedUPRepo _iSpecializedUPRepo { get; set; }
    [Inject]
    public ILectuterSpecializedCPCilents _iLecSpecializedCPRepo { get; set; }

    public bool isNotSelectedSpec { get; set; } = true;

    public class PreStatus
    {
        public int Id { get; set; }
        public string StatusName { get; set; }
    }

    private List<PreStatus> _preStatuses = new List<PreStatus>();
    private PreStatus _Statuses = new PreStatus();

    public AdminCoSoCreateClass()
    {
        ClassUPList = new List<ClassUp>();

        _preStatuses = new List<PreStatus>()
            {
                new PreStatus(){Id=0,StatusName="Đang Hoạt Động"},
                new PreStatus(){Id=1,StatusName="Dừng Hoạt Động"},
                new PreStatus(){Id=2,StatusName="Chưa Đủ Sinh Viên"},
                new PreStatus(){Id=3 ,StatusName="Chưa Có Môn Học"},
            };

        _lecturersCP = new LecturersCP();
        _specializedUP = new SpecializedUP();
        _lstStudents = new List<StudentViewModel>();
        _lstLec = new List<LecturersCP>();
        _lstLecSpec = new List<LectuterSpecializedCPDto>();
        _lstSpec = new List<SpecializedDto>();
        _lstSubSpec = new List<SubjectsSpecializedDtos>();
        _Statuses = new PreStatus();
        _classUp = new CreateClassVM();
        _lstSub = new List<SubjectDto>();
        _lstSubDemoID = new List<Guid>();
        _SubjectUP = new SubjectUP();
        _lstClass = new List<ClassUPViewModel>();
    }

    protected override async Task OnInitializedAsync()
    {
        _classUp = await _taskRepositories.GetClassModel();

        _lstSpec = await _iSpecializedUPRepo.GetAll();
        // lấy list LecID thuộc cơ sở
        _lstLec = await _lecturersCPRepo.GetAllLecturerAsync();
        var _lstLecID = _lstLec.Where(x => x.TrainingFacilitiesId == Guid.Parse(idTrainingFacility)).Select(c => c.Id).ToList();
        // lấy list SpecID của Lec
        _lstLecSpec = await _iLecSpecializedCPRepo.GetAllAsync();
        var _lstSpecID = _lstLecSpec.Where(x => _lstLecID.Contains(x.Idlecturers)).Select(c => c.Idspecialized).ToList();
        // lấy list Sub của Spec
        _lstSubSpec = await _subSpecUPRepo.GetAllAsync();
        var _lstSubID = _lstSubSpec.Where(x => _lstSpecID.Contains(x.SpecializedId)).Select(c => c.SubjectId).ToList();

        _lstSub = await _iSubjectUPRepo.GetAllSubjectAsync();
        _lstSub = _lstSub.Where(c => _lstSubID.Contains(Guid.Parse(c.Id.ToString()))).ToList();

        //
        foreach (var x in _preStatuses)
        {
            _Statuses.Id = x.Id;
            _Statuses.StatusName = x.StatusName;
        }

        // lấy môn học isDemo
        GetSpecializedAndSubject(_radioModel.IsDemo);
    }

    private void GetSpecializedAndSubject(bool isDemo)
    {
        // lấy môn (mẫu) => chuyên ngành => giảng viên thuộc cơ sở
        _lstSub = _lstSub.Where(c => c.IsDemo == isDemo).ToList();
        var _lstSubID = _lstSub.Select(c => c.Id).ToList();

        var _lstSpecOfSubID = _lstSubSpec.Where(x => _lstSubID.Contains(x.SubjectId)).Select(c => c.SpecializedId).ToList();

        _lstSpec = _lstSpec.Where(c => _lstSpecOfSubID.Contains(c.Id)).ToList();
    }

    private async Task Created(EditContext editContext)
    {
        if (_radioModel.IsDemo)
        {
            _classUp.HomeroomLecturerId = Guid.Empty;
            _classUp.Building = "N/A";
            _classUp.StudentAmount = 0;
        }

        _classUp.subjectUP = new List<Guid?>() { _classUp.SubjectId };

        var res = await _taskRepositories.AddAsync(_classUp);
        if (res)
        {
            _toast.ShowSuccess($"Thêm Lớp {_classUp.ClassroomName} thành công");
            _navigationManager.NavigateTo($"/createclass/{idTrainingFacility}");
        }
        else
        {
            _toast.ShowError($"Thêm Lớp {_classUp.ClassroomName} thất bại");
            _navigationManager.NavigateTo($"/createclass/{idTrainingFacility}");
        }
    }

    private async Task Quaylai()
    {

    }

    private class RadioModel
    {
        public bool IsDemo { get; set; } = false;
    }

    private async Task InputForClassDemo()
    {
        await OnInitializedAsync();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
