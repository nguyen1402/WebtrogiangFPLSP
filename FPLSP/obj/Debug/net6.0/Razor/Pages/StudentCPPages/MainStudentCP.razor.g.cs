#pragma checksum "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentCPPages\MainStudentCP.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3fb272309860033d810cca827fda21e00df60693"
// <auto-generated/>
#pragma warning disable 1591
namespace FPLSP.Pages.StudentCPPages
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
#line 2 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentCPPages\MainStudentCP.razor"
using FPLSP.Components.StudentCPComponents;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentCPPages\MainStudentCP.razor"
using FPLSP.Repositories.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentCPPages\MainStudentCP.razor"
using FPLSP.Server.Data.SeedWork;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentCPPages\MainStudentCP.razor"
using FPLSP.Server.Domain.Dtos.StudentCPDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentCPPages\MainStudentCP.razor"
using FPLSP.Server.Infrastructure.ViewModels.StudentCP;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/MainStudentsCP")]
    public partial class MainStudentCP : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"row\"><div class=\"col-md-4\"><h2>Danh Sách Sinh Viên</h2></div></div>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row mt-3");
            __builder.AddMarkupContent(3, "<div class=\"col-md-2 \"><a class=\"btn btn-outline-primary\" href=\"/createstudentcp\">Thêm Sinh Viên</a></div>\r\n    <div class=\"col-md-4 \"></div>\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-md-6");
            __builder.OpenComponent<global::FPLSP.Components.StudentCPComponents.FormSearchStudent>(6);
            __builder.AddAttribute(7, "OnSearch", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::FPLSP.Server.Infrastructure.ViewModels.StudentCP.StudentCPListSearch>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::FPLSP.Server.Infrastructure.ViewModels.StudentCP.StudentCPListSearch>(this, 
#nullable restore
#line 22 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentCPPages\MainStudentCP.razor"
                                     SearchStudentCP

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "row");
#nullable restore
#line 26 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentCPPages\MainStudentCP.razor"
     if (StudentCPList != null)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(11, "table");
            __builder.AddAttribute(12, "class", "table table-hover align-middle mt-3");
            __builder.AddMarkupContent(13, "<thead class=\"table-success\"><tr><th>Ảnh</th>\r\n                    <th>Mã Sinh Viên</th>\r\n                    <th>Tên Sinh Viên</th>\r\n                    <th>Email</th>\r\n                    <th>Chức năng</th></tr></thead>\r\n            ");
            __builder.OpenElement(14, "tbody");
#nullable restore
#line 39 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentCPPages\MainStudentCP.razor"
                 foreach (var item in StudentCPList)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(15, "tr");
            __builder.OpenElement(16, "td");
            __builder.OpenElement(17, "img");
            __builder.AddAttribute(18, "src", "/Image/StudentCP/" + (
#nullable restore
#line 42 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentCPPages\MainStudentCP.razor"
                                                        item.ImageUrl

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "alt", 
#nullable restore
#line 42 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentCPPages\MainStudentCP.razor"
                                                                             item.ImageUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(20, "height", "190");
            __builder.AddAttribute(21, "width", "170");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                        ");
            __builder.OpenElement(23, "td");
#nullable restore
#line (43,30)-(43,46) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentCPPages\MainStudentCP.razor"
__builder.AddContent(24, item.StudentCode);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                        ");
            __builder.OpenElement(26, "td");
#nullable restore
#line (44,30)-(44,46) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentCPPages\MainStudentCP.razor"
__builder.AddContent(27, item.StudentName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n                        ");
            __builder.OpenElement(29, "td");
#nullable restore
#line (45,30)-(45,40) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentCPPages\MainStudentCP.razor"
__builder.AddContent(30, item.Email);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                        ");
            __builder.OpenElement(32, "td");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "dropdown");
            __builder.AddMarkupContent(35, "<a class=\"btn btn-secondary dropdown-toggle\" role=\"button\" id=\"dropdownMenuLink\" data-bs-toggle=\"dropdown\" aria-expanded=\"false\"></a>\r\n                                ");
            __builder.OpenElement(36, "ul");
            __builder.AddAttribute(37, "class", "dropdown-menu");
            __builder.AddAttribute(38, "aria-labelledby", "dropdownMenuLink");
            __builder.OpenElement(39, "li");
            __builder.OpenElement(40, "a");
            __builder.AddAttribute(41, "class", "dropdown-item");
            __builder.AddAttribute(42, "style", "cursor:pointer");
            __builder.AddAttribute(43, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 51 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentCPPages\MainStudentCP.razor"
                                                                                                  () => RedirectToDetails(item.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(44, "Chi tiết sinh viên");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                                    ");
            __builder.OpenElement(46, "li");
            __builder.OpenElement(47, "a");
            __builder.AddAttribute(48, "class", "dropdown-item");
            __builder.AddAttribute(49, "style", "cursor:pointer");
            __builder.AddAttribute(50, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 52 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentCPPages\MainStudentCP.razor"
                                                                                                  () => RedirectToUpdate(item.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(51, "Cập nhật sinh viên");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n                                    ");
            __builder.OpenElement(53, "li");
            __builder.OpenElement(54, "a");
            __builder.AddAttribute(55, "class", "dropdown-item");
            __builder.AddAttribute(56, "style", "cursor:pointer");
            __builder.AddAttribute(57, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 53 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentCPPages\MainStudentCP.razor"
                                                                                                  () => RedirectToDelete(item.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(58, "Xóa sinh viên");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 58 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentCPPages\MainStudentCP.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 61 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentCPPages\MainStudentCP.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(59, "<span>\r\n            Loading......\r\n        </span>");
#nullable restore
#line 67 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentCPPages\MainStudentCP.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n\r\n");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "row");
            __builder.OpenElement(63, "div");
            __builder.AddAttribute(64, "class", "col-11 align-self-center");
            __builder.OpenComponent<global::FPLSP.Components.Pagingation>(65);
            __builder.AddAttribute(66, "MetaData", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::FPLSP.Server.Data.SeedWork.MetaData>(
#nullable restore
#line 72 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentCPPages\MainStudentCP.razor"
                               MetaData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(67, "Spread", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 72 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentCPPages\MainStudentCP.razor"
                                                 2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(68, "SelectedPage", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.Int32>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.Int32>(this, 
#nullable restore
#line 72 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentCPPages\MainStudentCP.razor"
                                                                  SelectedPage

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 75 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentCPPages\MainStudentCP.razor"
       
    [Inject]
    public IStudentCPApiClient _iStudentCPApiClient { get; set; }
    [Inject]
    public NavigationManager NavigationManager { get; set; }
    public List<StudentCPDtos> StudentCPList { get; set; } = new List<StudentCPDtos>();

    private PagingParameters _studentParameters = new PagingParameters();
    public MetaData MetaData { get; set; } = new MetaData();
    public string Error { get; set; }

    private StudentCPListSearch studentCPListSearch = new StudentCPListSearch();

    protected async override Task OnInitializedAsync()
    {
        await GetTasks();
    }


    private void RedirectToDetails(Guid id)
    {

        var url = Path.Combine("/DetailStudentCP/", id.ToString());
        NavigationManager.NavigateTo(url);
    }
    private void RedirectToUpdate(Guid id)
    {

        var url = Path.Combine("/updatetudentcp/", id.ToString());
        NavigationManager.NavigateTo(url);
    }

    private async Task RedirectToDelete(Guid id)
    {
        var url = Path.Combine("/deleteStudentCP/", id.ToString());
        NavigationManager.NavigateTo(url);
    }
    private async Task GetTasks()
    {
        try
        {
            var pagingResponse = await _iStudentCPApiClient.GetStudentList(studentCPListSearch);
            StudentCPList = pagingResponse.Items;
            MetaData = pagingResponse.MetaData;
        }
        catch (Exception ex)
        {
            Error = ex.Message;
        }

    }

    private async Task SelectedPage(int page)
    {
        studentCPListSearch.PageNumber = page;
        await GetTasks();
    }

    public async Task SearchStudentCP(StudentCPListSearch studentCPListSearchs)
    {
        studentCPListSearch = studentCPListSearchs;
        await GetTasks();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
