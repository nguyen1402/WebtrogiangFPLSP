#pragma checksum "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesLessonCP\Detailslesson.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0faed442db31aaeb028c8e84aa6a0f723c717b5c"
// <auto-generated/>
#pragma warning disable 1591
namespace FPLSP.Pages.PagesLessonCP
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
#line 2 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesLessonCP\Detailslesson.razor"
using FPLSP.Repositories.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesLessonCP\Detailslesson.razor"
using FPLSP.Server.Domain.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesLessonCP\Detailslesson.razor"
           [Authorize(Roles = "AdminCore,AdminCS")]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/detailslesson/{id}/{idud}")]
    public partial class Detailslesson : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row pt-3");
#nullable restore
#line 6 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesLessonCP\Detailslesson.razor"
 if (lesson != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row pt-1");
            __builder.OpenElement(4, "label");
            __builder.AddAttribute(5, "for", "name");
            __builder.AddAttribute(6, "class", " col-md-6 col-form-label");
            __builder.AddMarkupContent(7, "Môn học: ");
            __builder.OpenElement(8, "b");
#nullable restore
#line (9,73)-(9,91) 24 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesLessonCP\Detailslesson.razor"
__builder.AddContent(9, lesson.SubjectCode);

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, " - ");
#nullable restore
#line (9,95)-(9,113) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesLessonCP\Detailslesson.razor"
__builder.AddContent(11, lesson.SubjectName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "row pt-1");
            __builder.OpenElement(15, "label");
            __builder.AddAttribute(16, "for", "name");
            __builder.AddAttribute(17, "class", " col-md-col-md-6 col-form-label");
            __builder.AddMarkupContent(18, "Bài học: ");
            __builder.OpenElement(19, "b");
#nullable restore
#line (12,80)-(12,97) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesLessonCP\Detailslesson.razor"
__builder.AddContent(20, lesson.LessonCode);

#line default
#line hidden
#nullable disable
            __builder.AddContent(21, " : ");
#nullable restore
#line (12,101)-(12,118) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesLessonCP\Detailslesson.razor"
__builder.AddContent(22, lesson.LessonName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n    ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "row pt-1");
            __builder.OpenElement(26, "label");
            __builder.AddAttribute(27, "for", "name");
            __builder.AddAttribute(28, "class", " col-md-col-md-6 col-form-label");
            __builder.AddMarkupContent(29, "Mô tả : ");
            __builder.OpenElement(30, "b");
#nullable restore
#line (15,79)-(15,98) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesLessonCP\Detailslesson.razor"
__builder.AddContent(31, lesson.Descriptions);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n    ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "row pt-1");
            __builder.OpenElement(35, "label");
            __builder.AddAttribute(36, "for", "name");
            __builder.AddAttribute(37, "class", " col-md-col-md-6 col-form-label");
            __builder.AddMarkupContent(38, "Tổng số buổi ");
            __builder.OpenElement(39, "b");
#nullable restore
#line (18,84)-(18,101) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesLessonCP\Detailslesson.razor"
__builder.AddContent(40, lesson.TotalOfSub);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n    ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "row pt-1");
            __builder.OpenElement(44, "label");
            __builder.AddAttribute(45, "for", "name");
            __builder.AddAttribute(46, "class", " col-md-col-md-6 col-form-label");
            __builder.AddMarkupContent(47, "\r\n            Trạng Thái:\r\n");
#nullable restore
#line 23 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesLessonCP\Detailslesson.razor"
             if (lesson.Status == 1)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(48, "<b>Đang học</b>");
#nullable restore
#line 26 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesLessonCP\Detailslesson.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(49, "<b>Chưa bắt đầu</b>");
#nullable restore
#line 30 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesLessonCP\Detailslesson.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n    ");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "row pt-2 col-md-1 text-center");
            __builder.OpenElement(53, "a");
            __builder.AddAttribute(54, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesLessonCP\Detailslesson.razor"
                     ()=>Quaylai()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(55, "class", "btn btn-outline-danger");
            __builder.AddMarkupContent(56, "Quay Lại");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 36 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesLessonCP\Detailslesson.razor"

}

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesLessonCP\Detailslesson.razor"
       
    private LessonDto lesson;
    [Inject]
    public NavigationManager Navigation { get; set; }

    [Inject]
    public ILessonCPRepo _iLessonClient { get; set; }
    public bool ShowAuthError { get; set; }
    public string Error { get; set; }

    [Parameter]
    public string idud { get; set; }
    [Parameter]
    public string id { get; set; }
    protected async override Task OnInitializedAsync()
    {
        lesson = await _iLessonClient.GetbyId(Guid.Parse(idud));
    }

    private async Task Quaylai()
    {
        var url = Path.Combine("/lesson", id);
        Navigation.NavigateTo(url);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
