using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace School.Api.Models
{
    public class Student
    {
        public int Id { get; set; }

        // Student full name
        [Required]
        [MaxLength(200)]
        public string FullName { get; set; } = string.Empty;

        // Unique email for login/contact
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        // Optional age
        public int Age { get; set; }

        // Navigation properties
        // One student can have many grades
        public ICollection<Grade> Grades { get; set; } = new List<Grade>();

        // One student can have many attendance records
        public ICollection<Attendance> Attendances { get; set; } = new List<Attendance>();

        // Many-to-many link to Parent via StudentParent
        public ICollection<StudentParent> StudentParents { get; set; } = new List<StudentParent>();
    }
}
