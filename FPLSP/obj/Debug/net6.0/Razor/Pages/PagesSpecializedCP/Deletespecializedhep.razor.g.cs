#pragma checksum "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Deletespecializedhep.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ed1a6869bbefa4825207e9965d24a2849773283"
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
#line 2 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Deletespecializedhep.razor"
using FPLSP.Repositories.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Deletespecializedhep.razor"
using FPLSP.Server.Domain.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Deletespecializedhep.razor"
           [Authorize(Roles = "AdminCore,AdminCS")]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/deletespecializedhep/{idBo}/{id}")]
    public partial class Deletespecializedhep : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row pt-3");
            __builder.AddMarkupContent(2, "<h2>Xóa Chuyên Ngành Hẹp</h2>");
#nullable restore
#line 8 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Deletespecializedhep.razor"
     if (model != null)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.EditForm>(3);
            __builder.AddAttribute(4, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Object>(
#nullable restore
#line 10 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Deletespecializedhep.razor"
                         model

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Forms.EditContext>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 10 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Deletespecializedhep.razor"
                                               Delete

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(6, "class", "card card-body bg-light mt-5");
            __builder.AddAttribute(7, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n            ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "form-group row");
                __builder2.OpenElement(12, "label");
                __builder2.AddAttribute(13, "for", "name");
                __builder2.AddAttribute(14, "class", "row");
                __builder2.OpenElement(15, "p");
                __builder2.AddMarkupContent(16, "<b style=\"color : red\">You chắc chắn want delete to ?</b> chuyên ngành ");
                __builder2.OpenElement(17, "b");
#nullable restore
#line (15,100)-(15,124) 26 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Deletespecializedhep.razor"
__builder2.AddContent(18, model.SpecializationName);

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n                        ???\r\n                    ");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(20, "\r\n            ");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "row pt-2");
                __builder2.AddMarkupContent(23, "<div class=\"col-md-6 text-center\"><button type=\"submit\" class=\"btn btn-danger\">Xóa Ngay</button></div>\r\n                ");
                __builder2.OpenElement(24, "div");
                __builder2.AddAttribute(25, "class", "col-md-6 text-center");
                __builder2.OpenElement(26, "a");
                __builder2.AddAttribute(27, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 26 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Deletespecializedhep.razor"
                                 () => Quaylai()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "class", "btn btn-primary");
                __builder2.AddMarkupContent(29, "Quay Lại");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 30 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Deletespecializedhep.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Deletespecializedhep.razor"
       
    private SpecializedDto model;
    [Inject]
    public NavigationManager Navigation { get; set; }

    [Inject]
    public ISpecializedCPRepo _iSpecializedClient { get; set; }
    public bool ShowAuthError { get; set; }
    [Parameter]
    public string Error { get; set; }
    [Parameter]
    public string Idbo { get; set; }
    [Parameter]
    public string Id { get; set; }
    protected override async Task OnInitializedAsync()
    {
        model = await _iSpecializedClient.GetbyId(Guid.Parse(Idbo), Guid.Parse(Id));
    }
    private async Task Delete()
    {
        ShowAuthError = false;
        var result = await _iSpecializedClient.Delete(Guid.Parse(Idbo), Guid.Parse(Id));

        if (result != 1)
        {
            Error = "Lỗi";
            ShowAuthError = true;
            Navigation.NavigateTo("/deletespecialized" + Id);
        }
        else
        {
            var url = Path.Combine("/specializedhep", Idbo);
            Navigation.NavigateTo(url);
        }
    }
    private async Task Quaylai()
    {
        var url = Path.Combine("/specializedhep", Idbo);
        Navigation.NavigateTo(url);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
