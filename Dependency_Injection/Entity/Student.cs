using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace Dependency_Injection.Entity
{
    public class Student

    {
        [Required]
        public int Id { get; set; }
        [Required(ErrorMessage ="Name must be Reuired")]
        [StringLength(10)]
        public string? Name { get; set; }


        [Required(ErrorMessage = "Email is Invalid")]
        [MinLength(6)]
        public string? Email { get; set; }

        public  List<Enrollment> Enrollments{  get; set; } = new List<Enrollment>();
    }
}
