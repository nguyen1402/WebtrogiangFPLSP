#pragma checksum "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\FPLExam\PdfViewer.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35107c45869a15c88281ec15daaa9b2be1bd1a86"
// <auto-generated/>
#pragma warning disable 1591
namespace FPLSP.Pages.FPLExam
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
#line 2 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\FPLExam\PdfViewer.razor"
using System.Timers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\FPLExam\PdfViewer.razor"
using AntDesign;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\FPLExam\PdfViewer.razor"
using Microsoft.AspNetCore.Components.ProtectedBrowserStorage;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/pdfviewer")]
    public partial class PdfViewer : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<div class=""btn-container""><button class=""tired""><span class=""text"">Hover</span>
        <div class=""icon-container""><div class=""icon icon--left""><svg><use xlink:href=""#arrow-right""></use></svg></div>
            <div class=""icon icon--right""><svg><use xlink:href=""#arrow-right""></use></svg></div></div></button></div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\FPLExam\PdfViewer.razor"
 
    double size = 8;
    [Parameter]
    public RenderFragment childcontent { get; set; }
    public string username;
    public string IdUser;
    public string Image;
    private SliderMark[] nMarks =
    {
            new SliderMark(0, "0p"),
            new SliderMark(5, "5p"),
            new SliderMark(15, "15p"),
            new SliderMark(25, "25p"),
            new SliderMark(45, "45p")

     };
    protected async override Task OnAfterRenderAsync(bool firstRender)
    {

        //await protectedSessionStorage.SetAsync("UserName", userAuthen.Email);
        //await protectedSessionStorage.SetAsync("IdUser", userAuthen.Id);
        //await protectedSessionStorage.SetAsync("Image", imageUser);
        //await protectedSessionStorage.SetAsync("userAuthen", userAuthen);
        ////
        //ProtectedBrowserStorageResult<string> getid = await protectedSessionStorage.GetAsync<string>("IdUser");
        //ProtectedBrowserStorageResult<string> getuername = await protectedSessionStorage.GetAsync<string>("UserName");
        //ProtectedBrowserStorageResult<string> getimage = await protectedSessionStorage.GetAsync<string>("Image");
        //ProtectedBrowserStorageResult<UserSignIn> realuser = await protectedSessionStorage.GetAsync<UserSignIn>("userAuthen");
        //if (getuername.Success)
        // {
        //     fistusername = getuername.Value;
        // }
        // if (getid.Success)
        // {
        //     fistusername = getuername.Value;
        // }
        // if (getimage.Success)
        // {
        //     imageUser = getimage.Value;
        // }
        // if (realuser.Success)
        // {
        //     userAuthen = realuser.Value;
        // }

    }
    private async Task OnChangeValueTask()
    {
        
    }
    private async Task SetItem()
    {
        await JS.InvokeVoidAsync("localStorage.setItem", "thuyen", "leanthuyen");
    }
    private async Task GetIten()
    {
        username= await JS.InvokeAsync<string>("localStorage.getItem", "thuyen");
    }
    private async Task Xoa()
    {
        await JS.InvokeVoidAsync("localStorage.removeItem", "thuyen");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JS { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SweetAlertService Swal { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ProtectedSessionStorage protectedSessionStorage { get; set; }
    }
}
#pragma warning restore 1591
