#pragma checksum "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuizAnswerCPPages\CreateQuizAnswerCP.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "044abbaf8317e5fbe2b58f851dc8e44c26649b7b"
// <auto-generated/>
#pragma warning disable 1591
namespace FPLSP.Pages.QuizAnswerCPPages
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
#line 2 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuizAnswerCPPages\CreateQuizAnswerCP.razor"
using FPLSP.Repositories.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuizAnswerCPPages\CreateQuizAnswerCP.razor"
using FPLSP.Server.Domain.Dtos.QuizQuestionCPDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuizAnswerCPPages\CreateQuizAnswerCP.razor"
using FPLSP.Server.Domain.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuizAnswerCPPages\CreateQuizAnswerCP.razor"
using FPLSP.Server.Infrastructure.ViewModels.QuizAnswerCPVm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuizAnswerCPPages\CreateQuizAnswerCP.razor"
using FPLSP.Server.Infrastructure.ViewModels.QuizQuestionCPVm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuizAnswerCPPages\CreateQuizAnswerCP.razor"
           [Authorize(Roles = "AdminCore,AdminCS")]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/CreateQuizAnswerCP")]
    public partial class CreateQuizAnswerCP : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Th??m QuizAnswer</h3>\r\n");
            __builder.AddMarkupContent(1, "<div class=\"row mt-3 mb-3\"><div class=\"form-group pt-2 col-12\"><div class=\"row pt-2 col-1 ms-0 text-right\"><a href=\"/MainQuizAnswerCP\" class=\"btn btn-outline-danger\">Quay L???i</a></div></div></div>");
#nullable restore
#line 17 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuizAnswerCPPages\CreateQuizAnswerCP.razor"
 if (ShowAuthError)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "alert alert-danger");
            __builder.AddAttribute(4, "role", "alert");
