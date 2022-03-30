using System;

namespace BlazorApp.Common.ViewModels
{
    public class CourseVM
    {
        public long Id { get; set; }
        public string CourseName { get; set; }
        public int CourseYear { get; set; }
        public float CourseProgress { get; set; }
        public string DegreeClassification { get; set; }
        public bool isActive { get; set; }
        public string InsertedBy { get; set; }
        public DateTime InsertedDate { get; set; }
    }
}
