#pragma checksum "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LecturerPages\DetailsLecturer.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27e4823173c14d9b525b8b74b1b6a6660fd38d8e"
// <auto-generated/>
#pragma warning disable 1591
namespace FPLSP.Pages.LecturerPages
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
#line 2 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LecturerPages\DetailsLecturer.razor"
using FPLSP.Repositories.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LecturerPages\DetailsLecturer.razor"
using FPLSP.Server.Data.SeedWork;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LecturerPages\DetailsLecturer.razor"
using FPLSP.Server.Domain.Dtos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LecturerPages\DetailsLecturer.razor"
using FPLSP.Server.Infrastructure.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LecturerPages\DetailsLecturer.razor"
           [Authorize(Roles = "AdminCS")]

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/detailslecturer/{id}")]
    public partial class DetailsLecturer : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    body {\r\n    background-color: #ebeef4;\r\n    margin-top: 20px;\r\n}\r\n\r\n.nav-tabs {\r\n    border-bottom: 1px solid #c9d2e3;\r\n}\r\n\r\n.profile .profile-header {\r\n    position: relative;\r\n}\r\n\r\n    .profile .profile-header .profile-header-cover {\r\n        background: url(https://wallpapercave.com/wp/wp2901390.jpg);\r\n        background-size: cover;\r\n        background-position: center;\r\n        background-repeat: no-repeat;\r\n        height: 10.625rem;\r\n        position: relative; \r\n    }\r\n\r\nmedia (max-width: 991.98px) {\r\n    .profile .profile-header .profile-header-cover {\r\n        height: 6.25rem;\r\n    }\r\n}\r\n\r\n.profile .profile-header .profile-header-cover:before {\r\n    content: \"\";\r\n    position: absolute;\r\n    top: 0;\r\n    left: 0;\r\n    right: 0;\r\n    bottom: 0;\r\n}\r\n\r\n.profile .profile-header .profile-header-content {\r\n    position: relative;\r\n    padding: 0 150px;\r\n    display: -webkit-box;\r\n    display: -ms-flexbox;\r\n    display: flex;\r\n    -ms-flex-align: flex-end;\r\n    align-items: flex-end;\r\n}\r\n\r\nmedia (max-width: 991.98px) {\r\n    .profile .profile-header .profile-header-content {\r\n        display: block;\r\n        padding: 0 20px;\r\n    }\r\n}\r\n\r\n.profile .profile-header .profile-header-content .profile-header-img {\r\n    width: 12.5rem;\r\n    height: 12.5rem;\r\n    overflow: hidden;\r\n    z-index: 10;\r\n    margin-top: -8.75rem;\r\n    padding: 0.1875rem;\r\n    background: #fff;\r\n    -webkit-border-radius: 9px;\r\n    border-radius: 9px;\r\n}\r\n\r\nmedia (max-width: 991.98px) {\r\n    .profile .profile-header .profile-header-content .profile-header-img {\r\n        width: 4.375rem;\r\n        height: 4.375rem;\r\n        margin: -3.75rem 0 0;\r\n    }\r\n}\r\n\r\n.profile .profile-header .profile-header-content .profile-header-img img {\r\n    max-width: 100%;\r\n    width: 100%;\r\n    -webkit-border-radius: 6px;\r\n    border-radius: 6px;\r\n}\r\n\r\n.profile .profile-header .profile-header-content .profile-header-tab {\r\n    position: relative;\r\n    margin-left: 135px;\r\n    -webkit-box-flex: 1;\r\n    -ms-flex: 1;\r\n    flex: 1;\r\n}\r\nmedia (max-width: 991.98px) {\r\n    .profile .profile-header .profile-header-content .profile-header-tab {\r\n        margin: -0.625rem -20px 0;\r\n        padding: 0 150px;\r\n        overflow: scroll;\r\n        display: -webkit-box;\r\n        display: -ms-flexbox;\r\n        display: flex;\r\n        -ms-flex-wrap: nowrap;\r\n        flex-wrap: nowrap;\r\n    }\r\n}\r\n\r\n.profile .profile-header .profile-header-content .profile-header-tab .nav-item .nav-link {\r\n    padding: 0.8125rem 0.625rem 0.5625rem;\r\n    text-align: center;\r\n}\r\n\r\nmedia (max-width: 991.98px) {\r\n    .profile .profile-header .profile-header-content .profile-header-tab .nav-item .nav-link {\r\n        padding: 0.9375rem 0.625rem 0.3125rem;\r\n    }\r\n}\r\n\r\n.profile .profile-header .profile-header-content .profile-header-tab .nav-item .nav-link .nav-field {\r\n    font-weight: 600;\r\n    font-size: 0.8125rem;\r\n}\r\n\r\nmedia (max-width: 991.98px) {\r\n    .profile .profile-header .profile-header-content .profile-header-tab .nav-item .nav-link .nav-field {\r\n        font-size: 0.6875rem;\r\n        margin-bottom: -0.125rem;\r\n    }\r\n}\r\n\r\n.profile .profile-header .profile-header-content .profile-header-tab .nav-item .nav-link .nav-value {\r\n    font-size: 1.25rem;\r\n    font-weight: 400;\r\n    letter-spacing: -0.5px;\r\n}\r\n\r\nmedia (max-width: 991.98px) {\r\n    .profile .profile-header .profile-header-content .profile-header-tab .nav-item .nav-link .nav-value {\r\n        font-size: 1.125rem;\r\n    }\r\n}\r\n\r\nmedia (max-width: 991.98px) {\r\n    .profile .profile-header .profile-header-content .profile-header-tab .nav-item .nav-link.active {\r\n        background: 0 0;\r\n    }\r\n}\r\n\r\n.profile .profile-header .profile-header-content .profile-header-tab .nav-item + .nav-item {\r\n    margin-left: 0.9375rem;\r\n}\r\n\r\n.profile .profile-container {\r\n    padding: 30px 50px;\r\n    display: -webkit-box;\r\n    display: -ms-flexbox;\r\n    display: flex;\r\n}\r\n\r\nmedia (max-width: 991.98px) {\r\n    .profile .profile-container {\r\n        padding: 20px 20px;\r\n    }\r\n}\r\n\r\n.profile .profile-container .profile-sidebar {\r\n    width: 25rem;\r\n}\r\n\r\nmedia (max-width: 991.98px) {\r\n    .profile .profile-container .profile-sidebar {\r\n        display: none;\r\n    }\r\n}\r\n\r\n.profile .profile-container .profile-content {\r\n    padding-left: 30px;\r\n    -webkit-box-flex: 1;\r\n    -ms-flex: 1;\r\n    flex: 1;\r\n}\r\n\r\nmedia (max-width: 991.98px) {\r\n    .profile .profile-container .profile-content {\r\n        padding-left: 0;\r\n    }\r\n}\r\n\r\n.profile .profile-img-list {\r\n    list-style-type: none;\r\n    margin: -0.0625rem -1.3125rem;\r\n    padding: 0;\r\n}\r\n\r\n    .profile .profile-img-list:after,\r\n    .profile .profile-img-list:before {\r\n        content: \"\";\r\n        display: table;\r\n        clear: both;\r\n    }\r\n\r\n    .profile .profile-img-list .profile-img-list-item {\r\n        float: left;\r\n        width: 25%;\r\n        padding: 0.0625rem;\r\n    }\r\n\r\n        .profile .profile-img-list .profile-img-list-item.main {\r\n            width: 50%;\r\n        }\r\n\r\n        .profile .profile-img-list .profile-img-list-item .profile-img-list-link {\r\n            display: block;\r\n            padding-top: 75%;\r\n            overflow: hidden;\r\n            position: relative;\r\n        }\r\n\r\n            .profile .profile-img-list .profile-img-list-item .profile-img-list-link .profile-img-content,\r\n            .profile .profile-img-list .profile-img-list-item .profile-img-list-link img {\r\n                position: absolute;\r\n                top: 0;\r\n                left: 0;\r\n                right: 0;\r\n                bottom: 0;\r\n                max-width: 100%;\r\n                background-size: cover;\r\n                background-position: center;\r\n                background-repeat: no-repeat;\r\n            }\r\n\r\n                .profile .profile-img-list .profile-img-list-item .profile-img-list-link .profile-img-content:before,\r\n                .profile .profile-img-list .profile-img-list-item .profile-img-list-link img:before {\r\n                    content: \"\";\r\n                    position: absolute;\r\n                    top: 0;\r\n                    left: 0;\r\n                    right: 0;\r\n                    bottom: 0;\r\n                    border: 1px solid rgba(60, 78, 113, 0.15);\r\n                }\r\n\r\n        .profile .profile-img-list .profile-img-list-item.with-number .profile-img-number {\r\n            position: absolute;\r\n            top: 50%;\r\n            left: 0;\r\n            right: 0;\r\n            color: #fff;\r\n            font-size: 1.625rem;\r\n            font-weight: 500;\r\n            line-height: 1.625rem;\r\n            margin-top: -0.8125rem;\r\n            text-align: center;\r\n        }\r\n\r\n</style>");
#nullable restore
#line 259 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LecturerPages\DetailsLecturer.razor"
 if(lecturer == null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<global::FPLSP.Components.LoadingIndicator>(1);
            __builder.CloseComponent();
#nullable restore
#line 262 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LecturerPages\DetailsLecturer.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "profile");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "profile-header");
            __builder.AddMarkupContent(6, "<div class=\"profile-header-cover\"></div>\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "profile-header-content");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "profile-header-img");
            __builder.OpenElement(11, "img");
            __builder.AddAttribute(12, "src", "./css/images/LecturerCP/" + (
#nullable restore
#line 270 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LecturerPages\DetailsLecturer.razor"
                                                       lecturer.ImageUrl

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "onerror", "this.src=\'./css/images/Others/logoFPT.png\'");
            __builder.AddAttribute(14, "alt");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n            ");
            __builder.OpenElement(16, "ul");
            __builder.AddAttribute(17, "class", "profile-header-tab nav nav-tabs nav-tabs-v2");
            __builder.OpenElement(18, "li");
            __builder.AddAttribute(19, "class", "nav-item");
            __builder.AddMarkupContent(20, "<div class=\"nav-field\">Years Of Experience</div>\r\n                        ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "nav-value");
#nullable restore
#line (275,49)-(275,75) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LecturerPages\DetailsLecturer.razor"
__builder.AddContent(23, lecturer.YearsOfExperience);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.OpenElement(25, "li");
            __builder.AddAttribute(26, "class", "nav-item");
            __builder.AddMarkupContent(27, "<div class=\"nav-field\">Teaching Classes</div>\r\n                    ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "nav-value");
#nullable restore
#line (279,45)-(279,60) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LecturerPages\DetailsLecturer.razor"
__builder.AddContent(30, _lstClass.Count);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n\r\n    ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "profile-container");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "profile-sidebar");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "desktop-sticky-top");
            __builder.OpenElement(38, "h4");
            __builder.AddAttribute(39, "style", "text-align: center;");
#nullable restore
#line (288,54)-(288,76) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LecturerPages\DetailsLecturer.razor"
__builder.AddContent(40, lecturer.LecturersName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                ");
            __builder.OpenElement(42, "p");
            __builder.AddAttribute(43, "style", "text-align: center;");
#nullable restore
#line (290,22)-(290,42) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LecturerPages\DetailsLecturer.razor"
__builder.AddContent(44, lecturer.Description);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                    ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "mb-1");
            __builder.AddContent(48, "LecturerCode: ");
#nullable restore
#line (292,54)-(292,76) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LecturerPages\DetailsLecturer.razor"
__builder.AddContent(49, lecturer.LecturersCode);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                    ");
            __builder.OpenElement(51, "div");
            __builder.AddAttribute(52, "class", "mb-1");
            __builder.AddContent(53, "Specialized: ");
#nullable restore
#line (293,54)-(293,115) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LecturerPages\DetailsLecturer.razor"
__builder.AddContent(54, specializedListString == null ? "N/A" : specializedListString);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                ");
            __builder.OpenElement(56, "div");
            __builder.AddAttribute(57, "class", "mb-1");
            __builder.AddContent(58, "Gender: ");
#nullable restore
#line (294,45)-(294,88) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LecturerPages\DetailsLecturer.razor"
__builder.AddContent(59, lecturer.Gender == true ? "Male" : "Female");

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n                ");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "mb-1");
            __builder.AddContent(63, "Date Of Birth: ");
#nullable restore
#line (295,51)-(295,86) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LecturerPages\DetailsLecturer.razor"
__builder.AddContent(64, lecturer.Dob.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n                ");
            __builder.OpenElement(66, "div");
            __builder.AddAttribute(67, "class", "mb-1");
            __builder.AddContent(68, "Email: ");
#nullable restore
#line (296,43)-(296,57) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LecturerPages\DetailsLecturer.razor"
__builder.AddContent(69, lecturer.Email);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n                ");
            __builder.OpenElement(71, "div");
            __builder.AddAttribute(72, "class", "mb-1");
            __builder.AddContent(73, "PhoneNumber: ");
#nullable restore
#line (297,49)-(297,69) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LecturerPages\DetailsLecturer.razor"
__builder.AddContent(74, lecturer.PhoneNumber);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n                ");
            __builder.OpenElement(76, "div");
            __builder.AddAttribute(77, "class", "mb-1");
            __builder.AddContent(78, "Address: ");
#nullable restore
#line (298,45)-(298,61) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LecturerPages\DetailsLecturer.razor"
__builder.AddContent(79, lecturer.Address);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n                ");
            __builder.OpenElement(81, "div");
            __builder.AddAttribute(82, "class", "mb-1");
            __builder.AddContent(83, "IdentityCard: ");
#nullable restore
#line (299,50)-(299,71) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LecturerPages\DetailsLecturer.razor"
__builder.AddContent(84, lecturer.IdentityCard);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(85, "\r\n                    ");
            __builder.OpenElement(86, "div");
            __builder.AddAttribute(87, "class", "mb-1");
            __builder.AddContent(88, "IssuedOn: ");
#nullable restore
#line (300,50)-(300,90) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LecturerPages\DetailsLecturer.razor"
__builder.AddContent(89, lecturer.IssuedOn.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(90, "\r\n                ");
            __builder.OpenElement(91, "div");
            __builder.AddAttribute(92, "class", "mb-1");
            __builder.AddContent(93, "Ethnic: ");
#nullable restore
#line (301,44)-(301,59) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LecturerPages\DetailsLecturer.razor"
__builder.AddContent(94, lecturer.Ethnic);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n                ");
            __builder.OpenElement(96, "div");
            __builder.AddAttribute(97, "class", "mb-1");
            __builder.AddContent(98, "HomeTown: ");
#nullable restore
#line (302,46)-(302,63) 25 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LecturerPages\DetailsLecturer.razor"
__builder.AddContent(99, lecturer.HomeTown);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n                <hr class=\"mt-4 mb-4\">");
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n            ");
            __builder.OpenElement(102, "a");
            __builder.AddAttribute(103, "href", "/updatelecturer/" + (
#nullable restore
#line 305 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LecturerPages\DetailsLecturer.razor"
                                      id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(104, "<button type=\"submit\" class=\"btn btn-success\">Edit</button>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n\r\n        ");
            __builder.OpenElement(106, "div");
            __builder.AddAttribute(107, "class", "profile-content");
            __builder.OpenElement(108, "div");
            __builder.AddAttribute(109, "class", "row");
            __builder.OpenElement(110, "div");
            __builder.AddAttribute(111, "class", "col-xl-12");
            __builder.OpenElement(112, "div");
            __builder.AddAttribute(113, "class", "tab-content p-0");
            __builder.OpenElement(114, "div");
            __builder.AddAttribute(115, "class", "tab-pane fade active show");
            __builder.AddAttribute(116, "id", "profile-followers");
            __builder.OpenElement(117, "div");
            __builder.AddAttribute(118, "class", "list-group");
#nullable restore
#line 314 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LecturerPages\DetailsLecturer.razor"
                                 if(_lstClass.Count != 0)
                                {
                                    foreach (var item in _lstClass)
                                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(119, "div");
            __builder.AddAttribute(120, "class", "list-group-item d-flex align-items-center");
            __builder.OpenElement(121, "div");
            __builder.AddAttribute(122, "class", "flex-fill pl-3 pr-3");
            __builder.OpenElement(123, "div");
            __builder.OpenElement(124, "div");
            __builder.AddAttribute(125, "class", "text-dark font-weight-600");
#nullable restore
#line (320,94)-(320,112) 26 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LecturerPages\DetailsLecturer.razor"
__builder.AddContent(126, item.ClassroomName);

#line default
#line hidden
#nullable disable
            __builder.AddContent(127, " - ");
#nullable restore
#line (320,116)-(320,132) 26 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LecturerPages\DetailsLecturer.razor"
__builder.AddContent(128, item.SubjectName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(129, "\r\n                                                ");
            __builder.OpenElement(130, "div");
            __builder.AddAttribute(131, "class", "text-muted fs-13px");
#nullable restore
#line (321,82)-(321,98) 26 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LecturerPages\DetailsLecturer.razor"
__builder.AddContent(132, item.DateStarted);

#line default
#line hidden
#nullable disable
            __builder.AddContent(133, " - ");
#nullable restore
#line (321,102)-(321,114) 26 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LecturerPages\DetailsLecturer.razor"
__builder.AddContent(134, item.EndDate);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(135, "\r\n                                            ");
            __builder.OpenElement(136, "a");
            __builder.AddAttribute(137, "href", "/detailclass/" + (
#nullable restore
#line 323 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LecturerPages\DetailsLecturer.razor"
                                                                   item.JoinCode

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(138, "class", "btn btn-outline-primary");
            __builder.AddContent(139, "View Class");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 325 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LecturerPages\DetailsLecturer.razor"
                                    }
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(140, "<h3 text-muted mb-1>Gi???ng Vi??n Ch??a D???y L???p N??o</h3>");
#nullable restore
#line 330 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LecturerPages\DetailsLecturer.razor"
                                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 339 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LecturerPages\DetailsLecturer.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 341 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\Pages\LecturerPages\DetailsLecturer.razor"
      
        [Parameter]
        public string id { get; set; }
        private LecturersCPViewModel lecturer = new LecturersCPViewModel();
        [Inject]
        public ILecturersCPRepo _lecturerRepositories { get; set; }
        [Inject]
        public ISpecializedCPRepo _specializedCPRepo { get; set; }
        [Inject]
        public ILectuterSpecializedCPCilents _lectuterSpecializedCPCilents { get; set; }
        private List<LectuterSpecializedCPDto> _lstLecturerSpecial = new List<LectuterSpecializedCPDto>();
        private List<SpecializedDto> _lstSpecialized = new List<SpecializedDto>();
        [Inject]
        public ITaskRepositories<ClassUPViewModel> _taskRepositories { get; set; }
        private List<ClassUPViewModel> _lstClass = new List<ClassUPViewModel>();
        private PagingParameters _pagingParameters = new PagingParameters();

        private ClassUPViewModel _classUPViewModel = new ClassUPViewModel();
        private ClassSearchDTO _searchDTO = new ClassSearchDTO();
        private int _counter;

        private string specializedListString;
        protected async override Task OnInitializedAsync()
        {
            _lstLecturerSpecial = await _lectuterSpecializedCPCilents.GetAllAsync();

            lecturer = await _lecturerRepositories.GetLecturerListById(Guid.Parse(id));
            lecturer.ListSpecialized = _lstLecturerSpecial.Where(x => x.Idlecturers == lecturer.Id).Select(x => x.Idspecialized).ToList();

            if (lecturer.ListSpecialized != null)
            {
                specializedListString = await GetListSpecializedString();
            }

            await GetClassList(_searchDTO);
        }
        private async Task GetClassList(ClassSearchDTO classSearchDTO)
        {
            _counter = 0;
            var pagingResponse = await _taskRepositories.GetListDataAsync(classSearchDTO);

            _lstClass = pagingResponse.Items.Where(c => c.HomeroomLecturerEmail == lecturer.Email).ToList();
        }

        private async Task SelectedPage(int page)
        {
            _searchDTO.PageNumber = page;
            await GetClassList(_searchDTO);
        }
        private async Task SearchBar(EditContext editContext)
        {
            await GetClassList(_searchDTO);
        }

        private async Task<string> GetListSpecializedString()
        {
            string specializedList = null;

            foreach (var x in lecturer.ListSpecialized)
            {
                var specialized = await _specializedCPRepo.GetbyId(Guid.Empty, x);
                string specializedString = specialized.SpecializationName;

                Guid idspecializedBigger = Guid.Parse(specialized.IdSpeciality.ToString());
                for (int i = 0; i < specialized.Level; i++)
                {
                    var specializedBigger = await _specializedCPRepo.GetbyId(Guid.Empty, idspecializedBigger);
                    if (specializedBigger != null)
                    {
                        if (specializedBigger.IdSpeciality != null)
                        {
                            idspecializedBigger = Guid.Parse(Convert.ToString(specializedBigger.IdSpeciality));
                        }
                        specializedString = specializedBigger.SpecializationName + "-" + specializedString;
                    }
                }
                specializedList = specializedList + specializedString + ", ";
            }

            return (specializedList == null ? null : specializedList.Substring(0, specializedList.Length - 2));
        }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
