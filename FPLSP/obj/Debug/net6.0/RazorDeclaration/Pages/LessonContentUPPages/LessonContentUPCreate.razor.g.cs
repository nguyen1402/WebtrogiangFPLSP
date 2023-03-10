// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace FPLSP.Pages.LessonContentUPPages
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
#line 2 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LessonContentUPPages\LessonContentUPCreate.razor"
using FPLSP.Repositories.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LessonContentUPPages\LessonContentUPCreate.razor"
using FPLSP.Server.Infrastructure.ViewModels.LessonContentUP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LessonContentUPPages\LessonContentUPCreate.razor"
using FPLSP.Server.Infrastructure.ViewModels.LessonUP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LessonContentUPPages\LessonContentUPCreate.razor"
using FPLSP.Server.Infrastructure.ViewModels.ResourceLinkUP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LessonContentUPPages\LessonContentUPCreate.razor"
           [Authorize(Roles = "AdminCore,AdminCS")]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/lessonContentUPCreate/{idsubjectUP}/{Id}")]
    public partial class LessonContentUPCreate : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 73 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LessonContentUPPages\LessonContentUPCreate.razor"
       
    [Inject] ILessonContentUPRepo lessonContentUPRepo { get; set; }
    [Inject] NavigationManager NavigationManager { get; set; }
    [Inject] private ILessonUPRepo _lessonUPRepo { get; set; }
    private List<LessonUPViewModel> _lstLessonUP { get; set; }
    [Inject] private IResourceLinkUPRepo _resourceLinkUPRepo { get; set; }
    private List<ResourceLinkUPViewModel> _lstResourceLinkUP { get; set; }

    [CascadingParameter]
    private Error Error { get; set; }

    private LessonContentUPCreateRequest request = new LessonContentUPCreateRequest();
    [Parameter]
    public string idsubjectUP { get; set; }
    [Parameter]
    public string Id { get; set; }
    public string status { get; set; } = "";
    protected override async Task OnInitializedAsync()
    {
        _lstLessonUP = await _lessonUPRepo.GetAll();
        _lstResourceLinkUP = await _resourceLinkUPRepo.GetAll();
    }
    private async Task CreateSubmit(EditContext context)
    {
        try
        {
            request.Status = Convert.ToInt32(status);
            var result = await lessonContentUPRepo.Create(request);
            if (result)
            {
                NavigationManager.NavigateTo($"/lessonContentUP/{idsubjectUP}/{Id}");
            }
        }
        catch (Exception ex)
        {
            Error.ProcessError(ex);
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
