#pragma checksum "C:\SIEMPRE.NET\CURSO PRACTICO\PROYECTO REGISTROAUSEN\REGISTRODEAUSENCIAS.Blazor\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8306156e2ae11a05f58a79e81560c6b5dba0e9c"
// <auto-generated/>
#pragma warning disable 1591
namespace REGISTRODEAUSENCIAS.Blazor.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\SIEMPRE.NET\CURSO PRACTICO\PROYECTO REGISTROAUSEN\REGISTRODEAUSENCIAS.Blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\SIEMPRE.NET\CURSO PRACTICO\PROYECTO REGISTROAUSEN\REGISTRODEAUSENCIAS.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\SIEMPRE.NET\CURSO PRACTICO\PROYECTO REGISTROAUSEN\REGISTRODEAUSENCIAS.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\SIEMPRE.NET\CURSO PRACTICO\PROYECTO REGISTROAUSEN\REGISTRODEAUSENCIAS.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\SIEMPRE.NET\CURSO PRACTICO\PROYECTO REGISTROAUSEN\REGISTRODEAUSENCIAS.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\SIEMPRE.NET\CURSO PRACTICO\PROYECTO REGISTROAUSEN\REGISTRODEAUSENCIAS.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\SIEMPRE.NET\CURSO PRACTICO\PROYECTO REGISTROAUSEN\REGISTRODEAUSENCIAS.Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\SIEMPRE.NET\CURSO PRACTICO\PROYECTO REGISTROAUSEN\REGISTRODEAUSENCIAS.Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\SIEMPRE.NET\CURSO PRACTICO\PROYECTO REGISTROAUSEN\REGISTRODEAUSENCIAS.Blazor\_Imports.razor"
using REGISTRODEAUSENCIAS.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\SIEMPRE.NET\CURSO PRACTICO\PROYECTO REGISTROAUSEN\REGISTRODEAUSENCIAS.Blazor\_Imports.razor"
using REGISTRODEAUSENCIAS.Blazor.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-u43zdgv2uz");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "sidebar");
            __builder.AddAttribute(5, "b-u43zdgv2uz");
            __builder.OpenComponent<REGISTRODEAUSENCIAS.Blazor.Shared.NavMenu>(6);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n\r\n    ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "main");
            __builder.AddAttribute(10, "b-u43zdgv2uz");
            __builder.AddMarkupContent(11, "<div class=\"top-row px-4\" b-u43zdgv2uz><span b-u43zdgv2uz>Nombre de usuario</span>\r\n            <span b-u43zdgv2uz>Salir</span></div>\r\n\r\n        ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "content px-4");
            __builder.AddAttribute(14, "b-u43zdgv2uz");
            __builder.AddContent(15, 
#nullable restore
#line 15 "C:\SIEMPRE.NET\CURSO PRACTICO\PROYECTO REGISTROAUSEN\REGISTRODEAUSENCIAS.Blazor\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
