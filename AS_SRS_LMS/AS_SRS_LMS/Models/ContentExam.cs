using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AS_SRS_LMS.Models
{
    public class ContentExam
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ContentId { get; set; }
        public float Score { get; set; }
        public int NumberCorrect { get; set; }
        public int ExamId { get; set; }
        public Exam Exam { get; set; }
        public List<Question> Questions { get; set; }
    }
}
