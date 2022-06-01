using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AS_SRS_LMS.Models
{
    public class DetailSubject
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DetailSubjectId { get; set; }

        public int SubjectId { get; set; }
        public Subject Subjects { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public Schedule Schedule { get; set; }
    }
}
