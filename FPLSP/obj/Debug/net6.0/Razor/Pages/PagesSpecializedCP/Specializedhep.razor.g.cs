#pragma checksum "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Specializedhep.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dd49cbe7567b631d8c11b34a270c18bb6f497a48"
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
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Specializedhep.razor"
using FPLSP.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Specializedhep.razor"
using FPLSP.Components.SpecializedCP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Specializedhep.razor"
using FPLSP.Repositories.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Specializedhep.razor"
using FPLSP.Server.Data.SeedWork;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Specializedhep.razor"
using FPLSP.Server.Domain.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Specializedhep.razor"
using FPLSP.Server.Infrastructure.ViewModels.Specialized;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Specializedhep.razor"
           [Authorize(Roles = "AdminCore,AdminCS")]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/specializedhep/{idBo}")]
    public partial class Specializedhep : global::Microsoft.AspNetCore.Components.ComponentBase
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
#line 15 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Specializedhep.razor"
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
#line 18 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Specializedhep.razor"
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
#line 21 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Specializedhep.razor"
 if (CPList == null || CPList.Count == 0)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<global::FPLSP.Components.LoadingIndicator>(14);
            __builder.CloseComponent();
#nullable restore
#line 24 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Specializedhep.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "row");
            __builder.OpenElement(17, "table");
            __builder.AddAttribute(18, "class", "table");
            __builder.AddMarkupContent(19, "<thead class=\"text-center\"><tr><th scope=\"col\">Mã</th>\r\n                    <th scope=\"col\">Tên</th>\r\n                    <th scope=\"col\">Trạng thái</th>\r\n                    <th scope=\"col\">Chức năng</th></tr></thead>\r\n            ");
            __builder.OpenElement(20, "tbody");
            __builder.AddAttribute(21, "class", "text-center");
#nullable restore
#line 38 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Specializedhep.razor"
                 foreach (var sj in CPList)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(22, "tr");
            __builder.OpenElement(23, "td");
            __builder.AddAttribute(24, "class", "align-middle");
#nullable restore
#line (43,30)-(43,48) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Specializedhep.razor"
__builder.AddContent(25, sj.SpecializedCode);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                        ");
            __builder.OpenElement(27, "td");
            __builder.AddAttribute(28, "class", "align-middle");
#nullable restore
#line (46,30)-(46,51) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Specializedhep.razor"
__builder.AddContent(29, sj.SpecializationName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 49 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Specializedhep.razor"
                         if (@sj.Status == 0)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(30, "<td class=\"align-middle\">\r\n                                Chưa đủ sinh viên\r\n                            </td>");
#nullable restore
#line 54 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Specializedhep.razor"
                        }
                        else if (@sj.Status == 1)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(31, "<td class=\"align-middle\">\r\n                                Chờ đi vào hoạt động\r\n                            </td>");
#nullable restore
#line 60 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Specializedhep.razor"
                        }
                        else if (@sj.Status == 2)
                        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(32, "<td class=\"align-middle\">\r\n                                Ngưng hoạt động\r\n                            </td>");
#nullable restore
#line 66 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Specializedhep.razor"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(33, "<td class=\"align-middle\">\r\n                                Đang hoạt động\r\n                            </td>");
#nullable restore
#line 72 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Specializedhep.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(34, "td");
            __builder.AddAttribute(35, "class", "align-middle");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "dropdown");
            __builder.AddMarkupContent(38, "<a class=\"dropdown-toggle\" role=\"button\" id=\"dropdownMenuLink\" data-bs-toggle=\"dropdown\" aria-expanded=\"false\"></a>\r\n                                ");
            __builder.OpenElement(39, "ul");
            __builder.AddAttribute(40, "class", "dropdown-menu");
            __builder.AddAttribute(41, "aria-labelledby", "dropdownMenuLink");
            __builder.OpenElement(42, "li");
            __builder.OpenElement(43, "a");
            __builder.AddAttribute(44, "class", "dropdown-item");
            __builder.AddAttribute(45, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 79 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Specializedhep.razor"
                                                                           () => RedirectToDetails(sj.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(46, "Chi tiết ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                                    ");
            __builder.OpenElement(48, "li");
            __builder.OpenElement(49, "a");
            __builder.AddAttribute(50, "class", "dropdown-item");
            __builder.AddAttribute(51, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 80 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Specializedhep.razor"
                                                                           () => RedirectToUpdate(sj.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(52, "Cập nhật ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                                    ");
            __builder.OpenElement(54, "li");
            __builder.OpenElement(55, "a");
            __builder.AddAttribute(56, "class", "dropdown-item");
            __builder.AddAttribute(57, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 81 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Specializedhep.razor"
                                                                           () => RedirectToDelete(sj.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(58, "Xóa ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                                    ");
            __builder.OpenElement(60, "li");
            __builder.OpenElement(61, "a");
            __builder.AddAttribute(62, "class", "dropdown-item");
            __builder.AddAttribute(63, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 82 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Specializedhep.razor"
                                                                           () => RedirectToLectuterSpecialized(sj.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(64, "Danh sách giảng viên ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 87 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Specializedhep.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n\r\n        }\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n");
            __builder.AddMarkupContent(67, "<div class=\"col-md-2 float-end\"><a class=\"btn btn-outline-primary\" href=\"specialized\">Về chuyên ngành</a></div>\r\n");
            __builder.OpenElement(68, "tfoot");
            __builder.OpenComponent<global::FPLSP.Components.Pagingation>(69);
            __builder.AddAttribute(70, "MetaData", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::FPLSP.Server.Data.SeedWork.MetaData>(
#nullable restore
#line 97 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Specializedhep.razor"
                           MetaData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(71, "Spread", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 97 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Specializedhep.razor"
                                             2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(72, "SelectedPage", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.Int32>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.Int32>(this, 
#nullable restore
#line 97 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Specializedhep.razor"
                                                              SelectedPage

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 99 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Specializedhep.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 102 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Specializedhep.razor"
       
    [Parameter]
    public string idBo { get; set; }
    public List<SpecializedDto> CPList { get; set; } = new List<SpecializedDto>();
    public MetaData MetaData { get; set; } = new MetaData();

    private SpecializedListSearch _parameters = new SpecializedListSearch();
    [Inject]
    public NavigationManager NavigationManager { get; set; }
    [Inject]
    public ISpecializedCPRepo _iSpecializedClient { get; set; }

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

        var url = Path.Combine("/detailspecializedhep/", idBo.ToString(), id.ToString());
        NavigationManager.NavigateTo(url);
    }
    private void RedirectToCreate()
    {

        var url = Path.Combine("/createspecializedhep/", idBo.ToString());
        NavigationManager.NavigateTo(url);
    }
    private void RedirectToUpdate(Guid id)
    {

        var url = Path.Combine("/updatespecializedhep/", idBo.ToString(), id.ToString());
        NavigationManager.NavigateTo(url);
    }

    private async Task RedirectToDelete(Guid id)
    {
        var url = Path.Combine("/deletespecializedhep/", idBo.ToString(), id.ToString());
        NavigationManager.NavigateTo(url);
    }
    private void RedirectToLectuterSpecialized(Guid id)
    {

        var url = Path.Combine("/lectuterSpecialized/", idBo.ToString(), id.ToString());
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