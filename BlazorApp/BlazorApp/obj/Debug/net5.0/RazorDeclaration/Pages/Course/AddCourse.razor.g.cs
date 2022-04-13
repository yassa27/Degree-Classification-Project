// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp.Pages.Course
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
#line 2 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\Pages\Course\AddCourse.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\Pages\Course\AddCourse.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\Pages\Course\AddCourse.razor"
using BlazorApp.Common.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\Pages\Course\AddCourse.razor"
using BlazorApp.Services.Interface;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/addcourse")]
    public partial class AddCourse : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 46 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\Pages\Course\AddCourse.razor"
       
    CourseVM courseVM = new CourseVM();
    public string UserName;
    string Successmessage = null;
    string Failuremessage = null;
    private async Task HandleValidSubmit()
    {
        UserName = HttpContextAccessor.HttpContext.User.Identity.Name;
        if (courseVM !=null)
        {
            courseVM.InsertedBy = UserName;
            var response =  _course.AddNewCourse(courseVM);
            if(response == true)
            {
                Successmessage ="Course Added  SuccessFully";
                courseVM = new CourseVM();
                NavigationManager.NavigateTo("/");
            }
            else
            {
                Failuremessage = "Course is Already Added or Something Wents Wrong... ";

            }
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICourseManagementService _course { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHttpContextAccessor HttpContextAccessor { get; set; }
    }
}
#pragma warning restore 1591
