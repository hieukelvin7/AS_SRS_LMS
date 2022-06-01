using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AS_SRS_LMS.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public int LastName { get; set; }
        public string Image { get; set; }
        public string Address { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsEmailConfirmed { get; set; }
        public string Role { get; set; }

        public List<DetailCourse> DetailCourses { get; set; }
        
        public List<Exam> Exam { get; set; }
        public int ClassId { get; set; }
        public Class Class { get; set; }


    }
}
