#pragma checksum "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\ResourceLinkUPComponents\ResourceLinkUPSearch.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02b1c982a194f7e88aa95ca8b3ea7f17591fe8bd"
// <auto-generated/>
#pragma warning disable 1591
namespace FPLSP.Components.ResourceLinkUPComponents
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
#line 1 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\ResourceLinkUPComponents\ResourceLinkUPSearch.razor"
using FPLSP.Server.Infrastructure.ViewModels.ResourceLinkUP;

#line default
#line hidden
#nullable disable
    public partial class ResourceLinkUPSearch : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Object>(
#nullable restore
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\ResourceLinkUPComponents\ResourceLinkUPSearch.razor"
                  resourceLinkUPSearch

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Forms.EditContext>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\ResourceLinkUPComponents\ResourceLinkUPSearch.razor"
                                                  SearchForm

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(4, "div");
                __builder2.AddAttribute(5, "class", "row pl-16");
                __builder2.AddMarkupContent(6, "<div class=\"col-lg-2\"></div>\r\n        ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "col-lg-2");
                global::__Blazor.FPLSP.Components.ResourceLinkUPComponents.ResourceLinkUPSearch.TypeInference.CreateInputSelect_0(__builder2, 9, 10, "form-select", 11, 
#nullable restore
#line 7 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\ResourceLinkUPComponents\ResourceLinkUPSearch.razor"
                                                                ()=>resourceLinkUPSearch.Status

#line default
#line hidden
#nullable disable
                , 12, 
#nullable restore
#line 7 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\ResourceLinkUPComponents\ResourceLinkUPSearch.razor"
                                                                                                          resourceLinkUPSearch.Status

#line default
#line hidden
#nullable disable
                , 13, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 7 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\ResourceLinkUPComponents\ResourceLinkUPSearch.razor"
                                                                                                                                                       (int? value)=>
            StatusSearch(value)

#line default
#line hidden
#nullable disable
                ), 14, (__builder3) => {
                    __builder3.AddMarkupContent(15, "<option value>Trạng thái</option>\r\n                ");
                    __builder3.AddMarkupContent(16, "<option value=\"0\">Không hoạt động</option>\r\n                ");
                    __builder3.AddMarkupContent(17, "<option value=\"1\">Hoạt động</option>\r\n                ");
                    __builder3.AddMarkupContent(18, "<option value=\"2\">Ngưng hoạt động</option>");
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n        ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", " col-lg-6");
                __builder2.OpenElement(22, "div");
                __builder2.AddAttribute(23, "class", "input-group mb-3");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(24);
                __builder2.AddAttribute(25, "placeholder", "Nhập tiêu đề hoặc mô tả...");
                __builder2.AddAttribute(26, "class", "form-control");
                __builder2.AddAttribute(27, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 17 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\ResourceLinkUPComponents\ResourceLinkUPSearch.razor"
                                                                                                      resourceLinkUPSearch.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => resourceLinkUPSearch.Name = __value, resourceLinkUPSearch.Name))));
                __builder2.AddAttribute(29, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => resourceLinkUPSearch.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(30, "\r\n                ");
                __builder2.AddMarkupContent(31, "<div class=\"input-group-append pl-1\"><button type=\"submit\" class=\"btn btn-primary\">Tìm kiếm</button></div>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n        \r\n        ");
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "col-lg-2");
                __builder2.OpenElement(35, "a");
                __builder2.AddAttribute(36, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\ResourceLinkUPComponents\ResourceLinkUPSearch.razor"
                          ClearSearch

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(37, "class", "btn btn-outline-success");
                __builder2.AddMarkupContent(38, "Làm mới");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 29 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Components\ResourceLinkUPComponents\ResourceLinkUPSearch.razor"
      
    [Parameter]
        public EventCallback<ResourceLinkUPListSearch> OnSearch { get; set; }

        private ResourceLinkUPListSearch resourceLinkUPSearch = new ResourceLinkUPListSearch();
        public string status { get; set; } = "";

        private async Task SearchForm(EditContext context)
        {
            await OnSearch.InvokeAsync(resourceLinkUPSearch);
        }
        private void StatusSearch(int? a)
        {
            resourceLinkUPSearch.Status = a;
            SearchForm(null);
        }
        private void ClearSearch()
        {
            resourceLinkUPSearch = new ResourceLinkUPListSearch();
            SearchForm(null);
        }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.FPLSP.Components.ResourceLinkUPComponents.ResourceLinkUPSearch
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Object __arg0, int __seq1, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "ValueExpression", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
