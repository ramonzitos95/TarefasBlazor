#pragma checksum "D:\Programação\projetos blazor\BlazorTarefa\BlazorTarefa\Pages\Evento1.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81e18f1c54840216b766dc760ec5c374ecc45c9c"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorTarefa.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Programação\projetos blazor\BlazorTarefa\BlazorTarefa\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Programação\projetos blazor\BlazorTarefa\BlazorTarefa\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Programação\projetos blazor\BlazorTarefa\BlazorTarefa\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Programação\projetos blazor\BlazorTarefa\BlazorTarefa\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Programação\projetos blazor\BlazorTarefa\BlazorTarefa\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Programação\projetos blazor\BlazorTarefa\BlazorTarefa\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Programação\projetos blazor\BlazorTarefa\BlazorTarefa\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Programação\projetos blazor\BlazorTarefa\BlazorTarefa\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Programação\projetos blazor\BlazorTarefa\BlazorTarefa\_Imports.razor"
using BlazorTarefa;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Programação\projetos blazor\BlazorTarefa\BlazorTarefa\_Imports.razor"
using BlazorTarefa.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Programação\projetos blazor\BlazorTarefa\BlazorTarefa\_Imports.razor"
using BlazorTarefa.Entidades;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/evento1")]
    public partial class Evento1 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<label>Dados de eventos: Pressione a Tecla A para mudar a cor</label>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "style", "background-color:" + " " + (
#nullable restore
#line 5 "D:\Programação\projetos blazor\BlazorTarefa\BlazorTarefa\Pages\Evento1.razor"
                               cor

#line default
#line hidden
#nullable disable
            ) + ";" + " padding:50px;");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 6 "D:\Programação\projetos blazor\BlazorTarefa\BlazorTarefa\Pages\Evento1.razor"
       
    private string cor = "red";

    void TeclaPressionada(KeyboardEventArgs args)
    {
        if(args.Key=="A" || args.Key=="a")
        {
            cor = "blue";
            Console.WriteLine("A tecla A/a foi pressionada");
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
