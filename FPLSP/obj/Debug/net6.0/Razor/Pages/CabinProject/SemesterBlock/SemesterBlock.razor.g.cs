#pragma checksum "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\SemesterBlock\SemesterBlock.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "10342c5816748c10249355f5b52740a3066c1b7f"
// <auto-generated/>
#pragma warning disable 1591
namespace FPLSP.Pages.CabinProject.SemesterBlock
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
#line 2 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\SemesterBlock\SemesterBlock.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\SemesterBlock\SemesterBlock.razor"
using FPLSP.Data.Securities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\SemesterBlock\SemesterBlock.razor"
using FPLSP.Server.Infrastructure.ViewModels.CabinProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\SemesterBlock\SemesterBlock.razor"
using FPLSP.Repositories.Interfaces.CabinProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\SemesterBlock\SemesterBlock.razor"
using FPLSP.Server.Data.SeedWork;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\SemesterBlock\SemesterBlock.razor"
using FPLSP.Server.Domain.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\SemesterBlock\SemesterBlock.razor"
           [Authorize(Roles = "DirectorOfTraining")]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/semesterblock")]
    public partial class SemesterBlock : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 b-1ph58kkn21>Qu???n L?? Block, K?? H???c</h3>");
#nullable restore
#line 11 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\SemesterBlock\SemesterBlock.razor"
 if (lstblock == null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<global::FPLSP.Components.LoadingIndicator>(1);
            __builder.CloseComponent();
#nullable restore
#line 14 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\SemesterBlock\SemesterBlock.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.AddAttribute(4, "b-1ph58kkn21");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-lg-10");
            __builder.AddAttribute(7, "b-1ph58kkn21");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "pl");
            __builder.AddAttribute(10, "b-1ph58kkn21");
            __builder.OpenComponent<global::FPLSP.Pages.CabinProject.SemesterBlock.SemesterBlockComponents>(11);
            __builder.AddAttribute(12, "OnSearch", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::FPLSP.Server.Infrastructure.ViewModels.CabinProject.SemesterBlockSearch>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::FPLSP.Server.Infrastructure.ViewModels.CabinProject.SemesterBlockSearch>(this, 
#nullable restore
#line 20 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\SemesterBlock\SemesterBlock.razor"
                                                   SearchSemester

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n        ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "col-lg-2");
            __builder.AddAttribute(16, "b-1ph58kkn21");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "pl-13 d-flex justify-content-end mr-6");
            __builder.AddAttribute(19, "b-1ph58kkn21");
            __builder.OpenElement(20, "a");
            __builder.AddAttribute(21, "type", "button");
            __builder.AddAttribute(22, "class", "btn btn-primary ");
            __builder.AddAttribute(23, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\SemesterBlock\SemesterBlock.razor"
                                                                    ()=> OpenDialog()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "b-1ph58kkn21");
            __builder.AddMarkupContent(25, "<i class=\"fa-solid fa-plus\" b-1ph58kkn21></i> Th??m");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n    ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "row mt-4");
            __builder.AddAttribute(29, "b-1ph58kkn21");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "table-responsive ");
            __builder.AddAttribute(32, "b-1ph58kkn21");
            __builder.OpenElement(33, "table");
            __builder.AddAttribute(34, "class", "table table-light table-bordered");
            __builder.AddAttribute(35, "b-1ph58kkn21");
            __builder.AddMarkupContent(36, @"<thead b-1ph58kkn21><tr b-1ph58kkn21><th width=""10%"" b-1ph58kkn21>
                            K??
                        </th>
                        <th width=""10%"" b-1ph58kkn21>
                            Block
                        </th>
                        <th width=""10%"" b-1ph58kkn21>Ng??y b???t ?????u</th>
                        <th width=""10%"" b-1ph58kkn21>
                            Ng??y k???t th??c
                        </th>
                        <th width=""2%"" b-1ph58kkn21>
                            Tr???ng th??i
                        </th>
                        <th width=""1%"" b-1ph58kkn21>T??nh n??ng</th></tr></thead>
                ");
            __builder.OpenElement(37, "tbody");
            __builder.AddAttribute(38, "b-1ph58kkn21");
#nullable restore
#line 59 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\SemesterBlock\SemesterBlock.razor"
                     foreach (var item in semesterBlock)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\SemesterBlock\SemesterBlock.razor"
                         if (item.Status != 1)
                        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(39, "tr");
            __builder.AddAttribute(40, "b-1ph58kkn21");
            __builder.OpenElement(41, "td");
            __builder.AddAttribute(42, "b-1ph58kkn21");
#nullable restore
#line (65,38)-(65,57) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\SemesterBlock\SemesterBlock.razor"
__builder.AddContent(43, item.NameofSemester);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n                                ");
            __builder.OpenElement(45, "td");
            __builder.AddAttribute(46, "b-1ph58kkn21");
#nullable restore
#line (66,38)-(66,54) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\SemesterBlock\SemesterBlock.razor"
__builder.AddContent(47, item.NameofBlock);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                                ");
            __builder.OpenElement(49, "td");
            __builder.AddAttribute(50, "b-1ph58kkn21");
#nullable restore
#line (67,38)-(67,75) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\SemesterBlock\SemesterBlock.razor"
__builder.AddContent(51, item.StartTime.ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n                                ");
            __builder.OpenElement(53, "td");
            __builder.AddAttribute(54, "b-1ph58kkn21");
#nullable restore
#line (68,38)-(68,73) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\SemesterBlock\SemesterBlock.razor"
__builder.AddContent(55, item.EndTime.ToString("dd-MM-yyyy"));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n                                ");
            __builder.OpenElement(57, "td");
            __builder.AddAttribute(58, "b-1ph58kkn21");
#nullable restore
#line 70 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\SemesterBlock\SemesterBlock.razor"
                                     if (item.Checked == (bool)true)
                                {


#line default
#line hidden
#nullable disable
            __builder.OpenElement(59, "label");
            __builder.AddAttribute(60, "class", "toggle toggle-alternative");
            __builder.AddAttribute(61, "b-1ph58kkn21");
            __builder.OpenElement(62, "input");
            __builder.AddAttribute(63, "type", "checkbox");
            __builder.AddAttribute(64, "id", "checkboxB");
            __builder.AddAttribute(65, "class", "checkbox");
            __builder.AddAttribute(66, "checked", "checked");
            __builder.AddAttribute(67, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 74 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\SemesterBlock\SemesterBlock.razor"
                                                                                                                           ()=> ChangeStatus(item.IdBlock,item.IdSemester,true)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(68, "b-1ph58kkn21");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n                                        <span class=\"toggle-text\" b-1ph58kkn21></span>\r\n                                        <span class=\"toggle-handle\" b-1ph58kkn21></span>");
            __builder.CloseElement();
#nullable restore
#line 78 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\SemesterBlock\SemesterBlock.razor"

                                }
                                else
                                {


#line default
#line hidden
#nullable disable
            __builder.OpenElement(70, "label");
            __builder.AddAttribute(71, "class", "toggle toggle-alternative");
            __builder.AddAttribute(72, "b-1ph58kkn21");
            __builder.OpenElement(73, "input");
            __builder.AddAttribute(74, "type", "checkbox");
            __builder.AddAttribute(75, "id", "checkboxB");
            __builder.AddAttribute(76, "class", "checkbox");
            __builder.AddAttribute(77, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 84 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\SemesterBlock\SemesterBlock.razor"
                                                                                                             ()=> ChangeStatus(item.IdBlock, item.IdSemester,false)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(78, "b-1ph58kkn21");
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n                                        <span class=\"toggle-text\" b-1ph58kkn21></span>\r\n                                        <span class=\"toggle-handle\" b-1ph58kkn21></span>");
            __builder.CloseElement();
#nullable restore
#line 88 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\SemesterBlock\SemesterBlock.razor"

                                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n                                ");
            __builder.OpenElement(81, "td");
            __builder.AddAttribute(82, "b-1ph58kkn21");
            __builder.OpenElement(83, "div");
            __builder.AddAttribute(84, "class", "d-flex d-flex justify-content-end mr-4");
            __builder.AddAttribute(85, "b-1ph58kkn21");
            __builder.OpenElement(86, "div");
            __builder.AddAttribute(87, "class", "pr-1");
            __builder.AddAttribute(88, "b-1ph58kkn21");
            __builder.OpenElement(89, "a");
            __builder.AddAttribute(90, "class", "btn btn-primary ");
            __builder.AddAttribute(91, "type", "button");
            __builder.AddAttribute(92, "title", "S???a");
            __builder.AddAttribute(93, "id", "show-emp");
            __builder.AddAttribute(94, "href", "semesterblock/update/" + (
#nullable restore
#line 95 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\SemesterBlock\SemesterBlock.razor"
                                                                                                                                            _cryptoServices.Encrypt(item.IdBlock.ToString()).Replace("/", "danhhn" )

#line default
#line hidden
#nullable disable
            ) + "/" + (
#nullable restore
#line 95 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\SemesterBlock\SemesterBlock.razor"
                                                                                                                                                                                                                      _cryptoServices.Encrypt(item.IdSemester.ToString()).Replace("/", "danhhn" )

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(95, "b-1ph58kkn21");
            __builder.AddMarkupContent(96, "<i class=\"fas fa-edit\" b-1ph58kkn21></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n                                        ");
            __builder.OpenElement(98, "div");
            __builder.AddAttribute(99, "class", " pl-1");
            __builder.AddAttribute(100, "b-1ph58kkn21");
            __builder.OpenElement(101, "a");
            __builder.AddAttribute(102, "class", "btn btn-danger ");
            __builder.AddAttribute(103, "type", "button");
            __builder.AddAttribute(104, "title", "X??a");
            __builder.AddAttribute(105, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 100 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\SemesterBlock\SemesterBlock.razor"
                                                                                                           ()=>Delete(item.IdBlock,item.IdSemester)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(106, "b-1ph58kkn21");
            __builder.AddMarkupContent(107, "<i class=\"fas fa-trash-alt\" b-1ph58kkn21></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 107 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\SemesterBlock\SemesterBlock.razor"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 107 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\SemesterBlock\SemesterBlock.razor"
                         
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n            ");
            __builder.OpenElement(109, "div");
            __builder.AddAttribute(110, "class", "d-flex justify-content-center mb-2");
            __builder.AddAttribute(111, "b-1ph58kkn21");
            __builder.OpenElement(112, "div");
            __builder.AddAttribute(113, "class", "row");
            __builder.AddAttribute(114, "b-1ph58kkn21");
            __builder.OpenElement(115, "div");
            __builder.AddAttribute(116, "class", "col-11 align-self-center");
            __builder.AddAttribute(117, "b-1ph58kkn21");
            __builder.OpenComponent<global::FPLSP.Components.Pagingation>(118);
            __builder.AddAttribute(119, "MetaData", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::FPLSP.Server.Data.SeedWork.MetaData>(
#nullable restore
#line 114 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\SemesterBlock\SemesterBlock.razor"
                                               MetaData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(120, "Spread", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 114 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\SemesterBlock\SemesterBlock.razor"
                                                                 2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(121, "SelectedPage", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.Int32>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.Int32>(this, 
#nullable restore
#line 114 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\SemesterBlock\SemesterBlock.razor"
                                                                                  SelectedPage

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenComponent<global::FPLSP.Components.Comfirmation>(122);
            __builder.AddAttribute(123, "ConfirmationMessage", "B???n mu???n x??a kh??ng?");
            __builder.AddAttribute(124, "ConfirmationTitle", "X??c nh???n");
            __builder.AddAttribute(125, "ConfirmationChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.Boolean>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.Boolean>(this, 
#nullable restore
#line 123 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\SemesterBlock\SemesterBlock.razor"
                                   OnConfirmationDelete 

#line default
#line hidden
#nullable disable
            )));
            __builder.AddComponentReferenceCapture(126, (__value) => {
#nullable restore
#line 123 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\SemesterBlock\SemesterBlock.razor"
                                                                DeleteConfirmation = (FPLSP.Components.Comfirmation)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(127, "\r\n    ");
            __builder.OpenComponent<global::FPLSP.Pages.CabinProject.SemesterBlock.SemesterBlockAdd>(128);
            __builder.AddAttribute(129, "OnAdd", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.Boolean>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.Boolean>(this, 
#nullable restore
#line 124 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\SemesterBlock\SemesterBlock.razor"
                             OnConfirmAdd

#line default
#line hidden
#nullable disable
            )));
            __builder.AddComponentReferenceCapture(130, (__value) => {
#nullable restore
#line 124 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\SemesterBlock\SemesterBlock.razor"
                                                 semesterBlockAdd = (FPLSP.Pages.CabinProject.SemesterBlock.SemesterBlockAdd)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
#nullable restore
#line 125 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\SemesterBlock\SemesterBlock.razor"


}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 128 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\SemesterBlock\SemesterBlock.razor"
       
    [Inject] private CryptoServices _cryptoServices { get; set; }
    private Guid idBlock { get; set; }
    private Guid idBlockDel { get; set; }
    private Guid idSemesterDel { get; set; }
    [Inject] private IToastService _toastService { get; set; }
    [Inject] private NavigationManager navigationManager { get; set; }
    protected Comfirmation DeleteConfirmation { get; set; }
    protected SemesterBlockAdd semesterBlockAdd { get; set; }
    public MetaData MetaData { get; set; } = new MetaData();
    [Inject] private ISemesterBlockRepo _semesterBlockRepo { get; set; }
    [Inject] private ISemesterRepo _semesterRepo { get; set; }
    [Inject] private IBlockRepo _blockRepo { get; set; }
    SemesterBlockSearch _semesterBlockSearch = new SemesterBlockSearch();
    List<SemesterBlockDto> _lstSemesterBlockSearch = new List<SemesterBlockDto>();
    List<SemesterDto> semester = new List<SemesterDto>();
    List<BlockDto> lstblock = new List<BlockDto>();
    List<SemesterBlockVM> semesterBlock = new List<SemesterBlockVM>();
    [Parameter] public Guid IdTrain { get; set; }
    protected override async Task OnInitializedAsync()
    {
        await GetTasks();
    }
    private async Task GetTasks()
    {

        try
        {

            semester = await _semesterRepo.GetAll();
            lstblock = await _blockRepo.GetAll();
            var pagingResponse = await _semesterBlockRepo.GetPageList(_semesterBlockSearch);
            _lstSemesterBlockSearch = pagingResponse.Items;
            MetaData = pagingResponse.MetaData;
            var lstsemesterBlock = from a in _lstSemesterBlockSearch
                                   join b in semester
                                   on a.IdSemester equals b.Id
                                   join c in lstblock
                                   on a.IdBlock equals c.Id
                                   select new
                                   {
                                       a.IdBlock,
                                       a.IdSemester,
                                       b.NameofSemester,
                                       c.NameOfBlock,
                                       a.StartTime,
                                       a.EndTime,
                                       a.IndexOfSemesterBlock,
                                       a.Status,

                                   };
            semesterBlock = new List<SemesterBlockVM>();
            if (_semesterBlockSearch.Search != null)
            {
                foreach (var item in lstsemesterBlock)
                {
                    SemesterBlockVM vM = new SemesterBlockVM()
                        {
                            IdBlock = item.IdBlock,
                            IdSemester = item.IdSemester,
                            NameofSemester = item.NameofSemester,
                            NameofBlock = item.NameOfBlock,
                            StartTime = item.StartTime,
                            EndTime = item.EndTime,
                            IndexOfSemesterBlock = item.IndexOfSemesterBlock,
                            Status = item.Status
                        };
                    semesterBlock.Add(vM);
                    semesterBlock = semesterBlock.Where(x => x.NameofBlock.Contains(_semesterBlockSearch.Search) || x.NameofSemester.Contains(_semesterBlockSearch.Search)).ToList();
                }
            }
            else
            {
                foreach (var item in lstsemesterBlock)
                {
                    SemesterBlockVM vM = new SemesterBlockVM()
                        {
                            IdBlock = item.IdBlock,
                            IdSemester = item.IdSemester,
                            NameofSemester = item.NameofSemester,
                            NameofBlock = item.NameOfBlock,
                            StartTime = item.StartTime,
                            EndTime = item.EndTime,
                            IndexOfSemesterBlock = item.IndexOfSemesterBlock,
                            Status = item.Status
                        };
                    semesterBlock.Add(vM);
                }
            }


            //foreach (var item in semesterBlock)
            //{
            //    if (((item.EndTime.Day < DateTime.Now.Day) && item.EndTime.Month <= DateTime.Now.Month && item.EndTime.Year <= DateTime.Now.Year || (item.EndTime.Month < DateTime.Now.Month && item.EndTime.Year <= DateTime.Now.Year) || (item.EndTime.Year < DateTime.Now.Year)) && item.Status == 0)
            //    {
            //        var changeStatusCabin = semesterBlock.FirstOrDefault(x => x.IdBlock == item.IdBlock && x.IdSemester == item.IdSemester);
            //        changeStatusCabin.Status = 2;
            //        var check = await _semesterBlockRepo.UpdateSemesterBlock(changeStatusCabin);
            //    }
            //}
            foreach (var item in semesterBlock)
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
            semesterBlock = semesterBlock.OrderByDescending(x => x.EndTime).ToList();
        }
        catch (HttpRequestException ex)
        {
            return;
        }

    }
    private async void Delete(Guid IdBlock, Guid IdSemester)
    {
        idBlockDel = IdBlock;
        idSemesterDel = IdSemester;
        DeleteConfirmation.show();

    }
    private async Task ChangeStatus(Guid idBlock, Guid idSemeester, bool? Checked)
    {

        var changeStatus = semesterBlock.FirstOrDefault(x => x.IdBlock == idBlock && x.IdSemester == idSemeester);
        if (!(bool)Checked && changeStatus != null)
        {
            
            changeStatus.Status = 0;
            await _semesterBlockRepo.UpdateSemesterBlock(changeStatus);
            semesterBlock = semesterBlock.Where(x => x.IdBlock != idBlock && x.IdSemester != idSemeester && x.Status == 0).ToList();
            foreach (var item in semesterBlock)
            {
                item.Status = 2;
                await _semesterBlockRepo.UpdateSemesterBlock(item);
            }
            _toastService.ShowSuccess("Thay ?????i tr???ng th??i th??nh c??ng");
            await GetTasks();
        }
        else
        {
            
            changeStatus.Status = 2;
            await _semesterBlockRepo.UpdateSemesterBlock(changeStatus);
            _toastService.ShowSuccess("Thay ?????i tr???ng th??i th??nh c??ng");
            await GetTasks();
        }


    }
    private void Update(Guid IdBlock, Guid IdSemester)
    {
        string idb = _cryptoServices.Encrypt(IdBlock.ToString()).Replace("/", "sem");
        string ids = _cryptoServices.Encrypt(IdSemester.ToString()).Replace("/", "sem");
        //navigationManager.NavigateTo($"/semesterblock/update/{IdBlock.ToString()}/{IdSemester.ToString()}");
        navigationManager.NavigateTo($"/semesterblock/update/{idb}/{ids}");

    }
    private async Task OnConfirmationDelete(bool deleteconfirmed)
    {
        if (deleteconfirmed)
        {
            await _semesterBlockRepo.DeleteSemesterBlock(Convert.ToString(idBlockDel), Convert.ToString(idSemesterDel));
            await GetTasks();
        }

    }

    private async Task SelectedPage(int page)
    {
        _semesterBlockSearch.PageNumber = page;
        await GetTasks();
    }
    public async Task SearchSemester(SemesterBlockSearch semesterBlockSearch)
    {
        _semesterBlockSearch = semesterBlockSearch;
        await GetTasks();
    }
    private void OpenDialog()
    {
        if (semesterBlockAdd != null)
        {
            semesterBlockAdd.show();
        }

    }
    private async Task OnConfirmAdd(bool check)
    {
        if (check)
        {
            await GetTasks();
        }


    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient httpClient { get; set; }
    }
}
#pragma warning restore 1591
