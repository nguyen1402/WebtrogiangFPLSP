#pragma checksum "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ContentOfExamCPPages\CoeCPUpdate.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b854820440d1b155d2bf712b8b2f8042f28dfa9b"
// <auto-generated/>
#pragma warning disable 1591
namespace FPLSP.Pages.ContentOfExamCPPages
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
#line 2 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ContentOfExamCPPages\CoeCPUpdate.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ContentOfExamCPPages\CoeCPUpdate.razor"
using FPLSP.Repositories.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ContentOfExamCPPages\CoeCPUpdate.razor"
using FPLSP.Server.Domain.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ContentOfExamCPPages\CoeCPUpdate.razor"
using FPLSP.Server.Infrastructure.ViewModels.ContentOfExamsCP;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/CoeCPUpdate/{id:guid}")]
    public partial class CoeCPUpdate : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Cập Nhập Nội Dung Đề Thi</h3>");
#nullable restore
#line 9 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ContentOfExamCPPages\CoeCPUpdate.razor"
 if (_UpdateVm != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.AddMarkupContent(3, "<div class=\"col-1\"></div>\r\n        ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "d-flex justify-content-center col-10 ");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.EditForm>(6);
            __builder.AddAttribute(7, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Object>(
#nullable restore
#line 15 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ContentOfExamCPPages\CoeCPUpdate.razor"
                             _UpdateVm

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Forms.EditContext>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 15 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ContentOfExamCPPages\CoeCPUpdate.razor"
                                                       Update

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(9, "class", "card card-body bg-light mt-5");
            __builder.AddAttribute(10, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(11);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n                ");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "form-group row mt-2");
                __builder2.AddMarkupContent(15, "<label for=\"name\" class=\"col-md-2 col-form-label\"><i class=\"fa-solid fa-code\"></i> Mã link Đề Thi:</label>\r\n                    ");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "col-md-10");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(18);
                __builder2.AddAttribute(19, "id", "name");
                __builder2.AddAttribute(20, "class", "form-control");
                __builder2.AddAttribute(21, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 20 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ContentOfExamCPPages\CoeCPUpdate.razor"
                                                                               _UpdateVm.CoeCode

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _UpdateVm.CoeCode = __value, _UpdateVm.CoeCode))));
                __builder2.AddAttribute(23, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _UpdateVm.CoeCode));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(24, "\r\n                        ");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "text-danger");
                global::__Blazor.FPLSP.Pages.ContentOfExamCPPages.CoeCPUpdate.TypeInference.CreateValidationMessage_0(__builder2, 27, 28, 
#nullable restore
#line 22 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ContentOfExamCPPages\CoeCPUpdate.razor"
                                                      () => _UpdateVm.CoeCode

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n                ");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "form-group row mt-2");
                __builder2.AddMarkupContent(32, "<label for=\"name\" class=\"col-md-2 col-form-label\"><i class=\"fa-solid fas fa-check\"></i> Mức Độ:</label>\r\n                    ");
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "col-md-10");
                global::__Blazor.FPLSP.Pages.ContentOfExamCPPages.CoeCPUpdate.TypeInference.CreateInputSelect_1(__builder2, 35, 36, "form-select", 37, 
#nullable restore
#line 29 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ContentOfExamCPPages\CoeCPUpdate.razor"
                                                                      _UpdateVm.Level

#line default
#line hidden
#nullable disable
                , 38, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _UpdateVm.Level = __value, _UpdateVm.Level)), 39, () => _UpdateVm.Level, 40, (__builder3) => {
                    __builder3.AddMarkupContent(41, "<option value=\"5\">Mức 5</option>\r\n                            ");
                    __builder3.AddMarkupContent(42, "<option value=\"4\">Mức 4</option>\r\n                            ");
                    __builder3.AddMarkupContent(43, "<option value=\"3\">Mức 3</option>\r\n                            ");
                    __builder3.AddMarkupContent(44, "<option value=\"2\">Mức 2</option>\r\n                            ");
                    __builder3.AddMarkupContent(45, "<option value=\"1\">Mức 1</option>");
                }
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n\r\n                ");
                __builder2.OpenElement(47, "div");
                __builder2.AddAttribute(48, "class", "form-group row mt-2");
                __builder2.AddMarkupContent(49, "<label for=\"name\" class=\"col-md-2 col-form-label\"><i class=\"fa-solid fa-calendar-days\"></i> Ngày Mở:</label>\r\n                    ");
                __builder2.OpenElement(50, "div");
                __builder2.AddAttribute(51, "class", "col-md-10");
                global::__Blazor.FPLSP.Pages.ContentOfExamCPPages.CoeCPUpdate.TypeInference.CreateInputDate_2(__builder2, 52, 53, "name", 54, "form-control", 55, 
#nullable restore
#line 42 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ContentOfExamCPPages\CoeCPUpdate.razor"
                                                                               _UpdateVm.DateStarted

#line default
#line hidden
#nullable disable
                , 56, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _UpdateVm.DateStarted = __value, _UpdateVm.DateStarted)), 57, () => _UpdateVm.DateStarted);
                __builder2.AddMarkupContent(58, "\r\n                        ");
                __builder2.OpenElement(59, "div");
                __builder2.AddAttribute(60, "class", "text-danger");
                global::__Blazor.FPLSP.Pages.ContentOfExamCPPages.CoeCPUpdate.TypeInference.CreateValidationMessage_3(__builder2, 61, 62, 
#nullable restore
#line 44 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ContentOfExamCPPages\CoeCPUpdate.razor"
                                                      () => _UpdateVm.DateStarted

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\r\n                ");
                __builder2.OpenElement(64, "div");
                __builder2.AddAttribute(65, "class", "form-group row mt-2");
                __builder2.AddMarkupContent(66, "<label for=\"name\" class=\"col-md-2 col-form-label\"><i class=\"fa-solid fa-calendar-days\"></i> Ngày Đóng:</label>\r\n                    ");
                __builder2.OpenElement(67, "div");
                __builder2.AddAttribute(68, "class", "col-md-10");
                global::__Blazor.FPLSP.Pages.ContentOfExamCPPages.CoeCPUpdate.TypeInference.CreateInputDate_4(__builder2, 69, 70, "name", 71, "form-control", 72, 
#nullable restore
#line 51 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ContentOfExamCPPages\CoeCPUpdate.razor"
                                                                               _UpdateVm.EndDate

#line default
#line hidden
#nullable disable
                , 73, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _UpdateVm.EndDate = __value, _UpdateVm.EndDate)), 74, () => _UpdateVm.EndDate);
                __builder2.AddMarkupContent(75, "\r\n                        ");
                __builder2.OpenElement(76, "div");
                __builder2.AddAttribute(77, "class", "text-danger");
                global::__Blazor.FPLSP.Pages.ContentOfExamCPPages.CoeCPUpdate.TypeInference.CreateValidationMessage_5(__builder2, 78, 79, 
#nullable restore
#line 53 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ContentOfExamCPPages\CoeCPUpdate.razor"
                                                      () => _UpdateVm.EndDate

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(80, "\r\n                ");
                __builder2.OpenElement(81, "div");
                __builder2.AddAttribute(82, "class", "form-group row mt-2");
                __builder2.AddMarkupContent(83, "<label for=\"name\" class=\"col-md-2 col-form-label\"><i class=\"fas fa-light fa-file-lines\"></i> Nội Dung:</label>\r\n                    ");
                __builder2.OpenElement(84, "div");
                __builder2.AddAttribute(85, "class", "col-md-10");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputTextArea>(86);
                __builder2.AddAttribute(87, "class", "form-control");
                __builder2.AddAttribute(88, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 60 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ContentOfExamCPPages\CoeCPUpdate.razor"
                                                                         _UpdateVm.Content

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(89, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _UpdateVm.Content = __value, _UpdateVm.Content))));
                __builder2.AddAttribute(90, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _UpdateVm.Content));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(91, "\r\n                        ");
                __builder2.OpenElement(92, "div");
                __builder2.AddAttribute(93, "class", "text-danger");
                global::__Blazor.FPLSP.Pages.ContentOfExamCPPages.CoeCPUpdate.TypeInference.CreateValidationMessage_6(__builder2, 94, 95, 
#nullable restore
#line 62 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ContentOfExamCPPages\CoeCPUpdate.razor"
                                                      () => _UpdateVm.Content

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(96, "\r\n                ");
                __builder2.OpenElement(97, "div");
                __builder2.AddAttribute(98, "class", "form-group row mt-2");
                __builder2.AddMarkupContent(99, "<label for=\"name\" class=\"col-md-2 col-form-label\"><i class=\"fas fa-clipboard\"></i> Số lượng câu hỏi:</label>\r\n                    ");
                __builder2.OpenElement(100, "div");
                __builder2.AddAttribute(101, "class", "col-md-10");
                global::__Blazor.FPLSP.Pages.ContentOfExamCPPages.CoeCPUpdate.TypeInference.CreateInputNumber_7(__builder2, 102, 103, "form-control", 104, 
#nullable restore
#line 69 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ContentOfExamCPPages\CoeCPUpdate.razor"
                                                                       _UpdateVm.TotalOfQuestions

#line default
#line hidden
#nullable disable
                , 105, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _UpdateVm.TotalOfQuestions = __value, _UpdateVm.TotalOfQuestions)), 106, () => _UpdateVm.TotalOfQuestions);
                __builder2.AddMarkupContent(107, "\r\n                        ");
                __builder2.OpenElement(108, "div");
                __builder2.AddAttribute(109, "class", "text-danger");
                global::__Blazor.FPLSP.Pages.ContentOfExamCPPages.CoeCPUpdate.TypeInference.CreateValidationMessage_8(__builder2, 110, 111, 
#nullable restore
#line 71 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ContentOfExamCPPages\CoeCPUpdate.razor"
                                                      () => _UpdateVm.TotalOfQuestions

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(112, "\r\n                ");
                __builder2.OpenElement(113, "div");
                __builder2.AddAttribute(114, "class", "form-group row mt-2");
                __builder2.AddMarkupContent(115, "<label for=\"name\" class=\"col-md-2 col-form-label\"><i class=\"fa-solid fa-check\"></i>Trạng Thái:</label>\r\n                    ");
                __builder2.OpenElement(116, "div");
                __builder2.AddAttribute(117, "class", "col-md-10");
                global::__Blazor.FPLSP.Pages.ContentOfExamCPPages.CoeCPUpdate.TypeInference.CreateInputSelect_9(__builder2, 118, 119, "form-select", 120, 
#nullable restore
#line 78 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ContentOfExamCPPages\CoeCPUpdate.razor"
                                                                      _UpdateVm.Status

#line default
#line hidden
#nullable disable
                , 121, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _UpdateVm.Status = __value, _UpdateVm.Status)), 122, () => _UpdateVm.Status, 123, (__builder3) => {
                    __builder3.AddMarkupContent(124, "<option value=\"1\">Mở</option>\r\n                            ");
                    __builder3.AddMarkupContent(125, "<option value=\"0\">Đóng</option>");
                }
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(126, "\r\n\r\n                ");
                __builder2.OpenElement(127, "div");
                __builder2.AddAttribute(128, "class", "form-group row mt-2");
                __builder2.AddMarkupContent(129, "<label for=\"name\" class=\"col-md-2 col-form-label\"><i class=\"fa-regular fa-file\"></i> Đề Thi:</label>\r\n                    ");
                __builder2.OpenElement(130, "div");
                __builder2.AddAttribute(131, "class", "col-md-10");
                global::__Blazor.FPLSP.Pages.ContentOfExamCPPages.CoeCPUpdate.TypeInference.CreateInputSelect_10(__builder2, 132, 133, "form-select", 134, 
#nullable restore
#line 88 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ContentOfExamCPPages\CoeCPUpdate.razor"
                                                                      _UpdateVm.ExamId

#line default
#line hidden
#nullable disable
                , 135, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _UpdateVm.ExamId = __value, _UpdateVm.ExamId)), 136, () => _UpdateVm.ExamId, 137, (__builder3) => {
#nullable restore
#line 89 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ContentOfExamCPPages\CoeCPUpdate.razor"
                             if (_lstExam != null)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 91 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ContentOfExamCPPages\CoeCPUpdate.razor"
                                 foreach (var item in _lstExam)
                                {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(138, "option");
                    __builder3.AddAttribute(139, "value", 
#nullable restore
#line 93 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ContentOfExamCPPages\CoeCPUpdate.razor"
                                                    item.Id

#line default
#line hidden
#nullable disable
                    );
#nullable restore
#line (93,63)-(93,76) 27 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ContentOfExamCPPages\CoeCPUpdate.razor"
__builder3.AddContent(140, item.ExamName);

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
#nullable restore
#line 94 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ContentOfExamCPPages\CoeCPUpdate.razor"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 94 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ContentOfExamCPPages\CoeCPUpdate.razor"
                                 
                            }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(141, "\r\n                ");
                __builder2.OpenElement(142, "div");
                __builder2.AddAttribute(143, "class", "row pt-2");
                __builder2.AddMarkupContent(144, "<div class=\"col-4\"></div>\r\n                    ");
                __builder2.OpenElement(145, "div");
                __builder2.AddAttribute(146, "class", "col-4");
                __builder2.AddAttribute(147, "style", "text-align: center");
                __builder2.AddMarkupContent(148, "<button type=\"submit\" class=\"btn btn-primary me-2\">Cập Nhật</button>\r\n                        ");
                __builder2.OpenElement(149, "button");
                __builder2.AddAttribute(150, "type", "button");
                __builder2.AddAttribute(151, "class", "btn btn-success me-2");
                __builder2.AddAttribute(152, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 103 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ContentOfExamCPPages\CoeCPUpdate.razor"
                                                                                     Restore

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(153, "Khôi Phục");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(154, "\r\n                        ");
                __builder2.AddMarkupContent(155, "<a href=\"/ExamList\" class=\"btn btn-danger\">Quay Lại</a>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(156, "\r\n                    <div class=\"col-4\"></div>");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(157, "\r\n        <div class=\"col-1\"></div>");
            __builder.CloseElement();
#nullable restore
#line 113 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ContentOfExamCPPages\CoeCPUpdate.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 115 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ContentOfExamCPPages\CoeCPUpdate.razor"
      
    private CoeUpdateVm _UpdateVm = new CoeUpdateVm();
    [Inject] public NavigationManager Navigation { get; set; }
    [Inject] private IToastService _toastService { get; set; }
    [Inject] private IContentOfExamCPRepo contentOfExamCPRepo { get; set; }
    private List<ContentOfExamCPDto> _lsContentOfExamCpDtos = new List<ContentOfExamCPDto>();
    [Inject] private NavigationManager _navier { get; set; }
    [Inject] private IExamCPServicesRepo examApiClient { get; set; }

    private CoeListSearchVm _CoeListSearchVm = new CoeListSearchVm();
    private List<ExamCPDto> _lstExam;

    public CoeCPUpdate()
    {
        _lstExam = new List<ExamCPDto>();
    }
    [Parameter]
    public Guid Id { get; set; }

    protected async override Task OnInitializedAsync()
    {
        _lsContentOfExamCpDtos = await contentOfExamCPRepo.GetCoeCPListAll();
        await Get();
    }
    private async Task Get()
    {

        var pagingResponse = await examApiClient.GetAllExamCPListAsync();
        _lstExam = pagingResponse;

        var examCp = await contentOfExamCPRepo.GetCoeCPById(Id);
        var examDto = new CoeUpdateVm()
            {
                EndDate = examCp.EndDate,
                CoeCode = examCp.CoeCode,
                DateStarted = examCp.DateStarted,
                Level = examCp.Level,
                Status = examCp.Status,
                Content = examCp.Content,
                ExamId = examCp.ExamId,
                TotalOfQuestions = examCp.TotalOfQuestions,
                QuestionType = examCp.QuestionType
            };
        _UpdateVm = examDto;

    }


    private async Task Update()
    {
        if (CheckCode(_UpdateVm.CoeCode))
        {
            _toastService.ShowError("Mã nội dung bị trùng!");
            Navigation.NavigateTo($"/CoeCPUpdate/{Id}");
        }
        else
        {
            var result = await contentOfExamCPRepo.UpdateCoeCP(Id, _UpdateVm);
            if (result)
            {
                _toastService.ShowSuccess("Sửa Thành Công");
                Navigation.NavigateTo("/CoeCPList");
            }
            else
            {
                _toastService.ShowError("Lỗi! không Sửa được Link");
                Navigation.NavigateTo($"/CoeCPUpdate/{Id}");
            }
        }

    }
    private async void Restore()
    {
        var examCp = await contentOfExamCPRepo.GetCoeCPById(Id);
        var examDto = new CoeUpdateVm()
            {
                EndDate = examCp.EndDate,
                CoeCode = examCp.CoeCode,
                DateStarted = examCp.DateStarted,
                Level = examCp.Level,
                Status = examCp.Status,
                Content = examCp.Content,
                ExamId = examCp.ExamId,
                TotalOfQuestions = examCp.TotalOfQuestions,
                QuestionType = examCp.QuestionType
            };
        _UpdateVm = examDto;
        await OnInitializedAsync();

    }
    private bool CheckCode(string code)
    {
        var checkExited = _lsContentOfExamCpDtos.Any(c => Equals(code, c.CoeCode));
        return checkExited;
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.FPLSP.Pages.ContentOfExamCPPages.CoeCPUpdate
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
        public static void CreateInputSelect_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Object __arg0, int __seq1, global::System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Object __arg0, int __seq1, global::System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_7<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_8<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_9<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_10<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
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
