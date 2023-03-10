// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FPLSP.Pages.ManageNews
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
#line 2 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ManageNews\ManageNews.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ManageNews\ManageNews.razor"
using FPLSP.Data.Securities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ManageNews\ManageNews.razor"
using FPLSP.Repositories.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ManageNews\ManageNews.razor"
using FPLSP.Server.Domain.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ManageNews\ManageNews.razor"
using FPLSP.Server.Domain.Dtos.StudentStatisticVM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ManageNews\ManageNews.razor"
using FPLSP.Server.Infrastructure.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ManageNews\ManageNews.razor"
using FPLSP.Server.Infrastructure.ViewModels.NewFeed;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ManageNews\ManageNews.razor"
           [Authorize(Roles = "LecturerFPLSP")]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/news/{joinCodeNonDecrypt}/{idUserNonDecrypt}/{subjectIdNonDecrypt}/{specializedIdNonDecrypt}/{idclassNonDecrypt}")]
    public partial class ManageNews : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 112 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ManageNews\ManageNews.razor"
       
    [Parameter]
    public string joinCodeNonDecrypt { get; set; }
    [Parameter]
    public string idUserNonDecrypt { get; set; }
    [Parameter]
    public string specializedIdNonDecrypt { get; set; }
    [Parameter]
    public string subjectIdNonDecrypt { get; set; }
    [Parameter]
    public string idclassNonDecrypt { get; set; }


    public string joinCode = "";

    public string idUser = "";
    
    public string specializedId = "";
    
    public string subjectId = "";
    
    public string idclass = "";

    [Inject] NavigationManager navigationManager { get; set; }
    [Inject] IToastService _toast { get; set; }
    [Inject] private INewFeedRepo _newFeedRepo { get; set; }
    private Thongtinlop thongtinlop = new Thongtinlop();
    

    [Inject]
    public IStudentUPRepo _iStudentUPRepo { get; set; }
    [Inject]
    public ISpecializedCPRepo _iSpecializedClient { get; set; }
    [Inject]
    private ITaskRepositories<ClassUPViewModel> _classRepositories { get; set; }
    CreateClassVM classSearch = new CreateClassVM();

    List<NewFeedOverView> _lstNews;

    private bool _isNotLecturer { get; set; }
    private byte countNews = 1;


    public List<SpecializedDto> lstSpecAll { get; set; } = new List<SpecializedDto>();
    [Inject]
    public CryptoServices _cryptoServices { get; set; }
    public ManageNews()
    {
    }

    protected override async Task OnInitializedAsync()
    {
        idUser = _cryptoServices.Decrypt(idUserNonDecrypt.Replace("I0H", "/"));
        subjectId = _cryptoServices.Decrypt(subjectIdNonDecrypt.Replace("I0H", "/"));
        specializedId = _cryptoServices.Decrypt(specializedIdNonDecrypt.Replace("I0H", "/"));
        joinCode = _cryptoServices.Decrypt(joinCodeNonDecrypt.Replace("I0H", "/"));
        idclass = _cryptoServices.Decrypt(idclassNonDecrypt.Replace("I0H", "/"));

        thongtinlop = await _iStudentUPRepo.Thongtinlop(Guid.Parse(idclass), Guid.Parse(subjectId));
        lstSpecAll = await _iSpecializedClient.GetAll();
        countNews = 1;
        classSearch = await _classRepositories.GetClassById(joinCode);

        _lstNews = await _newFeedRepo.GetListNewForClass(classSearch.Id, classSearch.SubjectId);
        await CheckUser(classSearch.HomeroomLecturerId, Guid.Parse(idUser));
    }

    private async Task CheckUser(Guid idLecturer, Guid idUserInput)
    {
        _isNotLecturer = (idLecturer != idUserInput);

        if (_isNotLecturer)
        {
            _lstNews = _lstNews.Where(c => c.Status == 0).ToList();
        }
    }

    protected async Task ShowOrHide(Guid idNews)
    {
        var newsSearch = _lstNews.Where(c => c.Id == idNews).FirstOrDefault();

        if (newsSearch.Status == 0)
        {
            newsSearch.Status = 1;
        }
        else
        {
            newsSearch.Status = 0;
        }

        await Update(idNews, newsSearch);
    }

    private async Task Update(Guid idNews, NewFeedOverView newFeedOverView)
    {
        var res = await _newFeedRepo.UpdateNewFeed(idNews, new NewFeedVM()
                        {
                            Id = newFeedOverView.Id,
                            Title = newFeedOverView.Title,
                            Content = newFeedOverView.Content,
                            IdLesson = newFeedOverView.IdLesson,
                            Image = newFeedOverView.Image,
                            Status = newFeedOverView.Status,
                            CratedTime = newFeedOverView.CratedTime,
                            EndDate = newFeedOverView.EndDate,
                            Priority = newFeedOverView.Priority,
                            IsReaded = newFeedOverView.IsReaded,
                            IdUser = newFeedOverView.IdUser,
                            IdClass = newFeedOverView.IdClass,
                            IdSubject = newFeedOverView.IdSubject,
                            IdTypeOfNewFeed = newFeedOverView.IdTypeOfNewFeed,
                        });
        if (res)
        {
            _toast.ShowSuccess($"C???p Nh???t link t??i nguy??n th??nh c??ng");
            await this.OnInitializedAsync();
        }
        else
        {
            _toast.ShowError($"C???p Nh???t link t??i nguy??n th???t b???i");
            await this.OnInitializedAsync();
        }
    }

    private async Task Quaylai()
    {
        var url = Path.Combine($"/ViewChiTitet/{idclassNonDecrypt}/{specializedIdNonDecrypt}/{idUserNonDecrypt}/{subjectIdNonDecrypt}");
        navigationManager.NavigateTo(url);
    }
    private async Task ResToSpec()
    {
        var url = Path.Combine($"/LectuterSpecializedSubjectls/{idUserNonDecrypt}/{specializedIdNonDecrypt}");
        navigationManager.NavigateTo(url);
    }
    private async Task Mon()
    {
        var url = Path.Combine($"/Giaovien/{specializedIdNonDecrypt}/{idUserNonDecrypt}/{subjectIdNonDecrypt}");
        navigationManager.NavigateTo(url);
    }
    private async Task RedirectToDetails()
    {
        var url = Path.Combine($"/ViewChiTitet/{idclassNonDecrypt}/{specializedIdNonDecrypt}/{idUserNonDecrypt}/{subjectIdNonDecrypt}");
        navigationManager.NavigateTo(url);
    }

    private async Task RedirectToAddTaiLieu()
    {
        var url = Path.Combine($"/resoucrelinkforstudent/{joinCodeNonDecrypt}/{idclassNonDecrypt}/{specializedIdNonDecrypt}/{idUserNonDecrypt}/{subjectIdNonDecrypt}");
        navigationManager.NavigateTo(url);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
