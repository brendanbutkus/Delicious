#pragma checksum "/Users/brendanbutkus/Desktop/CSharp/Delicious/Views/Home/oneDish.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a7bb0ebc7621174ac05db7e953f422f92c64dc8e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_oneDish), @"mvc.1.0.view", @"/Views/Home/oneDish.cshtml")]
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
#line 1 "/Users/brendanbutkus/Desktop/CSharp/Delicious/Views/_ViewImports.cshtml"
using Delicious;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/brendanbutkus/Desktop/CSharp/Delicious/Views/_ViewImports.cshtml"
using Delicious.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7bb0ebc7621174ac05db7e953f422f92c64dc8e", @"/Views/Home/oneDish.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0e35dda39f592391f888af2310e784bfd314357", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_oneDish : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dishes>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<h1>Name: ");
#nullable restore
#line 3 "/Users/brendanbutkus/Desktop/CSharp/Delicious/Views/Home/oneDish.cshtml"
     Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n<h2>Chef: ");
#nullable restore
#line 4 "/Users/brendanbutkus/Desktop/CSharp/Delicious/Views/Home/oneDish.cshtml"
     Write(Model.Chef);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n<h2>Tastiness: ");
#nullable restore
#line 5 "/Users/brendanbutkus/Desktop/CSharp/Delicious/Views/Home/oneDish.cshtml"
          Write(Model.Tastiness);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n<h2>Calories: ");
#nullable restore
#line 6 "/Users/brendanbutkus/Desktop/CSharp/Delicious/Views/Home/oneDish.cshtml"
         Write(Model.Calories);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n<h2>Description: ");
#nullable restore
#line 7 "/Users/brendanbutkus/Desktop/CSharp/Delicious/Views/Home/oneDish.cshtml"
            Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n\n<a");
            BeginWriteAttribute("href", " href=\"", 185, "\"", 213, 2);
            WriteAttributeValue("", 192, "/delete/", 192, 8, true);
#nullable restore
#line 9 "/Users/brendanbutkus/Desktop/CSharp/Delicious/Views/Home/oneDish.cshtml"
WriteAttributeValue("", 200, Model.DishId, 200, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete</a>\n<a");
            BeginWriteAttribute("href", " href=\"", 251, "\"", 277, 2);
            WriteAttributeValue("", 258, "/edit/", 258, 6, true);
#nullable restore
#line 10 "/Users/brendanbutkus/Desktop/CSharp/Delicious/Views/Home/oneDish.cshtml"
WriteAttributeValue("", 264, Model.DishId, 264, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Edit</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dishes> Html { get; private set; }
    }
}
#pragma warning restore 1591
