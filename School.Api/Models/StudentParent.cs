﻿namespace School.Api.Models
{
    // Join table for Student <-> Parent (many-to-many)
    public class StudentParent
    {
        public int StudentId { get; set; }
        public Student Student { get; set; } = null!;

        public int ParentId { get; set; }
        public Parent Parent { get; set; } = null!;
    }
}
