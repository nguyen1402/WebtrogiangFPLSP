// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FPLSP.Pages.PagesSubjectUP
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
#line 2 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSubjectUP\UpdateSubjectUP.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSubjectUP\UpdateSubjectUP.razor"
using FPLSP.Repositories.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSubjectUP\UpdateSubjectUP.razor"
using FPLSP.Server.Domain.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSubjectUP\UpdateSubjectUP.razor"
using FPLSP.Server.Infrastructure.ViewModels.Subject;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/updatesubjectup/{idsubject}/{idspecializedUP}")]
    public partial class UpdateSubjectUP : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 103 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSubjectUP\UpdateSubjectUP.razor"
      
    private SubjectDto subject = new SubjectDto();
    private SubjectUpdateVM subjectVM = new SubjectUpdateVM();
    [Inject]
    public NavigationManager Navigation { get; set; }

    [Inject]
    private ISubjectUPRepo _subjectUPRepo { get; set; }
    [Inject] private IToastService ToastService { get; set; }

    [Parameter]
    public string idsubject { get; set; }
    [Parameter]
    public string idspecializedUP { get; set; }

    protected async override Task OnInitializedAsync()
    {
        subject = await _subjectUPRepo.GetSubjectbyId(Guid.Parse(idsubject));
    }
    private async Task Update()
    {
        try
        {
            subjectVM = new SubjectUpdateVM()
                {
                    SubjectCode = subject.SubjectCode,
                    SubjectName = subject.SubjectName,
                    TotalOfSub = subject.TotalOfSub,
                    StartDay = subject.StartDay,
                    EndDay = subject.EndDay,
                    Image = subject.Image,
                    Status = subject.Status,
                };
            var result = await _subjectUPRepo.UpdateSubject(Guid.Parse(idsubject), subjectVM);
            if (!result)
            {
                ToastService.ShowError("C???p nh???t th???t b???i, ki???m tra l???i");
            }
            else
            {
                Navigation.NavigateTo("/listsubjects");
                ToastService.ShowSuccess("C???p nh???t th??nh c??ng");
            }
        }

        catch (Exception)
        {
            ToastService.ShowError("???? x???y ra l???i, th??? l???i sau");
        }

    }
    private async Task Resorte()
    {
        subject = await _subjectUPRepo.GetSubjectbyId(Guid.Parse(idsubject));
    }

    private void AssignImageUrl(string Image) => subject.Image = Image;

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
