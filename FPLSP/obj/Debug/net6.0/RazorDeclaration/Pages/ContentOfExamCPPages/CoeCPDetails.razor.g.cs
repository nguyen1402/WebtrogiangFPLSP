// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FPLSP.Pages.ContentOfExamCPPages
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
#line 2 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ContentOfExamCPPages\CoeCPDetails.razor"
using FPLSP.Repositories.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ContentOfExamCPPages\CoeCPDetails.razor"
using FPLSP.Server.Domain.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ContentOfExamCPPages\CoeCPDetails.razor"
using FPLSP.Server.Infrastructure.ViewModels.Exams;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/CoeCPDetails/{id:guid}")]
    public partial class CoeCPDetails : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 108 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ContentOfExamCPPages\CoeCPDetails.razor"
      
    private ContentOfExamCPDto _Dto;
    [Inject] private IContentOfExamCPRepo contentOfExamCPRepo { get; set; }

    [Inject] private IExamCPServicesRepo examApiClient { get; set; }
    [Inject] private NavigationManager _navier { get; set; }

    private List<ExamCPDto> _lstExam;
    private ExamListSearchVm _examListSearchVm;
    public CoeCPDetails()
    {
        _examListSearchVm = new ExamListSearchVm();
        _lstExam = new List<ExamCPDto>();
    }
    [Parameter]
    public Guid Id { get; set; }

    protected async override Task OnInitializedAsync()
    {
        await Get();
    }
    private async Task Get()
    {

        var pagingResponse = await examApiClient.GetExamCPList(_examListSearchVm);
        _lstExam = pagingResponse.Items;
        var examCp = await contentOfExamCPRepo.GetCoeCPById(Id);
        var examDto = new ContentOfExamCPDto()
            {
                EndDate = examCp.EndDate,
                CoeCode = examCp.CoeCode,
                DateStarted = examCp.DateStarted,
                Level = examCp.Level,
                Status = examCp.Status,
                Content = examCp.Content,
                ExamId = examCp.ExamId,
                TotalOfQuestions = examCp.TotalOfQuestions,
                QuestionType = examCp.QuestionType,
                DateCreated = examCp.DateCreated,
                Id = examCp.Id,

            };
        _Dto = examDto;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
