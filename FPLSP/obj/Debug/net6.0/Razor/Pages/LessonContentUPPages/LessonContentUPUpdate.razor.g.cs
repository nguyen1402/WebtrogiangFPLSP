#pragma checksum "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LessonContentUPPages\LessonContentUPUpdate.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d005a183129c43c9bbedc096d728bc4312f2b941"
// <auto-generated/>
#pragma warning disable 1591
namespace FPLSP.Pages.LessonContentUPPages
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
#line 2 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LessonContentUPPages\LessonContentUPUpdate.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LessonContentUPPages\LessonContentUPUpdate.razor"
using FPLSP.Repositories.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LessonContentUPPages\LessonContentUPUpdate.razor"
using FPLSP.Server.Infrastructure.ViewModels.LessonContentUP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LessonContentUPPages\LessonContentUPUpdate.razor"
using FPLSP.Server.Infrastructure.ViewModels.LessonUP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LessonContentUPPages\LessonContentUPUpdate.razor"
using FPLSP.Server.Infrastructure.ViewModels.ResourceLinkUP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LessonContentUPPages\LessonContentUPUpdate.razor"
           [Authorize(Roles = "AdminCore,AdminCS")]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/lessonContentUPUpdate/{idsubjectUP}/{Id}")]
    public partial class LessonContentUPUpdate : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row pt-3");
            __builder.AddMarkupContent(2, "<h3>C???p nh???t n???i dung b??i h???c</h3>");
#nullable restore
#line 11 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LessonContentUPPages\LessonContentUPUpdate.razor"
     if (ShowAuthError)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "alert alert-danger");
            __builder.AddAttribute(5, "role", "alert");
