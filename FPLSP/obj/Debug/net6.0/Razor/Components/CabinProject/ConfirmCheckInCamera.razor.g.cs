#pragma checksum "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\CabinProject\ConfirmCheckInCamera.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ee03459f6000fbd1e0eba93a86080cf337060fc2"
// <auto-generated/>
#pragma warning disable 1591
namespace FPLSP.Components.CabinProject
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
    public partial class ConfirmCheckInCamera : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 1 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\CabinProject\ConfirmCheckInCamera.razor"
 if (ShowConfirmation)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "modal fade show d-block");
            __builder.AddAttribute(2, "id", "exampleModal");
            __builder.AddAttribute(3, "tabindex", "-1");
            __builder.AddAttribute(4, "role", "dialog");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "modal-dialog");
            __builder.AddAttribute(7, "role", "document");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "modal-content");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "modal-header");
            __builder.OpenElement(12, "h5");
            __builder.AddAttribute(13, "class", "modal-title");
            __builder.AddAttribute(14, "id", "exampleModalLabel");
#nullable restore
#line (7,69)-(7,86) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\CabinProject\ConfirmCheckInCamera.razor"
__builder.AddContent(15, ConfirmationTitle);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                    ");
            __builder.OpenElement(17, "button");
            __builder.AddAttribute(18, "type", "button");
            __builder.AddAttribute(19, "class", "close");
            __builder.AddAttribute(20, "data-dismiss", "modal");
            __builder.AddAttribute(21, "aria-label", "Close");
            __builder.AddAttribute(22, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\CabinProject\ConfirmCheckInCamera.razor"
                                  () => OnConfirmationChange(false)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(23, "<span aria-hidden=\"true\">&times;</span>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "modal-body");
#nullable restore
#line (14,22)-(14,41) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\CabinProject\ConfirmCheckInCamera.razor"
__builder.AddContent(27, ConfirmationMessage);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "modal-footer");
            __builder.OpenElement(31, "button");
            __builder.AddAttribute(32, "type", "button");
            __builder.AddAttribute(33, "class", "btn btn-secondary");
            __builder.AddAttribute(34, "data-dismiss", "modal");
            __builder.AddAttribute(35, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\CabinProject\ConfirmCheckInCamera.razor"
                                  () => OnConfirmationChange(false)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(36, "\r\n                        Cancel\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                    ");
            __builder.OpenElement(38, "button");
            __builder.AddAttribute(39, "type", "button");
            __builder.AddAttribute(40, "class", "btn btn-danger");
            __builder.AddAttribute(41, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\CabinProject\ConfirmCheckInCamera.razor"
                                  () => OnConfirmationChange(true)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(42, "\r\n                        Xác nhận\r\n                    ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 29 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\CabinProject\ConfirmCheckInCamera.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\CabinProject\ConfirmCheckInCamera.razor"
       
    [Inject] NavigationManager _navigationManager { get; set; }
    protected bool ShowConfirmation { get; set; }

    [Parameter]
    public string ConfirmationTitle { get; set; } = "Xác nhận thoát";

    [Parameter]
    public string ConfirmationMessage { get; set; } = "Bạn muốn thoát chụp xác nhận";

    [Parameter]
    public EventCallback<bool> ConfirmationChanged { get; set; }


    public void show()
    {
        ShowConfirmation = true;
        StateHasChanged();
    }
    protected async Task OnConfirmationChange(bool value)
    {
        ShowConfirmation = false;

        await ConfirmationChanged.InvokeAsync(value);

    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
