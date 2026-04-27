using System.Collections.Generic;

using System.ComponentModel.DataAnnotations;


namespace Dependency_Injection.Entity
{
    public class Course
    {
        public int Id { get; set; }
        [Required]
        public string? Title { get; set; }
        public int Credits { get; set; }

        public List<Enrollment> Enrollments { get; set; } = new List<Enrollment>();


       
    }
}
