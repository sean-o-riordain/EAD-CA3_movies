#pragma checksum "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Title.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8b78d809a5ae9a9d7d812fdae6536645e282375a"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/title/{titleId:int}")]
    public partial class Title : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 4 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Title.razor"
 if (title == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<p><em>Loading....</em></p>");
#nullable restore
#line 7 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Title.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-4");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "row");
            __builder.OpenElement(7, "h1");
            __builder.AddAttribute(8, "id", "title");
            __builder.AddContent(9, 
#nullable restore
#line 13 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Title.razor"
                            title.title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "row");
            __builder.OpenElement(13, "h4");
            __builder.AddContent(14, "Runtime: ");
            __builder.AddContent(15, 
#nullable restore
#line 16 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Title.razor"
                              title.runtime_minutes

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(16, " minutes");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "row");
            __builder.OpenElement(20, "p");
            __builder.AddContent(21, "Age Rating: ");
            __builder.AddContent(22, 
#nullable restore
#line 19 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Title.razor"
                                title.us_rating

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n            ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "row");
#nullable restore
#line 23 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Title.razor"
                 if (title.type == "tv_series")
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Title.razor"
                     if (title.end_year != null)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(26, "p");
            __builder.AddContent(27, "Tv Series Running ");
            __builder.AddContent(28, 
#nullable restore
#line 27 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Title.razor"
                                              title.year

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(29, " - ");
            __builder.AddContent(30, 
#nullable restore
#line 27 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Title.razor"
                                                            title.end_year

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 28 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Title.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(31, "p");
            __builder.AddContent(32, "Tv Series Running ");
            __builder.AddContent(33, 
#nullable restore
#line 31 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Title.razor"
                                              title.year

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(34, " - ongoing");
            __builder.CloseElement();
#nullable restore
#line 32 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Title.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Title.razor"
                     

                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(35, "p");
            __builder.AddContent(36, 
#nullable restore
#line 37 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Title.razor"
                        title.type

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(37, ": ");
            __builder.AddContent(38, 
#nullable restore
#line 37 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Title.razor"
                                     title.year

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 38 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Title.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n            ");
            __builder.OpenElement(40, "div");
            __builder.AddAttribute(41, "class", "row");
            __builder.OpenElement(42, "p");
            __builder.AddContent(43, "UserRating: ");
            __builder.AddContent(44, 
#nullable restore
#line 42 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Title.razor"
                                title.user_rating

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(45, " <br> critic score: ");
            __builder.AddContent(46, 
#nullable restore
#line 42 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Title.razor"
                                                                        title.critic_score

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n        ");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "col-4");
            __builder.OpenElement(50, "h4");
            __builder.AddContent(51, 
#nullable restore
#line 46 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Title.razor"
                 title.plot_overview

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "<h3>Genres:</h3>");
#nullable restore
#line 56 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Title.razor"
     foreach (var g in title.genres)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Title.razor"
         foreach (var l in genres)
        {
            if (g == l.id)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(53, "p");
            __builder.AddContent(54, 
#nullable restore
#line 62 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Title.razor"
                    l.name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 63 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Title.razor"
            }

        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 65 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Title.razor"
         
    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(55, "<h4>\r\n        Cast and Crew\r\n    </h4>");
#nullable restore
#line 71 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Title.razor"
     if (CastExpanded)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(56, "button");
            __builder.AddAttribute(57, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 73 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Title.razor"
                           CollapseCast

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(58, "Collapse");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n        ");
            __builder.OpenElement(60, "table");
            __builder.OpenElement(61, "thead");
            __builder.OpenElement(62, "tr");
            __builder.AddMarkupContent(63, "<td>Headshot</td>\r\n                    ");
            __builder.AddMarkupContent(64, "<td>Name</td>\r\n                    ");
            __builder.AddMarkupContent(65, "<td>Role</td>");
#nullable restore
#line 80 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Title.razor"
                     if (title.type == "tv_series")
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(66, "<td>Episode Count</td>");
#nullable restore
#line 83 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Title.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n            ");
            __builder.OpenElement(68, "tbody");
#nullable restore
#line 88 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Title.razor"
                 foreach (var c in title.cast_crew)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(69, "tr");
            __builder.OpenElement(70, "td");
            __builder.OpenElement(71, "img");
            __builder.AddAttribute(72, "src", 
#nullable restore
#line 91 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Title.razor"
                                   c.headshot_url

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 92 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Title.razor"
                     if (c.person_id != null)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(73, "td");
            __builder.AddAttribute(74, "id", "castName");
            __builder.OpenElement(75, "a");
            __builder.AddAttribute(76, "href", "/personinfo/" + (
#nullable restore
#line 94 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Title.razor"
                                                                c.person_id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(77, 
#nullable restore
#line 94 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Title.razor"
                                                                              c.full_name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 95 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Title.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(78, "td");
            __builder.AddContent(79, 
#nullable restore
#line 98 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Title.razor"
                             c.full_name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 99 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Title.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(80, "td");
            __builder.AddContent(81, 
#nullable restore
#line 101 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Title.razor"
                         c.role

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 102 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Title.razor"
                     if (title.type == "tv_series")
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(82, "td");
            __builder.AddContent(83, 
#nullable restore
#line 104 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Title.razor"
                             c.episode_count

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 105 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Title.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 107 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Title.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 110 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Title.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(84, "button");
            __builder.AddAttribute(85, "id", "expandCast");
            __builder.AddAttribute(86, "class", "btn-info");
            __builder.AddAttribute(87, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 113 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Title.razor"
                                                           ExpandCast

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(88, "Expand");
            __builder.CloseElement();
#nullable restore
#line 114 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Title.razor"

    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 117 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Title.razor"
     if (title.type == "tv_series")
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(89, "<h3>Season</h3>");
#nullable restore
#line 120 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Title.razor"
         if (SeasonExpanded)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(90, "button");
            __builder.AddAttribute(91, "class", "btn-info");
            __builder.AddAttribute(92, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 122 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Title.razor"
                                               CollapseSeason

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(93, "Collapse");
            __builder.CloseElement();
            __builder.AddMarkupContent(94, "\r\n            ");
            __builder.OpenElement(95, "table");
            __builder.AddMarkupContent(96, "<thead><tr><td>Poster</td>\r\n                        <td>Name</td>\r\n                        <td>Episode Count</td>\r\n                        <td>Overview</td></tr></thead>");
#nullable restore
#line 132 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Title.razor"
                 foreach (var s in title.seasons)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(97, "tbody");
            __builder.OpenElement(98, "tr");
            __builder.OpenElement(99, "td");
            __builder.OpenElement(100, "img");
            __builder.AddAttribute(101, "src", 
#nullable restore
#line 136 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Title.razor"
                                           s.poster_url

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(102, "\r\n                            ");
            __builder.OpenElement(103, "td");
            __builder.AddContent(104, 
#nullable restore
#line 137 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Title.razor"
                                 s.name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n                            ");
            __builder.OpenElement(106, "td");
            __builder.AddContent(107, 
#nullable restore
#line 138 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Title.razor"
                                 s.episode_count

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n                            ");
            __builder.OpenElement(109, "td");
            __builder.AddContent(110, 
#nullable restore
#line 139 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Title.razor"
                                 s.overview

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 143 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Title.razor"

                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 147 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Title.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(111, "button");
            __builder.AddAttribute(112, "class", "btn-info");
            __builder.AddAttribute(113, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 150 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Title.razor"
                                               ExpandSeason

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(114, "Expand");
            __builder.CloseElement();
#nullable restore
#line 151 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Title.razor"

        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 152 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Title.razor"
         


    }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(115, "<h4>\r\n        Similar Titles\r\n    </h4>");
#nullable restore
#line 160 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Title.razor"
     if (IsExpanded)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(116, "button");
            __builder.AddAttribute(117, "class", "btn-info");
            __builder.AddAttribute(118, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 162 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Title.razor"
                                           Collapse

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(119, "Collapse");
            __builder.CloseElement();
            __builder.AddMarkupContent(120, "\r\n        ");
            __builder.OpenElement(121, "table");
            __builder.AddAttribute(122, "class", "table");
            __builder.AddMarkupContent(123, "<thead><tr><td>Title</td>\r\n                    <td>Year</td>\r\n                    <td>Critic Score</td></tr></thead>\r\n            ");
            __builder.OpenElement(124, "tbody");
#nullable restore
#line 172 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Title.razor"
                 if (similarTitles != null)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 174 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Title.razor"
                     foreach (var t in similarTitles)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(125, "tr");
            __builder.OpenElement(126, "td");
            __builder.OpenElement(127, "a");
            __builder.AddAttribute(128, "href", "/title/" + (
#nullable restore
#line 177 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Title.razor"
                                                 t.id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(129, 
#nullable restore
#line 177 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Title.razor"
                                                        t.title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(130, "\r\n                            ");
            __builder.OpenElement(131, "td");
            __builder.AddContent(132, 
#nullable restore
#line 178 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Title.razor"
                                 t.year

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 179 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Title.razor"
                             if (t.critic_score == null)
                            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(133, "<td>Information Not Available</td>");
#nullable restore
#line 182 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Title.razor"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(134, "td");
            __builder.AddContent(135, 
#nullable restore
#line 185 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Title.razor"
                                     t.critic_score

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 186 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Title.razor"
                            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
#nullable restore
#line 189 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Title.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 189 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Title.razor"
                     
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 194 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Title.razor"

    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(136, "button");
            __builder.AddAttribute(137, "class", "btn-info");
            __builder.AddAttribute(138, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 198 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Title.razor"
                                           Expand

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(139, "Expand");
            __builder.CloseElement();
#nullable restore
#line 199 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Title.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 199 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Title.razor"
     
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 202 "D:\College\Year 4\EAD\ca3\ca3\ca3\Pages\Title.razor"
       
    [Parameter]
    public int titleId { get; set; }

    private TitleInfo title;
    private Genres[] genres;
    public List<TitleInfo> similarTitles = new List<TitleInfo>();
    public bool IsExpanded { get; set; }
    public bool CastExpanded { get; set; }
    public bool SeasonExpanded { get; set; }

    void Collapse()
    {
        IsExpanded = false;
    }

    async Task Expand()
    {

            if (similarTitles.Count == 0 && title.similar_titles != null && title != null)
            {

                foreach (var t in title.similar_titles.Take(5))
                {
                    string httpString = $"https://api.watchmode.com/v1/title/{t}/details/?apiKey=yvWxtCM9fYbj3Zg5NmEEK6bJtJnPSe6C6XfFj11m";
                    TitleInfo similar = await Http.GetFromJsonAsync<TitleInfo>(httpString);
                    similarTitles.Add(similar);
                }

            }
        

        IsExpanded = true;
    }

    void CollapseCast()
    {
        CastExpanded = false;
    }

    void ExpandCast()
    {
        CastExpanded = true;
    }

    void CollapseSeason()
    {
        SeasonExpanded = false;
    }

    void ExpandSeason()
    {
        SeasonExpanded = true;
    }

    protected override async Task OnParametersSetAsync()
    {
        similarTitles = new List<TitleInfo>();
        IsExpanded = false;
        CastExpanded = false;
        SeasonExpanded = false;
        string httpString = $"https://api.watchmode.com/v1/title/{titleId}/details/?apiKey=yvWxtCM9fYbj3Zg5NmEEK6bJtJnPSe6C6XfFj11m&append_to_response=seasons,cast-crew";
        title = await Http.GetFromJsonAsync<TitleInfo>(httpString);

    }
    protected override async Task OnInitializedAsync()
    {
        string httpString = $"https://api.watchmode.com/v1/title/{titleId}/details/?apiKey=yvWxtCM9fYbj3Zg5NmEEK6bJtJnPSe6C6XfFj11m&append_to_response=seasons,cast-crew";
        title = await Http.GetFromJsonAsync<TitleInfo>(httpString);
        genres = await Http.GetFromJsonAsync<Genres[]>("https://api.watchmode.com/v1/genres/?apiKey=yvWxtCM9fYbj3Zg5NmEEK6bJtJnPSe6C6XfFj11m");
    }


    public class Genres
    {
        public int id { get; set; }
        public string name { get; set; }
        public int? tmdb_id { get; set; }
    }


    public class Season
    {
        public int id { get; set; }
        public string poster_url { get; set; }
        public string name { get; set; }
        public string overview { get; set; }
        public int? number { get; set; }
        public string air_date { get; set; }
        public int? episode_count { get; set; }
    }

    public class CastCrew
    {
        public int? person_id { get; set; }
        public string type { get; set; }
        public string full_name { get; set; }
        public string headshot_url { get; set; }
        public string role { get; set; }
        public int? episode_count { get; set; }
        public object order { get; set; }
    }

    public class TitleInfo
    {
        public int id { get; set; }
        public string title { get; set; }
        public string original_title { get; set; }
        public string plot_overview { get; set; }
        public string type { get; set; }
        public int? runtime_minutes { get; set; }
        public int? year { get; set; }
        public int? end_year { get; set; }
        public string release_date { get; set; }
        public string imdb_id { get; set; }
        public int? tmdb_id { get; set; }
        public string tmdb_type { get; set; }
        public List<int> genres { get; set; }
        public double user_rating { get; set; }
        public int? critic_score { get; set; }
        public string us_rating { get; set; }
        public string original_language { get; set; }
        public List<int> similar_titles { get; set; }
        public List<int> networks { get; set; }
        public double relevance_percentile { get; set; }
        public List<Season> seasons { get; set; }
        public List<CastCrew> cast_crew { get; set; }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
