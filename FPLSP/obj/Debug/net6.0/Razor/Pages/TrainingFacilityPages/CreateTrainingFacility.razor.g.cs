#pragma checksum "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\TrainingFacilityPages\CreateTrainingFacility.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a589834c571b040bd11da9b98b2a6a06c39b66e9"
// <auto-generated/>
#pragma warning disable 1591
namespace FPLSP.Pages.TrainingFacilityPages
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
#line 2 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\TrainingFacilityPages\CreateTrainingFacility.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\TrainingFacilityPages\CreateTrainingFacility.razor"
using FPLSP.Data.Securities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\TrainingFacilityPages\CreateTrainingFacility.razor"
using FPLSP.Repositories.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\TrainingFacilityPages\CreateTrainingFacility.razor"
using FPLSP.Server.Infrastructure.ViewModels.TrainingFacilitiesCPVm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\TrainingFacilityPages\CreateTrainingFacility.razor"
           [Authorize(Roles = "AdminCore,AdminCS")]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/createtf")]
    public partial class CreateTrainingFacility : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>TẠO MỚI CƠ SỞ</h3>");
#nullable restore
#line 9 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\TrainingFacilityPages\CreateTrainingFacility.razor"
 if (_codeNew == null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<global::FPLSP.Components.LoadingIndicator>(1);
            __builder.CloseComponent();
#nullable restore
#line 12 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\TrainingFacilityPages\CreateTrainingFacility.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.EditForm>(2);
            __builder.AddAttribute(3, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Object>(
#nullable restore
#line 15 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\TrainingFacilityPages\CreateTrainingFacility.razor"
                      tfInput

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Forms.EditContext>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 15 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\TrainingFacilityPages\CreateTrainingFacility.razor"
                                               Create

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "class", "card card-body bg-light mt-5");
            __builder.AddAttribute(6, "id", "create-form");
            __builder.AddAttribute(7, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n        ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "form-group");
                __builder2.OpenElement(12, "div");
                __builder2.AddAttribute(13, "class", "row");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "col-2 pt-4");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "row");
                __builder2.OpenElement(18, "img");
                __builder2.AddAttribute(19, "src", 
#nullable restore
#line 21 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\TrainingFacilityPages\CreateTrainingFacility.razor"
                                   tfInput.ImageUrl

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(20, "width", "195px");
                __builder2.AddAttribute(21, "height", "232px");
                __builder2.AddAttribute(22, "style", "object-fit:contain");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n                ");
                __builder2.OpenElement(24, "div");
                __builder2.AddAttribute(25, "class", "row");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "form-group");
                __builder2.AddMarkupContent(28, "<label for=\"image\" class=\"col-12 col-form-label\">Hình Ảnh:</label>");
