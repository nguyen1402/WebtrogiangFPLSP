#pragma checksum "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\StudentUPDetail.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1de3af3634d7f41d5fce458c8e08c964d9768de"
// <auto-generated/>
#pragma warning disable 1591
namespace FPLSP.Pages.StudentUPPages
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
#line 2 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\StudentUPDetail.razor"
using FPLSP.Server.Domain.Dtos.StudentUPDtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\StudentUPDetail.razor"
using FPLSP.Repositories.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\StudentUPDetail.razor"
           [Authorize(Roles = "LecturerFPLSP")]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/StudentUPDetails/{Id:guid}")]
    public partial class StudentUPDetail : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Th??ng tin sinh vi??n</h3>");
#nullable restore
#line 7 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\StudentUPDetail.razor"
 if (student != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "form-group");
            __builder.AddMarkupContent(3, "<div class=\"row\"><div class=\"form-group pt-2 col-md-12\"><div class=\"row pt-2 col-md-1 text-center\"><a href=\"/StudentUPList\" class=\"btn btn-outline-danger\">Quay L???i</a></div></div></div>\r\n        ");
            __builder.AddMarkupContent(4, "<div class=\"row\"><div class=\"form-group pt-2 col-md-12\"></div></div>\r\n        ");
            __builder.OpenElement(5, "td");
            __builder.OpenElement(6, "img");
            __builder.AddAttribute(7, "src", 
#nullable restore
#line 21 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\StudentUPDetail.razor"
                       student.ImageUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(8, "onerror", "this.src=\'./css/images/Others/logoFPT.png\'");
            __builder.AddAttribute(9, "alt", "product image");
            __builder.AddAttribute(10, "height", "190");
            __builder.AddAttribute(11, "width", "170");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n\r\n        ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "row");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "form-group pt-2 col-md-4");
            __builder.OpenElement(17, "label");
            __builder.AddAttribute(18, "for", "name");
            __builder.AddAttribute(19, "class", "col-md-6 col-form-label");
            __builder.AddMarkupContent(20, "M?? Sinh Vi??n: ");
            __builder.OpenElement(21, "b");
#nullable restore
#line (25,85)-(25,104) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\StudentUPDetail.razor"
__builder.AddContent(22, student.StudentCode);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n            ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "form-group pt-2 col-md-4");
            __builder.OpenElement(26, "label");
            __builder.AddAttribute(27, "for", "name");
            __builder.AddAttribute(28, "class", "col-md-6 col-form-label");
            __builder.AddMarkupContent(29, "T??n Sinh Vi??n: ");
            __builder.OpenElement(30, "b");
#nullable restore
#line (28,86)-(28,105) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\StudentUPDetail.razor"
__builder.AddContent(31, student.StudentName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n        ");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "row");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "form-group pt-2 col-md-4");
            __builder.OpenElement(37, "label");
            __builder.AddAttribute(38, "for", "name");
            __builder.AddAttribute(39, "class", "col-md-6 col-form-label");
            __builder.AddMarkupContent(40, "Gi???i t??nh: \r\n");
#nullable restore
#line 34 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\StudentUPDetail.razor"
                     if(student.Gender == false)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(41, "<b>Nam</b>");
#nullable restore
#line 37 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\StudentUPDetail.razor"
                    }else{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(42, "<b>N???</b>");
#nullable restore
#line 39 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\StudentUPDetail.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n            ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "form-group pt-2 col-md-4");
            __builder.OpenElement(46, "label");
            __builder.AddAttribute(47, "for", "name");
            __builder.AddAttribute(48, "class", "col-md-6 col-form-label");
            __builder.AddMarkupContent(49, "Ng??y sinh: ");
            __builder.OpenElement(50, "b");
#nullable restore
#line (43,82)-(43,105) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\StudentUPDetail.razor"
__builder.AddContent(51, student.DateOfBirth.Day);

#line default
#line hidden
#nullable disable
            __builder.AddContent(52, "/");
#nullable restore
#line (43,107)-(43,132) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\StudentUPDetail.razor"
__builder.AddContent(53, student.DateOfBirth.Month);

#line default
#line hidden
#nullable disable
            __builder.AddContent(54, "/");
#nullable restore
#line (43,134)-(43,158) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\StudentUPDetail.razor"
__builder.AddContent(55, student.DateOfBirth.Year);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n        ");
            __builder.OpenElement(57, "div");
            __builder.AddAttribute(58, "class", "row");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "form-group pt-2 col-md-4");
            __builder.OpenElement(61, "label");
            __builder.AddAttribute(62, "for", "name");
            __builder.AddAttribute(63, "class", "col-md-6 col-form-label");
            __builder.AddContent(64, "Email: ");
            __builder.OpenElement(65, "b");
#nullable restore
#line (48,78)-(48,91) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\StudentUPDetail.razor"
__builder.AddContent(66, student.Email);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n            ");
            __builder.OpenElement(68, "div");
            __builder.AddAttribute(69, "class", "form-group pt-2 col-md-4");
            __builder.OpenElement(70, "label");
            __builder.AddAttribute(71, "for", "name");
            __builder.AddAttribute(72, "class", "col-md-6 col-form-label");
            __builder.AddMarkupContent(73, "S??? ??i???n tho???i: ");
            __builder.OpenElement(74, "b");
#nullable restore
#line (51,86)-(51,105) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\StudentUPDetail.razor"
__builder.AddContent(75, student.PhoneNumber);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n        ");
            __builder.OpenElement(77, "div");
            __builder.AddAttribute(78, "class", "row");
            __builder.OpenElement(79, "div");
            __builder.AddAttribute(80, "class", "form-group pt-2 col-md-4");
            __builder.OpenElement(81, "label");
            __builder.AddAttribute(82, "for", "name");
            __builder.AddAttribute(83, "class", "col-md-6 col-form-label");
            __builder.AddMarkupContent(84, "?????a ch???: ");
            __builder.OpenElement(85, "b");
