// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FPLSP.Pages.PagesResourcelinkCP
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
#line 2 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesResourcelinkCP\Createresourcelink.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesResourcelinkCP\Createresourcelink.razor"
using FPLSP.Data.Securities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesResourcelinkCP\Createresourcelink.razor"
using FPLSP.Repositories;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesResourcelinkCP\Createresourcelink.razor"
using FPLSP.Repositories.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesResourcelinkCP\Createresourcelink.razor"
using FPLSP.Server.Domain.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesResourcelinkCP\Createresourcelink.razor"
using FPLSP.Server.Infrastructure.ViewModels.ResourceLink;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesResourcelinkCP\Createresourcelink.razor"
           [Authorize(Roles = "AdminCore,AdminCS")]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/createresourcelink/{idspecializedNonDecrypt}/{idsubjectNonDecrypt}/{idlessonNonDecrypt}")]
    public partial class Createresourcelink : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 103 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesResourcelinkCP\Createresourcelink.razor"
       
    private ResourceLinkCreateVM model = new ResourceLinkCreateVM();
    [Inject]
    public NavigationManager Navigation { get; set; }

    [Inject]
    public IResourceLinkRepo _iResourcelinkClient { get; set; }
    public bool ShowAuthError { get; set; }
    [Parameter]
    public string Error { get; set; }
    [Parameter]
    public string idspecializedNonDecrypt { get; set; }
    [Parameter]
    public string idsubjectNonDecrypt { get; set; }
    [Parameter]
    public string idlessonNonDecrypt { get; set; }
    public string idspecialized = "";
    public string idsubject = "";
    public string idlesson = "";
    [Inject] private IToastService _toastService { get; set; }
    protected Comfirmation Confirmation { get; set; }
    [Inject]
    public CryptoServices _cryptoServices { get; set; }
    [Inject]
    public ISubjectClient _iSubjectClient { get; set; }
    List<SubjectDto> lstSubjectDtos = new List<SubjectDto>();

    Uri uri;
    string maxlevel = "";
    string IdCoSo = "";
    protected override async Task OnInitializedAsync()
    {
        uri = Navigation.ToAbsoluteUri(Navigation.Uri);
        if (string.IsNullOrEmpty(uri.Query) == false)
        {
            var urifist = uri.Query.Split("?")[1];
            maxlevel = _cryptoServices.Decrypt(urifist.Split("LDN01")[0].Replace("I0H", "/"));
            IdCoSo = _cryptoServices.Decrypt(urifist.Split("LDN01")[1].Replace("I0H", "/"));
        }
        idspecialized = _cryptoServices.Decrypt(idspecializedNonDecrypt.Replace("I0H", "/"));
        idsubject = _cryptoServices.Decrypt(idsubjectNonDecrypt.Replace("I0H", "/"));
        idlesson = _cryptoServices.Decrypt(idlessonNonDecrypt.Replace("I0H", "/"));
        lstSubjectDtos = await _iSubjectClient.GetAllSubjectByIdSpecialzed(Guid.Parse(idspecialized));
        model.Status = 1;
    }
    private async Task Create()
    {
        var allResourceLink = await _iResourcelinkClient.GetAllAsync();
        var title = allResourceLink.Where(p => p.ResourcesTitle == model.ResourcesTitle);
        var path = allResourceLink.Where(p => p.Path == model.Path);
        if (title.Count() > 0)
        {
            _toastService.ShowError("Ti??u ????? ???? t???n t???i");
            var url = Path.Combine("/createresourcelink/", _cryptoServices.Encrypt((idspecialized).ToString()).Replace("/", "I0H") + "/" + _cryptoServices.Encrypt((idsubject).ToString()).Replace("/", "I0H") + "/" + _cryptoServices.Encrypt((idlesson).ToString()).Replace("/", "I0H") + $"?{_cryptoServices.Encrypt((maxlevel).ToString()).Replace("/", "I0H") + "LDN01" + _cryptoServices.Encrypt((IdCoSo).ToString()).Replace("/", "I0H")}");
            Navigation.NavigateTo(url);
        }
        else
        {
            ShowAuthError = false;
            var result = await _iResourcelinkClient.Create(model);

            if (result != 1)
            {
                _toastService.ShowError("L???i! Vui l??ng th??? l???i");
                var url = Path.Combine("/createresourcelink/", _cryptoServices.Encrypt((idspecialized).ToString()).Replace("/", "I0H") + "/" + _cryptoServices.Encrypt((idsubject).ToString()).Replace("/", "I0H") + "/" + _cryptoServices.Encrypt((idlesson).ToString()).Replace("/", "I0H") + $"?{_cryptoServices.Encrypt((maxlevel).ToString()).Replace("/", "I0H") + "LDN01" + _cryptoServices.Encrypt((IdCoSo).ToString()).Replace("/", "I0H")}");
                Navigation.NavigateTo(url);
            }
            else
            {
                _toastService.ShowSuccess("Th??m m???i th??nh c??ng");

                var url = Path.Combine("/resourcelink/" + _cryptoServices.Encrypt((idspecialized).ToString()).Replace("/", "I0H"), _cryptoServices.Encrypt((idsubject).ToString()).Replace("/", "I0H"), _cryptoServices.Encrypt((idlesson).ToString()).Replace("/", "I0H") + $"?{_cryptoServices.Encrypt((maxlevel).ToString()).Replace("/", "I0H") + "LDN01" + _cryptoServices.Encrypt((IdCoSo).ToString()).Replace("/", "I0H")}");
                Navigation.NavigateTo(url);


            }
        }

    }
    private void Quaylaithemmoi()
    {
        var url = Path.Combine("/createresourcelink/", _cryptoServices.Encrypt((idspecialized).ToString()).Replace("/", "I0H") + "/" + _cryptoServices.Encrypt((idsubject).ToString()).Replace("/", "I0H") + "/" + _cryptoServices.Encrypt((idlesson).ToString()).Replace("/", "I0H") + $"?{_cryptoServices.Encrypt((maxlevel).ToString()).Replace("/", "I0H") + "LDN01" + _cryptoServices.Encrypt((IdCoSo).ToString()).Replace("/", "I0H")}");
        Navigation.NavigateTo(url);
    }
    private void Quaylaitrangchu()
    {
        var url = Path.Combine("/resourcelink/" + _cryptoServices.Encrypt((idspecialized).ToString()).Replace("/", "I0H"), _cryptoServices.Encrypt((idsubject).ToString()).Replace("/", "I0H"), _cryptoServices.Encrypt((idlesson).ToString()).Replace("/", "I0H") + $"?{_cryptoServices.Encrypt((maxlevel).ToString()).Replace("/", "I0H") + "LDN01" + _cryptoServices.Encrypt((IdCoSo).ToString()).Replace("/", "I0H")}");
        Navigation.NavigateTo(url);
    }
    private void Lammoi()
    {
        model.ResourcesTitle = null;
        model.Path = null;
        model.Status = 1;
        model.Descriptions = null;
    }
    public async Task OnConfirmation(bool confirmed)
    {
        if (confirmed)
        {
            var url = Path.Combine("/createresourcelink/", _cryptoServices.Encrypt((idspecialized).ToString()).Replace("/", "I0H") + "/" + _cryptoServices.Encrypt((idsubject).ToString()).Replace("/", "I0H") + "/" + _cryptoServices.Encrypt((idlesson).ToString()).Replace("/", "I0H") + $"?{_cryptoServices.Encrypt((maxlevel).ToString()).Replace("/", "I0H") + "LDN01" + _cryptoServices.Encrypt((IdCoSo).ToString()).Replace("/", "I0H")}");

            Navigation.NavigateTo(url);
        }
        else
        {
            var url = Path.Combine("/resourcelink/" + _cryptoServices.Encrypt((idspecialized).ToString()).Replace("/", "I0H"), _cryptoServices.Encrypt((idsubject).ToString()).Replace("/", "I0H"), _cryptoServices.Encrypt((idlesson).ToString()).Replace("/", "I0H") + $"?{_cryptoServices.Encrypt((maxlevel).ToString()).Replace("/", "I0H") + "LDN01" + _cryptoServices.Encrypt((IdCoSo).ToString()).Replace("/", "I0H")}");
            Navigation.NavigateTo(url);
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