#nullable restore
#line 26 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\TrainingFacilityPages\CreateTrainingFacility.razor"
                             if (@image != null)
                            {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "col-12");
                __builder2.OpenComponent<global::FPLSP.Shared.ImageUpload>(31);
                __builder2.AddAttribute(32, "OnChange", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, 
#nullable restore
#line 29 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\TrainingFacilityPages\CreateTrainingFacility.razor"
                                                           AssignImageUrl

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(33, "\r\n                                    ");
                __builder2.OpenElement(34, "div");
                __builder2.AddAttribute(35, "class", "text-danger");
                global::__Blazor.FPLSP.Pages.TrainingFacilityPages.CreateTrainingFacility.TypeInference.CreateValidationMessage_0(__builder2, 36, 37, 
#nullable restore
#line 30 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\TrainingFacilityPages\CreateTrainingFacility.razor"
                                                                                       () => tfInput.ImageUrl

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 32 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\TrainingFacilityPages\CreateTrainingFacility.razor"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(38, "div");
                __builder2.AddAttribute(39, "class", "col-12");
                __builder2.OpenComponent<global::FPLSP.Shared.ImageUpload>(40);
                __builder2.AddAttribute(41, "OnChange", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, 
#nullable restore
#line 36 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\TrainingFacilityPages\CreateTrainingFacility.razor"
                                                           AssignImageUrl

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(42, "\r\n                                    ");
                __builder2.OpenElement(43, "div");
                __builder2.AddAttribute(44, "class", "text-danger");
                global::__Blazor.FPLSP.Pages.TrainingFacilityPages.CreateTrainingFacility.TypeInference.CreateValidationMessage_1(__builder2, 45, 46, 
#nullable restore
#line 37 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\TrainingFacilityPages\CreateTrainingFacility.razor"
                                                                                       () => tfInput.ImageUrl

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 39 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\TrainingFacilityPages\CreateTrainingFacility.razor"
                            }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n                ");
                __builder2.OpenElement(48, "div");
                __builder2.AddAttribute(49, "class", "col-10 pt-1");
                __builder2.OpenElement(50, "div");
                __builder2.AddAttribute(51, "class", "row");
                __builder2.OpenElement(52, "div");
                __builder2.AddAttribute(53, "class", "form-group pt-2 col-md-6");
                __builder2.AddMarkupContent(54, "<label for=\"name\" class=\"col-md-4 col-form-label\">Mã Cơ Sở:</label>\r\n                            ");
                __builder2.OpenElement(55, "div");
                __builder2.AddAttribute(56, "class", "col-md-12");
                __builder2.OpenElement(57, "input");
                __builder2.AddAttribute(58, "id", "name");
                __builder2.AddAttribute(59, "class", "form-control");
                __builder2.AddAttribute(60, "value", 
#nullable restore
#line 50 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\TrainingFacilityPages\CreateTrainingFacility.razor"
                                                                              _codeNew

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(61, "disabled");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(62, "\r\n                        ");
                __builder2.OpenElement(63, "div");
                __builder2.AddAttribute(64, "class", "form-group pt-2 col-md-6");
                __builder2.AddMarkupContent(65, "<label for=\"name\" class=\"col-md-4 col-form-label\">Tên Cơ Sở:</label>\r\n                            ");
                __builder2.OpenElement(66, "div");
                __builder2.AddAttribute(67, "class", "col-md-12");
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputText>(68);
                __builder2.AddAttribute(69, "id", "name");
                __builder2.AddAttribute(70, "class", "form-control");
                __builder2.AddAttribute(71, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.String>(
#nullable restore
#line 56 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\TrainingFacilityPages\CreateTrainingFacility.razor"
                                                                                        tfInput.TrainingInstitutionName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(72, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.String>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tfInput.TrainingInstitutionName = __value, tfInput.TrainingInstitutionName))));
                __builder2.AddAttribute(73, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Linq.Expressions.Expression<System.Func<System.String>>>(() => tfInput.TrainingInstitutionName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(74, "\r\n                                ");
                __builder2.OpenElement(75, "div");
                __builder2.AddAttribute(76, "class", "text-danger");
                global::__Blazor.FPLSP.Pages.TrainingFacilityPages.CreateTrainingFacility.TypeInference.CreateValidationMessage_2(__builder2, 77, 78, 
#nullable restore
#line 57 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\TrainingFacilityPages\CreateTrainingFacility.razor"
                                                                                   () => tfInput.TrainingInstitutionName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(79, "\r\n                    ");
                __builder2.OpenElement(80, "div");
                __builder2.AddAttribute(81, "class", "row");
                __builder2.OpenElement(82, "div");
                __builder2.AddAttribute(83, "class", "form-group pt-2 col-md-6");
                __builder2.AddMarkupContent(84, "<label for=\"name\" class=\"col-md-4 col-form-label\">Cơ Sở:</label>\r\n                            ");
                __builder2.OpenElement(85, "div");
                __builder2.AddAttribute(86, "class", "col-md-12");
                global::__Blazor.FPLSP.Pages.TrainingFacilityPages.CreateTrainingFacility.TypeInference.CreateInputNumber_3(__builder2, 87, 88, "name", 89, "form-control", 90, 
#nullable restore
#line 66 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\TrainingFacilityPages\CreateTrainingFacility.razor"
                                                                                          tfInput.TrainingInstitution

#line default
#line hidden
#nullable disable
                , 91, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tfInput.TrainingInstitution = __value, tfInput.TrainingInstitution)), 92, () => tfInput.TrainingInstitution);
                __builder2.AddMarkupContent(93, "\r\n                                ");
                __builder2.OpenElement(94, "div");
                __builder2.AddAttribute(95, "class", "text-danger");
                global::__Blazor.FPLSP.Pages.TrainingFacilityPages.CreateTrainingFacility.TypeInference.CreateValidationMessage_4(__builder2, 96, 97, 
#nullable restore
#line 67 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\TrainingFacilityPages\CreateTrainingFacility.razor"
                                                                                   () => tfInput.TrainingInstitution

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(98, "\r\n\r\n                        ");
                __builder2.OpenElement(99, "div");
                __builder2.AddAttribute(100, "class", "form-group pt-2 col-md-6");
                __builder2.AddMarkupContent(101, "<label for=\"name\" class=\"col-md-4 col-form-label\">Trạng thái:</label>\r\n                            ");
                __builder2.OpenElement(102, "div");
                __builder2.AddAttribute(103, "class", "col-md-12");
                global::__Blazor.FPLSP.Pages.TrainingFacilityPages.CreateTrainingFacility.TypeInference.CreateInputSelect_5(__builder2, 104, 105, "form-select", 106, 
#nullable restore
#line 74 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\TrainingFacilityPages\CreateTrainingFacility.razor"
                                                          tfInput.Status

#line default
#line hidden
#nullable disable
                , 107, global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => tfInput.Status = __value, tfInput.Status)), 108, () => tfInput.Status, 109, (__builder3) => {
                    __builder3.AddMarkupContent(110, "<option value=\"1\">Không Hoạt động</option>\r\n                                    ");
                    __builder3.AddMarkupContent(111, "<option value=\"0\">Hoạt động</option>");
                }
                );
                __builder2.AddMarkupContent(112, "\r\n                                ");
                __builder2.OpenElement(113, "div");
                __builder2.AddAttribute(114, "class", "text-danger");
                global::__Blazor.FPLSP.Pages.TrainingFacilityPages.CreateTrainingFacility.TypeInference.CreateValidationMessage_6(__builder2, 115, 116, 
#nullable restore
#line 78 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\TrainingFacilityPages\CreateTrainingFacility.razor"
                                                                                   () => tfInput.Status

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(117, "\r\n\r\n        ");
                __builder2.OpenElement(118, "div");
                __builder2.AddAttribute(119, "class", "row pt-4");
                __builder2.OpenElement(120, "div");
                __builder2.AddAttribute(121, "class", "col-md-12 text-center");
                __builder2.AddMarkupContent(122, "<button type=\"submit\" class=\"btn btn-primary\" form=\"create-form\">Thêm Mới</button>\r\n                ");
                __builder2.OpenElement(123, "a");
                __builder2.AddAttribute(124, "class", "btn btn-outline-success ms-2");
                __builder2.AddAttribute(125, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 91 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\TrainingFacilityPages\CreateTrainingFacility.razor"
                                                                  () => clearForm()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(126, "Làm mới");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(127, "\r\n                ");
                __builder2.OpenElement(128, "a");
                __builder2.AddAttribute(129, "class", "btn btn-outline-danger ms-2");
                __builder2.AddAttribute(130, "href", "listtf?" + (
#nullable restore
#line 92 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\TrainingFacilityPages\CreateTrainingFacility.razor"
                                                                     _cryptoServices.Encrypt((maxlevel).ToString()).Replace(" /", "I0H"  )

#line default
#line hidden
#nullable disable
                ) + "LDN01" + (
#nullable restore
#line 92 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\TrainingFacilityPages\CreateTrainingFacility.razor"
                                                                                                                                                _cryptoServices.Encrypt((IdCoSo).ToString()).Replace("/", "I0H" )

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(131, "Quay lại");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 96 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\TrainingFacilityPages\CreateTrainingFacility.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 98 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\TrainingFacilityPages\CreateTrainingFacility.razor"
       
    [Parameter]
    public string _codeNew { get; set; }
    [Parameter]
    public string image { get; set; }

    [Inject]
    public ITrainingFacilitiesCPRepo _tfRepositories { get; set; }
    public TrainingFacilitiesCPRequest tfInput = new TrainingFacilitiesCPRequest();
    [Inject] public NavigationManager Navigation { get; set; }

    [Parameter]
    public string _error { get; set; }
    [Inject]
    public IToastService ToastService { get; set; }
    Uri uri;
    string maxlevel = "";
    string IdCoSo = "";
    [Inject]
    public CryptoServices _cryptoServices { get; set; }
    protected override async Task OnInitializedAsync()
    {
        uri = Navigation.ToAbsoluteUri(Navigation.Uri);
        if (string.IsNullOrEmpty(uri.Query) == false)
        {
            var urifist = uri.Query.Split("?")[1];
            maxlevel = _cryptoServices.Decrypt(urifist.Split("LDN01")[0].Replace("I0H", "/"));
            IdCoSo = _cryptoServices.Decrypt(urifist.Split("LDN01")[1].Replace("I0H", "/"));
        }
        
        var maxCodetf = await _tfRepositories.GetTrainingFacilityMaxCode();
        _codeNew = "CS" + (Convert.ToInt32(maxCodetf.TrainingFacilitiesCode.Substring(2, maxCodetf.TrainingFacilitiesCode.Length - 2)) + 1).ToString();
        tfInput.TrainingFacilitiesCode = _codeNew;
    }
    private async Task Create()
    {
        var lstTF = await _tfRepositories.GetTrainingFacilitiesAsync();
        bool check = true;
        foreach (char c in tfInput.TrainingInstitutionName)
        {
            if (!Char.IsLetter(c) && c.ToString() != " ")
                check = false;
        }
        if (check)
        {
            var temp = lstTF.FirstOrDefault(x => x.TrainingInstitution == tfInput.TrainingInstitution && x.TrainingInstitutionName == tfInput.TrainingInstitutionName);

            if (temp != null)
            {
                ToastService.ShowError("Cơ sở đã tồn tại", "Error");
                Navigation.NavigateTo($"/createtf?{_cryptoServices.Encrypt((maxlevel).ToString()).Replace(" / ", "I0H") + "LDN01" + _cryptoServices.Encrypt((IdCoSo).ToString()).Replace(" / ", "I0H")}");
            }
            else
            {
                var result = await _tfRepositories.CreateTrainingFacility(tfInput);

                if (result != true)
                {
                    ToastService.ShowError("Tạo cơ sở đào tạo thất bại", "Error");
                    Navigation.NavigateTo($"/createtf?{_cryptoServices.Encrypt((maxlevel).ToString()).Replace(" / ", "I0H") + "LDN01" + _cryptoServices.Encrypt((IdCoSo).ToString()).Replace(" / ", "I0H")}");
                }
                else
                {
                    ToastService.ShowSuccess("Tạo cơ sở đào tạo thành công", "Success");
                    Navigation.NavigateTo($"/listtf?{_cryptoServices.Encrypt((maxlevel).ToString()).Replace("/", "I0H") + "LDN01" + _cryptoServices.Encrypt((IdCoSo).ToString()).Replace("/", "I0H")}");
                    this.StateHasChanged();
                }
            }
        }
        else
        {
            ToastService.ShowError("Tên không được chứa số và ký tự đặc biệt", "Error");
        }

    }
    private async void OnFileSelected(InputFileChangeEventArgs e)
    {
        if (e.File.Name.ToLower().Contains(".png") || e.File.Name.ToLower().Contains(".jpg") || e.File.Name.ToLower().Contains(".gif"))
        {
            var selectedFiles = e.File;
            tfInput.ImageUrl = await _tfRepositories.LoadingImageUrl(selectedFiles, tfInput.TrainingFacilitiesCode);
            this.StateHasChanged();
        }
        else
        {
            tfInput.ImageUrl = e.File.Name;
            ToastService.ShowError("Ảnh không hợp lệ", "Error");
            this.StateHasChanged();
        }
    }

    public void clearForm()
    {
        image = "";
        tfInput.TrainingInstitutionName = "";
        tfInput.TrainingInstitution = 0;
        tfInput.Status = 1;
        tfInput.ImageUrl = "";

    }
    private void AssignImageUrl(string imgUrl)
    {
        imgUrl = imgUrl.Replace("https://localhost:5001/StaticFiles\\Images\\", "");
        tfInput.ImageUrl = imgUrl;
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.FPLSP.Pages.TrainingFacilityPages.CreateTrainingFacility
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
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Object __arg0, int __seq1, global::System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment __arg4)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.AddAttribute(__seq4, "ChildContent", __arg4);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_6<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591