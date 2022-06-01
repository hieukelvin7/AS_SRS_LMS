using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AS_SRS_LMS.Models
{
    public class Exam
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ExamId { get; set; }
        public string ExamName { get; set; }
        public string ContentExam { get; set; }
        public DateTime ExamDate { get; set; }
        public float Time { get; set; }
        public string DVT { get; set; }
        public bool Status { get; set; }
        public string ExamWork { get; set; }
        public int UserId { get; set; }
        public User Users { get; set; }
        
        public int ResultId { get; set; }
        public Result Results { get; set; }
        public int TestScheduleId { get; set; }
        public TestSchedule TestSchedule { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }

    }
}