#nullable restore
#line (14,14)-(14,19) 24 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LessonContentUPPages\LessonContentUPUpdate.razor"
__builder.AddContent(6, Error);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 16 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LessonContentUPPages\LessonContentUPUpdate.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LessonContentUPPages\LessonContentUPUpdate.razor"
     if (request != null)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.EditForm>(7);
            __builder.AddAttribute(8, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Object>(
#nullable restore
#line 19 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LessonContentUPPages\LessonContentUPUpdate.razor"
                         request

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Forms.EditContext>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 19 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LessonContentUPPages\LessonContentUPUpdate.razor"
                                                 UpdateSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(10, "class", "card card-body bg-light mt-5");
            __builder.AddAttribute(11, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(12);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n            ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "form-group");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "row");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "col-6");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "form-group pt-2 col-md-12");
                __builder2.AddMarkupContent(22, "<label for=\"name\" class=\"col-md-4 col-form-label\">T??n n???i dung b??i h???c:</label>\r\n                                ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "col-md-12");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(25);
                __builder2.AddAttribute(26, "id", "name");
                __builder2.AddAttribute(27, "class", "form-control");
                __builder2.AddAttribute(28, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 27 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LessonContentUPPages\LessonContentUPUpdate.razor"
                                                                                           request.LessonContentName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => request.LessonContentName = __value, request.LessonContentName))));
                __builder2.AddAttribute(30, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => request.LessonContentName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(31, "\r\n                                    ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "text-danger");
                global::__Blazor.FPLSP.Pages.LessonContentUPPages.LessonContentUPUpdate.TypeInference.CreateValidationMessage_0(__builder2, 34, 35, 
#nullable restore
#line 28 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LessonContentUPPages\LessonContentUPUpdate.razor"
                                                                                       () => request.LessonContentName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n                    ");
                __builder2.OpenElement(37, "div");
                __builder2.AddAttribute(38, "class", "col-6");
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "class", "form-group pt-2 col-md-12");
                __builder2.AddMarkupContent(41, "<label for=\"name\" class=\"col-md-4 col-form-label\">M?? n???i dung b??i h???c:</label>\r\n                            ");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "col-md-12");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(44);
                __builder2.AddAttribute(45, "id", "name");
                __builder2.AddAttribute(46, "class", "form-control");
                __builder2.AddAttribute(47, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 37 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LessonContentUPPages\LessonContentUPUpdate.razor"
                                                                                       request.LessonContentCode

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(48, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => request.LessonContentCode = __value, request.LessonContentCode))));
                __builder2.AddAttribute(49, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => request.LessonContentCode));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(50, "\r\n                                ");
                __builder2.OpenElement(51, "div");
                __builder2.AddAttribute(52, "class", "text-danger");
                global::__Blazor.FPLSP.Pages.LessonContentUPPages.LessonContentUPUpdate.TypeInference.CreateValidationMessage_1(__builder2, 53, 54, 
#nullable restore
#line 38 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LessonContentUPPages\LessonContentUPUpdate.razor"
                                                                                   () => request.LessonContentCode

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n                    ");
                __builder2.OpenElement(56, "div");
                __builder2.AddAttribute(57, "class", "col-6");
                __builder2.OpenElement(58, "div");
                __builder2.AddAttribute(59, "class", "form-group pt-2 col-md-12");
                __builder2.AddMarkupContent(60, "<label for=\"name\" class=\"col-md-4 col-form-label\">N???i dung :</label>\r\n                                ");
                __builder2.OpenElement(61, "div");
                __builder2.AddAttribute(62, "class", "col-md-12");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(63);
                __builder2.AddAttribute(64, "id", "name");
                __builder2.AddAttribute(65, "class", "form-control");
                __builder2.AddAttribute(66, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 47 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LessonContentUPPages\LessonContentUPUpdate.razor"
                                                                                           request.Content

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(67, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => request.Content = __value, request.Content))));
                __builder2.AddAttribute(68, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => request.Content));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(69, "\r\n                                ");
                __builder2.OpenElement(70, "div");
                __builder2.AddAttribute(71, "class", "text-danger");
                global::__Blazor.FPLSP.Pages.LessonContentUPPages.LessonContentUPUpdate.TypeInference.CreateValidationMessage_2(__builder2, 72, 73, 
#nullable restore
#line 48 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LessonContentUPPages\LessonContentUPUpdate.razor"
                                                                                   () => request.Content

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(74, "\r\n                    ");
                __builder2.OpenElement(75, "div");
                __builder2.AddAttribute(76, "class", "col-6");
                __builder2.OpenElement(77, "div");
                __builder2.AddAttribute(78, "class", "form-group pt-2 col-md-12");
                __builder2.AddMarkupContent(79, "<label for=\"name\" class=\"col-md-4 col-form-label\">M?? t???:</label>\r\n                            ");
                __builder2.OpenElement(80, "div");
                __builder2.AddAttribute(81, "class", "col-md-12");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(82);
                __builder2.AddAttribute(83, "id", "name");
                __builder2.AddAttribute(84, "class", "form-control");
                __builder2.AddAttribute(85, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 57 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LessonContentUPPages\LessonContentUPUpdate.razor"
                                                                                       request.Descriptions

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(86, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => request.Descriptions = __value, request.Descriptions))));
                __builder2.AddAttribute(87, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => request.Descriptions));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(88, "\r\n                                ");
                __builder2.OpenElement(89, "div");
                __builder2.AddAttribute(90, "class", "text-danger");
                global::__Blazor.FPLSP.Pages.LessonContentUPPages.LessonContentUPUpdate.TypeInference.CreateValidationMessage_3(__builder2, 91, 92, 
#nullable restore
#line 58 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LessonContentUPPages\LessonContentUPUpdate.razor"
                                                                                   () => request.Descriptions

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(93, "\r\n                    ");
                __builder2.OpenElement(94, "div");
                __builder2.AddAttribute(95, "class", "col-6");
                __builder2.OpenElement(96, "div");
                __builder2.AddAttribute(97, "class", "form-group pt-2 col-md-12");
                __builder2.AddMarkupContent(98, "<label for=\"name\" class=\"col-md-2 col-form-label\">Tr???ng th??i :</label>\r\n                                ");
                __builder2.OpenElement(99, "div");
                __builder2.AddAttribute(100, "class", "col-md-12");
                global::__Blazor.FPLSP.Pages.LessonContentUPPages.LessonContentUPUpdate.TypeInference.CreateInputSelect_4(__builder2, 101, 102, "form-select", 103, 
#nullable restore
#line 67 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LessonContentUPPages\LessonContentUPUpdate.razor"
                                                              request.Status

#line default
#line hidden
#nullable disable
                , 104, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => request.Status = __value, request.Status)), 105, () => request.Status, 106, (__builder3) => {
                    __builder3.AddMarkupContent(107, "<option value=\"0\">Kh??ng ho???t ?????ng</option>\r\n                                        ");
                    __builder3.AddMarkupContent(108, "<option value=\"1\">??ang ho???t ?????ng</option>");
                }
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(109, "\r\n                    ");
                __builder2.OpenElement(110, "div");
                __builder2.AddAttribute(111, "class", "col-6");
                __builder2.OpenElement(112, "div");
                __builder2.AddAttribute(113, "class", "form-group pt-2 col-md-12");
                __builder2.AddMarkupContent(114, "<label for=\"name\" class=\"col-md-4 col-form-label\">T??i nguy??n m??n h???c :</label>\r\n                                ");
                __builder2.OpenElement(115, "div");
                __builder2.AddAttribute(116, "class", "col-md-12");
                global::__Blazor.FPLSP.Pages.LessonContentUPPages.LessonContentUPUpdate.TypeInference.CreateInputSelect_5(__builder2, 117, 118, "form-select", 119, 
#nullable restore
#line 78 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LessonContentUPPages\LessonContentUPUpdate.razor"
                                                              request.ResuorceLinkId

#line default
#line hidden
#nullable disable
                , 120, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => request.ResuorceLinkId = __value, request.ResuorceLinkId)), 121, () => request.ResuorceLinkId, 122, (__builder3) => {
#nullable restore
#line 79 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LessonContentUPPages\LessonContentUPUpdate.razor"
                                         foreach (var item in _lstResourceLinkUP)
                                    {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(123, "option");
                    __builder3.AddAttribute(124, "value", 
#nullable restore
#line 81 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LessonContentUPPages\LessonContentUPUpdate.razor"
                                                         item.Id

#line default
#line hidden
#nullable disable
                    );
#nullable restore
#line (81,68)-(81,87) 27 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LessonContentUPPages\LessonContentUPUpdate.razor"
__builder3.AddContent(125, item.ResourcesTitle);

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
#nullable restore
#line 82 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LessonContentUPPages\LessonContentUPUpdate.razor"
                                    }                                      

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(126, "\r\n            ");
                __builder2.OpenElement(127, "div");
                __builder2.AddAttribute(128, "class", "row mt-3");
                __builder2.AddMarkupContent(129, "<div class=\"col-4\"></div>\r\n                ");
                __builder2.OpenElement(130, "div");
                __builder2.AddAttribute(131, "class", "col-4");
                __builder2.AddAttribute(132, "style", "text-align:center");
                __builder2.AddMarkupContent(133, "<button type=\"submit\" class=\"btn btn-primary me-2\">C???p Nh???t</button>\r\n                    ");
                __builder2.OpenElement(134, "button");
                __builder2.AddAttribute(135, "type", "button");
                __builder2.AddAttribute(136, "class", "btn btn-outline-success me-2");
                __builder2.AddAttribute(137, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 93 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LessonContentUPPages\LessonContentUPUpdate.razor"
                                                                                         Khoiphuc

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(138, "Kh??i Ph???c");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(139, "\r\n                    ");
                __builder2.OpenElement(140, "a");
                __builder2.AddAttribute(141, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 94 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LessonContentUPPages\LessonContentUPUpdate.razor"
                                 () => Quaylai()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(142, "class", "btn btn-outline-danger");
                __builder2.AddMarkupContent(143, "Quay L???i");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(144, "\r\n                <div class=\"col-4\"></div>");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 100 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LessonContentUPPages\LessonContentUPUpdate.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 102 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LessonContentUPPages\LessonContentUPUpdate.razor"
       
    [Parameter]
    public string Id { get; set; }
    [Parameter]
    public string idsubjectUP { get; set; }
    public bool ShowAuthError { get; set; }
    [Inject] ILessonContentUPRepo LessonContentUPRepo { get; set; }
    [Inject] NavigationManager NavigationManager { get; set; }
    [Inject] private ILessonUPRepo _lessonUPRepo { get; set; }
    private List<LessonUPViewModel> _lstLessonUP { get; set; }
    [Inject] private IResourceLinkUPRepo _resourceLinkUPRepo { get; set; }
    private List<ResourceLinkUPViewModel> _lstResourceLinkUP { get; set; }
    private LessonContentUPUpdateRequest request;
    private LessonContentUPViewModel data { get; set; } = new LessonContentUPViewModel();
    [Inject] private IToastService toastService { get; set; }
    [CascadingParameter]
    private Error Error { get; set; }

    public string status { get; set; } = "";
    protected override async Task OnInitializedAsync()
    {
        _lstLessonUP = await _lessonUPRepo.GetAll();
        _lstResourceLinkUP = await _resourceLinkUPRepo.GetAll();
        data = await LessonContentUPRepo.GetById(Id);
        request = new LessonContentUPUpdateRequest();
        request.LessonContentCode = data.LessonContentCode;
        request.LessonContentName = data.LessonContentName;
        request.Content = data.Content;
        request.Descriptions = data.Descriptions;
        request.LessonId = data.LessonId;
        request.Status = data.Status;
        status = data.Status.ToString();
        request.ResuorceLinkId = data.ResuorceLinkId;
    }


    private async Task UpdateSubmit(EditContext context)
    {
        try
        {
            var result = await LessonContentUPRepo.Update(Guid.Parse(Id), request);
            if (result)
            {
                toastService.ShowSuccess("C???p nh???t th??nh c??ng");
                NavigationManager.NavigateTo($"/lessonContentUP/{idsubjectUP}/{data.LessonId}");
            }
        }
        catch (Exception ex)
        {
            toastService.ShowSuccess("C???p nh???t th???t b???i");
        }
    }
    public async void Khoiphuc()
    {
        request = new LessonContentUPUpdateRequest();
        request.LessonContentCode = data.LessonContentCode;
        request.LessonContentName = data.LessonContentName;
        request.Content = data.Content;
        request.Descriptions = data.Descriptions;
        request.LessonId = data.LessonId;
        request.Status = data.Status;
        status = data.Status.ToString();
        request.ResuorceLinkId = data.ResuorceLinkId;
    }
    void Quaylai()
    {
        NavigationManager.NavigateTo($"/lessonContentUP/{idsubjectUP}/{data.LessonId}");
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.FPLSP.Pages.LessonContentUPPages.LessonContentUPUpdate
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
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
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
        public static void CreateInputSelect_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
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
