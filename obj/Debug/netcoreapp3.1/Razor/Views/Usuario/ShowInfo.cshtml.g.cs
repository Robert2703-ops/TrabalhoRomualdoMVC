#pragma checksum "E:\Trabalho_Romualdo\Views\Usuario\ShowInfo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e9a33553d921e55a71b5f45d8cdd76438e61445"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_ShowInfo), @"mvc.1.0.view", @"/Views/Usuario/ShowInfo.cshtml")]
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
#line 1 "E:\Trabalho_Romualdo\Views\_ViewImports.cshtml"
using Trabalho_Romualdo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Trabalho_Romualdo\Views\_ViewImports.cshtml"
using Trabalho_Romualdo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e9a33553d921e55a71b5f45d8cdd76438e61445", @"/Views/Usuario/ShowInfo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79c87088066d311d73e99a42b618471000f8a4c9", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_ShowInfo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e9a33553d921e55a71b5f45d8cdd76438e614453191", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Document</title>
    <style>
        body{
            background-color: #6495ED;
        }
        div{
            text-align: center;
        }
        p{
          font: Arial 50px;  
        }
        th{
            text-align: center;
            font-weight: 100;
        }
        table{
            margin-left: auto;
            margin-right: auto;
        }
    </style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e9a33553d921e55a71b5f45d8cdd76438e614454680", async() => {
                WriteLiteral("\r\n    ");
#nullable restore
#line 28 "E:\Trabalho_Romualdo\Views\Usuario\ShowInfo.cshtml"
Write(Model);

#line default
#line hidden
#nullable disable
                WriteLiteral(" TrabalhoRomualdo.Models.Usuario   \r\n    <div>\r\n        <h1>Obrigado por preencher o formulário ");
#nullable restore
#line 30 "E:\Trabalho_Romualdo\Views\Usuario\ShowInfo.cshtml"
                                           Write(Model.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n        <p>\r\n            Então você nasceu em ");
#nullable restore
#line 32 "E:\Trabalho_Romualdo\Views\Usuario\ShowInfo.cshtml"
                            Write(Model.BirthDate);

#line default
#line hidden
#nullable disable
                WriteLiteral(", ");
#nullable restore
#line 32 "E:\Trabalho_Romualdo\Views\Usuario\ShowInfo.cshtml"
                                              Write(Model.BirthDay);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <br/>           \r\n        </p>\r\n    </div>\r\n    <div>\r\n      <p>Seu IMC é de: <strong>");
#nullable restore
#line 36 "E:\Trabalho_Romualdo\Views\Usuario\ShowInfo.cshtml"
                          Write(Model.IMC);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" </strong><br/>
        analise seu Indice de Massa Corporal na tabela abaixo
      </p>
    </div>
        <table border=""3"">
          <tr>
            <th>IMC</th>
            <th>Resultado</th>
          </tr>
          <tr>
            <td width=""65%"">Menos do que 18,5</td>
            <td width=""57%"">Abaixo do peso</td>
          </tr>
          <tr>
            <td>Entre 18,5 e 24,9</td>
            <td>Peso normal</td>
          </tr>
          <tr>
            <td>Entre 25 e 29,9</td>
            <td>Sobrepeso</td>
          </tr>
          <tr>
            <td>Entre 30 e 34,9</td>
            <td>Obesidade grau 1</td>
           </tr>
         </table>   
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
