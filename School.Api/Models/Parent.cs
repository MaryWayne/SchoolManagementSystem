using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace School.Api.Models
{
    public class Parent
    {
        public int Id { get; set; }

        // Parent full name
        [Required]
        [MaxLength(200)]
        public string FullName { get; set; } = string.Empty;

        // Unique email for contact/login
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        // Phone number
        [Phone]
        public string PhoneNumber { get; set; } = string.Empty;

        // Many-to-many link to Student via StudentParent
        public ICollection<StudentParent> StudentParents { get; set; } = new List<StudentParent>();
    }
}
