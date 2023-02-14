// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FPLSP.Pages.NewFeed
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
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
#line 2 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\NewFeed\NewFeed.razor"
using FPLSP.Server.Infrastructure.ViewModels.NewFeed;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\NewFeed\NewFeed.razor"
using Microsoft.AspNetCore.SignalR.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\NewFeed\NewFeed.razor"
using FPLSP.Repositories.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\NewFeed\NewFeed.razor"
using FPLSP.Server.Domain.Entities.CoresParts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\NewFeed\NewFeed.razor"
using FPLSP.Server.Infrastructure.ViewModels.NewFeed;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\NewFeed\NewFeed.razor"
using FPLSP.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\NewFeed\NewFeed.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\NewFeed\NewFeed.razor"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\NewFeed\NewFeed.razor"
           [Authorize(Roles = "Student")]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.LayoutAttribute(typeof(MainLayout2))]
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/newfeed")]
    public partial class NewFeed : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 133 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\NewFeed\NewFeed.razor"
       
    [CascadingParameter]
    private Error _error { get; set; }
    [Inject]
    public INewFeedRepo _newFeedRepo { get; set; }
    private List<NewFeedOverView> _lstNewFeed;
    private List<NewFeedOverView> _lstNewFeedforclass = new List<NewFeedOverView>();
    //
    [Inject]
    public IHttpContextAccessor _httpContextAccessor { get; set; }
    //
    [Inject]
    public UserManager<UserSignIn> _userManager { get; set; }
    //

    public NewFeed()
    {
        _lstNewFeed = new List<NewFeedOverView>();
    }
    protected async override Task OnInitializedAsync()
    {
        await GetNewFeed();
        await ConnectToServer();
    }
    private async Task GetNewFeed()
    {
        var getusername = _httpContextAccessor.HttpContext.User.Identity.Name;
      
        var getID = _userManager.Users.ToList().Where(c => c.Email == getusername).Select(c => c.Id).FirstOrDefault();
        _lstNewFeed = await _newFeedRepo.GetListNewForUser(Guid.Parse(getID));
    }

    private async Task ConnectToServer()
    {
        try
        {
            //string url = "https://localhost:5001/notificationhub";
            //HubConnection _connection = null;
            //bool isConnected = false;
            //string connectionStatus = "Closed";
            //_connection = new HubConnectionBuilder()
            //    .WithUrl(url)
            //    .Build();

            //await _connection.StartAsync();
            //isConnected = true;
            //connectionStatus = "Connected :-)";

            //_connection.Closed += async (s) =>
            //{
            //    isConnected = false;
            //    connectionStatus = "Disconnected";
            //    await _connection.StartAsync();
            //    isConnected = true;
            //};

            //_connection.On<bool>("Noticafications", async res =>
            //{
            //    if (res == true)
            //    {
            //        await GetNewFeed();
            //        StateHasChanged();
            //    }
            //});
        }
        catch (Exception ex)
        {

            _error.ProcessError(ex);
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591