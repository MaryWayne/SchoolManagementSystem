using System.Collections.Generic;

namespace School.Api.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public int Age { get; set; }

        // Relations
        public List<Grade> Grades { get; set; } = new();
        public List<Attendance> Attendances { get; set; } = new();

        // 👇 Add this navigation property for StudentParent
        public List<StudentParent> Parents { get; set; } = new();
    }
}
