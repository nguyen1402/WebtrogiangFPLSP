#pragma checksum "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Detailspecialized.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7b2403a6bd6c79fabfc9e9e20bc9776636ea955"
// <auto-generated/>
#pragma warning disable 1591
namespace FPLSP.Pages.PagesSpecializedCP
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
#line 2 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Detailspecialized.razor"
using FPLSP.Repositories.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Detailspecialized.razor"
using FPLSP.Server.Domain.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Detailspecialized.razor"
           [Authorize(Roles = "AdminCore,AdminCS")]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/detailspecialized/{id}")]
    public partial class Detailspecialized : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Detailspecialized.razor"
 if (model != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row pt-1");
            __builder.OpenElement(2, "label");
            __builder.AddAttribute(3, "for", "name");
            __builder.AddAttribute(4, "class", " col-md-6 col-form-label");
            __builder.AddMarkupContent(5, "???????ng Link: ");
            __builder.OpenElement(6, "b");
#nullable restore
#line (8,76)-(8,97) 24 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Detailspecialized.razor"
__builder.AddContent(7, model.SpecializedCode);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "row pt-1");
            __builder.OpenElement(11, "label");
            __builder.AddAttribute(12, "for", "name");
            __builder.AddAttribute(13, "class", " col-md-col-md-6 col-form-label");
            __builder.AddMarkupContent(14, "M?? t???: ");
            __builder.OpenElement(15, "b");
#nullable restore
#line (11,78)-(11,102) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Detailspecialized.razor"
__builder.AddContent(16, model.SpecializationName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n    ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "row pt-1");
            __builder.OpenElement(20, "label");
            __builder.AddAttribute(21, "for", "name");
            __builder.AddAttribute(22, "class", " col-md-col-md-6 col-form-label");
            __builder.AddMarkupContent(23, "\r\n            Tr???ng th??i :\r\n");
#nullable restore
#line 16 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Detailspecialized.razor"
             if (@model.Status == 0)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(24, "<b>\r\n                    Ch??a ????? sinh vi??n\r\n                </b>");
#nullable restore
#line 21 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Detailspecialized.razor"
            }
            else if (@model.Status == 1)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(25, "<b>\r\n                    Ch??? ??i v??o ho???t ?????ng\r\n                </b>");
#nullable restore
#line 27 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Detailspecialized.razor"
            }
            else if (@model.Status == 2)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(26, "<b>\r\n                    Ng??ng ho???t ?????ng\r\n                </b>");
#nullable restore
#line 33 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Detailspecialized.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(27, "<b>\r\n                    ??ang ho???t ?????ng\r\n                </b>");
#nullable restore
#line 39 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Detailspecialized.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "<div class=\"row pt-2 col-md-1 text-center\"><a href=\"/specialized\" class=\"btn btn-outline-danger\">Quay L???i</a></div>");
#nullable restore
#line 46 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Detailspecialized.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Detailspecialized.razor"
       
    [Parameter]
    public string Id { get; set; }
    private SpecializedDto model;

    [Inject]
    public ISpecializedCPRepo _iSpecializedClient { get; set; }
    protected override async Task OnInitializedAsync()
    {
        model = await _iSpecializedClient.GetbyId(Guid.Empty, Guid.Parse(Id));
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
