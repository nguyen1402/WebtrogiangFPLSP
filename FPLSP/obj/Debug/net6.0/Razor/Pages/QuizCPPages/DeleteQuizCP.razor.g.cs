#pragma checksum "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuizCPPages\DeleteQuizCP.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef40ac2d337a7b865426b442e5bfd5d7b757af71"
// <auto-generated/>
#pragma warning disable 1591
namespace FPLSP.Pages.QuizCPPages
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
#line 2 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuizCPPages\DeleteQuizCP.razor"
using FPLSP.Repositories.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuizCPPages\DeleteQuizCP.razor"
using FPLSP.Server.Domain.Dtos.QuizCPDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuizCPPages\DeleteQuizCP.razor"
           [Authorize(Roles = "AdminCore,AdminCS")]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/DeleteQuizCP/{Id}/{idsubject}")]
    public partial class DeleteQuizCP : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Xóa Quiz</h3>");
#nullable restore
#line 7 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuizCPPages\DeleteQuizCP.razor"
 if (quiz != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "form-group");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "form-group pt-2 col-md-4");
            __builder.OpenElement(7, "label");
            __builder.AddAttribute(8, "for", "name");
            __builder.AddAttribute(9, "class", "col-md-6 col-form-label");
            __builder.AddMarkupContent(10, "Tên Quiz: ");
            __builder.OpenElement(11, "b");
#nullable restore
#line (12,81)-(12,94) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuizCPPages\DeleteQuizCP.razor"
__builder.AddContent(12, quiz.QuizName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "row");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "form-group pt-2 col-md-4");
            __builder.OpenElement(18, "label");
            __builder.AddAttribute(19, "for", "name");
            __builder.AddAttribute(20, "class", "col-md-6 col-form-label");
            __builder.AddContent(21, "Email: ");
            __builder.OpenElement(22, "b");
#nullable restore
#line (17,78)-(17,95) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuizCPPages\DeleteQuizCP.razor"
__builder.AddContent(23, quiz.Descriptions);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n        ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "row");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "form-group pt-2 col-md-3");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.EditForm>(29);
            __builder.AddAttribute(30, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Object>(
#nullable restore
#line 22 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuizCPPages\DeleteQuizCP.razor"
                                 quiz

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(31, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Forms.EditContext>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 22 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuizCPPages\DeleteQuizCP.razor"
                                                      Delete

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(32, "class", "card card-body bg-light mt-3");
            __builder.AddAttribute(33, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(34);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(35, "\r\n                    ");
                __builder2.AddMarkupContent(36, "<div class=\"form-group row\"><label for=\"name\" class=\"row\"><p><b style=\"color : red\">Bạn có muốn xóa không ?</b></p></label></div>\r\n                    ");
                __builder2.OpenElement(37, "div");
                __builder2.AddAttribute(38, "class", "row");
                __builder2.AddMarkupContent(39, "<div class=\"col-md-2 text-center\"><button type=\"submit\" class=\"btn btn-danger\">Xóa</button></div>\r\n                        ");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "col-md-6 text-center");
                __builder2.OpenElement(42, "a");
                __builder2.AddAttribute(43, "class", "btn btn-primary");
                __builder2.AddAttribute(44, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuizCPPages\DeleteQuizCP.razor"
                                                                 () => RedirectToMain()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(45, "Quay Lại");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n            <div class=\"form-group pt-2 col-md-4\"></div>");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 47 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuizCPPages\DeleteQuizCP.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuizCPPages\DeleteQuizCP.razor"
       
    public SubjectQuizCPDtos quiz;
    [Inject]
    public NavigationManager Navigation { get; set; }
    [Inject] public IQuizCPRepo _iQuizCPClient { get; set; }

    [Parameter]
    public string Id { get; set; }
    [Parameter]
    public string idsubject { get; set; }
    protected async override Task OnInitializedAsync()
    {
        quiz = await _iQuizCPClient.GetQuizById(Guid.Parse(Id));
        quiz.StartDay = quiz.StartDay;
        quiz.EndDay = quiz.EndDay;
        quiz.Status = 1;
    }
    private async Task Delete()
    {
        //await _iQuizCPClient.UpdateQuizCP(Guid.Parse(Id),quiz);
        var url = Path.Combine("/MainQuizsCP", idsubject.ToString());
        Navigation.NavigateTo(url);
    }
    private async Task RedirectToMain()
    {
        var url = Path.Combine("/MainQuizsCP", idsubject.ToString());
        Navigation.NavigateTo(url);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591