<<<<<<< HEAD
#pragma checksum "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b98d9dabcc045227cb5eec3fb75cee8f541ddd4"
=======
#pragma checksum "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a32d5145524a234329c57a9ab768f21a1b9637ee"
>>>>>>> 7020a4a0e6bbc8b8cc51df83528bb353b6569274
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Pages
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
#line 2 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\Pages\Index.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\Pages\Index.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\Pages\Index.razor"
using BlazorApp.Common.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\Pages\Index.razor"
using BlazorApp.Services.Interface;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 11 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\Pages\Index.razor"
 if (courseVM.CourseName == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<div class=\"col-md-12 mb-4\"><h6>You Have Not Add Course Yet, Please Add Your Course</h6></div>\r\n    ");
            __builder.AddMarkupContent(1, @"<div class=""col-md-12""><a class=""btn btn-labeled btn-dgreen"" href=""addcourse"" role=""button"" style=""padding-top: 5px; padding-bottom: 5px; margin-bottom: 20px; width: 280px; margin-left: 50px; margin-right50px;""><span style=""position: relative; left: -12px; display: inline-block; padding: 12px 24px; background: rgba(0,0,0,0.15); border-radius: 6px 0 0 6px;""><i class=""oi oi-plus""></i></span>Add Course
        </a></div>");
#nullable restore
#line 21 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\Pages\Index.razor"
}
else
{
   

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "card text-center mb-6");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card-header");
            __builder.OpenElement(6, "strong");
            __builder.AddContent(7, 
#nullable restore
#line 27 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\Pages\Index.razor"
             courseVM.CourseName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n\r\n  ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "card-body");
            __builder.OpenElement(11, "h5");
            __builder.AddAttribute(12, "class", "card-title");
            __builder.AddMarkupContent(13, "<strong>Year : </strong> ");
            __builder.AddContent(14, 
#nullable restore
#line 31 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\Pages\Index.razor"
                                                     courseVM.CourseYear

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n    ");
            __builder.OpenElement(16, "p");
            __builder.AddAttribute(17, "class", "card-text mb-0");
            __builder.AddMarkupContent(18, "<strong>Current Progress : </strong>");
            __builder.AddContent(19, 
#nullable restore
#line 32 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\Pages\Index.razor"
                                                                   courseVM.CourseProgress

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(20, " % ");
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n      ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "progress mb-2");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "progress-bar progress-bar-success progress-bar-striped");
            __builder.AddAttribute(26, "role", "progressbar");
            __builder.AddAttribute(27, "aria-valuenow", 
#nullable restore
#line 35 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\Pages\Index.razor"
                  courseVM.CourseProgress

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(28, "aria-valuemin", "0");
            __builder.AddAttribute(29, "aria-valuemax", "100");
            __builder.AddAttribute(30, "style", "width:" + (
#nullable restore
#line 35 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\Pages\Index.razor"
                                                                                               courseVM.CourseProgress

#line default
#line hidden
#nullable disable
            ) + "%");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n    \r\n    ");
            __builder.OpenElement(32, "p");
            __builder.AddAttribute(33, "class", "card-text");
            __builder.AddMarkupContent(34, "<strong>Your Degree Classification : </strong> ");
            __builder.AddContent(35, 
#nullable restore
#line 39 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\Pages\Index.razor"
                                                                         courseVM.DegreeClassification

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n  ");
            __builder.AddMarkupContent(37, "<div class=\"card-footer text-muted\"><a href=\"/module/index\" class=\"btn btn-primary\"><i>Go to your Course Modules</i></a></div>");
            __builder.CloseElement();
#nullable restore
#line 45 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\Pages\Index.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\Pages\Index.razor"
       
    public string UserName;
    string Successmessage = null;
    string Failuremessage = null;
    CourseVM courseVM = new CourseVM();
    protected override async Task OnInitializedAsync()
    {
        UserName = HttpContextAccessor.HttpContext.User.Identity.Name;
        var course = _Course.GetUserCourse(UserName);
        if (course !=null)
        {
            courseVM = course;
            float f = course.CourseProgress;
            float fc = (float)Math.Round(f * 100f) / 100f;
            courseVM.CourseProgress = fc;
        }
       
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICourseManagementService _Course { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpContextAccessor HttpContextAccessor { get; set; }
    }
}
#pragma warning restore 1591
