#pragma checksum "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ExamCPPages\ExamCPSearch.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "50ef38554659c66c9f3407fa9fa9862c1f13e441"
// <auto-generated/>
#pragma warning disable 1591
namespace FPLSP.Pages.ExamCPPages
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
#line 2 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ExamCPPages\ExamCPSearch.razor"
using FPLSP.Server.Infrastructure.ViewModels.Exams;

#line default
#line hidden
#nullable disable
    public partial class ExamCPSearch : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Object>(
#nullable restore
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ExamCPPages\ExamCPSearch.razor"
                  examListSearchVm

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Forms.EditContext>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ExamCPPages\ExamCPSearch.razor"
                                               SearchForm

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "row");
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "col-2");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "col");
                __builder2.OpenElement(10, "select");
                __builder2.AddAttribute(11, "class", "form-select");
                __builder2.AddAttribute(12, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ExamCPPages\ExamCPSearch.razor"
                                                       args =>FilterStatus(args.Value) 

#line default
#line hidden
#nullable disable
                ));
                __builder2.OpenElement(13, "option");
                __builder2.AddAttribute(14, "value");
                __builder2.AddMarkupContent(15, "Tất cả");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\r\n                    ");
                __builder2.OpenElement(17, "option");
                __builder2.AddAttribute(18, "value", "1");
                __builder2.AddMarkupContent(19, "Mở");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n                    ");
                __builder2.OpenElement(21, "option");
                __builder2.AddAttribute(22, "value", "0");
                __builder2.AddMarkupContent(23, "Chưa Mở");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n        ");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "col-3");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "col");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(29);
                __builder2.AddAttribute(30, "placeholder", "Mã Đề Thi");
                __builder2.AddAttribute(31, "class", "form-control");
                __builder2.AddAttribute(32, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 16 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ExamCPPages\ExamCPSearch.razor"
                                                                                     examListSearchVm.ExamCode

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => examListSearchVm.ExamCode = __value, examListSearchVm.ExamCode))));
                __builder2.AddAttribute(34, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => examListSearchVm.ExamCode));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n        ");
                __builder2.OpenElement(36, "div");
                __builder2.AddAttribute(37, "class", "col-3");
                __builder2.OpenElement(38, "div");
                __builder2.AddAttribute(39, "class", "col");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(40);
                __builder2.AddAttribute(41, "placeholder", "Tên Đề Thi");
                __builder2.AddAttribute(42, "class", "form-control");
                __builder2.AddAttribute(43, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 21 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ExamCPPages\ExamCPSearch.razor"
                                                                                      examListSearchVm.ExamName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(44, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => examListSearchVm.ExamName = __value, examListSearchVm.ExamName))));
                __builder2.AddAttribute(45, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => examListSearchVm.ExamName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n        ");
                __builder2.OpenElement(47, "div");
                __builder2.AddAttribute(48, "class", "col-4");
                __builder2.AddMarkupContent(49, "<button type=\"submit\" class=\"btn btn-primary\">Tìm kiếm</button>\r\n            ");
                __builder2.OpenElement(50, "button");
                __builder2.AddAttribute(51, "class", "btn btn-outline-primary me-2");
                __builder2.AddAttribute(52, "stype", "border:3px double Green");
                __builder2.AddAttribute(53, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ExamCPPages\ExamCPSearch.razor"
                                                                                                   () => Undo()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(54, "Làm mới");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ExamCPPages\ExamCPSearch.razor"
       
    [Parameter]
    public EventCallback<ExamListSearchVm> OnSearch { get; set; }

    private ExamListSearchVm examListSearchVm = new ExamListSearchVm();

    private async Task SearchForm(EditContext context)
    {
        await OnSearch.InvokeAsync(examListSearchVm);
    }
    private async void FilterStatus(object Value)
    {
        var a = Value.ToString();
        var b = a ?? null;

        if (!string.IsNullOrEmpty(b))
            examListSearchVm.Status = Int32.Parse(b);
        else
            examListSearchVm.Status = null;
        await OnSearch.InvokeAsync(examListSearchVm);
    }

    private async void Undo()
    {
        examListSearchVm.ExamName = null;
        examListSearchVm.ExamCode = null;
        examListSearchVm.Status = null;
        await OnSearch.InvokeAsync(examListSearchVm);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591