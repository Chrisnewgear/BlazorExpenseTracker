#pragma checksum "C:\Users\NUEVO\Desktop\CHRIS\Udemy\ExpenseTracker\ExpenseTracker.UI\Pages\CategoryDetails.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "870783c1c136e4d8ec35b8cdf29c02d34758dcf1"
// <auto-generated/>
#pragma warning disable 1591
namespace ExpenseTracker.UI.Pages
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
#nullable restore
#line 2 "C:\Users\NUEVO\Desktop\CHRIS\Udemy\ExpenseTracker\ExpenseTracker.UI\Pages\CategoryDetails.razor"
using BlazorExpenseTracker.Model;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/categorydetails")]
    public partial class CategoryDetails : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>CategoryDetails</h1>\r\n\r\n");
            __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::System.Object>(
#nullable restore
#line 6 "C:\Users\NUEVO\Desktop\CHRIS\Udemy\ExpenseTracker\ExpenseTracker.UI\Pages\CategoryDetails.razor"
                  category

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "OnValidSubmit", (object)(global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<global::Microsoft.AspNetCore.Components.EventCallback<global::Microsoft.AspNetCore.Components.Forms.EditContext>>(global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 6 "C:\Users\NUEVO\Desktop\CHRIS\Udemy\ExpenseTracker\ExpenseTracker.UI\Pages\CategoryDetails.razor"
                                           SaveCategory

#line default
#line hidden
#nullable disable
            ))));
            __builder.AddAttribute(4, "ChildContent", (global::Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n\r\n    ");
                __builder2.OpenElement(7, "table");
                __builder2.AddAttribute(8, "class", "table");
                __builder2.OpenElement(9, "tr");
                __builder2.AddMarkupContent(10, "<td>Name</td>\r\n            ");
                __builder2.OpenElement(11, "td");
                __builder2.OpenElement(12, "input");
                __builder2.AddAttribute(13, "type", "text");
                __builder2.AddAttribute(14, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Users\NUEVO\Desktop\CHRIS\Udemy\ExpenseTracker\ExpenseTracker.UI\Pages\CategoryDetails.razor"
                                          category.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(15, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => category.Name = __value, category.Name));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(16, "\r\n        ");
                __builder2.OpenElement(17, "tr");
                __builder2.OpenElement(18, "td");
                __builder2.AddAttribute(19, "colspan", "2");
                global::__Blazor.ExpenseTracker.UI.Pages.CategoryDetails.TypeInference.CreateValidationMessage_0(__builder2, 20, 21, 
#nullable restore
#line 17 "C:\Users\NUEVO\Desktop\CHRIS\Udemy\ExpenseTracker\ExpenseTracker.UI\Pages\CategoryDetails.razor"
                                                      ()=>category.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(22, "\r\n\r\n        ");
                __builder2.AddMarkupContent(23, "<tr><td colspan=\"2\" style=\"text-align:center;\"><input type=\"submit\" value=\"Save\">\r\n                <input type=\"button\" value=\"Cancel\"></td></tr>");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 31 "C:\Users\NUEVO\Desktop\CHRIS\Udemy\ExpenseTracker\ExpenseTracker.UI\Pages\CategoryDetails.razor"
       
    Category category = new Category();

    protected void SaveCategory()
    {

    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.ExpenseTracker.UI.Pages.CategoryDetails
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", (object)__arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591