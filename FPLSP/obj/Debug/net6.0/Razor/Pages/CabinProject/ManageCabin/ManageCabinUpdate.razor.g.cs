#pragma checksum "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\ManageCabin\ManageCabinUpdate.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9879056ef9476c303024faaeec1d4085b732a21a"
// <auto-generated/>
#pragma warning disable 1591
namespace FPLSP.Pages.CabinProject.ManageCabin
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
#line 2 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\ManageCabin\ManageCabinUpdate.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\ManageCabin\ManageCabinUpdate.razor"
using FPLSP.Data.Securities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\ManageCabin\ManageCabinUpdate.razor"
using FPLSP.Repositories.Interfaces.CabinProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\ManageCabin\ManageCabinUpdate.razor"
using FPLSP.Server.Infrastructure.ViewModels.CabinProject.Cabin;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/managecabin/update/{IdDe}/{IdTrainDe}")]
    public partial class ManageCabinUpdate : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Cập nhật Cabin</h3>\r\n");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Object>(
#nullable restore
#line 7 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\ManageCabin\ManageCabinUpdate.razor"
                 cabinCreateViewModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "class", "card card-body bg-light mt-6");
            __builder.AddAttribute(4, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n    ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "form-group");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "row");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "form-group pt-2 col-md-6 ");
                __builder2.AddMarkupContent(13, "<label class=\"form-label\">Tên Cabin:</label>\r\n                ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "text-danger");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(16);
                __builder2.AddAttribute(17, "class", "form-control");
                __builder2.AddAttribute(18, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 14 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\ManageCabin\ManageCabinUpdate.razor"
                                                                 cabinCreateViewModel.CabinName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cabinCreateViewModel.CabinName = __value, cabinCreateViewModel.CabinName))));
                __builder2.AddAttribute(20, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cabinCreateViewModel.CabinName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(21, "\r\n                    ");
                global::__Blazor.FPLSP.Pages.CabinProject.ManageCabin.ManageCabinUpdate.TypeInference.CreateValidationMessage_0(__builder2, 22, 23, 
#nullable restore
#line 15 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\ManageCabin\ManageCabinUpdate.razor"
                                            ()=>cabinCreateViewModel.CabinName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n            ");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "form-group pt-2 col-md-6 ");
                __builder2.AddMarkupContent(27, "<label class=\"form-label\">Tòa:</label>\r\n                ");
                __builder2.OpenElement(28, "div");
                __builder2.AddAttribute(29, "class", "text-danger");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(30);
                __builder2.AddAttribute(31, "class", "form-control");
                __builder2.AddAttribute(32, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 21 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\ManageCabin\ManageCabinUpdate.razor"
                                                                 cabinCreateViewModel.BuildingName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cabinCreateViewModel.BuildingName = __value, cabinCreateViewModel.BuildingName))));
                __builder2.AddAttribute(34, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => cabinCreateViewModel.BuildingName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(35, "\r\n                    ");
                global::__Blazor.FPLSP.Pages.CabinProject.ManageCabin.ManageCabinUpdate.TypeInference.CreateValidationMessage_1(__builder2, 36, 37, 
#nullable restore
#line 22 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\ManageCabin\ManageCabinUpdate.razor"
                                            ()=>cabinCreateViewModel.BuildingName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n            ");
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "class", "form-group pt-2 col-md-6 ");
                __builder2.AddMarkupContent(41, "<label class=\"form-label\">Trạng thái:</label>\r\n                ");
                __builder2.OpenElement(42, "div");
                __builder2.AddAttribute(43, "class", "text-danger");
                global::__Blazor.FPLSP.Pages.CabinProject.ManageCabin.ManageCabinUpdate.TypeInference.CreateInputSelect_2(__builder2, 44, 45, "form-select", 46, 
#nullable restore
#line 28 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\ManageCabin\ManageCabinUpdate.razor"
                                                                  cabinCreateViewModel.Status

#line default
#line hidden
#nullable disable
                , 47, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => cabinCreateViewModel.Status = __value, cabinCreateViewModel.Status)), 48, () => cabinCreateViewModel.Status, 49, (__builder3) => {
                    __builder3.AddMarkupContent(50, "<option value=\"0\">Đang hoạt động</option>\r\n                        ");
                    __builder3.AddMarkupContent(51, "<option value=\"2\">Bảo trì</option>");
                }
                );
                __builder2.AddMarkupContent(52, "\r\n                    ");
                global::__Blazor.FPLSP.Pages.CabinProject.ManageCabin.ManageCabinUpdate.TypeInference.CreateValidationMessage_3(__builder2, 53, 54, 
#nullable restore
#line 32 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\ManageCabin\ManageCabinUpdate.razor"
                                            ()=>cabinCreateViewModel.Status

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n        ");
                __builder2.OpenElement(56, "div");
                __builder2.AddAttribute(57, "class", "row");
                __builder2.OpenElement(58, "div");
                __builder2.AddAttribute(59, "class", "d-flex justify-content-center mb-2");
                __builder2.OpenElement(60, "div");
                __builder2.AddAttribute(61, "class", "p-2");
                __builder2.OpenElement(62, "button");
                __builder2.AddAttribute(63, "class", "btn btn-primary");
                __builder2.AddAttribute(64, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 39 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\ManageCabin\ManageCabinUpdate.razor"
                                                              ()=> Update()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(65, "Cập nhật");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "\r\n                ");
                __builder2.OpenElement(67, "div");
                __builder2.AddAttribute(68, "class", "p-2");
                __builder2.OpenElement(69, "button");
                __builder2.AddAttribute(70, "class", "btn btn-success");
                __builder2.AddAttribute(71, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\ManageCabin\ManageCabinUpdate.razor"
                                                               ()=> GetTasks()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(72, "Khôi phục");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\r\n                ");
                __builder2.OpenElement(74, "div");
                __builder2.AddAttribute(75, "class", "p-2");
                __builder2.OpenElement(76, "a");
                __builder2.AddAttribute(77, "href", "/managecabin/" + (
#nullable restore
#line 45 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\ManageCabin\ManageCabinUpdate.razor"
                                           IdTrainDe

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(78, "class", "btn btn-outline-danger");
                __builder2.AddMarkupContent(79, "Quay Lại");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\CabinProject\ManageCabin\ManageCabinUpdate.razor"
       
    CabinViewModel cabinCreateViewModel = new CabinViewModel();
    CabinUpdateViewModel cabinUpdateViewModel = new CabinUpdateViewModel();
    [Inject] private IToastService _toastService { get; set; }
    [Inject] private NavigationManager navigationManager { get; set; }
    [Inject] private ICabinRepo cabin { get; set; }
    [Parameter] public string IdDe { get; set; }
    [Parameter] public string IdTrainDe { get; set; }
    public string Id { get; set; }
    public string IdTrain { get; set; }
    [Inject] private CryptoServices cryptoServices { get; set; }
    protected override async Task OnInitializedAsync()
    {
        IdDe = IdDe.Replace("cabin", "/");
        IdTrainDe = IdTrainDe.Replace("cabin", "/");
        Id = cryptoServices.Decrypt(IdDe);
        IdTrain = cryptoServices.Decrypt(IdTrainDe);
        await GetTasks();
    }
    private async Task GetTasks(){
        cabinCreateViewModel = await cabin.GetCabinListById(Id);
    }
    private async Task Update()
    {
        var cb = await cabin.GetAllCabinAsync();
        cb = cb.Where(x => x.Id != cabinCreateViewModel.Id).ToList();
        if (cb.Where(x => x.CabinName == cabinCreateViewModel.CabinName && x.BuildingName == cabinCreateViewModel.BuildingName).Any())
        {
            _toastService.ShowError($"Cabin {cabinCreateViewModel.CabinName} đã tồn tại");
            return;
        }
        cabinUpdateViewModel.CabinName = cabinCreateViewModel.CabinName;
        cabinUpdateViewModel.BuildingName = cabinCreateViewModel.BuildingName;
        cabinUpdateViewModel.IndexOfCabin = cabinCreateViewModel.IndexOfCabin;
        cabinUpdateViewModel.Status = cabinCreateViewModel.Status;
        cabinUpdateViewModel.CreateTime = cabinCreateViewModel.CreateTime;
        var check = await cabin.UpdateCabin(Guid.Parse(Id), cabinUpdateViewModel);
        if (check)
        {
            _toastService.ShowSuccess("Cập nhật thành công");
            navigationManager.NavigateTo($"managecabin/{IdTrainDe}");
        }
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.FPLSP.Pages.CabinProject.ManageCabin.ManageCabinUpdate
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
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
