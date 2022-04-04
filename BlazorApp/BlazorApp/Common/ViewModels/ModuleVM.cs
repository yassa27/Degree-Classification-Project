using System;
using System.Collections.Generic;

namespace BlazorApp.Common.ViewModels
{
    public class ModuleListVM
    {
        public IEnumerable<ModuleVM> moduleVMs { get; set; }
    }
    public class ModuleVM
    {
        public long Id { get; set; }
        public string ModuleName { get; set; }
        public int ModuleCredit { get; set; }
        public int ModuleGrade { get; set; }
        public float ModuleProgress { get; set; }
        public long CourseId { get; set; }
        public bool isActive { get; set; }
        public string InsertedBy { get; set; }
        public DateTime InsertedDate { get; set; }
    }
}
