#pragma checksum "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ManageHomeWork\ManageAllHomeWork.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4fef4ff0a47c1a3653da964acbd3b6535b4bbd1"
// <auto-generated/>
#pragma warning disable 1591
namespace FPLSP.Pages.ManageHomeWork
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
#line 2 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ManageHomeWork\ManageAllHomeWork.razor"
using FPLSP.Repositories.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ManageHomeWork\ManageAllHomeWork.razor"
using FPLSP.Repositories.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ManageHomeWork\ManageAllHomeWork.razor"
using FPLSP.Server.Domain.Entities.UserParts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ManageHomeWork\ManageAllHomeWork.razor"
using FPLSP.Server.Infrastructure.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ManageHomeWork\ManageAllHomeWork.razor"
using FPLSP.Server.Infrastructure.ViewModels.LessonUP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ManageHomeWork\ManageAllHomeWork.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/manageallhomework/{lecturerId}")]
    public partial class ManageAllHomeWork : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 9 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ManageHomeWork\ManageAllHomeWork.razor"
 foreach (var classUP in _lstClassUP)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<global::MudBlazor.MudPaper>(0);
            __builder.AddAttribute(1, "Width", "940px");
            __builder.AddAttribute(2, "Elevation", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 11 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ManageHomeWork\ManageAllHomeWork.razor"
                                       0

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<global::MudBlazor.MudTreeView<string>>(4);
                __builder2.AddAttribute(5, "ExpandOnClick", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 12 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ManageHomeWork\ManageAllHomeWork.razor"
                                               true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(6, "Hover", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 12 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ManageHomeWork\ManageAllHomeWork.razor"
                                                            true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(7, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(8, "div");
                    __builder3.AddAttribute(9, "class", "row m-0");
                    __builder3.AddMarkupContent(10, "p\r\n                ");
                    __builder3.OpenElement(11, "div");
                    __builder3.AddAttribute(12, "class", "col-lg-11");
                    global::__Blazor.FPLSP.Pages.ManageHomeWork.ManageAllHomeWork.TypeInference.CreateMudTreeViewItem_0(__builder3, 13, 14, 
#nullable restore
#line 15 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ManageHomeWork\ManageAllHomeWork.razor"
                                              classUP.ClassroomName +"-"+ classUP.SubjectName

#line default
#line hidden
#nullable disable
                    , 15, (__builder4) => {
#nullable restore
#line 16 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ManageHomeWork\ManageAllHomeWork.razor"
                         if (_lstLesson.Any(c => c.SubjectId == classUP.SubjectId))
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ManageHomeWork\ManageAllHomeWork.razor"
                             foreach (var lesson in _lstLesson.Where(c => c.SubjectId == classUP.SubjectId).ToList())
                            {
                                if (_lstSubmitHomework.Any(c => c.IdClass == classUP.Id && c.IdSubject == Guid.Parse(classUP.SubjectId.ToString()) && c.IdLesson == lesson.Id))
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ManageHomeWork\ManageAllHomeWork.razor"
                                     foreach (var homeWork in GetHomeWorksInClass(classUP.Id, Guid.Parse(classUP.SubjectId.ToString()), lesson.Id))
                                    {

#line default
#line hidden
#nullable disable
                        __builder4.OpenElement(16, "div");
                        __builder4.AddAttribute(17, "class", "list-group-item d-flex align-items-center");
                        __builder4.OpenElement(18, "div");
                        __builder4.AddAttribute(19, "class", "flex-fill d-flex justify-content-start");
                        __builder4.OpenElement(20, "div");
                        __builder4.AddAttribute(21, "class", "text-dark font-weight-600");
                        __builder4.OpenElement(22, "strong");
#nullable restore
#line (26,97)-(26,114) 26 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ManageHomeWork\ManageAllHomeWork.razor"
__builder4.AddContent(23, lesson.LessonName);

#line default
#line hidden
#nullable disable
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                        __builder4.CloseElement();
                        __builder4.AddMarkupContent(24, "\r\n                                            ");
                        __builder4.AddMarkupContent(25, "<button class=\"btn btn-outline-warning\" onclick>Chi Tiết</button>\r\n                                            ");
                        __builder4.AddMarkupContent(26, "<button class=\"btn btn-outline-success\" onclick>Chỉnh Sửa</button>");
                        __builder4.CloseElement();
#nullable restore
#line 31 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ManageHomeWork\ManageAllHomeWork.razor"

                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ManageHomeWork\ManageAllHomeWork.razor"
                                     
                                }
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ManageHomeWork\ManageAllHomeWork.razor"
                             
                        }

#line default
#line hidden
#nullable disable
                    }
                    );
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 41 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ManageHomeWork\ManageAllHomeWork.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ManageHomeWork\ManageAllHomeWork.razor"
      
    [Parameter]
    public string lecturerId { get; set; }

    [Inject]
    ITaskRepositories<ClassUPViewModel> _classUPRepo { get; set; }
    private List<ClassUPViewModel> _lstClassUP { get; set; } = new List<ClassUPViewModel>();
    [Inject]
    ILessonUPRepo _lessonUPRepo { get; set; }
    private List<LessonUPViewModel> _lstLesson { get; set; } = new List<LessonUPViewModel>();
    [Inject]
    ISubmitHomeworkForStudentRepo _submitHomeworkRepo { get; set; }
    private List<SubmitHomeWork> _lstSubmitHomework { get; set; } = new List<SubmitHomeWork>();

    protected override async Task OnInitializedAsync()
    {
        _lstClassUP = await _classUPRepo.GetAllClass();
        _lstClassUP = _lstClassUP.Where(c => c.HomeroomLecturerId == Guid.Parse(lecturerId)).ToList();

        _lstLesson = await _lessonUPRepo.GetAll();
        _lstSubmitHomework = await _submitHomeworkRepo.Student_GetAllAsync();
    }

    private List<SubmitHomeWork> GetHomeWorksInClass(Guid classId, Guid subjectId, Guid lessonId)
    {
        return _lstSubmitHomework.Where(c => c.IdClass == classId && c.IdSubject == subjectId && c.IdLesson == lessonId).ToList();
    }

    private async Task UpdateHomeWork()
    {

    }
    private async Task DeleteHomeWork()
    {

    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.FPLSP.Pages.ManageHomeWork.ManageAllHomeWork
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTreeViewItem_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, T __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::MudBlazor.MudTreeViewItem<T>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ChildContent", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591