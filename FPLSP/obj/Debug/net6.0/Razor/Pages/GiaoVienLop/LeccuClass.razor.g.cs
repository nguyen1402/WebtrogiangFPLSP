#pragma checksum "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\GiaoVienLop\LeccuClass.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37b1265d6c89bf55f90c02ff997092704fbf184f"
// <auto-generated/>
#pragma warning disable 1591
namespace FPLSP.Pages.GiaoVienLop
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
#line 2 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\GiaoVienLop\LeccuClass.razor"
using Blazored.Toast.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\GiaoVienLop\LeccuClass.razor"
using FPLSP.Components.GiaoVienLopUPComponets;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\GiaoVienLop\LeccuClass.razor"
using FPLSP.Data.Securities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\GiaoVienLop\LeccuClass.razor"
using FPLSP.Repositories.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\GiaoVienLop\LeccuClass.razor"
using FPLSP.Server.Data.SeedWork;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\GiaoVienLop\LeccuClass.razor"
using FPLSP.Server.Domain.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\GiaoVienLop\LeccuClass.razor"
using FPLSP.Server.Domain.Entities.UserParts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\GiaoVienLop\LeccuClass.razor"
using FPLSP.Server.Infrastructure.ViewModels.GiaoVienTaoLop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\GiaoVienLop\LeccuClass.razor"
using FPLSP.Server.Infrastructure.ViewModels.Subject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\GiaoVienLop\LeccuClass.razor"
           [Authorize(Roles = "LecturerFPLSP")]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/Giaovien/{specializedIdNonDecrypt}/{lecuIdNonDecrypt}/{subjectIdNonDecrypt}")]
    public partial class LeccuClass : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row");
            __builder.OpenElement(2, "nav");
            __builder.AddAttribute(3, "aria-label", "breadcrumb");
            __builder.OpenElement(4, "ol");
            __builder.AddAttribute(5, "class", "breadcrumb");
            __builder.OpenElement(6, "li");
            __builder.AddAttribute(7, "class", "breadcrumb-item");
            __builder.AddMarkupContent(8, "Chuyên ngành: ");
            __builder.OpenElement(9, "a");
            __builder.AddAttribute(10, "style", "color:blue;box-shadow: 0 1px");
            __builder.AddAttribute(11, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\GiaoVienLop\LeccuClass.razor"
                                                                                                        () => Quaylai()

#line default
#line hidden
#nullable disable
            ));
#nullable restore
#line (15,123)-(15,226) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\GiaoVienLop\LeccuClass.razor"
__builder.AddContent(12, lstSpecAll.Where(c=>c.Id == Guid.Parse(specializedId)).Select(c=>c.SpecializationName).FirstOrDefault());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n            ");
            __builder.OpenElement(14, "li");
            __builder.AddAttribute(15, "class", "breadcrumb-item active");
            __builder.AddAttribute(16, "aria-current", "page");
            __builder.AddMarkupContent(17, "Danh sách Lớp Môn: ");
