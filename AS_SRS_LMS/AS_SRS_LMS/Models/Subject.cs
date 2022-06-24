using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AS_SRS_LMS.Models
{
    public class Subject
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public int NumberOfPeriod { get; set; }      

        public ICollection<Schedule> Schedules { get; set; }
        public ICollection<Exam> Exams { get; set; }
        public ICollection<Document> Documents { get; set; }
    }
}
