#pragma checksum "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\QuizAnswerCPComponents\FormSearchQuizAnswerCP.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "becf337d8c2938e76a34973a879ac5357546fcff"
// <auto-generated/>
#pragma warning disable 1591
namespace FPLSP.Components.QuizAnswerCPComponents
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
#line 1 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\QuizAnswerCPComponents\FormSearchQuizAnswerCP.razor"
using FPLSP.Repositories.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\QuizAnswerCPComponents\FormSearchQuizAnswerCP.razor"
using FPLSP.Server.Domain.Dtos.QuizAnswerCPDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\QuizAnswerCPComponents\FormSearchQuizAnswerCP.razor"
using FPLSP.Server.Infrastructure.ViewModels.QuizAnswerCPVm;

#line default
#line hidden
#nullable disable
    public partial class FormSearchQuizAnswerCP : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Object>(
#nullable restore
#line 7 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\QuizAnswerCPComponents\FormSearchQuizAnswerCP.razor"
                  QuizAnswerCPListSearch

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Forms.EditContext>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 7 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\QuizAnswerCPComponents\FormSearchQuizAnswerCP.razor"
                                                     SearchForm

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "row");
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "col-4");
                global::__Blazor.FPLSP.Components.QuizAnswerCPComponents.FormSearchQuizAnswerCP.TypeInference.CreateInputSelect_0(__builder2, 8, 9, "name", 10, "form-control", 11, 
#nullable restore
#line 10 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\QuizAnswerCPComponents\FormSearchQuizAnswerCP.razor"
                                                                     QuizAnswerCPListSearch.QuestionCode

#line default
#line hidden
#nullable disable
                , 12, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => QuizAnswerCPListSearch.QuestionCode = __value, QuizAnswerCPListSearch.QuestionCode)), 13, () => QuizAnswerCPListSearch.QuestionCode, 14, (__builder3) => {
                    __builder3.AddMarkupContent(15, "<option value>T???t c???</option>");
#nullable restore
#line 12 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\QuizAnswerCPComponents\FormSearchQuizAnswerCP.razor"
                 foreach (var item in ListQuizAnswerCP)
                {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(16, "option");
                    __builder3.AddAttribute(17, "value", 
#nullable restore
#line 14 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\QuizAnswerCPComponents\FormSearchQuizAnswerCP.razor"
                                    item.QuestionCode

#line default
#line hidden
#nullable disable
                    );
#nullable restore
#line (14,57)-(14,74) 26 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\QuizAnswerCPComponents\FormSearchQuizAnswerCP.razor"
__builder3.AddContent(18, item.QuestionCode);

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
#nullable restore
#line 15 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\QuizAnswerCPComponents\FormSearchQuizAnswerCP.razor"
                }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n        ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "col-6");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(22);
                __builder2.AddAttribute(23, "class", "form-control");
                __builder2.AddAttribute(24, "placeholder", "Nh???p c??u tr??? l???i");
                __builder2.AddAttribute(25, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 19 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\QuizAnswerCPComponents\FormSearchQuizAnswerCP.razor"
                                                         QuizAnswerCPListSearch.Answer

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => QuizAnswerCPListSearch.Answer = __value, QuizAnswerCPListSearch.Answer))));
                __builder2.AddAttribute(27, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => QuizAnswerCPListSearch.Answer));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n        ");
                __builder2.AddMarkupContent(29, "<div class=\"col-2\"><button type=\"submit\" class=\"btn btn-success\">T??m ki???m</button></div>");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\QuizAnswerCPComponents\FormSearchQuizAnswerCP.razor"
       
    [Parameter]
    public EventCallback<ListSearchQuizAnswerCP> OnSearch { get; set; }
    private ListSearchQuizAnswerCP QuizAnswerCPListSearch = new ListSearchQuizAnswerCP();
    public List<QuizAnswerCPDtos> ListQuizAnswerCP { get; set; } = new List<QuizAnswerCPDtos>();
    [Inject] public IQuizAnswerCPRepo _iQuizAnswerCPClient { get; set; }
    protected async override Task OnInitializedAsync()
    {
        var pagingResponse = await _iQuizAnswerCPClient.GetQuizAnswerLists(QuizAnswerCPListSearch);
        ListQuizAnswerCP = pagingResponse.Items;
    }
    private async Task SearchForm(EditContext context)
    {
        await OnSearch.InvokeAsync(QuizAnswerCPListSearch);
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.FPLSP.Components.QuizAnswerCPComponents.FormSearchQuizAnswerCP
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Object __arg0, int __seq1, global::System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
