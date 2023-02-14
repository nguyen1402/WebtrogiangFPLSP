// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FPLSP.Pages.PagesSubjectCP
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
#line 2 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSubjectCP\CreatSubject.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSubjectCP\CreatSubject.razor"
using FPLSP.Data.Securities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSubjectCP\CreatSubject.razor"
using FPLSP.Repositories;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSubjectCP\CreatSubject.razor"
using FPLSP.Repositories.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSubjectCP\CreatSubject.razor"
using FPLSP.Server.Domain.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSubjectCP\CreatSubject.razor"
using FPLSP.Server.Infrastructure.ViewModels.Subject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSubjectCP\CreatSubject.razor"
           [Authorize(Roles = "AdminCore,AdminCS")]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/createsubject/{idspecializedNonDecrypt}")]
    public partial class CreatSubject : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 119 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSubjectCP\CreatSubject.razor"
       
    [Parameter]
    public int lever { get; set; }
    [Parameter]
    public string image { get; set; }
    Uri uri;
    string maxlevel = "";
    string IdCoSo = "";
    [Parameter]
    public string idspecializedNonDecrypt { get; set; }
    public string idspecialized = "";
    private SubjectCreateVM subject = new SubjectCreateVM();
    [Inject]
    public NavigationManager Navigation { get; set; }

    [Inject]
    public ISubjectClient _iSubjectClient { get; set; }

    [Inject]
    public CryptoServices _cryptoServices { get; set; }

    [Inject]
    public ISpecializedCPRepo _iSpecialized { get; set; }

    public List<SpecializedDto> _lsSpecialized;
    public List<SpecializedDto> _lsSpecialized2;
    public List<SpecializedDto> _lsSpecialized3;
    [Inject] private IToastService _toastService { get; set; }
    public bool ShowAuthError { get; set; }
    [Parameter]
    public string Error { get; set; }
    public SpecializedDto specializedDto = new SpecializedDto();
    string namespecialized { get; set; }
    protected Comfirmation Confirmation { get; set; }
    protected async override Task OnInitializedAsync()
    {
        uri = Navigation.ToAbsoluteUri(Navigation.Uri);
        if (string.IsNullOrEmpty(uri.Query) == false)
        {
            var urifist = uri.Query.Split("?")[1];
            maxlevel = _cryptoServices.Decrypt(urifist.Split("LDN01")[0].Replace("I0H", "/"));
            IdCoSo = _cryptoServices.Decrypt(urifist.Split("LDN01")[1].Replace("I0H", "/"));
        }
        idspecialized = _cryptoServices.Decrypt(idspecializedNonDecrypt.Replace("I0H", "/"));
        await GetTasks();
    }
    private async Task GetTasks()
    {
        specializedDto = await _iSpecialized.GetbyId(Guid.Empty, Guid.Parse(idspecialized));
        namespecialized = specializedDto.SpecializationName;
        subject.TotalOfSub = 20;
    }

    private async Task Create()
    {
        ShowAuthError = false;
        subject.idspec = Guid.Parse(idspecialized);
        subject.Id = Guid.NewGuid();
        TimeSpan date = subject.EndDay - subject.StartDay;
        TimeSpan day = DateTime.Now - subject.EndDay;
        var allsubject = await _iSubjectClient.GetAllSubjectByIdSpecialzed(Guid.Parse(idspecialized));
        var subjectcode = allsubject.Where(p => p.SubjectCode == subject.SubjectCode).ToList();
        if (subjectcode.Count > 0)
        {
            _toastService.ShowError("Mã môn học đã được sử dụng");
            Navigation.NavigateTo("/createsubject/" + idspecialized.ToString());
        }
        else
        {
            var result = await _iSubjectClient.CreateSubject(subject);

            if (result != 1)
            {
                _toastService.ShowError("Lỗi");
                Navigation.NavigateTo("/createsubject/" + idspecialized.ToString());

            }
            else
            {
                _toastService.ShowSuccess("Thêm thành công");
                Confirmation.show();

            }
        }


    }
    private void AssignImageUrl(string imgUrl)
    {
        subject.Image = imgUrl;
    }


    private void ClearForm()
    {
        image = null;
        subject.TotalOfSub = 20;
        subject.SubjectName = null;
        subject.SubjectCode = null;
        subject.StartDay = DateTime.Now;
        subject.EndDay = DateTime.Now;
    }
    public async Task OnConfirmation(bool confirmed)
    {
        if (confirmed)
        {
            var url = Path.Combine("/createlesson/" + _cryptoServices.Encrypt((idspecialized).ToString()).Replace("/", "I0H") + "/" + _cryptoServices.Encrypt((subject.Id).ToString()).Replace("/", "I0H")) + $"?{_cryptoServices.Encrypt((maxlevel).ToString()).Replace("/", "I0H") + "LDN01" + _cryptoServices.Encrypt((IdCoSo).ToString()).Replace("/", "I0H")}";
            Navigation.NavigateTo(url);
        }
        else
        {
            Navigation.NavigateTo("/subjects/" + _cryptoServices.Encrypt((idspecialized).ToString()).Replace("/", "I0H"));
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
