// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FPLSP.Pages.ReportUps
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
#line 2 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ReportUps\ReportCreate.razor"
using FPLSP.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ReportUps\ReportCreate.razor"
using FPLSP.Repositories.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ReportUps\ReportCreate.razor"
using FPLSP.Server.Infrastructure.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ReportUps\ReportCreate.razor"
using FPLSP.Server.Infrastructure.ViewModels.ReportClassUP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ReportUps\ReportCreate.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ReportUps\ReportCreate.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/reportcreate/{classUPId}")]
    public partial class ReportCreate : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 99 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ReportUps\ReportCreate.razor"
 
    [Inject] private IReportClassUPRepo _reportClassUPRepo { get; set; }
    [Inject] private ITaskRepositories<ClassUPViewModel> _taskRepositories { get; set; }
    [Inject] private NavigationManager NavigationManager { get; set; }
    [Inject] private IToastService ToastService { get; set; }
    private string classCode { get; set; }

    [Parameter]
    public string classUPId { get; set; }
    private ReportUPViewModel report = new ReportUPViewModel();//Form phải khởi tạo
    protected override async Task OnInitializedAsync()
    {
        var allClass = await _taskRepositories.GetAllClass();
        classCode = allClass.FirstOrDefault(c => Equals(Guid.Parse(classUPId), c.Id)).ClassroomName + " - " + allClass.FirstOrDefault(c => Equals(Guid.Parse(classUPId), c.Id)).ClassroomName;
    }
    private async Task Create(EditContext context)
    {

        try
        {
            report.ClassId = Guid.Parse(classUPId);
            var result = await _reportClassUPRepo.CreateReportClassUP(report);
            if (result)
            {
               NavigationManager.NavigateTo($"reportlist/{classUPId}");
                ToastService.ShowSuccess("Tạo mới thành công");
            }
            else
            {
                ToastService.ShowError("Tạo mới thất bại, kiểm tra lại");
            }
        }
        catch (Exception)
        {

            ToastService.ShowError("Đã xảy ra lỗi, thử lại sau");
        }
    }
    void ClearForm()
    {
        report = new ReportUPViewModel();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591