#pragma checksum "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializeUPPages\CreatespecializedhepUP.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72f12b9114267fb5307193947641f60743aa4de3"
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
#line 2 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializeUPPages\CreatespecializedhepUP.razor"
using FPLSP.Repositories.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializeUPPages\CreatespecializedhepUP.razor"
using FPLSP.Server.Infrastructure.ViewModels.Specialized;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/createspecializedhepUP/{id}")]
    public partial class CreatespecializedhepUP : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row pt-3");
            __builder.AddMarkupContent(2, "<h2>Th??m chuy??n ng??nh h???p</h2>");
#nullable restore
#line 7 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializeUPPages\CreatespecializedhepUP.razor"
     if (ShowAuthError)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "alert alert-danger");
            __builder.AddAttribute(5, "role", "alert");
#nullable restore
#line (10,14)-(10,19) 24 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializeUPPages\CreatespecializedhepUP.razor"
__builder.AddContent(6, Error);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 12 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializeUPPages\CreatespecializedhepUP.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.EditForm>(7);
            __builder.AddAttribute(8, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Object>(
#nullable restore
#line 13 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializeUPPages\CreatespecializedhepUP.razor"
                     model

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Forms.EditContext>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 13 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializeUPPages\CreatespecializedhepUP.razor"
                                           Create

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(10, "class", "card card-body bg-light mt-5");
            __builder.AddAttribute(11, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(12);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n        ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "form-group");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "row");
                __builder2.OpenElement(18, "div");
                __builder2.AddAttribute(19, "class", "form-group pt-2 col-md-6");
                __builder2.AddMarkupContent(20, "<label for=\"name\" class=\"col-md-2 col-form-label\">T??n:</label>\r\n                    ");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "col-md-10");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(23);
                __builder2.AddAttribute(24, "id", "name");
                __builder2.AddAttribute(25, "class", "form-control");
                __builder2.AddAttribute(26, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 20 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializeUPPages\CreatespecializedhepUP.razor"
                                                                               model.SpecializationName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.SpecializationName = __value, model.SpecializationName))));
                __builder2.AddAttribute(28, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => model.SpecializationName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(29, "\r\n                        ");
                global::__Blazor.FPLSP.Pages.SpecializeUPPages.CreatespecializedhepUP.TypeInference.CreateValidationMessage_0(__builder2, 30, 31, 
#nullable restore
#line 21 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializeUPPages\CreatespecializedhepUP.razor"
                                                  () => model.SpecializationName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n                ");
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "form-group pt-2 col-md-6");
                __builder2.AddMarkupContent(35, "<label for=\"name\" class=\"col-md-2 col-form-label\">Tr???ng th??i:</label>\r\n                    ");
                __builder2.OpenElement(36, "div");
                __builder2.AddAttribute(37, "class", "col-md-10");
                global::__Blazor.FPLSP.Pages.SpecializeUPPages.CreatespecializedhepUP.TypeInference.CreateInputSelect_1(__builder2, 38, 39, "form-control", 40, 
#nullable restore
#line 27 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializeUPPages\CreatespecializedhepUP.razor"
                                                  model.Status

#line default
#line hidden
#nullable disable
                , 41, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => model.Status = __value, model.Status)), 42, () => model.Status, 43, (__builder3) => {
                    __builder3.AddMarkupContent(44, "<option value=\"0\">Ch??a ????? sinh vi??n</option>\r\n                            ");
                    __builder3.AddMarkupContent(45, "<option value=\"1\">Ch??? ??i v??o ho???t ?????ng</option>\r\n                            ");
                    __builder3.AddMarkupContent(46, "<option value=\"2\">Ng??ng ho???t ?????ng</option>\r\n                            ");
                    __builder3.AddMarkupContent(47, "<option value=\"3\">??ang ho???t ?????ng</option>");
                }
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n        ");
                __builder2.OpenElement(49, "div");
                __builder2.AddAttribute(50, "class", "row pt-2");
                __builder2.AddMarkupContent(51, "<div class=\"col-md-6 text-center\"><button type=\"submit\" class=\"btn btn-primary\">T???o M???i</button></div>\r\n            ");
                __builder2.OpenElement(52, "div");
                __builder2.AddAttribute(53, "class", "col-md-6 text-center");
                __builder2.OpenElement(54, "a");
                __builder2.AddAttribute(55, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializeUPPages\CreatespecializedhepUP.razor"
                               () => Quaylai()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(56, "class", "btn btn-danger");
                __builder2.AddMarkupContent(57, "Quay L???i");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\SpecializeUPPages\CreatespecializedhepUP.razor"
       
    
        [Parameter]
        public string Id { get; set; }
        private SpecializedVM model = new SpecializedVM();
        [Inject]
        public NavigationManager Navigation { get; set; }

        [Inject]
        public ISpecializedUPRepo _specializedUPRepo { get; set; }
        public bool ShowAuthError { get; set; }
        [Parameter]
        public string Error { get; set; }
        private async Task Create()
        {
            ShowAuthError = false;
            var result = await _specializedUPRepo.Create(Guid.Parse(Id), model);

            if (result != 1)
            {
                Error = "L???i";
                ShowAuthError = true;
                Navigation.NavigateTo("/createspecializedhepUP/" + Id.ToString());
            }
            else
            {
                Navigation.NavigateTo("/specializedhepUP/" + Id.ToString());
            }
        }
        private async Task Quaylai()
        {
            var url = Path.Combine("/specializedUP");
            Navigation.NavigateTo(url);
        }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.FPLSP.Pages.SpecializeUPPages.CreatespecializedhepUP
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
        public static void CreateInputSelect_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
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
