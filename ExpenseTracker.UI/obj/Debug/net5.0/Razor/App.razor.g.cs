#pragma checksum "C:\Users\NUEVO\Desktop\CHRIS\Udemy\ExpenseTracker\ExpenseTracker.UI\App.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b63402820c3631eea499e60b786c47a4c588b4cd"
// <auto-generated/>
#pragma warning disable 1591
namespace ExpenseTracker.UI
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\NUEVO\Desktop\CHRIS\Udemy\ExpenseTracker\ExpenseTracker.UI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\NUEVO\Desktop\CHRIS\Udemy\ExpenseTracker\ExpenseTracker.UI\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\NUEVO\Desktop\CHRIS\Udemy\ExpenseTracker\ExpenseTracker.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\NUEVO\Desktop\CHRIS\Udemy\ExpenseTracker\ExpenseTracker.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\NUEVO\Desktop\CHRIS\Udemy\ExpenseTracker\ExpenseTracker.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\NUEVO\Desktop\CHRIS\Udemy\ExpenseTracker\ExpenseTracker.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\NUEVO\Desktop\CHRIS\Udemy\ExpenseTracker\ExpenseTracker.UI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\NUEVO\Desktop\CHRIS\Udemy\ExpenseTracker\ExpenseTracker.UI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\NUEVO\Desktop\CHRIS\Udemy\ExpenseTracker\ExpenseTracker.UI\_Imports.razor"
using ExpenseTracker.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\NUEVO\Desktop\CHRIS\Udemy\ExpenseTracker\ExpenseTracker.UI\_Imports.razor"
using ExpenseTracker.UI.Shared;

#line default
#line hidden
#nullable disable
    public partial class App : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Routing.Router>(0);
            __builder.AddAttribute(1, "AppAssembly", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Reflection.Assembly>(
#nullable restore
#line 1 "C:\Users\NUEVO\Desktop\CHRIS\Udemy\ExpenseTracker\ExpenseTracker.UI\App.razor"
                      typeof(Program).Assembly

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(2, "PreferExactMatches", (object)(
#nullable restore
#line 1 "C:\Users\NUEVO\Desktop\CHRIS\Udemy\ExpenseTracker\ExpenseTracker.UI\App.razor"
                                                                     true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "Found", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.RouteData>)((routeData) => (__builder2) => {
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.RouteView>(4);
                __builder2.AddAttribute(5, "RouteData", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.RouteData>(
#nullable restore
#line 3 "C:\Users\NUEVO\Desktop\CHRIS\Udemy\ExpenseTracker\ExpenseTracker.UI\App.razor"
                               routeData

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(6, "DefaultLayout", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Type>(
#nullable restore
#line 3 "C:\Users\NUEVO\Desktop\CHRIS\Udemy\ExpenseTracker\ExpenseTracker.UI\App.razor"
                                                          typeof(MainLayout)

#line default
#line hidden
#nullable disable
                )));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(7, "NotFound", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.LayoutView>(8);
                __builder2.AddAttribute(9, "Layout", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Type>(
#nullable restore
#line 6 "C:\Users\NUEVO\Desktop\CHRIS\Udemy\ExpenseTracker\ExpenseTracker.UI\App.razor"
                             typeof(MainLayout)

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(10, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(11, "<p>Sorry, there\'s nothing at this address.</p>");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
