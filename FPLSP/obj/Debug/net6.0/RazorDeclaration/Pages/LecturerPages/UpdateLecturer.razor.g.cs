// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FPLSP.Pages.LecturerPages
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
#line 2 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LecturerPages\UpdateLecturer.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LecturerPages\UpdateLecturer.razor"
using FPLSP.Repositories.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LecturerPages\UpdateLecturer.razor"
using FPLSP.Server.Domain.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LecturerPages\UpdateLecturer.razor"
using FPLSP.Server.Domain.Entities.CoresParts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LecturerPages\UpdateLecturer.razor"
using FPLSP.Server.Infrastructure.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LecturerPages\UpdateLecturer.razor"
using FPLSP.Server.Infrastructure.ViewModels.LecturerCPVm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LecturerPages\UpdateLecturer.razor"
using FPLSP.Server.Infrastructure.ViewModels.LectuterSpecializedCP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LecturerPages\UpdateLecturer.razor"
           [Authorize(Roles = "AdminCS")]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/updatelecturer/{id}")]
    public partial class UpdateLecturer : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 194 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LecturerPages\UpdateLecturer.razor"
       
    [Parameter]
    public string id { get; set; }

    [Inject]
    public NavigationManager NavigationManager { get; set; }
    [Inject]
    public ILecturersCPRepo _LecturersCPRepo { get; set; }
    [Inject] public NavigationManager Navigation { get; set; }

    private string _codeNew { get; set; }
    public string _error { get; set; }
    public string status { get; set; } = "1";

    private LecturersCPRequest request = new LecturersCPRequest();
    [Inject]
    public ISpecializedCPRepo _speacializedRepositories { get; set; }
    public List<SpecializedDto> _lstSpecialized { get; set; } = new List<SpecializedDto>();
    [Inject]
    public IToastService ToastService { get; set; }
    public string roleID { get; set; }
    public LecturersCPViewModel lecturersCP { get; set; } = new LecturersCPViewModel();
    [Inject]
    public ITrainingFacilitiesCPRepo _trainingFacilityRepositories { get; set; }
    private List<TrainingFacilitiesCP> _lstTrainingFacility { get; set; } = new List<TrainingFacilitiesCP>();
    [Inject]
    public ILectuterSpecializedCPCilents _lectuterSpecializedCPClients { get; set; }
    public List<LectuterSpecializedCPDto> _lstLectuterSpecializedCPDto { get; set; } = new List<LectuterSpecializedCPDto>();
    [Inject]
    public ILectuterSpecializedCPCilents _lectuterSpecializedCPRepo { get; set; }
    protected override async Task OnInitializedAsync()
    {
        _lstTrainingFacility = await _trainingFacilityRepositories.GetTrainingFacilitiesAsync();
        _lstTrainingFacility = _lstTrainingFacility.Where(c => c.Status != 1).ToList();
        lecturersCP = await _LecturersCPRepo.GetLecturerListById(Guid.Parse(id));
        _lstSpecialized = await _speacializedRepositories.GetAll();
        _lstSpecialized = _lstSpecialized.Where(c => c.Status != 1).ToList();
        request.LecturersCode = lecturersCP.LecturersCode;
        request.LecturersName = lecturersCP.LecturersName;
        request.Gender = lecturersCP.Gender;
        request.Dob = lecturersCP.Dob;
        request.PhoneNumber = lecturersCP.PhoneNumber;
        request.Address = lecturersCP.Address;
        request.IdentityCard = lecturersCP.IdentityCard;
        request.IssuedOn = lecturersCP.IssuedOn;
        request.Ethnic = lecturersCP.Ethnic;
        request.ImageUrl = lecturersCP.ImageUrl;
        request.YearsOfExperience = lecturersCP.YearsOfExperience;
        request.HomeTown = lecturersCP.HomeTown;
        request.Description = lecturersCP.Description;
        request.Status = lecturersCP.Status;
        request.TrainingFacilitiesId = (Guid)lecturersCP.TrainingFacilitiesId;

        var listLectuterSpecialized = await _lectuterSpecializedCPClients.GetAllAsync();
        lecturersCP.ListSpecialized = listLectuterSpecialized.Select(x => x.Idspecialized).ToList();
        _lstLectuterSpecializedCPDto = await _lectuterSpecializedCPClients.GetAllAsync();
        _lstLectuterSpecializedCPDto = _lstLectuterSpecializedCPDto.Where(x => x.Idlecturers == Guid.Parse(id)).ToList();
        if (_lstSpecialized != null || _lstSpecialized.Count() > 0)
        {
            if (_lstLectuterSpecializedCPDto.Count > 0)
            {
                foreach (var item in _lstLectuterSpecializedCPDto)
                {
                    _lstSpecialized.FirstOrDefault(x => x.Id == item.Idspecialized).IsChecked = true;
                }
            }
        }

    }
    private void NavigateToSubjectCP(Guid id)
    {
        NavigationManager.NavigateTo($"/subjects/{id}");
    }

    public bool checkName(string x)
    {
        foreach (char c in x)
        {
            if (!Char.IsLetter(c) && c.ToString() != " ")
                return false;
        }
        return true;
    }
    public bool checkNumber(string x)
    {
        foreach (char c in x)
        {
            if (!Char.IsDigit(c))
                return false;
        }
        return true;
    }
    private async Task Update()
    {
        var chuyenganh = _lstSpecialized.Where(x => x.IsChecked == true);
        if (!checkName(request.LecturersName))
        {
            ToastService.ShowError("Tên không được chứa số và ký tự đặc biệt", "Error");
        }
        else if (!checkName(request.Ethnic))
        {
            ToastService.ShowError("Dân tộc không được chứa số và ký tự đặc biệt", "Error");
        }
        else if ((DateTime.Now.Year - request.Dob.Year) < 18)
        {
            ToastService.ShowError("Ngày sinh không hợp lệ", "Error");
        }
        else if (DateTime.Compare(request.IssuedOn, DateTime.Now) >= 0 || (request.IssuedOn.Year - request.Dob.Year) < 14)
        {
            ToastService.ShowError("Ngày cấp không hợp lệ", "Error");
        }
        else if (!(request.IdentityCard.Length == 9 || request.IdentityCard.Length == 12))
        {
            ToastService.ShowError("CMT/CCCD phải là 9 hoặc 12 số", "Error");
        }
        else if (!checkNumber(request.IdentityCard))
        {
            ToastService.ShowError("CMT/CCCD phải là số", "Error");
        }
        else if (!request.PhoneNumber.StartsWith("0") || request.PhoneNumber.Length != 10 || !checkNumber(request.PhoneNumber))
        {
            ToastService.ShowError("Số điện thoại không đúng định dạng", "Error");
        }
        else if (chuyenganh.Count() == 0)
        {
            ToastService.ShowError("Giảng viên bắt buộc phải chọn chuyên ngành", "Error");
        }
        else
        {

            if (request.IdentityCard != lecturersCP.IdentityCard || request.PhoneNumber != lecturersCP.PhoneNumber)
            {
                var le = await _LecturersCPRepo.GetAllLecturerAsync();

                if (request.IdentityCard != lecturersCP.IdentityCard && le.FirstOrDefault(x => x.IdentityCard == request.IdentityCard) != null)
                {
                    ToastService.ShowError("CMT/CCCD đã tồn tại", "Error");
                }
                else if (request.PhoneNumber != lecturersCP.PhoneNumber && le.FirstOrDefault(x => x.PhoneNumber == request.PhoneNumber) != null)
                {
                    ToastService.ShowError("Số điện thoại đã tồn tại", "Error");
                }
                else
                {
                    var result = await _LecturersCPRepo.UpdateLecturer(Guid.Parse(id), request);
                    if (result)
                    {
                        foreach (var item in _lstLectuterSpecializedCPDto)
                        {
                            await _lectuterSpecializedCPRepo.Delete(item.Idspecialized, item.Idlecturers);
                        }
                        var lec = await _LecturersCPRepo.GetAllLecturerAsync();
                        var lstSpecID = _lstSpecialized.Where(x => x.IsChecked == true).Select(x => x.Id).ToList();
                        if (lstSpecID.Count > 0)
                        {
                            LectuterSpecializedCPCreateVM lsVm = new LectuterSpecializedCPCreateVM();
                            lsVm.IdLectuter = Guid.Parse(id);
                            lsVm.Status = 1;
                            foreach (var item in lstSpecID)
                            {
                                await _lectuterSpecializedCPRepo.Create(item, lsVm);
                            }
                        }
                        else
                        {
                            ToastService.ShowError("Giảng viên bắt buộc phải chọn chuyên ngành", "Error");
                        }

                        Navigation.NavigateTo($"/listlecturer");
                        ToastService.ShowSuccess("Cập nhật giảng viên thành công", "Success");
                    }
                    else
                    {
                        Navigation.NavigateTo($"/updatelecturercp/{lecturersCP.Id}");
                        ToastService.ShowError("Cập nhật giảng viên thất bại", "Error");
                    }
                }
            }
            else
            {
                var result = await _LecturersCPRepo.UpdateLecturer(Guid.Parse(id), request);
                if (result)
                {
                    foreach (var item in _lstLectuterSpecializedCPDto)
                    {
                        await _lectuterSpecializedCPRepo.Delete(item.Idspecialized, item.Idlecturers);
                    }
                    var lec = await _LecturersCPRepo.GetAllLecturerAsync();
                    var lstSpecID = _lstSpecialized.Where(x => x.IsChecked == true).Select(x => x.Id).ToList();
                    if (lstSpecID.Count > 0)
                    {
                        LectuterSpecializedCPCreateVM lsVm = new LectuterSpecializedCPCreateVM();
                        lsVm.IdLectuter = Guid.Parse(id);
                        lsVm.Status = 1;
                        foreach (var item in lstSpecID)
                        {
                            await _lectuterSpecializedCPRepo.Create(item, lsVm);
                        }
                    }
                    else
                    {
                        ToastService.ShowError("Giảng viên bắt buộc phải chọn chuyên ngành", "Error");
                    }
                    Navigation.NavigateTo($"/listlecturer");
                    ToastService.ShowSuccess("Cập nhật giảng viên thành công", "Success");
                }
                else
                {
                    Navigation.NavigateTo($"/updatelecturer/{lecturersCP.Id}");
                    ToastService.ShowError("Cập nhật giảng viên thất bại", "Error");
                }
            }
        }
    }

    public async Task clearForm()
    {
        lecturersCP = await _LecturersCPRepo.GetLecturerListById(Guid.Parse(id));
        request.LecturersCode = lecturersCP.LecturersCode;
        request.LecturersName = lecturersCP.LecturersName;
        request.Gender = lecturersCP.Gender;
        request.Dob = lecturersCP.Dob;
        request.PhoneNumber = lecturersCP.PhoneNumber;
        request.Address = lecturersCP.Address;
        request.IdentityCard = lecturersCP.IdentityCard;
        request.IssuedOn = lecturersCP.IssuedOn;
        request.Ethnic = lecturersCP.Ethnic;
        request.ImageUrl = lecturersCP.ImageUrl;
        request.YearsOfExperience = lecturersCP.YearsOfExperience;
        request.HomeTown = lecturersCP.HomeTown;
        request.Description = lecturersCP.Description;
        request.Status = lecturersCP.Status;
        request.TrainingFacilitiesId = (Guid)lecturersCP.TrainingFacilitiesId;
        foreach (var item in _lstLectuterSpecializedCPDto)
        {
            _lstSpecialized.FirstOrDefault(x => x.Id == item.Idspecialized).IsChecked = true;
        }
    }
    void CheckManual(Guid st, bool check)
    {
        if (check == true)
        {
            foreach (var x in _lstSpecialized.Where(c => c.Id == st))
            {
                x.IsChecked = false;
            }
        }
        if (check == false)
        {
            foreach (var x in _lstSpecialized.Where(c => c.Id == st))
            {
                x.IsChecked = true;
            }
        }
    }
    private void AssignImageUrl(string imgUrl)
    {
        request.ImageUrl = imgUrl;
        if (!(imgUrl.ToLower().Contains(".png") || imgUrl.ToLower().Contains(".jpg") || imgUrl.ToLower().Contains(".gif")))
        {
            ToastService.ShowError("Ảnh không hợp lệ", "Error");
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
