#pragma checksum "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LessonUPPages\ListLessonClassUP.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "537739bbf15253df167297059f5469c444b65890"
// <auto-generated/>
#pragma warning disable 1591
namespace FPLSP.Pages.LessonUPPages
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
#line 2 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LessonUPPages\ListLessonClassUP.razor"
using FPLSP.Repositories.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LessonUPPages\ListLessonClassUP.razor"
using FPLSP.Server.Data.SeedWork;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LessonUPPages\ListLessonClassUP.razor"
using FPLSP.Server.Domain.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LessonUPPages\ListLessonClassUP.razor"
using FPLSP.Server.Infrastructure.ViewModels.LessonUP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LessonUPPages\ListLessonClassUP.razor"
           [Authorize(Roles = "AdminCore,AdminCS")]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/ListLessonClassUP/{idclass}/{specializedId}/{lecuId}/{subjectId}")]
    public partial class ListLessonClassUP : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "col-md-2 text-center");
            __builder.OpenElement(4, "a");
            __builder.AddAttribute(5, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LessonUPPages\ListLessonClassUP.razor"
                     Quaylai

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(6, "class", "btn btn-danger");
            __builder.AddMarkupContent(7, "Quay lại");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n    ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "col-lg-10");
            __builder.OpenComponent<global::FPLSP.Pages.LessonUPPages.ListLessonClassUPSeach>(11);
            __builder.AddAttribute(12, "OnSearch", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::FPLSP.Server.Infrastructure.ViewModels.LessonUP.LessonUPListSearch>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::FPLSP.Server.Infrastructure.ViewModels.LessonUP.LessonUPListSearch>(this, 
#nullable restore
#line 14 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LessonUPPages\ListLessonClassUP.razor"
                                          SearchLessonUP

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 17 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LessonUPPages\ListLessonClassUP.razor"
 if (_lstLessonUPs == null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<global::FPLSP.Components.LoadingIndicator>(13);
            __builder.CloseComponent();
#nullable restore
#line 20 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LessonUPPages\ListLessonClassUP.razor"
}
else
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LessonUPPages\ListLessonClassUP.razor"
     if (_lstLessonUPs.Any())
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "mt-3");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "card text-center");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "card-body");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "row");
#nullable restore
#line 29 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LessonUPPages\ListLessonClassUP.razor"
                         if (_lstLessonUPs != null)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LessonUPPages\ListLessonClassUP.razor"
                             foreach (var item in _lstLessonUPs.OrderBy(c => c.LessonCode))
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "col-lg-3 mb-5 single-product-item");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "card border-2 border-info");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "row ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "card-body text-center");
            __builder.OpenElement(30, "h5");
            __builder.AddAttribute(31, "class", "my-3");
            __builder.AddMarkupContent(32, "Tên bài : ");
