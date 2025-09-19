using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace School.Api.Models
{
    public class Teacher
    {
        public int Id { get; set; }

        // Teacher full name
        [Required]
        [MaxLength(200)]
        public string FullName { get; set; } = string.Empty;

        // Unique email for contact/login
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        // Optional phone number
        [Phone]
        public string PhoneNumber { get; set; } = string.Empty;

        // Navigation - courses the teacher teaches
        public ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}
