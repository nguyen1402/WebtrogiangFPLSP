#pragma checksum "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\Pagingation.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4f8202ce54ebcf59454f41aca7556249bd532602"
// <auto-generated/>
#pragma warning disable 1591
namespace FPLSP.Components
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
#line 1 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\Pagingation.razor"
using FPLSP.Features;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\Pagingation.razor"
using FPLSP.Server.Data.SeedWork;

#line default
#line hidden
#nullable disable
    public partial class Pagingation : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "nav");
            __builder.AddAttribute(1, "aria-label", "Page navigation example");
            __builder.OpenElement(2, "ul");
            __builder.AddAttribute(3, "class", "pagination justify-content-center");
#nullable restore
#line 6 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\Pagingation.razor"
         foreach (var link in _links)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "li");
            __builder.AddAttribute(5, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\Pagingation.razor"
                          () => OnSelectedPage(link)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "style", "cursor: pointer;");
            __builder.AddAttribute(7, "class", "page-item" + " " + (
#nullable restore
#line 8 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\Pagingation.razor"
                                                                                                  link.Enabled ? null : "disabled"

#line default
#line hidden
#nullable disable
            ) + " " + (
#nullable restore
#line 8 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\Pagingation.razor"
                                                                                                                                      link.Active ? "active" : null

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(8, "span");
            __builder.AddAttribute(9, "class", "page-link");
            __builder.AddAttribute(10, "href", "#");
#nullable restore
#line (9,51)-(9,60) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\Pagingation.razor"
__builder.AddContent(11, link.Text);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 11 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\Pagingation.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\Pagingation.razor"
       
    [Parameter]
    public MetaData MetaData { get; set; }
    [Parameter]
    public int Spread { get; set; }
    [Parameter]
    public EventCallback<int> SelectedPage { get; set; }

    private List<PagingLink> _links;

    protected override void OnParametersSet()
    {
        CreatePaginationLinks();
    }

    private void CreatePaginationLinks()
    {
        _links = new List<PagingLink>();
        _links.Add(new PagingLink(MetaData.CurrentPage - 1, MetaData.HasPrevious, "Previous"));
        for (int i = 1; i <= MetaData.TotalPages; i++)
        {
            if (i >= MetaData.CurrentPage - Spread && i <= MetaData.CurrentPage + Spread)
            {
                _links.Add(new PagingLink(i, true, i.ToString()) { Active = MetaData.CurrentPage == i });
            }
        }
        _links.Add(new PagingLink(MetaData.CurrentPage + 1, MetaData.HasNext, "Next"));
    }

    private async Task OnSelectedPage(PagingLink link)
    {
        if (link.Page == MetaData.CurrentPage || !link.Enabled)
            return;
        MetaData.CurrentPage = link.Page;
        await SelectedPage.InvokeAsync(link.Page);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
