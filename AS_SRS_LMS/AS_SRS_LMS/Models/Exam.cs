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

        public int TypeExamId { get; set; }
        public TypeExam TypeExam { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
        public ICollection<ContentExam> ContentExams { get; set; }
        public List<Result> Results { get; set; }
    }
}
