#pragma checksum "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializeUPPages\SpecializedhepUP.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a24b2088763e63d12fd3e69cc3c7b8473c13959a"
// <auto-generated/>
#pragma warning disable 1591
namespace FPLSP.Pages.SpecializeUPPages
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
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializeUPPages\SpecializedhepUP.razor"
using FPLSP.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializeUPPages\SpecializedhepUP.razor"
using FPLSP.Components.SpecializedCP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializeUPPages\SpecializedhepUP.razor"
using FPLSP.Repositories.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializeUPPages\SpecializedhepUP.razor"
using FPLSP.Server.Data.SeedWork;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializeUPPages\SpecializedhepUP.razor"
using FPLSP.Server.Domain.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializeUPPages\SpecializedhepUP.razor"
using FPLSP.Server.Infrastructure.ViewModels.Specialized;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/specializedhepUP/{idBo}")]
    public partial class SpecializedhepUP : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row pt-3");
            __builder.AddMarkupContent(2, "<div class=\"col-md-4\"><h2>Chuyên ngành hẹp</h2></div>\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-md-6");
            __builder.OpenComponent<global::FPLSP.Components.SpecializedCP.SpecializedSearch>(5);
            __builder.AddAttribute(6, "OnSearch", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::FPLSP.Server.Infrastructure.ViewModels.Specialized.SpecializedListSearch>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::FPLSP.Server.Infrastructure.ViewModels.Specialized.SpecializedListSearch>(this, 
#nullable restore
#line 14 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializeUPPages\SpecializedhepUP.razor"
                                     SearchTask

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "col-md-2 float-end");
            __builder.OpenElement(10, "a");
            __builder.AddAttribute(11, "class", "btn btn-outline-primary");
            __builder.AddAttribute(12, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializeUPPages\SpecializedhepUP.razor"
                                                     () => RedirectToCreate()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(13, "+ Chuyên ngành hẹp");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 20 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializeUPPages\SpecializedhepUP.razor"
     if (CPList == null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<global::FPLSP.Components.LoadingIndicator>(14);
            __builder.CloseComponent();
#nullable restore
#line 23 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializeUPPages\SpecializedhepUP.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "row");
#nullable restore
#line 27 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializeUPPages\SpecializedhepUP.razor"
         if (CPList.Count == 0)
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(17, "<span>Danh sách chuyên ngành hẹp rỗng</span>");
#nullable restore
#line 30 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializeUPPages\SpecializedhepUP.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(18, "table");
            __builder.AddAttribute(19, "class", "table");
            __builder.AddMarkupContent(20, "<thead class=\"text-center\"><tr><th scope=\"col\">Mã</th>\r\n                        <th scope=\"col\">Tên</th>\r\n                        <th scope=\"col\">Trạng thái</th>\r\n                        <th scope=\"col\">Chức năng</th></tr></thead>\r\n                ");
            __builder.OpenElement(21, "tbody");
            __builder.AddAttribute(22, "class", "text-center");
#nullable restore
#line 43 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializeUPPages\SpecializedhepUP.razor"
                     foreach (var sj in CPList)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(23, "tr");
            __builder.OpenElement(24, "td");
            __builder.AddAttribute(25, "class", "align-middle");
#nullable restore
#line (48,34)-(48,52) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializeUPPages\SpecializedhepUP.razor"
__builder.AddContent(26, sj.SpecializedCode);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                            ");
            __builder.OpenElement(28, "td");
            __builder.AddAttribute(29, "class", "align-middle");
#nullable restore
#line (51,34)-(51,55) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializeUPPages\SpecializedhepUP.razor"
__builder.AddContent(30, sj.SpecializationName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 54 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializeUPPages\SpecializedhepUP.razor"
                             if (@sj.Status == 0)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(31, "<td class=\"align-middle\">\r\n                                    Chưa đủ sinh viên\r\n                                </td>");
#nullable restore
#line 59 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializeUPPages\SpecializedhepUP.razor"
                            }
                            else if (@sj.Status == 1)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(32, "<td class=\"align-middle\">\r\n                                    Chờ đi vào hoạt động\r\n                                </td>");
#nullable restore
#line 65 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializeUPPages\SpecializedhepUP.razor"
                            }
                            else if (@sj.Status == 2)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(33, "<td class=\"align-middle\">\r\n                                    Ngưng hoạt động\r\n                                </td>");
#nullable restore
#line 71 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializeUPPages\SpecializedhepUP.razor"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(34, "<td class=\"align-middle\">\r\n                                    Đang hoạt động\r\n                                </td>");
#nullable restore
#line 77 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializeUPPages\SpecializedhepUP.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(35, "td");
            __builder.AddAttribute(36, "class", "align-middle");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "dropdown");
            __builder.AddMarkupContent(39, "<a class=\"dropdown-toggle\" role=\"button\" id=\"dropdownMenuLink\" data-bs-toggle=\"dropdown\" aria-expanded=\"false\"></a>\r\n                                    ");
            __builder.OpenElement(40, "ul");
            __builder.AddAttribute(41, "class", "dropdown-menu");
            __builder.AddAttribute(42, "aria-labelledby", "dropdownMenuLink");
            __builder.OpenElement(43, "li");
            __builder.OpenElement(44, "a");
            __builder.AddAttribute(45, "class", "dropdown-item");
            __builder.AddAttribute(46, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 86 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializeUPPages\SpecializedhepUP.razor"
                                                                               () => RedirectToDetails(sj.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(47, "Chi tiết ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                                        ");
            __builder.OpenElement(49, "li");
            __builder.OpenElement(50, "a");
            __builder.AddAttribute(51, "class", "dropdown-item");
            __builder.AddAttribute(52, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 87 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializeUPPages\SpecializedhepUP.razor"
                                                                               () => RedirectToUpdate(sj.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(53, "Cập nhật ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                                        ");
            __builder.OpenElement(55, "li");
            __builder.OpenElement(56, "a");
            __builder.AddAttribute(57, "class", "dropdown-item");
            __builder.AddAttribute(58, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 88 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializeUPPages\SpecializedhepUP.razor"
                                                                               () => RedirectToDelete(sj.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(59, "Xóa ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n                                        ");
            __builder.OpenElement(61, "li");
            __builder.OpenElement(62, "a");
            __builder.AddAttribute(63, "class", "dropdown-item");
            __builder.AddAttribute(64, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 89 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializeUPPages\SpecializedhepUP.razor"
                                                                               () => RedirectToLectuterSpecialized(sj.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(65, "Danh sách giảng viên ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 94 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializeUPPages\SpecializedhepUP.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 97 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializeUPPages\SpecializedhepUP.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n    ");
            __builder.AddMarkupContent(67, "<div class=\"col-md-2 float-end\"><a class=\"btn btn-outline-primary\" href=\"specializedUP\">Về chuyên ngành</a></div>\r\n    ");
            __builder.OpenElement(68, "tfoot");
            __builder.OpenComponent<global::FPLSP.Components.Pagingation>(69);
            __builder.AddAttribute(70, "MetaData", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::FPLSP.Server.Data.SeedWork.MetaData>(
#nullable restore
#line 103 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializeUPPages\SpecializedhepUP.razor"
                               MetaData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(71, "Spread", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 103 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializeUPPages\SpecializedhepUP.razor"
                                                 2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(72, "SelectedPage", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.Int32>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.Int32>(this, 
#nullable restore
#line 103 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializeUPPages\SpecializedhepUP.razor"
                                                                  SelectedPage

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 105 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializeUPPages\SpecializedhepUP.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 107 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializeUPPages\SpecializedhepUP.razor"
       
    [Parameter]
    public string idBo { get; set; }
    public List<SpecializedDto> CPList { get; set; } = new List<SpecializedDto>();
    public MetaData MetaData { get; set; } = new MetaData();

    private SpecializedListSearch _parameters = new SpecializedListSearch();
    [Inject]
    public NavigationManager NavigationManager { get; set; }
    [Inject]
    public ISpecializedUPRepo _iSpecializedClient { get; set; }

    public string Error { get; set; }
    protected async override Task OnInitializedAsync()
    {
        await GetTasks();
    }

    public async Task SearchTask(SpecializedListSearch specializedListSearch)
    {
        _parameters = specializedListSearch;
        await GetTasks();
    }
    private void RedirectToDetails(Guid id)
    {

        var url = Path.Combine("/detailspecializedhepUP/", idBo.ToString(), id.ToString());
        NavigationManager.NavigateTo(url);
    }
    private void RedirectToCreate()
    {

        var url = Path.Combine("/createspecializedhepUP/", idBo.ToString());
        NavigationManager.NavigateTo(url);
    }
    private void RedirectToUpdate(Guid id)
    {

        var url = Path.Combine("/updatespecializedhepUP/", idBo.ToString(), id.ToString());
        NavigationManager.NavigateTo(url);
    }

    private async Task RedirectToDelete(Guid id)
    {
        var url = Path.Combine("/deletespecializedhepUP/", idBo.ToString(), id.ToString());
        NavigationManager.NavigateTo(url);
    }
    private void RedirectToLectuterSpecialized(Guid id)
    {

        var url = Path.Combine("/lectuterSpecializedUP/", idBo.ToString(), id.ToString());
        NavigationManager.NavigateTo(url);
    }
    private async Task GetTasks()
    {
        try
        {
            var pagingResponse = await _iSpecializedClient.Gets(Guid.Parse(idBo), _parameters);
            CPList = pagingResponse.Items;
            MetaData = pagingResponse.MetaData;
        }
        catch (Exception ex)
        {
            Error = ex.Message;
        }

    }

    private async Task SelectedPage(int page)
    {
        _parameters.PageNumber = page;
        await GetTasks();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591