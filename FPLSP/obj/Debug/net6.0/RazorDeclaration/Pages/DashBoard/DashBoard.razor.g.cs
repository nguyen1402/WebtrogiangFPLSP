// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FPLSP.Pages.DashBoard
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
#line 2 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\DashBoard\DashBoard.razor"
using FPLSP.Data.Securities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\DashBoard\DashBoard.razor"
using FPLSP.Repositories.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\DashBoard\DashBoard.razor"
using FPLSP.Server.Domain.Dtos.DashboardDtos;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/admin-dashboard/{userRolesNonDecrypt}/{IdTrainingFacilityNonDecrypt}")]
    public partial class DashBoard : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 126 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\DashBoard\DashBoard.razor"
       
    [Inject] public IDashboardClient dashboardClient { get; set; }
    [Parameter]
    public string userRolesNonDecrypt { get; set; }
    [Parameter]
    public string IdTrainingFacilityNonDecrypt { get; set; }

    private string userRoles = "";
    public string IdTrainingFacility = "";
    public int ClassAllQuantity { get; set; }
    public int GetAllLectureNotUser { get; set; }
    public int GetAllStudentUPNotUser { get; set; }
    public int GetAllSpec { get; set; }
    public List<TrainingFacilitiesForDashBoardDto> TrainingFacilitiesCollection { get; set; }
    public double[] termsLectureUp { get; set; } = new double[0];
    public string[] labelsTrainFaci_Name { get; set; } = new string[0];
    public double[] termsStudentUp_Quantity { get; set; } = new double[0];
    public double[] termsClassUp_Quantity { get; set; } = new double[0];
    public double[] termsSpec_Quantity { get; set; } = new double[0];
    [Inject]
    public CryptoServices _cryptoServices { get; set; }
    int Index;
    protected async override Task OnInitializedAsync()
    {
        userRoles = _cryptoServices.Decrypt(userRolesNonDecrypt.Replace("I0H", "/"));
        IdTrainingFacility = _cryptoServices.Decrypt(IdTrainingFacilityNonDecrypt.Replace("I0H", "/"));
        TrainingFacilitiesCollection = new List<TrainingFacilitiesForDashBoardDto>();
        Index = 0;
        await Get();
    }

    private async Task Get()
    {
        var countstudent = await dashboardClient.GetAllStudentUPNotUser();
        GetAllStudentUPNotUser = countstudent;
        if (userRoles == "AdminCore" || userRoles == "7")
        {
            IdTrainingFacility = "00000000-0000-0000-0000-000000000000";

        };
        var countlecture = await dashboardClient.GetAllLectureNotUser(Guid.Parse(IdTrainingFacility));
        GetAllLectureNotUser = countlecture;
        TrainingFacilitiesCollection = await dashboardClient.GetInforTraningFacilitiesForDashboard();
        if (userRoles == "AdminCS" || userRoles == "6")
        {
            TrainingFacilitiesCollection = TrainingFacilitiesCollection.Where(c => c.TrainFaci_Id == Guid.Parse(IdTrainingFacility)).ToList();
            GetAllSpec = TrainingFacilitiesCollection.Where(c => c.TrainFaci_Id == Guid.Parse(IdTrainingFacility)).Select(c => c.Spec_Quantity).FirstOrDefault() ;
        };
        GetAllSpec = await dashboardClient.GetAllSpec();
        termsLectureUp = new double[TrainingFacilitiesCollection.Count()];
        labelsTrainFaci_Name = new string[TrainingFacilitiesCollection.Count()];
        termsStudentUp_Quantity = new double[TrainingFacilitiesCollection.Count()];
        termsClassUp_Quantity = new double[TrainingFacilitiesCollection.Count()];
        termsSpec_Quantity = new double[TrainingFacilitiesCollection.Count()];
        for (int runs = 0; runs < TrainingFacilitiesCollection.Count; runs++)
        {
            termsLectureUp[runs] = TrainingFacilitiesCollection[runs].LectureUp_Quantity;
            termsStudentUp_Quantity[runs] = TrainingFacilitiesCollection[runs].StudentUp_Quantity;
            termsClassUp_Quantity[runs] = TrainingFacilitiesCollection[runs].ClassUp_Quantity;
            labelsTrainFaci_Name[runs] = TrainingFacilitiesCollection[runs].TrainFaci_Name;
            termsSpec_Quantity[runs] = TrainingFacilitiesCollection[runs].Spec_Quantity;
        }


    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
