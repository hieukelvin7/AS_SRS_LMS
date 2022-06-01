using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AS_SRS_LMS.Models
{
    public class Course
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CourseId { get; set; }
        public string Theme { get; set; }
        public DateTime StarDate { get; set; }
        public DateTime EndDate { get; set; }
        public float Time { get; set; }
        public string DVT { get; set; }

        public bool Status { get; set; }
        
        public List<DetailCourse> DetailCourses { get; set; }
        
        public List<DetailSubject> DetailSubjects { get; set; }
    }
}
