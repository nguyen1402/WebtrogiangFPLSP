#pragma checksum "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ImagePages\ImageList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e1e31ba660bed9a9770a9be201f87c29a1db71a"
// <auto-generated/>
#pragma warning disable 1591
namespace FPLSP.Pages.ImagePages
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
#line 2 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ImagePages\ImageList.razor"
using FPLSP.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ImagePages\ImageList.razor"
using FPLSP.Repositories.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ImagePages\ImageList.razor"
using FPLSP.Server.Data.SeedWork;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ImagePages\ImageList.razor"
using FPLSP.Server.Domain.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ImagePages\ImageList.razor"
using FPLSP.Server.Infrastructure.ViewModels.ImagesCP;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/ImageList")]
    public partial class ImageList : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "main");
            __builder.AddAttribute(1, "class", "app-content");
            __builder.AddMarkupContent(2, "<div class=\"app-title\"><ul class=\"app-breadcrumb breadcrumb side\"><li class=\"breadcrumb-item active\"><a class=\"btn\" href=\"ImageList\"><b><h3>Danh s??ch ???nh</h3></b></a></li></ul>\r\n        <div id=\"clock\"></div></div>\r\n\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-md-12");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "tile");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "tile-body");
            __builder.AddMarkupContent(11, @"<div class=""row element-button""><div class=""col-sm-2""><a class=""btn btn-success"" href=""/ImageCreate"" title=""Th??m""><i class=""fas fa-plus""></i>
                                T???o m???i ???nh
                            </a></div></div>

                    ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "row");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "col-md-12");
            __builder.OpenComponent<global::FPLSP.Pages.ImagePages.ImageSearch>(16);
            __builder.AddAttribute(17, "OnSearch", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::FPLSP.Server.Infrastructure.ViewModels.ImagesCP.ImageCPListSearchVm>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::FPLSP.Server.Infrastructure.ViewModels.ImagesCP.ImageCPListSearchVm>(this, 
#nullable restore
#line 61 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ImagePages\ImageList.razor"
                                                   Search

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "mt-2");
            __builder.OpenElement(21, "table");
            __builder.AddAttribute(22, "class", "table table-hover table-bordered js-copytextarea");
            __builder.AddAttribute(23, "cellpadding", "0");
            __builder.AddAttribute(24, "cellspacing", "0");
            __builder.AddAttribute(25, "border", "0");
            __builder.AddAttribute(26, "id", "sampleTable");
            __builder.AddMarkupContent(27, @"<thead class=""text-center""><tr><th width=""5%""><input type=""checkbox"" id=""all""></th>
                                    <th>???nh</th>
                                    <th>M?? t???</th>
                                    <th>Tr???ng th??i</th>
                                    <th width=""15%"">T??nh n??ng</th></tr></thead>
                            ");
            __builder.OpenElement(28, "tbody");
#nullable restore
#line 77 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ImagePages\ImageList.razor"
                                 foreach (var item in _ImageCPDtos)
                                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(29, "tr");
            __builder.AddMarkupContent(30, "<td width=\"10\"><input type=\"checkbox\"></td>\r\n                                        ");
            __builder.OpenElement(31, "td");
            __builder.AddAttribute(32, "class", "text-center");
            __builder.OpenElement(33, "img");
            __builder.AddAttribute(34, "src", 
#nullable restore
#line 81 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ImagePages\ImageList.razor"
                                                                           item.Path

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(35, "onerror", "this.src=\'./css/images/Others/logoFPT.png\'");
            __builder.AddAttribute(36, "alt", "product image");
            __builder.AddAttribute(37, "style", "width:100px;");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                                        ");
            __builder.OpenElement(39, "td");
#nullable restore
#line (82,46)-(82,63) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ImagePages\ImageList.razor"
__builder.AddContent(40, item.Descriptions);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                                        ");
            __builder.OpenElement(42, "td");
            __builder.AddAttribute(43, "class", "text-center");
#nullable restore
#line (83,67)-(83,118) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ImagePages\ImageList.razor"
__builder.AddContent(44, @item.Status == 1 ? "??ang s??? d???ng" : "Ch??a s??? d???ng");

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                                        ");
            __builder.OpenElement(46, "td");
            __builder.AddAttribute(47, "class", "text-center");
            __builder.OpenElement(48, "a");
            __builder.AddAttribute(49, "class", "btn btn-primary ");
            __builder.AddAttribute(50, "type", "button");
            __builder.AddAttribute(51, "title", "X??a");
            __builder.AddAttribute(52, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 85 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ImagePages\ImageList.razor"
                                                                                                            () => RedirectToDelete(item.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(53, "<i class=\"fas fa-trash-alt\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                                            ");
            __builder.OpenElement(55, "a");
            __builder.AddAttribute(56, "class", "btn btn-primary ");
            __builder.AddAttribute(57, "type", "button");
            __builder.AddAttribute(58, "title", "S???a");
            __builder.AddAttribute(59, "id", "show-emp");
            __builder.AddAttribute(60, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 89 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ImagePages\ImageList.razor"
                                                     () => RedirectToUpdate(item.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(61, "<i class=\"fas fa-edit\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(62, "\r\n                                            ");
            __builder.OpenElement(63, "a");
            __builder.AddAttribute(64, "class", "btn btn-primary");
            __builder.AddAttribute(65, "type", "button");
            __builder.AddAttribute(66, "title", "Chi Ti???t");
            __builder.AddAttribute(67, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 92 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ImagePages\ImageList.razor"
                                                                                                                () => RedirectToDetails(item.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(68, "<i class=\"fa-solid fa-bars\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 97 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ImagePages\ImageList.razor"
                                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n                    ");
            __builder.OpenElement(70, "div");
            __builder.AddAttribute(71, "class", "d-flex justify-content-center");
            __builder.OpenElement(72, "tfoot");
            __builder.OpenComponent<global::FPLSP.Components.Pagingation>(73);
            __builder.AddAttribute(74, "MetaData", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::FPLSP.Server.Data.SeedWork.MetaData>(
#nullable restore
#line 104 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ImagePages\ImageList.razor"
                                                                    MetaData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(75, "Spread", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 104 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ImagePages\ImageList.razor"
                                                                                      2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(76, "SelectedPage", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.Int32>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.Int32>(this, 
#nullable restore
#line 104 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ImagePages\ImageList.razor"
                                                                                                       SelectedPage

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n\r\n");
            __builder.OpenComponent<global::FPLSP.Components.Comfirmation>(78);
            __builder.AddAttribute(79, "ConfirmationMessage", "Are you sure to Delete?");
            __builder.AddAttribute(80, "ConfirmationTitle", "Delete Exam");
            __builder.AddAttribute(81, "ConfirmationChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.Boolean>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.Boolean>(this, 
#nullable restore
#line 115 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ImagePages\ImageList.razor"
                                                    OnConfirmationCreate 

#line default
#line hidden
#nullable disable
            )));
            __builder.AddComponentReferenceCapture(82, (__value) => {
#nullable restore
#line 115 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ImagePages\ImageList.razor"
                                                                                 DeleteConfirmation = (FPLSP.Components.Comfirmation)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 187 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ImagePages\ImageList.razor"
       
    public List<ImageCPDto> _ImageCPDtos { get; set; } = new List<ImageCPDto>();
    public MetaData MetaData { get; set; } = new MetaData();

    private ImageCPListSearchVm _imageCPListSearchVm = new ImageCPListSearchVm();

    protected Comfirmation DeleteConfirmation { get; set; }
    [Inject]
    public NavigationManager NavigationManager { get; set; }
    [Inject]
    public IImageCPRepo _imageCPRepo { get; set; }
    private Guid Id;
    public string Error { get; set; }
    protected async override Task OnInitializedAsync()
    {
        await GetTasks();
    }
    private void RedirectToDetails(Guid id)
    {

        var url = Path.Combine("/ImageDetail", id.ToString());
        NavigationManager.NavigateTo(url);
    }
    private void RedirectToUpdate(Guid id)
    {

        var url = Path.Combine("/ImageUpdate", id.ToString());
        NavigationManager.NavigateTo(url);
    }

    private async Task RedirectToDelete(Guid id)
    {
        Id = id;
        DeleteConfirmation.show();
    }

    public async Task OnConfirmationCreate(bool deleteconfirmed)
    {
        if (deleteconfirmed)
        {
            await _imageCPRepo.DeleteImageCP(Id);
            await GetTasks();
            NavigationManager.NavigateTo($"/ImageList");
        }
    }

    private async Task GetTasks()
    {
        try
        {
            var pagingResponse = await _imageCPRepo.GetImageCPList(_imageCPListSearchVm);
            _ImageCPDtos = pagingResponse.Items;
            MetaData = pagingResponse.MetaData;
        }
        catch (Exception ex)
        {
            Error = ex.Message;
        }

    }

    private async Task SelectedPage(int page)
    {
        _imageCPListSearchVm.PageNumber = page;
        await GetTasks();
    }

    public async Task Search(ImageCPListSearchVm imageCPListSearch)
    {
        _imageCPListSearchVm = imageCPListSearch;
        await GetTasks();
    }
    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
