#pragma checksum "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultFixed.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9440cec2da2995d784ef47244446f9319aa91ef5"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp4.Client.Pages.FaultPages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
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
#line 5 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultFixed.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultFixed.razor"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fault/edit/{faultId:int}")]
    public partial class FaultFixed : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>FaultFixed</h3>\r\n\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 10 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultFixed.razor"
                  fault

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 10 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultFixed.razor"
                                         EditFault

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenElement(8, "div");
                __builder2.AddMarkupContent(9, "\r\n\r\n        ");
                __builder2.OpenElement(10, "div");
                __builder2.AddMarkupContent(11, "\r\n            ");
                __builder2.OpenElement(12, "div");
                __builder2.AddMarkupContent(13, "\r\n                ");
                __builder2.AddMarkupContent(14, "<div rows=\"5\">\r\n                    <label>Bölüm : </label>\r\n                </div>\r\n                ");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "float", "left");
                __builder2.AddMarkupContent(17, "\r\n                    ");
                __builder2.OpenElement(18, "select");
                __builder2.AddAttribute(19, "value", 
#nullable restore
#line 20 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultFixed.razor"
                                    fault.MakinaGrubu

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(20, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultFixed.razor"
                                                                   DoStuff

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(21, "\r\n                        ");
                __builder2.OpenElement(22, "option");
                __builder2.AddAttribute(23, "value", true);
                __builder2.AddMarkupContent(24, "Lütfen Seçiniz");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(25, "\r\n");
#nullable restore
#line 22 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultFixed.razor"
                         foreach (var item in machineList.Keys)
                        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(26, "                            ");
                __builder2.OpenElement(27, "option");
                __builder2.AddAttribute(28, "value", 
#nullable restore
#line 24 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultFixed.razor"
                                            item

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(29, 
#nullable restore
#line 24 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultFixed.razor"
                                                   item

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n");
#nullable restore
#line 25 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultFixed.razor"
                        }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(31, "                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n                    ");
                __Blazor.BlazorApp4.Client.Pages.FaultPages.FaultFixed.TypeInference.CreateValidationMessage_0(__builder2, 33, 34, 
#nullable restore
#line 27 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultFixed.razor"
                                              () => fault.MakinaGrubu

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(35, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n        ");
                __builder2.OpenElement(39, "div");
                __builder2.AddMarkupContent(40, "\r\n            ");
                __builder2.OpenElement(41, "div");
                __builder2.AddMarkupContent(42, "\r\n                ");
                __builder2.AddMarkupContent(43, "<div rows=\"5\">\r\n                    <label>Makina : </label>\r\n                </div>\r\n                ");
                __builder2.OpenElement(44, "div");
                __builder2.AddAttribute(45, "float", "left");
                __builder2.AddMarkupContent(46, "\r\n                    ");
                __Blazor.BlazorApp4.Client.Pages.FaultPages.FaultFixed.TypeInference.CreateInputSelect_1(__builder2, 47, 48, 
#nullable restore
#line 37 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultFixed.razor"
                                               fault.Makina

#line default
#line hidden
#nullable disable
                , 49, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => fault.Makina = __value, fault.Makina)), 50, () => fault.Makina, 51, (__builder3) => {
                    __builder3.AddMarkupContent(52, "\r\n                        ");
                    __builder3.AddMarkupContent(53, "<option value>Lütfen Seçiniz</option>\r\n");
#nullable restore
#line 39 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultFixed.razor"
                         foreach (var item in makina)
                        {


#line default
#line hidden
#nullable disable
                    __builder3.AddContent(54, "                            ");
                    __builder3.OpenElement(55, "option");
                    __builder3.AddAttribute(56, "value", 
#nullable restore
#line 42 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultFixed.razor"
                                            item

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(57, 
#nullable restore
#line 42 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultFixed.razor"
                                                   item

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(58, "\r\n");
#nullable restore
#line 43 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultFixed.razor"
                        }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(59, "                    ");
                }
                );
                __builder2.AddMarkupContent(60, "\r\n                    ");
                __Blazor.BlazorApp4.Client.Pages.FaultPages.FaultFixed.TypeInference.CreateValidationMessage_2(__builder2, 61, 62, 
#nullable restore
#line 45 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultFixed.razor"
                                              () => fault.Makina

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(63, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(64, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(66, "\r\n\r\n        ");
                __builder2.OpenElement(67, "div");
                __builder2.AddMarkupContent(68, "\r\n            ");
                __builder2.OpenElement(69, "div");
                __builder2.AddMarkupContent(70, "\r\n                ");
                __builder2.AddMarkupContent(71, "<div rows=\"5\">\r\n                    <label>Operatör : </label>\r\n                </div>\r\n                ");
                __builder2.OpenElement(72, "div");
                __builder2.AddAttribute(73, "float", "left");
                __builder2.AddMarkupContent(74, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(75);
                __builder2.AddAttribute(76, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 56 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultFixed.razor"
                                             fault.Operator

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(77, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => fault.Operator = __value, fault.Operator))));
                __builder2.AddAttribute(78, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => fault.Operator));
                __builder2.AddAttribute(79, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(80, "\r\n                        ");
                    __builder3.AddMarkupContent(81, "<option value=\"Makine1\">Operatör</option>\r\n                    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(82, "\r\n                    ");
                __Blazor.BlazorApp4.Client.Pages.FaultPages.FaultFixed.TypeInference.CreateValidationMessage_3(__builder2, 83, 84, 
#nullable restore
#line 59 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultFixed.razor"
                                              () => fault.Operator

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(85, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(86, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(87, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(88, "\r\n\r\n        ");
                __builder2.OpenElement(89, "div");
                __builder2.AddMarkupContent(90, "\r\n            ");
                __builder2.AddMarkupContent(91, "<div rows=\"5\">\r\n                <label>Açıklama :</label>\r\n\r\n            </div>\r\n            ");
                __builder2.OpenElement(92, "div");
                __builder2.AddAttribute(93, "float", "left");
                __builder2.AddMarkupContent(94, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(95);
                __builder2.AddAttribute(96, "rows", "7");
                __builder2.AddAttribute(97, "cols", "33");
                __builder2.AddAttribute(98, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 70 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultFixed.razor"
                                             fault.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(99, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => fault.Description = __value, fault.Description))));
                __builder2.AddAttribute(100, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => fault.Description));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(101, "\r\n                ");
                __Blazor.BlazorApp4.Client.Pages.FaultPages.FaultFixed.TypeInference.CreateValidationMessage_4(__builder2, 102, 103, 
#nullable restore
#line 71 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultFixed.razor"
                                          () => fault.Description

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(104, "\r\n\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(105, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(106, "\r\n\r\n\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(107, "\r\n\r\n    ");
                __builder2.OpenElement(108, "div");
                __builder2.AddMarkupContent(109, "\r\n\r\n        ");
                __builder2.OpenElement(110, "div");
                __builder2.AddMarkupContent(111, "\r\n            ");
                __builder2.AddMarkupContent(112, "<div>\r\n                <label>Kullanıcı Adı</label>\r\n            </div>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(113);
                __builder2.AddAttribute(114, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 88 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultFixed.razor"
                                     fault.FixBy

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(115, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => fault.FixBy = __value, fault.FixBy))));
                __builder2.AddAttribute(116, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => fault.FixBy));
                __builder2.AddAttribute(117, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(118, "\r\n            ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(119, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(120, "\r\n        ");
                __builder2.OpenElement(121, "div");
                __builder2.AddMarkupContent(122, "\r\n            ");
                __builder2.AddMarkupContent(123, "<div>\r\n                <label>Yapılan İşlemler</label>\r\n            </div>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(124);
                __builder2.AddAttribute(125, "rows", "7");
                __builder2.AddAttribute(126, "cols", "42");
                __builder2.AddAttribute(127, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 96 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultFixed.razor"
                                         fault.FixDescription

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(128, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => fault.FixDescription = __value, fault.FixDescription))));
                __builder2.AddAttribute(129, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => fault.FixDescription));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(130, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(131, "\r\n        ");
                __builder2.OpenElement(132, "div");
                __builder2.AddMarkupContent(133, "\r\n            ");
                __builder2.AddMarkupContent(134, "<div>\r\n                <label>Tarih</label>\r\n\r\n            </div>\r\n\r\n            ");
                __Blazor.BlazorApp4.Client.Pages.FaultPages.FaultFixed.TypeInference.CreateInputDate_5(__builder2, 135, 136, 
#nullable restore
#line 105 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultFixed.razor"
                                     fault.FixedTime

#line default
#line hidden
#nullable disable
                , 137, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => fault.FixedTime = __value, fault.FixedTime)), 138, () => fault.FixedTime);
                __builder2.AddMarkupContent(139, "\r\n\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(140, "\r\n        <hr>\r\n        ");
                __builder2.OpenElement(141, "button");
                __builder2.AddAttribute(142, "type", "submit");
                __builder2.AddAttribute(143, "class", "btn btn-success");
                __builder2.AddAttribute(144, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 110 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultFixed.razor"
                                                                (() => EditFault())

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(145, "\r\n            Kaydet\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(146, "\r\n    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(147, "\r\n\r\n\r\n\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 121 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultFixed.razor"
       
    [Parameter] public EventCallback OnValidSubmit { get; set; }


    [Parameter] public BlazorApp4.Shared.Models.Fault fault { get; set; } = new BlazorApp4.Shared.Models.Fault();

    [Parameter] public int faultId { get; set; }


    List<BlazorApp4.Shared.Models.Fault> faultList { get; set; }


    protected async override Task OnParametersSetAsync()
    {
        faultList = await http.GetFromJsonAsync<List<BlazorApp4.Shared.Models.Fault>>($"api/fault/edit/{faultId}");


    }


  async  Task EditFault()
    {

        await http.PutAsJsonAsync("api/fault", fault);
        await js.InvokeVoidAsync("alert", $"Updated Successfully!");
        //uriHelper.NavigateTo("fault");

    }



    Dictionary<String, List<String>> machineList { get; set; } =
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
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
namespace __Blazor.BlazorApp4.Client.Pages.FaultPages.FaultFixed
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.AddAttribute(__seq3, "ChildContent", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_5<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