#nullable restore
#line (56,80)-(56,95) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\StudentUPDetail.razor"
__builder.AddContent(86, student.Address);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n            ");
            __builder.OpenElement(88, "div");
            __builder.AddAttribute(89, "class", "form-group pt-2 col-md-4");
            __builder.OpenElement(90, "label");
            __builder.AddAttribute(91, "for", "name");
            __builder.AddAttribute(92, "class", "col-md-6 col-form-label");
            __builder.AddMarkupContent(93, "D??n t???c: ");
            __builder.OpenElement(94, "b");
#nullable restore
#line (59,80)-(59,94) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\StudentUPDetail.razor"
__builder.AddContent(95, student.Ethnic);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n        ");
            __builder.OpenElement(97, "div");
            __builder.AddAttribute(98, "class", "row");
            __builder.OpenElement(99, "div");
            __builder.AddAttribute(100, "class", "form-group pt-2 col-md-4");
            __builder.OpenElement(101, "label");
            __builder.AddAttribute(102, "for", "name");
            __builder.AddAttribute(103, "class", "col-md-6 col-form-label");
            __builder.AddContent(104, "CMT/CCCD: ");
            __builder.OpenElement(105, "b");
#nullable restore
#line (64,81)-(64,107) 26 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\StudentUPDetail.razor"
__builder.AddContent(106, student.IdentityCardNumber);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(107, "\r\n            ");
            __builder.OpenElement(108, "div");
            __builder.AddAttribute(109, "class", "form-group pt-2 col-md-4");
            __builder.OpenElement(110, "label");
            __builder.AddAttribute(111, "for", "name");
            __builder.AddAttribute(112, "class", "col-md-6 col-form-label");
            __builder.AddMarkupContent(113, "Ng??y c???p: ");
            __builder.OpenElement(114, "b");
#nullable restore
#line (67,81)-(67,101) 26 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\StudentUPDetail.razor"
__builder.AddContent(115, student.IssuedOn.Day);

#line default
#line hidden
#nullable disable
            __builder.AddContent(116, "/");
#nullable restore
#line (67,103)-(67,125) 26 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\StudentUPDetail.razor"
__builder.AddContent(117, student.IssuedOn.Month);

#line default
#line hidden
#nullable disable
            __builder.AddContent(118, "/");
#nullable restore
#line (67,127)-(67,148) 26 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\StudentUPDetail.razor"
__builder.AddContent(119, student.IssuedOn.Year);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(120, "\r\n        ");
            __builder.OpenElement(121, "div");
            __builder.AddAttribute(122, "class", "row");
            __builder.OpenElement(123, "div");
            __builder.AddAttribute(124, "class", "form-group pt-2 col-md-4");
            __builder.OpenElement(125, "label");
            __builder.AddAttribute(126, "for", "name");
            __builder.AddAttribute(127, "class", "col-md-6 col-form-label");
            __builder.AddMarkupContent(128, "T??n B???: ");
            __builder.OpenElement(129, "b");
#nullable restore
#line (72,79)-(72,98) 26 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\StudentUPDetail.razor"
__builder.AddContent(130, student.FathersName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(131, "\r\n            ");
            __builder.OpenElement(132, "div");
            __builder.AddAttribute(133, "class", "form-group pt-2 col-md-4");
            __builder.OpenElement(134, "label");
            __builder.AddAttribute(135, "for", "name");
            __builder.AddAttribute(136, "class", "col-md-6 col-form-label");
            __builder.AddMarkupContent(137, "T??n M???: ");
            __builder.OpenElement(138, "b");
#nullable restore
#line (75,79)-(75,97) 26 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\StudentUPDetail.razor"
__builder.AddContent(139, student.MotherName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(140, "\r\n        ");
            __builder.OpenElement(141, "div");
            __builder.AddAttribute(142, "class", "row");
            __builder.OpenElement(143, "div");
            __builder.AddAttribute(144, "class", "form-group pt-2 col-md-4");
            __builder.OpenElement(145, "label");
            __builder.AddAttribute(146, "for", "name");
            __builder.AddAttribute(147, "class", "col-md-6 col-form-label");
            __builder.AddMarkupContent(148, "M?? t???: ");
            __builder.OpenElement(149, "b");
#nullable restore
#line (80,78)-(80,97) 26 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\StudentUPDetail.razor"
__builder.AddContent(150, student.Description);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(151, "\r\n            ");
            __builder.OpenElement(152, "div");
            __builder.AddAttribute(153, "class", "form-group pt-2 col-md-4");
            __builder.OpenElement(154, "label");
            __builder.AddAttribute(155, "for", "name");
            __builder.AddAttribute(156, "class", "col-md-6 col-form-label");
            __builder.AddMarkupContent(157, "Tr???ng th??i: \r\n");
#nullable restore
#line 84 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\StudentUPDetail.razor"
                     if(student.Status == 0)
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(158, "<b>??ang ho???t ?????ng</b>");
#nullable restore
#line 87 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\StudentUPDetail.razor"
                    }else{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(159, "<b>Ng??ng ho???t ?????ng</b>");
#nullable restore
#line 89 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\StudentUPDetail.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 94 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\StudentUPDetail.razor"



}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 99 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\StudentUPPages\StudentUPDetail.razor"
 
    public StudentUpDto student;
    [Inject] public NavigationManager Navigation { get; set; }
    [Inject] IStudentUPRepo _repo { get; set; }
    [Parameter] public Guid Id { get; set; }

    protected async override Task OnInitializedAsync()
    {
        student = await _repo.GetStudentUPById(Id);
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
