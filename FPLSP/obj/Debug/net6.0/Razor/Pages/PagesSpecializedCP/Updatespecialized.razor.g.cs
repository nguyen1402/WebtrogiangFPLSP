#pragma checksum "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Updatespecialized.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f6446ef497a3187762c2e757bdf2ea42e4d9078e"
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
#line 2 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Updatespecialized.razor"
using FPLSP.Repositories.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Updatespecialized.razor"
using FPLSP.Server.Infrastructure.ViewModels.Specialized;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Updatespecialized.razor"
           [Authorize(Roles = "AdminCore,AdminCS")]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/updatespecialized/{id}")]
    public partial class Updatespecialized : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row pt-3");
            __builder.AddMarkupContent(2, "<h2>Cập Nhật Chuyên Ngành</h2>");
#nullable restore
#line 7 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Updatespecialized.razor"
     if (ShowAuthError)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "alert alert-danger");
            __builder.AddAttribute(5, "role", "alert");
#nullable restore
#line (10,14)-(10,19) 24 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Updatespecialized.razor"
__builder.AddContent(6, Error);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 12 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Updatespecialized.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Updatespecialized.razor"
     if (model != null)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.EditForm>(7);
            __builder.AddAttribute(8, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Object>(
#nullable restore
#line 15 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Updatespecialized.razor"
                         model

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Forms.EditContext>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 15 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Updatespecialized.razor"
                                               Update

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(10, "class", "card card-body bg-light mt-5");
            __builder.AddAttribute(11, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(12);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n            ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "form-group");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "row");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "form-group pt-2 col-md-6");
                __builder2.AddMarkupContent(20, "<label for=\"name\" class=\"col-md-2 col-form-label\">Code:</label>\r\n                        ");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "col-md-10");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(23);
                __builder2.AddAttribute(24, "id", "name");
                __builder2.AddAttribute(25, "class", "form-control");
                __builder2.AddAttribute(26, "disabled", true);
                __builder2.AddAttribute(27, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 22 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Updatespecialized.razor"
                                                                                   model.SpecializedCode

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.SpecializedCode = __value, model.SpecializedCode))));
                __builder2.AddAttribute(29, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => model.SpecializedCode));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(30, "\r\n                            ");
                global::__Blazor.FPLSP.Pages.PagesSpecializedCP.Updatespecialized.TypeInference.CreateValidationMessage_0(__builder2, 31, 32, 
#nullable restore
#line 23 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Updatespecialized.razor"
                                                      () => model.SpecializedCode

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(33, "\r\n                    ");
                __builder2.OpenElement(34, "div");
                __builder2.AddAttribute(35, "class", "form-group pt-2 col-md-6");
                __builder2.AddMarkupContent(36, "<label for=\"name\" class=\"col-md-2 col-form-label\">Tên:</label>\r\n                        ");
                __builder2.OpenElement(37, "div");
                __builder2.AddAttribute(38, "class", "col-md-10");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(39);
                __builder2.AddAttribute(40, "id", "name");
                __builder2.AddAttribute(41, "class", "form-control");
                __builder2.AddAttribute(42, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 29 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Updatespecialized.razor"
                                                                                   model.SpecializationName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(43, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.SpecializationName = __value, model.SpecializationName))));
                __builder2.AddAttribute(44, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => model.SpecializationName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(45, "\r\n                            ");
                global::__Blazor.FPLSP.Pages.PagesSpecializedCP.Updatespecialized.TypeInference.CreateValidationMessage_1(__builder2, 46, 47, 
#nullable restore
#line 30 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Updatespecialized.razor"
                                                      () => model.SpecializationName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n               ");
                __builder2.OpenElement(49, "div");
                __builder2.AddAttribute(50, "class", "form-group pt-2 col-md-6");
                __builder2.AddMarkupContent(51, "<label for=\"name\" class=\"col-md-2 col-form-label\">Trạng thái:</label>\r\n                    ");
                __builder2.OpenElement(52, "div");
                __builder2.AddAttribute(53, "class", "col-md-10");
                global::__Blazor.FPLSP.Pages.PagesSpecializedCP.Updatespecialized.TypeInference.CreateInputSelect_2(__builder2, 54, 55, "form-control", 56, 
#nullable restore
#line 37 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Updatespecialized.razor"
                                                  model.Status

#line default
#line hidden
#nullable disable
                , 57, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.Status = __value, model.Status)), 58, () => model.Status, 59, (__builder3) => {
                    __builder3.AddMarkupContent(60, "<option value=\"0\">Chưa đủ sinh viên</option>\r\n                            ");
                    __builder3.AddMarkupContent(61, "<option value=\"1\">Chờ đi vào hoạt động</option>\r\n                            ");
                    __builder3.AddMarkupContent(62, "<option value=\"2\">Ngưng hoạt động</option>\r\n                            ");
                    __builder3.AddMarkupContent(63, "<option value=\"3\">Đang hoạt động</option>");
                }
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n            ");
                __builder2.AddMarkupContent(65, "<div class=\"row pt-2\"><div class=\"col-md-6 text-center\"><button type=\"submit\" class=\"btn btn-primary\">Cập nhật</button></div>\r\n                <div class=\"col-md-6 text-center\"><a href=\"/specialized\" class=\"btn btn-danger\">Quay Lại</a></div></div>");
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 55 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Updatespecialized.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 58 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\PagesSpecializedCP\Updatespecialized.razor"
       
    private SpecializedVM model;
    [Inject]
    public NavigationManager Navigation { get; set; }

    [Inject]
    public ISpecializedCPRepo _iSpecializedClient { get; set; }
    public bool ShowAuthError { get; set; }
    [Parameter]
    public string Error { get; set; }
    [Parameter]
    public string Id { get; set; }
    protected override async Task OnInitializedAsync()
    {
        var modeldb = await _iSpecializedClient.GetbyId(Guid.Empty, Guid.Parse(Id));
        model = new SpecializedVM()
            {
                SpecializedCode = modeldb.SpecializedCode,
                SpecializationName = modeldb.SpecializationName,
                Status = modeldb.Status
            };
    }
    private async Task Update()
    {
        ShowAuthError = false;
        var result = await _iSpecializedClient.Update(Guid.Empty, Guid.Parse(Id), model);

        if (result != 1)
        {
            Error = "Lỗi";
            ShowAuthError = true;
            Navigation.NavigateTo("/updatespecialized/" + Id.ToString());
        }
        else
        {
            Navigation.NavigateTo("/specialized");
        }
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.FPLSP.Pages.PagesSpecializedCP.Updatespecialized
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
