#pragma checksum "D:\AMAN\CreateEdit\Create-Edit\PublicProfiler\Views\Components\SocialEdit.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba07cfdc7cb651fd7b0379887e4177360cde9e04"
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
#line 1 "D:\AMAN\CreateEdit\Create-Edit\PublicProfiler\Views\Components\SocialEdit.razor"
using System.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\AMAN\CreateEdit\Create-Edit\PublicProfiler\Views\Components\SocialEdit.razor"
using PublicProfiler.Models;

#line default
#line hidden
#nullable disable
    public partial class SocialEdit : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Social Edit</h3>\r\n\r\n    ");
            __builder.OpenElement(1, "form");
            __builder.AddAttribute(2, "action", 
#nullable restore
#line 6 "D:\AMAN\CreateEdit\Create-Edit\PublicProfiler\Views\Components\SocialEdit.razor"
                   url

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(3, "method", "post");
            __builder.OpenElement(4, "input");
            __builder.AddAttribute(5, "type", "hidden");
            __builder.AddAttribute(6, "name", "SocialId");
            __builder.AddAttribute(7, "value", 
#nullable restore
#line 8 "D:\AMAN\CreateEdit\Create-Edit\PublicProfiler\Views\Components\SocialEdit.razor"
                                                     social.SocialId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n        ");
            __builder.OpenElement(9, "label");
            __builder.AddContent(10, "Website: ");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "type", "text");
            __builder.AddAttribute(13, "name", "Website");
            __builder.AddAttribute(14, "value", 
#nullable restore
#line 9 "D:\AMAN\CreateEdit\Create-Edit\PublicProfiler\Views\Components\SocialEdit.razor"
                                                                  social.Website

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.OpenElement(16, "label");
            __builder.AddContent(17, "Social Media URL: ");
            __builder.OpenElement(18, "input");
            __builder.AddAttribute(19, "type", "text");
            __builder.AddAttribute(20, "name", "SocialMediaURL");
            __builder.AddAttribute(21, "value", 
#nullable restore
#line 10 "D:\AMAN\CreateEdit\Create-Edit\PublicProfiler\Views\Components\SocialEdit.razor"
                                                                                  social.SocialMediaURL

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n        ");
            __builder.OpenElement(23, "label");
            __builder.AddContent(24, "Active Since: ");
            __builder.OpenElement(25, "input");
            __builder.AddAttribute(26, "type", "datetime-local");
            __builder.AddAttribute(27, "name", "SocialMediaURL");
            __builder.AddAttribute(28, "value", 
#nullable restore
#line 11 "D:\AMAN\CreateEdit\Create-Edit\PublicProfiler\Views\Components\SocialEdit.razor"
                                                                                        social.ActiveSince

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n        ");
            __builder.OpenElement(30, "label");
            __builder.AddContent(31, "User ID: ");
            __builder.OpenElement(32, "input");
            __builder.AddAttribute(33, "type", "hidden");
            __builder.AddAttribute(34, "name", "UserId");
            __builder.AddAttribute(35, "value", 
#nullable restore
#line 12 "D:\AMAN\CreateEdit\Create-Edit\PublicProfiler\Views\Components\SocialEdit.razor"
                                                                   social.UserId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n\r\n\r\n            ");
            __builder.OpenElement(37, "label");
            __builder.AddContent(38, "User Name: ");
            __builder.OpenElement(39, "span");
            __builder.AddContent(40, 
#nullable restore
#line 17 "D:\AMAN\CreateEdit\Create-Edit\PublicProfiler\Views\Components\SocialEdit.razor"
                                     social.User.Alias

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(41, ", ");
            __builder.AddContent(42, 
#nullable restore
#line 17 "D:\AMAN\CreateEdit\Create-Edit\PublicProfiler\Views\Components\SocialEdit.razor"
                                                         social.User.RealName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n            ");
            __builder.OpenElement(44, "input");
            __builder.AddAttribute(45, "type", "hidden");
            __builder.AddAttribute(46, "name", "User.UserId");
            __builder.AddAttribute(47, "value", 
#nullable restore
#line 18 "D:\AMAN\CreateEdit\Create-Edit\PublicProfiler\Views\Components\SocialEdit.razor"
                                                            social.User.UserId

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n\r\n        ");
            __builder.OpenElement(49, "input");
            __builder.AddAttribute(50, "type", "submit");
            __builder.AddAttribute(51, "name", "submit");
            __builder.AddAttribute(52, "value", 
#nullable restore
#line 30 "D:\AMAN\CreateEdit\Create-Edit\PublicProfiler\Views\Components\SocialEdit.razor"
                                                   buttonMode

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "D:\AMAN\CreateEdit\Create-Edit\PublicProfiler\Views\Components\SocialEdit.razor"
           
        private Social _social = new Social();

        private string url
        {
            get
            {
                string ret = String.Empty;

                if (_social.SocialId < 1)
                {
                    ret = String.Concat(baseUrl, "/Create").Replace("//", "/");
                    return ret;
                }
                ret = String.Concat(baseUrl, "/Edit", _social.SocialId.ToString()).Replace("//", "/");

                return ret;
            }
        }


        //  private IEnumerable<User> _users


        private string buttonMode
        {
            get
            {
                if (_social.SocialId < 1)
                {
                    return baseUrl;
                }

                return "Update Post";
            }
        }


        private bool isUserAvailable
        {
            get
            {
                if (_social.SocialId < 1)
                {
                    return false;
                }
                return true;
            }
        }

        [Parameter]
        public Social social
        {
            set
            {
                _social = value;
            }
            get
            {
                return _social;
            }
        }

        [Parameter]
        public string baseUrl { get; set; }

    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591