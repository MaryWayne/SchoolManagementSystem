using System;
using System.ComponentModel.DataAnnotations;

namespace School.Api.Models
{
    public class Grade
    {
        public int Id { get; set; }

        // Score (0-100)
        [Range(0, 100)]
        public int Score { get; set; }

        // Date when the grade was awarded
        public DateTime DateAwarded { get; set; } = DateTime.UtcNow;

        // Foreign keys & navigation
        public int StudentId { get; set; }
        public Student? Student { get; set; }

        public int CourseId { get; set; }
        public Course? Course { get; set; }

        // Optional exam association
        public int? ExamId { get; set; }
        public Exam? Exam { get; set; }
    }
}
