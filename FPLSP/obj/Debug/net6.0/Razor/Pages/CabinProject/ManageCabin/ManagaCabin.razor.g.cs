#pragma checksum "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\ManageCabin\ManagaCabin.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "58db64ff08fc9529ed13ea2439ed80a1a0e6e25e"
// <auto-generated/>
#pragma warning disable 1591
namespace FPLSP.Pages.CabinProject.ManageCabin
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
#line 2 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\ManageCabin\ManagaCabin.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\ManageCabin\ManagaCabin.razor"
using FPLSP.Data.Securities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\ManageCabin\ManagaCabin.razor"
using FPLSP.Repositories.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\ManageCabin\ManagaCabin.razor"
using FPLSP.Repositories.Interfaces.CabinProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\ManageCabin\ManagaCabin.razor"
using FPLSP.Server.Data.SeedWork;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\ManageCabin\ManagaCabin.razor"
using FPLSP.Server.Infrastructure.ViewModels.CabinProject.BookingRequest;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\ManageCabin\ManagaCabin.razor"
using FPLSP.Server.Infrastructure.ViewModels.CabinProject.Cabin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\ManageCabin\ManagaCabin.razor"
           [Authorize(Roles = "DirectorOfTraining")]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/managecabin/{IdTrain}")]
    public partial class ManagaCabin : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 b-7q6p7yjqkx>Qu???n l?? Cabin</h3>");
