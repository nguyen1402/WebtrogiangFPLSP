#pragma checksum "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializedCPPages\SpecializedCPList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d274cbd76fabc292a28874ae4a36fdd13b918ee8"
// <auto-generated/>
#pragma warning disable 1591
namespace FPLSP.Pages.SpecializedCPPages
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
#line 2 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializedCPPages\SpecializedCPList.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializedCPPages\SpecializedCPList.razor"
using FPLSP.Data.Securities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializedCPPages\SpecializedCPList.razor"
using FPLSP.Repositories.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializedCPPages\SpecializedCPList.razor"
using FPLSP.Server.Data.SeedWork;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializedCPPages\SpecializedCPList.razor"
using FPLSP.Server.Domain.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializedCPPages\SpecializedCPList.razor"
using FPLSP.Server.Infrastructure.ViewModels.Specialized;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializedCPPages\SpecializedCPList.razor"
           [Authorize(Roles = "AdminCore,AdminCS")]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/SpecializedCP/{maxlevelNonDecrpyt}/{IdCoSoNonDecrpyt}")]
    public partial class SpecializedCPList : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"row\"><h3>CHUY??N NG??NH</h3></div>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row pt-3");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-md-5 float-end");
            __builder.OpenElement(5, "a");
            __builder.AddAttribute(6, "class", "btn btn-outline-primary");
            __builder.AddAttribute(7, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializedCPPages\SpecializedCPList.razor"
                                                     RedirectToManage

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(8, "Qu???n l?? Chuy??n Ng??nh");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "col-md-5 text-right");
            __builder.OpenComponent<global::FPLSP.Pages.SpecializedCPPages.SpecializedCPListSearch>(12);
            __builder.AddAttribute(13, "OnSearch", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::FPLSP.Server.Infrastructure.ViewModels.Specialized.SpecializedListSearch>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::FPLSP.Server.Infrastructure.ViewModels.Specialized.SpecializedListSearch>(this, 
#nullable restore
#line 18 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializedCPPages\SpecializedCPList.razor"
                                           SearchSpecializedCP

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 31 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializedCPPages\SpecializedCPList.razor"
 if (_lstSpecializedCP == null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<global::FPLSP.Components.LoadingIndicator>(14);
            __builder.CloseComponent();
#nullable restore
#line 34 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializedCPPages\SpecializedCPList.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "row pt-3");
#nullable restore
#line 38 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializedCPPages\SpecializedCPList.razor"
         if (_lstSpecializedCP.Count == 0)
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(17, "<span>Danh s??ch chuy??n ng??nh r???ng</span>");
#nullable restore
#line 41 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializedCPPages\SpecializedCPList.razor"
        }
        else
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializedCPPages\SpecializedCPList.razor"
             foreach (var item in _lstSpecializedCP)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "col-3");
            __builder.AddAttribute(20, "style", "padding: 10px;");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "card text-bg-dark");
            __builder.AddAttribute(23, "style", "border-top-right-radius: 30px");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "style", "width:290px;");
            __builder.OpenElement(26, "p");
            __builder.AddAttribute(27, "style", "background-color: #ffe3e0;color: #e92727;margin: 0;padding: 10px 15px;font-weight: 650;font-size: 15px;border-top-right-radius: 30px");
            __builder.AddMarkupContent(28, "<i class=\"fa-solid fa-graduation-cap\"></i> ");
            __builder.OpenElement(29, "b");
