#pragma checksum "C:\MySpace\Disk D\SEMESTER3\DNPAssignment2\WebApplication\WebClient\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19483ebeb9c748d437e52891c90b804ced3505d7"
// <auto-generated/>
#pragma warning disable 1591
namespace WebClient.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\MySpace\Disk D\SEMESTER3\DNPAssignment2\WebApplication\WebClient\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\MySpace\Disk D\SEMESTER3\DNPAssignment2\WebApplication\WebClient\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\MySpace\Disk D\SEMESTER3\DNPAssignment2\WebApplication\WebClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\MySpace\Disk D\SEMESTER3\DNPAssignment2\WebApplication\WebClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\MySpace\Disk D\SEMESTER3\DNPAssignment2\WebApplication\WebClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\MySpace\Disk D\SEMESTER3\DNPAssignment2\WebApplication\WebClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\MySpace\Disk D\SEMESTER3\DNPAssignment2\WebApplication\WebClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\MySpace\Disk D\SEMESTER3\DNPAssignment2\WebApplication\WebClient\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\MySpace\Disk D\SEMESTER3\DNPAssignment2\WebApplication\WebClient\_Imports.razor"
using WebClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\MySpace\Disk D\SEMESTER3\DNPAssignment2\WebApplication\WebClient\_Imports.razor"
using WebClient.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Hello, user!</h1>\r\n\r\nWelcome to the adult management system. \r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(1);
            __builder.AddAttribute(2, "NotAuthorized", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(3, "\r\n    Please proceed with ");
                __builder2.AddMarkupContent(4, "<a href=\"/login\">login</a>!\r\n    ");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591