#pragma checksum "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesResourcelinkCP\Updateresourcelink.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b108c7af4270f83c79cee891d1046e8314d4c1d"
// <auto-generated/>
#pragma warning disable 1591
namespace FPLSP.Pages.PagesResourcelinkCP
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
#line 2 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesResourcelinkCP\Updateresourcelink.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesResourcelinkCP\Updateresourcelink.razor"
using FPLSP.Data.Securities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesResourcelinkCP\Updateresourcelink.razor"
using FPLSP.Repositories;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesResourcelinkCP\Updateresourcelink.razor"
using FPLSP.Repositories.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesResourcelinkCP\Updateresourcelink.razor"
using FPLSP.Server.Domain.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesResourcelinkCP\Updateresourcelink.razor"
using FPLSP.Server.Infrastructure.ViewModels.ResourceLink;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesResourcelinkCP\Updateresourcelink.razor"
           [Authorize(Roles = "AdminCore,AdminCS")]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/updateresourcelink/{idspecializedNonDecrypt}/{idsubjectNonDecrypt}/{idlessonNonDecrypt}/{idResourceLinkNonDecrypt}")]
    public partial class Updateresourcelink : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"row\"><div class=\"col-4 ps-0\"><h3 class=\"ps-0\">Cập nhật Link</h3></div></div>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
#nullable restore
#line 14 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesResourcelinkCP\Updateresourcelink.razor"
     if (ShowAuthError)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "alert alert-danger");
            __builder.AddAttribute(5, "role", "alert");
#nullable restore
#line (17,14)-(17,19) 24 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesResourcelinkCP\Updateresourcelink.razor"
__builder.AddContent(6, Error);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 19 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesResourcelinkCP\Updateresourcelink.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesResourcelinkCP\Updateresourcelink.razor"
     if (model != null)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.EditForm>(7);
            __builder.AddAttribute(8, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Object>(
#nullable restore
#line 22 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesResourcelinkCP\Updateresourcelink.razor"
                         model

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Forms.EditContext>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 22 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesResourcelinkCP\Updateresourcelink.razor"
                                               Update

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(10, "class", "card card-body bg-light mt-1");
            __builder.AddAttribute(11, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(12);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n\r\n            ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "form-group");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "row");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "col-lg-5 pt-1 pl-5");
