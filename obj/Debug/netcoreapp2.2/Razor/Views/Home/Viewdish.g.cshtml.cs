#pragma checksum "/Users/macbook/Desktop/CSharp_stack/Entity_framework/first_entity/Views/Home/Viewdish.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "da0833b027263a4e269380ae58f964e2f0b8df26"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Viewdish), @"mvc.1.0.view", @"/Views/Home/Viewdish.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Viewdish.cshtml", typeof(AspNetCore.Views_Home_Viewdish))]
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
#line 1 "/Users/macbook/Desktop/CSharp_stack/Entity_framework/first_entity/Views/_ViewImports.cshtml"
using first_entity;

#line default
#line hidden
#line 1 "/Users/macbook/Desktop/CSharp_stack/Entity_framework/first_entity/Views/Home/Viewdish.cshtml"
using first_entity.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da0833b027263a4e269380ae58f964e2f0b8df26", @"/Views/Home/Viewdish.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cff2f5c6e0f0d205013a86f8614d54c1747e7e5d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Viewdish : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Dish>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(39, 51, true);
            WriteLiteral("\n\n            <a href=\"/\">Home</a>\n\n            <p>");
            EndContext();
            BeginContext(91, 12, false);
#line 7 "/Users/macbook/Desktop/CSharp_stack/Entity_framework/first_entity/Views/Home/Viewdish.cshtml"
          Write(Model.DishId);

#line default
#line hidden
            EndContext();
            BeginContext(103, 21, true);
            WriteLiteral("</p>\n\n            <p>");
            EndContext();
            BeginContext(125, 10, false);
#line 9 "/Users/macbook/Desktop/CSharp_stack/Entity_framework/first_entity/Views/Home/Viewdish.cshtml"
          Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(135, 31, true);
            WriteLiteral("</p>\n\n\n            <p>Calories:");
            EndContext();
            BeginContext(167, 14, false);
#line 12 "/Users/macbook/Desktop/CSharp_stack/Entity_framework/first_entity/Views/Home/Viewdish.cshtml"
                   Write(Model.Calories);

#line default
#line hidden
            EndContext();
            BeginContext(181, 31, true);
            WriteLiteral("</p>\n\n            <p>Tastiness:");
            EndContext();
            BeginContext(213, 15, false);
#line 14 "/Users/macbook/Desktop/CSharp_stack/Entity_framework/first_entity/Views/Home/Viewdish.cshtml"
                    Write(Model.Tastiness);

#line default
#line hidden
            EndContext();
            BeginContext(228, 35, true);
            WriteLiteral("</p>\n\n            <a class=\"Delete\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 263, "\"", 291, 2);
            WriteAttributeValue("", 270, "/Delete/", 270, 8, true);
#line 16 "/Users/macbook/Desktop/CSharp_stack/Entity_framework/first_entity/Views/Home/Viewdish.cshtml"
WriteAttributeValue("", 278, Model.DishId, 278, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(292, 41, true);
            WriteLiteral(">Delete</a>\n\n            <a  class=\"Edit\"");
            EndContext();
            BeginWriteAttribute("href", "href=\"", 333, "\"", 362, 2);
            WriteAttributeValue("", 339, "/Editdish/", 339, 10, true);
#line 18 "/Users/macbook/Desktop/CSharp_stack/Entity_framework/first_entity/Views/Home/Viewdish.cshtml"
WriteAttributeValue("", 349, Model.DishId, 349, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(363, 9, true);
            WriteLiteral(">Edit</a>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Dish> Html { get; private set; }
    }
}
#pragma warning restore 1591