#nullable restore
#line (37,77)-(37,92) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LessonUPPages\ListLessonClassUP.razor"
__builder.AddContent(33, item.LessonName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                                                ");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "d-flex justify-content-center mb-2");
            __builder.OpenElement(37, "div");
            __builder.AddAttribute(38, "class", "row");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "col-md-6");
            __builder.OpenElement(41, "a");
            __builder.AddAttribute(42, "class", "btn btn-info ");
            __builder.AddAttribute(43, "type", "button");
            __builder.AddAttribute(44, "title", "Xét thời gian");
            __builder.AddAttribute(45, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LessonUPPages\ListLessonClassUP.razor"
                                                                                                                                   () => SubmitHomeWorksCreate(item.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(46, "<i class=\"bi bi-alarm\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n                                                        ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "col-md-6");
            __builder.OpenElement(50, "a");
            __builder.AddAttribute(51, "class", "btn btn-success ");
            __builder.AddAttribute(52, "type", "button");
            __builder.AddAttribute(53, "title", "Thêm bài tập");
            __builder.AddAttribute(54, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 46 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LessonUPPages\ListLessonClassUP.razor"
                                                                                                                                     () => RedirectToThembaitap(item.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(55, "<i class=\"bi bi-plus-circle-fill\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 56 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LessonUPPages\ListLessonClassUP.razor"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LessonUPPages\ListLessonClassUP.razor"
                             
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(56, "<h3>Danh sách rỗng !</h3>");
#nullable restore
#line 61 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LessonUPPages\ListLessonClassUP.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                ");
            __builder.OpenElement(58, "div");
            __builder.AddAttribute(59, "class", "card-footer text-muted");
            __builder.OpenElement(60, "div");
            __builder.AddAttribute(61, "class", "row mt-3");
            __builder.OpenElement(62, "span");
            __builder.OpenComponent<global::FPLSP.Components.Pagingation>(63);
            __builder.AddAttribute(64, "MetaData", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::FPLSP.Server.Data.SeedWork.MetaData>(
#nullable restore
#line 68 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LessonUPPages\ListLessonClassUP.razor"
                                                   MetaData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(65, "Spread", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 68 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LessonUPPages\ListLessonClassUP.razor"
                                                                     2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(66, "SelectedPage", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.Int32>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.Int32>(this, 
#nullable restore
#line 68 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LessonUPPages\ListLessonClassUP.razor"
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
#nullable restore
#line 75 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LessonUPPages\ListLessonClassUP.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(67, "<h5> Không tìm thấy danh sách bài học UP</h5>");
#nullable restore
#line 79 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LessonUPPages\ListLessonClassUP.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 79 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LessonUPPages\ListLessonClassUP.razor"
     
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 81 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LessonUPPages\ListLessonClassUP.razor"
      

    [Parameter]
        public string specializedId { get; set; }
        [Parameter]
        public string lecuId { get; set; }
        [Parameter]
        public string subjectId { get; set; }

        [Parameter]
        public string idclass { get; set; }

        [Inject] private ILessonUPRepo _LessonUPRepo { get; set; }
        [Inject] public NavigationManager NavigationManager { get; set; }
        [Inject] private ISubjectUPRepo _subjectUPRepo { get; set; }

        private List<SubjectDto> _lstsubjectDtos { get; set; }

        public MetaData MetaData { get; set; } = new MetaData();

        private List<LessonUPViewModel> _lstLessonUPs;

        private LessonUPListSearch _LessonUPSearch = new LessonUPListSearch();

        [CascadingParameter]
        private Error Error { get; set; }

        private Guid deleteID { get; set; }

        protected Comfirmation DeleteConfirmation { get; set; }

        protected override async Task OnInitializedAsync()
        {
            _lstsubjectDtos = await _subjectUPRepo.GetAllSubjectAsync();
            await GetTasks();
        }

        public async Task SearchLessonUP(LessonUPListSearch LessonUPSearch)
        {
            _LessonUPSearch = LessonUPSearch;
            await GetTasks();
        }

        public void OnDelete(Guid id)
        {
            deleteID = id;
            DeleteConfirmation.show();
        }

        public async Task OnConfirmDelete(bool deleteConfirmed)
        {
            if (deleteConfirmed)
            {
                var result = await _LessonUPRepo.Delete(deleteID);
                if (result)
                {
                    await GetTasks();
                }
            }
        }

        private async Task GetTasks()
        {
            try
            {
                var pagingResponse =  await _LessonUPRepo.GetAll();
                _lstLessonUPs =  pagingResponse.Where(c => c.SubjectId == Guid.Parse(subjectId)).OrderBy(c =>Convert.ToInt32(c.LessonName.Substring(3,3))).ToList();
                //MetaData = pagingResponse.MetaData;
            }
            catch (Exception ex)
            {
                Error.ProcessError(ex);
            }
        }

        private async Task SelectedPage(int page)
        {
            _LessonUPSearch.PageNumber = page;
            await GetTasks();
        }

        private void SubmitHomeWorksCreate(Guid idlesson)
        {

            var url = Path.Combine($"/SubmitHomeWorksCreate/{idclass}/{lecuId}/{subjectId}/{specializedId}/{idlesson}");
            NavigationManager.NavigateTo(url);
        }
        private void RedirectToChitiet(Guid idlesson)
        {

            var url = Path.Combine($"/SubmitHomeWorksList/{idclass}/{lecuId}/{subjectId}/{specializedId}/{idlesson}");
            NavigationManager.NavigateTo(url);
        }
        private void RedirectToThembaitap(Guid idlesson)
        {

            var url = Path.Combine($"/HomeWorklist/{idclass}/{lecuId}/{subjectId}/{specializedId}/{idlesson}");
            NavigationManager.NavigateTo(url);
        }
        private void Quaylai()
        {
            var url = Path.Combine($"/StudentStatisticsChitiet/{idclass}/{specializedId}/{lecuId}/{subjectId}");
            NavigationManager.NavigateTo(url);
        }
        

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591