#nullable restore
#line (16,88)-(16,183) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\GiaoVienLop\LeccuClass.razor"
__builder.AddContent(18, SubjectUPList.Where(c=>c.Id == Guid.Parse(subjectId)).Select(c=>c.SubjectName).FirstOrDefault());

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "row pt-3");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "col-md-3");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "col-md-6");
            __builder.OpenElement(26, "a");
            __builder.AddAttribute(27, "class", "btn btn-outline-danger");
            __builder.AddAttribute(28, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\GiaoVienLop\LeccuClass.razor"
                                                        () => Quaylai()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(29, "<i class=\"bi bi-arrow-return-left\" title=\"Quay lại\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n    ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "col-md-5");
            __builder.OpenComponent<global::FPLSP.Components.GiaoVienLopUPComponets.GiaoVienLopUPCPSearch>(33);
            __builder.AddAttribute(34, "OnSearch", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::FPLSP.Server.Infrastructure.ViewModels.GiaoVienTaoLop.SubjectServicesCPListSearch>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::FPLSP.Server.Infrastructure.ViewModels.GiaoVienTaoLop.SubjectServicesCPListSearch>(this, 
#nullable restore
#line 27 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\GiaoVienLop\LeccuClass.razor"
                                         SearchTask

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n    ");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "col-md-3");
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "row");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "col-md-6");
            __builder.OpenElement(42, "a");
            __builder.AddAttribute(43, "class", "btn btn-outline-primary");
            __builder.AddAttribute(44, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 32 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\GiaoVienLop\LeccuClass.razor"
                                                             ()=> RedirectToCreat()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(45, "Thêm lớp");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n");
            __builder.OpenElement(47, "div");
            __builder.AddAttribute(48, "class", "row");
#nullable restore
#line 38 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\GiaoVienLop\LeccuClass.razor"
     if (fag == false)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<global::FPLSP.Components.LoadingIndicator>(49);
            __builder.CloseComponent();
#nullable restore
#line 41 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\GiaoVienLop\LeccuClass.razor"
    }
    else if (CPList.Count > 0)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(50, "table");
            __builder.AddAttribute(51, "class", "table");
            __builder.AddMarkupContent(52, "<thead class=\"text-center\"><tr><th scope=\"col\">Join Code</th>\r\n                    <th scope=\"col\">Tên lớp</th>\r\n                    <th scope=\"col\">Tòa </th>\r\n                    <th scope=\"col\">Số lượng sinh viên</th></tr></thead>\r\n            ");
            __builder.OpenElement(53, "tbody");
            __builder.AddAttribute(54, "class", "text-center");
#nullable restore
#line 54 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\GiaoVienLop\LeccuClass.razor"
                 foreach (var sj in CPList)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(55, "tr");
            __builder.OpenElement(56, "td");
            __builder.AddAttribute(57, "class", "align-middle");
#nullable restore
#line (58,30)-(58,41) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\GiaoVienLop\LeccuClass.razor"
__builder.AddContent(58, sj.JoinCode);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                        ");
            __builder.OpenElement(60, "td");
            __builder.AddAttribute(61, "class", "align-middle");
#nullable restore
#line (61,30)-(61,46) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\GiaoVienLop\LeccuClass.razor"
__builder.AddContent(62, sj.ClassroomName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n                        ");
            __builder.OpenElement(64, "td");
            __builder.AddAttribute(65, "class", "align-middle");
#nullable restore
#line (64,30)-(64,41) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\GiaoVienLop\LeccuClass.razor"
__builder.AddContent(66, sj.Building);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n                        ");
            __builder.OpenElement(68, "td");
            __builder.AddAttribute(69, "class", "align-middle");
#nullable restore
#line (67,30)-(67,47) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\GiaoVienLop\LeccuClass.razor"
__builder.AddContent(70, sj.Sinhvienthucte);

#line default
#line hidden
#nullable disable
            __builder.AddContent(71, "/");
#nullable restore
#line (67,49)-(67,65) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\GiaoVienLop\LeccuClass.razor"
__builder.AddContent(72, sj.StudentAmount);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n                        ");
            __builder.OpenElement(74, "td");
            __builder.AddAttribute(75, "class", "text-center");
            __builder.OpenElement(76, "a");
            __builder.AddAttribute(77, "class", "btn btn-outline-success ");
            __builder.AddAttribute(78, "type", "button");
            __builder.AddAttribute(79, "title", "Chi Tiết Lớp");
            __builder.AddAttribute(80, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 70 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\GiaoVienLop\LeccuClass.razor"
                                                                                                             () => RedirectToChitiet(_cryptoServices.Encrypt((sj.ClassId).ToString()))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(81, "\r\n                                Chi Tiết Lớp\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n                            ");
            __builder.OpenElement(83, "a");
            __builder.AddAttribute(84, "class", "btn btn-outline-danger ");
            __builder.AddAttribute(85, "type", "button");
            __builder.AddAttribute(86, "title", "Xóa lớp");
            __builder.AddAttribute(87, "onclick", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 79 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\GiaoVienLop\LeccuClass.razor"
                                                                                                       () => Delete(sj.ClassId,sj.SubjectId)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(88, "<i class=\"fas fa-trash-alt\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 84 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\GiaoVienLop\LeccuClass.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenComponent<global::FPLSP.Components.Comfirmation>(89);
            __builder.AddAttribute(90, "ConfirmationMessage", "Bạn có chắc muốn xóa không?");
            __builder.AddAttribute(91, "ConfirmationTitle", "Xóa lớp");
            __builder.AddAttribute(92, "ConfirmationChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.Boolean>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.Boolean>(this, 
#nullable restore
#line 91 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\GiaoVienLop\LeccuClass.razor"
                                       OnConfirmationDelete

#line default
#line hidden
#nullable disable
            )));
            __builder.AddComponentReferenceCapture(93, (__value) => {
#nullable restore
#line 90 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\GiaoVienLop\LeccuClass.razor"
                        DeleteConfirmation = (FPLSP.Components.Comfirmation)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
#nullable restore
#line 92 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\GiaoVienLop\LeccuClass.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(94, "<h5>Danh sách lớp trống</h5>");
#nullable restore
#line 96 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\GiaoVienLop\LeccuClass.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n");
            __builder.OpenElement(96, "div");
            __builder.AddAttribute(97, "class", "footer text-muted");
            __builder.OpenElement(98, "div");
            __builder.AddAttribute(99, "class", "row mt-3");
            __builder.OpenElement(100, "span");
            __builder.OpenComponent<global::FPLSP.Components.Pagingation>(101);
            __builder.AddAttribute(102, "MetaData", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::FPLSP.Server.Data.SeedWork.MetaData>(
#nullable restore
#line 102 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\GiaoVienLop\LeccuClass.razor"
                                   MetaData

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(103, "Spread", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Int32>(
#nullable restore
#line 102 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\GiaoVienLop\LeccuClass.razor"
                                                     2

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(104, "SelectedPage", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::System.Int32>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.Int32>(this, 
#nullable restore
#line 102 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\GiaoVienLop\LeccuClass.razor"
                                                                      SelectedPage

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 108 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\GiaoVienLop\LeccuClass.razor"
       
    [Parameter]
    public string specializedIdNonDecrypt { get; set; }
    [Parameter]
    public string lecuIdNonDecrypt { get; set; }
    [Parameter]
    public string subjectIdNonDecrypt { get; set; }

    public string specializedId = "";

    public string lecuId = "";

    public string subjectId = "";

    public bool fag { get; set; } = false;

    protected Comfirmation DeleteConfirmation { get; set; }

    [Inject] private IToastService _toastService { get; set; }
    public string _idSubject { get; set; }
    public string _idClass { get; set; }
    public List<ClassSubjectUPDto> CPList { get; set; } = new List<ClassSubjectUPDto>();
    public MetaData MetaData { get; set; } = new MetaData();
    private int encounter;
    private SubjectServicesCPListSearch _parameters = new SubjectServicesCPListSearch();
    [Inject]
    public NavigationManager NavigationManager { get; set; }
    [Inject]
    public IClassSubjectApiClient _iClassSubjectApiClient { get; set; }
    public string Error { get; set; }

    public List<SpecializedDto> lstSpecAll { get; set; } = new List<SpecializedDto>();
    [Inject]
    public ISpecializedCPRepo _iSpecializedClient { get; set; }

    [Inject] public ISubjectUPRepo _subjectUPRepo { get; set; }
    public List<SubjectDto> SubjectUPList { get; set; } = new List<SubjectDto>();
    public List<ClassUp> _lstClassUps { get; set; } = new List<ClassUp>();
    private SubjectListSearch SubjectListSearch = new SubjectListSearch();
    [Inject]
    public CryptoServices _cryptoServices { get; set; }
    protected async override Task OnInitializedAsync()
    {
        lecuId = _cryptoServices.Decrypt(lecuIdNonDecrypt.Replace("I0H", "/"));
        subjectId = _cryptoServices.Decrypt(subjectIdNonDecrypt.Replace("I0H", "/"));
        specializedId = _cryptoServices.Decrypt(specializedIdNonDecrypt.Replace("I0H", "/"));
        //    _specialized = await _iClassSubjectApiClient.GetbyId(Guid.Parse(idspecialized), Guid.Parse(id));
        await GetTasks();
    }
    public async Task SearchTask(SubjectServicesCPListSearch lessonContentListSearch)
    {
        _parameters = lessonContentListSearch;
        await GetTasks();
    }
    private async Task RedirectToCreat()
    {
        var url = Path.Combine($"/Creat/{specializedIdNonDecrypt}/{lecuIdNonDecrypt}/{subjectIdNonDecrypt}");
        NavigationManager.NavigateTo(url);
    }
    private async Task RedirectToChitiet(string idclass)
    {
        string a = "";
        a = idclass.Replace("/", "I0H");
        var url = Path.Combine($"/ViewChiTitet/{a}/{specializedIdNonDecrypt}/{lecuIdNonDecrypt}/{subjectIdNonDecrypt}");
        NavigationManager.NavigateTo(url);
    }

    //private async Task RedirectToThemlinktainguyen(string joincode)
    //{
    //    var url = Path.Combine($"/resoucrelinkforstudent/{joincode}/Giaovien=={specializedId}=={lecuId}=={subjectId}");
    //    NavigationManager.NavigateTo(url);
    //}
    //private async Task RedirectToKho(string joincode, Guid? idLecturer)
    //{
    //    var url = Path.Combine($"/news/{joincode}/{idLecturer}");
    //    NavigationManager.NavigateTo(url);
    //}

    public async Task OnConfirmationDelete(bool deleteconfirmed)
    {
        if (deleteconfirmed && _idSubject == null)
        {
            _toastService.ShowError("Bạn đã bỏ xóa !");
            await GetTasks();
            NavigationManager.NavigateTo($"/Giaovien/{specializedIdNonDecrypt}/{lecuIdNonDecrypt}/{subjectIdNonDecrypt}");
        }
        else if (deleteconfirmed && _idSubject != null)
        {
            var result = await _iClassSubjectApiClient.Delete(Guid.Parse(_idClass), Guid.Parse(_idSubject));
            if (result == 1)
            {
                _toastService.ShowSuccess("Xóa thành công");
                await GetTasks();
                NavigationManager.NavigateTo($"/Giaovien/{specializedIdNonDecrypt}/{lecuIdNonDecrypt}/{subjectIdNonDecrypt}");
            }
            else
            {
                _toastService.ShowError("Xóa thất bại");
                await GetTasks();
                NavigationManager.NavigateTo($"/Giaovien/{specializedIdNonDecrypt}/{lecuIdNonDecrypt}/{subjectIdNonDecrypt}");
            }
        }
        _idSubject = null;
    }
    private async Task Delete(Guid? idclass, Guid? idsubject)
    {
        _idClass = idclass.ToString();
        _idSubject = idsubject.ToString();
        DeleteConfirmation.show();
    }

    //private async Task RedirectToDetailsClassLeccu(Guid? idclass)
    //{
    //    var url = Path.Combine($"/DetailsClassLeccu/{idclass}/{specializedId}/{lecuId}/{subjectId}");
    //    NavigationManager.NavigateTo(url);
    //}
    private async Task Quaylai()
    {
        var url = Path.Combine($"/LectuterSpecializedSubjectls/{lecuIdNonDecrypt}/{specializedIdNonDecrypt}");
        NavigationManager.NavigateTo(url);
    }

    private async Task GetTasks()
    {
        try
        {
            fag = false;
            for (var i = 0; i < 15; i++)
            {
                encounter = i;
            }
            var SubjectUPListpagingResponse1 = await _subjectUPRepo.GetSubjects(Guid.Parse(specializedId), SubjectListSearch);
            SubjectUPList = SubjectUPListpagingResponse1.Items;
            lstSpecAll = await _iSpecializedClient.GetAll();
            _lstClassUps = await _iClassSubjectApiClient.GetlstClassUP(Guid.Parse(subjectId));
            var pagingResponse = await _iClassSubjectApiClient.GetPagingParamets(Guid.Parse(subjectId), Guid.Parse(lecuId), Guid.Parse(specializedId), _parameters);
            CPList = pagingResponse.Items;
            MetaData = pagingResponse.MetaData;
            fag = true;
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
#pragma warning restore 1591