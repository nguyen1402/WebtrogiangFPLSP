#pragma checksum "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ExamLinkCPPages\ExamLinkUpdate.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4e8dad808becb463ca878a996eed637646ecc2a"
// <auto-generated/>
#pragma warning disable 1591
namespace FPLSP.Pages.ExamLinkCPPages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
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
#line 2 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ExamLinkCPPages\ExamLinkUpdate.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ExamLinkCPPages\ExamLinkUpdate.razor"
using FPLSP.Repositories.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ExamLinkCPPages\ExamLinkUpdate.razor"
using FPLSP.Server.Domain.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ExamLinkCPPages\ExamLinkUpdate.razor"
using FPLSP.Server.Domain.Entities.CoresParts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ExamLinkCPPages\ExamLinkUpdate.razor"
using FPLSP.Server.Infrastructure.ViewModels.ExamLinks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ExamLinkCPPages\ExamLinkUpdate.razor"
using FPLSP.Server.Infrastructure.ViewModels.Exams;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ExamLinkCPPages\ExamLinkUpdate.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/ExamLinkUpdate/{id:guid}")]
    public partial class ExamLinkUpdate : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Cập Nhập Thông Tin Link Đề Thi</h3>");
#nullable restore
#line 12 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ExamLinkCPPages\ExamLinkUpdate.razor"
 if (_examLinkUpdateVm != null)
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
#line 18 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ExamLinkCPPages\ExamLinkUpdate.razor"
                             _examLinkUpdateVm

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Forms.EditContext>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 18 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ExamLinkCPPages\ExamLinkUpdate.razor"
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
#line 23 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ExamLinkCPPages\ExamLinkUpdate.razor"
                                                                               _examLinkUpdateVm.ExamLinkCode

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _examLinkUpdateVm.ExamLinkCode = __value, _examLinkUpdateVm.ExamLinkCode))));
                __builder2.AddAttribute(23, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _examLinkUpdateVm.ExamLinkCode));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(24, "\r\n                        ");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "text-danger");
                global::__Blazor.FPLSP.Pages.ExamLinkCPPages.ExamLinkUpdate.TypeInference.CreateValidationMessage_0(__builder2, 27, 28, 
#nullable restore
#line 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ExamLinkCPPages\ExamLinkUpdate.razor"
                                                      () => _examLinkUpdateVm.ExamLinkCode

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
                __builder2.AddMarkupContent(32, "<label for=\"name\" class=\"col-md-2 col-form-label\"><i class=\"fa-regular fas  fa-cloud\"></i> Link Đề Thi:</label>\r\n                    ");
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "col-md-10");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(35);
                __builder2.AddAttribute(36, "id", "name");
                __builder2.AddAttribute(37, "class", "form-control");
                __builder2.AddAttribute(38, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 32 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ExamLinkCPPages\ExamLinkUpdate.razor"
                                                                               _examLinkUpdateVm.Path

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(39, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _examLinkUpdateVm.Path = __value, _examLinkUpdateVm.Path))));
                __builder2.AddAttribute(40, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _examLinkUpdateVm.Path));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(41, "\r\n                        ");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "text-danger");
                global::__Blazor.FPLSP.Pages.ExamLinkCPPages.ExamLinkUpdate.TypeInference.CreateValidationMessage_1(__builder2, 44, 45, 
#nullable restore
#line 34 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ExamLinkCPPages\ExamLinkUpdate.razor"
                                                      () => _examLinkUpdateVm.Path

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n                ");
                __builder2.OpenElement(47, "div");
                __builder2.AddAttribute(48, "class", "form-group row mt-2");
                __builder2.AddMarkupContent(49, "<label for=\"name\" class=\"col-md-2 col-form-label\"><i class=\"fa-solid fa-calendar-days\"></i> Ngày Đóng:</label>\r\n                    ");
                __builder2.OpenElement(50, "div");
                __builder2.AddAttribute(51, "class", "col-md-10");
                global::__Blazor.FPLSP.Pages.ExamLinkCPPages.ExamLinkUpdate.TypeInference.CreateInputDate_2(__builder2, 52, 53, "name", 54, "form-control", 55, 
#nullable restore
#line 41 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ExamLinkCPPages\ExamLinkUpdate.razor"
                                                                               _examLinkUpdateVm.ExpirationDate

#line default
#line hidden
#nullable disable
                , 56, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _examLinkUpdateVm.ExpirationDate = __value, _examLinkUpdateVm.ExpirationDate)), 57, () => _examLinkUpdateVm.ExpirationDate);
                __builder2.AddMarkupContent(58, "\r\n                        ");
                __builder2.OpenElement(59, "div");
                __builder2.AddAttribute(60, "class", "text-danger");
                global::__Blazor.FPLSP.Pages.ExamLinkCPPages.ExamLinkUpdate.TypeInference.CreateValidationMessage_3(__builder2, 61, 62, 
#nullable restore
#line 43 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ExamLinkCPPages\ExamLinkUpdate.razor"
                                                      () => _examLinkUpdateVm.ExpirationDate

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
                __builder2.AddMarkupContent(66, "<label for=\"name\" class=\"col-md-2 col-form-label\"><i class=\"fa-solid fa-check\"></i> Trạng Thái:</label>\r\n                    ");
                __builder2.OpenElement(67, "div");
                __builder2.AddAttribute(68, "class", "col-md-10");
                global::__Blazor.FPLSP.Pages.ExamLinkCPPages.ExamLinkUpdate.TypeInference.CreateInputSelect_4(__builder2, 69, 70, "form-control", 71, 
#nullable restore
#line 50 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ExamLinkCPPages\ExamLinkUpdate.razor"
                                                                       _examLinkUpdateVm.Status

#line default
#line hidden
#nullable disable
                , 72, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _examLinkUpdateVm.Status = __value, _examLinkUpdateVm.Status)), 73, () => _examLinkUpdateVm.Status, 74, (__builder3) => {
                    __builder3.AddMarkupContent(75, "<option value=\"1\">Mở</option>\r\n                            ");
                    __builder3.AddMarkupContent(76, "<option value=\"0\">Đóng</option>");
                }
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(77, "\r\n\r\n                ");
                __builder2.OpenElement(78, "div");
                __builder2.AddAttribute(79, "class", "form-group row mt-2");
                __builder2.AddMarkupContent(80, "<label for=\"name\" class=\"col-md-2 col-form-label\"><i class=\"fa-regular fa-file\"></i> Đề Thi:</label>\r\n                    ");
                __builder2.OpenElement(81, "div");
                __builder2.AddAttribute(82, "class", "col-md-10");
                global::__Blazor.FPLSP.Pages.ExamLinkCPPages.ExamLinkUpdate.TypeInference.CreateInputSelect_5(__builder2, 83, 84, "form-select", 85, 
#nullable restore
#line 60 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ExamLinkCPPages\ExamLinkUpdate.razor"
                                                                      _examLinkUpdateVm.ExamId

#line default
#line hidden
#nullable disable
                , 86, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _examLinkUpdateVm.ExamId = __value, _examLinkUpdateVm.ExamId)), 87, () => _examLinkUpdateVm.ExamId, 88, (__builder3) => {
#nullable restore
#line 61 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ExamLinkCPPages\ExamLinkUpdate.razor"
                             if (_lstExam != null)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ExamLinkCPPages\ExamLinkUpdate.razor"
                                 foreach (var item in _lstExam)
                                {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(89, "option");
                    __builder3.AddAttribute(90, "value", 
#nullable restore
#line 65 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ExamLinkCPPages\ExamLinkUpdate.razor"
                                                    item.Id

#line default
#line hidden
#nullable disable
                    );
#nullable restore
#line (65,63)-(65,76) 26 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ExamLinkCPPages\ExamLinkUpdate.razor"
__builder3.AddContent(91, item.ExamName);

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
#nullable restore
#line 66 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ExamLinkCPPages\ExamLinkUpdate.razor"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ExamLinkCPPages\ExamLinkUpdate.razor"
                                 
                            }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(92, "\r\n                ");
                __builder2.OpenElement(93, "div");
                __builder2.AddAttribute(94, "class", "row pt-2");
                __builder2.AddMarkupContent(95, "<div class=\"col-4\"></div>\r\n                    ");
                __builder2.OpenElement(96, "div");
                __builder2.AddAttribute(97, "class", "col-4");
                __builder2.AddAttribute(98, "style", "text-align: center");
                __builder2.AddMarkupContent(99, "<button type=\"submit\" class=\"btn btn-primary me-2\">Cập Nhật</button>\r\n                        ");
                __builder2.OpenElement(100, "button");
                __builder2.AddAttribute(101, "type", "button");
                __builder2.AddAttribute(102, "class", "btn btn-success me-2");
                __builder2.AddAttribute(103, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 75 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ExamLinkCPPages\ExamLinkUpdate.razor"
                                                                                     Restore

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(104, "Khôi Phục");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(105, "\r\n                        ");
                __builder2.AddMarkupContent(106, "<a href=\"/ExamLinkList\" class=\"btn btn-danger\">Quay Lại</a>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(107, "\r\n                    <div class=\"col-4\"></div>");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n        <div class=\"col-1\"></div>");
            __builder.CloseElement();
#nullable restore
#line 85 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ExamLinkCPPages\ExamLinkUpdate.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 88 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ExamLinkCPPages\ExamLinkUpdate.razor"
       
    private ExamLinkUpdateVm _examLinkUpdateVm = new ExamLinkUpdateVm();
    [Inject] public NavigationManager Navigation { get; set; }
    [Inject] private IToastService _toastService { get; set; }

    [Inject] private IExamLinkCPRepo _examLinkApiClient { get; set; }

    [Inject] private IExamCPServicesRepo _examApiClient { get; set; }

    private ExamListSearchVm _examListSearchVm;
    private List<ExamCPDto> _lstExam;
    private List<ExamLinkCP> ExamDtos = new List<ExamLinkCP>();
    private ExamLinkCP examLink = new ExamLinkCP();


    public ExamLinkUpdate()
    {
        _examListSearchVm = new ExamListSearchVm();
        _lstExam = new List<ExamCPDto>();
    }
    [Parameter]
    public Guid Id { get; set; }

    protected async override Task OnInitializedAsync()
    {
        var pagingResponse = await _examApiClient.GetAllExamCPListAsync();
        _lstExam = pagingResponse;
        ExamDtos = await _examLinkApiClient.GetExamLinkCP();
        await Get();
    }
    private async Task Get()
    {

        examLink = await _examLinkApiClient.GetExamLinkCPById(Id);
        var examDto = new ExamLinkUpdateVm()
            {
                ExamId = examLink.Id,
                ExamLinkCode = examLink.ExamLinkCode,
                ExpirationDate = examLink.ExpirationDate,
                Path = examLink.Path,
                Status = examLink.Status
            };
        _examLinkUpdateVm = examDto;

    }


    public async Task Update()
    {
        //if (CheckCode(_examLinkUpdateVm.ExamLinkCode))
        //{
        //    _toastService.ShowError("Lỗi! mã Link bị trùng");
        //    Navigation.NavigateTo($"/ExamLinkUpdate/{examLink.Id}");
        //}
        //else
        //{
        var result = await _examLinkApiClient.UpdateExamLinkCP(Id, _examLinkUpdateVm);
        if (result)
        {
            _toastService.ShowSuccess("Sửa Thành Công");
            Navigation.NavigateTo("/ExamLinkList");
        }
        else
        {
            _toastService.ShowError("Lỗi!");
            Navigation.NavigateTo($"/ExamLinkUpdate/{examLink.Id}");
        }
        // }

    }
    private bool CheckCode(string input)
    {
        var sdfdsf = ExamDtos.Any(c => Equals(input, c.ExamLinkCode));
        return sdfdsf;
    }
    private async void Restore()
    {

        _examLinkUpdateVm.ExamLinkCode = examLink.ExamLinkCode;
        _examLinkUpdateVm.Path = examLink.Path;
        _examLinkUpdateVm.Status = examLink.Status;
        _examLinkUpdateVm.ExpirationDate = examLink.ExpirationDate;
        await OnInitializedAsync();

    }


#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.FPLSP.Pages.ExamLinkCPPages.ExamLinkUpdate
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