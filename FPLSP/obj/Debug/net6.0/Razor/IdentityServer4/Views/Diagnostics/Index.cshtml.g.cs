#pragma checksum "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\IdentityServer4\Views\Diagnostics\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df4cf1f1a739f1572e607b7045d8d314480aa991"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.IdentityServer4_Views_Diagnostics_Index), @"mvc.1.0.view", @"/IdentityServer4/Views/Diagnostics/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\IdentityServer4\Views\_ViewImports.cshtml"
using IdentityServerHost.Quickstart.UI;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df4cf1f1a739f1572e607b7045d8d314480aa991", @"/IdentityServer4/Views/Diagnostics/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a00496e1714fb62801584a343cc1019e13a800a", @"/IdentityServer4/Views/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("Identifier", "/IdentityServer4/Views/Diagnostics/Index.cshtml")]
    [global::System.Runtime.CompilerServices.CreateNewOnMetadataUpdateAttribute]
    #nullable restore
    public class IdentityServer4_Views_Diagnostics_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DiagnosticsViewModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div class=""diagnostics-page"">
    <div class=""lead"">
        <h1>Authentication Cookie</h1>
    </div>

    <div class=""row"">
        <div class=""col"">
            <div class=""card"">
                <div class=""card-header"">
                    <h2>Claims</h2>
                </div>
                <div class=""card-body"">
                    <dl>
");
#nullable restore
#line 16 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\IdentityServer4\Views\Diagnostics\Index.cshtml"
                         foreach (var claim in Model.AuthenticateResult.Principal.Claims)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <dt>");
#nullable restore
#line (18,34)-(18,44) 6 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\IdentityServer4\Views\Diagnostics\Index.cshtml"
Write(claim.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n                            <dd>");
#nullable restore
#line (19,34)-(19,45) 6 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\IdentityServer4\Views\Diagnostics\Index.cshtml"
Write(claim.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n");
#nullable restore
#line 20 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\IdentityServer4\Views\Diagnostics\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </dl>
                </div>
            </div>
        </div>
        
        <div class=""col"">
            <div class=""card"">
                <div class=""card-header"">
                    <h2>Properties</h2>
                </div>
                <div class=""card-body"">
                    <dl>
");
#nullable restore
#line 33 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\IdentityServer4\Views\Diagnostics\Index.cshtml"
                         foreach (var prop in Model.AuthenticateResult.Properties.Items)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <dt>");
#nullable restore
#line (35,34)-(35,42) 6 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\IdentityServer4\Views\Diagnostics\Index.cshtml"
Write(prop.Key);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dt>\r\n                            <dd>");
#nullable restore
#line (36,34)-(36,44) 6 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\IdentityServer4\Views\Diagnostics\Index.cshtml"
Write(prop.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n");
#nullable restore
#line 37 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\IdentityServer4\Views\Diagnostics\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\IdentityServer4\Views\Diagnostics\Index.cshtml"
                         if (Model.Clients.Any())
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <dt>Clients</dt>\r\n                            <dd>\r\n");
#nullable restore
#line 42 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\IdentityServer4\Views\Diagnostics\Index.cshtml"
                              
                                var clients = Model.Clients.ToArray();
                                for(var i = 0; i < clients.Length; i++)
                                {
                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line (46,44)-(46,54) 6 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\IdentityServer4\Views\Diagnostics\Index.cshtml"
Write(clients[i]);

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\IdentityServer4\Views\Diagnostics\Index.cshtml"
                                                            
                                    if (i < clients.Length - 1)
                                    {
                                        

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 49 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\IdentityServer4\Views\Diagnostics\Index.cshtml"
                                                       
                                    }
                                }
                            

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </dd>\r\n");
#nullable restore
#line 54 "C:\Users\Nguyen Bui\source\repos\FPLSP3\FPLSP\IdentityServer4\Views\Diagnostics\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </dl>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DiagnosticsViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591