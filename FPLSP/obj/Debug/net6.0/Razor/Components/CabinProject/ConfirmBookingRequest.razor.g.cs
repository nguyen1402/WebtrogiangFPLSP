#pragma checksum "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\CabinProject\ConfirmBookingRequest.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "769bef51b6677a14bf654ec05e7e6bfcd9508969"
// <auto-generated/>
#pragma warning disable 1591
namespace FPLSP.Components.CabinProject
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
#line 1 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\CabinProject\ConfirmBookingRequest.razor"
using FPLSP.Pages.CabinProject.AdminCoSo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\CabinProject\ConfirmBookingRequest.razor"
using FPLSP.Repositories.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\CabinProject\ConfirmBookingRequest.razor"
using FPLSP.Repositories.Interfaces.CabinProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\CabinProject\ConfirmBookingRequest.razor"
using FPLSP.Server.Domain.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\CabinProject\ConfirmBookingRequest.razor"
using FPLSP.Server.Domain.Entities.CoresParts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\CabinProject\ConfirmBookingRequest.razor"
using FPLSP.Server.Infrastructure.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\CabinProject\ConfirmBookingRequest.razor"
using FPLSP.Server.Infrastructure.ViewModels.CabinProject.BookingRequest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\CabinProject\ConfirmBookingRequest.razor"
using FPLSP.Server.Infrastructure.ViewModels.CabinProject.Cabin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\CabinProject\ConfirmBookingRequest.razor"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\CabinProject\ConfirmBookingRequest.razor"
using System.ComponentModel.DataAnnotations;

#line default
#line hidden
#nullable disable
    public partial class ConfirmBookingRequest : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 11 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\CabinProject\ConfirmBookingRequest.razor"
 if (ShowConfirmation)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "modal fade show d-block");
            __builder.AddAttribute(2, "id", "exampleModal");
            __builder.AddAttribute(3, "tabindex", "-1");
            __builder.AddAttribute(4, "role", "dialog");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "modal-dialog");
            __builder.AddAttribute(7, "role", "document");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "modal-content");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "modal-header");
            __builder.OpenElement(12, "h5");
            __builder.AddAttribute(13, "class", "modal-title");
            __builder.AddAttribute(14, "id", "exampleModalLabel");
#nullable restore
#line (18,69)-(18,86) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\CabinProject\ConfirmBookingRequest.razor"
__builder.AddContent(15, ConfirmationTitle);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "modal-body");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "form-group pt-2 row");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "col-md-6");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "for", "name");
            __builder.AddAttribute(25, "class", "col-form-label");
            __builder.AddMarkupContent(26, "Giảng Viên: ");
#nullable restore
#line (24,81)-(24,160) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\CabinProject\ConfirmBookingRequest.razor"
__builder.AddContent(27, _LectureVM.FirstOrDefault(c=>c.Id == IdLecturer).Email.ToString().Split("@")[0]);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                            ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "for", "class");
            __builder.AddAttribute(31, "class", "col-form-label");
            __builder.AddMarkupContent(32, "Lớp: ");
#nullable restore
#line (25,75)-(25,131) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\CabinProject\ConfirmBookingRequest.razor"
__builder.AddContent(33, _clasVM.FirstOrDefault(c=>c.Id == IdClass).ClassroomName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                            ");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "for", "subject");
            __builder.AddAttribute(37, "class", "col-form-label");
            __builder.AddMarkupContent(38, "Môn: ");
#nullable restore
#line (26,77)-(26,138) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\CabinProject\ConfirmBookingRequest.razor"
__builder.AddContent(39, _subjectDtos.FirstOrDefault(c=>c.Id == IdSubject).SubjectCode);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                        ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "col-md-6");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "for", "shift");
            __builder.AddAttribute(45, "class", "col-form-label");
            __builder.AddMarkupContent(46, "Ca dạy: ");
