// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FPLSP.Pages.CabinProject.AdminCoSo
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
#line 2 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\AdminCoSo\BookingRequest.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\AdminCoSo\BookingRequest.razor"
using Blazored.Toast;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\AdminCoSo\BookingRequest.razor"
using FPLSP.Data.Securities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\AdminCoSo\BookingRequest.razor"
using FPLSP.Repositories.Interfaces.CabinProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\AdminCoSo\BookingRequest.razor"
using FPLSP.Repositories.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\AdminCoSo\BookingRequest.razor"
using FPLSP.Server.Data.SeedWork;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\AdminCoSo\BookingRequest.razor"
using FPLSP.Server.Domain.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\AdminCoSo\BookingRequest.razor"
using FPLSP.Server.Domain.Entities.CoresParts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\AdminCoSo\BookingRequest.razor"
using FPLSP.Server.Domain.Entities.UserParts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\AdminCoSo\BookingRequest.razor"
using FPLSP.Server.Infrastructure.ViewModels.CabinProject.BookingCabin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\AdminCoSo\BookingRequest.razor"
using FPLSP.Server.Infrastructure.ViewModels.CabinProject.BookingRequest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\AdminCoSo\BookingRequest.razor"
using FPLSP.Server.Infrastructure.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\AdminCoSo\BookingRequest.razor"
using FPLSP.Server.Infrastructure.ViewModels.CabinProject.Cabin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\AdminCoSo\BookingRequest.razor"
using FPLSP.Server.Infrastructure.ViewModels.CabinProject.GroupCabin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\AdminCoSo\BookingRequest.razor"
using FPLSP.Server.Infrastructure.ViewModels.CabinProject.ShiftOfCabin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\AdminCoSo\BookingRequest.razor"
using FPLSP.Server.Infrastructure.ViewModels.CabinProject.TeachingSchedule;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\AdminCoSo\BookingRequest.razor"
using FPLSP.Components.CabinProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\AdminCoSo\BookingRequest.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\AdminCoSo\BookingRequest.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\AdminCoSo\BookingRequest.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\AdminCoSo\BookingRequest.razor"
using System.Diagnostics;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\AdminCoSo\BookingRequest.razor"
using System.Net.Mail;

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\AdminCoSo\BookingRequest.razor"
using System.Net;

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\AdminCoSo\BookingRequest.razor"
using Microsoft.AspNetCore.Hosting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\AdminCoSo\BookingRequest.razor"
           [Authorize(Roles = "Staff,DirectorOfTraining")]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/BookingRequest/{IdTrainingFacilityNonDecrypt}")]
    public partial class BookingRequest : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 321 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\AdminCoSo\BookingRequest.razor"
       
    [Parameter]
    public string IdTrainingFacilityNonDecrypt { get; set; }
    [Parameter]
    public string IdTrainingFacility { get; set; }

    [Inject] private IBookingRequestRepo _iBookingRequestRepo { get; set; }
    [Inject] private IBookingCabinApiClient _ibookingCabinApiClient { get; set; }
    [Inject] private ICabinRepo _icabinRepo { get; set; }
    [Inject] private ISubjectsSpecializedUPRepo _iSubjectsSpecializedUP { get; set; }
    [Inject] private ILecturersCPRepo _ilecturersCPRepo { get; set; }
    [Inject] private ITaskRepositories<ClassUPViewModel> _iClassRepo { get; set; }
    [Inject] private ISpecializedUPRepo _ispecializedUPRepo { get; set; }
    [Inject] private IClassSubjectApiClient _iclassSubjectApi { get; set; }
    [Inject] private ISubjectUPRepo _isubjectUPRepo { get; set; }
    [Inject] private IToastService _itoastService { get; set; }
    [Inject] private IGroupCabinRepo _igroupCabinRepo { get; set; }
    [Inject] private IShiftOfCabinApiClient _ishiftOfCabinApiClient { get; set; }
    [Inject] private ITeachingScheduleApiClient _teachingScheduleApiClient { get; set; }
    [Inject] private IHostingEnvironment _hostingEnvironment { get; set; }

    [Inject] private CryptoServices _cryptoServices { get; set; }
    [Inject] SweetAlertService Swal { get; set; }

    private BookingRequestSearchViewModel _bookingRequestSearch = new BookingRequestSearchViewModel();
    private List<BookingRequestViewModel> _listBookingRequest;
    private List<LecturersCP> _LectureVM = new List<LecturersCP>();
    private List<LecturersCP> _listLectureSearchVM = new List<LecturersCP>();
    private List<ClassUPViewModel> _clasVM = new List<ClassUPViewModel>();
    private List<SpecializedDto> _specializedDtos = new List<SpecializedDto>();
    private List<SubjectClassUP> _subjectClassUPs = new List<SubjectClassUP>();
    private List<SubjectDto> _subjectDtos = new List<SubjectDto>();
    private List<GroupCabinViewModel> _groupCabinViewModels = new List<GroupCabinViewModel>();
    private List<ShiftOfCabinVM> _shiftOfCabinVMs;
    private List<CabinViewModel> _cabinViewModels = new List<CabinViewModel>();
    private BookingCabinVM _bookingCabinVM = new BookingCabinVM();
    private List<BookingCabinVM> _listBookingCabinVM = new List<BookingCabinVM>();
    private List<TeachingScheduleVM> _teachingScheduleVMs = new List<TeachingScheduleVM>();

    private Guid _idSubject;
    private Guid _idLecture;
    private Guid _idClass;
    private Guid _idCabin;
    private Guid _idBookingRequest;
    private Guid _idShift;

    private Guid _newIdCabin;
    private Guid _newIdRequest;
    private int _statusCabinUndo = 0;

    private DateTime _monday = new();
    private DateTime _sunday = new();

    private DateTime _startTime = DateTime.Now;
    private DateTime _endTime = DateTime.Now;
    private DateTime _sendingTime = DateTime.Now;
    private string _shiftName = "Ca ";
    private string? _textsearch = "";
    private string? _contenFeedBack = "Đã được chọn giúp cabin";
    private string _titleRoom = "Danh sách cabin còn trống";
    private string _lecturename = "";
    private string _undo = "none";
    private string _xephuy = "";
    private bool _undoRequest = false;

    private string _disabletab = "none";

    System.Timers.Timer t;

    public MetaData MetaData { get; set; } = new MetaData();
    protected ConfirmBookingRequest Confirmsubmit { get; set; }
    protected ConfirmBookingRequest Confirmclose { get; set; }

    private async Task AddCabin()//Chọn cabin từ Request
    {
        _disabletab = "block";
        _newIdCabin = Guid.NewGuid();
        _newIdRequest = Guid.NewGuid();
        bool result = false;
        bool resultadd = false;
        bool resultcreate = false;
        if (_listBookingCabinVM.Any(c => c.SubjectId == _idSubject && c.ClassId == _idClass && c.IdShift == _idShift && c.IdLectuter == _idLecture && c.IdCabin == _idCabin && c.DateCreated == new DateTime(_startTime.Year, _startTime.Month, _startTime.Day)))
        {
            _statusCabinUndo = 2;
            var bookingcabin = _listBookingCabinVM.FirstOrDefault(c => c.SubjectId == _idSubject && c.ClassId == _idClass && c.IdShift == _idShift && c.IdLectuter == _idLecture && c.IdCabin == _idCabin && c.DateCreated == new DateTime(_startTime.Year, _startTime.Month, _startTime.Day));
            var bookingcabinUpdate = new BookingCabinUpdateVM
                {
                    SubjectId = bookingcabin.SubjectId,
                    ClassId = bookingcabin.ClassId,
                    IdCabin = bookingcabin.IdCabin,
                    IdShift = bookingcabin.IdShift,
                    DateCreated = new DateTime(_startTime.Year, _startTime.Month, _startTime.Day),
                    CheckinTime = _startTime,
                    CheckoutTime = _endTime,
                    Note = bookingcabin.Note,
                    Status = 0,
                    IdLectuter = bookingcabin.IdLectuter
                };
            result = await _ibookingCabinApiClient.Update(bookingcabin.Id, _idCabin, _idSubject, _idClass, _idShift, bookingcabinUpdate);
        }
        else
        {
            if (_statusCabinUndo == 0)
            {
                _statusCabinUndo = 1;
            }
            var bookingCabin = new BookingCabinCreateVM
                {
                    Id = _newIdCabin,
                    IdLectuter = _idLecture,
                    SubjectId = _idSubject,
                    ClassId = _idClass,
                    CheckinTime = _startTime,
                    CheckoutTime = _endTime,
                    DateCreated = new DateTime(_startTime.Year, _startTime.Month, _startTime.Day),
                    IdShift = _idShift,
                    IdCabin = _idCabin,//Id của cabin sau khi chọn
                    Note = "Được chọn giúp",
                    Status = 0
                };
            resultadd = await _ibookingCabinApiClient.Add(bookingCabin);

        }
        if (result || resultadd)
        {
            if (await CreateBookingRequest(2))
            {
                _itoastService.ShowSuccess("Chọn cabin thành công");
                _titleRoom = "Thông tin cabin đã chọn";
                _xephuy = "xếp";
                _undo = "block";
                await TimeLoadUndo();
            }
            else
            {
                _itoastService.ShowError("Chọn cabin thất bại");
            }
        }

        await GetTasks();
    }

    private async Task<bool> CreateBookingRequest(int status)
    {
        var booking = new BookingRequestCreateViewModel
            {
                Id = _newIdRequest,
                ContentOfRequest = "Đã được chọn giúp cabin",
                SendingTime = _sendingTime,
                IdLectuter = _idLecture,
                SubjectId = _idSubject,
                ClassId = _idClass,
                ContenOfFeedBack = _contenFeedBack,
                Status = status,
                StartTime = _startTime,
                FeedBackTime = DateTime.Now,
                EndTime = _endTime
            };
        if (status == 3)
        {
            booking.ContenOfFeedBack = "Hủy cabin vì: " + _contenFeedBack;
        }

        var result = await _iBookingRequestRepo.CreateBookingRequest(booking);// SignalR
        return result;
    }

    private async Task SendEmail()
    {
        try
        {
            //Gửi Email
            string to, from, pass, email;
            to = _LectureVM.FirstOrDefault(c => c.Id == _idLecture).Email;

            from = "truongnvph26436@fpt.edu.vn";
            string rootpath = System.IO.Path.Combine(_hostingEnvironment.ContentRootPath, @"wwwroot\ViewSendEmail\ViewSendEmail.html");
            email = ReadEmailTemplate(rootpath);
            email = email.Replace("#userName#", _LectureVM.FirstOrDefault(c => c.Id == _idLecture).Email.ToString().Split("@")[0]);
            email = email.Replace("#feedBackConTent#", _contenFeedBack);
            email = email.Replace("#classNameSubjectCode#", _clasVM.FirstOrDefault(c => c.Id == _idClass).ClassroomName + "-" + _subjectDtos.FirstOrDefault(c => c.Id == _idSubject).SubjectCode);
            email = email.Replace("#subjectName#", _subjectDtos.FirstOrDefault(c => c.Id == _idSubject).SubjectName);
            email = email.Replace("#shiftTimeStart#", _startTime.ToString("HH:mm"));
            email = email.Replace("#day#", _startTime.ToString("dddd", new CultureInfo("vi-VN")));
            email = email.Replace("#shiftTimeEnd#", _endTime.ToString("HH:mm"));
            email = email.Replace("#teachingDay#", _startTime.ToString("dd/MM/yyyy"));
            email = email.Replace("#cabin#", _cabinViewModels.FirstOrDefault(c => c.Id == _idCabin).CabinName);

            AlternateView alternateView = AlternateView.CreateAlternateViewFromString(email, null, "text/html");

            pass = "yclnvhixhvxuygna";

            MailMessage mailMessage = new MailMessage();

            mailMessage.To.Add(to);
            mailMessage.From = new MailAddress(from);
            mailMessage.Subject = "THÔNG BÁO: XẾP GIÚP CABIN";
            mailMessage.Body = email;
            mailMessage.IsBodyHtml = false;
            mailMessage.AlternateViews.Add(alternateView);

            SmtpClient smtp = new SmtpClient("smtp.gmail.com");

            smtp.UseDefaultCredentials = false;
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);

            smtp.Send(mailMessage);
        }
        catch (Exception)
        {
        }
    }

    //Đọc định dạng html -> template email
    private string ReadEmailTemplate(string template)
    {
        string result = "";
        StreamReader reader = new(template);
        result = reader.ReadToEnd();
        reader.Close();
        return result;
    }

    //Tắt Undo sau 5 giây
    private async Task TimeLoadUndo()
    {
        t = new(10000);
        t.Elapsed += async (sender, EventArgs) => await CloseUndo();
        t.Start();
    }

    private async Task CloseUndo()
    {
        _undo = "none";
        t.Stop();
        await this.InvokeAsync(() => this.StateHasChanged());
        if (!_undoRequest)
        {
            await SendEmail();
        }
    }

    private async Task Close()
    {
        _undo = "none";
        if (!_undoRequest)
        {
            await SendEmail();
        }
    }

    private async Task Undo()
    {
        _undoRequest = true;
        _undo = "none";
        if (_statusCabinUndo == 1)
        {
            var resultadd = await _ibookingCabinApiClient.UndoDelete(_newIdCabin);
            if (resultadd)
            {
                var resultRequest = await _iBookingRequestRepo.DeleteBookingRequest(_newIdRequest);
                if (resultRequest)
                {
                    _itoastService.ShowSuccess("Hoàn tác thành công");
                }
                else
                {
                    _itoastService.ShowSuccess("Hoàn tác thât bại");
                }
            }
            else
            {
                _itoastService.ShowSuccess("Hoàn tác thât bại");
            }
        }
        else if (_statusCabinUndo == 2)
        {
            var bookingcabin = _listBookingCabinVM.FirstOrDefault(c => c.Status == 0 && c.IdCabin == _idCabin && c.SubjectId == _idSubject && c.ClassId == _idClass && c.IdShift == _idShift && c.IdLectuter == _idLecture && c.DateCreated == new DateTime(_startTime.Year, _startTime.Month, _startTime.Day));
            var bookingcabinUpdate = new BookingCabinUpdateVM
                {
                    SubjectId = bookingcabin.SubjectId,
                    ClassId = bookingcabin.ClassId,
                    IdCabin = bookingcabin.IdCabin,
                    IdShift = bookingcabin.IdShift,
                    DateCreated = new DateTime(_startTime.Year, _startTime.Month, _startTime.Day),
                    CheckinTime = _startTime,
                    CheckoutTime = _endTime,
                    Note = bookingcabin.Note,
                    Status = 1,
                    IdLectuter = bookingcabin.IdLectuter
                };
            var result = await _ibookingCabinApiClient.Update(bookingcabin.Id, bookingcabin.IdCabin, _idSubject, _idClass, _idShift, bookingcabinUpdate);
            if (result)
            {
                var resultRequest = await _iBookingRequestRepo.DeleteBookingRequest(_newIdRequest);
                if (resultRequest)
                {
                    _itoastService.ShowSuccess("Hoàn tác thành công");
                }
                else
                {
                    _itoastService.ShowSuccess("Hoàn tác thât bại");
                }
            }
            else
            {
                _itoastService.ShowSuccess("Hoàn tác thât bại");
            }
        }
        else if (_statusCabinUndo == 3)
        {
            var bookingcabin = _listBookingCabinVM.FirstOrDefault(c => c.Status == 1 && c.IdCabin == _idCabin && c.SubjectId == _idSubject && c.ClassId == _idClass && c.IdShift == _idShift && c.IdLectuter == _idLecture && c.DateCreated == new DateTime(_startTime.Year, _startTime.Month, _startTime.Day));
            var bookingcabinUpdate = new BookingCabinUpdateVM
                {
                    SubjectId = bookingcabin.SubjectId,
                    ClassId = bookingcabin.ClassId,
                    IdCabin = bookingcabin.IdCabin,
                    IdShift = bookingcabin.IdShift,
                    DateCreated = new DateTime(_startTime.Year, _startTime.Month, _startTime.Day),
                    CheckinTime = _startTime,
                    CheckoutTime = _endTime,
                    Note = bookingcabin.Note,
                    Status = 0,
                    IdLectuter = bookingcabin.IdLectuter
                };
            var result = await _ibookingCabinApiClient.Update(bookingcabin.Id, bookingcabin.IdCabin, _idSubject, _idClass, _idShift, bookingcabinUpdate);
            if (result)
            {
                var resultRequest = await _iBookingRequestRepo.DeleteBookingRequest(_newIdRequest);
                if (resultRequest)
                {
                    _itoastService.ShowSuccess("Hoàn tác thành công");
                }
                else
                {
                    _itoastService.ShowSuccess("Hoàn tác thât bại");
                }
            }
            else
            {
                _itoastService.ShowSuccess("Hoàn tác thât bại");
            }
        }

    }

    public async Task SearchTask(BookingRequestSearchViewModel bookingRequestSearch)
    {
        _bookingRequestSearch = bookingRequestSearch;
        if (bookingRequestSearch.stringSearch != null)
        {
            _textsearch = bookingRequestSearch.stringSearch;
        }
        await GetTasks();
    }


    private async Task MessError()
    {
        await Swal.FireAsync(new SweetAlertOptions
            {
                Title = "Thông báo",
                Text = $"Yêu cầu xếp cabin đã hết hạn",
                Icon = SweetAlertIcon.Warning,
                ConfirmButtonText = "Xác Nhận",
            });
    }

    private async Task ClickNotify(BookingRequestViewModel bookingRequestVM)
    {
        _idSubject = bookingRequestVM.SubjectId;
        _idClass = bookingRequestVM.ClassId;
        _idLecture = bookingRequestVM.IdLectuter;
        _idBookingRequest = bookingRequestVM.Id;
        _startTime = bookingRequestVM.StartTime;
        _endTime = bookingRequestVM.EndTime;
        _sendingTime = bookingRequestVM.SendingTime;
        if (bookingRequestVM.Status == 2)
        {
            _titleRoom = "Thông tin cabin đã chọn";
        }
        else
        {
            _titleRoom = "Danh sách cabin còn trống";
        }
        if (_shiftOfCabinVMs != null)
        {
            try
            {
                _shiftName = _shiftOfCabinVMs.FirstOrDefault(c => c.StartTime == _startTime.TimeOfDay && c.EndTime == _endTime.TimeOfDay).ShiftName;
                _idShift = _shiftOfCabinVMs.FirstOrDefault(c => c.StartTime == _startTime.TimeOfDay && c.EndTime == _endTime.TimeOfDay).Id;
            }
            catch (Exception)
            {

                _itoastService.ShowError("Đã xảy ra lỗi vui lòng kiểm tra Ca học");
            }
        }
    }


    private async Task ClickCabin(Guid idCabin)
    {
        _idCabin = idCabin;

        Confirmsubmit.Day = _startTime;
        Confirmsubmit.IdCabin = _idCabin;
        Confirmsubmit.IdClass = _idClass;
        Confirmsubmit.IdLecturer = _idLecture;
        Confirmsubmit.IdSubject = _idSubject;
        Confirmsubmit.ShiftName = _shiftName;
        Confirmsubmit.show();
    }

    private async Task ClickCloseCabin(Guid idCabin)
    {
        _idCabin = idCabin;
        Confirmclose.Day = _startTime;
        Confirmclose.IdCabin = _idCabin;
        Confirmclose.IdClass = _idClass;
        Confirmclose.IdLecturer = _idLecture;
        Confirmclose.IdSubject = _idSubject;
        Confirmclose.ShiftName = _shiftName;
        Confirmclose.show();
    }

    protected override async Task OnInitializedAsync()
    {
        IdTrainingFacility = _cryptoServices.Decrypt(IdTrainingFacilityNonDecrypt.Replace("cabin", "/"));
        //
        try
        {
            //Check thay đổi của BookingRequest
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

            _connection.On<string>("SignalRBookingRequests", async (res) =>
            {
                if (res == "Done")
                {
                    await GetTasks();

                    await this.InvokeAsync(() => this.StateHasChanged());
                }


            });

            _connection.On<string>("SignalRBookingCabins", async (res) =>
            {
                if (res == "Done")
                {
                    await GetTasks();

                    await this.InvokeAsync(() => this.StateHasChanged());
                }
            });
            _connection.On<string>("SignalRCabins", async (res) =>
            {
                if (res == "Done")
                {
                    await GetTasks();

                    await this.InvokeAsync(() => this.StateHasChanged());
                }
            });
            _connection.On<string>("SignalRGroupCabins", async (res) =>
            {
                if (res == "Done")
                {
                    await GetTasks();

                    await this.InvokeAsync(() => this.StateHasChanged());
                }
            });

        }
        catch (Exception ex)
        {


        }
        finally
        {
            await GetTasks();
        }

    }

    private async Task GetTasks()
    {
        _disabletab = "none";
        await LoadDaysOfWeek(DateTime.Now);
        _listBookingRequest = await _iBookingRequestRepo.GetAllBookingRequestAsync();
        _listBookingRequest = _listBookingRequest.Where(c => (new DateTime(c.StartTime.Year, c.StartTime.Month, c.StartTime.Day)) >= _monday && (new DateTime(c.StartTime.Year, c.StartTime.Month, c.StartTime.Day)) <= _sunday && c.Status != 4 && c.Status != 5).ToList();
        //Lấy các thông tin hiển thị bên cột thông báo
        _LectureVM = await _ilecturersCPRepo.GetAllLecturerAsync();
        if (_textsearch != "")
        {
            _listLectureSearchVM = _LectureVM.Where(c => c.Email.ToString().Split("@")[0].Contains(_textsearch)).ToList();
        }
        else
        {
            _listLectureSearchVM = _LectureVM;
        }
        _clasVM = await _iClassRepo.GetAllClass();
        _subjectClassUPs = await _iclassSubjectApi.GetAllSubjectClass();
        _specializedDtos = await _ispecializedUPRepo.GetAll();
        _subjectDtos = await _isubjectUPRepo.GetAllSubjectAsync();
        _groupCabinViewModels = await _igroupCabinRepo.GetAllGroupCabinAsync();
        var cabinVM = await _icabinRepo.GetAllCabinAsync();
        _cabinViewModels = cabinVM.Where(c => c.IdTrainingFacility == Guid.Parse(IdTrainingFacility)).ToList();
        _listBookingCabinVM = await _ibookingCabinApiClient.GetAll();
        _shiftOfCabinVMs = await _ishiftOfCabinApiClient.GetAll();
        var teachingschedules = await _teachingScheduleApiClient.GetAll();
        _teachingScheduleVMs = teachingschedules.Where(c => c.IdTrainingFacility == Guid.Parse(IdTrainingFacility) && c.Status != 1).ToList();

    }

    #region Load DaysOfWeek
    public async Task LoadDaysOfWeek(DateTime date)
    {
        date = new DateTime(date.Year, date.Month, date.Day);

        var dayOfWeek = date.DayOfWeek;
        if (dayOfWeek == DayOfWeek.Sunday)
        {
            //xét chủ nhật là đầu tuần
            //return date.AddDays(1);

            //xét chủ nhật là ngày cuối tuần
            _monday = date.AddDays(-6);
        }
        else
        {
            int offset = dayOfWeek - DayOfWeek.Monday;
            _monday = date.AddDays(-offset);
        }
        _sunday = _monday.AddDays(6);
    }

    #endregion

    private async Task CloseCabin()
    {
        _disabletab = "block";
        _newIdRequest = Guid.NewGuid();
        _statusCabinUndo = 3;
        var bookingcabin = _listBookingCabinVM.FirstOrDefault(c => c.SubjectId == _idSubject && c.ClassId == _idClass && c.IdShift == _idShift && c.IdLectuter == _idLecture && c.IdCabin == _idCabin && c.DateCreated == new DateTime(_startTime.Year, _startTime.Month, _startTime.Day));
        var bookingcabinUpdate = new BookingCabinUpdateVM
            {
                SubjectId = bookingcabin.SubjectId,
                ClassId = bookingcabin.ClassId,
                IdCabin = bookingcabin.IdCabin,
                IdShift = bookingcabin.IdShift,
                DateCreated = new DateTime(_startTime.Year, _startTime.Month, _startTime.Day),
                CheckinTime = _startTime,
                CheckoutTime = _endTime,
                IndexOfBookingCabin = bookingcabin.IndexOfBookingCabin,
                Note = bookingcabin.Note,
                Status = 1,
                IdLectuter = bookingcabin.IdLectuter
            };
        var result = await _ibookingCabinApiClient.Update(bookingcabin.Id, _idCabin, _idSubject, _idClass, _idShift, bookingcabinUpdate);
        if (result)
        {

            if (await CreateBookingRequest(3))
            {
                _titleRoom = "Danh sách cabin còn trống";
                _itoastService.ShowSuccess("Hủy cabin thành công");
                _xephuy = "hủy";
                _undo = "block";
                await TimeLoadUndo();
            }
            else
            {
                _itoastService.ShowError("Hủy cabin thất bại");
            }
        }
        await GetTasks();
    }

    public async Task OnConfirmationSubmit(string deleteconfirmed)//xác nhận thoát tab chụp ảnh
    {
        if (deleteconfirmed != null)
        {
            await AddCabin();
        }
    }

    public async Task OnConfirmationClose(string deleteconfirmed)//xác nhận thoát tab chụp ảnh
    {
        if (deleteconfirmed != null)
        {
            _contenFeedBack = deleteconfirmed;
            await CloseCabin();
        }
    }

    private async Task SelectedPage(int page)
    {
        _bookingRequestSearch.PageNumber = page;
        await GetTasks();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591