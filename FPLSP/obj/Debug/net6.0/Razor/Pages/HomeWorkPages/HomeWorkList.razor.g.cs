#pragma checksum "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\HomeWorkPages\HomeWorkList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc36391b05f17f41316d3519170b21a7180013f0"
// <auto-generated/>
#pragma warning disable 1591
namespace FPLSP.Pages.HomeWorkPages
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
#line 2 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\HomeWorkPages\HomeWorkList.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\HomeWorkPages\HomeWorkList.razor"
using FPLSP.Repositories.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\HomeWorkPages\HomeWorkList.razor"
using FPLSP.Server.Data.SeedWork;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\HomeWorkPages\HomeWorkList.razor"
using FPLSP.Server.Domain.Entities.UserParts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\HomeWorkPages\HomeWorkList.razor"
using FPLSP.Server.Infrastructure.ViewModels.HomeWork;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/HomeWorklist/{idclass}/{lecuId}/{subjectId}/{specializedId}/{idlesson}")]
    public partial class HomeWorkList : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row pt-3");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "col-md-3");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-md-6");
            __builder.OpenElement(6, "a");
            __builder.AddAttribute(7, "class", "btn btn-outline-danger");
            __builder.AddAttribute(8, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\HomeWorkPages\HomeWorkList.razor"
                                                        () => Quaylai()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(9, "Quay lại");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "col-md-5");
            __builder.OpenComponent<global::FPLSP.Pages.HomeWorkPages.HomeWorkListSeach>(13);
            __builder.AddAttribute(14, "OnSearch", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::FPLSP.Server.Infrastructure.ViewModels.HomeWork.HomeWorkSeachList>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::FPLSP.Server.Infrastructure.ViewModels.HomeWork.HomeWorkSeachList>(this, 
#nullable restore
#line 15 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\HomeWorkPages\HomeWorkList.razor"
                                     SearchTask

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n    ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "col-md-3");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "row");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "col-md-6");
            __builder.OpenElement(22, "a");
            __builder.AddAttribute(23, "class", "btn btn-outline-primary");
            __builder.AddAttribute(24, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\HomeWorkPages\HomeWorkList.razor"
                                                             ()=> RedirectToCreat()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(25, "Thêm Bài Tập");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "row");
#nullable restore
#line 26 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\HomeWorkPages\HomeWorkList.razor"
     if (CPList.Count > 0)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(29, "table");
            __builder.AddAttribute(30, "class", "table");
            __builder.AddMarkupContent(31, "<thead class=\"text-center\"><tr><th scope=\"col\">Link Bài Tập</th></tr></thead>\r\n            ");
            __builder.OpenElement(32, "tbody");
            __builder.AddAttribute(33, "class", "text-center");
#nullable restore
#line 35 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\HomeWorkPages\HomeWorkList.razor"
                 foreach (var sj in CPList)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(34, "tr");
            __builder.OpenElement(35, "td");
            __builder.AddAttribute(36, "class", "align-middle w-100");
