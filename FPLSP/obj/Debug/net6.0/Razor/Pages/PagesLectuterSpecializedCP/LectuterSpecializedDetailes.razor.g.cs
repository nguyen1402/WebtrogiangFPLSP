#pragma checksum "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesLectuterSpecializedCP\LectuterSpecializedDetailes.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bfbcc13e4d4ce1859932b201a16b372ce5a8eed3"
// <auto-generated/>
#pragma warning disable 1591
namespace FPLSP.Pages.PagesLectuterSpecializedCP
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
#line 2 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesLectuterSpecializedCP\LectuterSpecializedDetailes.razor"
using FPLSP.Repositories.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesLectuterSpecializedCP\LectuterSpecializedDetailes.razor"
using FPLSP.Server.Domain.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesLectuterSpecializedCP\LectuterSpecializedDetailes.razor"
           [Authorize(Roles = "AdminCS")]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/lectuterSpecializedDetails/{id}/{idBo}/{Idspecialized}/{Idlecturers}")]
    public partial class LectuterSpecializedDetailes : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row pt-3");
#nullable restore
#line 6 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesLectuterSpecializedCP\LectuterSpecializedDetailes.razor"
     if (CP != null)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row pt-1");
            __builder.OpenElement(4, "img");
            __builder.AddAttribute(5, "src", 
#nullable restore
#line 9 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesLectuterSpecializedCP\LectuterSpecializedDetailes.razor"
                       CP.ImageUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(6, "onerror", "this.src=\'./css/images/Others/logoFPT.png\'");
            __builder.AddAttribute(7, "alt", "product image");
            __builder.AddAttribute(8, "style", "width:100px;");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "row pt-1");
            __builder.OpenElement(12, "label");
            __builder.AddAttribute(13, "for", "name");
            __builder.AddAttribute(14, "class", " col-md-6 col-form-label");
            __builder.AddMarkupContent(15, "Chuy??n ng??nh: ");
            __builder.OpenElement(16, "b");
#nullable restore
#line (12,82)-(12,100) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesLectuterSpecializedCP\LectuterSpecializedDetailes.razor"
__builder.AddContent(17, CP.SpecializedCode);

#line default
#line hidden
#nullable disable
            __builder.AddContent(18, " - ");
#nullable restore
#line (12,104)-(12,125) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesLectuterSpecializedCP\LectuterSpecializedDetailes.razor"
__builder.AddContent(19, CP.SpecializationName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "row pt-1");
            __builder.OpenElement(23, "label");
            __builder.AddAttribute(24, "for", "name");
            __builder.AddAttribute(25, "class", " col-md-col-md-6 col-form-label");
            __builder.AddMarkupContent(26, "\r\n                Gi???i t??nh:\r\n");
#nullable restore
#line 17 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesLectuterSpecializedCP\LectuterSpecializedDetailes.razor"
                 if (@CP.Gender == true)
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(27, "<b>Nam</b>");
#nullable restore
#line 20 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesLectuterSpecializedCP\LectuterSpecializedDetailes.razor"
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(28, "<b>N???</b>");
#nullable restore
#line 24 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesLectuterSpecializedCP\LectuterSpecializedDetailes.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n        ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "row pt-1");
            __builder.OpenElement(32, "label");
            __builder.AddAttribute(33, "for", "name");
            __builder.AddAttribute(34, "class", " col-md-col-md-6 col-form-label");
            __builder.AddMarkupContent(35, "Ng??y sinh : ");
            __builder.OpenElement(36, "b");
#nullable restore
#line (28,87)-(28,93) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesLectuterSpecializedCP\LectuterSpecializedDetailes.razor"
__builder.AddContent(37, CP.Dob);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n        ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "row pt-1");
            __builder.OpenElement(41, "label");
            __builder.AddAttribute(42, "for", "name");
            __builder.AddAttribute(43, "class", " col-md-col-md-6 col-form-label");
            __builder.AddContent(44, "Email ");
            __builder.OpenElement(45, "b");
#nullable restore
#line (31,81)-(31,89) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesLectuterSpecializedCP\LectuterSpecializedDetailes.razor"
__builder.AddContent(46, CP.Email);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n        ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "row pt-1");
            __builder.OpenElement(50, "label");
            __builder.AddAttribute(51, "for", "name");
            __builder.AddAttribute(52, "class", " col-md-col-md-6 col-form-label");
            __builder.AddMarkupContent(53, "S??? ??i???n tho???i ");
            __builder.OpenElement(54, "b");
