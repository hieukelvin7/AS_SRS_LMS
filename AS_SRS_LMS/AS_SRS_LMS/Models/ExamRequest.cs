using System.ComponentModel.DataAnnotations;

namespace AS_SRS_LMS.Models
{
    public class ExamRequest
    {
        public string ExamName { get; set; } = string.Empty;
        [Required]
        public DateTime ExamDate { get; set; }
        [Required]
        public int TypeExamId { get; set; }
    }
}
