#pragma checksum "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\Pages\Assignment\Assignments.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b18286b26ca3ec2fc9f1e24207ecc327af86f89"
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
#line 2 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\Pages\Assignment\Assignments.razor"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\Pages\Assignment\Assignments.razor"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\Pages\Assignment\Assignments.razor"
using BlazorApp.Common.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\Pages\Assignment\Assignments.razor"
using BlazorApp.Services.Interface;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Assignment/index/{moduleid:long}")]
    public partial class Assignments : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h2>Assignments</h2>");
#nullable restore
#line 11 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\Pages\Assignment\Assignments.razor"
 if (Successmessage != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "p");
            __builder.AddAttribute(2, "class", "alert-success");
            __builder.AddContent(3, 
#nullable restore
#line 13 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\Pages\Assignment\Assignments.razor"
                              Successmessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 14 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\Pages\Assignment\Assignments.razor"
}else if(Failuremessage != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "p");
            __builder.AddAttribute(5, "class", "alert-danger");
            __builder.AddContent(6, 
#nullable restore
#line 16 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\Pages\Assignment\Assignments.razor"
                             Successmessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 17 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\Pages\Assignment\Assignments.razor"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\Pages\Assignment\Assignments.razor"
 if (assignmentListVM.assignmentVMs == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(7, "<h3>Loading.....</h3>");
#nullable restore
#line 21 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\Pages\Assignment\Assignments.razor"
}else{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "row");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "col-md-12");
#nullable restore
#line 24 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\Pages\Assignment\Assignments.razor"
             if (ModuleName != null)
           {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(12, "h3");
            __builder.AddContent(13, "Module: ");
            __builder.AddContent(14, 
#nullable restore
#line 26 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\Pages\Assignment\Assignments.razor"
                            ModuleName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 27 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\Pages\Assignment\Assignments.razor"
           }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "col-12 col-sm-0 text-right mb-2");
            __builder.OpenElement(17, "button");
            __builder.AddAttribute(18, "class", "btn btn-primary mx-2");
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 29 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\Pages\Assignment\Assignments.razor"
                                                               (() => AddAssignment(modid))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(20, "\r\n                                        Add New Assignment\r\n                                    ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n            ");
            __builder.OpenElement(22, "table");
            __builder.AddAttribute(23, "class", "table table-striped");
            __builder.AddMarkupContent(24, "<thead class=\"thead-dark\"><tr><th>Assignment Name</th> \r\n                        <th>Assignment Weight</th>\r\n                        <th>Assignment Grade</th>\r\n                        <th></th></tr></thead>\r\n                ");
            __builder.OpenElement(25, "tbody");
#nullable restore
#line 42 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\Pages\Assignment\Assignments.razor"
                     foreach (var p in assignmentListVM.assignmentVMs)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(26, "tr");
            __builder.OpenElement(27, "td");
            __builder.AddContent(28, 
#nullable restore
#line 45 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\Pages\Assignment\Assignments.razor"
                                 p.AssignmentName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                            ");
            __builder.OpenElement(30, "td");
            __builder.AddContent(31, 
#nullable restore
#line 46 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\Pages\Assignment\Assignments.razor"
                                 p.AssignmentWeight

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                            ");
            __builder.OpenElement(33, "td");
            __builder.AddContent(34, 
#nullable restore
#line 47 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\Pages\Assignment\Assignments.razor"
                                 p.AssignmentGrade

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n                                ");
            __builder.OpenElement(36, "td");
#nullable restore
#line 50 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\Pages\Assignment\Assignments.razor"
                                     if (idToDelete == p.Id)
                                    {


#line default
#line hidden
#nullable disable
            __builder.OpenElement(37, "button");
            __builder.AddAttribute(38, "class", "btn btn-danger mx-2");
            __builder.AddAttribute(39, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 53 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\Pages\Assignment\Assignments.razor"
                                                                                      (() => DeleteAssignment(p.Id))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(40, "\r\n                                            Confirm Delete\r\n                                        ");
            __builder.CloseElement();
#nullable restore
#line 56 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\Pages\Assignment\Assignments.razor"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(41, "button");
            __builder.AddAttribute(42, "class", "btn btn-outline-danger mx-2");
            __builder.AddAttribute(43, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 59 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\Pages\Assignment\Assignments.razor"
                                                                                              (() => idToDelete =p.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(44, "\r\n                                            Delete\r\n                                        ");
            __builder.CloseElement();
#nullable restore
#line 62 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\Pages\Assignment\Assignments.razor"
                                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 65 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\Pages\Assignment\Assignments.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n              ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "col-md-4 mb-4");
            __builder.OpenElement(48, "button");
            __builder.AddAttribute(49, "class", "btn btn-secondary mx-2");
            __builder.AddAttribute(50, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 68 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\Pages\Assignment\Assignments.razor"
                                                                                          (() => Module())

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(51, "\r\n                                        Back to Module\r\n                                    ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 73 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\Pages\Assignment\Assignments.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 74 "C:\Users\siddi\Source\Repos\yassa27\Degree-Classification-Project\BlazorApp\BlazorApp\Pages\Assignment\Assignments.razor"
       
    private long idToDelete = 0;
    private long idToAdd = 0;
    public string UserName;
    public string ModuleName;
    private long modid;
    string Successmessage = null;
    string Failuremessage = null;
    [Parameter]
    public long Moduleid
    {
        get { return modid; }
        set
        {
            modid = value;
        }
    }
    AssignmentListVM assignmentListVM = new AssignmentListVM();
    protected override async Task OnParametersSetAsync()
    {
        UserName = HttpContextAccessor.HttpContext.User.Identity.Name;
        var mod =  _Assignment.GetModuleById(Moduleid);
        ModuleName = mod.ModuleName;
        var res =  _Assignment.GetAssignments(Moduleid);
        assignmentListVM.assignmentVMs = res.assignmentVMs;
    }
    private void Module()
    {
        NavigationManager.NavigateTo("./module/index");
    }
    private void AddAssignment(long id)
    {
        NavigationManager.NavigateTo("./addassignment/"+id);
    }
    private async Task DeleteAssignment(long id)
    {
        var res = _Assignment.RemoveAssignment(id,Moduleid,UserName);
        if (res == true)
        {
            Successmessage ="Assignment Deleted  SuccessFully";
            var response =  _Assignment.GetAssignments(Moduleid);
            assignmentListVM.assignmentVMs = response.assignmentVMs;
        }else
        {
            Failuremessage = "Something went wrong";
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
#pragma warning restore 1591
