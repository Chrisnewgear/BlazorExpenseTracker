#pragma checksum "C:\Users\NUEVO\Desktop\CHRIS\Udemy\ExpenseTracker\ExpenseTracker.UI\Pages\Categories.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e56244c38d6eaf7c210b36a950340b42caef9b6f"
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
#line 2 "C:\Users\NUEVO\Desktop\CHRIS\Udemy\ExpenseTracker\ExpenseTracker.UI\Pages\Categories.razor"
using BlazorExpenseTracker.Model;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/categories")]
    public partial class Categories : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Categories</h1>");
#nullable restore
#line 6 "C:\Users\NUEVO\Desktop\CHRIS\Udemy\ExpenseTracker\ExpenseTracker.UI\Pages\Categories.razor"
 if(categories == null)
{ 

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>");
#nullable restore
#line 9 "C:\Users\NUEVO\Desktop\CHRIS\Udemy\ExpenseTracker\ExpenseTracker.UI\Pages\Categories.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "table");
            __builder.AddMarkupContent(3, "<thead><tr><th>Name</th></tr></thead>\r\n        ");
            __builder.OpenElement(4, "tbody");
#nullable restore
#line 17 "C:\Users\NUEVO\Desktop\CHRIS\Udemy\ExpenseTracker\ExpenseTracker.UI\Pages\Categories.razor"
             foreach(var category in categories)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "tr");
            __builder.OpenElement(6, "td");
#nullable restore
#line 20 "C:\Users\NUEVO\Desktop\CHRIS\Udemy\ExpenseTracker\ExpenseTracker.UI\Pages\Categories.razor"
__builder.AddContent(7, category.Name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 22 "C:\Users\NUEVO\Desktop\CHRIS\Udemy\ExpenseTracker\ExpenseTracker.UI\Pages\Categories.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 25 "C:\Users\NUEVO\Desktop\CHRIS\Udemy\ExpenseTracker\ExpenseTracker.UI\Pages\Categories.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "C:\Users\NUEVO\Desktop\CHRIS\Udemy\ExpenseTracker\ExpenseTracker.UI\Pages\Categories.razor"
       
    private IEnumerable<Category> categories = new List<Category>
    {
        new Category{Id = 1, Name = "Shopping"},
        new Category{Id = 2, Name = "Fuel"}
    };

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
