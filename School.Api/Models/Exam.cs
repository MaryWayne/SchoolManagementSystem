using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace School.Api.Models
{
    public class Exam
    {
        public int Id { get; set; }

        // e.g., Midterm, Final
        [Required]
        [MaxLength(150)]
        public string Name { get; set; } = string.Empty;

        public DateTime Date { get; set; }

        // Navigation
        public ICollection<Grade> Grades { get; set; } = new List<Grade>();

        // Many-to-many between Exam and Course
        public ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}
