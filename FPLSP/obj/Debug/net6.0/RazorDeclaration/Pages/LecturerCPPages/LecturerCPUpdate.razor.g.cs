// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FPLSP.Pages.LecturerCPPages
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
#line 2 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LecturerCPPages\LecturerCPUpdate.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LecturerCPPages\LecturerCPUpdate.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LecturerCPPages\LecturerCPUpdate.razor"
using FPLSP.Data.Securities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LecturerCPPages\LecturerCPUpdate.razor"
using FPLSP.Repositories.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LecturerCPPages\LecturerCPUpdate.razor"
using FPLSP.Server.Domain.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LecturerCPPages\LecturerCPUpdate.razor"
using FPLSP.Server.Infrastructure.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LecturerCPPages\LecturerCPUpdate.razor"
using FPLSP.Server.Infrastructure.ViewModels.LecturerCPVm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LecturerCPPages\LecturerCPUpdate.razor"
using FPLSP.Server.Infrastructure.ViewModels.LectuterSpecializedCP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LecturerCPPages\LecturerCPUpdate.razor"
           [Authorize(Roles = "AdminCore,AdminCS")]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/updatelecturercp/{id}")]
    public partial class LecturerCPUpdate : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 211 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LecturerCPPages\LecturerCPUpdate.razor"
       
    [Parameter]
    public string id { get; set; }

    [Parameter]
    public string image { get; set; }
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
    public ILectuterSpecializedCPCilents _lectuterSpecializedCPClients { get; set; }
    public List<LectuterSpecializedCPDto> _lstLectuterSpecializedCPDto { get; set; } = new List<LectuterSpecializedCPDto>();
    [Inject]
    public ILectuterSpecializedCPCilents _lectuterSpecializedCPRepo { get; set; }
    private string UserNameDisPlay;
    private string fistusername;
    [Inject] public IUserIdentityRepo _UserIdentityRepo { get; set; }
    private string UserName = "";
    private UserInListRoles userRole = new UserInListRoles();
    Uri uri;
    string maxlevel = "";
    string IdCoSo = "";
    [Inject]
    public CryptoServices _cryptoServices { get; set; }
    protected override async Task OnInitializedAsync()
    {
        uri = NavigationManager.ToAbsoluteUri(NavigationManager.Uri);
        if (string.IsNullOrEmpty(uri.Query) == false)
        {
            var urifist = uri.Query.Split("?")[1];
            maxlevel = _cryptoServices.Decrypt(urifist.Split("LDN01")[0].Replace("I0H", "/"));
            IdCoSo = _cryptoServices.Decrypt(urifist.Split("LDN01")[1].Replace("I0H", "/"));
        }
        //fistusername = await _localStorageService.GetItemAsStringAsync("userlogin");
        //UserNameDisPlay = fistusername.Split("@")[0];
        //UserNameDisPlay = UserNameDisPlay.Replace('"', ' ');
        //UserNameDisPlay = UserNameDisPlay.Replace('/', ' ');
        //UserNameDisPlay = UserNameDisPlay.Replace(" ", "");
        //UserName = UserNameDisPlay + "@fpt.edu.vn";
        //userRole = await _UserIdentityRepo.GetRoleUser(UserName);
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
        image = lecturersCP.ImageUrl;
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
            ToastService.ShowError("T??n kh??ng ???????c ch???a s??? v?? k?? t??? ?????c bi???t", "Error");
        }
        else if (!checkName(request.Ethnic))
        {
            ToastService.ShowError("D??n t???c kh??ng ???????c ch???a s??? v?? k?? t??? ?????c bi???t", "Error");
        }
        else if ((DateTime.Now.Year - request.Dob.Year) < 18)
        {
            ToastService.ShowError("Ng??y sinh kh??ng h???p l???", "Error");
        }
        else if (DateTime.Compare(request.IssuedOn, DateTime.Now) >= 0 || (request.IssuedOn.Year - request.Dob.Year) < 14)
        {
            ToastService.ShowError("Ng??y c???p kh??ng h???p l???", "Error");
        }
        else if (!(request.IdentityCard.Length == 9 || request.IdentityCard.Length == 12))
        {
            ToastService.ShowError("CMT/CCCD ph???i l?? 9 ho???c 12 s???", "Error");
        }
        else if (!checkNumber(request.IdentityCard))
        {
            ToastService.ShowError("CMT/CCCD ph???i l?? s???", "Error");
        }
        else if (!request.PhoneNumber.StartsWith("0") || request.PhoneNumber.Length != 10 || !checkNumber(request.PhoneNumber))
        {
            ToastService.ShowError("S??? ??i???n tho???i kh??ng ????ng ?????nh d???ng", "Error");
        }
        else if (chuyenganh.Count() == 0)
        {
            ToastService.ShowError("Gi???ng vi??n b???t bu???c ph???i ch???n chuy??n ng??nh", "Error");
        }
        else
        {
           

            if (request.IdentityCard != lecturersCP.IdentityCard || request.PhoneNumber != lecturersCP.PhoneNumber)
            {
                var le = await _LecturersCPRepo.GetAllLecturerAsync();

                if (request.IdentityCard != lecturersCP.IdentityCard && le.FirstOrDefault(x => x.IdentityCard == request.IdentityCard) != null)
                {
                    ToastService.ShowError("CMT/CCCD ???? t???n t???i", "Error");
                }
                else if (request.PhoneNumber != lecturersCP.PhoneNumber && le.FirstOrDefault(x => x.PhoneNumber == request.PhoneNumber) != null)
                {
                    ToastService.ShowError("S??? ??i???n tho???i ???? t???n t???i", "Error");
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
                            ToastService.ShowError("Gi???ng vi??n b???t bu???c ph???i ch???n chuy??n ng??nh", "Error");
                        }

                        Navigation.NavigateTo($"/lecturercp/{lecturersCP.TrainingFacilitiesId}");
                        ToastService.ShowSuccess("C???p nh???t gi???ng vi??n th??nh c??ng", "Success");
                    }
                    else
                    {
                        Navigation.NavigateTo($"/updatelecturercp/{lecturersCP.Id}");
                        ToastService.ShowError("C???p nh???t gi???ng vi??n th???t b???i", "Error");
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
                        ToastService.ShowError("Gi???ng vi??n b???t bu???c ph???i ch???n chuy??n ng??nh", "Error");
                    }
                    Navigation.NavigateTo($"/lecturercp/{lecturersCP.TrainingFacilitiesId}?{_cryptoServices.Encrypt((maxlevel).ToString()).Replace("/", "I0H") + "LDN01" + _cryptoServices.Encrypt((IdCoSo).ToString()).Replace("/", "I0H")}");
                    ToastService.ShowSuccess("C???p nh???t gi???ng vi??n th??nh c??ng", "Success");
                }
                else
                {
                    Navigation.NavigateTo($"/updatelecturercp/{lecturersCP.Id}?{_cryptoServices.Encrypt((maxlevel).ToString()).Replace("/", "I0H") + "LDN01" + _cryptoServices.Encrypt((IdCoSo).ToString()).Replace("/", "I0H")}");
                    ToastService.ShowError("C???p nh???t gi???ng vi??n th???t b???i", "Error");
                }
            }
        }
    }

    public void clearForm()
    {
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
        if (image != lecturersCP.ImageUrl)
        {
            image = lecturersCP.ImageUrl;
        }
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
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService _localStorageService { get; set; }
    }
}
#pragma warning restore 1591
