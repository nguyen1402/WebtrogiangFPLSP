#pragma checksum "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\AnswerUp\AnswerUpAdd.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "324ba9c1ee1445ef1cbd779007982b311ece8b0f"
// <auto-generated/>
#pragma warning disable 1591
namespace FPLSP.Pages.AnswerUp
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
#line 4 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\AnswerUp\AnswerUpAdd.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\AnswerUp\AnswerUpAdd.razor"
using FPLSP.Repositories.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\AnswerUp\AnswerUpAdd.razor"
using FPLSP.Server.Domain.Dtos.QuizQuestionUPDto;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\AnswerUp\AnswerUpAdd.razor"
using FPLSP.Server.Infrastructure.ViewModels.AnswerUp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\AnswerUp\AnswerUpAdd.razor"
using FPLSP.Server.Infrastructure.ViewModels.QuizQuestionUp;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/answerup/add")]
    public partial class AnswerUpAdd : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>QuizQuestionAdd</h3>\r\n\r\n\r\n");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Web.PageTitle>(1);
            __builder.AddAttribute(2, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(3, "FPLSP | Elearning");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.EditForm>(5);
            __builder.AddAttribute(6, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Object>(
#nullable restore
#line 12 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\AnswerUp\AnswerUpAdd.razor"
                  answer

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n    ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationSummary>(10);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n     ");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "mb-3");
                __builder2.AddMarkupContent(14, "<label>QuestionTital</label>\r\n        ");
                global::__Blazor.FPLSP.Pages.AnswerUp.AnswerUpAdd.TypeInference.CreateInputSelect_0(__builder2, 15, 16, "form-control", 17, 
#nullable restore
#line 17 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\AnswerUp\AnswerUpAdd.razor"
                                                       QuizQuestionUpVm.Id

#line default
#line hidden
#nullable disable
                , 18, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => QuizQuestionUpVm.Id = __value, QuizQuestionUpVm.Id)), 19, () => QuizQuestionUpVm.Id, 20, (__builder3) => {
                    __builder3.AddMarkupContent(21, "<option value>Ch???n m??n h???c</option>");
#nullable restore
#line 19 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\AnswerUp\AnswerUpAdd.razor"
             if (quizQuestionUpDto != null)
                {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\AnswerUp\AnswerUpAdd.razor"
                 foreach (var item in quizQuestionUpDto)
                    {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(22, "option");
                    __builder3.AddAttribute(23, "value", 
#nullable restore
#line 23 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\AnswerUp\AnswerUpAdd.razor"
                                    item.Id

#line default
#line hidden
#nullable disable
                    );
#nullable restore
#line (23,47)-(23,65) 26 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\AnswerUp\AnswerUpAdd.razor"
__builder3.AddContent(24, item.QuestionTital);

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
#nullable restore
#line 24 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\AnswerUp\AnswerUpAdd.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\AnswerUp\AnswerUpAdd.razor"
                 
                }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.AddMarkupContent(25, "\r\n        ");
                global::__Blazor.FPLSP.Pages.AnswerUp.AnswerUpAdd.TypeInference.CreateValidationMessage_1(__builder2, 26, 27, 
#nullable restore
#line 27 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\AnswerUp\AnswerUpAdd.razor"
                                ()=>QuizQuestionUpVm.QuestionTital

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(28, "\r\n    ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "mb-3");
                __builder2.AddMarkupContent(31, "<label for=\"exampleFormControlInput1\" class=\"form-label\">Answer :</label>\r\n        ");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(32);
                __builder2.AddAttribute(33, "id", "exampleFormControlInput1");
                __builder2.AddAttribute(34, "placeholder", "Please type QuestionTital");
                __builder2.AddAttribute(35, "class", "form-control");
                __builder2.AddAttribute(36, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 30 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\AnswerUp\AnswerUpAdd.razor"
                                 answer.Answer

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(37, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => answer.Answer = __value, answer.Answer))));
                __builder2.AddAttribute(38, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => answer.Answer));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(39, "\r\n        ");
                global::__Blazor.FPLSP.Pages.AnswerUp.AnswerUpAdd.TypeInference.CreateValidationMessage_2(__builder2, 40, 41, 
#nullable restore
#line 31 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\AnswerUp\AnswerUpAdd.razor"
                                  () => answer.Answer

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n    <hr>\r\n    ");
                __builder2.OpenElement(43, "div");
                __builder2.AddAttribute(44, "class", "col");
                __builder2.OpenElement(45, "button");
                __builder2.AddAttribute(46, "class", "btn btn-info");
                __builder2.AddAttribute(47, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 35 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\AnswerUp\AnswerUpAdd.razor"
                                               Add

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(48, "Th??m");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n        ");
                __builder2.AddMarkupContent(50, "<button class=\"btn btn-outline-danger\"><a href=\"/answerup\">Tho??t</a></button>");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\AnswerUp\AnswerUpAdd.razor"
       
    [Inject] IQuizQuestionUPRepo _quizQuestionUPRepo { get; set; }
    [Inject] IAnswerUPRepo _answerUPRepo { get; set; }
    [Inject] NavigationManager NavigationManager { get; set; }
    AnswerUpVm answer = new AnswerUpVm();
    List<QuizQuestionUpDto> quizQuestionUpDto = new List<QuizQuestionUpDto>();
    QuizQuestionUpVm QuizQuestionUpVm = new QuizQuestionUpVm();
    protected override async Task OnInitializedAsync()
    {
        quizQuestionUpDto = await _quizQuestionUPRepo.GetAll();

    }
    protected async Task Add()
    {
        answer.QuizQuestionId = QuizQuestionUpVm.Id;
        if (await _answerUPRepo.AddAnswer(answer))
        {
            NavigationManager.NavigateTo("/answerup");
        }
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.FPLSP.Pages.AnswerUp.AnswerUpAdd
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
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
    }
}
#pragma warning restore 1591
