#pragma checksum "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a2e36ea9e1e127c826ac62a60bb436bfa1b5818"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/fault")]
    public partial class FaultList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 278 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultList.razor"
       

    public DateTime dateTime1 = DateTime.Now;




    //protected override async Task OnInitializedAsync()
    //{
    //    faults = await client.GetFromJsonAsync<FaultList[]>("api/fault");
    //}

    List<BlazorApp4.Shared.Models.Fault> faultList { get; set; }
    [Parameter] public BlazorApp4.Shared.Models.Fault selectedFault { get; set; }
    protected override async Task OnInitializedAsync()
    {
        faultList = await client.GetFromJsonAsync<List<BlazorApp4.Shared.Models.Fault>>("api/fault");


    }

    [Parameter] public BlazorApp4.Shared.Models.Fault faultToEdit { get; set; } = new BlazorApp4.Shared.Models.Fault();

    [Parameter] public int faultId { get; set; }

    public String statusLabel(String text)
    {
        if (text == "REPORTED")
        {
            return "RAPOR EDİLDİ";
        }
        else if (text == "FIXING")
        {
            return "TAMİR EDİLİYOR";
        }
        else if (text == "FIXED")
        {
            return "TAMİR EDİLDİ";
        }
        else
        {
            return " - ";
        }
    }

    private Modal modalRef;
    private Modal modalRefCancel;
    private void ShowModal()
    {

        //   selectedFault = fault;
        modalRef.Show();
    }
    private void ShowModal2()
    {

        //   selectedFault = fault;
        modalRefCancel.Show();
    }
    private void EditFault()
    {

    }

    async Task SaveChanges()
    {
        faultToEdit.Status = BlazorApp4.Shared.Models.FaultStatus.FIXED;
        faultToEdit.FixedTime = dateTime1;
        await http.PutAsJsonAsync($"api/fault", faultToEdit);
        faultList = await client.GetFromJsonAsync<List<BlazorApp4.Shared.Models.Fault>>("api/fault");
        modalRef.Hide();
    }

    async Task SaveChanges2()
    {
        faultToEdit.Status = BlazorApp4.Shared.Models.FaultStatus.CANCELED;
        faultToEdit.FixedTime = dateTime1;
        await http.PutAsJsonAsync($"api/fault", faultToEdit);
        faultList = await client.GetFromJsonAsync<List<BlazorApp4.Shared.Models.Fault>>("api/fault");
        modalRefCancel.Hide();
    }

    private  void HideModal()
    {
        selectedFault = null;

        modalRef.Hide();
    }
    private  void HideModal2()
    {
        selectedFault = null;

        modalRefCancel.Hide();
    }

    public async void GetFaultAndShowModal(int id)
    {

        faultToEdit = await http.GetFromJsonAsync<BlazorApp4.Shared.Models.Fault>($"api/fault/{id}");
        ShowModal();
    }
    public async void GetFaultAndShowModal2(int id)
    {
        faultToEdit = await http.GetFromJsonAsync<BlazorApp4.Shared.Models.Fault>($"api/fault/{id}");
        ShowModal2();
    }


    public void AddFault()
    {
        uriHelper.NavigateTo("fault/create");
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
