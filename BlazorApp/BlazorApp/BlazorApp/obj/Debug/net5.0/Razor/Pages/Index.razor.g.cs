#pragma checksum "C:\Users\siddi\Downloads\BlazorApp\BlazorApp\BlazorApp\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c53dce133f5ccd6e19180c58800f8fbc717ce004"
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
#line 1 "C:\Users\siddi\Downloads\BlazorApp\BlazorApp\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\siddi\Downloads\BlazorApp\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\siddi\Downloads\BlazorApp\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\siddi\Downloads\BlazorApp\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\siddi\Downloads\BlazorApp\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\siddi\Downloads\BlazorApp\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\siddi\Downloads\BlazorApp\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\siddi\Downloads\BlazorApp\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\siddi\Downloads\BlazorApp\BlazorApp\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\siddi\Downloads\BlazorApp\BlazorApp\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\siddi\Downloads\BlazorApp\BlazorApp\BlazorApp\Pages\Index.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\siddi\Downloads\BlazorApp\BlazorApp\BlazorApp\Pages\Index.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\siddi\Downloads\BlazorApp\BlazorApp\BlazorApp\Pages\Index.razor"
using BlazorApp.Common.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\siddi\Downloads\BlazorApp\BlazorApp\BlazorApp\Pages\Index.razor"
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
#line 10 "C:\Users\siddi\Downloads\BlazorApp\BlazorApp\BlazorApp\Pages\Index.razor"
 if (courseVM.CourseName == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<div class=\"col-md-12 mb-4\"><h6>You Have Not Add Course Yet, Please Add Your Course</h6></div>\r\n    ");
            __builder.AddMarkupContent(1, @"<div class=""col-md-12""><a class=""btn btn-labeled btn-dgreen"" href=""addcourse"" role=""button"" style=""padding-top: 5px; padding-bottom: 5px; margin-bottom: 20px; width: 280px; margin-left: 50px; margin-right50px;""><span style=""position: relative; left: -12px; display: inline-block; padding: 12px 24px; background: rgba(0,0,0,0.15); border-radius: 6px 0 0 6px;""><i class=""oi oi-plus""></i></span>Add Course
        </a></div>");
#nullable restore
#line 20 "C:\Users\siddi\Downloads\BlazorApp\BlazorApp\BlazorApp\Pages\Index.razor"
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
            __builder.AddContent(6, 
#nullable restore
#line 25 "C:\Users\siddi\Downloads\BlazorApp\BlazorApp\BlazorApp\Pages\Index.razor"
     courseVM.CourseName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n  ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "card-body");
            __builder.OpenElement(10, "h5");
            __builder.AddAttribute(11, "class", "card-title");
            __builder.AddContent(12, "Year: ");
            __builder.AddContent(13, 
#nullable restore
#line 28 "C:\Users\siddi\Downloads\BlazorApp\BlazorApp\BlazorApp\Pages\Index.razor"
                                  courseVM.CourseYear

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.OpenElement(15, "p");
            __builder.AddAttribute(16, "class", "card-text");
            __builder.AddContent(17, "Progress: ");
            __builder.AddContent(18, 
#nullable restore
#line 29 "C:\Users\siddi\Downloads\BlazorApp\BlazorApp\BlazorApp\Pages\Index.razor"
                                    courseVM.CourseProgress

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(19, " %");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n    ");
            __builder.OpenElement(21, "p");
            __builder.AddAttribute(22, "class", "card-text");
            __builder.AddContent(23, "Your Degree Classification: ");
            __builder.AddContent(24, 
#nullable restore
#line 30 "C:\Users\siddi\Downloads\BlazorApp\BlazorApp\BlazorApp\Pages\Index.razor"
                                                      courseVM.DegreeClassification

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n  ");
            __builder.AddMarkupContent(26, "<div class=\"card-footer text-muted\"><a href=\"/module/index\" class=\"btn btn-primary\">Go to Course Modules</a></div>");
            __builder.CloseElement();
#nullable restore
#line 36 "C:\Users\siddi\Downloads\BlazorApp\BlazorApp\BlazorApp\Pages\Index.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\siddi\Downloads\BlazorApp\BlazorApp\BlazorApp\Pages\Index.razor"
       
    public string UserName;
    string Successmessage = null;
    string Failuemessage = null;
    CourseVM courseVM = new CourseVM();
    protected override async Task OnInitializedAsync()
    {
        UserName = HttpContextAccessor.HttpContext.User.Identity.Name;
        var course = _Course.GetUserCourse(UserName);
        if (course !=null)
        {
            courseVM = course;
            float f = course.CourseProgress;
            //rounding to 2 decimal places
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