#nullable restore
#line 28 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesResourcelinkCP\Updateresourcelink.razor"
                         if (model.PathId() != null)
                        {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(20, "iframe");
                __builder2.AddAttribute(21, "class", "modal-xl");
                __builder2.AddAttribute(22, "style", "height: 308px;width:480px;padding-top: 10px;");
                __builder2.AddAttribute(23, "src", "https://www.youtube.com/embed/" + (
#nullable restore
#line 30 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesResourcelinkCP\Updateresourcelink.razor"
                                                                                                                                              model.PathId()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(24, "frameborder", "0");
                __builder2.AddAttribute(25, "allow", "accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture");
                __builder2.AddAttribute(26, "allowfullscreen");
                __builder2.CloseElement();
#nullable restore
#line 31 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesResourcelinkCP\Updateresourcelink.razor"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(27, "<h5>Video sẽ được hiển thị ở đây</h5>");
#nullable restore
#line 35 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesResourcelinkCP\Updateresourcelink.razor"
                        }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n                    ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "col-lg-7");
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "class", "form-group pt-2 ");
                __builder2.AddMarkupContent(33, "<label for=\"name\" class=\"form-label\">Tiêu đề:</label>\r\n                            ");
                __builder2.OpenElement(34, "div");
                __builder2.AddAttribute(35, "class", "text-danger");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(36);
                __builder2.AddAttribute(37, "class", "form-control");
                __builder2.AddAttribute(38, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 41 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesResourcelinkCP\Updateresourcelink.razor"
                                                                             model.ResourcesTitle

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(39, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.ResourcesTitle = __value, model.ResourcesTitle))));
                __builder2.AddAttribute(40, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => model.ResourcesTitle));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(41, "\r\n                                ");
                global::__Blazor.FPLSP.Pages.PagesResourcelinkCP.Updateresourcelink.TypeInference.CreateValidationMessage_0(__builder2, 42, 43, 
#nullable restore
#line 42 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesResourcelinkCP\Updateresourcelink.razor"
                                                        ()=>model.ResourcesTitle

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n                        ");
                __builder2.OpenElement(45, "div");
                __builder2.AddAttribute(46, "class", "form-group pt-2");
                __builder2.AddMarkupContent(47, "<label for=\"name\" class=\"form-label\">Đường dẫn:</label>\r\n                            ");
                __builder2.OpenElement(48, "div");
                __builder2.AddAttribute(49, "class", "text-danger");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(50);
                __builder2.AddAttribute(51, "class", "form-control");
                __builder2.AddAttribute(52, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 48 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesResourcelinkCP\Updateresourcelink.razor"
                                                                             model.Path

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(53, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.Path = __value, model.Path))));
                __builder2.AddAttribute(54, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => model.Path));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(55, "\r\n                                ");
                global::__Blazor.FPLSP.Pages.PagesResourcelinkCP.Updateresourcelink.TypeInference.CreateValidationMessage_1(__builder2, 56, 57, 
#nullable restore
#line 49 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesResourcelinkCP\Updateresourcelink.razor"
                                                        ()=>model.Path

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n                        ");
                __builder2.OpenElement(59, "div");
                __builder2.AddAttribute(60, "class", "form-group pt-2");
                __builder2.AddMarkupContent(61, "<label for=\"name\" class=\"form-label\">Mô tả:</label>\r\n                            ");
                __builder2.OpenElement(62, "div");
                __builder2.AddAttribute(63, "class", "text-danger");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(64);
                __builder2.AddAttribute(65, "class", "form-control");
                __builder2.AddAttribute(66, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 55 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesResourcelinkCP\Updateresourcelink.razor"
                                                                             model.Descriptions

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(67, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.Descriptions = __value, model.Descriptions))));
                __builder2.AddAttribute(68, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => model.Descriptions));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(69, "\r\n                                ");
                global::__Blazor.FPLSP.Pages.PagesResourcelinkCP.Updateresourcelink.TypeInference.CreateValidationMessage_2(__builder2, 70, 71, 
#nullable restore
#line 56 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesResourcelinkCP\Updateresourcelink.razor"
                                                        ()=>model.Descriptions

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(72, "\r\n                        ");
                __builder2.OpenElement(73, "div");
                __builder2.AddAttribute(74, "class", "form-group pt-2 ");
                __builder2.AddMarkupContent(75, "<label for=\"name\" class=\"form-label\">Trạng thái:</label>\r\n                            ");
                __builder2.OpenElement(76, "div");
                __builder2.AddAttribute(77, "class", "text-danger");
                global::__Blazor.FPLSP.Pages.PagesResourcelinkCP.Updateresourcelink.TypeInference.CreateInputSelect_3(__builder2, 78, 79, "form-select", 80, 
#nullable restore
#line 62 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesResourcelinkCP\Updateresourcelink.razor"
                                                                              model.Status

#line default
#line hidden
#nullable disable
                , 81, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.Status = __value, model.Status)), 82, () => model.Status, 83, (__builder3) => {
                    __builder3.AddMarkupContent(84, "<option value=\"0\">Không hoạt động</option>\r\n                                    ");
                    __builder3.AddMarkupContent(85, "<option value=\"1\">Đang Hoạt động</option>");
                }
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(86, "\r\n                        ");
                __builder2.OpenElement(87, "div");
                __builder2.AddAttribute(88, "class", "form-group row pt-2");
                __builder2.AddMarkupContent(89, "<label for=\"name\" class=\"col-6 col-form-label float-end\">Chọn môn:</label>\r\n                            ");
                __builder2.OpenElement(90, "div");
                global::__Blazor.FPLSP.Pages.PagesResourcelinkCP.Updateresourcelink.TypeInference.CreateInputSelect_4(__builder2, 91, 92, "form-select", 93, 
#nullable restore
#line 71 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesResourcelinkCP\Updateresourcelink.razor"
                                                                              model.IdSubject

#line default
#line hidden
#nullable disable
                , 94, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.IdSubject = __value, model.IdSubject)), 95, () => model.IdSubject, 96, (__builder3) => {
                    __builder3.AddMarkupContent(97, "<option value>Chọn môn </option>");
#nullable restore
#line 73 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesResourcelinkCP\Updateresourcelink.razor"
                                     if (lstSubjectDtos != null)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 75 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesResourcelinkCP\Updateresourcelink.razor"
                                         foreach (var item in lstSubjectDtos.OrderBy(c => c.SubjectName))
                                        {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(98, "option");
                    __builder3.AddAttribute(99, "value", 
#nullable restore
#line 77 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesResourcelinkCP\Updateresourcelink.razor"
                                                            item.Id

#line default
#line hidden
#nullable disable
                    );
#nullable restore
#line (77,71)-(77,87) 27 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesResourcelinkCP\Updateresourcelink.razor"
__builder3.AddContent(100, item.SubjectName);

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
#nullable restore
#line 78 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesResourcelinkCP\Updateresourcelink.razor"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 78 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesResourcelinkCP\Updateresourcelink.razor"
                                         
                                    }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.AddMarkupContent(101, "\r\n                                ");
                __builder2.OpenElement(102, "div");
                __builder2.AddAttribute(103, "class", "text-danger");
                global::__Blazor.FPLSP.Pages.PagesResourcelinkCP.Updateresourcelink.TypeInference.CreateValidationMessage_5(__builder2, 104, 105, 
#nullable restore
#line 81 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesResourcelinkCP\Updateresourcelink.razor"
                                                                                   () => model.IdSubject

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(106, "\r\n\r\n                    ");
                __builder2.OpenElement(107, "div");
                __builder2.AddAttribute(108, "class", "d-flex justify-content-center pt-3 mb-2");
                __builder2.AddMarkupContent(109, "<div class=\"p-2\"><button type=\"submit\" class=\"btn btn-success\">Cập Nhật</button></div>\r\n                        ");
                __builder2.OpenElement(110, "div");
                __builder2.AddAttribute(111, "class", "p-2");
                __builder2.OpenElement(112, "a");
                __builder2.AddAttribute(113, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 92 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesResourcelinkCP\Updateresourcelink.razor"
                                         ()=> KhoiPhuc()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(114, "class", "btn btn-outline-primary");
                __builder2.AddMarkupContent(115, "Khôi Phục");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(116, "\r\n                        ");
                __builder2.OpenElement(117, "div");
                __builder2.AddAttribute(118, "class", "p-2");
                __builder2.OpenElement(119, "a");
                __builder2.AddAttribute(120, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 95 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesResourcelinkCP\Updateresourcelink.razor"
                                         ()=>Quaylaitrangchu()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(121, "class", "btn btn-outline-danger");
                __builder2.AddMarkupContent(122, "Quay Lại");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 101 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesResourcelinkCP\Updateresourcelink.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 105 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesResourcelinkCP\Updateresourcelink.razor"
       
    private ResourceLinkUpdateVM model;
    private ResourceLinkUpdateVM UndoresourceLinkDto;
    [Inject]
    public NavigationManager Navigation { get; set; }

    [Inject]
    public IResourceLinkRepo _iResourcelinkClient { get; set; }
    public bool ShowAuthError { get; set; }
    [Parameter]
    public string Error { get; set; }


    [Parameter]
    public string idResourceLinkNonDecrypt { get; set; }
    [Parameter]
    public string idlessonNonDecrypt { get; set; }
    [Parameter]
    public string idsubjectNonDecrypt { get; set; }
    [Parameter]
    public string idspecializedNonDecrypt { get; set; }
     public string idspecialized = "";
    public string idsubject = "";
    public string idlesson = "";
    public string idResourceLink = "";

    [Inject] private IToastService _toastService { get; set; }

 [Inject]
    public CryptoServices _cryptoServices { get; set; }
    [Inject]
    public ISubjectClient _iSubjectClient { get; set; }
    List<SubjectDto> lstSubjectDtos = new List<SubjectDto>();

    Uri uri;
    string maxlevel = "";
    string IdCoSo = "";
    protected override async Task OnInitializedAsync()
    {

        uri = Navigation.ToAbsoluteUri(Navigation.Uri);
        if (string.IsNullOrEmpty(uri.Query) == false)
        {
            var urifist = uri.Query.Split("?")[1];
            maxlevel = _cryptoServices.Decrypt(urifist.Split("LDN01")[0].Replace("I0H", "/"));
            IdCoSo = _cryptoServices.Decrypt(urifist.Split("LDN01")[1].Replace("I0H", "/"));
        }
        idspecialized = _cryptoServices.Decrypt(idspecializedNonDecrypt.Replace("I0H", "/"));
        idsubject = _cryptoServices.Decrypt(idsubjectNonDecrypt.Replace("I0H", "/"));
        idlesson = _cryptoServices.Decrypt(idlessonNonDecrypt.Replace("I0H", "/"));
        idResourceLink = _cryptoServices.Decrypt(idResourceLinkNonDecrypt.Replace("I0H", "/"));
        lstSubjectDtos = await _iSubjectClient.GetAllSubjectByIdSpecialzed(Guid.Parse(idspecialized));

        var modeldb = await _iResourcelinkClient.GetbyId(Guid.Parse(idResourceLink));
        UndoresourceLinkDto = modeldb;
        model = await _iResourcelinkClient.GetbyId(Guid.Parse(idResourceLink));
    }
    private async Task Update()
    {
        var all = await _iResourcelinkClient.GetAllAsync();
        all = all.Where(p => p.ResourcesTitle != UndoresourceLinkDto.ResourcesTitle).ToList();
        all = all.Where(p => p.ResourcesTitle == model.ResourcesTitle).ToList();
        var all1 = await _iResourcelinkClient.GetAllAsync();
        all1 = all1.Where(p => p.Path != UndoresourceLinkDto.Path).ToList();
        all1 = all1.Where(p => p.Path == model.Path).ToList();
        if (all.Count() > 0)
        {
            _toastService.ShowError("Tiêu đề link đã được sử dụng");
            var url = Path.Combine("/updateresourcelink/" + _cryptoServices.Encrypt((idspecialized).ToString()).Replace("/", "I0H") + "/" + _cryptoServices.Encrypt((idsubject).ToString()).Replace("/", "I0H") + "/" + _cryptoServices.Encrypt((idlesson).ToString()).Replace("/", "I0H") + "/" + _cryptoServices.Encrypt((idResourceLink).ToString()).Replace("/", "I0H") + $"?{_cryptoServices.Encrypt((maxlevel).ToString()).Replace("/", "I0H") + "LDN01" + _cryptoServices.Encrypt((IdCoSo).ToString()).Replace("/", "I0H")}");

            Navigation.NavigateTo(url);
        }
        else
        {

        }
        var result = await _iResourcelinkClient.Update(Guid.Parse(idResourceLink), model);

        if (result != 1)
        {
            _toastService.ShowError("Lỗi! Vui lòng thử lại");
            var url = Path.Combine("/updateresourcelink/" + _cryptoServices.Encrypt((idspecialized).ToString()).Replace("/", "I0H") + "/" + _cryptoServices.Encrypt((idsubject).ToString()).Replace("/", "I0H") + "/" + _cryptoServices.Encrypt((idlesson).ToString()).Replace("/", "I0H") + "/" + _cryptoServices.Encrypt((idResourceLink).ToString()).Replace("/", "I0H") + $"?{_cryptoServices.Encrypt((maxlevel).ToString()).Replace("/", "I0H") + "LDN01" + _cryptoServices.Encrypt((IdCoSo).ToString()).Replace("/", "I0H")}");
            Navigation.NavigateTo(url);
        }
        else
        {
            _toastService.ShowSuccess("Cập nhật thành công");
            var url = Path.Combine("/resourcelink/" + _cryptoServices.Encrypt((idspecialized).ToString()).Replace("/", "I0H"), _cryptoServices.Encrypt((idsubject).ToString()).Replace("/", "I0H"), _cryptoServices.Encrypt((idlesson).ToString()).Replace("/", "I0H") + $"?{_cryptoServices.Encrypt((maxlevel).ToString()).Replace("/", "I0H") + "LDN01" + _cryptoServices.Encrypt((IdCoSo).ToString()).Replace("/", "I0H")}");
            Navigation.NavigateTo(url);
        }
    }

    private void KhoiPhuc()
    {
        model.Path = UndoresourceLinkDto.Path;
        model.Descriptions = UndoresourceLinkDto.Descriptions;
        model.ResourcesTitle = UndoresourceLinkDto.ResourcesTitle;
        model.Status = UndoresourceLinkDto.Status;
    }
    private void Quaylaitrangchu()
    {
        var url = Path.Combine("/resourcelink/" + _cryptoServices.Encrypt((idspecialized).ToString()).Replace("/", "I0H"), _cryptoServices.Encrypt((idsubject).ToString()).Replace("/", "I0H"), _cryptoServices.Encrypt((idlesson).ToString()).Replace("/", "I0H") + $"?{_cryptoServices.Encrypt((maxlevel).ToString()).Replace("/", "I0H") + "LDN01" + _cryptoServices.Encrypt((IdCoSo).ToString()).Replace("/", "I0H")}");
        Navigation.NavigateTo(url);
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.FPLSP.Pages.PagesResourcelinkCP.Updateresourcelink
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
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
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
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591