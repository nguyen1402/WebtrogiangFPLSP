#pragma checksum "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSubjectCP\CreatSubject.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46021e8753214f086942aca75eb7c8df2efacb08"
// <auto-generated/>
#pragma warning disable 1591
namespace FPLSP.Pages.PagesSubjectCP
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
#line 2 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSubjectCP\CreatSubject.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSubjectCP\CreatSubject.razor"
using FPLSP.Data.Securities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSubjectCP\CreatSubject.razor"
using FPLSP.Repositories;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSubjectCP\CreatSubject.razor"
using FPLSP.Repositories.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSubjectCP\CreatSubject.razor"
using FPLSP.Server.Domain.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSubjectCP\CreatSubject.razor"
using FPLSP.Server.Infrastructure.ViewModels.Subject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSubjectCP\CreatSubject.razor"
           [Authorize(Roles = "AdminCore,AdminCS")]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/createsubject/{idspecializedNonDecrypt}")]
    public partial class CreatSubject : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row pt-3");
            __builder.AddMarkupContent(4, "<h3>T???o M???i M??n</h3>\r\n        ");
            __builder.OpenElement(5, "nav");
            __builder.AddAttribute(6, "aria-label", "breadcrumb");
            __builder.OpenElement(7, "ol");
            __builder.AddAttribute(8, "class", "breadcrumb");
            __builder.OpenElement(9, "li");
            __builder.AddAttribute(10, "class", "breadcrumb-item");
            __builder.OpenElement(11, "a");
            __builder.AddAttribute(12, "href", "/SpecializedCP/" + (
#nullable restore
#line 16 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSubjectCP\CreatSubject.razor"
                                                                     _cryptoServices.Encrypt((maxlevel).ToString()).Replace("/", "I0H")

#line default
#line hidden
#nullable disable
            ) + "/" + (
#nullable restore
#line 16 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSubjectCP\CreatSubject.razor"
                                                                                                                                         _cryptoServices.Encrypt((IdCoSo).ToString()).Replace("/", "I0H")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(13, "Chuy??n ng??nh");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                ");
            __builder.OpenElement(15, "li");
            __builder.AddAttribute(16, "class", "breadcrumb-item");
            __builder.OpenElement(17, "a");
            __builder.AddAttribute(18, "href", "/subjects/" + (
#nullable restore
#line 17 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSubjectCP\CreatSubject.razor"
                                                                idspecializedNonDecrypt.ToString()

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line (17,102)-(17,117) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSubjectCP\CreatSubject.razor"
__builder.AddContent(19, namespecialized);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                ");
            __builder.AddMarkupContent(21, "<li class=\"breadcrumb-item active\" aria-current=\"page\">T???o m???i m??n h???c</li>");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 21 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSubjectCP\CreatSubject.razor"
         if (ShowAuthError)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "alert alert-danger");
            __builder.AddAttribute(24, "role", "alert");
#nullable restore
#line (24,18)-(24,23) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSubjectCP\CreatSubject.razor"
__builder.AddContent(25, Error);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 26 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSubjectCP\CreatSubject.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.EditForm>(26);
            __builder.AddAttribute(27, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Object>(
#nullable restore
#line 27 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSubjectCP\CreatSubject.razor"
                         subject

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(28, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Forms.EditContext>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 27 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSubjectCP\CreatSubject.razor"
                                                 Create

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(29, "class", "card card-body bg-light");
            __builder.AddAttribute(30, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(31);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(32, "\r\n            ");
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "form-group");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", "row");
                __builder2.OpenElement(37, "div");
                __builder2.AddAttribute(38, "class", "col-2 pt-4");
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "class", "row");
                __builder2.OpenElement(41, "img");
                __builder2.AddAttribute(42, "src", 
#nullable restore
#line 34 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSubjectCP\CreatSubject.razor"
                                       subject.Image

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(43, "width", "195px");
                __builder2.AddAttribute(44, "height", "232px");
                __builder2.AddAttribute(45, "style", "object-fit:contain");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n                        ");
                __builder2.OpenElement(47, "div");
                __builder2.AddAttribute(48, "class", "row");
                __builder2.OpenElement(49, "div");
                __builder2.AddAttribute(50, "class", "form-group");
                __builder2.AddMarkupContent(51, "<label for=\"image\" class=\"col-12 col-form-label\">H??nh ???nh:</label>");
#nullable restore
#line 39 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSubjectCP\CreatSubject.razor"
                                 if (@image != null)
                                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(52, "div");
                __builder2.AddAttribute(53, "class", "col-12");
                __builder2.OpenComponent<global::FPLSP.Shared.ImageUpload>(54);
                __builder2.AddAttribute(55, "OnChange", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, 
#nullable restore
#line 42 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSubjectCP\CreatSubject.razor"
                                                               AssignImageUrl

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.CloseElement();
#nullable restore
#line 44 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSubjectCP\CreatSubject.razor"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(56, "div");
                __builder2.AddAttribute(57, "class", "col-12");
                __builder2.OpenComponent<global::FPLSP.Shared.ImageUpload>(58);
                __builder2.AddAttribute(59, "OnChange", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, 
#nullable restore
#line 48 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSubjectCP\CreatSubject.razor"
                                                               AssignImageUrl

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.CloseElement();
#nullable restore
#line 50 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSubjectCP\CreatSubject.razor"
                                }

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(60, "div");
                __builder2.AddAttribute(61, "class", "text-danger");
                global::__Blazor.FPLSP.Pages.PagesSubjectCP.CreatSubject.TypeInference.CreateValidationMessage_0(__builder2, 62, 63, 
#nullable restore
#line 51 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSubjectCP\CreatSubject.razor"
                                                                                   () => subject.Image

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n                    ");
                __builder2.OpenElement(65, "div");
                __builder2.AddAttribute(66, "class", "col-10 pt-1");
                __builder2.OpenElement(67, "div");
                __builder2.AddAttribute(68, "class", "row");
                __builder2.OpenElement(69, "div");
                __builder2.AddAttribute(70, "class", "form-group pt-2 col-6");
                __builder2.AddMarkupContent(71, "<label for=\"name\" class=\"col-2 col-form-label\">S??? bu???i:</label>\r\n                                ");
                __builder2.OpenElement(72, "div");
                __builder2.AddAttribute(73, "class", "col-12");
                global::__Blazor.FPLSP.Pages.PagesSubjectCP.CreatSubject.TypeInference.CreateInputNumber_1(__builder2, 74, 75, "10", 76, "29", 77, "name", 78, "form-control", 79, 
#nullable restore
#line 64 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSubjectCP\CreatSubject.razor"
                                                                                                           subject.TotalOfSub

#line default
#line hidden
#nullable disable
                , 80, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => subject.TotalOfSub = __value, subject.TotalOfSub)), 81, () => subject.TotalOfSub);
                __builder2.AddMarkupContent(82, "\r\n\r\n                                    ");
                __builder2.OpenElement(83, "div");
                __builder2.AddAttribute(84, "class", "text-danger");
                global::__Blazor.FPLSP.Pages.PagesSubjectCP.CreatSubject.TypeInference.CreateValidationMessage_2(__builder2, 85, 86, 
#nullable restore
#line 66 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSubjectCP\CreatSubject.razor"
                                                                                       () => subject.TotalOfSub

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(87, "\r\n                            ");
                __builder2.OpenElement(88, "div");
                __builder2.AddAttribute(89, "class", "form-group pt-2 col-6");
                __builder2.AddMarkupContent(90, "<label for=\"name\" class=\"col-3 col-form-label\">Tr???ng th??i:</label>\r\n                                ");
                __builder2.OpenElement(91, "div");
                __builder2.AddAttribute(92, "class", "col-12");
                global::__Blazor.FPLSP.Pages.PagesSubjectCP.CreatSubject.TypeInference.CreateInputSelect_3(__builder2, 93, 94, "form-select", 95, 
#nullable restore
#line 72 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSubjectCP\CreatSubject.razor"
                                                              subject.Status

#line default
#line hidden
#nullable disable
                , 96, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => subject.Status = __value, subject.Status)), 97, () => subject.Status, 98, (__builder3) => {
                    __builder3.AddMarkupContent(99, "<option value=\"0\">Kh??ng ho???t ?????ng</option>\r\n                                        ");
                    __builder3.AddMarkupContent(100, "<option value=\"1\">??ang ho???t ?????ng</option>");
                }
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(101, "\r\n                        ");
                __builder2.OpenElement(102, "div");
                __builder2.AddAttribute(103, "class", "row");
                __builder2.OpenElement(104, "div");
                __builder2.AddAttribute(105, "class", "form-group pt-2 col-12");
                __builder2.AddMarkupContent(106, "<label for=\"name\" class=\"col-3 col-form-label\">M??n ch??nh/M??n m???u:</label>\r\n                                ");
                __builder2.OpenElement(107, "div");
                __builder2.AddAttribute(108, "class", "col-12");
                global::__Blazor.FPLSP.Pages.PagesSubjectCP.CreatSubject.TypeInference.CreateInputSelect_4(__builder2, 109, 110, "form-select", 111, 
#nullable restore
#line 84 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSubjectCP\CreatSubject.razor"
                                                              subject.IsDemo

#line default
#line hidden
#nullable disable
                , 112, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => subject.IsDemo = __value, subject.IsDemo)), 113, () => subject.IsDemo, 114, (__builder3) => {
                    __builder3.AddMarkupContent(115, "<option value=\"false\">M??n ch??nh</option>\r\n                                        ");
                    __builder3.AddMarkupContent(116, "<option value=\"true\">M??n m???u</option>");
                }
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(117, "\r\n\r\n                        ");
                __builder2.OpenElement(118, "div");
                __builder2.AddAttribute(119, "class", "row");
                __builder2.OpenElement(120, "div");
                __builder2.AddAttribute(121, "class", "col-12");
                __builder2.OpenElement(122, "div");
                __builder2.AddAttribute(123, "class", "row");
                __builder2.AddMarkupContent(124, "<div class=\"col-3\"></div>\r\n                                    ");
                __builder2.OpenElement(125, "div");
                __builder2.AddAttribute(126, "class", "col-6 mt-2 pt-4");
                __builder2.AddAttribute(127, "style", "text-align:center");
                __builder2.AddMarkupContent(128, "<button type=\"submit\" class=\"btn btn-primary me-2\">Th??m M???i</button>\r\n                                        ");
                __builder2.OpenElement(129, "button");
                __builder2.AddAttribute(130, "type", "button");
                __builder2.AddAttribute(131, "class", "btn btn-outline-success me-2");
                __builder2.AddAttribute(132, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 99 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSubjectCP\CreatSubject.razor"
                                                                                                             ClearForm

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(133, "L??m M???i");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(134, "\r\n                                        ");
                __builder2.OpenElement(135, "a");
                __builder2.AddAttribute(136, "href", "/subjects/" + (
#nullable restore
#line 100 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSubjectCP\CreatSubject.razor"
                                                            idspecializedNonDecrypt.ToString()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(137, "class", "btn btn-outline-danger");
                __builder2.AddMarkupContent(138, "Quay L???i");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(139, "\r\n                                    <div class=\"col-3\"></div>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(140, "\r\n");
            __builder.OpenComponent<global::FPLSP.Components.Comfirmation>(141);
            __builder.AddAttribute(142, "ConfirmationMessage", "B???n c?? ch???c mu???n t???o th??m b??i h???c cho m??n n??y kh??ng ?");
            __builder.AddAttribute(143, "ConfirmationTitle", "T???o b??i h???c");
            __builder.AddAttribute(144, "ConfirmationChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.Boolean>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.Boolean>(this, 
#nullable restore
#line 116 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSubjectCP\CreatSubject.razor"
                                                    OnConfirmation

#line default
#line hidden
#nullable disable
            )));
            __builder.AddComponentReferenceCapture(145, (__value) => {
#nullable restore
#line 116 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSubjectCP\CreatSubject.razor"
                                                                          Confirmation = (FPLSP.Components.Comfirmation)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 119 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSubjectCP\CreatSubject.razor"
       
    [Parameter]
    public int lever { get; set; }
    [Parameter]
    public string image { get; set; }
    Uri uri;
    string maxlevel = "";
    string IdCoSo = "";
    [Parameter]
    public string idspecializedNonDecrypt { get; set; }
    public string idspecialized = "";
    private SubjectCreateVM subject = new SubjectCreateVM();
    [Inject]
    public NavigationManager Navigation { get; set; }

    [Inject]
    public ISubjectClient _iSubjectClient { get; set; }

    [Inject]
    public CryptoServices _cryptoServices { get; set; }

    [Inject]
    public ISpecializedCPRepo _iSpecialized { get; set; }

    public List<SpecializedDto> _lsSpecialized;
    public List<SpecializedDto> _lsSpecialized2;
    public List<SpecializedDto> _lsSpecialized3;
    [Inject] private IToastService _toastService { get; set; }
    public bool ShowAuthError { get; set; }
    [Parameter]
    public string Error { get; set; }
    public SpecializedDto specializedDto = new SpecializedDto();
    string namespecialized { get; set; }
    protected Comfirmation Confirmation { get; set; }
    protected async override Task OnInitializedAsync()
    {
        uri = Navigation.ToAbsoluteUri(Navigation.Uri);
        if (string.IsNullOrEmpty(uri.Query) == false)
        {
            var urifist = uri.Query.Split("?")[1];
            maxlevel = _cryptoServices.Decrypt(urifist.Split("LDN01")[0].Replace("I0H", "/"));
            IdCoSo = _cryptoServices.Decrypt(urifist.Split("LDN01")[1].Replace("I0H", "/"));
        }
        idspecialized = _cryptoServices.Decrypt(idspecializedNonDecrypt.Replace("I0H", "/"));
        await GetTasks();
    }
    private async Task GetTasks()
    {
        specializedDto = await _iSpecialized.GetbyId(Guid.Empty, Guid.Parse(idspecialized));
        namespecialized = specializedDto.SpecializationName;
        subject.TotalOfSub = 20;
    }

    private async Task Create()
    {
        ShowAuthError = false;
        subject.idspec = Guid.Parse(idspecialized);
        subject.Id = Guid.NewGuid();
        TimeSpan date = subject.EndDay - subject.StartDay;
        TimeSpan day = DateTime.Now - subject.EndDay;
        var allsubject = await _iSubjectClient.GetAllSubjectByIdSpecialzed(Guid.Parse(idspecialized));
        var subjectcode = allsubject.Where(p => p.SubjectCode == subject.SubjectCode).ToList();
        if (subjectcode.Count > 0)
        {
            _toastService.ShowError("M?? m??n h???c ???? ???????c s??? d???ng");
            Navigation.NavigateTo("/createsubject/" + idspecialized.ToString());
        }
        else
        {
            var result = await _iSubjectClient.CreateSubject(subject);

            if (result != 1)
            {
                _toastService.ShowError("L???i");
                Navigation.NavigateTo("/createsubject/" + idspecialized.ToString());

            }
            else
            {
                _toastService.ShowSuccess("Th??m th??nh c??ng");
                Confirmation.show();

            }
        }


    }
    private void AssignImageUrl(string imgUrl)
    {
        subject.Image = imgUrl;
    }


    private void ClearForm()
    {
        image = null;
        subject.TotalOfSub = 20;
        subject.SubjectName = null;
        subject.SubjectCode = null;
        subject.StartDay = DateTime.Now;
        subject.EndDay = DateTime.Now;
    }
    public async Task OnConfirmation(bool confirmed)
    {
        if (confirmed)
        {
            var url = Path.Combine("/createlesson/" + _cryptoServices.Encrypt((idspecialized).ToString()).Replace("/", "I0H") + "/" + _cryptoServices.Encrypt((subject.Id).ToString()).Replace("/", "I0H")) + $"?{_cryptoServices.Encrypt((maxlevel).ToString()).Replace("/", "I0H") + "LDN01" + _cryptoServices.Encrypt((IdCoSo).ToString()).Replace("/", "I0H")}";
            Navigation.NavigateTo(url);
        }
        else
        {
            Navigation.NavigateTo("/subjects/" + _cryptoServices.Encrypt((idspecialized).ToString()).Replace("/", "I0H"));
        }
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.FPLSP.Pages.PagesSubjectCP.CreatSubject
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Object __arg0, int __seq1, global::System.Object __arg1, int __seq2, global::System.Object __arg2, int __seq3, global::System.Object __arg3, int __seq4, TValue __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg5, int __seq6, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg6)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "min", __arg0);
        __builder.AddAttribute(__seq1, "max", __arg1);
        __builder.AddAttribute(__seq2, "id", __arg2);
        __builder.AddAttribute(__seq3, "class", __arg3);
        __builder.AddAttribute(__seq4, "Value", __arg4);
        __builder.AddAttribute(__seq5, "ValueChanged", __arg5);
        __builder.AddAttribute(__seq6, "ValueExpression", __arg6);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
