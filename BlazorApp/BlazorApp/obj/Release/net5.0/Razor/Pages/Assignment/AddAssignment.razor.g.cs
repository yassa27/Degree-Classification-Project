#pragma checksum "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\Pages\Assignment\AddAssignment.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9310f6ef24aafa56382d6f8e57b829693b54b817"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Pages.Assignment
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
#line 2 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\Pages\Assignment\AddAssignment.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\Pages\Assignment\AddAssignment.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\Pages\Assignment\AddAssignment.razor"
using BlazorApp.Common.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\Pages\Assignment\AddAssignment.razor"
using BlazorApp.Services.Interface;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/addassignment/{moduleid:long}")]
    public partial class AddAssignment : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 9 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\Pages\Assignment\AddAssignment.razor"
 if (Successmessage != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "p");
            __builder.AddAttribute(1, "class", "alert-success");
            __builder.AddContent(2, 
#nullable restore
#line 11 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\Pages\Assignment\AddAssignment.razor"
                              Successmessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 12 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\Pages\Assignment\AddAssignment.razor"
}else if(Failuremessage != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "p");
            __builder.AddAttribute(4, "class", "alert-danger");
            __builder.AddContent(5, 
#nullable restore
#line 14 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\Pages\Assignment\AddAssignment.razor"
                             Failuremessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 15 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\Pages\Assignment\AddAssignment.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(6, "<h3>Add Assignment</h3>\r\n");
            __builder.OpenElement(7, "form");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "form-outline mb-4");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "col-md-4");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(12);
            __builder.AddAttribute(13, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 20 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\Pages\Assignment\AddAssignment.razor"
                              assignmentVM

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 20 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\Pages\Assignment\AddAssignment.razor"
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
                __builder2.AddMarkupContent(22, "<label>Enter Assignment Name</label>\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(23);
                __builder2.AddAttribute(24, "class", "form-control");
                __builder2.AddAttribute(25, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\Pages\Assignment\AddAssignment.razor"
                                            assignmentVM.AssignmentName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => assignmentVM.AssignmentName = __value, assignmentVM.AssignmentName))));
                __builder2.AddAttribute(27, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => assignmentVM.AssignmentName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n                ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "form-group");
                __builder2.AddMarkupContent(31, "<label>Enter Assignment Weight</label>\r\n                    ");
                __Blazor.BlazorApp.Pages.Assignment.AddAssignment.TypeInference.CreateInputNumber_0(__builder2, 32, 33, "form-control", 34, 
#nullable restore
#line 29 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\Pages\Assignment\AddAssignment.razor"
                                              assignmentVM.AssignmentWeight

#line default
#line hidden
#nullable disable
                , 35, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => assignmentVM.AssignmentWeight = __value, assignmentVM.AssignmentWeight)), 36, () => assignmentVM.AssignmentWeight);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(37, "\r\n                ");
                __builder2.OpenElement(38, "div");
                __builder2.AddAttribute(39, "class", "form-group");
                __builder2.AddMarkupContent(40, "<label>Enter Assignment Grade</label>\r\n                    ");
                __Blazor.BlazorApp.Pages.Assignment.AddAssignment.TypeInference.CreateInputNumber_1(__builder2, 41, 42, "form-control", 43, 
#nullable restore
#line 33 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\Pages\Assignment\AddAssignment.razor"
                                              assignmentVM.AssignmentGrade

#line default
#line hidden
#nullable disable
                , 44, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => assignmentVM.AssignmentGrade = __value, assignmentVM.AssignmentGrade)), 45, () => assignmentVM.AssignmentGrade);
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n                  ");
                __builder2.OpenElement(47, "div");
                __builder2.AddAttribute(48, "class", "submit-btn-con col-12 text-right");
                __builder2.OpenElement(49, "a");
                __builder2.AddAttribute(50, "href", "/Assignment/index/" + (
#nullable restore
#line 36 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\Pages\Assignment\AddAssignment.razor"
                                                        Moduleid

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(51, "name");
                __builder2.AddAttribute(52, "id");
                __builder2.AddAttribute(53, "class", "btn btn-secondary btn-cancel text-white text-uppercase font-weight-bold");
                __builder2.AddContent(54, "Cancel");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(55, "\r\n                            <input type=\"submit\" name id class=\"btn btn-primary btn-submit text-white text-uppercase font-weight-bold\" value=\"Add \">");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\Pages\Assignment\AddAssignment.razor"
       
    AssignmentVM assignmentVM = new AssignmentVM();
    public string UserName;
    string Successmessage = null;
    string Failuremessage = null;
    private long modid;
    [Parameter]
    public long Moduleid
    {
        get { return modid; }
        set
        {
            modid = value;
        }
    }
    private async Task HandleValidSubmit()
    {
        UserName = HttpContextAccessor.HttpContext.User.Identity.Name;
        if (assignmentVM !=null)
        {
            assignmentVM.InsertedBy = UserName;
            assignmentVM.ModuleId = Moduleid;
            var response =  _Assignment.AddNewAssignment(assignmentVM);
            if(response == true)
            {
                Successmessage ="Assignment Added  SuccessFully";
                assignmentVM = new AssignmentVM();
                NavigationManager.NavigateTo("/Assignment/index/"+Moduleid);
            }
            else
            {
                Failuremessage = "Something went wrong, please ensure the assignment weight is correct";
            }
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICourseManagementService _Assignment { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpContextAccessor HttpContextAccessor { get; set; }
    }
}
namespace __Blazor.BlazorApp.Pages.Assignment.AddAssignment
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
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
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
