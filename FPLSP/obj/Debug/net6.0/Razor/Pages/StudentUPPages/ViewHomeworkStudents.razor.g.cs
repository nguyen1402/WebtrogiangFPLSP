#pragma checksum "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\ViewHomeworkStudents.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dfe06b4b0e8711a10524c27d2158f86e94f8fb02"
// <auto-generated/>
#pragma warning disable 1591
namespace FPLSP.Pages.StudentUPPages
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
#line 1 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\ViewHomeworkStudents.razor"
using FPLSP.Repositories.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\ViewHomeworkStudents.razor"
using FPLSP.Server.Domain.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\ViewHomeworkStudents.razor"
using FPLSP.Server.Domain.Dtos.StudentStatisticVM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\ViewHomeworkStudents.razor"
           [Authorize(Roles = "LecturerFPLSP")]

#line default
#line hidden
#nullable disable
    public partial class ViewHomeworkStudents : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\ViewHomeworkStudents.razor"
 if (ShowConfirmation)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "modal fade show d-block");
            __builder.AddAttribute(2, "id", "exampleModal");
            __builder.AddAttribute(3, "tabindex", "-1");
            __builder.AddAttribute(4, "role", "dialog");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "modal-dialog");
            __builder.AddAttribute(7, "role", "document");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "modal-content");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "modal-header");
            __builder.OpenElement(12, "h5");
            __builder.AddAttribute(13, "class", "modal-title");
            __builder.AddAttribute(14, "id", "exampleModalLabel");
