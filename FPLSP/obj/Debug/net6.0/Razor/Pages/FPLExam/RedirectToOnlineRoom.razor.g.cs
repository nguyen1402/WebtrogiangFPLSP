#pragma checksum "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\FPLExam\RedirectToOnlineRoom.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d211b691bb93ab51a4f78fc7f0f81364c54410b4"
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
#line 2 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\FPLExam\RedirectToOnlineRoom.razor"
using AntDesign;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\FPLExam\RedirectToOnlineRoom.razor"
using FPLSP.Data.FPLExam;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\FPLExam\RedirectToOnlineRoom.razor"
using FPLSP.Repositories.Interfaces.FPLExam;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\FPLExam\RedirectToOnlineRoom.razor"
using FPLSP.Server.Domain.Entities.CoresParts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\FPLExam\RedirectToOnlineRoom.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/redirecttoonlineroom/{GetIdUser}/{SecretKey}/{LastChecking}")]
    public partial class RedirectToOnlineRoom : global::Microsoft.AspNetCore.Components.ComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<div class=""loading""><div class=""loading-texter""><span class=""loading-texter-words"">F</span>
        <span class=""loading-texter-words"">P</span>
        <span class=""loading-texter-words"">L</span>
        &nbsp;
        <span class=""loading-texter-words"">E</span>
        <span class=""loading-texter-words"">X</span>
        <span class=""loading-texter-words"">A</span>
        <span class=""loading-texter-words"">M</span></div></div>");
#nullable restore
#line 27 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\FPLExam\RedirectToOnlineRoom.razor"
 if (!string.IsNullOrEmpty(checkingsateuser.SelectedIdUser) || !string.IsNullOrEmpty(checkingsateuser.DeclineIdUser))
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, @"<div class=""loading""><div class=""loading-texter""><span class=""loading-texter-words"">L</span>
            <span class=""loading-texter-words"">O</span>
            <span class=""loading-texter-words"">A</span>

            <span class=""loading-texter-words"">D</span>
            <span class=""loading-texter-words"">I</span>
            <span class=""loading-texter-words"">N</span>
            <span class=""loading-texter-words"">D</span></div></div>");
#nullable restore
#line 42 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\FPLExam\RedirectToOnlineRoom.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\FPLExam\RedirectToOnlineRoom.razor"
       
    [Parameter]
    public string LastChecking { get; set; }
    [Parameter]
    public string SecretKey { get; set; }
    [Inject] public UserManager<UserSignIn> _userManager { get; set; }
    [Inject] public IOnlineExamRoomRepo _onlineExamRoomRepo { get; set; }
    private int counter = 0;
    private int gettingstatus;
    private string getEmail;
    [Parameter]
    public string GetIdUser { get; set; }
    protected async override Task OnInitializedAsync()
    {

        checkingsateuser.OnChange += OnMyChangeHandler;
        //l???y ra id c???a th?? sinh ????
        var authState = await AuthenticationStateProvider.GetAuthenticationStateAsync();
        var user = authState.User;
        if (user.Identity.IsAuthenticated)
        {
            getEmail = user.Claims.ToList()[4].Value;
            var getIdUser = user.Claims.ToList().LastOrDefault().Value;
            checkingsateuser.SelectedIdUser = "";
            checkingsateuser.DeclineIdUser = "";
            if (!string.IsNullOrEmpty(checkingsateuser.SelectedIdUser))
            {
                var resupdate = await _onlineExamRoomRepo.FastChangingStatus(SecretKey, GetIdUser);
                if (resupdate)
                {

                    var gettingstatus = await _onlineExamRoomRepo.FastGettingStatus(SecretKey, GetIdUser);
                    NavigationManager.NavigateTo($"/onlineroomhandler/{SecretKey}/{GetIdUser}", true);
                }
            }
            if (getIdUser != null)
            {
                gettingstatus = await _onlineExamRoomRepo.FastGettingStatus(SecretKey, GetIdUser);
            }
            if (LastChecking.ToLower() == "firstjoin")
            {

                NavigationManager.NavigateTo($"onlineroomhandler/{SecretKey}/{GetIdUser}", true);
            }
        }
    }


    protected async override Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            if (!string.IsNullOrEmpty(checkingsateuser.SelectedIdUser))
            {
                var resupdate = await _onlineExamRoomRepo.FastChangingStatus(SecretKey, GetIdUser);
                if (resupdate)
                {

                    NavigationManager.NavigateTo($"/onlineroomhandler/{SecretKey}/{GetIdUser}", true);
                }
            }
            if (!string.IsNullOrEmpty(checkingsateuser.DeclineIdUser))
            {

                NavigationManager.NavigateTo($"/loadingpage/{GetIdUser}");
            }
            if (LastChecking == "waittingforaccpet")
            {
                var res = await _onlineExamRoomRepo.FastUpdateTurn(SecretKey, GetIdUser);


            }

        }
        if (!string.IsNullOrEmpty(checkingsateuser.SelectedIdUser))
        {
            if (checkingsateuser.SelectedIdUser == GetIdUser)
            {
                var resupdate = await _onlineExamRoomRepo.FastChangingStatus(SecretKey, GetIdUser);
                if (resupdate)
                {

                    NavigationManager.NavigateTo($"/onlineroomhandler/{SecretKey}/{GetIdUser}",true);
                }
               // checkingsateuser.OnChange -= OnMyChangeHandler;
            }
           
          
        }
        if (!string.IsNullOrEmpty(checkingsateuser.DeclineIdUser))
        {
            
            NavigationManager.NavigateTo($"/loadingpage/{GetIdUser}");
        }

    }
    public async void OnMyChangeHandler(object sender, EventArgs args)
    {
        // notify the UI that the state has changed
        await InvokeAsync(() => StateHasChanged());
    }

    public void Dispose()
    {
      //  checkingsateuser.OnChange -= OnMyChangeHandler;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private StateDelegateAcceptTojoin checkingsateuser { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NotificationService _notice { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SweetAlertService Swal { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
