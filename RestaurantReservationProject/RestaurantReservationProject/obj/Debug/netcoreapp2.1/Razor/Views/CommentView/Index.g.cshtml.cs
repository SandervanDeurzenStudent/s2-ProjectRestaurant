#pragma checksum "C:\Users\Sander van Deurzen\source\repos\FONTYS\s2-herstart\s2-ProjectRestaurant\RestaurantReservationProject\RestaurantReservationProject\Views\CommentView\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ebf482870d3e0a5e63736dfe00367c50e0a09aa4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CommentView_Index), @"mvc.1.0.view", @"/Views/CommentView/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/CommentView/Index.cshtml", typeof(AspNetCore.Views_CommentView_Index))]
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
#line 1 "C:\Users\Sander van Deurzen\source\repos\FONTYS\s2-herstart\s2-ProjectRestaurant\RestaurantReservationProject\RestaurantReservationProject\Views\_ViewImports.cshtml"
using RestaurantReservationProject;

#line default
#line hidden
#line 2 "C:\Users\Sander van Deurzen\source\repos\FONTYS\s2-herstart\s2-ProjectRestaurant\RestaurantReservationProject\RestaurantReservationProject\Views\_ViewImports.cshtml"
using RestaurantReservationProject.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ebf482870d3e0a5e63736dfe00367c50e0a09aa4", @"/Views/CommentView/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08460831ceaf8c40f7043b8808cf65be8d3cc65e", @"/Views/_ViewImports.cshtml")]
    public class Views_CommentView_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Presentation.Models.CommentViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(58, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Sander van Deurzen\source\repos\FONTYS\s2-herstart\s2-ProjectRestaurant\RestaurantReservationProject\RestaurantReservationProject\Views\CommentView\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(148, 115, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(264, 40, false);
#line 16 "C:\Users\Sander van Deurzen\source\repos\FONTYS\s2-herstart\s2-ProjectRestaurant\RestaurantReservationProject\RestaurantReservationProject\Views\CommentView\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(304, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(360, 40, false);
#line 19 "C:\Users\Sander van Deurzen\source\repos\FONTYS\s2-herstart\s2-ProjectRestaurant\RestaurantReservationProject\RestaurantReservationProject\Views\CommentView\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Info));

#line default
#line hidden
            EndContext();
            BeginContext(400, 63, true);
            WriteLiteral("\r\n            </th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 24 "C:\Users\Sander van Deurzen\source\repos\FONTYS\s2-herstart\s2-ProjectRestaurant\RestaurantReservationProject\RestaurantReservationProject\Views\CommentView\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(495, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(544, 39, false);
#line 27 "C:\Users\Sander van Deurzen\source\repos\FONTYS\s2-herstart\s2-ProjectRestaurant\RestaurantReservationProject\RestaurantReservationProject\Views\CommentView\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(583, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(639, 39, false);
#line 30 "C:\Users\Sander van Deurzen\source\repos\FONTYS\s2-herstart\s2-ProjectRestaurant\RestaurantReservationProject\RestaurantReservationProject\Views\CommentView\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Info));

#line default
#line hidden
            EndContext();
            BeginContext(678, 73, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(751, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "44fe7ebd0ec7412594f8dfe212f73a4d", async() => {
                BeginContext(798, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 34 "C:\Users\Sander van Deurzen\source\repos\FONTYS\s2-herstart\s2-ProjectRestaurant\RestaurantReservationProject\RestaurantReservationProject\Views\CommentView\Index.cshtml"
                                         WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(808, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 37 "C:\Users\Sander van Deurzen\source\repos\FONTYS\s2-herstart\s2-ProjectRestaurant\RestaurantReservationProject\RestaurantReservationProject\Views\CommentView\Index.cshtml"
}

#line default
#line hidden
            BeginContext(847, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Presentation.Models.CommentViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
