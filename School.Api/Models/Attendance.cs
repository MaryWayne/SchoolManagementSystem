using System;
using System.ComponentModel.DataAnnotations;
using School.Api.Enums;

namespace School.Api.Models
{
    public class Attendance
    {
        public int Id { get; set; }

        // Date of the attendance event
        public DateTime Date { get; set; } = DateTime.UtcNow;

        // Attendance status (Present/Absent/Late)
        public AttendanceStatus Status { get; set; } = AttendanceStatus.Present;

        // Link to student
        public int StudentId { get; set; }
        public Student? Student { get; set; }
    }
}
