#pragma checksum "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c733f1e14c2aae74ab8fa3b7f1daf3bd1f7213e4"
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
            __builder.AddMarkupContent(0, "<h3>FaultList</h3>\r\n<br>\r\n\r\n");
#nullable restore
#line 23 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultList.razor"
 if (faultList == null)
{
    

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "Yükleniyor...");
#nullable restore
#line 25 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultList.razor"
                              
}
else if (faultList.Count == 0)
{
    

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "Kayıt bulunamadı.");
#nullable restore
#line 29 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultList.razor"
                                  
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.OpenElement(4, "table");
            __builder.AddAttribute(5, "class", "table table-striped");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.AddMarkupContent(7, "<thead>\r\n            <tr>\r\n                <th>Bölüm</th>\r\n                <th>Makina</th>\r\n                <th>Operatör</th>\r\n                <th>Tarih</th>\r\n                <th>Açıklama</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(8, "tbody");
            __builder.AddMarkupContent(9, "\r\n");
#nullable restore
#line 45 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultList.razor"
             foreach (BlazorApp4.Shared.Models.Fault faul in faultList)
            {
                

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "                ");
            __builder.OpenElement(11, "tr");
            __builder.AddMarkupContent(12, "\r\n                    ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 49 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultList.razor"
                         faul.MakinaGrubu

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                    ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 50 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultList.razor"
                         faul.Makina

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                    ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 51 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultList.razor"
                         faul.Operator

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 52 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultList.razor"
                         faul.CreatedTime

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                    ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 53 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultList.razor"
                         faul.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                    ");
            __builder.OpenElement(28, "td");
            __builder.AddMarkupContent(29, "\r\n                        ");
            __builder.OpenComponent<Blazorise.Button>(30);
            __builder.AddAttribute(31, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.Color>(
#nullable restore
#line 56 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultList.razor"
                                       Color.Warning

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "Clicked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 56 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultList.razor"
                                                                 e => GetFaultAndShowModal(faul.Id)

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(33, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(34, "Bitir");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(35, "\r\n\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n");
#nullable restore
#line 64 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultList.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(38, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                    ");
            __builder.OpenComponent<Blazorise.Modal>(41);
            __builder.AddAttribute(42, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(43, "\r\n    ");
                __builder2.OpenComponent<Blazorise.ModalBackdrop>(44);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(45, "\r\n    ");
                __builder2.OpenComponent<Blazorise.ModalContent>(46);
                __builder2.AddAttribute(47, "IsCentered", "true");
                __builder2.AddAttribute(48, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(49, "\r\n        ");
                    __builder3.OpenComponent<Blazorise.ModalHeader>(50);
                    __builder3.AddAttribute(51, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(52, "\r\n            ");
                        __builder4.OpenComponent<Blazorise.ModalTitle>(53);
                        __builder4.AddAttribute(54, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(55, "Employee edit");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(56, "\r\n            ");
                        __builder4.OpenComponent<Blazorise.CloseButton>(57);
                        __builder4.AddAttribute(58, "Clicked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 73 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultList.razor"
                                   HideModal

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(59, "\r\n        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(60, "\r\n        ");
                    __builder3.OpenComponent<Blazorise.ModalBody>(61);
                    __builder3.AddAttribute(62, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(63, "\r\n           \r\n            \r\n            \r\n            \r\n            \r\n            \r\n            \r\n            \r\n            \r\n            \r\n            ");
                        __builder4.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(64);
                        __builder4.AddAttribute(65, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 86 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultList.razor"
                              faultToEdit

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(66, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 86 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultList.razor"
                                                           EditFault

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(67, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder5) => {
                            __builder5.AddMarkupContent(68, "\r\n                ");
                            __builder5.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(69);
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(70, "\r\n                ");
                            __builder5.OpenComponent<Blazorise.CardDeck>(71);
                            __builder5.AddAttribute(72, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder6) => {
                                __builder6.AddMarkupContent(73, "\r\n                    ");
                                __builder6.OpenComponent<Blazorise.Card>(74);
                                __builder6.AddAttribute(75, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddMarkupContent(76, "\r\n\r\n                        ");
                                    __builder7.OpenComponent<Blazorise.CardBody>(77);
                                    __builder7.AddAttribute(78, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder8) => {
                                        __builder8.AddMarkupContent(79, "\r\n\r\n\r\n                            ");
                                        __builder8.AddMarkupContent(80, "<label>Bölüm : </label>\r\n                            ");
                                        __builder8.OpenComponent<Blazorise.TextEdit>(81);
                                        __builder8.AddAttribute(82, "Disabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 95 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultList.razor"
                                                true

#line default
#line hidden
#nullable disable
                                        ));
                                        __builder8.AddAttribute(83, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 95 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultList.razor"
                                                             faultToEdit.MakinaGrubu

#line default
#line hidden
#nullable disable
                                        ));
                                        __builder8.CloseComponent();
                                        __builder8.AddMarkupContent(84, "\r\n\r\n\r\n\r\n                            ");
                                        __builder8.AddMarkupContent(85, "<label>Makina : </label>\r\n                            ");
                                        __builder8.OpenComponent<Blazorise.TextEdit>(86);
                                        __builder8.AddAttribute(87, "Disabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 100 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultList.razor"
                                                true

#line default
#line hidden
#nullable disable
                                        ));
                                        __builder8.AddAttribute(88, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 100 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultList.razor"
                                                             faultToEdit.Makina

#line default
#line hidden
#nullable disable
                                        ));
                                        __builder8.CloseComponent();
                                        __builder8.AddMarkupContent(89, "\r\n\r\n\r\n\r\n\r\n                            ");
                                        __builder8.AddMarkupContent(90, "<label>Operatör : </label>\r\n\r\n                            ");
                                        __builder8.OpenComponent<Blazorise.TextEdit>(91);
                                        __builder8.AddAttribute(92, "Disabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 107 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultList.razor"
                                                true

#line default
#line hidden
#nullable disable
                                        ));
                                        __builder8.AddAttribute(93, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 107 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultList.razor"
                                                             faultToEdit.Operator

#line default
#line hidden
#nullable disable
                                        ));
                                        __builder8.CloseComponent();
                                        __builder8.AddMarkupContent(94, "\r\n\r\n\r\n                            ");
                                        __builder8.AddMarkupContent(95, "<label>Açıklama :</label>\r\n\r\n\r\n                            ");
                                        __builder8.OpenComponent<Blazorise.TextEdit>(96);
                                        __builder8.AddAttribute(97, "Disabled", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 113 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultList.razor"
                                                true

#line default
#line hidden
#nullable disable
                                        ));
                                        __builder8.AddAttribute(98, "Text", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 113 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultList.razor"
                                                             faultToEdit.Description

#line default
#line hidden
#nullable disable
                                        ));
                                        __builder8.CloseComponent();
                                        __builder8.AddMarkupContent(99, "\r\n\r\n\r\n                        ");
                                    }
                                    ));
                                    __builder7.CloseComponent();
                                    __builder7.AddMarkupContent(100, "\r\n                    ");
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(101, "\r\n\r\n                    ");
                                __builder6.OpenComponent<Blazorise.Card>(102);
                                __builder6.AddAttribute(103, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder7) => {
                                    __builder7.AddMarkupContent(104, "\r\n\r\n                        ");
                                    __builder7.OpenComponent<Blazorise.CardBody>(105);
                                    __builder7.AddAttribute(106, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder8) => {
                                        __builder8.AddMarkupContent(107, "\r\n\r\n\r\n                            ");
                                        __builder8.OpenElement(108, "div");
                                        __builder8.AddMarkupContent(109, "\r\n\r\n\r\n                                ");
                                        __builder8.OpenElement(110, "div");
                                        __builder8.AddMarkupContent(111, "\r\n                                    ");
                                        __builder8.AddMarkupContent(112, "<div>\r\n                                        <label>Kullanıcı Adı</label>\r\n                                    </div>\r\n\r\n                                    ");
                                        __builder8.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(113);
                                        __builder8.AddAttribute(114, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 135 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultList.razor"
                                                             faultToEdit.FixBy

#line default
#line hidden
#nullable disable
                                        ));
                                        __builder8.AddAttribute(115, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => faultToEdit.FixBy = __value, faultToEdit.FixBy))));
                                        __builder8.AddAttribute(116, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => faultToEdit.FixBy));
                                        __builder8.AddAttribute(117, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder9) => {
                                            __builder9.AddMarkupContent(118, "\r\n                                    ");
                                        }
                                        ));
                                        __builder8.CloseComponent();
                                        __builder8.AddMarkupContent(119, "\r\n                                ");
                                        __builder8.CloseElement();
                                        __builder8.AddMarkupContent(120, "\r\n                                ");
                                        __builder8.OpenElement(121, "div");
                                        __builder8.AddMarkupContent(122, "\r\n                                    ");
                                        __builder8.AddMarkupContent(123, "<div>\r\n                                        <label>Yapılan İşlemler</label>\r\n                                    </div>\r\n\r\n                                    ");
                                        __builder8.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputTextArea>(124);
                                        __builder8.AddAttribute(125, "rows", "7");
                                        __builder8.AddAttribute(126, "cols", "42");
                                        __builder8.AddAttribute(127, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 144 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultList.razor"
                                                                 faultToEdit.FixDescription

#line default
#line hidden
#nullable disable
                                        ));
                                        __builder8.AddAttribute(128, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => faultToEdit.FixDescription = __value, faultToEdit.FixDescription))));
                                        __builder8.AddAttribute(129, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => faultToEdit.FixDescription));
                                        __builder8.CloseComponent();
                                        __builder8.AddMarkupContent(130, "\r\n                                ");
                                        __builder8.CloseElement();
                                        __builder8.AddMarkupContent(131, "\r\n                                ");
                                        __builder8.OpenElement(132, "div");
                                        __builder8.AddMarkupContent(133, "\r\n                                    ");
                                        __builder8.AddMarkupContent(134, "<div>\r\n\r\n                                        <label>Tarih</label>\r\n                                    </div>\r\n  \r\n                                    ");
                                        __Blazor.BlazorApp4.Client.Pages.FaultPages.FaultList.TypeInference.CreateInputDate_0(__builder8, 135, 136, 
#nullable restore
#line 154 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultList.razor"
                                                              faultToEdit.FixedTime

#line default
#line hidden
#nullable disable
                                        , 137, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => faultToEdit.FixedTime = __value, faultToEdit.FixedTime)), 138, () => faultToEdit.FixedTime);
                                        __builder8.AddMarkupContent(139, "\r\n                                ");
                                        __builder8.CloseElement();
                                        __builder8.AddMarkupContent(140, "\r\n\r\n                                <hr>\r\n                            ");
                                        __builder8.CloseElement();
                                        __builder8.AddMarkupContent(141, "\r\n\r\n\r\n\r\n                        ");
                                    }
                                    ));
                                    __builder7.CloseComponent();
                                    __builder7.AddMarkupContent(142, "\r\n                    ");
                                }
                                ));
                                __builder6.CloseComponent();
                                __builder6.AddMarkupContent(143, "\r\n                    ");
                            }
                            ));
                            __builder5.CloseComponent();
                            __builder5.AddMarkupContent(144, "\r\n            ");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(145, "\r\n        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(146, "\r\n        ");
                    __builder3.OpenComponent<Blazorise.ModalFooter>(147);
                    __builder3.AddAttribute(148, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddMarkupContent(149, "\r\n            ");
                        __builder4.OpenComponent<Blazorise.Button>(150);
                        __builder4.AddAttribute(151, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.Color>(
#nullable restore
#line 172 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultList.razor"
                           Color.Secondary

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(152, "Clicked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 172 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultList.razor"
                                                       ()=>SaveChanges()

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(153, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(154, "Kapat");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(155, "\r\n            ");
                        __builder4.OpenComponent<Blazorise.Button>(156);
                        __builder4.AddAttribute(157, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Blazorise.Color>(
#nullable restore
#line 173 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultList.razor"
                           Color.Primary

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(158, "Clicked", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 173 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultList.razor"
                                                    HideModal

#line default
#line hidden
#nullable disable
                        )));
                        __builder4.AddAttribute(159, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddContent(160, "Kaydet");
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(161, "\r\n        ");
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(162, "\r\n    ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(163, "\r\n");
            }
            ));
            __builder.AddComponentReferenceCapture(164, (__value) => {
#nullable restore
#line 68 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultList.razor"
                                 modalRef = (Blazorise.Modal)__value;

#line default
#line hidden
#nullable disable
            }
            );
            __builder.CloseComponent();
            __builder.AddMarkupContent(165, "\r\n");
#nullable restore
#line 177 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultList.razor"


}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 180 "C:\Users\Duygu GÜNGÖR\source\repos\BlazorApp4\BlazorApp4\Client\Pages\FaultPages\FaultList.razor"
       

    public DateTime? dateTime1 = DateTime.Now;
 



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

    private void ShowModal()
    {

        //   selectedFault = fault;
        modalRef.Show();
    }
    private void EditFault()
    {

    }

    async  Task SaveChanges()
    {
        await http.PostAsJsonAsync($"api/fault", faultToEdit);
        modalRef.Hide();
        return ;

    }
    private void HideModal()
    {
        selectedFault = null;
        modalRef.Hide();
    }

    public async void GetFaultAndShowModal(int id)
    {
        faultToEdit = await http.GetFromJsonAsync<BlazorApp4.Shared.Models.Fault>($"api/fault/{id}");
        ShowModal();
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
namespace __Blazor.BlazorApp4.Client.Pages.FaultPages.FaultList
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputDate_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2)
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
