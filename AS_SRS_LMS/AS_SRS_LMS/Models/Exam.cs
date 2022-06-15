using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AS_SRS_LMS.Models
{
    public class Exam
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ExamId { get; set; }
        public string ExamName { get; set; }
        public DateTime ExamDate { get; set; }

        public bool Status { get; set; }

        public int SubjectId { get; set; }
        public Subject Subject { get; set; }

        public int TypeExamId { get; set; }
        public TypeExam TypeExam { get; set; }
        public ContentExam ContentExam { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
