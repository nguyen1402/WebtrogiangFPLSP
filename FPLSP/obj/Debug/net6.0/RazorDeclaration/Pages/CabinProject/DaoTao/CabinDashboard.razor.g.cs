// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FPLSP.Pages.CabinProject.DaoTao
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
#line 4 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\DaoTao\CabinDashboard.razor"
using FPLSP.Data.Securities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\DaoTao\CabinDashboard.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\DaoTao\CabinDashboard.razor"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\DaoTao\CabinDashboard.razor"
using System.Diagnostics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\DaoTao\CabinDashboard.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\DaoTao\CabinDashboard.razor"
using FPLSP.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\DaoTao\CabinDashboard.razor"
using FPLSP.Components.CabinProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\DaoTao\CabinDashboard.razor"
using FPLSP.Repositories.Interfaces.CabinProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\DaoTao\CabinDashboard.razor"
using FPLSP.Repositories.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\DaoTao\CabinDashboard.razor"
using FPLSP.Server.Domain.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\DaoTao\CabinDashboard.razor"
using FPLSP.Server.Infrastructure.ViewModels.CabinProject.Cabin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\DaoTao\CabinDashboard.razor"
using FPLSP.Server.Infrastructure.ViewModels.CabinProject.GroupCabin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\DaoTao\CabinDashboard.razor"
using FPLSP.Server.Infrastructure.ViewModels.CabinProject.ShiftOfCabin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\DaoTao\CabinDashboard.razor"
using FPLSP.Server.Infrastructure.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\DaoTao\CabinDashboard.razor"
using FPLSP.Server.Infrastructure.ViewModels.CabinProject.TeachingSchedule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\DaoTao\CabinDashboard.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\DaoTao\CabinDashboard.razor"
           [Authorize(Roles = "DirectorOfTraining")]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/Cabin/directorOfTraining/{idTrainingFacilityNonDecrypt}")]
    public partial class CabinDashboard : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 179 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\DaoTao\CabinDashboard.razor"
       
    [Parameter]
    public string idTrainingFacilityNonDecrypt { get; set; }
    public string idTrainingFacility { get; set; }
    [Inject] public CryptoServices _cryptoServices { get; set; }
    [Inject] IShiftOfCabinApiClient shiftOfCabinApiClient { get; set; }
    [Inject] ISemesterRepo semesterRepo { get; set; }
    [Inject] IBlockRepo blockRepo { get; set; }
    [Inject] NavigationManager _navigationManager { get; set; }
    [Inject] ISemesterBlockRepo semesterBlockRepo { get; set; }
    [Inject] IGroupCabinRepo groupCabinRepo { get; set; }
    [Inject] ISpecializedUPRepo specializedUPRepo { get; set; }
    List<GroupCabinViewModel> listGroupCabin { get; set; }
    List<CabinViewModel> listCabinActive;
    [Inject] ICabinRepo cabinRepo { get; set; }
    [Inject] private IToastService _toastService { get; set; }
    DateTime startDateOfBlock;
    List<(string, DateTime)> daysOfWeek = new List<(string, DateTime)>();
    List<ShiftOfCabinVM> listShift;
    List<SpecializedDto> listSpec;

    private string nullString = null;

    private string semesterBlock;
    private string week;

    List<ShiftOfCabinFullVM> listFullShift = new List<ShiftOfCabinFullVM>();
    ShiftOfCabinFullVM _Model = new ShiftOfCabinFullVM();

    List<(string, string)> listSemesterBlock = new List<(string, string)>();
    List<string> listWeekOfBlock = new List<string>();
    List<SemesterBlockDto> listSemBlock;
    int allCabin;

    protected override async Task OnInitializedAsync()
    {
        try
        {
            idTrainingFacility = _cryptoServices.Decrypt(idTrainingFacilityNonDecrypt.Replace("cabin", "/"));
            try
            {
                string url = "http://localhost:5001/SignalRCabinHub";
                HubConnection _connection = null;
                bool isConnected = false;
                string connectionStatus = "Closed";
                _connection = new HubConnectionBuilder()
                    .WithUrl(url)
                    .Build();

                await _connection.StartAsync();
                isConnected = true;
                connectionStatus = "Connected :-)";

                _connection.Closed += async (s) =>
                {
                    isConnected = false;
                    connectionStatus = "Disconnected";
                    await _connection.StartAsync();
                    isConnected = true;
                };

                _connection.On<string>("SignalRCabins", async (res) =>
                {
                    if (res == "Done")
                    {
                        await OnInitializedAsync();

                        await this.InvokeAsync(() => this.StateHasChanged());
                    }
                });

                _connection.On<string>("SignalRGroupCabins", async (res) =>
                {
                    if (res == "Done")
                    {
                        await OnInitializedAsync();

                        await this.InvokeAsync(() => this.StateHasChanged());
                    }
                });

                _connection.On<string>("SignalRBookingCabins", async (res) =>
                {
                    if (res == "Done")
                    {
                        await OnInitializedAsync();

                        await this.InvokeAsync(() => this.StateHasChanged());
                    }
                });

                _connection.On<string>("SignalRTeachingSchedules", async (res) =>
                {
                    if (res == "Done")
                    {
                        await OnInitializedAsync();

                        await this.InvokeAsync(() => this.StateHasChanged());
                    }
                });

                _connection.On<string>("SignalRSemesterBlocks", async (res) =>
                {
                    if (res == "Done")
                    {
                        await OnInitializedAsync();

                        await this.InvokeAsync(() => this.StateHasChanged());
                    }
                });
            }
            catch (Exception ex)
            {


            }
            finally
            {
                listCabinActive = await cabinRepo.GetAllCabinAsync();
                listCabinActive = listCabinActive.Where(c => c.Status != 1 && c.IdTrainingFacility == Guid.Parse(idTrainingFacility)).ToList();
                allCabin = listCabinActive.Count();

                listShift = await shiftOfCabinApiClient.GetAll();
                listShift = listShift.Where(c => c.Status == 0).ToList();


                //listSubClass = await subjectClassRepo.GetAllClass();
                //listSubClass = listSubClass.Where(c => c.HomeroomLecturerId == Guid.Parse(idUser)).ToList();
                listGroupCabin = await groupCabinRepo.GetAllGroupCabinAsync();
                listGroupCabin = listGroupCabin.Where(c => c.Status == 0).ToList();

                listSpec = await specializedUPRepo.GetAll();


                listFullShift = await shiftOfCabinApiClient.GetAllInformationOfShiftOfCabin();
                listFullShift = listFullShift.Where(c => c.IdTrainingFacility == Guid.Parse(idTrainingFacility)).ToList();

                listSemesterBlock.Clear();
                var listGrouping = listFullShift.GroupBy(c => new { c.IdSemester, c.IdBlock, c.SemesterName, c.BlockName })./*Select(c => new($"{c.Key.IdSemester.ToString()} * {c.Key.IdBlock.ToString()}", $"{c.Key.SemesterName} - {c.Key.BlockName}")).*/ToList();

                listSemBlock = await semesterBlockRepo.GetAll();
                if (listSemBlock != null)
                {
                    listSemBlock = listSemBlock.Where(c => c.Status == 0).ToList();

                    var listSem = await semesterRepo.GetAll();
                    var listBlock = await blockRepo.GetAll();
                    foreach (var group in listSemBlock.GroupBy(c => new { c.IdSemester, c.IdBlock }))
                    {
                        listSemesterBlock.Add(new($"{group.Key.IdSemester.ToString()} * {group.Key.IdBlock.ToString()}", $"{listSem.FirstOrDefault(c => c.Id == group.Key.IdSemester).NameofSemester} - {listBlock.FirstOrDefault(c => c.Id == group.Key.IdBlock).NameOfBlock}"));
                    }
                    foreach (var group in listGrouping)
                    {
                        if (group.Key.IdSemester != null && group.Key.IdBlock != null)
                        {
                            if (listSemBlock.FirstOrDefault(c => c.IdSemester == group.Key.IdSemester && c.IdBlock == group.Key.IdBlock) != null)
                            {
                                if (listSemBlock.FirstOrDefault(c => c.IdSemester == group.Key.IdSemester && c.IdBlock == group.Key.IdBlock).Status != 1)
                                {
                                    semesterBlock = $"{group.Key.IdSemester.ToString()} * {group.Key.IdBlock.ToString()}";
                                }
                            }
                        }
                    }
                    await CheckSemesterBlock(semesterBlock);
                    LoadDaysOfWeek(DateTime.Now);
                    week = $"{daysOfWeek[0].Item2.ToString("dd/MM/yyyy")} - {daysOfWeek[0].Item2.AddDays(6).ToString("dd/MM/yyyy")}";

                    await LoadFullShift();
                }
            }
        }
        catch
        {
            // Lịch học rỗng
            listFullShift = new List<ShiftOfCabinFullVM>();
        }
    }

    private string BookedCabinInAllCabin(Guid? idSpec, Guid idShift, DateTime day)
    {
        var booked = listFullShift.Where(c => c.IdShiftOfCabin == idShift && c.TeachingDay == day && c.IdSpecialized == idSpec && c.IdCabin != null).Count().ToString();
        var all = listGroupCabin.Where(c => c.IdSpec == idSpec && listCabinActive.Any(x => x.Id == c.IdCabin)).Count().ToString();
        if (idSpec == null)
        {
            return booked + "/" + listCabinActive.Count(c => !listGroupCabin.Any(x => x.IdCabin == c.Id));
        }
        return booked + "/" + all;
    }

    private async Task LoadFullShift()
    {
        //if (semesterBlock != null && week != null)
        //{
        listFullShift = await shiftOfCabinApiClient.GetAllInformationOfShiftOfCabin();

        //date = listFullShift.FirstOrDefault().TeachingDay == null ? new DateTime(1, 1, 1) : listFullShift.FirstOrDefault().TeachingDay;
        //}
        //else
        //{

        //}
    }

    public async Task CheckSemesterBlock(string value)
    {
        semesterBlock = value;
        if (semesterBlock == null)
        {
            listWeekOfBlock.Clear();
        }
        week = null;
        await LoadWeeksOfBlock(semesterBlock);
    }


    public async void CheckDateRange(string value)
    {
        week = value;
        if (week != null)
        {
            var date = week.Split(" - ")[0];
            var day = date.Split("/")[0];
            var month = date.Split("/")[1];
            var year = date.Split("/")[2];
            LoadDaysOfWeek(new DateTime(Convert.ToInt32(year), Convert.ToInt32(month), Convert.ToInt32(day)));
        }
        else
        {
            daysOfWeek = new List<(string, DateTime)>();
        }
    }

    public async Task LoadWeeksOfBlock(string semesterBlockInput)
    {
        if (semesterBlockInput != null)
        {
            var idSemester = semesterBlockInput.Split(" * ")[0];
            var idBlock = semesterBlockInput.Split(" * ")[1];

            var semesterBlockSearch = await semesterBlockRepo.GetById(idBlock, idSemester);
            var startDate = new DateTime(semesterBlockSearch.StartTime.Year, semesterBlockSearch.StartTime.Month, semesterBlockSearch.StartTime.Day);
            var endDate = new DateTime(semesterBlockSearch.EndTime.Year, semesterBlockSearch.EndTime.Month, semesterBlockSearch.EndTime.Day);

            startDate = FindMonDay(startDate);
            endDate = FindMonDay(endDate).AddDays(6);
            var diff = (endDate - startDate).Days;
            listWeekOfBlock.Clear();

            for (int i = 0; i < diff; i += 7)
            {
                listWeekOfBlock.Add($"{startDate.AddDays(i).ToString("dd/MM/yyyy")} - {startDate.AddDays(i + 6).ToString("dd/MM/yyyy")}");
            }
        }
    }

    private async Task NavigateToListDetails(Guid idShift, DateTime day)
    {
        //<a href="/listCabin/@(shift.Id)/@($"{day.Day}-{day.Month}-{day.Year}")"></a>

        _navigationManager.NavigateTo($"/listCabin/{_cryptoServices.Encrypt(idTrainingFacility.ToString()).Replace("/", "cabin")}/{_cryptoServices.Encrypt(idShift.ToString()).Replace("/", "cabin")}/{$"{day.Day}-{day.Month}-{day.Year}"}");
    }

    private async Task NavigateToViewSchedule()
    {
        //<a href="/listCabin/@(shift.Id)/@($"{day.Day}-{day.Month}-{day.Year}")"></a>

        _navigationManager.NavigateTo($"/Cabin/directorOfTraining/viewSchedule/{idTrainingFacilityNonDecrypt}");
    }

    #region Load DaysOfWeek
    public void LoadDaysOfWeek(DateTime date)
    {
        date = new DateTime(date.Year, date.Month, date.Day);
        daysOfWeek = new List<(string, DateTime)>();

        var dayOfWeek = date.DayOfWeek;
        DateTime monday = new DateTime();
        if (dayOfWeek == DayOfWeek.Sunday)
        {
            //xét chủ nhật là đầu tuần
            //return date.AddDays(1);

            //xét chủ nhật là ngày cuối tuần
            monday = date.AddDays(-6);
        }
        else
        {
            int offset = dayOfWeek - DayOfWeek.Monday;
            monday = date.AddDays(-offset);
        }

        daysOfWeek.Add(new("Thứ 2", monday));
        for (int i = 1; i < 7; i++)
        {
            if (i == 6)
            {
                daysOfWeek.Add(new($"Chủ Nhật", monday.AddDays(i)));
            }
            else
            {
                daysOfWeek.Add(new($"Thứ {i + 2}", monday.AddDays(i)));
            }
        }
    }
    #endregion

    #region Tìm thứ 2
    public DateTime FindMonDay(DateTime date)
    {
        date = new DateTime(date.Year, date.Month, date.Day);
        daysOfWeek = new List<(string, DateTime)>();

        var dayOfWeek = date.DayOfWeek;
        DateTime monday = new DateTime();
        if (dayOfWeek == DayOfWeek.Sunday)
        {
            //xét chủ nhật là đầu tuần
            //return date.AddDays(1);

            //xét chủ nhật là ngày cuối tuần
            monday = date.AddDays(-6);
        }
        else
        {
            int offset = dayOfWeek - DayOfWeek.Monday;
            monday = date.AddDays(-offset);
        }

        return monday;
    }

    #endregion

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SweetAlertService Swal { get; set; }
    }
}
#pragma warning restore 1591