#nullable restore
#line (34,89)-(34,103) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesLectuterSpecializedCP\LectuterSpecializedDetailes.razor"
__builder.AddContent(55, CP.PhoneNumber);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n        ");
            __builder.OpenElement(57, "div");
            __builder.AddAttribute(58, "class", "row pt-1");
            __builder.OpenElement(59, "label");
            __builder.AddAttribute(60, "for", "name");
            __builder.AddAttribute(61, "class", " col-md-col-md-6 col-form-label");
            __builder.AddMarkupContent(62, "?????a ch??? ");
            __builder.OpenElement(63, "b");
#nullable restore
#line (37,83)-(37,93) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesLectuterSpecializedCP\LectuterSpecializedDetailes.razor"
__builder.AddContent(64, CP.Address);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n        ");
            __builder.OpenElement(66, "div");
            __builder.AddAttribute(67, "class", "row pt-1");
            __builder.OpenElement(68, "label");
            __builder.AddAttribute(69, "for", "name");
            __builder.AddAttribute(70, "class", " col-md-col-md-6 col-form-label");
            __builder.AddMarkupContent(71, "D??n t???c ");
            __builder.OpenElement(72, "b");
#nullable restore
#line (40,83)-(40,92) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesLectuterSpecializedCP\LectuterSpecializedDetailes.razor"
__builder.AddContent(73, CP.Ethnic);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n        ");
            __builder.OpenElement(75, "div");
            __builder.AddAttribute(76, "class", "row pt-1");
            __builder.OpenElement(77, "label");
            __builder.AddAttribute(78, "for", "name");
            __builder.AddAttribute(79, "class", " col-md-col-md-6 col-form-label");
            __builder.AddMarkupContent(80, "\r\n                C??c gi???ng vi??n li??n quan :\r\n");
#nullable restore
#line 45 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesLectuterSpecializedCP\LectuterSpecializedDetailes.razor"
                 if (CP.Emsils.Count > 0)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesLectuterSpecializedCP\LectuterSpecializedDetailes.razor"
                     foreach (var item in CP.Emsils)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(81, "div");
            __builder.AddAttribute(82, "class", "row");
            __builder.OpenElement(83, "b");
            __builder.OpenElement(84, "i");
#nullable restore
#line (50,36)-(50,40) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesLectuterSpecializedCP\LectuterSpecializedDetailes.razor"
__builder.AddContent(85, item);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 52 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesLectuterSpecializedCP\LectuterSpecializedDetailes.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesLectuterSpecializedCP\LectuterSpecializedDetailes.razor"
                     
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n        ");
            __builder.OpenElement(87, "div");
            __builder.AddAttribute(88, "class", "row pt-2 col-md-1 text-center");
            __builder.OpenElement(89, "a");
            __builder.AddAttribute(90, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 58 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesLectuterSpecializedCP\LectuterSpecializedDetailes.razor"
                         ()=>Quaylai()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(91, "class", "btn btn-outline-danger");
            __builder.AddMarkupContent(92, "Quay L???i");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 60 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesLectuterSpecializedCP\LectuterSpecializedDetailes.razor"

    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 65 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesLectuterSpecializedCP\LectuterSpecializedDetailes.razor"
       
    [Parameter]
    public string id { get; set; }
    [Parameter]
    public string idBo { get; set; }

    [Parameter]
    public string Idspecialized { get; set; }
    [Parameter]
    public string Idlecturers { get; set; }
    [Inject]
    public NavigationManager Navigation { get; set; }

    public LectuterSpecializedCPDto CP;
    [Inject]
    public ILectuterSpecializedCPCilents _iLessonContentClient { get; set; }

    protected async override Task OnInitializedAsync()
    {
        CP = await _iLessonContentClient.GetbyId(Guid.Parse(Idspecialized), Guid.Parse(Idlecturers));
    }
    private async Task Quaylai()
    {
        var url = Path.Combine("/lectuterSpecialized", idBo, id);
        Navigation.NavigateTo(url);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
