#pragma checksum "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ManageHomeWork\ResourceLinkForStudent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d1d2a1ec3252a2869502ebbdfbd6e06ae306c6f"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.OpenElement(2, "nav");
            __builder.AddAttribute(3, "aria-label", "breadcrumb");
            __builder.OpenElement(4, "ol");
            __builder.AddAttribute(5, "class", "breadcrumb");
            __builder.OpenElement(6, "li");
            __builder.AddAttribute(7, "class", "breadcrumb-item");
            __builder.AddMarkupContent(8, "Chuy??n ng??nh: ");
            __builder.OpenElement(9, "a");
            __builder.AddAttribute(10, "style", "color:blue;box-shadow: 0 1px");
            __builder.AddAttribute(11, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ManageHomeWork\ResourceLinkForStudent.razor"
                                                                                                        () => ResToSpec()

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line (25,126)-(25,229) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ManageHomeWork\ResourceLinkForStudent.razor"
__builder.AddContent(12, lstSpecAll.Where(c=>c.Id == Guid.Parse(specializedId)).Select(c=>c.SpecializationName).FirstOrDefault());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n            ");
            __builder.OpenElement(14, "li");
            __builder.AddAttribute(15, "class", "breadcrumb-item");
            __builder.AddMarkupContent(16, "M??n :");
            __builder.OpenElement(17, "a");
            __builder.AddAttribute(18, "style", "color:blue;box-shadow: 0 1px");
            __builder.AddAttribute(19, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ManageHomeWork\ResourceLinkForStudent.razor"
                                                                                               () => Mon()

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line (26,110)-(26,129) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ManageHomeWork\ResourceLinkForStudent.razor"
__builder.AddContent(20, thongtinlop.NameMon);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.OpenElement(22, "li");
            __builder.AddAttribute(23, "class", "breadcrumb-item");
            __builder.AddMarkupContent(24, "L???p :");
            __builder.OpenElement(25, "a");
            __builder.AddAttribute(26, "style", "color:blue;box-shadow: 0 1px");
            __builder.AddAttribute(27, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ManageHomeWork\ResourceLinkForStudent.razor"
                                                                                               () => RedirectToDetails()

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line (27,124)-(27,145) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ManageHomeWork\ResourceLinkForStudent.razor"
__builder.AddContent(28, thongtinlop.NameClass);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n            ");
            __builder.AddMarkupContent(30, "<li class=\"breadcrumb-item active\" aria-current=\"page\">Th??m t??i li???u</li>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "row pt-3");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "col-md-4");
#nullable restore
#line 34 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ManageHomeWork\ResourceLinkForStudent.razor"
         if (@thongtinlop != null)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(36, "h4");
            __builder.AddMarkupContent(37, "\r\n                                                        M??n : ");
            __builder.OpenElement(38, "b");
#nullable restore
#line (37,67)-(37,86) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ManageHomeWork\ResourceLinkForStudent.razor"
__builder.AddContent(39, thongtinlop.NameMon);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(40, " - L???p ");
            __builder.OpenElement(41, "b");
#nullable restore
#line (37,101)-(37,122) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ManageHomeWork\ResourceLinkForStudent.razor"
__builder.AddContent(42, thongtinlop.NameClass);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 39 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ManageHomeWork\ResourceLinkForStudent.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n\r\n");
            __builder.OpenComponent<global::MudBlazor.MudPaper>(44);
            __builder.AddAttribute(45, "Class", "pa-16 ma-2");
            __builder.AddAttribute(46, "Outlined", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 43 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ManageHomeWork\ResourceLinkForStudent.razor"
                                       true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(47, "Square", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 43 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ManageHomeWork\ResourceLinkForStudent.razor"
                                                     true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(48, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenElement(49, "div");
                __builder2.AddAttribute(50, "class", "mb-3");
                __builder2.AddMarkupContent(51, "<label for=\"exampleFormControlInput1\" class=\"form-label\">Ti??u ????? <i class=\"fa-solid fa-tags\"></i></label>\r\n        ");
                __builder2.OpenElement(52, "input");
                __builder2.AddAttribute(53, "type", "text");
                __builder2.AddAttribute(54, "value", 
#nullable restore
#line 52 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ManageHomeWork\ResourceLinkForStudent.razor"
                                   _getTitle

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(55, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 52 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ManageHomeWork\ResourceLinkForStudent.razor"
                                                           (ChangeEventArgs args)=>GetMessOfTitle(args)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(56, "class", "form-control");
                __builder2.AddAttribute(57, "id", "exampleFormControlInput1");
                __builder2.AddAttribute(58, "placeholder", "Ti??u ????? T??i Li???u Kh???o");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(59, "\r\n    ");
                __builder2.OpenElement(60, "div");
                __builder2.AddAttribute(61, "class", "mb-3");
                __builder2.OpenElement(62, "select");
                __builder2.AddAttribute(63, "class", "form-select");
                __builder2.AddAttribute(64, "style", "margin-top: 10px;");
                __builder2.AddAttribute(65, "aria-label", "Default select example");
                __builder2.AddAttribute(66, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 55 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ManageHomeWork\ResourceLinkForStudent.razor"
                                                                                                               (ChangeEventArgs args)=>SelectLesson(args)

#line default
#line hidden
#nullable disable
                ));
                __builder2.OpenElement(67, "option");
                __builder2.AddAttribute(68, "value", 
#nullable restore
#line 56 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ManageHomeWork\ResourceLinkForStudent.razor"
                            Guid.Empty

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(69, "Ch???n B??i H???c");
                __builder2.CloseElement();
#nullable restore
#line 57 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ManageHomeWork\ResourceLinkForStudent.razor"
             foreach (var less in _lstlessUP.Where(c => c.SubjectId == Guid.Parse(subjectId)))
            {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(70, "option");
                __builder2.AddAttribute(71, "value", 
#nullable restore
#line 59 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ManageHomeWork\ResourceLinkForStudent.razor"
                                less.Id

#line default
#line hidden
#nullable disable
                );
#nullable restore
#line (59,43)-(59,58) 26 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ManageHomeWork\ResourceLinkForStudent.razor"
__builder2.AddContent(72, less.LessonName);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
#nullable restore
#line 60 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ManageHomeWork\ResourceLinkForStudent.razor"
            }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\r\n    ");
                __builder2.OpenElement(74, "div");
                __builder2.AddAttribute(75, "class", "mb-3");
                __builder2.AddMarkupContent(76, "<label for=\"exampleFormControlTextarea1\" class=\"form-label\">N???i Dung K??m Link T??i Li???u Kham Kh???o <i class=\"fa-solid fa-link\"></i></label>\r\n        ");
                __builder2.OpenElement(77, "textarea");
                __builder2.AddAttribute(78, "value", 
#nullable restore
#line 65 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ManageHomeWork\ResourceLinkForStudent.razor"
                          data

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(79, "oninput", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 65 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ManageHomeWork\ResourceLinkForStudent.razor"
                                          HandleOnChange

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(80, "class", "form-control");
                __builder2.AddAttribute(81, "id", "exampleFormControlTextarea1");
                __builder2.AddAttribute(82, "rows", "3");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(83, "\r\n    ");
                __builder2.OpenElement(84, "div");
                __builder2.AddAttribute(85, "class", "row d-flex  justify-content-center");
                __builder2.OpenElement(86, "div");
                __builder2.AddAttribute(87, "class", "gap-2 col-6 mx-auto");
                __builder2.OpenElement(88, "a");
                __builder2.AddAttribute(89, "class", "btn btn-outline-success");
                __builder2.AddAttribute(90, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 71 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ManageHomeWork\ResourceLinkForStudent.razor"
                                                                  MakeALink

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(91, "Th??m Link T??i Nguy??n <i class=\"fa-solid fa-link\"></i>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(92, "\r\n\r\n\r\n            ");
                __builder2.OpenElement(93, "a");
                __builder2.AddAttribute(94, "class", "btn btn-outline-danger");
                __builder2.AddAttribute(95, "title", "Quay l???i");
                __builder2.AddAttribute(96, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 74 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ManageHomeWork\ResourceLinkForStudent.razor"
                                                                         () => RedirectToDetails()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(97, "Quay l???i");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
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
            _toastService.ShowError($"B???n Ch??a ??i???n Ti??u ????? Cho L???p ! {_Class.ClassroomName}-{_Class.SubjectName}");
            return;
        }
        if (String.IsNullOrEmpty(data))
        {
            _toastService.ShowError($"B???n Ch??a ??i???n Link T??i Nguy??n Cho L???p ! {_Class.ClassroomName}-{_Class.SubjectName}");
            return;
        }
        Regex reg = new Regex(pattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);

        if (!reg.IsMatch(data))
        {
            _toastService.ShowError($"Link Kh??ng Ph?? H???p");
            return;
        }
        if (_getIdLesson==Guid.Empty)
        {
            _toastService.ShowError($"B??i H???c Kh??ng H???p L??? !");
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
            _toastService.ShowSuccess($"???? ????nh k??m link kham kh???o th??nh c??ng ! {_Class.ClassroomName}-{_Class.SubjectName}");
            await RedirectToDetails();
        }
        else
        {
            _toastService.ShowError($"????nh k??m Link Kham Kh???o Th???t B???i ! {_Class.ClassroomName}-{_Class.SubjectName}");
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