#nullable restore
#line (29,78)-(29,87) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\CabinProject\ConfirmBookingRequest.razor"
__builder.AddContent(47, ShiftName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                            ");
            __builder.OpenElement(49, "div");
            __builder.AddAttribute(50, "for", "day");
            __builder.AddAttribute(51, "class", "col-form-label");
            __builder.AddMarkupContent(52, "Thứ: ");
#nullable restore
#line (30,73)-(30,119) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\CabinProject\ConfirmBookingRequest.razor"
__builder.AddContent(53, Day.ToString("dddd", new CultureInfo("vi-VN")));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                            ");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "for", "cabin");
            __builder.AddAttribute(57, "class", "col-form-label");
            __builder.AddMarkupContent(58, "Phòng: ");
#nullable restore
#line (31,77)-(31,138) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\CabinProject\ConfirmBookingRequest.razor"
__builder.AddContent(59, _cabinViewModels.FirstOrDefault(c=>c.Id == IdCabin).CabinName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 33 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\CabinProject\ConfirmBookingRequest.razor"
                         if (CheckConfirm == 1)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(60, "div");
            __builder.OpenElement(61, "input");
            __builder.AddAttribute(62, "id", "conten");
            __builder.AddAttribute(63, "class", "form-control");
            __builder.AddAttribute(64, "placeholder", "Nguyên nhân hủy phòng");
            __builder.AddAttribute(65, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 36 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\CabinProject\ConfirmBookingRequest.razor"
                                                                                      _contenOfFeedBack

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(66, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => _contenOfFeedBack = __value, _contenOfFeedBack));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n                                ");
            __builder.OpenElement(68, "span");
            __builder.AddAttribute(69, "style", "color:" + " red;" + " display:" + (
#nullable restore
#line 37 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\CabinProject\ConfirmBookingRequest.razor"
                                                                  _displayErrror

#line default
#line hidden
#nullable disable
            ) + ";");
            __builder.AddMarkupContent(70, "Nguyên nhân hủy phòng không được để trống");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 39 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\CabinProject\ConfirmBookingRequest.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n                ");
            __builder.OpenElement(72, "div");
            __builder.AddAttribute(73, "class", "modal-footer");
            __builder.OpenElement(74, "button");
            __builder.AddAttribute(75, "type", "button");
            __builder.AddAttribute(76, "class", "btn btn-secondary");
            __builder.AddAttribute(77, "data-dismiss", "modal");
            __builder.AddAttribute(78, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\CabinProject\ConfirmBookingRequest.razor"
                                  () => OnConfirmationChange(false)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(79, "\r\n                        Hủy\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n                    ");
            __builder.OpenElement(81, "button");
            __builder.AddAttribute(82, "type", "submit");
            __builder.AddAttribute(83, "class", "btn btn-danger");
            __builder.AddAttribute(84, "form", "details-form");
            __builder.AddAttribute(85, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 49 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\CabinProject\ConfirmBookingRequest.razor"
                                  () => { OnConfirmationChange(true); }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(86, "\r\n                        Xác nhận\r\n                    ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 56 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\CabinProject\ConfirmBookingRequest.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 58 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\CabinProject\ConfirmBookingRequest.razor"
       
    [Inject] private ISubjectUPRepo _isubjectUPRepo { get; set; }
    [Inject] private ILecturersCPRepo _ilecturersCPRepo { get; set; }
    [Inject] private ICabinRepo _icabinRepo { get; set; }
    [Inject] private ITaskRepositories<ClassUPViewModel> _iClassRepo { get; set; }


    private List<SubjectDto> _subjectDtos = new List<SubjectDto>();
    private List<ClassUPViewModel> _clasVM = new List<ClassUPViewModel>();
    private List<LecturersCP> _LectureVM = new List<LecturersCP>();
    private List<CabinViewModel> _cabinViewModels = new List<CabinViewModel>();

    protected bool ShowConfirmation { get; set; }

    [Parameter]
    public string ConfirmationTitle { get; set; } = "";
    [Parameter]
    public string ConfirmationMessage { get; set; } = "Chi tiết ca dạy";

    [Parameter]
    public Guid IdClass { get; set; }
    [Parameter]
    public Guid IdSubject { get; set; }
    [Parameter]
    public Guid IdLecturer { get; set; }
    [Parameter]
    public string ShiftName { get; set; }
    [Parameter]
    public DateTime Day { get; set; }
    [Parameter]
    public Guid IdCabin { get; set; }
    [Parameter]
    public int CheckConfirm { get; set; }

    public string _contenOfFeedBack = "";
    public string _displayErrror = "none";

    [Parameter]
    public EventCallback<string> ConfirmationChanged { get; set; }

    public void show()
    {
        ShowConfirmation = true;
        StateHasChanged();
    }
    protected async Task OnConfirmationChange(bool value)
    {
        if (value)
        {            
            if (_contenOfFeedBack == string.Empty && CheckConfirm == 1)
            {
                _displayErrror = "block";
            }
            else
            {
                _displayErrror = "none";
                ShowConfirmation = false;
                await ConfirmationChanged.InvokeAsync(_contenOfFeedBack);
            }
        }
        else
        {
            ShowConfirmation = false;
            await ConfirmationChanged.InvokeAsync(null);
        }

    }
    protected async override Task OnInitializedAsync()
    {
        _subjectDtos = await _isubjectUPRepo.GetAllSubjectAsync();
        _clasVM = await _iClassRepo.GetAllClass();
        _LectureVM = await _ilecturersCPRepo.GetAllLecturerAsync();
        _cabinViewModels = await _icabinRepo.GetAllCabinAsync();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