#nullable restore
#line 13 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\ManageCabin\ManagaCabin.razor"
 if (lstcabinViewModel == null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<global::FPLSP.Components.LoadingIndicator>(1);
            __builder.CloseComponent();
#nullable restore
#line 16 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\ManageCabin\ManagaCabin.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.AddAttribute(4, "b-7q6p7yjqkx");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-lg-9");
            __builder.AddAttribute(7, "b-7q6p7yjqkx");
            __builder.OpenComponent<global::FPLSP.Pages.CabinProject.ManageCabin.ManageCabinSearch>(8);
            __builder.AddAttribute(9, "OnSearch", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::FPLSP.Server.Infrastructure.ViewModels.CabinProject.Cabin.CabinSearchViewModel>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::FPLSP.Server.Infrastructure.ViewModels.CabinProject.Cabin.CabinSearchViewModel>(this, 
#nullable restore
#line 21 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\ManageCabin\ManagaCabin.razor"
                                         SearchCabin

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(10, "\r\n            <div class=\"pl-16\" b-7q6p7yjqkx></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n        ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "col-lg-3");
            __builder.AddAttribute(14, "b-7q6p7yjqkx");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "pl-13 d-flex justify-content-end mr-6 ");
            __builder.AddAttribute(17, "b-7q6p7yjqkx");
            __builder.OpenElement(18, "a");
            __builder.AddAttribute(19, "type", "button");
            __builder.AddAttribute(20, "class", "btn btn-primary");
            __builder.AddAttribute(21, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\ManageCabin\ManagaCabin.razor"
                                                                   ()=> OpenDialog()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "b-7q6p7yjqkx");
            __builder.AddMarkupContent(23, "<i class=\"fa-solid fa-plus\" b-7q6p7yjqkx></i> Th??m");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n    ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "row mt-4");
            __builder.AddAttribute(27, "b-7q6p7yjqkx");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "table-responsive ");
            __builder.AddAttribute(30, "b-7q6p7yjqkx");
            __builder.OpenElement(31, "table");
            __builder.AddAttribute(32, "class", "table table-light table-bordered");
            __builder.AddAttribute(33, "b-7q6p7yjqkx");
            __builder.AddMarkupContent(34, @"<thead b-7q6p7yjqkx><tr b-7q6p7yjqkx><th width=""17%"" b-7q6p7yjqkx>
                            T??n Cabin
                        </th>
                        <th width=""17%"" b-7q6p7yjqkx>
                            T??a
                        </th>
                        <th width=""4%"" b-7q6p7yjqkx>Ng??y t???o</th>
                        <th width=""2%"" b-7q6p7yjqkx>
                            Tr???ng th??i
                        </th>
                        <th width=""1%"" b-7q6p7yjqkx>T??nh n??ng</th></tr></thead>
                ");
            __builder.OpenElement(35, "tbody");
            __builder.AddAttribute(36, "b-7q6p7yjqkx");
#nullable restore
#line 51 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\ManageCabin\ManagaCabin.razor"
                     foreach (var item in lstcabinViewModel)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(37, "tr");
            __builder.AddAttribute(38, "b-7q6p7yjqkx");
            __builder.OpenElement(39, "td");
            __builder.AddAttribute(40, "b-7q6p7yjqkx");
#nullable restore
#line (55,34)-(55,48) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\ManageCabin\ManagaCabin.razor"
__builder.AddContent(41, item.CabinName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                            ");
            __builder.OpenElement(43, "td");
            __builder.AddAttribute(44, "b-7q6p7yjqkx");
#nullable restore
#line (58,34)-(58,51) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\ManageCabin\ManagaCabin.razor"
__builder.AddContent(45, item.BuildingName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                            ");
            __builder.OpenElement(47, "td");
            __builder.AddAttribute(48, "b-7q6p7yjqkx");
#nullable restore
#line (61,34)-(61,72) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\ManageCabin\ManagaCabin.razor"
__builder.AddContent(49, item.CreateTime.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n\r\n                            ");
            __builder.OpenElement(51, "td");
            __builder.AddAttribute(52, "b-7q6p7yjqkx");
#nullable restore
#line 66 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\ManageCabin\ManagaCabin.razor"
                                 if (item.Checked == (bool)true)
                                {


#line default
#line hidden
#nullable disable
            __builder.OpenElement(53, "label");
            __builder.AddAttribute(54, "class", "toggle toggle-alternative");
            __builder.AddAttribute(55, "b-7q6p7yjqkx");
            __builder.OpenElement(56, "input");
            __builder.AddAttribute(57, "type", "checkbox");
            __builder.AddAttribute(58, "id", "checkboxB");
            __builder.AddAttribute(59, "class", "checkbox");
            __builder.AddAttribute(60, "checked", "checked");
            __builder.AddAttribute(61, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 70 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\ManageCabin\ManagaCabin.razor"
                                                                                                                           ()=> ChangeStatus(item.Id,true)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(62, "b-7q6p7yjqkx");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n                                        <span class=\"toggle-text\" b-7q6p7yjqkx></span>\r\n                                        <span class=\"toggle-handle\" b-7q6p7yjqkx></span>");
            __builder.CloseElement();
#nullable restore
#line 74 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\ManageCabin\ManagaCabin.razor"

                                }
                                else
                                {


#line default
#line hidden
#nullable disable
            __builder.OpenElement(64, "label");
            __builder.AddAttribute(65, "class", "toggle toggle-alternative");
            __builder.AddAttribute(66, "b-7q6p7yjqkx");
            __builder.OpenElement(67, "input");
            __builder.AddAttribute(68, "type", "checkbox");
            __builder.AddAttribute(69, "id", "checkboxB");
            __builder.AddAttribute(70, "class", "checkbox");
            __builder.AddAttribute(71, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 80 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\ManageCabin\ManagaCabin.razor"
                                                                                                         ()=> ChangeStatus(item.Id,false)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(72, "b-7q6p7yjqkx");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n                                        <span class=\"toggle-text\" b-7q6p7yjqkx></span>\r\n                                        <span class=\"toggle-handle\" b-7q6p7yjqkx></span>");
            __builder.CloseElement();
#nullable restore
#line 84 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\ManageCabin\ManagaCabin.razor"

                                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n                            ");
            __builder.OpenElement(75, "td");
            __builder.AddAttribute(76, "b-7q6p7yjqkx");
            __builder.OpenElement(77, "div");
            __builder.AddAttribute(78, "class", "d-flex justify-content-center mb-2");
            __builder.AddAttribute(79, "b-7q6p7yjqkx");
            __builder.OpenElement(80, "div");
            __builder.AddAttribute(81, "class", "pr-1");
            __builder.AddAttribute(82, "b-7q6p7yjqkx");
            __builder.OpenElement(83, "a");
            __builder.AddAttribute(84, "class", "btn btn-primary ");
            __builder.AddAttribute(85, "type", "button");
            __builder.AddAttribute(86, "title", "S???a");
            __builder.AddAttribute(87, "href", "/managecabin/update/" + (
#nullable restore
#line 91 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\ManageCabin\ManagaCabin.razor"
                                                                                                                         cryptoServices.Encrypt(item.Id.ToString()).Replace("/","cabin")

#line default
#line hidden
#nullable disable
            ) + "/" + (
#nullable restore
#line 91 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\ManageCabin\ManagaCabin.razor"
                                                                                                                                                                                          cryptoServices.Encrypt(IdTrain.ToString()).Replace("/","cabin")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(88, "id", "show-emp");
            __builder.AddAttribute(89, "b-7q6p7yjqkx");
            __builder.AddMarkupContent(90, "<i class=\"fas fa-edit\" b-7q6p7yjqkx></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n                                    ");
            __builder.OpenElement(92, "div");
            __builder.AddAttribute(93, "class", " pl-1");
            __builder.AddAttribute(94, "b-7q6p7yjqkx");
            __builder.OpenElement(95, "a");
            __builder.AddAttribute(96, "class", "btn btn-danger ");
            __builder.AddAttribute(97, "type", "button");
            __builder.AddAttribute(98, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 96 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\ManageCabin\ManagaCabin.razor"
                                                                                           ()=> Delete(item.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(99, "title", "X??a");
            __builder.AddAttribute(100, "b-7q6p7yjqkx");
            __builder.AddMarkupContent(101, "<i class=\"fas fa-trash-alt\" b-7q6p7yjqkx></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 103 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\ManageCabin\ManagaCabin.razor"

                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n            ");
            __builder.AddMarkupContent(103, "<div class=\"d-flex justify-content-center mb-2\" b-7q6p7yjqkx><div class=\"row\" b-7q6p7yjqkx><div class=\"col-11 align-self-center\" b-7q6p7yjqkx></div></div></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n    ");
            __builder.OpenElement(105, "div");
            __builder.AddAttribute(106, "class", "d-flex justify-content-center mb-2");
            __builder.AddAttribute(107, "b-7q6p7yjqkx");
            __builder.OpenElement(108, "div");
            __builder.AddAttribute(109, "class", "row");
            __builder.AddAttribute(110, "b-7q6p7yjqkx");
            __builder.OpenElement(111, "div");
            __builder.AddAttribute(112, "class", "col-11 align-self-center");
            __builder.AddAttribute(113, "b-7q6p7yjqkx");
            __builder.OpenComponent<global::FPLSP.Components.Pagingation>(114);
            __builder.AddAttribute(115, "MetaData", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::FPLSP.Server.Data.SeedWork.MetaData>(
#nullable restore
#line 118 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\ManageCabin\ManagaCabin.razor"
                                       MetaData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(116, "Spread", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 118 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\ManageCabin\ManagaCabin.razor"
                                                         2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(117, "SelectedPage", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.Int32>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.Int32>(this, 
#nullable restore
#line 118 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\ManageCabin\ManagaCabin.razor"
                                                                          SelectedPage

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenComponent<global::FPLSP.Pages.CabinProject.ManageCabin.RemoveCabin>(118);
            __builder.AddAttribute(119, "ConfirmationMessage", "X??a Cabin ???? ???????c ch???n");
            __builder.AddAttribute(120, "ConfirmationTitle", "X??c nh???n");
            __builder.AddAttribute(121, "ConfirmationChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.Boolean>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.Boolean>(this, 
#nullable restore
#line 125 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\ManageCabin\ManagaCabin.razor"
                                   OnConfirmationDelete 

#line default
#line hidden
#nullable disable
            )));
            __builder.AddComponentReferenceCapture(122, (__value) => {
#nullable restore
#line 125 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\ManageCabin\ManagaCabin.razor"
                                                                DeleteConfirmation = (FPLSP.Pages.CabinProject.ManageCabin.RemoveCabin)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(123, "\r\n    ");
            __builder.OpenComponent<global::FPLSP.Pages.CabinProject.ManageCabin.ManageCabinAdd>(124);
            __builder.AddAttribute(125, "OnAdd", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.Boolean>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.Boolean>(this, 
#nullable restore
#line 126 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\ManageCabin\ManagaCabin.razor"
                           OnConfirmAdd

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(126, "IdTrain", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 126 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\ManageCabin\ManagaCabin.razor"
                                                   cryptoServices.Encrypt(IdTrain.ToString()).Replace("/","cabin")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddComponentReferenceCapture(127, (__value) => {
#nullable restore
#line 126 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\ManageCabin\ManagaCabin.razor"
                                                                                                                          manageCabinAdd = (FPLSP.Pages.CabinProject.ManageCabin.ManageCabinAdd)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
#nullable restore
#line 127 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\ManageCabin\ManagaCabin.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 128 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\ManageCabin\ManagaCabin.razor"
       

    [Inject] private ICabinRepo cabin { get; set; }
    [Inject] private IGroupCabinRepo groupCabinRepo { get; set; }
    [Inject] private IBookingRequestRepo _bookingRequestRepo { get; set; }
    [Inject] private IBookingCabinApiClient _bookingCabinApiClient { get; set; }
    [Inject] private ILecturersCPRepo lecturersCPRepo { get; set; }
    [Inject] IShiftOfCabinApiClient shiftOfCabinApiClient { get; set; }
    [Inject] private CryptoServices cryptoServices { get; set; }
    List<CabinViewModel> lstcabinViewModel = new List<CabinViewModel>();
    CabinSearchViewModel cabinSearchViewModel = new CabinSearchViewModel();
    public MetaData MetaData { get; set; } = new MetaData();
    protected RemoveCabin DeleteConfirmation { get; set; }
    protected ManageCabinAdd manageCabinAdd { get; set; }
    [Inject] private IToastService _toastService { get; set; }
    Guid Id;
    string nameLec { get; set; }
    [Parameter] public string IdTrain { get; set; }
    private void OpenDialog()
    {
        manageCabinAdd.show();
    }
    protected override async Task OnInitializedAsync()
    {
        IdTrain = cryptoServices.Decrypt(IdTrain.ToString());
        await GetTasks();
    }
    private async Task GetTasks()
    {
        var lstCabin = await cabin.GetCabinListSearch(cabinSearchViewModel);
        lstcabinViewModel = lstCabin.Items.Where(x => x.IdTrainingFacility == Guid.Parse(IdTrain)).OrderByDescending(x => x.IndexOfCabin).ToList();
        MetaData = lstCabin.MetaData;
        foreach (var item in lstcabinViewModel)
        {
            if (item.Status == 0)
            {
                item.Checked = true;
            }
            else if (item.Status == 2)
            {
                item.Checked = false;
            }
        }
    }
    private async Task ChangeStatus(Guid id, bool? Checked)
    {

        var changeStatusCabin = lstcabinViewModel.FirstOrDefault(x => x.Id == id);
        if (changeStatusCabin != null)
        {
            if ((bool)Checked)
            {
                CabinUpdateViewModel cabinUpdateViewModel = new CabinUpdateViewModel()
                    {
                        CabinName = changeStatusCabin.CabinName,
                        BuildingName = changeStatusCabin.BuildingName,
                        IndexOfCabin = changeStatusCabin.IndexOfCabin,
                        CreateTime = changeStatusCabin.CreateTime,
                        Status = 2

                    };
                var check = await cabin.UpdateCabin(id, cabinUpdateViewModel);
                if (check)
                {
                    _toastService.ShowSuccess("Thay ?????i tr???ng th??i th??nh c??ng");
                    await GetTasks();
                }
            }
            else
            {
                CabinUpdateViewModel cabinUpdateViewModel = new CabinUpdateViewModel()
                    {
                        CabinName = changeStatusCabin.CabinName,
                        BuildingName = changeStatusCabin.BuildingName,
                        IndexOfCabin = changeStatusCabin.IndexOfCabin,
                        CreateTime = changeStatusCabin.CreateTime,
                        Status = 0

                    };
                var check = await cabin.UpdateCabin(id, cabinUpdateViewModel);
                if (check)
                {
                    _toastService.ShowSuccess("Thay ?????i tr???ng th??i th??nh c??ng");
                    await GetTasks();
                }
            }

        }


    }
    private async Task SelectedPage(int page)
    {
        cabinSearchViewModel.PageNumber = page;
        await GetTasks();
    }
    private async Task Delete(Guid id)
    {
        Id = id;     
        await DeleteConfirmation.show(id);
    }
    private async Task OnConfirmationDelete(bool deleteconfirmed)
    {
        if (deleteconfirmed)
        {

            var check = await cabin.DeleteCabin(Id);
            var grcb = await groupCabinRepo.GetAllGroupCabinAsync();
            grcb = grcb.Where(x => x.IdCabin == Id).ToList();
            var bkcb = await _bookingCabinApiClient.GetAll();
            bkcb = bkcb.Where(x => x.IdCabin == Id).ToList();
            //var bkrq = await bookingRequestRepo.GetAllBookingRequestAsync();
            //bkrq = bkrq.Where(x => x.IdCabin == Id).ToList();
            //foreach (var item in bkrq)
            //{
            //    await bookingRequestRepo.DeleteBookingRequest(item.Id);
            //}

            foreach (var item in bkcb)
            {

                var listShiftDefault = await shiftOfCabinApiClient.GetAll();
                var shift = listShiftDefault.FirstOrDefault(c => c.Id == item.IdShift);
                var StartShift = shift.StartTime;
                var EndShift = shift.EndTime;
                await _bookingCabinApiClient.Delete(item.Id, item.IdCabin, item.SubjectId, item.ClassId, item.IdShift);
                var listBookingCabin = await _bookingCabinApiClient.GetAll();

                var obj = listBookingCabin.FirstOrDefault(c => c.Status != 1 && c.SubjectId == item.SubjectId && c.ClassId == item.ClassId && c.IdShift == item.IdShift && c.IdLectuter == item.IdLectuter && c.IdCabin == item.IdCabin && c.DateCreated == item.DateCreated);
                var resBooking = obj == null ? true : await _bookingCabinApiClient.Delete(obj.Id, Guid.Parse(item.IdCabin.ToString()), Guid.Parse(item.SubjectId.ToString()), Guid.Parse(item.ClassId.ToString()), Guid.Parse(item.IdShift.ToString()));
                var resRequest = false;

                // t???o booking request
                if (resBooking)
                {

                    var StartTimeOfBR = new DateTime(item.DateCreated.Year, item.DateCreated.Month, item.DateCreated.Day, StartShift.Hours, StartShift.Minutes, StartShift.Seconds);
                    var EndTimeOfBR = new DateTime(item.DateCreated.Year, item.DateCreated.Month, item.DateCreated.Day, EndShift.Hours, EndShift.Minutes, EndShift.Seconds);

                    var booking = new BookingRequestCreateViewModel
                        {
                            ContentOfRequest = "???? b??? h???y cabin",
                            IdLectuter = Guid.Parse(item.IdLectuter.ToString()),
                            SendingTime = DateTime.Now,
                            SubjectId = Guid.Parse(item.SubjectId.ToString()),
                            ClassId = Guid.Parse(item.ClassId.ToString()),
                            Status = 5,
                            ContenOfFeedBack = "H???y cabin v??: Cabin d???ng ho???t ?????ng",
                            StartTime = StartTimeOfBR,
                            FeedBackTime = DateTime.Now,
                            EndTime = EndTimeOfBR
                        };

                    var listBookingRequest = await _bookingRequestRepo.GetAllBookingRequestAsync();

                    if (listBookingRequest.Any(c => c.IdLectuter == Guid.Parse(item.IdLectuter.ToString()) &&
                        c.SubjectId == Guid.Parse(item.SubjectId.ToString()) &&
                    c.ClassId == Guid.Parse(item.ClassId.ToString()) &&
                    c.StartTime == StartTimeOfBR &&
                    c.EndTime == EndTimeOfBR
                    ))
                    {
                        booking.Status = 3;
                    }
                    resRequest = await _bookingRequestRepo.CreateBookingRequest(booking);
                }

            }
       
            foreach (var item in grcb)
            {
                await groupCabinRepo.DeleteGroupCabin(item.IdSpec, item.IdCabin);
            }

            if (check)
            {
                _toastService.ShowSuccess("X??a th??nh c??ng");
                await GetTasks();
            }
            else
            {
                _toastService.ShowError("X??a th???t b???i");
            }
        }

    }
    private async Task OnConfirmAdd(bool check)
    {
        if (check)
        {
            await GetTasks();
        }


    }
    public async Task SearchCabin(CabinSearchViewModel cabinViewModel)
    {
        cabinSearchViewModel = cabinViewModel;
        await GetTasks();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDialogService DialogService { get; set; }
    }
}
#pragma warning restore 1591
