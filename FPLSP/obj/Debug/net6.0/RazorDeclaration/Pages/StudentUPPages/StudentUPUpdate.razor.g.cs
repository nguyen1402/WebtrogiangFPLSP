// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FPLSP.Pages.StudentUPPages
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
#line 2 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\StudentUPUpdate.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\StudentUPUpdate.razor"
using FPLSP.Server.Infrastructure.ViewModels.StudentsUPVm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\StudentUPUpdate.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\StudentUPUpdate.razor"
using FPLSP.Repositories.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\StudentUPUpdate.razor"
using FPLSP.Server.Domain.Dtos.StudentUPDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\StudentUPUpdate.razor"
using FPLSP.Server.Domain.Entities.UserParts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\StudentUPUpdate.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\StudentUPUpdate.razor"
           [Authorize(Roles = "LecturerFPLSP")]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout2))]
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/StudentUPUpdate/{id:guid}")]
    public partial class StudentUPUpdate : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 241 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\StudentUPUpdate.razor"
 
    private StudentUpdateVM _studentsUPUpdateVm = new StudentUpdateVM();

    [Inject] private IToastService _toastService { get; set; }
    [Inject] private IStudentUPRepo studentUPRepo { get; set; }
    [Inject] public NavigationManager Navigation { get; set; }
    [Inject] public ILocalStorageService _localStorage { get; set; }

    bool flag = false;

    [Parameter]
    public Guid Id { get; set; }
    public List<StudentUP> ListStudentUps { get; set; } = new List<StudentUP>();
    public string ImgUrl { get; set; }
    public string userEmail { get; set; }
    public bool ShowAuthError { get; set; }
    public StudentUpDto Student { get; set; } = new StudentUpDto();


    protected async override Task OnInitializedAsync()
    {
        await Get(); ListStudentUps = new List<StudentUP>();
        ListStudentUps = await studentUPRepo.GetAllStudentUPAsync();
        //var fistusername = await _localStorage.GetItemAsStringAsync("userlogin", null);
        //var UserNameDisPlay = fistusername.Split("@")[0];
        //UserNameDisPlay = UserNameDisPlay.Replace('"', ' ');
        //UserNameDisPlay = UserNameDisPlay.Replace('/', ' ');
        //UserNameDisPlay = UserNameDisPlay.Replace(" ", "");
        userEmail = Student.Email;
    }
    private async Task Get()
    {
        var studentUp = await studentUPRepo.GetStudentUPById(Id);
        var updateVm = new StudentsUPUpdateVm()
            {
                Email = studentUp.Email,
                Ethnic = studentUp.Ethnic=="default"? "":studentUp.Ethnic,
                Address = studentUp.Address == "default" ? "" : studentUp.Address,
                DateOfBirth = studentUp.DateOfBirth,
                Description = studentUp.Description == "default" ? "" : studentUp.Description,
                FathersName = studentUp.FathersName == "default" ? "" : studentUp.FathersName,
                Gender = studentUp.Gender,
                HomeTown = studentUp.HomeTown == "default" ? "" : studentUp.HomeTown,
                IdentityCardNumber = studentUp.IdentityCardNumber=="default"? "":studentUp.IdentityCardNumber,
                ImageUrl = studentUp.ImageUrl=="default"? "":studentUp.ImageUrl,
                IssuedOn = studentUp.IssuedOn,
                MotherName = studentUp.MotherName == "default" ? "" : studentUp.MotherName,
                Password = studentUp.Password,
                PhoneNumber = studentUp.PhoneNumber == "default" ? "" : studentUp.PhoneNumber,
                Status = studentUp.Status,
                StudentName = studentUp.StudentName == "default" ? "" :studentUp.StudentName,
                StudentCode = studentUp.StudentCode
            };
        _studentsUPUpdateVm = new StudentUpdateVM()
        {
            Email = updateVm.Email,
            Ethnic = updateVm.Ethnic,
            Address = updateVm.Address,
            DateOfBirth = updateVm.DateOfBirth,
            Description = updateVm.Description,
            FathersName = updateVm.FathersName,
            Gender = updateVm.Gender,
            HomeTown = updateVm.HomeTown,
            IdentityCardNumber = updateVm.IdentityCardNumber,
            ImageUrl = updateVm.ImageUrl,
            IssuedOn = updateVm.IssuedOn,
            MotherName = updateVm.MotherName,
            Password = updateVm.Password,
            PhoneNumber = updateVm.PhoneNumber,
            Status = updateVm.Status,
            StudentName = updateVm.StudentName,
            StudentCode = updateVm.StudentCode

            //Email = studentUp.Email,
            //Ethnic = studentUp.Ethnic,
            //Address = studentUp.Address,
            //DateOfBirth = studentUp.DateOfBirth,
            //Description = studentUp.Description,
            //FathersName = studentUp.FathersName,
            //Gender = studentUp.Gender,
            //HomeTown = studentUp.HomeTown,
            //IdentityCardNumber = studentUp.IdentityCardNumber,
            //ImageUrl = studentUp.ImageUrl,
            //IssuedOn = studentUp.IssuedOn,
            //MotherName = studentUp.MotherName,
            //Password = studentUp.Password,
            //PhoneNumber = studentUp.PhoneNumber,
            //Status = studentUp.Status,
            //StudentName = studentUp.StudentName,
            //StudentCode = studentUp.StudentCode
        };
        Student = studentUp;
        ImgUrl = studentUp.ImageUrl;
    }


    private async Task Update()
    {
        //if (CheckInfomationChanged(_studentsUPUpdateVm))
        //{
        //    Navigation.NavigateTo($"/StudentUPUpdate/{Id}");
        //}
        //else
        if (CheckCMT(_studentsUPUpdateVm.IdentityCardNumber) && (_studentsUPUpdateVm.IdentityCardNumber != Student.IdentityCardNumber))
        {
            _toastService.ShowError("CCCD bị trùng");
            ShowAuthError = true;
            Navigation.NavigateTo($"/StudentUPUpdate/{Id}");
        }
        else if (CheckPhoneNumber(_studentsUPUpdateVm.PhoneNumber) && (_studentsUPUpdateVm.PhoneNumber != Student.PhoneNumber))
        {
            _toastService.ShowError("Số điện thoại bị trùng");
            ShowAuthError = true;
            Navigation.NavigateTo($"/StudentUPUpdate/{Id}");
        }
        else if (CheckMail(_studentsUPUpdateVm.Email) && (_studentsUPUpdateVm.Email != Student.Email))
        {
            _toastService.ShowError("Email bị trùng");
            ShowAuthError = true;
            Navigation.NavigateTo($"/StudentUPUpdate/{Id}");
        }
        else
        {
            var result = await studentUPRepo.UpdateStudentUP(Id, _studentsUPUpdateVm);
            if (result != 1)
            {
                _toastService.ShowError("Lỗi không thêm được Sinh viên");
                ShowAuthError = true;
                Navigation.NavigateTo($"/StudentUPUpdate/{Id}");
            }
            else
            {
                _toastService.ShowSuccess("Sửa Thành Công");
                Navigation.NavigateTo($"/viewclass/{Student.Email.Replace(".","-")}");
            }
        }
    }

    private bool CheckInfomationChanged(StudentsUPUpdateVm _studentsUpUpdateVm)
    {
        var flag = false;
        if (_studentsUPUpdateVm.ImageUrl == Student.ImageUrl &&
            _studentsUPUpdateVm.StudentName == Student.StudentName &&
            _studentsUPUpdateVm.Address == Student.Address &&
            _studentsUPUpdateVm.DateOfBirth == Student.DateOfBirth &&
            _studentsUPUpdateVm.Description == Student.Description &&
            _studentsUPUpdateVm.Email == Student.Email &&
            _studentsUPUpdateVm.Ethnic == Student.Ethnic &&
            _studentsUPUpdateVm.FathersName == Student.FathersName &&
            _studentsUPUpdateVm.IdentityCardNumber == Student.IdentityCardNumber &&
            _studentsUPUpdateVm.Gender == Student.Gender &&
            _studentsUPUpdateVm.ImageUrl == Student.ImageUrl &&
            _studentsUPUpdateVm.MotherName == Student.MotherName &&
            _studentsUPUpdateVm.PhoneNumber == Student.PhoneNumber &&
            _studentsUPUpdateVm.HomeTown == Student.HomeTown &&
            _studentsUPUpdateVm.Password == Student.Password &&
            _studentsUPUpdateVm.IssuedOn == Student.IssuedOn &&
            _studentsUPUpdateVm.Status == Student.Status) flag = true;

        return flag;

    }
    private void AssignImageUrl(string Image)
    {
        _studentsUPUpdateVm.ImageUrl = Image;
        flag = true;
    }

    private void Exit()
    {
        Navigation.NavigateTo($"/viewclass/{Student.Email.Replace(".","-")}");
    }
    private async Task Restore()
    {
        await OnInitializedAsync();
    }
    private bool CheckMail(string mail)
    {
        var checkExited = ListStudentUps.Any(c => Equals(mail, c.Email));
        return checkExited;
    }
    private bool CheckCMT(string CCCD)
    {
        var checkExited = ListStudentUps.Any(c => Equals(CCCD, c.IdentityCardNumber));
        return checkExited;
    }
    private bool CheckPhoneNumber(string phoneNumber)
    {
        var checkExited = ListStudentUps.Any(c => Equals(phoneNumber, c.PhoneNumber));
        return checkExited;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
