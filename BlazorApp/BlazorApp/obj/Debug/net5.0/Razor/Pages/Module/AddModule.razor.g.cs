#pragma checksum "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\Pages\Module\AddModule.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54447d803e63102f293a42b3859f458a93274334"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Pages.Module
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\Pages\Module\AddModule.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\Pages\Module\AddModule.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\Pages\Module\AddModule.razor"
using BlazorApp.Common.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\Pages\Module\AddModule.razor"
using BlazorApp.Services.Interface;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/addmodule")]
    public partial class AddModule : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 9 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\Pages\Module\AddModule.razor"
 if (Successmessage != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "p");
            __builder.AddAttribute(1, "class", "alert-success");
            __builder.AddContent(2, 
#nullable restore
#line 11 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\Pages\Module\AddModule.razor"
                              Successmessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 12 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\Pages\Module\AddModule.razor"
}else if(Failuemessage != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "p");
            __builder.AddAttribute(4, "class", "alert-danger");
            __builder.AddContent(5, 
#nullable restore
#line 14 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\Pages\Module\AddModule.razor"
                             Failuemessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 15 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\Pages\Module\AddModule.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(6, "<h3>Add Module</h3>\r\n");
            __builder.OpenElement(7, "form");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "form-outline mb-4");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "col-md-4");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(12);
            __builder.AddAttribute(13, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 20 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\Pages\Module\AddModule.razor"
                              moduleVM

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 20 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\Pages\Module\AddModule.razor"
                                                       HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(15, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(16);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(17, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(18);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\r\n                ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "form-group");
                __builder2.AddMarkupContent(22, "<label>Enter Module Name</label>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(23);
                __builder2.AddAttribute(24, "class", "form-control");
                __builder2.AddAttribute(25, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\Pages\Module\AddModule.razor"
                                            moduleVM.ModuleName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => moduleVM.ModuleName = __value, moduleVM.ModuleName))));
                __builder2.AddAttribute(27, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => moduleVM.ModuleName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n                ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "form-group");
                __builder2.AddMarkupContent(31, "<label>Enter Module Credits</label>\r\n                    ");
                __Blazor.BlazorApp.Pages.Module.AddModule.TypeInference.CreateInputNumber_0(__builder2, 32, 33, "form-control", 34, 
#nullable restore
#line 29 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\Pages\Module\AddModule.razor"
                                              moduleVM.ModuleCredit

#line default
#line hidden
#nullable disable
                , 35, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => moduleVM.ModuleCredit = __value, moduleVM.ModuleCredit)), 36, () => moduleVM.ModuleCredit);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n                ");
                __builder2.AddMarkupContent(38, @"<div class=""submit-btn-con col-12 text-right""><a href=""/module/index"" name id class=""btn btn-secondary btn-cancel text-white text-uppercase font-weight-bold"">Cancel</a>
                            <input type=""submit"" name id class=""btn btn-primary btn-submit text-white text-uppercase font-weight-bold"" value=""Add ""></div>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\Pages\Module\AddModule.razor"
       
    ModuleVM moduleVM = new ModuleVM();
    public string UserName;
    string Successmessage = null;
    string Failuemessage = null;
    private async Task HandleValidSubmit()
    {
        UserName = HttpContextAccessor.HttpContext.User.Identity.Name;
        if (moduleVM !=null)
        {
            moduleVM.InsertedBy = UserName;
            var response =  _Module.AddNewModule(moduleVM);
            if(response == true)
            {
                Successmessage ="Module Added  SuccessFully";
                moduleVM = new ModuleVM();
               NavigationManager.NavigateTo("/module/index");
            }
            else
            {
                 Failuemessage ="Module is Already Added or Something Wents Wrong... ";
            }
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICourseManagementService _Module { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpContextAccessor HttpContextAccessor { get; set; }
    }
}
namespace __Blazor.BlazorApp.Pages.Module.AddModule
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
