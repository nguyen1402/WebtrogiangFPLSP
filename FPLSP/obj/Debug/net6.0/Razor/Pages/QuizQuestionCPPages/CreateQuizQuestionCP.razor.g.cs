#pragma checksum "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuizQuestionCPPages\CreateQuizQuestionCP.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c45682aac5d797b1f42b79873154f76e67e63ee"
// <auto-generated/>
#pragma warning disable 1591
namespace FPLSP.Pages.QuizQuestionCPPages
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
#line 2 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuizQuestionCPPages\CreateQuizQuestionCP.razor"
using FPLSP.Repositories.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuizQuestionCPPages\CreateQuizQuestionCP.razor"
using FPLSP.Server.Domain.Dtos.KindOfQuestionCPDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuizQuestionCPPages\CreateQuizQuestionCP.razor"
using FPLSP.Server.Domain.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuizQuestionCPPages\CreateQuizQuestionCP.razor"
using FPLSP.Server.Infrastructure.ViewModels.KìnOfQuestionCPVm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuizQuestionCPPages\CreateQuizQuestionCP.razor"
using FPLSP.Server.Infrastructure.ViewModels.QuizQuestionCPVm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuizQuestionCPPages\CreateQuizQuestionCP.razor"
           [Authorize(Roles = "AdminCore,AdminCS")]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/CreateQuizQuestionCP")]
    public partial class CreateQuizQuestionCP : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Thêm QuizQuestion</h3>\r\n");
            __builder.AddMarkupContent(1, "<div class=\"row mt-3 mb-3\"><div class=\"form-group pt-2 col-12\"><div class=\"row pt-2 col-1 ms-0 text-right\"><a href=\"/MainQuizQuestionsCP\" class=\"btn btn-outline-danger\">Quay Lại</a></div></div></div>");
#nullable restore
#line 17 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuizQuestionCPPages\CreateQuizQuestionCP.razor"
 if (ShowAuthError)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "alert alert-danger");
            __builder.AddAttribute(4, "role", "alert");
