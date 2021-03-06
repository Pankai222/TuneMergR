// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace TuneMergR.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Olligagman\RiderProjects\TuneMergR\TuneMergR\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Olligagman\RiderProjects\TuneMergR\TuneMergR\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Olligagman\RiderProjects\TuneMergR\TuneMergR\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Olligagman\RiderProjects\TuneMergR\TuneMergR\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Olligagman\RiderProjects\TuneMergR\TuneMergR\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Olligagman\RiderProjects\TuneMergR\TuneMergR\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Olligagman\RiderProjects\TuneMergR\TuneMergR\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Olligagman\RiderProjects\TuneMergR\TuneMergR\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Olligagman\RiderProjects\TuneMergR\TuneMergR\_Imports.razor"
using TuneMergR;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Olligagman\RiderProjects\TuneMergR\TuneMergR\_Imports.razor"
using TuneMergR.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Olligagman\RiderProjects\TuneMergR\TuneMergR\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Olligagman\RiderProjects\TuneMergR\TuneMergR\_Imports.razor"
using TuneMergR.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Olligagman\RiderProjects\TuneMergR\TuneMergR\Pages\Index.razor"
using TuneMergR.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Olligagman\RiderProjects\TuneMergR\TuneMergR\Pages\Index.razor"
using TuneMergR.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Olligagman\RiderProjects\TuneMergR\TuneMergR\Pages\Index.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "C:\Users\Olligagman\RiderProjects\TuneMergR\TuneMergR\Pages\Index.razor"
       
    bool displaySongs;
    bool isLoaded;
    bool songsLoaded;
    private List<PlaylistChannelResult.Playlist> _playlists;
    
    [Inject]
    public ISongService SongService { get; set; }

    protected override async Task OnInitializedAsync()
    {
        var jsonPlaylistResult = await SongService.GetPlaylists();
        _playlists = jsonPlaylistResult.Items;
        
        if (_playlists is not null)
        {
            if (_playlists.Any())
            {
                isLoaded = true;
            }
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
