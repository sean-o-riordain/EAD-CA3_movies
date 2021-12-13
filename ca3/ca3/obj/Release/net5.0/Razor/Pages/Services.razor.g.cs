#pragma checksum "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Services.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ceeac8b3bcb3705efc65018d7ca37dd691d281b8"
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
            __builder.AddMarkupContent(0, "<h1>Services</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>List of all streaming services and channels</p>");
#nullable restore
#line 8 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Services.razor"
 if (servicesList == null || regions == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>");
#nullable restore
#line 11 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Services.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "select");
            __builder.AddAttribute(4, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 14 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Services.razor"
                       setRegion

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(5, "option");
            __builder.AddAttribute(6, "value", "all");
            __builder.AddContent(7, "All");
            __builder.CloseElement();
#nullable restore
#line 16 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Services.razor"
         foreach (var region in regions)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "option");
            __builder.AddAttribute(9, "value", 
#nullable restore
#line 18 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Services.razor"
                           region.country

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(10, 
#nullable restore
#line 18 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Services.razor"
                                           region.name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 19 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Services.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.OpenElement(11, "select");
            __builder.AddAttribute(12, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 22 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Services.razor"
                       setPaymentType

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(13, "option");
            __builder.AddAttribute(14, "value", "all");
            __builder.AddContent(15, "All");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.OpenElement(17, "option");
            __builder.AddAttribute(18, "value", "sub");
            __builder.AddContent(19, "Subscription");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n        ");
            __builder.OpenElement(21, "option");
            __builder.AddAttribute(22, "value", "free");
            __builder.AddContent(23, "Free");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n        ");
            __builder.OpenElement(25, "option");
            __builder.AddAttribute(26, "value", "tve");
            __builder.AddContent(27, "TV Channel App");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n        ");
            __builder.OpenElement(29, "option");
            __builder.AddAttribute(30, "value", "purchase");
            __builder.AddContent(31, "purchase");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 30 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Services.razor"
     foreach (var service in servicesList)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Services.razor"
         if (region == "all" && paymentType == "all")
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(32, "<p>**************</p>\r\n            ");
            __builder.OpenElement(33, "p");
            __builder.AddContent(34, 
#nullable restore
#line 35 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Services.razor"
                service.name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(35, " ");
            __builder.AddContent(36, 
#nullable restore
#line 35 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Services.razor"
                              service.type

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n            ");
            __builder.OpenElement(38, "a");
            __builder.AddAttribute(39, "href", "/servicesTitles/" + (
#nullable restore
#line 36 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Services.razor"
                                      service.id

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(40, "img");
            __builder.AddAttribute(41, "src", 
#nullable restore
#line 36 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Services.razor"
                                                             service.logo_100px

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n            ");
            __builder.AddMarkupContent(43, "<p>****************</p>");
#nullable restore
#line 38 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Services.razor"
        }
        else if (region != "all" && paymentType == "all")
        {

            

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Services.razor"
             if (service.regions.Any(region.Contains))
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(44, "<p>**************</p>\r\n                ");
            __builder.OpenElement(45, "p");
            __builder.AddContent(46, 
#nullable restore
#line 45 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Services.razor"
                    service.name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(47, " ");
            __builder.AddContent(48, 
#nullable restore
#line 45 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Services.razor"
                                  service.type

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                ");
            __builder.OpenElement(50, "a");
            __builder.AddAttribute(51, "href", "/servicesTitles/" + (
#nullable restore
#line 46 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Services.razor"
                                          service.id

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(52, "img");
            __builder.AddAttribute(53, "src", 
#nullable restore
#line 46 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Services.razor"
                                                                 service.logo_100px

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                ");
            __builder.AddMarkupContent(55, "<p>****************</p>");
#nullable restore
#line 48 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Services.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Services.razor"
             
        }
        else if (region == "all" && paymentType != "all")
        {

            

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Services.razor"
             if (service.type == paymentType)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(56, "<p>**************</p>\r\n                ");
            __builder.OpenElement(57, "p");
            __builder.AddContent(58, 
#nullable restore
#line 56 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Services.razor"
                    service.name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(59, " ");
            __builder.AddContent(60, 
#nullable restore
#line 56 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Services.razor"
                                  service.type

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                ");
            __builder.OpenElement(62, "a");
            __builder.AddAttribute(63, "href", "/servicesTitles/" + (
#nullable restore
#line 57 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Services.razor"
                                          service.id

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(64, "img");
            __builder.AddAttribute(65, "src", 
#nullable restore
#line 57 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Services.razor"
                                                                 service.logo_100px

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n                ");
            __builder.AddMarkupContent(67, "<p>****************</p>");
#nullable restore
#line 59 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Services.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Services.razor"
             
        }
        else
        {

            

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Services.razor"
             if ((service.regions.Any(region.Contains)) && service.type == paymentType)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(68, "<p>**************</p>\r\n                ");
            __builder.OpenElement(69, "p");
            __builder.AddContent(70, 
#nullable restore
#line 67 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Services.razor"
                    service.name

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(71, " ");
            __builder.AddContent(72, 
#nullable restore
#line 67 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Services.razor"
                                  service.type

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n                ");
            __builder.OpenElement(74, "a");
            __builder.AddAttribute(75, "href", "/servicesTitles/" + (
#nullable restore
#line 68 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Services.razor"
                                          service.id

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(76, "img");
            __builder.AddAttribute(77, "src", 
#nullable restore
#line 68 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Services.razor"
                                                                 service.logo_100px

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n                ");
            __builder.AddMarkupContent(79, "<p>****************</p>");
#nullable restore
#line 70 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Services.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Services.razor"
             
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Services.razor"
         
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Services.razor"
     

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 76 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Services.razor"
       
    private ServicesClass[] servicesList;
    private Countries[] regions;
    private string region = "all";
    private string paymentType = "all";


    protected override async Task OnInitializedAsync()
    {
        regions = await Http.GetFromJsonAsync<Countries[]>("https://api.watchmode.com/v1/regions/?apiKey=vMCQ0i6AkMxAo5afgFFjxSZVpAbpM6oiPNprmEZl");

        servicesList = await Http.GetFromJsonAsync<ServicesClass[]>("https://api.watchmode.com/v1/sources/?apiKey=vMCQ0i6AkMxAo5afgFFjxSZVpAbpM6oiPNprmEZl");



    }

    public void setRegion(ChangeEventArgs e)
    {
        region = e.Value.ToString();
    }

    public void setPaymentType(ChangeEventArgs e)
    {
        paymentType = e.Value.ToString();
    }

    /*
    <select @onchange="setGenre">
        <option value="@int.MaxValue">All</option>
        @foreach (var genre in genres)
        {
            <option value=@genre.id>@genre.name</option>
        }
    </select>
    genres = await Http.GetFromJsonAsync<Genres[]>("https://api.watchmode.com/v1/genres/?apiKey=vMCQ0i6AkMxAo5afgFFjxSZVpAbpM6oiPNprmEZl");
    private Genres[] genres;
    private int genre = int.MaxValue;
    public void setGenre(ChangeEventArgs e)
    {
        genre = Int32.Parse(e.Value.ToString());
    }
    public class Genres
    {
        public int id { get; set; }
        public string name { get; set; }
        public int? tmdb_id { get; set; }
    }*/

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