#nullable restore
#line (49,220)-(49,240) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializedCPPages\SpecializedCPList.razor"
__builder.AddContent(30, item.SpecializedCode);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddContent(31, " - ");
#nullable restore
#line (49,248)-(49,281) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializedCPPages\SpecializedCPList.razor"
__builder.AddContent(32, item.SpecializationName.ToUpper());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                        ");
            __builder.OpenElement(34, "img");
            __builder.AddAttribute(35, "src", 
#nullable restore
#line 51 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializedCPPages\SpecializedCPList.razor"
                                   item.Image

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(36, "onerror", "this.src=\'./css/images/Others/logoFPT.png\'");
            __builder.AddAttribute(37, "style", "height:160px;object-fit:contain");
            __builder.AddAttribute(38, "class", "card-img");
            __builder.AddAttribute(39, "alt", "...");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                        ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "card-img-overlay d-flex align-items-end p-0");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "row");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "col-8 dropup-center dropup");
            __builder.OpenElement(47, "button");
            __builder.AddAttribute(48, "class", "btn btn-danger dropdown-toggle");
            __builder.AddAttribute(49, "style", "border-top-right-radius: 30px; font-size: smaller;width: 165px;background-color: #ec5528;color: #f5f5f5;");
            __builder.AddAttribute(50, "type", "button");
            __builder.AddAttribute(51, "data-bs-toggle", "dropdown");
            __builder.AddAttribute(52, "aria-expanded", "false");