#nullable restore
#line (20,10)-(20,15) 24 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuizAnswerCPPages\CreateQuizAnswerCP.razor"
__builder.AddContent(5, Error);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 22 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuizAnswerCPPages\CreateQuizAnswerCP.razor"
}

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.EditForm>(6);
            __builder.AddAttribute(7, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Object>(
#nullable restore
#line 23 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuizAnswerCPPages\CreateQuizAnswerCP.razor"
                 QuizAnswer

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Forms.EditContext>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 23 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuizAnswerCPPages\CreateQuizAnswerCP.razor"
                                            Create

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(9, "class", "card card-body bg-light mt-3");
            __builder.AddAttribute(10, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(11);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\r\n    ");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "form-group");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "row");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "form-group pt-2 col-md-6");
                __builder2.AddMarkupContent(19, "<label for=\"name\" class=\"col-md-2 col-form-label\">M?? C??u H???i:</label>\r\n                ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "col-md-12");
                global::__Blazor.FPLSP.Pages.QuizAnswerCPPages.CreateQuizAnswerCP.TypeInference.CreateInputSelect_0(__builder2, 22, 23, "name", 24, "form-control", 25, 
#nullable restore
#line 30 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuizAnswerCPPages\CreateQuizAnswerCP.razor"
                                                                             QuizAnswer.IdQuizQuestion

#line default
#line hidden
#nullable disable
                , 26, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => QuizAnswer.IdQuizQuestion = __value, QuizAnswer.IdQuizQuestion)), 27, () => QuizAnswer.IdQuizQuestion, 28, (__builder3) => {
                    __builder3.AddMarkupContent(29, "<option value>M?? c??u h???i</option>");
#nullable restore
#line 32 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuizAnswerCPPages\CreateQuizAnswerCP.razor"
                         foreach (var item in ListQuizQuestionCP)
                        {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(30, "option");
                    __builder3.AddAttribute(31, "value", 
#nullable restore
#line 34 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuizAnswerCPPages\CreateQuizAnswerCP.razor"
                                            item.Id

#line default
#line hidden
#nullable disable
                    );
#nullable restore
#line (34,55)-(34,72) 26 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuizAnswerCPPages\CreateQuizAnswerCP.razor"
__builder3.AddContent(32, item.QuestionCode);

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(33, " - ");
#nullable restore
#line (34,76)-(34,93) 26 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuizAnswerCPPages\CreateQuizAnswerCP.razor"
__builder3.AddContent(34, item.QuestionName);

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
#nullable restore
#line 35 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuizAnswerCPPages\CreateQuizAnswerCP.razor"
                        }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.AddMarkupContent(35, "\r\n                    ");
                global::__Blazor.FPLSP.Pages.QuizAnswerCPPages.CreateQuizAnswerCP.TypeInference.CreateValidationMessage_1(__builder2, 36, 37, 
#nullable restore
#line 37 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuizAnswerCPPages\CreateQuizAnswerCP.razor"
                                              () => QuizAnswer.IdQuizQuestion

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n            ");
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "class", "form-group pt-2 col-md-6");
                __builder2.AddMarkupContent(41, "<label for=\"name\" class=\"col-md-2 col-form-label\">C??u tr??? l???i:</label>\r\n                ");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "col-md-12");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(44);
                __builder2.AddAttribute(45, "id", "name");
                __builder2.AddAttribute(46, "class", "form-control");
                __builder2.AddAttribute(47, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 43 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuizAnswerCPPages\CreateQuizAnswerCP.razor"
                                                                           QuizAnswer.Answer

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(48, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => QuizAnswer.Answer = __value, QuizAnswer.Answer))));
                __builder2.AddAttribute(49, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => QuizAnswer.Answer));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(50, "\r\n                    ");
                global::__Blazor.FPLSP.Pages.QuizAnswerCPPages.CreateQuizAnswerCP.TypeInference.CreateValidationMessage_2(__builder2, 51, 52, 
#nullable restore
#line 44 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuizAnswerCPPages\CreateQuizAnswerCP.razor"
                                              () => QuizAnswer.Answer

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\r\n        <div class=\"row\"></div>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n\r\n    ");
                __builder2.AddMarkupContent(55, "<div class=\"row pt-2\"><div class=\"col-md-12 text-center\"><button type=\"submit\" class=\"btn btn-success\">Th??m QuizAnswer</button></div></div>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 58 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuizAnswerCPPages\CreateQuizAnswerCP.razor"
       
    private ListQuizQuestionSearch QuizQuestionCPListSearch = new ListQuizQuestionSearch();
    [Inject] public NavigationManager Navigation { get; set; }
    public bool ShowAuthError { get; set; }
    [Parameter]
    public string Error { get; set; }
    public List<QuizQuestionCPDtos> ListQuizQuestionCP { get; set; } = new List<QuizQuestionCPDtos>();
    public CreateQuizAnswerCPVm QuizAnswer { get; set; } = new CreateQuizAnswerCPVm();
    [Inject] public IQuizQuestionCPRepo _quizQuestionCPClient { get; set; }
    [Inject] public IQuizAnswerCPRepo _quizanswerCPClient { get; set; }
    protected async override Task OnInitializedAsync()
    {
        var pagingResponse = await _quizQuestionCPClient.GetQuizQuestionList(QuizQuestionCPListSearch);
        ListQuizQuestionCP = pagingResponse.Items;
    }
    private async Task Create()
    {

        ShowAuthError = false;
        var result = await _quizanswerCPClient.CreateQuizAnswerCP(QuizAnswer);

        if (result != 1)
        {
            Error = "Ch??a ch???n M?? c??u h???i";
            ShowAuthError = true;
            Navigation.NavigateTo("/CreateQuizAnswerCP");
        }
        else
        {
            Navigation.NavigateTo("/MainQuizAnswerCP");

        }


    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.FPLSP.Pages.QuizAnswerCPPages.CreateQuizAnswerCP
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
