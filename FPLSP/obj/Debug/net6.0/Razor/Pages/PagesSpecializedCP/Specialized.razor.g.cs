#pragma checksum "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Specialized.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd44357fbafda0e80807ba8edb4323349be8f5a0"
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
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Specialized.razor"
using FPLSP.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Specialized.razor"
using FPLSP.Repositories.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Specialized.razor"
using FPLSP.Server.Data.SeedWork;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Specialized.razor"
using FPLSP.Server.Domain.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Specialized.razor"
using FPLSP.Server.Infrastructure.ViewModels.Specialized;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Specialized.razor"
           [Authorize(Roles = "AdminCore,AdminCS")]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/specialized")]
    public partial class Specialized : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<div class=\"row pt-3\"><div class=\"col-md-4\"><h3>Chuyên ngành</h3></div>\r\n    <div class=\"col-md-2 float-end\"><a class=\"btn btn-outline-primary\" href=\"/createspecialized\">+ Chuyên ngành</a></div></div>");
#nullable restore
#line 18 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Specialized.razor"
         if (CPListAll.Where(c => c.Level == 0).ToList() == null || CPListAll == null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<global::FPLSP.Components.LoadingIndicator>(1);
            __builder.CloseComponent();
#nullable restore
#line 21 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Specialized.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
#nullable restore
#line 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Specialized.razor"
         if (CPListAll.Where(c => c.Level == 0).ToList().Count == 0)
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(4, "<span>Danh sách chuyên ngành rỗng</span>");
#nullable restore
#line 28 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Specialized.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(5, "<div class=\"col-md-2\"></div>");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-md-8");
            __builder.OpenComponent<global::MudBlazor.MudPaper>(8);
            __builder.AddAttribute(9, "Width", "100%");
            __builder.AddAttribute(10, "Elevation", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 36 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Specialized.razor"
                                                  0

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<global::MudBlazor.MudTreeView<string>>(12);
                __builder2.AddAttribute(13, "ExpandOnClick", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 37 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Specialized.razor"
                                                           true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(14, "Hover", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Boolean>(
#nullable restore
#line 37 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Specialized.razor"
                                                                        true

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
#nullable restore
#line 38 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Specialized.razor"
                         foreach (var item in CPListAll.Where(c => c.Level == 0).ToList())
                        {

#line default
#line hidden
#nullable disable
                    global::__Blazor.FPLSP.Pages.PagesSpecializedCP.Specialized.TypeInference.CreateMudTreeViewItem_0(__builder3, 16, 17, 
#nullable restore
#line 40 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Specialized.razor"
                                                      item.SpecializationName

#line default
#line hidden
#nullable disable
                    , 18, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 40 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Specialized.razor"
                                                                                          () => RedirectToSubject(item.Id)

#line default
#line hidden
#nullable disable
                    ), 19, 
#nullable restore
#line 40 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Specialized.razor"
                                                                                                                                   Icons.Custom.FileFormats.FileVideo

#line default
#line hidden
#nullable disable
                    , 20, 
#nullable restore
#line 40 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Specialized.razor"
                                                                                                                                                                                 CPListAll.Where(c => c.Level == 1 && c.IdSpeciality == item.Id).ToList().Count().ToString()

#line default
#line hidden
#nullable disable
                    , 21, (__builder4) => {
#nullable restore
#line 41 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Specialized.razor"
                                 foreach (var item1 in CPListAll.Where(c => c.Level == 1 && c.IdSpeciality == item.Id).ToList())
                    {

#line default
#line hidden
#nullable disable
                        global::__Blazor.FPLSP.Pages.PagesSpecializedCP.Specialized.TypeInference.CreateMudTreeViewItem_1(__builder4, 22, 23, 
#nullable restore
#line 43 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Specialized.razor"
                                                  item1.SpecializationName

#line default
#line hidden
#nullable disable
                        , 24, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Specialized.razor"
                                                                                       () => RedirectToSubject(item1.Id)

#line default
#line hidden
#nullable disable
                        ), 25, 
#nullable restore
#line 43 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Specialized.razor"
                                                                                                                                 Icons.Custom.FileFormats.FileDocument

#line default
#line hidden
#nullable disable
                        , 26, 
#nullable restore
#line 43 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Specialized.razor"
                                                                                                                                                                                  CPListAll.Where(c => c.Level == 2 && c.IdSpeciality == item1.Id).ToList().Count().ToString()

#line default
#line hidden
#nullable disable
                        , 27, (__builder5) => {
#nullable restore
#line 44 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Specialized.razor"
                             foreach (var item2 in CPListAll.Where(c => c.Level == 2 && c.IdSpeciality == item1.Id).ToList())
                        {

#line default
#line hidden
#nullable disable
                            global::__Blazor.FPLSP.Pages.PagesSpecializedCP.Specialized.TypeInference.CreateMudTreeViewItem_2(__builder5, 28, 29, 
#nullable restore
#line 46 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Specialized.razor"
                                                      item2.SpecializationName

#line default
#line hidden
#nullable disable
                            , 30, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 46 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Specialized.razor"
                                                                                           () => RedirectToSubject(item2.Id)

#line default
#line hidden
#nullable disable
                            ), 31, 
#nullable restore
#line 46 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Specialized.razor"
                                                                                                                                     Icons.Custom.FileFormats.FileDocument

#line default
#line hidden
#nullable disable
                            , 32, 
#nullable restore
#line 46 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Specialized.razor"
                                                                                                                                                                                      CPListAll.Where(c => c.Level == 2 && c.IdSpeciality == item2.Id).ToList().Count().ToString()

#line default
#line hidden
#nullable disable
                            );
#nullable restore
#line 47 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Specialized.razor"
                        }

#line default
#line hidden
#nullable disable
                        }
                        );
#nullable restore
#line 49 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Specialized.razor"
                    }

#line default
#line hidden
#nullable disable
                    }
                    );
#nullable restore
#line 51 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Specialized.razor"
                        }

#line default
#line hidden
#nullable disable
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "<div class=\"col-md-2\"></div>");
#nullable restore
#line 58 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Specialized.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 60 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Specialized.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 76 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Specialized.razor"
       
    public List<SpecializedDto> CPList { get; set; } = new List<SpecializedDto>();
    public List<SpecializedDto> CPListAll { get; set; } = new List<SpecializedDto>();
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
        await GetTasksAll();


    }

    public async Task SearchTask(SpecializedListSearch specializedListSearch)
    {
        _parameters = specializedListSearch;
        await GetTasks();
    }

    private void RedirectToSubject(Guid id)
    {

        var url = Path.Combine("/subjects/", id.ToString());
        NavigationManager.NavigateTo(url, true);
    }
    //private void RedirectToDetails(Guid id)
    //{

    //    var url = Path.Combine("/detailspecialized/", id.ToString());
    //    NavigationManager.NavigateTo(url);
    //}
    //private void RedirectToUpdate(Guid id)
    //{

    //    var url = Path.Combine("/updatespecialized/", id.ToString());
    //    NavigationManager.NavigateTo(url);
    //}

    //private async Task RedirectToDelete(Guid id)
    //{
    //    var url = Path.Combine("/deletespecialized/", id.ToString());
    //    NavigationManager.NavigateTo(url);
    //}
    //private void RedirectToSpeccializedhep(Guid id)
    //{

    //    var url = Path.Combine("/specializedhep/", id.ToString());
    //    NavigationManager.NavigateTo(url);
    //}
    private async Task GetTasks()
    {
        try
        {
            var pagingResponse = await _iSpecializedClient.Gets(Guid.Empty, _parameters);
            CPList = pagingResponse.Items;
            MetaData = pagingResponse.MetaData;
        }
        catch (Exception ex)
        {
            Error = ex.Message;
        }

    }
    private async Task GetTasksAll()
    {
        try
        {
            CPListAll = await _iSpecializedClient.GetAll();
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
namespace __Blazor.FPLSP.Pages.PagesSpecializedCP.Specialized
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTreeViewItem_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, T __arg0, int __seq1, global::System.Object __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::MudBlazor.MudTreeViewItem<T>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "onclick", __arg1);
        __builder.AddAttribute(__seq2, "Icon", __arg2);
        __builder.AddAttribute(__seq3, "EndText", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateMudTreeViewItem_1<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, T __arg0, int __seq1, global::System.Object __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::MudBlazor.MudTreeViewItem<T>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "onclick", __arg1);
        __builder.AddAttribute(__seq2, "Icon", __arg2);
        __builder.AddAttribute(__seq3, "EndText", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateMudTreeViewItem_2<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, T __arg0, int __seq1, global::System.Object __arg1, int __seq2, global::System.String __arg2, int __seq3, global::System.String __arg3)
        {
        __builder.OpenComponent<global::MudBlazor.MudTreeViewItem<T>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "onclick", __arg1);
        __builder.AddAttribute(__seq2, "Icon", __arg2);
        __builder.AddAttribute(__seq3, "EndText", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
