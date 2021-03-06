#pragma checksum "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Services.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fdb4be334ffab234da47c75dc973e0fa72a57299"
// <auto-generated/>
#pragma warning disable 1591
namespace ca3.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\College\Year 4\EAD\ca3\ca3\ca3\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\College\Year 4\EAD\ca3\ca3\ca3\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\College\Year 4\EAD\ca3\ca3\ca3\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\College\Year 4\EAD\ca3\ca3\ca3\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\College\Year 4\EAD\ca3\ca3\ca3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\College\Year 4\EAD\ca3\ca3\ca3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\College\Year 4\EAD\ca3\ca3\ca3\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\College\Year 4\EAD\ca3\ca3\ca3\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\College\Year 4\EAD\ca3\ca3\ca3\_Imports.razor"
using ca3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\College\Year 4\EAD\ca3\ca3\ca3\_Imports.razor"
using ca3.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Services : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 id=\"title\">Services</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>List of all streaming services and channels</p>\r\n");
            __builder.AddMarkupContent(2, "<p>Click any Streaming Service to start searching for a title to watch </p>");
#nullable restore
#line 9 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Services.razor"
 if (servicesList == null || regions == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(3, "<p><em>Loading...</em></p>");
#nullable restore
#line 12 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Services.razor"
}
else
{   

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(4, "<p>Region:</p>\r\n    ");
            __builder.OpenElement(5, "select");
            __builder.AddAttribute(6, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 16 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Services.razor"
                       setRegion

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(7, "option");
            __builder.AddAttribute(8, "value", "all");
            __builder.AddContent(9, "All");
            __builder.CloseElement();
#nullable restore
#line 18 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Services.razor"
         foreach (var region in regions)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(10, "option");
            __builder.AddAttribute(11, "value", 
#nullable restore
#line 20 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Services.razor"
                           region.country

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(12, 
#nullable restore
#line 20 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Services.razor"
                                           region.name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 21 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Services.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "<p>Payment Type:</p>\r\n    ");
            __builder.OpenElement(14, "select");
            __builder.AddAttribute(15, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 25 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Services.razor"
                       setPaymentType

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(16, "option");
            __builder.AddAttribute(17, "value", "all");
            __builder.AddContent(18, "All");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.OpenElement(20, "option");
            __builder.AddAttribute(21, "value", "sub");
            __builder.AddContent(22, "Subscription");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.OpenElement(24, "option");
            __builder.AddAttribute(25, "value", "free");
            __builder.AddContent(26, "Free");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n        ");
            __builder.OpenElement(28, "option");
            __builder.AddAttribute(29, "value", "tve");
            __builder.AddContent(30, "TV Channel App");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n        ");
            __builder.OpenElement(32, "option");
            __builder.AddAttribute(33, "value", "purchase");
            __builder.AddContent(34, "purchase");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "row");
            __builder.AddMarkupContent(37, "<div class=\"col-1 border\"><h5>Search All streaming Services</h5>\r\n            <a href=\"/servicesTitles/0\" id=\"allServices\">Click Here</a></div>");
#nullable restore
#line 38 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Services.razor"
         foreach (var service in servicesList)
        {

            

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Services.razor"
             if (region == "all" && paymentType == "all")
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "col-1 border");
            __builder.OpenElement(40, "h5");
            __builder.AddContent(41, 
#nullable restore
#line 44 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Services.razor"
                         service.name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.OpenElement(42, "p");
            __builder.AddContent(43, "type: ");
            __builder.AddContent(44, 
#nullable restore
#line 44 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Services.razor"
                                                    service.type

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                    ");
            __builder.OpenElement(46, "a");
            __builder.AddAttribute(47, "href", "/servicesTitles/" + (
#nullable restore
#line 45 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Services.razor"
                                              service.id

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(48, "img");
            __builder.AddAttribute(49, "src", 
#nullable restore
#line 45 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Services.razor"
                                                                     service.logo_100px

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 47 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Services.razor"
            }
            else if (region != "all" && paymentType == "all")
            {

                

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Services.razor"
                 if (service.regions.Any(region.Contains))
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(50, "div");
            __builder.AddAttribute(51, "class", "col-1 border");
            __builder.OpenElement(52, "h5");
            __builder.AddContent(53, 
#nullable restore
#line 55 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Services.razor"
                             service.name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.OpenElement(54, "p");
            __builder.AddContent(55, "type: ");
            __builder.AddContent(56, 
#nullable restore
#line 55 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Services.razor"
                                                         service.type

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                        ");
            __builder.OpenElement(58, "a");
            __builder.AddAttribute(59, "href", "/servicesTitles/" + (
#nullable restore
#line 56 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Services.razor"
                                                  service.id

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(60, "img");
            __builder.AddAttribute(61, "src", 
#nullable restore
#line 56 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Services.razor"
                                                                         service.logo_100px

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 59 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Services.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Services.razor"
                 
            }
            else if (region == "all" && paymentType != "all")
            {

                

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Services.razor"
                 if (service.type == paymentType)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(62, "div");
            __builder.AddAttribute(63, "class", "col-1 border");
            __builder.OpenElement(64, "h5");
            __builder.AddContent(65, 
#nullable restore
#line 68 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Services.razor"
                             service.name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.OpenElement(66, "p");
            __builder.AddContent(67, "type: ");
            __builder.AddContent(68, 
#nullable restore
#line 68 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Services.razor"
                                                         service.type

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n                        ");
            __builder.OpenElement(70, "a");
            __builder.AddAttribute(71, "href", "/servicesTitles/" + (
#nullable restore
#line 69 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Services.razor"
                                                  service.id

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(72, "img");
            __builder.AddAttribute(73, "src", 
#nullable restore
#line 69 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Services.razor"
                                                                         service.logo_100px

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 72 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Services.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Services.razor"
                 
            }
            else
            {

                

#line default
#line hidden
#nullable disable
#nullable restore
#line 77 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Services.razor"
                 if ((service.regions.Any(region.Contains)) && service.type == paymentType)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(74, "div");
            __builder.AddAttribute(75, "class", "col-1 border");
            __builder.OpenElement(76, "h5");
            __builder.AddContent(77, 
#nullable restore
#line 81 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Services.razor"
                             service.name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.OpenElement(78, "p");
            __builder.AddContent(79, "type: ");
            __builder.AddContent(80, 
#nullable restore
#line 81 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Services.razor"
                                                         service.type

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n                        ");
            __builder.OpenElement(82, "a");
            __builder.AddAttribute(83, "href", "/servicesTitles/" + (
#nullable restore
#line 82 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Services.razor"
                                                  service.id

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(84, "img");
            __builder.AddAttribute(85, "src", 
#nullable restore
#line 82 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Services.razor"
                                                                         service.logo_100px

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 85 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Services.razor"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 85 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Services.razor"
                 
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 86 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Services.razor"
             

        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 90 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Services.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 92 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Services.razor"
       
    private ServicesClass[] servicesList;
    private Countries[] regions;
    private string region = "all";
    private string paymentType = "all";


    protected override async Task OnInitializedAsync()
    {
        regions = await Http.GetFromJsonAsync<Countries[]>("https://api.watchmode.com/v1/regions/?apiKey=yvWxtCM9fYbj3Zg5NmEEK6bJtJnPSe6C6XfFj11m");

        servicesList = await Http.GetFromJsonAsync<ServicesClass[]>("https://api.watchmode.com/v1/sources/?apiKey=yvWxtCM9fYbj3Zg5NmEEK6bJtJnPSe6C6XfFj11m");



    }

    public void setRegion(ChangeEventArgs e)
    {
        region = e.Value.ToString();
    }

    public void setPaymentType(ChangeEventArgs e)
    {
        paymentType = e.Value.ToString();
    }



    public class ServicesClass
    {
        public int id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public string logo_100px { get; set; }
        public string ios_appstore_url { get; set; }
        public string android_playstore_url { get; set; }
        public string android_scheme { get; set; }
        public string ios_scheme { get; set; }
        public List<string> regions { get; set; }
    }

    public class Countries
    {
        public string country { get; set; }
        public string name { get; set; }
        public string flag { get; set; }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
