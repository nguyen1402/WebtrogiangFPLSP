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
#line 2 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesResourcelinkCP\Resourcelink.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesResourcelinkCP\Resourcelink.razor"
using FPLSP.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesResourcelinkCP\Resourcelink.razor"
using FPLSP.Components.ResourceLinkCP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesResourcelinkCP\Resourcelink.razor"
using FPLSP.Data.Securities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesResourcelinkCP\Resourcelink.razor"
using FPLSP.Repositories;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesResourcelinkCP\Resourcelink.razor"
using FPLSP.Repositories.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesResourcelinkCP\Resourcelink.razor"
using FPLSP.Server.Data.SeedWork;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesResourcelinkCP\Resourcelink.razor"
using FPLSP.Server.Domain.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesResourcelinkCP\Resourcelink.razor"
using FPLSP.Server.Infrastructure.ViewModels.ResourceLink;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesResourcelinkCP\Resourcelink.razor"
           [Authorize(Roles = "AdminCore,AdminCS")]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/resourcelink/{idspecializedNonDecrypt}/{idsubjectNonDecrypt}/{idlessonNonDecrypt}")]
    public partial class Resourcelink : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 134 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesResourcelinkCP\Resourcelink.razor"
       
    public List<ResourceLinkDto> ListRourceLink { get; set; } = new List<ResourceLinkDto>();
    public MetaData MetaData { get; set; } = new MetaData();

    private ResourceLinkListSearch _parameters = new ResourceLinkListSearch();
    [Inject]
    public NavigationManager NavigationManager { get; set; }
    [Inject]
    public IResourceLinkRepo _iResourcelinkClient { get; set; }
    [Parameter]
    public string idspecializedNonDecrypt { get; set; }
    [Parameter]
    public string idsubjectNonDecrypt { get; set; }
    [Parameter]
    public string idlessonNonDecrypt { get; set; }
    public string idspecialized = "";
    public string idsubject = "";
    public string idlesson = "";
    public string Error { get; set; }
    public DateTime time { get; set; }
    public TimeSpan tg;
    public bool Check = false;
    private int stt = 0;
    private List<Guid> _removeListResourcelink = new List<Guid>();
    [Inject]
    public ISubjectClient _iSubjectClient { get; set; }
    [Inject] private IToastService _toastService { get; set; }
    [Inject]
    public CryptoServices _cryptoServices { get; set; }
    private string _idResourceLink;
    protected Comfirmation DeleteConfirmation { get; set; }

    List<SubjectDto> lstSubjectDtos = new List<SubjectDto>();

    Uri uri;
    string maxlevel = "";
    string IdCoSo = "";
    protected async override Task OnInitializedAsync()
    {
        uri = NavigationManager.ToAbsoluteUri(NavigationManager.Uri);
        if (string.IsNullOrEmpty(uri.Query) == false)
        {
            var urifist = uri.Query.Split("?")[1];
            maxlevel = _cryptoServices.Decrypt(urifist.Split("LDN01")[0].Replace("I0H", "/"));
            IdCoSo = _cryptoServices.Decrypt(urifist.Split("LDN01")[1].Replace("I0H", "/"));
        }
        idspecialized = _cryptoServices.Decrypt(idspecializedNonDecrypt.Replace("I0H", "/"));
        idsubject = _cryptoServices.Decrypt(idsubjectNonDecrypt.Replace("I0H", "/"));
        idlesson = _cryptoServices.Decrypt(idlessonNonDecrypt.Replace("I0H", "/"));
        _parameters.Status = 3;
        _parameters.IdSubject =Guid.Parse(idsubject);
        lstSubjectDtos = await _iSubjectClient.GetAllSubjectByIdSpecialzed(Guid.Parse(idspecialized));
        
        await GetTasks();
    }
    private async Task Undo()
    {
        _parameters.Name = "";
        _parameters.Status = 3;
        _parameters.PageNumber = 1;
        await GetTasks();

    }
    private async Task TimKiem()
    {
        await GetTasks();
    }
    private async Task ChangeValue(int value)
    {
        _parameters.Status = value;
        _parameters.Name = _parameters.Name;
        await GetTasks();
    }
    public async Task SearchTask(ResourceLinkListSearch resourceLinkListSearch)
    {
        _parameters = resourceLinkListSearch;
        Check = false;
        await GetTasks();
    }
    private void RedirectToDetails(Guid id)
    {

        var url = Path.Combine($"/detailsresourcelink/{id.ToString()}?{_cryptoServices.Encrypt((maxlevel).ToString()).Replace("/", "I0H") + "LDN01" + _cryptoServices.Encrypt((IdCoSo).ToString()).Replace("/", "I0H")}");
        NavigationManager.NavigateTo(url);
    }
    private void RedirectToUpdate1(Guid idresource)
    {
        var url = Path.Combine("/updateresourcelink/" + _cryptoServices.Encrypt((idspecialized).ToString()).Replace("/", "I0H") + "/" + _cryptoServices.Encrypt((idsubject).ToString()).Replace("/", "I0H") + "/" + _cryptoServices.Encrypt((idlesson).ToString()).Replace("/", "I0H") + "/" + _cryptoServices.Encrypt((idresource).ToString()).Replace("/", "I0H") + $"?{_cryptoServices.Encrypt((maxlevel).ToString()).Replace("/", "I0H") + "LDN01" + _cryptoServices.Encrypt((IdCoSo).ToString()).Replace("/", "I0H")}");

        NavigationManager.NavigateTo(url);
    }

    private async Task RedirectToDelete(Guid id)
    {
        var url = Path.Combine($"/deleteresourcelink/{id.ToString()}?{_cryptoServices.Encrypt((maxlevel).ToString()).Replace("/", "I0H") + "LDN01" + _cryptoServices.Encrypt((IdCoSo).ToString()).Replace("/", "I0H")}");
        NavigationManager.NavigateTo(url);
    }

    private async Task GetTasks()
    {
        try
        {
            var pagingResponse = await _iResourcelinkClient.Gets(_parameters);
            ListRourceLink = pagingResponse.Items;
            MetaData = pagingResponse.MetaData;
            time = DateTime.Now;
        }
        catch (Exception ex)
        {
            Error = ex.Message;
        }

    }

    private void Quaylai()
    {
        
        var url = Path.Combine("/subjects/" + _cryptoServices.Encrypt((idspecialized).ToString()).Replace("/", "I0H") + $"?{_cryptoServices.Encrypt((maxlevel).ToString()).Replace("/", "I0H") + "LDN01" + _cryptoServices.Encrypt((IdCoSo).ToString()).Replace("/", "I0H")}");
        NavigationManager.NavigateTo(url);
    }
    private void RedirectToCreat()
    {
        var url = Path.Combine("/createresourcelink/" + _cryptoServices.Encrypt((idspecialized).ToString()).Replace("/", "I0H") + "/" + _cryptoServices.Encrypt((idsubject).ToString()).Replace("/", "I0H") + "/" + _cryptoServices.Encrypt((idlesson).ToString()).Replace("/", "I0H") + $"?{_cryptoServices.Encrypt((maxlevel).ToString()).Replace("/", "I0H") + "LDN01" + _cryptoServices.Encrypt((IdCoSo).ToString()).Replace("/", "I0H")}");
        NavigationManager.NavigateTo(url);
    }
    private async Task SelectedPage(int page)
    {
        _parameters.PageNumber = page;
        Check = false;
        await GetTasks();
    }

    public async Task OnDelete(Guid id)
    {
        _idResourceLink = id.ToString();
        DeleteConfirmation.show();
    }
    public async Task OnConfirmationDelete(bool deleteconfirmed)
    {

        stt = 0;
        if (deleteconfirmed && _idResourceLink == null && _removeListResourcelink.Count == 0)
        {
            _toastService.ShowError("Bạn chưa chọn đối tượng để đổi trạng thái");
            await GetTasks();
            //NavigationManager.NavigateTo($"/lesson/{idspec}/{idsubject}");
        }
        else if (deleteconfirmed && _idResourceLink != null)
        {
            var result = await _iResourcelinkClient.Delete(Guid.Parse(_idResourceLink));
            if (result == 1)
            {
                _toastService.ShowSuccess("Đổi trạng thái thành công");
                await GetTasks();
                var url = Path.Combine("/resourcelink/" + _cryptoServices.Encrypt((idspecialized).ToString()).Replace("/", "I0H") + "/" + _cryptoServices.Encrypt((idsubject).ToString()).Replace("/", "I0H"), _cryptoServices.Encrypt((idlesson).ToString()).Replace("/", "I0H") + $"?{_cryptoServices.Encrypt((maxlevel).ToString()).Replace("/", "I0H") + "LDN01" + _cryptoServices.Encrypt((IdCoSo).ToString()).Replace("/", "I0H")}");

                NavigationManager.NavigateTo(url);
            }
            else
            {
                _toastService.ShowError("Đổi trạng thái thất bại");
                await GetTasks();
                var url = Path.Combine("/resourcelink/" + _cryptoServices.Encrypt((idspecialized).ToString()).Replace("/", "I0H") + "/" + _cryptoServices.Encrypt((idsubject).ToString()).Replace("/", "I0H"), _cryptoServices.Encrypt((idlesson).ToString()).Replace("/", "I0H") + $"?{_cryptoServices.Encrypt((maxlevel).ToString()).Replace("/", "I0H") + "LDN01" + _cryptoServices.Encrypt((IdCoSo).ToString()).Replace("/", "I0H")}");

                NavigationManager.NavigateTo(url);
            }
        }
        else if (deleteconfirmed && _removeListResourcelink != null)
        {

            var result = await _iResourcelinkClient.RemoveListResource(_removeListResourcelink);
            if (result)
            {
                _toastService.ShowSuccess("Đổi trạng thái thành công");
                await GetTasks();
                var url = Path.Combine("/resourcelink/" + _cryptoServices.Encrypt((idspecialized).ToString()).Replace("/", "I0H") + "/" + _cryptoServices.Encrypt((idsubject).ToString()).Replace("/", "I0H"), _cryptoServices.Encrypt((idlesson).ToString()).Replace("/", "I0H") + $"?{_cryptoServices.Encrypt((maxlevel).ToString()).Replace("/", "I0H") + "LDN01" + _cryptoServices.Encrypt((IdCoSo).ToString()).Replace("/", "I0H")}");

                NavigationManager.NavigateTo(url);
            }
            else
            {
                _toastService.ShowError("Đổi trạng thái thất bại");

                await GetTasks();
                var url = Path.Combine("/resourcelink/", _cryptoServices.Encrypt((idspecialized).ToString()).Replace("/", "I0H") + "/" + _cryptoServices.Encrypt((idsubject).ToString()).Replace("/", "I0H"), _cryptoServices.Encrypt((idlesson).ToString()).Replace("/", "I0H"));
                NavigationManager.NavigateTo(url);
            }
        }
        _idResourceLink = null;
        _removeListResourcelink = null;
        Check = false;
    }
    public void DeleteLesson(Guid id)
    {
        _idResourceLink = id.ToString();
        DeleteConfirmation.show();
    }
    void CheckManual(Guid reportId, bool check)
    {
        stt = 0;
        if (check == true)
        {
            foreach (var x in ListRourceLink.Where(c => c.Id == reportId))
            {
                x.IsChecked = false;
            }
        }
        if (check == false)
        {
            foreach (var x in ListRourceLink.Where(c => c.Id == reportId))
            {
                x.IsChecked = true;
            }
        }
    }
    void DeleteAll()
    {
        stt = 0;
        _removeListResourcelink = ListRourceLink.Where(c => c.IsChecked == true).Select(c => c.Id).ToList();
        DeleteConfirmation.show();
    }
    void CheckAllExpense(object checkValue)
    {
        stt = 0;
        if (Convert.ToBoolean(checkValue) == false)
        {
            ListRourceLink.ToList().ForEach(e => e.IsChecked = false);
        }
        else
        {
            ListRourceLink.ToList().ForEach(e => e.IsChecked = true);
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
