#pragma checksum "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultSearch.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fd50dd39ab5b2a83e47f2fd20a512db98ffee71a"
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
#line 11 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\_Imports.razor"
using Blazorise.Sidebar;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultSearch.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fault/search")]
    public partial class FaultSearch : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Arıza Sorgula</h3>\r\n<br>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 12 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultSearch.razor"
                  fault

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(4, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(6, "\r\n\r\n    ");
                __builder2.OpenElement(7, "div");
                __builder2.AddAttribute(8, "class", "container");
                __builder2.AddMarkupContent(9, "\r\n        ");
                __builder2.AddMarkupContent(10, @"<div class=""row  justify-content-md-center"">
            <div class=""col"">Başlangıç Tarihi</div>
            <div class=""col"">Bitiş Tarihi</div>
            <div class=""col"">Bölüm</div>
            <div class=""col"">Makina</div>
            </div>
            ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "row  justify-content-md-center");
                __builder2.AddMarkupContent(13, "\r\n                ");
                __builder2.OpenElement(14, "div");
                __builder2.AddAttribute(15, "class", "col");
                __builder2.AddMarkupContent(16, "\r\n                    ");
                __builder2.OpenElement(17, "input");
                __builder2.AddAttribute(18, "class", "form-control");
                __builder2.AddAttribute(19, "id", "dp1");
                __builder2.AddAttribute(20, "type", "date");
                __builder2.AddAttribute(21, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultSearch.razor"
                                                                            dp1

#line default
#line hidden
#nullable disable
                , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(22, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => dp1 = __value, dp1, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(24, "\r\n                ");
                __builder2.OpenElement(25, "div");
                __builder2.AddAttribute(26, "class", "col");
                __builder2.AddMarkupContent(27, "\r\n                    ");
                __builder2.OpenElement(28, "input");
                __builder2.AddAttribute(29, "class", "form-control");
                __builder2.AddAttribute(30, "id", "dp2");
                __builder2.AddAttribute(31, "type", "date");
                __builder2.AddAttribute(32, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 27 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultSearch.razor"
                                                                            dp2

#line default
#line hidden
#nullable disable
                , format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.AddAttribute(33, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => dp2 = __value, dp2, format: "yyyy-MM-dd", culture: global::System.Globalization.CultureInfo.InvariantCulture));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(34, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(35, "\r\n\r\n                ");
                __builder2.OpenElement(36, "div");
                __builder2.AddAttribute(37, "class", "col");
                __builder2.AddMarkupContent(38, "\r\n                    ");
                __builder2.OpenElement(39, "select");
                __builder2.AddAttribute(40, "class", "browser-default custom-select");
                __builder2.AddAttribute(41, "value", 
#nullable restore
#line 37 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultSearch.razor"
                                                                          fault.MakinaGrubu

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(42, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 37 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultSearch.razor"
                                                                                                         DoStuff

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(43, "\r\n                        ");
                __builder2.OpenElement(44, "option");
                __builder2.AddAttribute(45, "value", true);
                __builder2.AddMarkupContent(46, "Lütfen Seçiniz");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n");
#nullable restore
#line 39 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultSearch.razor"
                         foreach (var item in machineList.Keys)
                        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(48, "                            ");
                __builder2.OpenElement(49, "option");
                __builder2.AddAttribute(50, "value", 
#nullable restore
#line 41 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultSearch.razor"
                                            item

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(51, 
#nullable restore
#line 41 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultSearch.razor"
                                                   item

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n");
#nullable restore
#line 42 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultSearch.razor"
                        }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(53, "                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(54, "\r\n                    ");
                __Blazor.BlazorApp4.Client.Pages.FaultPages.FaultSearch.TypeInference.CreateValidationMessage_0(__builder2, 55, 56, 
#nullable restore
#line 44 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultSearch.razor"
                                              () => fault.MakinaGrubu

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(57, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n                ");
                __builder2.OpenElement(59, "div");
                __builder2.AddAttribute(60, "class", "col");
                __builder2.AddMarkupContent(61, "\r\n                    ");
                __builder2.OpenElement(62, "select");
                __builder2.AddAttribute(63, "class", "browser-default custom-select");
                __builder2.AddAttribute(64, "value", 
#nullable restore
#line 47 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultSearch.razor"
                                                                          fault.Makina

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(65, "\r\n                        ");
                __builder2.OpenElement(66, "option");
                __builder2.AddAttribute(67, "value", true);
                __builder2.AddMarkupContent(68, "Lütfen Seçiniz");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(69, "\r\n");
#nullable restore
#line 49 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultSearch.razor"
                         foreach (var item in makina)
                        {


#line default
#line hidden
#nullable disable
                __builder2.AddContent(70, "                            ");
                __builder2.OpenElement(71, "option");
                __builder2.AddAttribute(72, "value", 
#nullable restore
#line 52 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultSearch.razor"
                                            item

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(73, 
#nullable restore
#line 52 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultSearch.razor"
                                                   item

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(74, "\r\n");
#nullable restore
#line 53 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultSearch.razor"
                        }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(75, "                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(76, "\r\n                    ");
                __Blazor.BlazorApp4.Client.Pages.FaultPages.FaultSearch.TypeInference.CreateValidationMessage_1(__builder2, 77, 78, 
#nullable restore
#line 55 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultSearch.razor"
                                              () => fault.Makina

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(79, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(80, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(81, "\r\n        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(82, "\r\n            <br>\r\n            ");
                __builder2.OpenComponent<Radzen.Blazor.RadzenButton>(83);
                __builder2.AddAttribute(84, "Click", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 60 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultSearch.razor"
                                                 (args) => Click(args, "Button with text")

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(85, "Text", "Sorgula");
                __builder2.AddAttribute(86, "Style", "margin-bottom: 20px; width: 150px");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(87, "\r\n            <br>\r\n\r\n");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(88, "\r\n\r\n\r\n\r\n\r\n<br>\r\n\r\n");
#nullable restore
#line 70 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultSearch.razor"
 if (faultList == null)
{
    

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(89, "Yükleniyor...");
#nullable restore
#line 72 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultSearch.razor"
                              
}
else if (faultList.Length == 0)
{
    

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(90, "Kayıt bulunamadı.");
#nullable restore
#line 76 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultSearch.razor"
                                  
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(91, "    ");
            __builder.OpenComponent<Blazorise.Table>(92);
            __builder.AddAttribute(93, "Hoverable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 80 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultSearch.razor"
                      true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(94, "Narrow", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 80 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultSearch.razor"
                                     true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(95, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(96, "\r\n        ");
                __builder2.OpenComponent<Blazorise.TableHeader>(97);
                __builder2.AddAttribute(98, "ThemeContrast", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.ThemeContrast>(
#nullable restore
#line 81 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultSearch.razor"
                                    ThemeContrast.Light

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(99, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(100, "\r\n            ");
                    __builder3.OpenComponent<Blazorise.TableRow>(101);
                    __builder3.AddAttribute(102, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(103, "\r\n                ");
                        __builder4.OpenComponent<Blazorise.TableHeaderCell>(104);
                        __builder4.AddAttribute(105, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(106, "Bölüm");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(107, "\r\n                ");
                        __builder4.OpenComponent<Blazorise.TableHeaderCell>(108);
                        __builder4.AddAttribute(109, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(110, "Makina");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(111, "\r\n                ");
                        __builder4.OpenComponent<Blazorise.TableHeaderCell>(112);
                        __builder4.AddAttribute(113, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(114, "Bildirim Tarihi");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(115, "\r\n                ");
                        __builder4.OpenComponent<Blazorise.TableHeaderCell>(116);
                        __builder4.AddAttribute(117, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(118, "Başlama Tarihi");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(119, "\r\n                ");
                        __builder4.OpenComponent<Blazorise.TableHeaderCell>(120);
                        __builder4.AddAttribute(121, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(122, "Açıklama");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(123, "\r\n                ");
                        __builder4.OpenComponent<Blazorise.TableHeaderCell>(124);
                        __builder4.AddAttribute(125, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(126, "Bitiş Tarihi");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(127, "\r\n                ");
                        __builder4.OpenComponent<Blazorise.TableHeaderCell>(128);
                        __builder4.AddAttribute(129, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(130, "Yapılan İşlemler");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(131, "\r\n                ");
                        __builder4.OpenComponent<Blazorise.TableHeaderCell>(132);
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(133, "\r\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(134, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(135, "\r\n        ");
                __builder2.OpenComponent<Blazorise.TableBody>(136);
                __builder2.AddAttribute(137, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(138, "\r\n");
#nullable restore
#line 95 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultSearch.razor"
             foreach (BlazorApp4.Shared.Models.Fault faul in faultList)
            {
                if (faul.Status == BlazorApp4.Shared.Models.FaultStatus.FIXED){

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(139, "            ");
                    __builder3.OpenComponent<Blazorise.TableRow>(140);
                    __builder3.AddAttribute(141, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(142, "\r\n                ");
                        __builder4.OpenComponent<Blazorise.TableRowCell>(143);
                        __builder4.AddAttribute(144, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(145, 
#nullable restore
#line 99 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultSearch.razor"
                               faul.MakinaGrubu

#line default
#line hidden
#nullable disable
                            );
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(146, "\r\n                ");
                        __builder4.OpenComponent<Blazorise.TableRowCell>(147);
                        __builder4.AddAttribute(148, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(149, 
#nullable restore
#line 100 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultSearch.razor"
                               faul.Makina

#line default
#line hidden
#nullable disable
                            );
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(150, "\r\n                ");
                        __builder4.OpenComponent<Blazorise.TableRowCell>(151);
                        __builder4.AddAttribute(152, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(153, 
#nullable restore
#line 101 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultSearch.razor"
                               faul.RecordTime

#line default
#line hidden
#nullable disable
                            );
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(154, "\r\n                ");
                        __builder4.OpenComponent<Blazorise.TableRowCell>(155);
                        __builder4.AddAttribute(156, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(157, 
#nullable restore
#line 102 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultSearch.razor"
                               faul.CreatedTime

#line default
#line hidden
#nullable disable
                            );
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(158, "\r\n                ");
                        __builder4.OpenComponent<Blazorise.TableRowCell>(159);
                        __builder4.AddAttribute(160, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(161, 
#nullable restore
#line 103 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultSearch.razor"
                               faul.Description

#line default
#line hidden
#nullable disable
                            );
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(162, "\r\n                ");
                        __builder4.OpenComponent<Blazorise.TableRowCell>(163);
                        __builder4.AddAttribute(164, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(165, 
#nullable restore
#line 104 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultSearch.razor"
                               faul.FixedTime

#line default
#line hidden
#nullable disable
                            );
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(166, "\r\n                ");
                        __builder4.OpenComponent<Blazorise.TableRowCell>(167);
                        __builder4.AddAttribute(168, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(169, 
#nullable restore
#line 106 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultSearch.razor"
                               faul.FixDescription

#line default
#line hidden
#nullable disable
                            );
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(170, "\r\n            ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(171, "\r\n");
#nullable restore
#line 113 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultSearch.razor"
                }
            }

#line default
#line hidden
#nullable disable
                    __builder3.AddMarkupContent(172, "\r\n        ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(173, "\r\n    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(174, "\r\n");
#nullable restore
#line 118 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultSearch.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 120 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultSearch.razor"
       

    [Parameter] public BlazorApp4.Shared.Models.FaultStatus faultStatus { get; set; }
    [Parameter] public BlazorApp4.Shared.Models.Fault fault { get; set; } = new BlazorApp4.Shared.Models.Fault();

    BlazorApp4.Shared.Models.Fault[] faultList { get; set; }

    public String statusLabel(String text)
    {
        if (text == "REPORTED")
        {
            return "RAPOR EDİLDİ";
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


    Dictionary<String, List<String>> machineList { get; set; } =
new Dictionary<String, List<String>>()
{
            { "EFEKT",  new List<string>() { "EFEKT-1", "EFEKT-2", "EFEKT-3", "EFEKT-4" } }
  };

    public List<String> makina { get; set; } = new List<String>() { "Liste Yüklenemedi" };

    public void DoStuff(ChangeEventArgs e)
    {
        var kafamdakiMakina = e.Value.ToString();
        fault.MakinaGrubu = kafamdakiMakina;
        // Console.WriteLine("It is definitely: " + kafamdakiMakina);
        makina = machineList.ContainsKey(kafamdakiMakina) ? machineList[kafamdakiMakina] : new List<String>() { "Liste Yüklenemedi" };

    }
    public DateTime dp1 = DateTime.SpecifyKind(DateTime.Today, DateTimeKind.Local);
    public DateTime dp2 = DateTime.SpecifyKind(DateTime.Today, DateTimeKind.Local);


    async void Click(MouseEventArgs args, string buttonName)
    {
        long after = ((DateTimeOffset)dp1).ToUnixTimeMilliseconds()+10800000;
        long before = ((DateTimeOffset)dp2).ToUnixTimeMilliseconds()+97199000;

        var url = "api/fault/query?afterTimestamp=" + after.ToString() + "&beforeTimestamp=" + before.ToString() /*+"&status=" +faultStatus.ToString()*/ ;
        faultList = await client.GetFromJsonAsync<BlazorApp4.Shared.Models.Fault[]>(url);
        Console.WriteLine(faultList);
    }

    // var appointmentNoShow = from a in appointments
    // from p in properties
    // from c in clients
    // where a.Id == p.OID &&
    //(a.Start.Date >= startDate.Date && a.Start.Date <= endDate)



    //public List<tbltask> gettaskssdata(int? c, int? userid, string a, string StartDate, string EndDate, int? ProjectID, int? statusid)
    //{
    //    List<tbltask> tbtask = new List<tbltask>();
    //    DateTime sdate = (StartDate != "") ? Convert.ToDateTime(StartDate).Date : new DateTime();
    //    DateTime edate = (EndDate != "") ? Convert.ToDateTime(EndDate).Date : new DateTime();
    //    tbtask = entity.tbltasks.Include(x => x.tblproject).Include(x => x.tbUser).
    //        Where(x => x.tblproject.company_id == c
    //            && (ProjectID == 0 || ProjectID == x.tblproject.ProjectId)
    //            && (statusid == 0 || statusid == x.tblstatu.StatusId)
    //            && (a == "" || (x.TaskName.Contains(a) || x.tbUser.User_name.Contains(a)))
    //            && ((StartDate == "" && EndDate == "") || ((x.StartDate >= sdate && x.EndDate <= edate)))).ToList();



    //    return tbtask;


    //}







#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager uriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient client { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
namespace __Blazor.BlazorApp4.Client.Pages.FaultPages.FaultSearch
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
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
