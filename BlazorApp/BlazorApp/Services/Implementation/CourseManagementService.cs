using BlazorApp.Common.ViewModels;
using BlazorApp.Data;
using BlazorApp.Services.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Services.Implementation
{
    public class CourseManagementService : ICourseManagementService
    {
        private readonly ApplicationDbContext _context;
        public CourseManagementService(ApplicationDbContext context)
        {
            this._context = context;
        }
        #region Course mgt.
        public bool AddNewCourse(CourseVM courseVM)
        {
            bool turn = false;
            try
            {
                if (courseVM !=null)
                {  
                    var coursecheck =  _context.Courses.Where(x => x.InsertedBy == courseVM.InsertedBy).FirstOrDefault();
                    if (coursecheck == null)
                    {
                        Course course = new Course();
                        course.CourseYear = courseVM.CourseYear;
                        course.CourseName = courseVM.CourseName;
                        course.InsertedDate = System.DateTime.Now;
                        course.InsertedBy = courseVM.InsertedBy;
                        course.isActive = true;
                        var response =  _context.Courses.Add(course);
                        if (response !=null)
                        {
                             _context.SaveChanges();
                            turn = true;
                        }
                    }
                }
               
            }
            catch (System.Exception)
            {

                throw;
            }
            return turn;
        }
        public CourseVM GetUserCourse(string user)
        {
            try
            {
                var course =  _context.Courses.Where(x => x.InsertedBy == user).Select(y => new CourseVM
                {
                    Id = y.Id,
                    CourseName = y.CourseName,
                    CourseYear = y.CourseYear,
                    CourseProgress = y.CourseProgress,
                    InsertedBy = y.InsertedBy,
                    isActive = y.isActive
                }).FirstOrDefault();
                if (course != null)
                {
                    if (course.CourseProgress >= 69.5)
                    {
                        course.DegreeClassification = "1st";
                    }
                    else if (course.CourseProgress >= 59.5 && course.CourseProgress <= 69.4)
                    {
                        course.DegreeClassification = "2:1";
                    }
                    else if (course.CourseProgress >= 49.5 && course.CourseProgress <= 59.4)
                    {
                        course.DegreeClassification = "2:2";
                    }
                    else if (course.CourseProgress >= 39.5 && course.CourseProgress <= 49.4)
                    {
                        course.DegreeClassification = "3rd";
                    }
                    else if (course.CourseProgress == 0)
                    {
                        course.DegreeClassification = "-";
                    }
                    else
                    {
                        course.DegreeClassification = "Fail";
                    }
                }
              
                return course;
            }
            catch (System.Exception)
            {

                throw;
            }
        }
       
        public bool RemoveCourse(long courseid)
        {
            var turn = false;
            try
            {
                var obj =  _context.Courses.Where(x => x.Id == courseid).FirstOrDefault();
                if (obj != null)
                {
                   var mod =  _context.Modules.Where(x => x.CourseId == courseid).ToList();
                    foreach (var item in mod)
                    {
                        _context.Modules.Remove(item);
                        var assign =  _context.Assignments.Where(x => x.ModuleId == item.Id).ToList();
                        foreach (var i in assign)
                        {
                            _context.Assignments.Remove(i);
                        }
                    } 
                  
                    var response = _context.Courses.Remove(obj);
                    if (response != null)
                    {
                        turn = true;
                         _context.SaveChanges();
                    }

                }

            }
            catch (Exception)
            {

                throw;
            }
            return turn;
        }
        #endregion

        public bool AddNewModule(ModuleVM moduleVM)
        {
            bool turn = false;
            try
            {
                if (moduleVM !=null)
                {
                    var course =  _context.Courses.Where(x => x.InsertedBy == moduleVM.InsertedBy).FirstOrDefault();
                    if (course !=null)
                    {
                        var modulecheck =  _context.Modules.Where(x => x.ModuleName == moduleVM.ModuleName && x.InsertedBy == moduleVM.InsertedBy).FirstOrDefault();
                        if (modulecheck ==null)
                        {
                            Module module = new Module();
                            module.ModuleName = moduleVM.ModuleName;
                            module.ModuleCredit = moduleVM.ModuleCredit;
                            module.CourseId = course.Id;
                            module.isActive = true;
                            module.InsertedDate = DateTime.Now;
                            module.InsertedBy = moduleVM.InsertedBy;
                            var response =  _context.Modules.Add(module);
                            if (response != null)
                            {
                                var moduleweightage = _context.Modules.Where(x => x.InsertedBy == moduleVM.InsertedBy).Sum(x => x.ModuleCredit);
                                float result = (course.CourseProgress * (float)moduleweightage) / 100;
                                float result1 = (result * ((float)moduleweightage + module.ModuleCredit)) /100;
                                course.CourseProgress = result1;
                                _context.Entry(course).State = EntityState.Modified;
                                 _context.SaveChanges();
                                turn = true;
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            return turn;
        }
        public ModuleListVM GetUserModules(string user)
        {
            ModuleListVM moduleListVM = new ModuleListVM();
            try
            {
                var Modules =  _context.Modules.Where(x => x.InsertedBy == user).Select(y => new ModuleVM
                {
                    Id = y.Id,
                    ModuleCredit = y.ModuleCredit,
                    ModuleName = y.ModuleName,
                    ModuleGrade = y.ModuleGrade,
                    ModuleProgress = y.ModuleProgress,
                    CourseId = y.CourseId,
                    InsertedBy = y.InsertedBy,
                    isActive = y.isActive
                }).ToList();
                moduleListVM.moduleVMs = Modules;
                return moduleListVM;
            }
            catch (System.Exception)
            {

                throw;
            }
        }
        public ModuleVM GetModuleById(long id)
        {
            try
            {
                var Modules =  _context.Modules.Where(x => x.Id == id).Select(y => new ModuleVM
                {
                    Id = y.Id,
                    ModuleCredit = y.ModuleCredit,
                    ModuleName = y.ModuleName,
                    ModuleGrade = y.ModuleGrade,
                    CourseId = y.CourseId,
                    InsertedBy = y.InsertedBy,
                    isActive = y.isActive
                }).FirstOrDefault();
                return Modules;
            }
            catch (System.Exception)
            {

                throw;
            }
        }
        public bool RemoveModule(long id, string user)
        {
            var turn = false;
            try
            {
                var obj =  _context.Modules.Where(x => x.Id == id).FirstOrDefault();
                if (obj != null)
                {
                   var assign =  _context.Assignments.Where(x => x.ModuleId == id).ToList();
                    var moduleweightage = _context.Modules.Where(x => x.InsertedBy == user).Sum(x => x.ModuleCredit);
                    var course = _context.Courses.Where(x => x.InsertedBy == user).FirstOrDefault();
                    if (assign.Count > 0)
                    {
                        foreach (var i in assign)
                        {
                            var assignvalue = (i.AssignmentGrade * i.AssignmentWeight) / 100;
                            var assigncoursevalue = (assignvalue * obj.ModuleCredit) / moduleweightage;
                            course.CourseProgress = course.CourseProgress - assigncoursevalue;
                            _context.Entry(course).State = EntityState.Modified;
                            _context.Assignments.Remove(i);
                        }
                    }
                    else
                    {
                        float result = (course.CourseProgress * (float)moduleweightage) / 100;
                        float result1 = (result * ((float)moduleweightage - obj.ModuleCredit));
                        course.CourseProgress = result1;
                        _context.Entry(course).State = EntityState.Modified;
                    }
                    
                    var response = _context.Modules.Remove(obj);
                    if (response != null)
                    {
                        turn = true;
                         _context.SaveChanges();
                    }

                }

            }
            catch (Exception)
            {

                throw;
            }
            return turn;
        }
        public bool AddNewAssignment(AssignmentVM assignmentVM)
        {
            bool turn = false;
            try
            {
                if (assignmentVM != null && assignmentVM.AssignmentGrade <=100)
                {
                    var module =  _context.Modules.Where(x => x.Id == assignmentVM.ModuleId).FirstOrDefault();
                    if (module != null)
                    {
                        var weightagecheck = _context.Assignments.Where(x => x.ModuleId == assignmentVM.ModuleId).Sum(x => x.AssignmentWeight);
                        if (weightagecheck+assignmentVM.AssignmentWeight <= 100)
                        {
                            var assignmentecheck =  _context.Assignments.Where(x => x.AssignmentName == assignmentVM.AssignmentName && x.InsertedBy == assignmentVM.InsertedBy && x.ModuleId==assignmentVM.ModuleId).FirstOrDefault();
                            if (assignmentecheck == null)
                            {
                                Assignment assignment = new Assignment();
                                assignment.AssignmentName = assignmentVM.AssignmentName;
                                assignment.AssignmentGrade = assignmentVM.AssignmentGrade;
                                assignment.AssignmentWeight = assignmentVM.AssignmentWeight;
                                assignment.ModuleId = assignmentVM.ModuleId;
                                assignment.isActive = true;
                                assignment.InsertedDate = DateTime.Now;
                                assignment.InsertedBy = assignmentVM.InsertedBy;
                                var response =  _context.Assignments.Add(assignment);
                                if (response != null)
                                {
                                    int assignmentweightage = (assignmentVM.AssignmentGrade * assignmentVM.AssignmentWeight)/100;
                                    module.ModuleProgress = module.ModuleProgress + assignmentweightage;
                                    _context.Entry(module).State = EntityState.Modified;
                                    var course = _context.Courses.Where(x=>x.InsertedBy == assignmentVM.InsertedBy).FirstOrDefault();
                                    var moduleweightage = _context.Modules.Where(x => x.InsertedBy == assignmentVM.InsertedBy).Sum(x => x.ModuleCredit);
                                    int result = (assignmentweightage * module.ModuleCredit) / moduleweightage;
                                    course.CourseProgress = course.CourseProgress + result;
                                    _context.Entry(course).State = EntityState.Modified;
                                     _context.SaveChanges();
                                    turn = true;
                                }
                            }
                        }
                        
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            return turn;
        }
        public AssignmentListVM GetAssignments(long moduleid)
        {
            AssignmentListVM assignmentListVM = new AssignmentListVM(); 
            try
            {
                var assignments =  _context.Assignments.Where(x => x.ModuleId == moduleid).Select(y => new AssignmentVM
                {
                    Id = y.Id,
                    AssignmentName = y.AssignmentName,
                    AssignmentGrade = y.AssignmentGrade,
                    AssignmentWeight = y.AssignmentWeight,
                    ModuleId = y.ModuleId,
                    isActive = y.isActive
                }).ToList();
                assignmentListVM.assignmentVMs = assignments;
                return assignmentListVM;
            }
            catch (System.Exception)
            {

                throw;
            }
        }
        public AssignmentVM GetAssignmentById(long id)
        {
            try
            {
                var assignment =  _context.Assignments.Where(x => x.Id == id).Select(y => new AssignmentVM
                {
                    Id = y.Id,
                    AssignmentName = y.AssignmentName,
                    AssignmentGrade = y.AssignmentGrade,
                    AssignmentWeight = y.AssignmentWeight,
                    ModuleId = y.ModuleId,
                    isActive = y.isActive
                }).FirstOrDefault();
                return assignment;
            }
            catch (System.Exception)
            {

                throw;
            }
        }
        public bool RemoveAssignment(long id,long moduleid, string user)
        {
            var turn = false;
            try
            {
                var obj =  _context.Assignments.Where(x => x.Id == id).FirstOrDefault();
                if (obj != null)
                {
                    var module = _context.Modules.Where(x => x.Id == moduleid).FirstOrDefault();
                    int res = (obj.AssignmentGrade * obj.AssignmentWeight) / 100;
                    module.ModuleProgress = module.ModuleProgress - res;
                    var course = _context.Courses.Where(x => x.InsertedBy == user).FirstOrDefault();
                    var moduleweightage = _context.Modules.Where(x => x.InsertedBy == user).Sum(x => x.ModuleCredit);
                    int a = (res * module.ModuleCredit) / moduleweightage;
                    course.CourseProgress = course.CourseProgress - a;
                    var response = _context.Assignments.Remove(obj);
                    if (response != null)
                    {
                        _context.Entry(module).State = EntityState.Modified;
                        _context.Entry(course).State = EntityState.Modified;
                        turn = true;
                         _context.SaveChanges();
                    }

                }

            }
            catch (Exception)
            {

                throw;
            }
            return turn;
        }
    }
}
