using System;

namespace BlazorApp.Data
{
    public class Module
    {
        public long Id { get; set; }
        public string ModuleName { get; set; }
        public int ModuleCredit { get; set; }
        public int ModuleGrade { get; set; }
        public long CourseId { get; set; }
        public float ModuleProgress { get; set; }
        public bool isActive { get; set; }
        public string InsertedBy { get; set; }
        public DateTime InsertedDate { get; set; }
    }
}