#nullable restore
#line (39,30)-(39,45) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\HomeWorkPages\HomeWorkList.razor"
__builder.AddContent(37, sj.LinkHomeWork);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                        ");
            __builder.OpenElement(39, "td");
            __builder.AddAttribute(40, "class", "text-center");
            __builder.OpenElement(41, "a");
            __builder.AddAttribute(42, "class", "btn btn-outline-danger ");
            __builder.AddAttribute(43, "type", "button");
            __builder.AddAttribute(44, "title", "Xóa");
            __builder.AddAttribute(45, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\HomeWorkPages\HomeWorkList.razor"
                                                                                                   () => RedirectToDelete(sj.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(46, "<i class=\"bi bi-dash-circle-fill\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                        ");
            __builder.OpenElement(48, "td");
            __builder.AddAttribute(49, "class", "text-center");
            __builder.OpenElement(50, "a");
            __builder.AddAttribute(51, "class", "btn btn-outline-success ");
            __builder.AddAttribute(52, "type", "button");
            __builder.AddAttribute(53, "title", "Cập nhật");
            __builder.AddAttribute(54, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 47 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\HomeWorkPages\HomeWorkList.razor"
                                                                                                         () => RedirectToUpdate(sj.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(55, "<i class=\"bi bi-pencil-square\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 52 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\HomeWorkPages\HomeWorkList.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 55 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\HomeWorkPages\HomeWorkList.razor"

    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(56, "<span>\r\n            Danh sách bài tập đang rỗng...\r\n        </span>");
#nullable restore
#line 62 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\HomeWorkPages\HomeWorkList.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n");
            __builder.OpenElement(58, "div");
            __builder.AddAttribute(59, "class", "footer text-muted");
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "class", "row mt-3");
            __builder.OpenElement(62, "span");
            __builder.OpenComponent<global::FPLSP.Components.Pagingation>(63);
            __builder.AddAttribute(64, "MetaData", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::FPLSP.Server.Data.SeedWork.MetaData>(
#nullable restore
#line 68 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\HomeWorkPages\HomeWorkList.razor"
                                   MetaData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(65, "Spread", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 68 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\HomeWorkPages\HomeWorkList.razor"
                                                     2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(66, "SelectedPage", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.Int32>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.Int32>(this, 
#nullable restore
#line 68 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\HomeWorkPages\HomeWorkList.razor"
                                                                      SelectedPage

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n");
            __builder.OpenComponent<global::FPLSP.Components.Comfirmation>(68);
            __builder.AddAttribute(69, "ConfirmationMessage", "Bạn muốn xóa link bài tập?");
            __builder.AddAttribute(70, "ConfirmationTitle", "Xóa link");
            __builder.AddAttribute(71, "ConfirmationChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.Boolean>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.Boolean>(this, 
#nullable restore
#line 75 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\HomeWorkPages\HomeWorkList.razor"
                                   OnConfirmationDelete 

#line default
#line hidden
#nullable disable
            )));
            __builder.AddComponentReferenceCapture(72, (__value) => {
#nullable restore
#line 75 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\HomeWorkPages\HomeWorkList.razor"
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
#line 76 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\HomeWorkPages\HomeWorkList.razor"
      
    [Parameter]
        public string specializedId { get; set; }
        [Parameter]
        public string lecuId { get; set; }
        [Parameter]
        public string subjectId { get; set; }

        [Parameter]
        public string idclass { get; set; }

        [Parameter]
        public string idlesson { get; set; }

        public Guid _idSubject { get; set; }

        private List<Guid> _listRemove = new List<Guid>();

        [Inject] public IToastService _toastService { get; set; }
        protected Comfirmation DeleteConfirmation { get; set; }
        public List<HomeWork> CPList { get; set; } = new List<HomeWork>();
        public MetaData MetaData { get; set; } = new MetaData();

        private HomeWorkSeachList _parameters = new HomeWorkSeachList();
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        [Inject]
        public IHomeWorkClient _iHomeWorkClient { get; set; }


        public string Error { get; set; }

        protected async override Task OnInitializedAsync()
        {
            await GetTasks();
        }
        public async Task SearchTask(HomeWorkSeachList lessonContentListSearch)
        {
            _parameters = lessonContentListSearch;
            await GetTasks();
        }
        private async Task RedirectToCreat()
        {
            var url = Path.Combine($"/Homeworkcreate/{idclass}/{subjectId}/{idlesson}/{lecuId}/{specializedId}");
            NavigationManager.NavigateTo(url);
        }
        private async Task RedirectToUpdate(Guid? idhomework)
        {
            var url = Path.Combine($"/Homeworkupdate/{idclass}/{subjectId}/{idlesson}/{lecuId}/{specializedId}/{idhomework}");
            NavigationManager.NavigateTo(url);
        }

        private async Task RedirectToDelete(Guid? idhomework)
        {
            var url = Path.Combine($"/Homeworkupdate/{idclass}/{subjectId}/{idlesson}/{lecuId}/{specializedId}/{idhomework}");
            NavigationManager.NavigateTo(url);
        }
        private async Task Quaylai()
        {
            var url = Path.Combine($"/ListLessonClassUP/{idclass}/{specializedId}/{lecuId}/{subjectId}");
            NavigationManager.NavigateTo(url);
        }

        private async Task GetTasks()
        {
            try
            {
                var pagingResponse = await _iHomeWorkClient.GetCPList(Guid.Parse(idclass), Guid.Parse(subjectId), Guid.Parse(idlesson), _parameters);
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
        public async Task RedirectToDelete(Guid id)
        {
            _idSubject = id;
            DeleteConfirmation.show();
        }
        public async Task OnConfirmationDelete(bool deleteconfirmed)
        {
            if (deleteconfirmed && _listRemove != null)
            {
                var result = await _iHomeWorkClient.DeleteCP(_idSubject);
                if (result == 1)
                {
                    _toastService.ShowSuccess("Xóa link thành công !");
                    await GetTasks();
                }
                else
                {
                    _toastService.ShowError("Ngưng hoạt động thất bại !");
                    await GetTasks();
                }
            }
        }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
