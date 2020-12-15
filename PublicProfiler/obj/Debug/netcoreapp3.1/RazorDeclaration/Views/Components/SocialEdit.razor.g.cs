// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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