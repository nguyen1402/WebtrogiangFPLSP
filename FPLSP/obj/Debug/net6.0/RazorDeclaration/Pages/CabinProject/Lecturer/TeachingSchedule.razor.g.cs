// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FPLSP.Pages.CabinProject.Lecturer
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
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\Lecturer\TeachingSchedule.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\Lecturer\TeachingSchedule.razor"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\Lecturer\TeachingSchedule.razor"
using System.Diagnostics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\Lecturer\TeachingSchedule.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\Lecturer\TeachingSchedule.razor"
using FPLSP.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\Lecturer\TeachingSchedule.razor"
using FPLSP.Components.CabinProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\Lecturer\TeachingSchedule.razor"
using FPLSP.Data.Securities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\Lecturer\TeachingSchedule.razor"
using FPLSP.Repositories.Interfaces.CabinProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\Lecturer\TeachingSchedule.razor"
using FPLSP.Repositories.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\Lecturer\TeachingSchedule.razor"
using FPLSP.Server.Infrastructure.ViewModels.CabinProject.BookingCabin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\Lecturer\TeachingSchedule.razor"
using FPLSP.Server.Infrastructure.ViewModels.CabinProject.ShiftOfCabin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\Lecturer\TeachingSchedule.razor"
using FPLSP.Server.Infrastructure.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\Lecturer\TeachingSchedule.razor"
using FPLSP.Server.Infrastructure.ViewModels.CabinProject.TeachingSchedule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\Lecturer\TeachingSchedule.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\Lecturer\TeachingSchedule.razor"
           [Authorize(Roles = "Lecturer")]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/Cabin/lecturer/{idUserNonDecrypt}")]
    public partial class TeachingSchedule : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 177 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\Lecturer\TeachingSchedule.razor"
       
    [Parameter]
    public string idUserNonDecrypt { get; set; }
    public string idUser { get; set; }
    [Inject] public CryptoServices _cryptoServices { get; set; }
    [Inject] ITaskRepositories<ClassUPViewModel> subjectClassRepo { get; set; }
    [Inject] ITeachingScheduleApiClient teachingScheduleApiClient { get; set; }
    [Inject] public IBookingCabinApiClient _bookingCabinApiClient { get; set; }
    [Inject] IShiftOfCabinApiClient shiftOfCabinApiClient { get; set; }
    [Inject] IBlockRepo blockRepo { get; set; }
    [Inject] ISemesterRepo semesterRepo { get; set; }
    [Inject] private IToastService _toastService { get; set; }

    protected DetailShift bookingCabin { set; get; }
    protected BookingRequestForLecturerPage bookingRequestForLecturer { set; get; }

    private string image = "";
    private string close = "none";//dùng đóng mở tab chụp ảnh
    private bool loadCamera;
    private byte[] byteimage;//biến đế lưu ảnh theo kiểu byte
    private bool viewImage;
    private bool viewCamera;
    DateTime date;
    string blockName;
    string semesterName;
    List<(string, DateTime)> daysOfWeek = new List<(string, DateTime)>();
    List<ShiftOfCabinVM> listShift;
    List<ShiftOfCabinFullVM> listFullShift;
    //List<ClassUPViewModel> listSubClass;
    List<TeachingScheduleVM> listSchedule;
    List<BookingCabinVM> listBookingCabin;

    protected ConfirmCheckInCamera Confirmclose { get; set; }

    public Guid IdClassForDetails = Guid.Empty;
    public Guid IdSubjectForDetails = Guid.Empty;
    public Guid IdLecturerForDetails = Guid.Empty;
    public Guid IdShiftForDetails = Guid.Empty;
    public Guid? IdCabinForDetails = null;
    public string ClassSubjectNameForDetails;
    public string LecturerNameForDetails;
    public string ShiftNameForDetails;
    public string CabinNameForDetails;
    public DateTime TeachingDayForDetails;
    public TimeSpan StartShiftForDetails;
    public TimeSpan EndShiftForDetails;


    protected override async Task OnInitializedAsync()
    {
        try
        {
            idUser = _cryptoServices.Decrypt(idUserNonDecrypt.Replace("cabin","/"));
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
                //listSubClass = await subjectClassRepo.GetAllClass();
                //listSubClass = listSubClass.Where(c => c.HomeroomLecturerId == Guid.Parse(idUser)).ToList();

                listSchedule = await teachingScheduleApiClient.GetAll();
                listSchedule = listSchedule == null ? new List<TeachingScheduleVM>() : listSchedule.Where(c => c.Status == 0 && c.IdLecturter == Guid.Parse(idUser)).ToList();

                var listBlock = await blockRepo.GetAll();
                var listSemester = await semesterRepo.GetAll();

                date = DateTime.Now;
                blockName = listBlock.FirstOrDefault(c => c.Status == 0 && c.Id == listSchedule.FirstOrDefault(c => c.Status == 0).IdBlock).NameOfBlock;
                semesterName = listSemester.FirstOrDefault(c => c.Status == 0 && c.Id == listSchedule.FirstOrDefault(c => c.Status == 0).IdSemester).NameofSemester;
                LoadDaysOfWeek(date);

                listShift = await shiftOfCabinApiClient.GetAll();
                listShift = listShift == null ? new List<ShiftOfCabinVM>() : listShift.Where(c => c.Status != 1).ToList();

                listFullShift = await shiftOfCabinApiClient.GetAllInformationOfShiftOfCabin();
                listFullShift = listFullShift == null ? new List<ShiftOfCabinFullVM>() : listFullShift.Where(c => c.IdLecturer == Guid.Parse(idUser)).ToList();

                listBookingCabin = await _bookingCabinApiClient.GetAll();
                listBookingCabin = listBookingCabin.Where(c => c.Status != 1).ToList();
            }
        }
        catch
        {
            // Lịch học rỗng
            listSchedule = new List<TeachingScheduleVM>();
            listShift = new List<ShiftOfCabinVM>();
            listFullShift = new List<ShiftOfCabinFullVM>();
        }
    }

    private async Task Submit()
    {
        if (image == "")
        {
            _toastService.ShowError("Bạn chưa chụp ảnh");
        }
        else
        {
            close = "none";
            byteimage = Encoding.ASCII.GetBytes(image);//Chuyển image -> byte
            await StoreInDatabase(byteimage);
        }
    }


    private async Task StoreInDatabase(byte[] imageBytes)//lưu ảnh dạng byte vào database
    {
        //Thời gian chụp = DateTime.Now
        //var imageByte = Encoding.ASCII.GetString(imageBytes);
        var listBookingCabin = await _bookingCabinApiClient.GetAll();
        var objForUpdate = listBookingCabin.FirstOrDefault(c => c.Status == 0 && c.SubjectId == IdSubjectForDetails && c.ClassId == IdClassForDetails && c.IdShift == IdShiftForDetails && c.IdLectuter == IdLecturerForDetails && c.IdCabin == IdCabinForDetails && c.DateCreated == new DateTime(TeachingDayForDetails.Year, TeachingDayForDetails.Month, TeachingDayForDetails.Day));
        var obj = new BookingCabinUpdateVM()
            {
                SubjectId = IdSubjectForDetails,
                ClassId = IdClassForDetails,
                IdCabin = Guid.Parse(IdCabinForDetails.ToString()),
                IdShift = IdShiftForDetails,
                IdLectuter = IdLecturerForDetails,
                CheckinImage = imageBytes,
                CheckinTime = DateTime.Now,
                CheckoutTime = objForUpdate.CheckoutTime,
                DateCreated = objForUpdate.DateCreated,
                Note = "Checkin vào cabin",
                Status = 0
            };

        var res = await _bookingCabinApiClient.Update(objForUpdate.Id, Guid.Parse(IdCabinForDetails.ToString()), IdSubjectForDetails, IdClassForDetails, IdShiftForDetails, obj);

        if (res)
        {
            await Swal.FireAsync("Check In", "Check In Thành Công", SweetAlertIcon.Success);
        }
        else
        {
            await Swal.FireAsync("Check In", "Check In Thất Bại", SweetAlertIcon.Error);
        }
        await OnInitializedAsync();
    }
    public async Task Capture()
    {
        viewImage = false;//hiện ảnh
        viewCamera = true;//ẩn camera
        image = await JSRuntime.InvokeAsync<string>("take_snapshot_cabin");//đẩy ảnh vừa chụp
        await StopCamera();
    }
    private async Task ComeBack()
    {
        viewImage = true;//Đổi trạng thái khi ấn chụp ảnh
        viewCamera = false;
        image = "";
        await LoadCamera();
    }

    private async Task OpenCamera()//bật tắt tab chụp ảnh
    {
        try
        {
            viewImage = true;//Đổi trạng thái khi ấn chụp ảnh
            viewCamera = false;
            loadCamera = true;
            close = "block";
            await LoadCamera();
        }
        catch(Exception ex)
        {
            await OnConfirmationClose(true);
            _toastService.ShowError("Có lỗi xảy ra khi bật camera. Vui lòng kiểm tra và thử lại");
        }

    }

    public async Task ViewBookingRequest()
    {
        await bookingRequestForLecturer.show();
    }

    public async Task BookARoom(ShiftOfCabinFullVM obj)
    {
        /*
        * obj = null -> Mở ExchangeTeachingSchedule
        * So sánh DateTime.Now với khoảng ca, thứ
        * Trong khoảng -> Mở CheckIn
        * Ngoài khoảng -> Mở DetailShift
        *
        */
        // DetailShift (Booking)
        IdClassForDetails = Guid.Parse(obj.IdClass.ToString());
        IdSubjectForDetails = Guid.Parse(obj.IdSubject.ToString());
        IdLecturerForDetails = Guid.Parse(obj.IdLecturer.ToString());
        IdShiftForDetails = Guid.Parse(obj.IdShiftOfCabin.ToString());
        IdCabinForDetails = obj.IdCabin == null ? null : Guid.Parse(obj.IdCabin.ToString());
        ClassSubjectNameForDetails = obj.ClassName + " - " + obj.SubjectCode;
        LecturerNameForDetails = obj.LecturerUserName;
        ShiftNameForDetails = obj.ShiftName;
        CabinNameForDetails = obj.CabinName;
        TeachingDayForDetails = obj.TeachingDay.Value;
        StartShiftForDetails = obj.StartTimeOfShift.Value;
        EndShiftForDetails = obj.EndTimeOfShift.Value;

        if (obj == null)
        {
            // ExchangeTeachingSchedule
        }
        else
        {
            DateTime startTime = new DateTime(obj.TeachingDay.Value.Year, obj.TeachingDay.Value.Month, obj.TeachingDay.Value.Day, obj.StartTimeOfShift.Value.Hours, obj.StartTimeOfShift.Value.Minutes, obj.StartTimeOfShift.Value.Seconds);
            DateTime endTime = new DateTime(obj.TeachingDay.Value.Year, obj.TeachingDay.Value.Month, obj.TeachingDay.Value.Day, obj.EndTimeOfShift.Value.Hours, obj.EndTimeOfShift.Value.Minutes, obj.EndTimeOfShift.Value.Seconds);
            var objForUpdate = listBookingCabin.FirstOrDefault(c => c.Status == 0 && c.SubjectId == IdSubjectForDetails && c.ClassId == IdClassForDetails && c.IdShift == IdShiftForDetails && c.IdLectuter == IdLecturerForDetails && c.IdCabin == IdCabinForDetails && c.DateCreated == new DateTime(TeachingDayForDetails.Year, TeachingDayForDetails.Month, TeachingDayForDetails.Day));

            if (DateTime.Now >= startTime && DateTime.Now < endTime && IdCabinForDetails != null && objForUpdate.CheckinImage == null)
            {
                // CheckIn
                await OpenCamera();
            }
            else
            {
                await bookingCabin.show();
            }
        }
    }
    private async Task Close()//Thoát chụp ảnh
    {
        Confirmclose.show();
    }

    private async Task LoadCamera()
    {
        image = "";
        await JSRuntime.InvokeVoidAsync("ready_cabin", this);//Bật camera
        TimeLoad();

    }

    private async Task StopCamera()//tắt camera
    {
        await JSRuntime.InvokeVoidAsync("stop_cabin", this);
    }

    private void TimeLoad()
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        Thread.Sleep(700);//Cho camera load 0.7s
        stopwatch.Stop();
        loadCamera = false;
    }
    public async Task OnConfirmationClose(bool deleteconfirmed)//xác nhận thoát tab chụp ảnh
    {
        if (deleteconfirmed)
        {
            close = "none";
            await StopCamera();
        }
    }

    private async Task OnConfirmationBooking(int result)
    {
        if (result == 1)
        {
            await Swal.FireAsync("Xếp Phòng", "Xếp Phòng Cho Lớp Học Thành Công", SweetAlertIcon.Success);
        }
        if (result == 2)
        {
            await Swal.FireAsync("Xếp Phòng", "Xếp Phòng Cho Lớp Học Thất Bại", SweetAlertIcon.Error);
        }

        await OnInitializedAsync();
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


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SweetAlertService Swal { get; set; }
    }
}
#pragma warning restore 1591
