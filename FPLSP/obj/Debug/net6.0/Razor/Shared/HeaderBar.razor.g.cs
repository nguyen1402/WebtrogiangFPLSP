#pragma checksum "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Shared\HeaderBar.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "40e80f67e2677237ae05cb763164ca2679b10296"
// <auto-generated/>
#pragma warning disable 1591
namespace FPLSP.Shared
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
#line 2 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Shared\HeaderBar.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Shared\HeaderBar.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Shared\HeaderBar.razor"
using Microsoft.AspNetCore.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Shared\HeaderBar.razor"
using Microsoft.AspNetCore.Authentication.Cookies;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Shared\HeaderBar.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Shared\HeaderBar.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Shared\HeaderBar.razor"
using System.Reflection;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Shared\HeaderBar.razor"
using System.Text.RegularExpressions;

#line default
#line hidden
#nullable disable
    public partial class HeaderBar : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "nav");
            __builder.AddAttribute(1, "class", "navbar navbar-light text-center");
            __builder.AddMarkupContent(2, @"<div class=""row""><div class=""col-lg-12  d-flex justify-content-start""><a href class=""navbar-brand d-flex d-lg-none""><h2 class=""text-primary mb-0""><i class=""fa fa-hashtag""></i></h2></a>
                <button class=""sidebar-toggler""></button>
                <form class=""d-none d-md-flex mt-2  ms-4""></form></div></div>
        ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "d-flex align-items-center mb-4 pl-2");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "position-relative");
            __builder.OpenElement(7, "img");
            __builder.AddAttribute(8, "class", "rounded-circle");
            __builder.AddAttribute(9, "src", 
#nullable restore
#line 33 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Shared\HeaderBar.razor"
                                              imageUser

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(10, "alt");
            __builder.AddAttribute(11, "style", "width: 40px; height: 40px;");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n                <div class=\"bg-success rounded-circle border border-2 border-white position-absolute end-0 bottom-0 p-1\"></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n            ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "ms-2");
            __builder.OpenElement(16, "span");
            __builder.AddAttribute(17, "class", "mb-0");
#nullable restore
#line (37,40)-(37,80) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Shared\HeaderBar.razor"
__builder.AddContent(18, fistusername == null ? "" : fistusername);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "<br>\r\n                ");
            __builder.OpenElement(20, "a");
            __builder.AddAttribute(21, "type", "button");
            __builder.AddAttribute(22, "class", "nav-link float-start ps-0 pt-1");
            __builder.AddAttribute(23, "style", "font-size: smaller;");
            __builder.AddAttribute(24, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Shared\HeaderBar.razor"
                                                                                                              LogOut

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(25, "<i class=\"fa-solid fa-right-from-bracket\"></i> Đăng xuất");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Shared\HeaderBar.razor"
       

    //Type[] types => Assembly.GetExecutingAssembly().GetTypes().Where(c => c.BaseType == typeof(ComponentBase)).ToArray();
    //Type SelecteType;
    //RenderFragment renderFragment;
    //private string _compnentName;
    //[Inject] public IToastService _toastService { get; set; }
    //private string UserName = "";
    //private string UserNameDisPlay;
    //public string ComponentName
    //{
    //    get { return _compnentName; }
    //    set
    //    {
    //        _compnentName = value;
    //        SelecteType = types.Where(c => c.Name.ToUpper() == value.ToUpper()).FirstOrDefault() ?? typeof(SurveyPrompt);
    //        renderFragment = (builder) =>
    //        {
    //            builder.OpenComponent(0, SelecteType);
    //            builder.CloseComponent();
    //        };
    //    }
    //}
    private string fistusername="";

    private ReaderWriterLock _lock;
    private string SaveKey = "";
    string patern = "^([a-z]{3,13}[0-9]{0,3}@fpt-edu-vn)$";
    private string imageUser = "";
    protected async override Task OnInitializedAsync()
    {
        var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
        var user = authState.User;

        if (user.Identity.IsAuthenticated)
        {
            fistusername = user.Claims.ToList()[4].Value.ToString();
            imageUser = user.Claims.ToList()[6].Value.ToString();
        }
        else
        {

            fistusername = "ViewerUser";
        }




    }
    protected override async Task OnAfterRenderAsync(bool firstRender){
        //var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
        //var user = authState.User;

        //if (user.Identity.IsAuthenticated)
        //{
        //    fistusername = user.Claims.ToList()[4].Value.ToString();
        //}
        //else
        //{

        //    fistusername = "ViewerUser";
        //}
        //var xxx = Navigation.Uri.ToString();
        //if (xxx.Contains("fplsp") && xxx.Contains("adminlogin"))
        //{
        //    fistusername = xxx.Substring(27, xxx.Length - 27);
        //    if (Regex.IsMatch(fistusername, patern))
        //    {
        //        await _localStorageService.SetItemAsStringAsync("keyver", fistusername);
        //    }

        //}
        //else
        //{
        //    fistusername = await _localStorageService.GetItemAsync<string>("keyver");
        //}
        //if (xxx.Contains("fplsp") == false && xxx.Contains("adminlogin"))
        //{
        //    fistusername = xxx.Substring(34, xxx.Length - 34);
        //    if (Regex.IsMatch(fistusername, patern))
        //    {
        //        await _localStorageService.SetItemAsStringAsync("keyver", fistusername);
        //    }

        //}
        //else
        //{
        //    fistusername = await _localStorageService.GetItemAsync<string>("keyver");
        //}

    }

    private async Task LogOut()
    {

        await _localStorageService.SetItemAsStringAsync("keyver", "");
        _httcontex.HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        _httcontex.HttpContext.Session.Remove("err");
        Navigation.NavigateTo("/");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpContextAccessor _httcontex { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService _localStorageService { get; set; }
    }
}
#pragma warning restore 1591