#nullable restore
#line (20,10)-(20,15) 24 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuizQuestionCPPages\CreateQuizQuestionCP.razor"
__builder.AddContent(5, Error);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 22 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuizQuestionCPPages\CreateQuizQuestionCP.razor"
}

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.EditForm>(6);
            __builder.AddAttribute(7, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Object>(
#nullable restore
#line 23 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuizQuestionCPPages\CreateQuizQuestionCP.razor"
                 QuizQuestion

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Forms.EditContext>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 23 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuizQuestionCPPages\CreateQuizQuestionCP.razor"
                                              Create

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(9, "class", "card card-body bg-light mt-5");
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
                __builder2.AddMarkupContent(19, "<label for=\"name\" class=\"col-md-2 col-form-label\">Loại Câu Hỏi:</label>\r\n                ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "col-md-12");
                global::__Blazor.FPLSP.Pages.QuizQuestionCPPages.CreateQuizQuestionCP.TypeInference.CreateInputSelect_0(__builder2, 22, 23, "name", 24, "form-control", 25, 
#nullable restore
#line 30 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuizQuestionCPPages\CreateQuizQuestionCP.razor"
                                                                             QuizQuestion.KindoOfQuestionId

#line default
#line hidden
#nullable disable
                , 26, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => QuizQuestion.KindoOfQuestionId = __value, QuizQuestion.KindoOfQuestionId)), 27, () => QuizQuestion.KindoOfQuestionId, 28, (__builder3) => {
                    __builder3.AddMarkupContent(29, "<option value>Loại câu hỏi</option>");
#nullable restore
#line 32 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuizQuestionCPPages\CreateQuizQuestionCP.razor"
                         foreach (var item in ListKOQCP)
                        {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(30, "option");
                    __builder3.AddAttribute(31, "value", 
#nullable restore
#line 34 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuizQuestionCPPages\CreateQuizQuestionCP.razor"
                                            item.Id

#line default
#line hidden
#nullable disable
                    );
#nullable restore
#line (34,55)-(34,72) 26 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuizQuestionCPPages\CreateQuizQuestionCP.razor"
__builder3.AddContent(32, item.QuestionForm);

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(33, " - ");
#nullable restore
#line (34,76)-(34,97) 26 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuizQuestionCPPages\CreateQuizQuestionCP.razor"
__builder3.AddContent(34, item.QuestionTypeName);

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
#nullable restore
#line 35 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuizQuestionCPPages\CreateQuizQuestionCP.razor"
                        }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.AddMarkupContent(35, "\r\n                    ");
                global::__Blazor.FPLSP.Pages.QuizQuestionCPPages.CreateQuizQuestionCP.TypeInference.CreateValidationMessage_1(__builder2, 36, 37, 
#nullable restore
#line 37 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuizQuestionCPPages\CreateQuizQuestionCP.razor"
                                              () => QuizQuestion.KindoOfQuestionId

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n            ");
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "class", "form-group pt-2 col-md-6");
                __builder2.AddMarkupContent(41, "<label for=\"name\" class=\"col-md-2 col-form-label\">Mã Câu hỏi:</label>\r\n                ");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "col-md-12");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(44);
                __builder2.AddAttribute(45, "id", "name");
                __builder2.AddAttribute(46, "class", "form-control");
                __builder2.AddAttribute(47, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 43 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuizQuestionCPPages\CreateQuizQuestionCP.razor"
                                                                           QuizQuestion.QuestionCode

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(48, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => QuizQuestion.QuestionCode = __value, QuizQuestion.QuestionCode))));
                __builder2.AddAttribute(49, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => QuizQuestion.QuestionCode));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(50, "\r\n                    ");
                global::__Blazor.FPLSP.Pages.QuizQuestionCPPages.CreateQuizQuestionCP.TypeInference.CreateValidationMessage_2(__builder2, 51, 52, 
#nullable restore
#line 44 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuizQuestionCPPages\CreateQuizQuestionCP.razor"
                                              () => QuizQuestion.QuestionCode

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(53, "\r\n        ");
                __builder2.OpenElement(54, "div");
                __builder2.AddAttribute(55, "class", "row");
                __builder2.OpenElement(56, "div");
                __builder2.AddAttribute(57, "class", "form-group pt-2 col-md-6");
                __builder2.AddMarkupContent(58, "<label for=\"name\" class=\"col-md-2 col-form-label\">Tên Câu Hỏi:</label>\r\n                ");
                __builder2.OpenElement(59, "div");
                __builder2.AddAttribute(60, "class", "col-md-12");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(61);
                __builder2.AddAttribute(62, "id", "name");
                __builder2.AddAttribute(63, "class", "form-control");
                __builder2.AddAttribute(64, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 52 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuizQuestionCPPages\CreateQuizQuestionCP.razor"
                                                                           QuizQuestion.QuestionName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(65, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => QuizQuestion.QuestionName = __value, QuizQuestion.QuestionName))));
                __builder2.AddAttribute(66, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => QuizQuestion.QuestionName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(67, "\r\n                    ");
                global::__Blazor.FPLSP.Pages.QuizQuestionCPPages.CreateQuizQuestionCP.TypeInference.CreateValidationMessage_3(__builder2, 68, 69, 
#nullable restore
#line 53 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuizQuestionCPPages\CreateQuizQuestionCP.razor"
                                              () => QuizQuestion.QuestionName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(70, "\r\n            ");
                __builder2.OpenElement(71, "div");
                __builder2.AddAttribute(72, "class", "form-group pt-2 col-md-6");
                __builder2.AddMarkupContent(73, "<label for=\"name\" class=\"col-md-2 col-form-label\">Trạng thái:</label>\r\n                ");
                __builder2.OpenElement(74, "div");
                __builder2.AddAttribute(75, "class", "col-md-12");
                global::__Blazor.FPLSP.Pages.QuizQuestionCPPages.CreateQuizQuestionCP.TypeInference.CreateInputSelect_4(__builder2, 76, 77, "name", 78, "form-control", 79, 
#nullable restore
#line 59 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuizQuestionCPPages\CreateQuizQuestionCP.razor"
                                                                             QuizQuestion.Status

#line default
#line hidden
#nullable disable
                , 80, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => QuizQuestion.Status = __value, QuizQuestion.Status)), 81, () => QuizQuestion.Status, 82, (__builder3) => {
                    __builder3.AddMarkupContent(83, "<option value=\"0\">Đang hoạt động</option>\r\n                        ");
                    __builder3.AddMarkupContent(84, "<option value=\"1\">Ngưng hoạt động</option>");
                }
                );
                __builder2.AddMarkupContent(85, "\r\n                    ");
                global::__Blazor.FPLSP.Pages.QuizQuestionCPPages.CreateQuizQuestionCP.TypeInference.CreateValidationMessage_5(__builder2, 86, 87, 
#nullable restore
#line 63 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuizQuestionCPPages\CreateQuizQuestionCP.razor"
                                              () => QuizQuestion.Status

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(88, "\r\n        <div class=\"row\"></div>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(89, "\r\n\r\n    ");
                __builder2.AddMarkupContent(90, "<div class=\"row pt-2\"><div class=\"col-md-12 text-center\"><button type=\"submit\" class=\"btn btn-success\">Thêm QuizQuestion</button></div></div>");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 77 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuizQuestionCPPages\CreateQuizQuestionCP.razor"
       
    private ListKOQCPSearch KOQCPListSearch = new ListKOQCPSearch();
    [Inject] public NavigationManager Navigation { get; set; }
    public bool ShowAuthError { get; set; }
    [Parameter]
    public string Error { get; set; }
    public List<KindOfQuestionCPDtos> ListKOQCP { get; set; } = new List<KindOfQuestionCPDtos>();
    public CreateQuizQuestionCPVm QuizQuestion { get; set; } = new CreateQuizQuestionCPVm();
    [Inject] public IQuizQuestionCPRepo _quizQuestionCPClient { get; set; }
    [Inject] public IKindoOfQuestionCPRepo _koqCPClient { get; set; }
    protected async override Task OnInitializedAsync()
    {
        var pagingResponse = await _koqCPClient.GetKOQList(KOQCPListSearch);
        ListKOQCP = pagingResponse.Items;
    }
    private async Task Create()
    {

        ShowAuthError = false;
        var result = await _quizQuestionCPClient.CreateQuizQuestionCP(QuizQuestion);

        if (result != 1)
        {
            Error = "Lỗi";
            ShowAuthError = true;
            Navigation.NavigateTo("/CreateQuizQuestionCP");
        }
        else
        {
            Navigation.NavigateTo("/MainQuizQuestionsCP");

        }


    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.FPLSP.Pages.QuizQuestionCPPages.CreateQuizQuestionCP
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
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Object __arg0, int __seq1, global::System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
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
        public static void CreateValidationMessage_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