#nullable restore
#line (11,69)-(11,86) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\ViewHomeworkStudents.razor"
__builder.AddContent(15, ConfirmationTitle);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "button");
            __builder.AddAttribute(18, "type", "button");
            __builder.AddAttribute(19, "class", "close");
            __builder.AddAttribute(20, "data-dismiss", "modal");
            __builder.AddAttribute(21, "aria-label", "Close");
            __builder.AddAttribute(22, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\ViewHomeworkStudents.razor"
                                  () => OnConfirmationChange(false)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(23, "<span aria-hidden=\"true\">&times;</span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "modal-body");
#nullable restore
#line 18 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\ViewHomeworkStudents.razor"
                     if (_ls.Count() > 0 || _ls == null)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(27, "table");
            __builder.AddAttribute(28, "class", "table table-hover align-middle table-bordered mt-3");
            __builder.AddAttribute(29, "style", "text-align:center");
            __builder.AddMarkupContent(30, @"<thead class=""table-success""><tr><th stype=""width:10%"">STT</th>
                                    <th stype=""width:15%"">???????ng d???n</th>
                                    <th stype=""width:20%"">Th???i gian n???p</th></tr></thead>
                            ");
            __builder.OpenElement(31, "tbody");
#nullable restore
#line 30 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\ViewHomeworkStudents.razor"
                                 foreach (var item in _ls)
                                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(32, "tr");
            __builder.OpenElement(33, "td");
#nullable restore
#line (34,46)-(34,47) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\ViewHomeworkStudents.razor"
__builder.AddContent(34, a);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 36 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\ViewHomeworkStudents.razor"
                                         if (@item.SubmitLink != "")
                                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(35, "td");
            __builder.AddAttribute(36, "class", "align-middle");
            __builder.AddAttribute(37, "title", 
#nullable restore
#line 38 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\ViewHomeworkStudents.razor"
                                                                             item.SubmitLink

#line default
#line hidden
#nullable disable
            );
            __builder.OpenElement(38, "a");
            __builder.AddAttribute(39, "href", 
#nullable restore
#line 38 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\ViewHomeworkStudents.razor"
                                                                                                        item.SubmitLink

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(40, "target", "_blank");
            __builder.AddMarkupContent(41, "?????n link");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 39 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\ViewHomeworkStudents.razor"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(42, "<td>Ch??a n???p</td>");
#nullable restore
#line 43 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\ViewHomeworkStudents.razor"
                                        }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(43, "td");
#nullable restore
#line (44,46)-(44,61) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\ViewHomeworkStudents.razor"
__builder.AddContent(44, item.SubmitTime);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 46 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\ViewHomeworkStudents.razor"
                                    a++;

                                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 51 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\ViewHomeworkStudents.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(45, "<p>R???ng</p>");
#nullable restore
#line 55 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\ViewHomeworkStudents.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                ");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "modal-footer");
            __builder.OpenElement(49, "button");
            __builder.AddAttribute(50, "type", "button");
            __builder.AddAttribute(51, "class", "btn btn-secondary");
            __builder.AddAttribute(52, "data-dismiss", "modal");
            __builder.AddAttribute(53, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 59 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\ViewHomeworkStudents.razor"
                                  () => OnConfirmationChange(false)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(54, "\r\n                        ????ng\r\n                    ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 70 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\ViewHomeworkStudents.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 76 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\ViewHomeworkStudents.razor"
       
    [Inject] NavigationManager _navigationManager { get; set; }


    protected bool ShowConfirmation { get; set; }
    [Inject]
    public ISubmitHomeWorkApiClient _SubmitHomeWorkApiClient { get; set; }

    [Inject]
    public IStudentUPRepo studentUPRepo { get; set; }
    [Inject]
    public ILessonUPRepo lessonUPRepo { get; set; }
    [Parameter]
    public string ConfirmationTitle { get; set; }

    [Parameter]
    public string ConfirmationMessage { get; set; } = "Chi ti???t";

    [Parameter]
    public EventCallback<bool> ConfirmationChanged { get; set; }

    private List<SubmitHomeWorkDtos> _ls = new List<SubmitHomeWorkDtos>();
    [Parameter]
    public EventCallback<string> Confirmation { get; set; }

    [Parameter]
    public string idclass1 { get; set; }
    [Parameter]
    public string idstudent1 { get; set; }
    [Parameter]
    public string idlesoon { get; set; }

    private int a { get; set; } = 1;

    private int baihoc { get; set; } = 1;
    private bool flag = false;

    private Thongtinlop thongtinlop = new Thongtinlop();

    //protected async override Task OnInitializedAsync()
    //{

    //}
    public async void show(string idclass1, string subjectId, string idlesoon, string idstudent1)
    {
        var xlist = await _SubmitHomeWorkApiClient.GetALl();
        _ls = xlist.Where(c => c.IdClass == Guid.Parse(idclass1) && c.IdStudent == Guid.Parse(idstudent1)
        && c.IdLesson == Guid.Parse(idlesoon)).OrderByDescending(c => c.SubmitTime).ToList();

        var lssinhvien = await studentUPRepo.GetAllStudentUPAsync();
        var namer = lssinhvien.Where(c => c.Id == Guid.Parse(idstudent1)).Select(c => c.StudentName).First();
        if (namer == null)
        {
            namer = "...";
        }
        var lslesson = await lessonUPRepo.GetAll();
        var namerleson = lslesson.Where(c => c.Id == Guid.Parse(idlesoon)).Select(c => c.LessonName).First();

        if (namerleson == null)
        {
            namerleson = "...";
        }
        thongtinlop = await studentUPRepo.Thongtinlop(Guid.Parse(idclass1), Guid.Parse(subjectId));

        for (var i = 0; i < thongtinlop.Listidlesson.Count(); i++)
        {
            if (thongtinlop.Listidlesson[i].ToString() == idlesoon)
            {
                break;
            }
            else
            {
                baihoc += 1;
            }

        }
        ConfirmationTitle = $"{namer} - B??i h???c {baihoc}";
        ShowConfirmation = true;
        StateHasChanged();
    }

    protected async Task OnConfirmationChange(bool value)
    {

        if (value)
        {
            ShowConfirmation = false;

            //await Confirmation.InvokeAsync(idclass1);
            //await ConfirmationChanged.InvokeAsync(value);
        }
        else
        {
            ShowConfirmation = false;
            a = 1;
            baihoc = 1;
        }
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
