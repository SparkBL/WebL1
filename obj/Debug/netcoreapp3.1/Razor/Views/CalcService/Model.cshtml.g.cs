#pragma checksum "C:\Users\gooob\source\repos\WebL_1\Views\CalcService\Model.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b04502cbd8f626ca1559c4514cb95a194d63f0d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CalcService_Model), @"mvc.1.0.view", @"/Views/CalcService/Model.cshtml")]
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
#line 1 "C:\Users\gooob\source\repos\WebL_1\Views\_ViewImports.cshtml"
using WebL_1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gooob\source\repos\WebL_1\Views\_ViewImports.cshtml"
using WebL_1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b04502cbd8f626ca1559c4514cb95a194d63f0d", @"/Views/CalcService/Model.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff7eac0b8014980879f8738033a6f79d4d7fe1fa", @"/Views/_ViewImports.cshtml")]
    public class Views_CalcService_Model : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebL_1.Models.ICalcUnit>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\gooob\source\repos\WebL_1\Views\CalcService\Model.cshtml"
  
    ViewData["Title"] = "ViewModel";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2 style=\"padding-bottom:20px\">ViewModel</h2>\r\n \r\n<h6>Rand Value First: ");
#nullable restore
#line 8 "C:\Users\gooob\source\repos\WebL_1\Views\CalcService\Model.cshtml"
                 Write(Model.a);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h6>\r\n<h6>Rand Value Second: ");
#nullable restore
#line 9 "C:\Users\gooob\source\repos\WebL_1\Views\CalcService\Model.cshtml"
                  Write(Model.b);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n<h6>Add: ");
#nullable restore
#line 10 "C:\Users\gooob\source\repos\WebL_1\Views\CalcService\Model.cshtml"
    Write(Model.a);

#line default
#line hidden
#nullable disable
            WriteLiteral(" + ");
#nullable restore
#line 10 "C:\Users\gooob\source\repos\WebL_1\Views\CalcService\Model.cshtml"
               Write(Model.b);

#line default
#line hidden
#nullable disable
            WriteLiteral(" = ");
#nullable restore
#line 10 "C:\Users\gooob\source\repos\WebL_1\Views\CalcService\Model.cshtml"
                          Write(Model.Sum());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n<h6>Sub: ");
#nullable restore
#line 11 "C:\Users\gooob\source\repos\WebL_1\Views\CalcService\Model.cshtml"
    Write(Model.a);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 11 "C:\Users\gooob\source\repos\WebL_1\Views\CalcService\Model.cshtml"
               Write(Model.b);

#line default
#line hidden
#nullable disable
            WriteLiteral(" = ");
#nullable restore
#line 11 "C:\Users\gooob\source\repos\WebL_1\Views\CalcService\Model.cshtml"
                          Write(Model.Min());

#line default
#line hidden
#nullable disable
            WriteLiteral("  </h6>\r\n<h6>Mult: ");
#nullable restore
#line 12 "C:\Users\gooob\source\repos\WebL_1\Views\CalcService\Model.cshtml"
     Write(Model.a);

#line default
#line hidden
#nullable disable
            WriteLiteral(" * ");
#nullable restore
#line 12 "C:\Users\gooob\source\repos\WebL_1\Views\CalcService\Model.cshtml"
                Write(Model.b);

#line default
#line hidden
#nullable disable
            WriteLiteral(" = ");
#nullable restore
#line 12 "C:\Users\gooob\source\repos\WebL_1\Views\CalcService\Model.cshtml"
                           Write(Model.Mult());

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h6>\r\n<h6>Mult: ");
#nullable restore
#line 13 "C:\Users\gooob\source\repos\WebL_1\Views\CalcService\Model.cshtml"
     Write(Model.a);

#line default
#line hidden
#nullable disable
            WriteLiteral(" / ");
#nullable restore
#line 13 "C:\Users\gooob\source\repos\WebL_1\Views\CalcService\Model.cshtml"
                Write(Model.b);

#line default
#line hidden
#nullable disable
            WriteLiteral(" = ");
#nullable restore
#line 13 "C:\Users\gooob\source\repos\WebL_1\Views\CalcService\Model.cshtml"
                           Write(Model.Div());

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebL_1.Models.ICalcUnit> Html { get; private set; }
    }
}
#pragma warning restore 1591
