// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FPLSP.Pages.QuizQuesstionQuizCP
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
#line 2 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuizQuesstionQuizCP\QuizQuesstionUpdateAnserQuizCp.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuizQuesstionQuizCP\QuizQuesstionUpdateAnserQuizCp.razor"
using FPLSP.Data.Securities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuizQuesstionQuizCP\QuizQuesstionUpdateAnserQuizCp.razor"
using FPLSP.Repositories;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuizQuesstionQuizCP\QuizQuesstionUpdateAnserQuizCp.razor"
using FPLSP.Repositories.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuizQuesstionQuizCP\QuizQuesstionUpdateAnserQuizCp.razor"
using FPLSP.Server.Domain.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuizQuesstionQuizCP\QuizQuesstionUpdateAnserQuizCp.razor"
using FPLSP.Server.Domain.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuizQuesstionQuizCP\QuizQuesstionUpdateAnserQuizCp.razor"
using FPLSP.Server.Infrastructure.ViewModels.QuizQuesstionQuizCP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuizQuesstionQuizCP\QuizQuesstionUpdateAnserQuizCp.razor"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuizQuesstionQuizCP\QuizQuesstionUpdateAnserQuizCp.razor"
           [Authorize(Roles = "AdminCore,AdminCS")]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/quizQuesstionUpdateAnserQuiz/{idspecializedNonDecrypt}/{idsubjectNonDecrypt}/{idquizNonDecrypt}/{idquizquesstionquizNonDecrypt}/")]
    public partial class QuizQuesstionUpdateAnserQuizCp : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 311 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\QuizQuesstionQuizCP\QuizQuesstionUpdateAnserQuizCp.razor"
       
    [Parameter]
    public string idquizNonDecrypt { get; set; }
    public string idquiz = "";
    [Parameter]
    public string idquizquesstionquizNonDecrypt { get; set; }
    public string idquizquesstionquiz = "";

    [Parameter]
    public string idsubjectNonDecrypt { get; set; }
    public string idsubject = "";
    [Parameter]
    public string idspecializedNonDecrypt { get; set; }
    public string idspecialized = "";

    private QuizQuesstionQuizCPUpdateVM lessonContent { get; set; } = new QuizQuesstionQuizCPUpdateVM();
    [Inject]
    public NavigationManager Navigation { get; set; }
    public int f = 0;
    public int g = 0;
    public int countAnswer = 0;
    public int answerquestion = 0;
    [Inject]
    public IQuizQuesstionQuizCPClient _iQuizQuesstionQuizCPClient { get; set; }

    public QuizQuesstionQuizCPDto CP;
    public QuizQuesstionQuizCPDto UndoQuizQuestionQuiz;
    public bool ShowAuthError { get; set; }
    [Inject] private IToastService _toastService { get; set; }
    [Inject]
    public CryptoServices _cryptoServices { get; set; }
    [Parameter]
    public string Error { get; set; }
    private SubjectDto subject { get; set; } = new SubjectDto();
    [Inject]
    ISubjectClient _iSubjectClient { get; set; }
    public SpecializedDto specializedDto { get; set; } = new SpecializedDto();
    string namespecialized { get; set; }
    [Inject]
    public ISpecializedCPRepo _iSpecialized { get; set; }
    public string nameQuiz { get; set; }
    [Inject]
    public IQuizCPRepo _iQuizCPRepo { get; set; }
    Uri uri;
    string maxlevel = "";
    string IdCoSo = "";
    protected async override Task OnInitializedAsync()
    {
        uri = Navigation.ToAbsoluteUri(Navigation.Uri);
        if (string.IsNullOrEmpty(uri.Query) == false)
        {
            var urifist = uri.Query.Split("?")[1];
            maxlevel = _cryptoServices.Decrypt(urifist.Split("LDN01")[0].Replace("I0H", "/"));
            IdCoSo = _cryptoServices.Decrypt(urifist.Split("LDN01")[1].Replace("I0H", "/"));
        }
        idquiz = _cryptoServices.Decrypt(idquizNonDecrypt.Replace("I0H", "/"));
        idsubject = _cryptoServices.Decrypt(idsubjectNonDecrypt.Replace("I0H", "/"));
        idquizquesstionquiz = _cryptoServices.Decrypt(idquizquesstionquizNonDecrypt.Replace("I0H", "/"));
        idspecialized = _cryptoServices.Decrypt(idspecializedNonDecrypt.Replace("I0H", "/"));
        var quiz = await _iQuizCPRepo.GetQuizById(Guid.Parse(idquiz));
        nameQuiz = quiz.QuizName;
        specializedDto = await _iSpecialized.GetbyId(Guid.Empty, Guid.Parse(idspecialized));
        namespecialized = specializedDto.SpecializationName;
        CP = await _iQuizQuesstionQuizCPClient.GetbyId(Guid.Parse(idquizquesstionquiz));
        UndoQuizQuestionQuiz = CP;

        lessonContent = new QuizQuesstionQuizCPUpdateVM()
            {
                StatusQuizQuiz = CP.StatusQuizQuiz,
                ContentQuestion = CP.ContentQuestion,
                QuestionForm = CP.QuestionForm,
                lsAnswer = CP.Answers,
                lsIsCorrect = CP.lsIsCorrect,
            };
        for (var i = 0; i < lessonContent.lsAnswer.Count; i++)
        {
            if (i == 0)
            {
                lessonContent.Answer = lessonContent.lsAnswer[i];
                lessonContent.IsCorrect = lessonContent.lsIsCorrect[i];
            }
            if (i == 1)
            {
                lessonContent.Answer2 = lessonContent.lsAnswer[i];
                lessonContent.IsCorrect2 = lessonContent.lsIsCorrect[i];
            }
            if (i == 2)
            {
                lessonContent.Answer3 = lessonContent.lsAnswer[i];
                lessonContent.IsCorrect3 = lessonContent.lsIsCorrect[i];
            }
            if (i == 3)
            {
                lessonContent.Answer4 = lessonContent.lsAnswer[i];
                lessonContent.IsCorrect4 = lessonContent.lsIsCorrect[i];
            }
        }
    }
    private async Task Update()
    {
        Regex trimmer = new Regex(@"\s\s+");
        lessonContent.StatusQuizQuiz = 1;
        lessonContent.ContentQuestion = lessonContent.ContentQuestion.Trim();
        lessonContent.ContentQuestion = trimmer.Replace(lessonContent.ContentQuestion, "");
        lessonContent.lsAnswer = new List<string>();
        lessonContent.lsIsCorrect = new List<bool>();
        if (lessonContent.QuestionForm == QuestionForms.YesNo)
        {
            lessonContent.Answer = "Yes";
            lessonContent.lsAnswer.Add(lessonContent.Answer);
            lessonContent.lsIsCorrect.Add(lessonContent.IsCorrect);

            lessonContent.Answer2 = "No";
            lessonContent.lsAnswer.Add(lessonContent.Answer2);
            lessonContent.lsIsCorrect.Add(lessonContent.IsCorrect2);

            for (int i = 0; i < lessonContent.lsIsCorrect.Count; i++)
            {
                if (lessonContent.lsIsCorrect[i] == false)
                {
                    f += 1;
                }
                if (lessonContent.lsIsCorrect[i] == true)
                {
                    g += 1;
                }
            }
            if (f == 2 || g == 2)
            {
                _toastService.ShowError("Kh??ng ???????c c?? 2 ????p ??n gi???ng nhau");
                var url = Path.Combine($"/quizQuesstionUpdateAnserQuiz/{_cryptoServices.Encrypt((idspecialized).ToString()).Replace("/", "I0H")}/{_cryptoServices.Encrypt((idsubject).ToString()).Replace("/", "I0H")}/{_cryptoServices.Encrypt((idquiz).ToString()).Replace("/", "I0H")}/{_cryptoServices.Encrypt((idquizquesstionquiz).ToString()).Replace("/", "I0H")}?{_cryptoServices.Encrypt((maxlevel).ToString()).Replace("/", "I0H") + "LDN01" + _cryptoServices.Encrypt((IdCoSo).ToString()).Replace("/", "I0H")}");

                Navigation.NavigateTo(url);
                f = 0;
                g = 0;
                return;
            }
        }
        else if (lessonContent.QuestionForm == QuestionForms.MultipleChoise)
        {
            lessonContent.lsAnswer.Clear();
            lessonContent.lsIsCorrect.Clear();
            countAnswer = 0;
            f = 0;
            g = 0;
            lessonContent.lsAnswer.Add(lessonContent.Answer);
            lessonContent.lsIsCorrect.Add(lessonContent.IsCorrect);

            lessonContent.lsAnswer.Add(lessonContent.Answer2);
            lessonContent.lsIsCorrect.Add(lessonContent.IsCorrect2);

            lessonContent.lsAnswer.Add(lessonContent.Answer3);
            lessonContent.lsIsCorrect.Add(lessonContent.IsCorrect3);

            lessonContent.lsAnswer.Add(lessonContent.Answer4);
            lessonContent.lsIsCorrect.Add(lessonContent.IsCorrect4);
            for (int i = 0; i < lessonContent.lsIsCorrect.Count; i++)
            {
                if (lessonContent.lsIsCorrect[i] == false)
                {
                    f += 1;
                }
                if (lessonContent.lsAnswer[i] == "")
                {
                    countAnswer += 1;
                }
            }
            for (int i = 0; i < lessonContent.lsAnswer.Count; i++)
            {
                for (int j = i + 1; j < lessonContent.lsAnswer.Count; j++)
                {
                    if (lessonContent.lsAnswer[i] == lessonContent.lsAnswer[j])
                    {
                        answerquestion += 1;
                    }
                }


            }
            if (countAnswer >= 1)
            {
                _toastService.ShowError("Ph???i nh???p ????? 4 c??u tr??? l???i");
                var url = Path.Combine($"/quizQuesstionUpdateAnserQuiz/{_cryptoServices.Encrypt((idspecialized).ToString()).Replace("/", "I0H")}/{_cryptoServices.Encrypt((idsubject).ToString()).Replace("/", "I0H")}/{_cryptoServices.Encrypt((idquiz).ToString()).Replace("/", "I0H")}/{_cryptoServices.Encrypt((idquizquesstionquiz).ToString()).Replace("/", "I0H")}?{_cryptoServices.Encrypt((maxlevel).ToString()).Replace("/", "I0H") + "LDN01" + _cryptoServices.Encrypt((IdCoSo).ToString()).Replace("/", "I0H")}");
                Navigation.NavigateTo(url);
                countAnswer = 0;
                return;
            }
            if (answerquestion > 0)
            {
                _toastService.ShowError("Kh??ng ???????c c?? c??u tr??? l???i tr??ng nhau");
                var url = Path.Combine($"/createquizQuesstionQuizCP/{_cryptoServices.Encrypt((idspecialized).ToString()).Replace("/", "I0H")}/{_cryptoServices.Encrypt((idsubject).ToString()).Replace("/", "I0H")}/{_cryptoServices.Encrypt((idquiz).ToString()).Replace("/", "I0H")}?{_cryptoServices.Encrypt((maxlevel).ToString()).Replace("/", "I0H") + "LDN01" + _cryptoServices.Encrypt((IdCoSo).ToString()).Replace("/", "I0H")}");

                Navigation.NavigateTo(url);
                answerquestion = 0;
                return;
            }
            else if (f == 4)
            {
                _toastService.ShowError("Kh??ng ???????c c?? 4 ????p ??n sai");
                var url = Path.Combine($"/quizQuesstionUpdateAnserQuiz/{_cryptoServices.Encrypt((idspecialized).ToString()).Replace("/", "I0H")}/{_cryptoServices.Encrypt((idsubject).ToString()).Replace("/", "I0H")}/{_cryptoServices.Encrypt((idquiz).ToString()).Replace("/", "I0H")}/{_cryptoServices.Encrypt((idquizquesstionquiz).ToString()).Replace("/", "I0H")}?{_cryptoServices.Encrypt((maxlevel).ToString()).Replace("/", "I0H") + "LDN01" + _cryptoServices.Encrypt((IdCoSo).ToString()).Replace("/", "I0H")}");
                 Navigation.NavigateTo(url);
                f = 0;
                return;
            }
        }
        else if (lessonContent.QuestionForm == QuestionForms.SupplyItems)
        {
            lessonContent.lsAnswer.Add(lessonContent.Answer);
            lessonContent.IsCorrect = true;
            lessonContent.lsIsCorrect.Add(lessonContent.IsCorrect);
            if (lessonContent.Answer == "")
            {
                _toastService.ShowError("B???n ch??a nh???p c??u tr??? l???i");
                var url = Path.Combine($"/quizQuesstionUpdateAnserQuiz/{_cryptoServices.Encrypt((idspecialized).ToString()).Replace("/", "I0H")}/{_cryptoServices.Encrypt((idsubject).ToString()).Replace("/", "I0H")}/{_cryptoServices.Encrypt((idquiz).ToString()).Replace("/", "I0H")}/{_cryptoServices.Encrypt((idquizquesstionquiz).ToString()).Replace("/", "I0H")}?{_cryptoServices.Encrypt((maxlevel).ToString()).Replace("/", "I0H") + "LDN01" + _cryptoServices.Encrypt((IdCoSo).ToString()).Replace("/", "I0H")}");
                Navigation.NavigateTo(url);
                return;
            }
        }
        else if (lessonContent.QuestionForm == QuestionForms.MatchingItems)
        {
            lessonContent.lsAnswer.Clear();
            lessonContent.lsIsCorrect.Clear();
            countAnswer = 0;
            g = 0;
            f = 0;
            lessonContent.lsAnswer.Add(lessonContent.Answer);
            lessonContent.lsIsCorrect.Add(lessonContent.IsCorrect);

            lessonContent.lsAnswer.Add(lessonContent.Answer2);
            lessonContent.lsIsCorrect.Add(lessonContent.IsCorrect2);

            lessonContent.lsAnswer.Add(lessonContent.Answer3);
            lessonContent.lsIsCorrect.Add(lessonContent.IsCorrect3);

            lessonContent.lsAnswer.Add(lessonContent.Answer4);
            lessonContent.lsIsCorrect.Add(lessonContent.IsCorrect4);

            for (int i = 0; i < lessonContent.lsIsCorrect.Count; i++)
            {
                if (lessonContent.lsIsCorrect[i] == true)
                {
                    f += 1;
                }
                if (lessonContent.lsIsCorrect[i] == false)
                {
                    g += 1;
                }
                if (lessonContent.lsAnswer[i] == "")
                {
                    countAnswer += 1;
                }
            }
            for (int i = 0; i < lessonContent.lsAnswer.Count; i++)
            {
                for (int j = i + 1; j < lessonContent.lsAnswer.Count; j++)
                {
                    if (lessonContent.lsAnswer[i] == lessonContent.lsAnswer[j])
                    {
                        answerquestion += 1;
                    }
                }


            }
            if (countAnswer >= 1)
            {
                _toastService.ShowError("Ph???i nh???p ????? 4 c??u tr??? l???i");
               var url = Path.Combine($"/quizQuesstionUpdateAnserQuiz/{_cryptoServices.Encrypt((idspecialized).ToString()).Replace("/", "I0H")}/{_cryptoServices.Encrypt((idsubject).ToString()).Replace("/", "I0H")}/{_cryptoServices.Encrypt((idquiz).ToString()).Replace("/", "I0H")}/{_cryptoServices.Encrypt((idquizquesstionquiz).ToString()).Replace("/", "I0H")}?{_cryptoServices.Encrypt((maxlevel).ToString()).Replace("/", "I0H") + "LDN01" + _cryptoServices.Encrypt((IdCoSo).ToString()).Replace("/", "I0H")}");
                 Navigation.NavigateTo(url);
                countAnswer = 0;
                return;
            }
            if (answerquestion > 0)
            {
                _toastService.ShowError("Kh??ng ???????c c?? c??u tr??? l???i tr??ng nhau");
                var url = Path.Combine($"/quizQuesstionUpdateAnserQuiz/{_cryptoServices.Encrypt((idspecialized).ToString()).Replace("/", "I0H")}/{_cryptoServices.Encrypt((idsubject).ToString()).Replace("/", "I0H")}/{_cryptoServices.Encrypt((idquiz).ToString()).Replace("/", "I0H")}/{_cryptoServices.Encrypt((idquizquesstionquiz).ToString()).Replace("/", "I0H")}?{_cryptoServices.Encrypt((maxlevel).ToString()).Replace("/", "I0H") + "LDN01" + _cryptoServices.Encrypt((IdCoSo).ToString()).Replace("/", "I0H")}");
                Navigation.NavigateTo(url);
                answerquestion = 0;
                return;
            }
            if (g == 4)
            {
                _toastService.ShowError("Kh??ng ???????c c?? 4 c??u tr??? l???i sai!");
                var url = Path.Combine($"/quizQuesstionUpdateAnserQuiz/{_cryptoServices.Encrypt((idspecialized).ToString()).Replace("/", "I0H")}/{_cryptoServices.Encrypt((idsubject).ToString()).Replace("/", "I0H")}/{_cryptoServices.Encrypt((idquiz).ToString()).Replace("/", "I0H")}/{_cryptoServices.Encrypt((idquizquesstionquiz).ToString()).Replace("/", "I0H")}?{_cryptoServices.Encrypt((maxlevel).ToString()).Replace("/", "I0H") + "LDN01" + _cryptoServices.Encrypt((IdCoSo).ToString()).Replace("/", "I0H")}");
                Navigation.NavigateTo(url);
                g = 0;
                return;
            }
            if (f > 1)
            {
                _toastService.ShowError("Kh??ng ???????c c?? nhi???u h??n 1 ????p ??n ????ng!");
                var url = Path.Combine($"/quizQuesstionUpdateAnserQuiz/{_cryptoServices.Encrypt((idspecialized).ToString()).Replace("/", "I0H")}/{_cryptoServices.Encrypt((idsubject).ToString()).Replace("/", "I0H")}/{_cryptoServices.Encrypt((idquiz).ToString()).Replace("/", "I0H")}/{_cryptoServices.Encrypt((idquizquesstionquiz).ToString()).Replace("/", "I0H")}?{_cryptoServices.Encrypt((maxlevel).ToString()).Replace("/", "I0H") + "LDN01" + _cryptoServices.Encrypt((IdCoSo).ToString()).Replace("/", "I0H")}");
                Navigation.NavigateTo(url);
                f = 0;
                return;
            }

        }
        var result = await _iQuizQuesstionQuizCPClient.Update(Guid.Parse(idquizquesstionquiz), lessonContent);

        if (result != 1)
        {
            _toastService.ShowError("Ch??a c???p nh???t ???????c!");
            var url = Path.Combine($"/quizQuesstionUpdateAnserQuiz/{_cryptoServices.Encrypt((idspecialized).ToString()).Replace("/", "I0H")}/{_cryptoServices.Encrypt((idsubject).ToString()).Replace("/", "I0H")}/{_cryptoServices.Encrypt((idquiz).ToString()).Replace("/", "I0H")}/{_cryptoServices.Encrypt((idquizquesstionquiz).ToString()).Replace("/", "I0H")}?{_cryptoServices.Encrypt((maxlevel).ToString()).Replace("/", "I0H") + "LDN01" + _cryptoServices.Encrypt((IdCoSo).ToString()).Replace("/", "I0H")}");
            Navigation.NavigateTo(url);
        }
        else
        {
            _toastService.ShowSuccess("C???p nh???t th??nh c??ng!");
            var url = Path.Combine($"/quizQuesstionQuizCP/{_cryptoServices.Encrypt((idspecialized).ToString()).Replace("/", "I0H")}/{_cryptoServices.Encrypt((idsubject).ToString()).Replace("/", "I0H")}/{_cryptoServices.Encrypt((idquiz).ToString()).Replace("/", "I0H")}?{_cryptoServices.Encrypt((maxlevel).ToString()).Replace("/", "I0H") + "LDN01" + _cryptoServices.Encrypt((IdCoSo).ToString()).Replace("/", "I0H")}");

            Navigation.NavigateTo(url);
        }

    }

    private async Task Quaylai()
    {
        var url = Path.Combine($"/quizQuesstionQuizCP/{_cryptoServices.Encrypt((idspecialized).ToString()).Replace("/", "I0H")}/{_cryptoServices.Encrypt((idsubject).ToString()).Replace("/", "I0H")}/{_cryptoServices.Encrypt((idquiz).ToString()).Replace("/", "I0H")}?{_cryptoServices.Encrypt((maxlevel).ToString()).Replace("/", "I0H") + "LDN01" + _cryptoServices.Encrypt((IdCoSo).ToString()).Replace("/", "I0H")}");
        Navigation.NavigateTo(url);
    }
    private async void KhoiPhuc()
    {
        lessonContent = new QuizQuesstionQuizCPUpdateVM()
            {
                StatusQuizQuiz = UndoQuizQuestionQuiz.StatusQuizQuiz,
                ContentQuestion = UndoQuizQuestionQuiz.ContentQuestion,
                QuestionForm = UndoQuizQuestionQuiz.QuestionForm,
                lsAnswer = UndoQuizQuestionQuiz.Answers,
                lsIsCorrect = UndoQuizQuestionQuiz.lsIsCorrect,
            };
        for (var i = 0; i < lessonContent.lsAnswer.Count; i++)
        {
            if (i == 0)
            {
                lessonContent.Answer = lessonContent.lsAnswer[i];
                lessonContent.IsCorrect = lessonContent.lsIsCorrect[i];
            }
            if (i == 1)
            {
                lessonContent.Answer2 = lessonContent.lsAnswer[i];
                lessonContent.IsCorrect2 = lessonContent.lsIsCorrect[i];
            }
            if (i == 2)
            {
                lessonContent.Answer3 = lessonContent.lsAnswer[i];
                lessonContent.IsCorrect3 = lessonContent.lsIsCorrect[i];
            }
            if (i == 3)
            {
                lessonContent.Answer4 = lessonContent.lsAnswer[i];
                lessonContent.IsCorrect4 = lessonContent.lsIsCorrect[i];
            }
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
