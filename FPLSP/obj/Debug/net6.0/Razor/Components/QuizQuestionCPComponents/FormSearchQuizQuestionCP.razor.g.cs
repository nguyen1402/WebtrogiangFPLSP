#pragma checksum "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\QuizQuestionCPComponents\FormSearchQuizQuestionCP.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f7f48167aa23bd44655367e461e2c8bd8431a50"
// <auto-generated/>
#pragma warning disable 1591
namespace FPLSP.Components.QuizQuestionCPComponents
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
#line 1 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\QuizQuestionCPComponents\FormSearchQuizQuestionCP.razor"
using FPLSP.Repositories.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\QuizQuestionCPComponents\FormSearchQuizQuestionCP.razor"
using FPLSP.Server.Domain.Dtos.KindOfQuestionCPDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\QuizQuestionCPComponents\FormSearchQuizQuestionCP.razor"
using FPLSP.Server.Infrastructure.ViewModels.KìnOfQuestionCPVm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\QuizQuestionCPComponents\FormSearchQuizQuestionCP.razor"
using FPLSP.Server.Infrastructure.ViewModels.QuizQuestionCPVm;

#line default
#line hidden
#nullable disable
    public partial class FormSearchQuizQuestionCP : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Object>(
#nullable restore
#line 7 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\QuizQuestionCPComponents\FormSearchQuizQuestionCP.razor"
                  _quizquestionCPListSearch

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Forms.EditContext>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 7 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\QuizQuestionCPComponents\FormSearchQuizQuestionCP.razor"
                                                        SearchForm

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "row");
                __builder2.OpenElement(6, "div");
                __builder2.AddAttribute(7, "class", "col-3");
                global::__Blazor.FPLSP.Components.QuizQuestionCPComponents.FormSearchQuizQuestionCP.TypeInference.CreateInputSelect_0(__builder2, 8, 9, "name", 10, "form-control", 11, 
#nullable restore
#line 10 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\QuizQuestionCPComponents\FormSearchQuizQuestionCP.razor"
                                                                     _quizquestionCPListSearch.KindoOfQuestionId

#line default
#line hidden
#nullable disable
                , 12, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _quizquestionCPListSearch.KindoOfQuestionId = __value, _quizquestionCPListSearch.KindoOfQuestionId)), 13, () => _quizquestionCPListSearch.KindoOfQuestionId, 14, (__builder3) => {
                    __builder3.AddMarkupContent(15, "<option value>Tất cả</option>");
#nullable restore
#line 12 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\QuizQuestionCPComponents\FormSearchQuizQuestionCP.razor"
                 foreach (var item in ListKOQCP)
                {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(16, "option");
                    __builder3.AddAttribute(17, "value", 
#nullable restore
#line 14 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\QuizQuestionCPComponents\FormSearchQuizQuestionCP.razor"
                                    item.Id

#line default
#line hidden
#nullable disable
                    );
#nullable restore
#line (14,47)-(14,64) 26 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\QuizQuestionCPComponents\FormSearchQuizQuestionCP.razor"
__builder3.AddContent(18, item.QuestionForm);

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(19, "-");
#nullable restore
#line (14,66)-(14,87) 26 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\QuizQuestionCPComponents\FormSearchQuizQuestionCP.razor"
__builder3.AddContent(20, item.QuestionTypeName);

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
#nullable restore
#line 15 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\QuizQuestionCPComponents\FormSearchQuizQuestionCP.razor"
                }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(21, "\r\n        ");
                __builder2.OpenElement(22, "div");
                __builder2.AddAttribute(23, "class", "col-4");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(24);
                __builder2.AddAttribute(25, "placeholder", "Tên câu hỏi");
                __builder2.AddAttribute(26, "class", "form-control");
                __builder2.AddAttribute(27, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 19 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\QuizQuestionCPComponents\FormSearchQuizQuestionCP.razor"
                                                                                   _quizquestionCPListSearch.QuizQuestionName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _quizquestionCPListSearch.QuizQuestionName = __value, _quizquestionCPListSearch.QuizQuestionName))));
                __builder2.AddAttribute(29, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _quizquestionCPListSearch.QuizQuestionName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n        ");
                __builder2.OpenElement(31, "div");
                __builder2.AddAttribute(32, "class", "col-3");
                global::__Blazor.FPLSP.Components.QuizQuestionCPComponents.FormSearchQuizQuestionCP.TypeInference.CreateInputSelect_1(__builder2, 33, 34, "name", 35, "form-control", 36, 
#nullable restore
#line 22 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\QuizQuestionCPComponents\FormSearchQuizQuestionCP.razor"
                                                                     _quizquestionCPListSearch.Status

#line default
#line hidden
#nullable disable
                , 37, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _quizquestionCPListSearch.Status = __value, _quizquestionCPListSearch.Status)), 38, () => _quizquestionCPListSearch.Status, 39, (__builder3) => {
                    __builder3.AddMarkupContent(40, "<option value>Tất cả</option>\r\n                ");
                    __builder3.AddMarkupContent(41, "<option value=\"0\">Đang hoạt động</option>\r\n                ");
                    __builder3.AddMarkupContent(42, "<option value=\"1\">Ngưng hoạt động</option>");
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n        ");
                __builder2.AddMarkupContent(44, "<div class=\"col-2\"><button type=\"submit\" class=\"btn btn-success\">Tìm kiếm</button></div>");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\QuizQuestionCPComponents\FormSearchQuizQuestionCP.razor"
      
    [Parameter]
        public EventCallback<ListQuizQuestionSearch> OnSearch { get; set; }

        private ListQuizQuestionSearch _quizquestionCPListSearch = new ListQuizQuestionSearch();
        public List<KindOfQuestionCPDtos> ListKOQCP { get; set; } = new List<KindOfQuestionCPDtos>();
        [Inject] public IKindoOfQuestionCPRepo _koqCPClient { get; set; }

        private ListKOQCPSearch KOQCPListSearch = new ListKOQCPSearch();
        private async Task SearchForm(EditContext context)
        {
            await OnSearch.InvokeAsync(_quizquestionCPListSearch);
        }
        protected async override Task OnInitializedAsync()
        {
            var pagingResponse = await _koqCPClient.GetKOQList(KOQCPListSearch);
            ListKOQCP = pagingResponse.Items;
        }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.FPLSP.Components.QuizQuestionCPComponents.FormSearchQuizQuestionCP
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
        public static void CreateInputSelect_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Object __arg0, int __seq1, global::System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
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
