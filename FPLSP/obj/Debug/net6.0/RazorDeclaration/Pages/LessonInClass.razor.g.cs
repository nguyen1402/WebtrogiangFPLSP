// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FPLSP.Pages
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
#line 2 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LessonInClass.razor"
using FPLSP.Repositories.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LessonInClass.razor"
using FPLSP.Server.Domain.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LessonInClass.razor"
using FPLSP.Server.Infrastructure.ViewModels.LessonContentUP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LessonInClass.razor"
using FPLSP.Server.Infrastructure.ViewModels.LessonUP;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/lessoninclass/{Id}")]
    public partial class LessonInClass : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 37 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LessonInClass.razor"
       
    [Parameter]
    public List<LessonUPViewModel> ListLesson { get; set; } = new List<LessonUPViewModel>();
    public Dictionary<Guid, List<LessonContentUPViewModel>> listLessonContent = new Dictionary<Guid, List<LessonContentUPViewModel>>();

    [Inject]
    public NavigationManager NavigationManager { get; set; }
    [Inject]
    public ILessonUPRepo _iLessonClient { get; set; }
    [Inject]
    public ILessonContentUPRepo _iLessonContentRepo { get; set; }
    private SubjectDto subject = new SubjectDto();
    [Inject]
    public ISubjectUPRepo _iSubjectRepo { get; set; }
    public string Error { get; set; }
    [Parameter]
    public string Id { get; set; }
    protected async override Task OnInitializedAsync()
    {
        subject = await _iSubjectRepo.GetSubjectbyId(Guid.Parse(Id));
        if (subject != null)
        {
            await GetListLesson();
        }
    }

    private async Task GetListLesson()
    {
        try
        {
            ListLesson = await _iLessonClient.GetAll();
            ListLesson = ListLesson.Where(c => c.SubjectId == subject.Id).ToList();

            foreach (var item in ListLesson)
            {
                listLessonContent.Add(item.Id, await GetLessonContents(item.Id));
            }
        }
        catch (Exception ex)
        {
            Error = ex.Message;
        }

    }

    private async Task<List<LessonContentUPViewModel>> GetLessonContents(Guid idLS)
    {
        var x = await _iLessonContentRepo.GetAll();
        var result = x.Where(c => c.LessonId == idLS).ToList();
        return result;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
