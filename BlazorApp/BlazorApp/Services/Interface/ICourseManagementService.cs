using BlazorApp.Common.ViewModels;
using System.Threading.Tasks;

namespace BlazorApp.Services.Interface
{
    //This is the public interface, users will not be able to access function implementation
    public interface ICourseManagementService
    {
        bool AddNewCourse(CourseVM courseVM);
        CourseVM GetUserCourse(string user);
        bool RemoveCourse(long courseid);
        bool AddNewModule(ModuleVM moduleVM);
        bool AddNewAssignment(AssignmentVM assignmentVM);
        ModuleListVM GetUserModules(string user);
        ModuleVM GetModuleById(long id);
        AssignmentListVM GetAssignments(long moduleid);
        AssignmentVM GetAssignmentById(long id);
        bool RemoveAssignment(long id,long moduleid, string user);
        bool RemoveModule(long id, string user);
    }
}
