#pragma checksum "C:\Users\MURAT\source\repos\jQueryAndAjax\MVC\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b0105ead39ae204e870d4d1b7901e784cdfc3808"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\MURAT\source\repos\jQueryAndAjax\MVC\Views\_ViewImports.cshtml"
using MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\MURAT\source\repos\jQueryAndAjax\MVC\Views\_ViewImports.cshtml"
using MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0105ead39ae204e870d4d1b7901e784cdfc3808", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d7a8f56340c239c091cff637a00cc2fdf252300", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\MURAT\source\repos\jQueryAndAjax\MVC\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Ajax Samples";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Ajax Samples</h1>\r\n<p>Bring up console window</p>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b0105ead39ae204e870d4d1b7901e784cdfc38083477", async() => {
                WriteLiteral(@"
  <div class=""row"">
    <label for=""productID"">Product ID</label>
    <input id=""productID"" name=""productID""
           type=""text"" value=""0"" />
  </div>
  <div class=""row"">
    <label for=""name"">Product Name</label>
    <input id=""name"" name=""name"" type=""text"" 
           value=""A New Product"" />
  </div>
  <div class=""row"">
    <label for=""productNumber"">Product Number</label>
    <input id=""productNumber"" name=""productNumber""
           type=""text"" value=""NEW-999"" />
  </div>
  <div class=""row"">
    <label for=""color"">Color</label>
    <input id=""color"" name=""color"" type=""text""
           value=""Red"" />
  </div>
  <div class=""row"">
    <label for=""standardCost"">Cost</label>
    <input id=""standardCost"" name=""standardCost""
           type=""number"" value=""10.00"" />
  </div>
  <div class=""row"">
    <label for=""listPrice"">Price</label>
    <input id=""listPrice"" name=""listPrice""
           type=""number"" value=""25.00"" />
  </div>
  <div class=""row"">
    <label for=""sellStartDate""");
                WriteLiteral(@">Sell Start Date</label>
    <input id=""sellStartDate"" name=""sellStartDate""
           type=""text"" value=""1/15/2021"" />
  </div>
  <div class=""row"">
    <label id=""message"" class=""infoMessage""></label>
  </div>
  <div class=""row"">
    <label id=""error"" class=""errorMessage""></label>
  </div>
  <div class=""row"">
    <button type=""button"" onclick=""get();"">
      Get Products
    </button>
    <button type=""button"" onclick=""getProduct();"">
      Get a Product
    </button>
    <button type=""button"" onclick=""insertProduct();"">
      Insert Product
    </button>
    <button type=""button"" onclick=""updateProduct();"">
      Update Product
    </button>
    <button type=""button"" onclick=""deleteProduct();"">
      Delete Product
    </button>
  </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""/js/ajax-common.js""></script>
    <script src=""/js/product.js""></script>
    <script>
      'use strict';

      const URL = ""http://localhost:5000/api/product"";

      function get() { 
		let req = new XMLHttpRequest();
		req.onreadystatechange = function () {
		  if (this.readyState === XMLHttpRequest.DONE && this.status === 200) {
			console.log(this.response);
			displayMessage(""Products Retrieved"");
		  }
		};
		req.open(""GET"", URL);
		req.send();
      }

      function getProduct() { 

      }

      function insertProduct() { 

      }

      function updateProduct() { 

      }

      function deleteProduct() { 

      }
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
