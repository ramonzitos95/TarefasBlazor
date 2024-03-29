#pragma checksum "D:\Programação\projetos blazor\BlazorTarefa\BlazorTarefa\Shared\Tarefas.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "234007e4e2026409900c89da860ec2404a1c45f3"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorTarefa.Shared
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
    public partial class Tarefas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h1");
            __builder.AddContent(1, 
#nullable restore
#line 2 "D:\Programação\projetos blazor\BlazorTarefa\BlazorTarefa\Shared\Tarefas.razor"
     Titulo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(2, "\r\n\r\n");
            __builder.OpenElement(3, "table");
            __builder.AddAttribute(4, "class", "table");
            __builder.AddMarkupContent(5, "<thead><tr><th>Data</th>\r\n            <th>Descrição</th>\r\n            <th>Concluida</th></tr></thead>\r\n    ");
            __builder.OpenElement(6, "tbody");
            __Blazor.BlazorTarefa.Shared.Tarefas.TypeInference.CreateListaGenerica_0(__builder, 7, 8, 
#nullable restore
#line 13 "D:\Programação\projetos blazor\BlazorTarefa\BlazorTarefa\Shared\Tarefas.razor"
                                  tarefas

#line default
#line hidden
#nullable disable
            , 9, (tarefa) => (__builder2) => {
                __builder2.OpenComponent<BlazorTarefa.Shared.TarefaIndividual>(10);
                __builder2.AddAttribute(11, "item", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<BlazorTarefa.Entidades.Tarefa>(
#nullable restore
#line 15 "D:\Programação\projetos blazor\BlazorTarefa\BlazorTarefa\Shared\Tarefas.razor"
                                        tarefa

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "RemoverTarefa", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<BlazorTarefa.Entidades.Tarefa>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<BlazorTarefa.Entidades.Tarefa>(this, 
#nullable restore
#line 15 "D:\Programação\projetos blazor\BlazorTarefa\BlazorTarefa\Shared\Tarefas.razor"
                                                               RemoveTarefa

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
            }
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 22 "D:\Programação\projetos blazor\BlazorTarefa\BlazorTarefa\Shared\Tarefas.razor"
 if (tarefas != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "form-group");
            __builder.AddMarkupContent(15, "<label>Tarefa</label>\r\n        ");
            __builder.OpenElement(16, "input");
            __builder.AddAttribute(17, "type", "text");
            __builder.AddAttribute(18, "placeholder", "Informe a tarefa");
            __builder.AddAttribute(19, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 26 "D:\Programação\projetos blazor\BlazorTarefa\BlazorTarefa\Shared\Tarefas.razor"
                                                                 novaTarefa

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => novaTarefa = __value, novaTarefa));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n        ");
            __builder.OpenElement(22, "button");
            __builder.AddAttribute(23, "class", "btn-primary");
            __builder.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 27 "D:\Programação\projetos blazor\BlazorTarefa\BlazorTarefa\Shared\Tarefas.razor"
                                              AdicionarNovaTarefa

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(25, "Registrar Tarefa");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 29 "D:\Programação\projetos blazor\BlazorTarefa\BlazorTarefa\Shared\Tarefas.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "D:\Programação\projetos blazor\BlazorTarefa\BlazorTarefa\Shared\Tarefas.razor"
       

    [Parameter] public List<Tarefa> tarefas { get; set; }
    [Parameter] public String Titulo { get; set; }

    private string novaTarefa = "";

    void AdicionarNovaTarefa()
    {
        if (!string.IsNullOrWhiteSpace(novaTarefa))

            tarefas.Add(new Tarefa()
            {
                DataCriacao = DateTime.Now,
                Descricao = novaTarefa,
                ID = Guid.NewGuid()
            });
        novaTarefa = "";
    }

    private void RemoveTarefa(Tarefa tarefa)
    {
        tarefas.Remove(tarefas.First(x => x.ID == tarefa.ID));
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.BlazorTarefa.Shared.Tarefas
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateListaGenerica_0<Titem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.List<Titem> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment<Titem> __arg1)
        {
        __builder.OpenComponent<global::BlazorTarefa.Shared.ListaGenerica<Titem>>(seq);
        __builder.AddAttribute(__seq0, "ListaItem", __arg0);
        __builder.AddAttribute(__seq1, "Lista", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
