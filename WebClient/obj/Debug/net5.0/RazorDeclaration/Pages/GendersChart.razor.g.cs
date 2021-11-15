// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace WebClient.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\MySpace\Disk D\SEMESTER3\DNPAssignment3\PersonManagement\WebClient\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\MySpace\Disk D\SEMESTER3\DNPAssignment3\PersonManagement\WebClient\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\MySpace\Disk D\SEMESTER3\DNPAssignment3\PersonManagement\WebClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\MySpace\Disk D\SEMESTER3\DNPAssignment3\PersonManagement\WebClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\MySpace\Disk D\SEMESTER3\DNPAssignment3\PersonManagement\WebClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\MySpace\Disk D\SEMESTER3\DNPAssignment3\PersonManagement\WebClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\MySpace\Disk D\SEMESTER3\DNPAssignment3\PersonManagement\WebClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\MySpace\Disk D\SEMESTER3\DNPAssignment3\PersonManagement\WebClient\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\MySpace\Disk D\SEMESTER3\DNPAssignment3\PersonManagement\WebClient\_Imports.razor"
using WebClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\MySpace\Disk D\SEMESTER3\DNPAssignment3\PersonManagement\WebClient\_Imports.razor"
using WebClient.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\MySpace\Disk D\SEMESTER3\DNPAssignment3\PersonManagement\WebClient\Pages\GendersChart.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\MySpace\Disk D\SEMESTER3\DNPAssignment3\PersonManagement\WebClient\Pages\GendersChart.razor"
using Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\MySpace\Disk D\SEMESTER3\DNPAssignment3\PersonManagement\WebClient\Pages\GendersChart.razor"
using C1.Chart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\MySpace\Disk D\SEMESTER3\DNPAssignment3\PersonManagement\WebClient\Pages\GendersChart.razor"
using C1.Blazor.Chart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\MySpace\Disk D\SEMESTER3\DNPAssignment3\PersonManagement\WebClient\Pages\GendersChart.razor"
           [Authorize(Policy = "SecurityLevel1")]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Genders")]
    public partial class GendersChart : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 19 "C:\MySpace\Disk D\SEMESTER3\DNPAssignment3\PersonManagement\WebClient\Pages\GendersChart.razor"
       

    private IList<Adult> allAdults; //TODO make it work (need to implement WEB API methods to sort by gender)
    private int Male;
    private int Female;
    private int Other;

    protected override async Task OnInitializedAsync()
    {
        allAdults = await AdultService.GetAllAdultsAsync();
        GetMaleNumber();
        GetFemaleNumber();
        GetOtherNumber();
    }

    private List<object> GetGenders()
    {
        return new List<object>
        {
            new
            {
                gender = "M",
                number = Male,
            },
            new
            {
                gender = "F",
                number = Female
            },
            new
            {
                gender = "Other",
                number = Other
            }
        };
    }

    private void GetMaleNumber()
    {
        IList<Adult> count = allAdults.Where(adult => adult.Sex == "M").ToList();
        int temp = count.Count;
        Male = temp;
    }

    private void GetFemaleNumber()
    {
        IList<Adult> count = allAdults.Where(adult => adult.Sex == "F").ToList();
        int temp = count.Count;
        Female = temp;
    }

    private void GetOtherNumber()
    {
        IList<Adult> count = allAdults.Where(adult => adult.Sex == "Other").ToList();
        int temp = count.Count;
        Other = temp;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavMgr { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserService UserService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdultService AdultService { get; set; }
    }
}
#pragma warning restore 1591