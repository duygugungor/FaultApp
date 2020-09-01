#pragma checksum "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7ab3f6c942fe46e892d34cf588fc1b5ac063e1c"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp4.Client.Pages.FaultPages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\_Imports.razor"
using BlazorApp4.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\_Imports.razor"
using BlazorApp4.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\_Imports.razor"
using Blazorise;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\_Imports.razor"
using Blazorise.Sidebar;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fault/create")]
    public partial class FaultForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 87 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultForm.razor"
       
    [Parameter] public BlazorApp4.Shared.Models.Fault fault { get; set; } = new BlazorApp4.Shared.Models.Fault();
    async Task CreateFault()
    {
        await client.PostAsJsonAsync("api/fault", fault);
        //uriHelper.NavigateTo("employee");
    }

    Dictionary<String, List<String>> machineList {get; set; } =
    new Dictionary<String, List<String>>()
    {
            { "EFEKT",  new List<string>() { "EFEKT-1", "EFEKT-2", "EFEKT-3", "EFEKT-4" } },
             { "RAM",  new List<string>() { "RAM-1", "RAM-2", "RAM-3", "RAM-4" } }
    };

    public List<String> makina { get; set; } = new List<String>() { "Liste Yüklenemedi" };

    public void DoStuff(ChangeEventArgs e)
    {
        var kafamdakiMakina = e.Value.ToString();
        fault.MakinaGrubu = kafamdakiMakina;
       // Console.WriteLine("It is definitely: " + kafamdakiMakina);
        makina = machineList.ContainsKey(kafamdakiMakina) ? machineList[kafamdakiMakina] : new List<String>() { "Liste Yüklenemedi" };

    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager uriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient client { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
