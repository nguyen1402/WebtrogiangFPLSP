#pragma checksum "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ImagePages\ImageUpdate.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5287e41f1ccf4302055bd0f5e9d79e36c61ac74c"
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
#line 2 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ImagePages\ImageUpdate.razor"
using FPLSP.Repositories.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ImagePages\ImageUpdate.razor"
using FPLSP.Server.Domain.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ImagePages\ImageUpdate.razor"
using FPLSP.Server.Infrastructure.ViewModels.ContentOfExamsCP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ImagePages\ImageUpdate.razor"
using FPLSP.Server.Infrastructure.ViewModels.ImagesCP;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/ImageUpdate/{id:guid}")]
    public partial class ImageUpdate : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 6 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ImagePages\ImageUpdate.razor"
 if (_imageCPUpdateVm != null)
{



#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row pt-3");
            __builder.AddMarkupContent(2, "<h3>C???p Nh???p th??ng tin ???nh</h3>\r\n\r\n        ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.AddMarkupContent(5, "<div class=\"col-1\"></div>\r\n            ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "d-flex justify-content-center col-10 ");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.EditForm>(8);
            __builder.AddAttribute(9, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Object>(
#nullable restore
#line 17 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ImagePages\ImageUpdate.razor"
                                 _imageCPUpdateVm

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Forms.EditContext>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 17 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ImagePages\ImageUpdate.razor"
                                                                  Update

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(11, "class", "card card-body bg-light mt-5");
            __builder.AddAttribute(12, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(13);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\r\n                    ");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "form-group");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "form-group row");
                __builder2.AddMarkupContent(19, "<label for=\"image\" class=\"col-md-2 col-form-label\"><i class=\"fa-regular fa-image\"></i> H??nh ???nh:</label>");
#nullable restore
#line 22 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ImagePages\ImageUpdate.razor"
                             if (flag == false)
                            {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "form-group row");
                __builder2.OpenElement(22, "img");
                __builder2.AddAttribute(23, "src", 
#nullable restore
#line 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ImagePages\ImageUpdate.razor"
                                               _imageCPUpdateVm.Path

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(24, "onerror", "this.src=\'./css/images/Others/logoFPT.png\'");
                __builder2.AddAttribute(25, "alt", "product image");
                __builder2.AddAttribute(26, "style", "width:100px;");
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 27 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ImagePages\ImageUpdate.razor"
                            }

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "col-md-10");
                __builder2.OpenComponent<global::FPLSP.Shared.ImageUpload>(29);
                __builder2.AddAttribute(30, "OnChange", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, 
#nullable restore
#line 29 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ImagePages\ImageUpdate.razor"
                                                       AssignImageUrl

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n                        ");
                __builder2.OpenElement(32, "div");
                __builder2.AddAttribute(33, "class", "row");
                __builder2.OpenElement(34, "div");
                __builder2.AddAttribute(35, "class", "form-group pt-2 col-md-6");
                __builder2.AddMarkupContent(36, "<label for=\"name\" class=\"col-md-4 col-form-label\"><i class=\"fa-regular fa-clipboard\"></i> M?? T???:</label>\r\n                                ");
                __builder2.OpenElement(37, "div");
                __builder2.AddAttribute(38, "class", "col-md-10");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(39);
                __builder2.AddAttribute(40, "id", "name");
                __builder2.AddAttribute(41, "class", "form-control");
                __builder2.AddAttribute(42, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 36 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ImagePages\ImageUpdate.razor"
                                                                                           _imageCPUpdateVm.Descriptions

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(43, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _imageCPUpdateVm.Descriptions = __value, _imageCPUpdateVm.Descriptions))));
                __builder2.AddAttribute(44, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _imageCPUpdateVm.Descriptions));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(45, "\r\n                                    ");
                global::__Blazor.FPLSP.Pages.ImagePages.ImageUpdate.TypeInference.CreateValidationMessage_0(__builder2, 46, 47, 
#nullable restore
#line 37 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ImagePages\ImageUpdate.razor"
                                                              () => _imageCPUpdateVm.Descriptions

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(48, "\r\n                            ");
                __builder2.OpenElement(49, "div");
                __builder2.AddAttribute(50, "class", "form-group pt-2 col-md-6");
                __builder2.AddMarkupContent(51, "<label for=\"name\" class=\"col-md-4 col-form-label\"><i class=\"fa-solid fa-check\"></i> Tr???ng th??i:</label>\r\n                                ");
                __builder2.OpenElement(52, "div");
                __builder2.AddAttribute(53, "class", "col-md-10");
                global::__Blazor.FPLSP.Pages.ImagePages.ImageUpdate.TypeInference.CreateInputSelect_1(__builder2, 54, 55, "form-control", 56, 
#nullable restore
#line 43 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ImagePages\ImageUpdate.razor"
                                                              _imageCPUpdateVm.Status

#line default
#line hidden
#nullable disable
                , 57, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _imageCPUpdateVm.Status = __value, _imageCPUpdateVm.Status)), 58, () => _imageCPUpdateVm.Status, 59, (__builder3) => {
                    __builder3.AddMarkupContent(60, "<option value=\"0\">Ch??a s??? d???ng</option>\r\n                                        ");
                    __builder3.AddMarkupContent(61, "<option value=\"1\">??ang s??? d???ng</option>");
                }
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(62, "\r\n\r\n                        <div class=\"row\"></div>\r\n                        ");
                __builder2.OpenElement(63, "div");
                __builder2.AddAttribute(64, "class", "form-group row");
                __builder2.AddMarkupContent(65, "<label for=\"name\" class=\"col-md-4 col-form-label\"><i class=\"fas fa-light fa-file-lines\"></i> N???i Dung ????? Thi:</label>\r\n                            ");
                __builder2.OpenElement(66, "div");
                __builder2.AddAttribute(67, "class", "col-md-10");
                global::__Blazor.FPLSP.Pages.ImagePages.ImageUpdate.TypeInference.CreateInputSelect_2(__builder2, 68, 69, "form-control", 70, 
#nullable restore
#line 57 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ImagePages\ImageUpdate.razor"
                                                                               _imageCPUpdateVm.CoeId

#line default
#line hidden
#nullable disable
                , 71, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _imageCPUpdateVm.CoeId = __value, _imageCPUpdateVm.CoeId)), 72, () => _imageCPUpdateVm.CoeId, 73, (__builder3) => {
#nullable restore
#line 58 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ImagePages\ImageUpdate.razor"
                                     if (_lstCoe != null)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ImagePages\ImageUpdate.razor"
                                         foreach (var item in _lstCoe)
                                        {

#line default
#line hidden
#nullable disable
                    __builder3.OpenElement(74, "option");
                    __builder3.AddAttribute(75, "value", 
#nullable restore
#line 62 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ImagePages\ImageUpdate.razor"
                                                            item.Id

#line default
#line hidden
#nullable disable
                    );
#nullable restore
#line (62,71)-(62,83) 26 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ImagePages\ImageUpdate.razor"
__builder3.AddContent(76, item.CoeCode);

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(77, " - ");
#nullable restore
#line (62,87)-(62,99) 26 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ImagePages\ImageUpdate.razor"
__builder3.AddContent(78, item.Content);

#line default
#line hidden
#nullable disable
                    __builder3.CloseElement();
#nullable restore
#line 63 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ImagePages\ImageUpdate.razor"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 63 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ImagePages\ImageUpdate.razor"
                                         
                                    }

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(79, "\r\n                    ");
                __builder2.AddMarkupContent(80, "<div class=\"row pt-2\"><div class=\"col-md-6 text-center\"><button type=\"submit\" class=\"btn btn-primary\">C???p Nh???p</button></div>\r\n                        <div class=\"col-md-6 text-center\"><a href=\"/ImageList\" class=\"btn btn-danger\">Quay L???i</a></div></div>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n            <div class=\"col-1\"></div>");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 84 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ImagePages\ImageUpdate.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<global::FPLSP.Components.LoadingIndicator>(82);
            __builder.CloseComponent();
#nullable restore
#line 88 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ImagePages\ImageUpdate.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 91 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\ImagePages\ImageUpdate.razor"
      
    private ImageCPUpdateVm _imageCPUpdateVm = new ImageCPUpdateVm();


    [Inject] private IImageCPRepo _imageCPRepo { get; set; }
    [Inject] private NavigationManager _navier { get; set; }

    [Inject] private IContentOfExamCPRepo _contentOfExamCPRepo { get; set; }
    private CoeListSearchVm _coeListSearchVm = new CoeListSearchVm();
    private List<ContentOfExamCPDto> _lstCoe = new List<ContentOfExamCPDto>();
    bool flag = false;

    [Parameter]
    public Guid Id { get; set; }

    protected async override Task OnInitializedAsync()
    {
        await Get();
    }
    private async Task Get()
    {

        var pagingResponse = await _contentOfExamCPRepo.GetCoeCPList(_coeListSearchVm);
        _lstCoe = pagingResponse.Items;

        var ImageCP = await _imageCPRepo.GetImageCPById(Id);
        var updateVm = new ImageCPUpdateVm()
            {
                CoeId = ImageCP.CoeId,
                Descriptions = ImageCP.Descriptions,
                Path = ImageCP.Path,
                Status = ImageCP.Status
            };
        _imageCPUpdateVm = updateVm;

    }


    private async Task Update()
    {
        var result = await _imageCPRepo.UpdateImageCP(Id, _imageCPUpdateVm);
        if (result)
        {
            _navier.NavigateTo("/ImageList");
        }

    }
    private void AssignImageUrl(string imgUrl)
    {
        _imageCPUpdateVm.Path = imgUrl;
        flag = true;
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.FPLSP.Pages.ImagePages.ImageUpdate
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