#nullable restore
#line (56,42)-(56,65) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializedCPPages\SpecializedCPList.razor"
__builder.AddContent(53, item.SpecializationName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                                    ");
            __builder.OpenElement(55, "ul");
            __builder.AddAttribute(56, "class", "dropdown-menu");
#nullable restore
#line 62 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializedCPPages\SpecializedCPList.razor"
                                         if (_lstAll.Where(x => x.IdSpeciality == item.Id).Count() > 0)
                                        {
                                            foreach (var x in _lstAll.Where(x => x.IdSpeciality == item.Id))
                                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(57, "li");
            __builder.OpenElement(58, "a");
            __builder.AddAttribute(59, "class", "dropdown-item");
            __builder.AddAttribute(60, "style", "font-size:small;");
            __builder.AddAttribute(61, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 66 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializedCPPages\SpecializedCPList.razor"
                                                                                                                  () => { NavigateToSubjectCP(_cryptoServices.Encrypt((x.Id.ToString()))); }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(62, "<i class=\"fa-solid fa-graduation-cap\"></i> ");
#nullable restore
#line (66,236)-(66,256) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializedCPPages\SpecializedCPList.razor"
__builder.AddContent(63, x.SpecializationName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 67 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializedCPPages\SpecializedCPList.razor"
                                            }
                                        }
                                        else
                                        {
                                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 78 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializedCPPages\SpecializedCPList.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 78 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializedCPPages\SpecializedCPList.razor"
             
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n    ");
            __builder.OpenElement(65, "div");
            __builder.AddAttribute(66, "class", "footer text-muted");
            __builder.OpenElement(67, "div");
            __builder.AddAttribute(68, "class", "row mt-3");
            __builder.OpenElement(69, "span");
            __builder.OpenComponent<global::FPLSP.Components.Pagingation>(70);
            __builder.AddAttribute(71, "MetaData", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::FPLSP.Server.Data.SeedWork.MetaData>(
#nullable restore
#line 85 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializedCPPages\SpecializedCPList.razor"
                                       MetaData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(72, "Spread", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 85 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializedCPPages\SpecializedCPList.razor"
                                                         2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(73, "SelectedPage", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.Int32>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.Int32>(this, 
#nullable restore
#line 85 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializedCPPages\SpecializedCPList.razor"
                                                                          SelectedPage

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 90 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializedCPPages\SpecializedCPList.razor"
}

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<global::FPLSP.Components.Comfirmation>(74);
            __builder.AddAttribute(75, "ConfirmationMessage", "B???n c?? ch???c mu???n x??a chuy??n ng??nh kh??ng?");
            __builder.AddAttribute(76, "ConfirmationTitle", "X??a");
            __builder.AddAttribute(77, "ConfirmationChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.Boolean>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.Boolean>(this, 
#nullable restore
#line 94 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializedCPPages\SpecializedCPList.razor"
                                   OnConfirmationDelete

#line default
#line hidden
#nullable disable
            )));
            __builder.AddComponentReferenceCapture(78, (__value) => {
#nullable restore
#line 93 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializedCPPages\SpecializedCPList.razor"
                    DeleteConfirmation = (FPLSP.Components.Comfirmation)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 96 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializedCPPages\SpecializedCPList.razor"
       
    [Inject]
    public ISpecializedCPRepo _specializedCPRepo { get; set; }
    private List<SpecializedDto> _lstSpecializedCP = new List<SpecializedDto>();
    private List<SpecializedDto> _lstAll = new List<SpecializedDto>();
    [Inject] public IDashboardClient dashboardClient { get; set; }
    [Parameter]
    public string maxlevelNonDecrpyt { get; set; }
    [Parameter]
    public string IdCoSoNonDecrpyt { get; set; }

    
    private List<Guid> _removeSpecializedCP = new List<Guid>();
    [Inject]
    public CryptoServices _cryptoServices { get; set; }
    [Inject]
    public NavigationManager NavigationManager { get; set; }

    [CascadingParameter]
    private Error _error { get; set; }
    public MetaData MetaData { get; set; } = new MetaData();
    public SpecializedListSearch _specializedListSearch { get; set; } = new SpecializedListSearch();
    protected Comfirmation DeleteConfirmation { get; set; }
    private string deleteID { get; set; }
    [Inject]
    public IToastService ToastService { get; set; }
    private bool Check = false;

    string maxlevel = "";
    string IdCoSo = "";
    protected override async Task OnInitializedAsync()
    {
        maxlevel = _cryptoServices.Decrypt(maxlevelNonDecrpyt.Replace("I0H", "/"));
        IdCoSo = _cryptoServices.Decrypt(IdCoSoNonDecrpyt.Replace("I0H", "/"));
        _lstAll = await _specializedCPRepo.GetAll();
        _lstAll = _lstAll.Where(x => x.Level != 0 && x.Status == 0).ToList();
        await GetSpecializedCPList();
    }
    private async Task SelectedPage(int page)
    {
        _specializedListSearch.PageNumber = page;
        Check = false;
        await GetSpecializedCPList();
    }
    public async Task SearchSpecializedCP(SpecializedListSearch search)
    {
        _specializedListSearch = search;
        await GetSpecializedCPList();
    }
    private async Task GetSpecializedCPList()
    {
        try
        {

            if (maxlevel == "6")
            {
                var pagingResponse = await dashboardClient.GetAllSpecByIdTran(Guid.Parse(IdCoSo), _specializedListSearch);
                _lstSpecializedCP = pagingResponse.Items;
                _lstSpecializedCP = _lstSpecializedCP.OrderBy(x => x.SpecializedCode).ToList();
                MetaData = pagingResponse.MetaData;
            }
            else
            {
                var pagingResponse = await _specializedCPRepo.Gets(Guid.Empty, _specializedListSearch);
                _lstSpecializedCP = pagingResponse.Items;
                _lstSpecializedCP = _lstSpecializedCP.OrderBy(x => x.SpecializedCode).ToList();
                MetaData = pagingResponse.MetaData;

            }

        }
        catch (Exception ex)
        {

            _error.ProcessError(ex);
        }
    }
    public void OnDelete(Guid id)
    {
        deleteID = id.ToString();
        DeleteConfirmation.show();
    }

    public async Task OnConfirmDelete(bool deleteConfirmed)
    {
        if (deleteConfirmed)
        {
            var result = await _specializedCPRepo.Delete(Guid.Empty, Guid.Parse(deleteID));
            if (result == 1)
            {
                ToastService.ShowSuccess("?????i tr???ng th??i chuy??n ng??nh th??nh c??ng", "Success");
                await GetSpecializedCPList();
            }
            else
            {
                ToastService.ShowError("?????i tr???ng th??i chuy??n ng??nh th???t b???i", "Error");
            }
        }
    }

    void CheckManual(Guid reportId, bool check)
    {
        if (check == true)
        {
            foreach (var x in _lstSpecializedCP.Where(c => c.Id == reportId))
            {
                x.IsChecked = false;
            }
        }
        if (check == false)
        {
            foreach (var x in _lstSpecializedCP.Where(c => c.Id == reportId))
            {
                x.IsChecked = true;
            }
        }
    }
    void DeleteAll()
    {
        _removeSpecializedCP = _lstSpecializedCP.Where(c => c.IsChecked == true).Select(c => c.Id).ToList();
        DeleteConfirmation.show();
    }
    void CheckAllExpense(object checkValue)
    {
        if (Convert.ToBoolean(checkValue) == false)
        {
            _lstSpecializedCP.ToList().ForEach(e => e.IsChecked = false);
        }
        else
        {
            _lstSpecializedCP.ToList().ForEach(e => e.IsChecked = true);
        }
    }
    public async Task OnConfirmationDelete(bool deleteconfirmed)
    {
        if (deleteconfirmed && deleteID == null && _removeSpecializedCP.Count == 0)
        {
            ToastService.ShowError("B???n ch??a ch???n ?????i t?????ng ????? x??a");
            await GetSpecializedCPList();
            NavigationManager.NavigateTo($"/SpecializedCP/{_cryptoServices.Encrypt((maxlevel).ToString()).Replace("/", "I0H" )}/{_cryptoServices.Encrypt((IdCoSo).ToString()).Replace("/", "I0H" )}");
        }
        else if (deleteconfirmed && deleteID != null)
        {
            var result = await _specializedCPRepo.Delete(Guid.Empty, Guid.Parse(deleteID));
            if (result == 1)
            {
                ToastService.ShowSuccess("X??a th??nh c??ng");
                deleteID = null;
                await GetSpecializedCPList();
                NavigationManager.NavigateTo($"/SpecializedCP/{_cryptoServices.Encrypt((maxlevel).ToString()).Replace("/", "I0H")}/{_cryptoServices.Encrypt((IdCoSo).ToString()).Replace("/", "I0H")}");
            }
            else
            {
                ToastService.ShowError("X??a th???t b???i");
                deleteID = null;
                await GetSpecializedCPList();
                NavigationManager.NavigateTo($"/SpecializedCP/{_cryptoServices.Encrypt((maxlevel).ToString()).Replace("/", "I0H")}/{_cryptoServices.Encrypt((IdCoSo).ToString()).Replace("/", "I0H")}");
            }
        }
        else if (deleteconfirmed && _removeSpecializedCP != null)
        {

            //var result = await _specializedCPRepo.RemoveSpecializedCP(_removeSpecializedCP);
            //if (result)
            //{
            //    ToastService.ShowSuccess("X??a th??nh c??ng");
            //    deleteID = null;
            //    _removeSpecializedCP = null;
            //    await GetSpecializedCPList();
            //    NavigationManager.NavigateTo($"/SpecializedCP");
            //}
            //else
            //{
            //    ToastService.ShowError("X??a th???t b???i");
            //    deleteID = null;
            //    _removeSpecializedCP = null;
            //    await GetSpecializedCPList();
            //    NavigationManager.NavigateTo($"/SpecializedCP");
            //}
        }
        else
        {
            deleteID = null;
            _removeSpecializedCP = null;
        }
        Check = false;
    }

    private void RedirectToCreate()
    {
        NavigationManager.NavigateTo($"/createSpecializedCP?{_cryptoServices.Encrypt((maxlevel).ToString()).Replace("/", "I0H") + "LDN01" + _cryptoServices.Encrypt((IdCoSo).ToString()).Replace("/", "I0H")}");
    }
    private void NavigateToUpdate(Guid id)
    {
        NavigationManager.NavigateTo($"/updateSpecializedCP/{id}?{_cryptoServices.Encrypt((maxlevel).ToString()).Replace("/", "I0H") + "LDN01" + _cryptoServices.Encrypt((IdCoSo).ToString()).Replace("/", "I0H")}");
    }
    private void RedirectToManage()
    {
        NavigationManager.NavigateTo($"/manageSpecializedCP?{_cryptoServices.Encrypt((maxlevel).ToString()).Replace("/", "I0H") + "LDN01" + _cryptoServices.Encrypt((IdCoSo).ToString()).Replace("/", "I0H")}");
    }
    private void NavigateToSubjectCP(string id)
    {
        var a = id.Replace("/", "I0H");
        NavigationManager.NavigateTo($"/subjects/{a}?{_cryptoServices.Encrypt((maxlevel).ToString()).Replace("/", "I0H") + "LDN01" + _cryptoServices.Encrypt((IdCoSo).ToString()).Replace("/", "I0H")}");
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
