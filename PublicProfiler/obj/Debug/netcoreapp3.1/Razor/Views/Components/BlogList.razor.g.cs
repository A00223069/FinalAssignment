#pragma checksum "D:\AMAN\CreateEdit\Create-Edit\PublicProfiler\Views\Components\BlogList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c80935c60d3c90e209b3c645d732f877919f76cd"
// <auto-generated/>
#pragma warning disable 1591
namespace PublicProfiler.Views.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\AMAN\CreateEdit\Create-Edit\PublicProfiler\Views\Components\BlogList.razor"
using PublicProfiler.Models;

#line default
#line hidden
#nullable disable
    public partial class BlogList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Blog List</h3>\r\n\r\n");
            __builder.OpenElement(1, "dl");
#nullable restore
#line 7 "D:\AMAN\CreateEdit\Create-Edit\PublicProfiler\Views\Components\BlogList.razor"
     foreach (BlogPost blog in ModelList)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "dt");
            __builder.AddContent(3, 
#nullable restore
#line 9 "D:\AMAN\CreateEdit\Create-Edit\PublicProfiler\Views\Components\BlogList.razor"
             blog.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(4, " ");
            __builder.AddContent(5, 
#nullable restore
#line 9 "D:\AMAN\CreateEdit\Create-Edit\PublicProfiler\Views\Components\BlogList.razor"
                        blog.AuthorEmail

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "dd");
            __builder.AddContent(8, 
#nullable restore
#line 10 "D:\AMAN\CreateEdit\Create-Edit\PublicProfiler\Views\Components\BlogList.razor"
             blog.Content

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 11 "D:\AMAN\CreateEdit\Create-Edit\PublicProfiler\Views\Components\BlogList.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "D:\AMAN\CreateEdit\Create-Edit\PublicProfiler\Views\Components\BlogList.razor"
       
    [Parameter]
    public IEnumerable<BlogPost> ModelList { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
