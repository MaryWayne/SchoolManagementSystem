namespace School.Api.Models
{
    public class StudentParent
    {
        public int Id { get; set; }

        public string FullName { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        // Foreign key
        public int StudentId { get; set; }

        // Navigation
        public Student Student { get; set; } = null!;
    }
}
