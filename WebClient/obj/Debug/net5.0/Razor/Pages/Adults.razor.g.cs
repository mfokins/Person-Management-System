#pragma checksum "C:\MySpace\Disk D\SEMESTER3\DNPAssignment3\Person-Management-System\WebClient\Pages\Adults.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "29751cc63f4cb380a5fb47a317c9bca767677f3f"
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
#line 1 "C:\MySpace\Disk D\SEMESTER3\DNPAssignment3\Person-Management-System\WebClient\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\MySpace\Disk D\SEMESTER3\DNPAssignment3\Person-Management-System\WebClient\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\MySpace\Disk D\SEMESTER3\DNPAssignment3\Person-Management-System\WebClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\MySpace\Disk D\SEMESTER3\DNPAssignment3\Person-Management-System\WebClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\MySpace\Disk D\SEMESTER3\DNPAssignment3\Person-Management-System\WebClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\MySpace\Disk D\SEMESTER3\DNPAssignment3\Person-Management-System\WebClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\MySpace\Disk D\SEMESTER3\DNPAssignment3\Person-Management-System\WebClient\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\MySpace\Disk D\SEMESTER3\DNPAssignment3\Person-Management-System\WebClient\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\MySpace\Disk D\SEMESTER3\DNPAssignment3\Person-Management-System\WebClient\_Imports.razor"
using WebClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\MySpace\Disk D\SEMESTER3\DNPAssignment3\Person-Management-System\WebClient\_Imports.razor"
using WebClient.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\MySpace\Disk D\SEMESTER3\DNPAssignment3\Person-Management-System\WebClient\Pages\Adults.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\MySpace\Disk D\SEMESTER3\DNPAssignment3\Person-Management-System\WebClient\Pages\Adults.razor"
using Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Adults")]
    public partial class Adults : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Adults</h3>\r\n\r\n ");
            __builder.OpenElement(1, "p");
            __builder.AddMarkupContent(2, "\r\n        Search:\r\n        <br>\r\n        ");
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "type", "text");
            __builder.AddAttribute(5, "placeholder", "Enter to search...");
            __builder.AddAttribute(6, "onkeyup", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.KeyboardEventArgs>(this, 
#nullable restore
#line 19 "C:\MySpace\Disk D\SEMESTER3\DNPAssignment3\Person-Management-System\WebClient\Pages\Adults.razor"
                                                                                                                     ExecuteSearch

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "style", "width:100px");
            __builder.AddAttribute(8, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 19 "C:\MySpace\Disk D\SEMESTER3\DNPAssignment3\Person-Management-System\WebClient\Pages\Adults.razor"
                                                                   SearchParameter

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => SearchParameter = __value, SearchParameter));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 22 "C:\MySpace\Disk D\SEMESTER3\DNPAssignment3\Person-Management-System\WebClient\Pages\Adults.razor"
 if (adultsToShow == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(10, "<p><em>Loading...</em></p>");
#nullable restore
#line 27 "C:\MySpace\Disk D\SEMESTER3\DNPAssignment3\Person-Management-System\WebClient\Pages\Adults.razor"
}
else if (!adultsToShow.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(11, "<p><em>No Adult listed. Please add some.</em></p>");
#nullable restore
#line 33 "C:\MySpace\Disk D\SEMESTER3\DNPAssignment3\Person-Management-System\WebClient\Pages\Adults.razor"
}
else
{
   



#line default
#line hidden
#nullable disable
            __builder.OpenElement(12, "table");
            __builder.AddAttribute(13, "class", "table");
            __builder.OpenElement(14, "thead");
            __builder.OpenElement(15, "tr");
            __builder.AddMarkupContent(16, "<th>Adult ID</th>\r\n            ");
            __builder.AddMarkupContent(17, "<th>First Name</th>\r\n            ");
            __builder.AddMarkupContent(18, "<th>Last Name</th>\r\n            ");
            __builder.AddMarkupContent(19, "<th>Gender</th>\r\n            ");
            __builder.AddMarkupContent(20, "<th>Age</th>\r\n            ");
            __builder.AddMarkupContent(21, "<th>Job</th>\r\n            ");
            __builder.AddMarkupContent(22, "<th>Salary</th> \r\n            ");
            __builder.AddMarkupContent(23, "<th>Height</th>\r\n            ");
            __builder.AddMarkupContent(24, "<th>Weight</th>\r\n            ");
            __builder.AddMarkupContent(25, "<th>Hair Color</th>\r\n            ");
            __builder.AddMarkupContent(26, "<th>Eye color</th>\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(27);
            __builder.AddAttribute(28, "Policy", "SecurityLevel2");
            __builder.AddAttribute(29, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(30, "<th>Remove</th>\r\n                ");
                __builder2.AddMarkupContent(31, "<th>Edit</th>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n        ");
            __builder.OpenElement(33, "tbody");
#nullable restore
#line 61 "C:\MySpace\Disk D\SEMESTER3\DNPAssignment3\Person-Management-System\WebClient\Pages\Adults.razor"
         foreach (var item in adultsToShow)

        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(34, "tr");
            __builder.OpenElement(35, "td");
            __builder.AddContent(36, 
#nullable restore
#line 66 "C:\MySpace\Disk D\SEMESTER3\DNPAssignment3\Person-Management-System\WebClient\Pages\Adults.razor"
                     item.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                ");
            __builder.OpenElement(38, "td");
            __builder.AddContent(39, 
#nullable restore
#line 67 "C:\MySpace\Disk D\SEMESTER3\DNPAssignment3\Person-Management-System\WebClient\Pages\Adults.razor"
                     item.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                ");
            __builder.OpenElement(41, "td");
            __builder.AddContent(42, 
#nullable restore
#line 68 "C:\MySpace\Disk D\SEMESTER3\DNPAssignment3\Person-Management-System\WebClient\Pages\Adults.razor"
                     item.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                ");
            __builder.OpenElement(44, "td");
            __builder.AddContent(45, 
#nullable restore
#line 69 "C:\MySpace\Disk D\SEMESTER3\DNPAssignment3\Person-Management-System\WebClient\Pages\Adults.razor"
                     item.Sex

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                ");
            __builder.OpenElement(47, "td");
            __builder.AddContent(48, 
#nullable restore
#line 70 "C:\MySpace\Disk D\SEMESTER3\DNPAssignment3\Person-Management-System\WebClient\Pages\Adults.razor"
                     item.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                ");
            __builder.OpenElement(50, "td");
            __builder.AddContent(51, 
#nullable restore
#line 71 "C:\MySpace\Disk D\SEMESTER3\DNPAssignment3\Person-Management-System\WebClient\Pages\Adults.razor"
                     item.JobTitle.JobTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n                ");
            __builder.OpenElement(53, "td");
            __builder.AddContent(54, 
#nullable restore
#line 72 "C:\MySpace\Disk D\SEMESTER3\DNPAssignment3\Person-Management-System\WebClient\Pages\Adults.razor"
                     item.JobTitle.Salary

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(55, " \r\n                ");
            __builder.OpenElement(56, "td");
            __builder.AddContent(57, 
#nullable restore
#line 73 "C:\MySpace\Disk D\SEMESTER3\DNPAssignment3\Person-Management-System\WebClient\Pages\Adults.razor"
                     item.Height

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n                ");
            __builder.OpenElement(59, "td");
            __builder.AddContent(60, 
#nullable restore
#line 74 "C:\MySpace\Disk D\SEMESTER3\DNPAssignment3\Person-Management-System\WebClient\Pages\Adults.razor"
                     item.Weight

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                ");
            __builder.OpenElement(62, "td");
            __builder.AddContent(63, 
#nullable restore
#line 75 "C:\MySpace\Disk D\SEMESTER3\DNPAssignment3\Person-Management-System\WebClient\Pages\Adults.razor"
                     item.HairColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n                ");
            __builder.OpenElement(65, "td");
            __builder.AddContent(66, 
#nullable restore
#line 76 "C:\MySpace\Disk D\SEMESTER3\DNPAssignment3\Person-Management-System\WebClient\Pages\Adults.razor"
                     item.EyeColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(68);
            __builder.AddAttribute(69, "Policy", "SecurityLevel2");
            __builder.AddAttribute(70, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.OpenElement(71, "td");
                __builder2.OpenElement(72, "button");
                __builder2.AddAttribute(73, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 79 "C:\MySpace\Disk D\SEMESTER3\DNPAssignment3\Person-Management-System\WebClient\Pages\Adults.razor"
                                            () => RemoveAdult(item.Id)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(74, "<i class=\"oi oi-trash\" style=\"color: red\"></i>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(75, "\r\n                    ");
                __builder2.OpenElement(76, "td");
                __builder2.OpenElement(77, "button");
                __builder2.AddAttribute(78, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 86 "C:\MySpace\Disk D\SEMESTER3\DNPAssignment3\Person-Management-System\WebClient\Pages\Adults.razor"
                                            () => Edit(item.Id)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(79, "<i class=\"oi oi-pencil\" style=\"color:#1b6ec2\"></i>");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 93 "C:\MySpace\Disk D\SEMESTER3\DNPAssignment3\Person-Management-System\WebClient\Pages\Adults.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 96 "C:\MySpace\Disk D\SEMESTER3\DNPAssignment3\Person-Management-System\WebClient\Pages\Adults.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 98 "C:\MySpace\Disk D\SEMESTER3\DNPAssignment3\Person-Management-System\WebClient\Pages\Adults.razor"
       
    private IList<Adult> adultsToShow;
    private IList<Adult> allAdults;

    private string SearchParameter;  //TODO need to implement other way of filtering

    private bool ObjectVisibility(Adult adult)
    {
        if (string.IsNullOrEmpty(SearchParameter))
            return true;

        if (adult.FirstName.Contains(SearchParameter, StringComparison.OrdinalIgnoreCase))
            return true;

        if (adult.LastName.Contains(SearchParameter, StringComparison.OrdinalIgnoreCase))
            return true;

         // if (adult.JobTitle.JobTitle.Contains(SearchParameter, StringComparison.OrdinalIgnoreCase))  //Conflicting because there is "JobTitle" inside "JobTitle"
         //    return true;

        if (adult.HairColor.Contains(SearchParameter, StringComparison.OrdinalIgnoreCase))
            return true;

        if (adult.EyeColor.Contains(SearchParameter, StringComparison.OrdinalIgnoreCase))
            return true;

        if (adult.Id.ToString().StartsWith(SearchParameter) || adult.Age.ToString().StartsWith(SearchParameter))
            return true;

        if (adult.Weight.ToString().StartsWith(SearchParameter) || adult.Height.ToString().StartsWith(SearchParameter))
            return true;

        if (adult.JobTitle.Salary.ToString().StartsWith(SearchParameter))
            return true;

        return false;
    }

    private void ExecuteSearch()
    {
        IList<Adult> temp = new List<Adult>();
        foreach (Adult adult in allAdults)
        {
            if (ObjectVisibility(adult))
            {
                temp.Add(adult);
            }
        }
        adultsToShow = temp;
    }

    protected override async Task OnInitializedAsync()
    {
        allAdults = await AdultService.GetAllAdultsAsync();
        adultsToShow = allAdults;
    }

    private void RemoveAdult(int id)
    {
        Adult adultToRemove = allAdults.First(t => t.Id == id);
        AdultService.RemoveAdultAsync(id);
        allAdults.Remove(adultToRemove);
        adultsToShow.Remove(adultToRemove);
    }

    private void Edit(int id)
    {
        NavMgr.NavigateTo($"Edit/{id}");
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
