// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FPLSP.Pages.ManageHomeWork
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
#line 2 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ManageHomeWork\ResourceLinkForStudent.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ManageHomeWork\ResourceLinkForStudent.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ManageHomeWork\ResourceLinkForStudent.razor"
using FPLSP.Data.Securities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ManageHomeWork\ResourceLinkForStudent.razor"
using FPLSP.Repositories.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ManageHomeWork\ResourceLinkForStudent.razor"
using FPLSP.Server.Data.SeedWork;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ManageHomeWork\ResourceLinkForStudent.razor"
using FPLSP.Server.Domain.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ManageHomeWork\ResourceLinkForStudent.razor"
using FPLSP.Server.Domain.Dtos.StudentStatisticVM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ManageHomeWork\ResourceLinkForStudent.razor"
using FPLSP.Server.Domain.Entities.CoresParts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ManageHomeWork\ResourceLinkForStudent.razor"
using FPLSP.Server.Domain.Entities.UserParts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ManageHomeWork\ResourceLinkForStudent.razor"
using FPLSP.Server.Domain.Entities.UsesParts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ManageHomeWork\ResourceLinkForStudent.razor"
using FPLSP.Server.Infrastructure.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ManageHomeWork\ResourceLinkForStudent.razor"
using FPLSP.Server.Infrastructure.ViewModels.LessonUP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ManageHomeWork\ResourceLinkForStudent.razor"
using FPLSP.Server.Infrastructure.ViewModels.NewFeed;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ManageHomeWork\ResourceLinkForStudent.razor"
using FPLSP.Server.Infrastructure.ViewModels.SubmitHomeWorkVM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ManageHomeWork\ResourceLinkForStudent.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ManageHomeWork\ResourceLinkForStudent.razor"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout))]
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/resoucrelinkforstudent/{joincodeNonDecrypt}/{idclassNonDecrypt}/{specializedIdNonDecrypt}/{idUserNonDecrypt}/{subjectIdNonDecrypt}")]
    public partial class ResourceLinkForStudent : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 82 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ManageHomeWork\ResourceLinkForStudent.razor"
       
    private string pattern = @"^(http|https|ftp|)\://|[a-zA-Z0-9\-\.]+\.[a-zA-Z](:[a-zA-Z0-9]*)?/?([a-zA-Z0-9\-\._\?\,\'/\\\+&amp;%\$#\=~])*[^\.\,\)\(\s]$";
    private CreateClassVM _Class = new CreateClassVM();
    [Inject]
    public ITaskRepositories<ClassUPViewModel> _taskRepositories { get; set; }
    private string _getTitle;
    public MetaData MetaData { get; set; } = new MetaData();
    [Parameter]
    public string joincodeNonDecrypt { get; set; }
    [Parameter]
    public string idUserNonDecrypt { get; set; }
    [Parameter]
    public string specializedIdNonDecrypt { get; set; }
    [Parameter]
    public string subjectIdNonDecrypt { get; set; }
    [Parameter]
    public string idclassNonDecrypt { get; set; }

    public string joincode = "";

    public string idUser = "";

    public string specializedId = "";

    public string subjectId = "";

    public string idclass = "";

    private List<LessonUPViewModel> _lstlessUP = new List<LessonUPViewModel>();
    [Inject]
    public ILessonUPRepo _IlessonUPRepo { get; set; }
    private string data;
    [Parameter] public string ChildData { get; set; }
    //[Parameter] public string backurl { get; set; }

    private Thongtinlop thongtinlop = new Thongtinlop();
    [Inject] NavigationManager navigationManager { get; set; }
    [Parameter]
    public EventCallback<string> ChildDataChanged { get; set; }
    [Inject] public ISenderNotification _ISender { get; set; }
    private Guid _getIdLesson;
    [Inject] public UserManager<UserSignIn> userManager { get; set; }
    //
    [Inject] public IToastService _toastService { get; set; }
    private int encounter;
    private string getEmail = "";
    [Inject]
    public IStudentUPRepo _iStudentUPRepo { get; set; }
    [Inject]
    public ISpecializedCPRepo _iSpecializedClient { get; set; }
    
    public List<SpecializedDto> lstSpecAll  = new List<SpecializedDto>();
    [Inject]
    public CryptoServices _cryptoServices { get; set; }
    protected override async Task OnInitializedAsync()
    {
        idUser = _cryptoServices.Decrypt(idUserNonDecrypt.Replace("I0H", "/"));
        subjectId = _cryptoServices.Decrypt(subjectIdNonDecrypt.Replace("I0H", "/"));
        specializedId = _cryptoServices.Decrypt(specializedIdNonDecrypt.Replace("I0H", "/"));
        joincode = _cryptoServices.Decrypt(joincodeNonDecrypt.Replace("I0H", "/"));
        idclass = _cryptoServices.Decrypt(idclassNonDecrypt.Replace("I0H", "/"));

        thongtinlop = await _iStudentUPRepo.Thongtinlop(Guid.Parse(idclass), Guid.Parse(subjectId));
        lstSpecAll = await _iSpecializedClient.GetAll();
        _Class = await _taskRepositories.GetClassById(joincode);
        getEmail = await _localStorageService.GetItemAsync<string>("keyver");
        _lstlessUP = await _IlessonUPRepo.GetAll();
        for (var i = 0; i < 15; i++)
        {
            encounter = i;
        }

    }
    protected override void OnParametersSet()
    {
        data = ChildData;
        base.OnParametersSet();
    }
    public async Task SelectLesson(ChangeEventArgs args)
    {
        if (args.Value != Guid.Empty.ToString())
        {
            _getIdLesson = Guid.Parse(args.Value.ToString());
        }
    }
    private async Task HandleOnChange(ChangeEventArgs args)
    {
        data = args.Value.ToString();

        await ChildDataChanged.InvokeAsync(data);
    }
    private async Task GetMessOfTitle(ChangeEventArgs args){
        _getTitle = args.Value.ToString();
    }
    private async Task MakeALink()
    {
        if (String.IsNullOrEmpty(_getTitle)){
            _toastService.ShowError($"Bạn Chưa Điền Tiêu Đề Cho Lớp ! {_Class.ClassroomName}-{_Class.SubjectName}");
            return;
        }
        if (String.IsNullOrEmpty(data))
        {
            _toastService.ShowError($"Bạn Chưa Điền Link Tài Nguyên Cho Lớp ! {_Class.ClassroomName}-{_Class.SubjectName}");
            return;
        }
        Regex reg = new Regex(pattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);

        if (!reg.IsMatch(data))
        {
            _toastService.ShowError($"Link Không Phù Hợp");
            return;
        }
        if (_getIdLesson==Guid.Empty)
        {
            _toastService.ShowError($"Bài Học Không Hợp Lệ !");
            return;
        }
        NewFeedVM newFeedVM = new NewFeedVM()
            {
                Id = Guid.NewGuid(),
                Title = _getTitle,
                Content = data,
                Image = "Resource",
                Status = 0,
                CratedTime = DateTime.Now,
                EndDate = default,
                Priority = 1,
                IdLesson = _getIdLesson,
                IsReaded = true,
                IdClass = _Class.Id,
                IdSubject = _Class.SubjectId,
                IdTypeOfNewFeed = Guid.Parse("9A0CCC99-F28A-4608-8BD4-48EE2BD2E0FB"),
                IdUser = idUser
    };
        var res=  await _ISender.SendAsync(newFeedVM);
        if(res){
            _getTitle = "";
            data = "";
            _toastService.ShowSuccess($"Đã đính kèm link kham khảo thành công ! {_Class.ClassroomName}-{_Class.SubjectName}");
            await RedirectToDetails();
        }
        else
        {
            _toastService.ShowError($"Đính kèm Link Kham Khảo Thất Bại ! {_Class.ClassroomName}-{_Class.SubjectName}");
        }
    }
    private async Task Quaylai()
    {
        var url = Path.Combine($"/news/{joincodeNonDecrypt}/{idUserNonDecrypt}/{subjectIdNonDecrypt}/{specializedIdNonDecrypt}/{idclassNonDecrypt}");
        navigationManager.NavigateTo(url);
    }
    private async Task ResToSpec()
    {
        var url = Path.Combine($"/LectuterSpecializedSubjectls/{idUserNonDecrypt}/{specializedIdNonDecrypt}");
        navigationManager.NavigateTo(url);
    }
    private async Task Mon()
    {
        var url = Path.Combine($"/Giaovien/{specializedIdNonDecrypt}/{idUserNonDecrypt}/{subjectIdNonDecrypt}");
        navigationManager.NavigateTo(url);
    }
    private async Task RedirectToDetails()
    {
        var url = Path.Combine($"/ViewChiTitet/{idclassNonDecrypt}/{specializedIdNonDecrypt}/{idUserNonDecrypt}/{subjectIdNonDecrypt}");
        navigationManager.NavigateTo(url);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService _localStorageService { get; set; }
    }
}
#pragma warning restore 1591