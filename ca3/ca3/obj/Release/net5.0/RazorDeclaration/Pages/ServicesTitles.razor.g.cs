// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/servicesTitles/{serviceId:int}")]
    public partial class ServicesTitles : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\ServicesTitles.razor"
       


    [Parameter]
    public int serviceId { get; set; }

    private Titles titlesList;

    protected override async Task OnInitializedAsync()
    {
        string httpString = $"https://api.watchmode.com/v1/list-titles/?apiKey=vMCQ0i6AkMxAo5afgFFjxSZVpAbpM6oiPNprmEZl&source_ids={serviceId}";
        titlesList = await Http.GetFromJsonAsync<Titles>(httpString);
    }

    public class Title
    {
        public int id { get; set; }
        public string title { get; set; }
        public int year { get; set; }
        public string imdb_id { get; set; }
        public int tmdb_id { get; set; }
        public string tmdb_type { get; set; }
        public string type { get; set; }
    }

    public class Titles
    {
        public List<Title> titles { get; set; }
        public int page { get; set; }
        public int total_results { get; set; }
        public int total_pages { get; set; }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
