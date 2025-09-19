using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace School.Api.Models
{
    public class Course
    {
        public int Id { get; set; }

        // Course name (e.g., Mathematics)
        [Required]
        [MaxLength(150)]
        public string Name { get; set; } = string.Empty;

        // Optional description
        public string Description { get; set; } = string.Empty;

        // Credits (optional)
        public int Credits { get; set; }

        // Link to the teacher who primarily teaches the course
        public int TeacherId { get; set; }
        public Teacher? Teacher { get; set; }

        // Navigation
        public ICollection<Grade> Grades { get; set; } = new List<Grade>();

        // Many-to-many: courses can belong to multiple exams
        public ICollection<Exam> Exams { get; set; } = new List<Exam>();
    }
}
