using System;

namespace BlazorApp.Data
{
    public class Course
    {
        public long Id { get; set; }
        public string CourseName { get; set; }
        public int CourseYear { get; set; }
        public float CourseProgress { get; set; }
        public bool isActive { get; set; }
        public string InsertedBy { get; set; }
        public DateTime InsertedDate { get; set; }
    }
}
