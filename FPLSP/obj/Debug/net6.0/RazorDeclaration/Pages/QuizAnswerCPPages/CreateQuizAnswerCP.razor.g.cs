// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
            Error = "Chưa chọn Mã câu hỏi";
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
#pragma warning restore 1591