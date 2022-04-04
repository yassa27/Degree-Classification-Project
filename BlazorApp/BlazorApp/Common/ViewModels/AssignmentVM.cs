using System;
using System.Collections.Generic;

namespace BlazorApp.Common.ViewModels
{
    public class AssignmentListVM
    {
        public IEnumerable<AssignmentVM> assignmentVMs { get; set; }
    }
    public class AssignmentVM
    {
        public long Id { get; set; }
        public string AssignmentName { get; set; }
        public int AssignmentWeight { get; set; }
        public int AssignmentGrade { get; set; }
        public long ModuleId { get; set; }
        public bool isActive { get; set; }
        public string InsertedBy { get; set; }
        public DateTime InsertedDate { get; set; }
    }
}
