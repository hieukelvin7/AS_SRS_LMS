using System.ComponentModel.DataAnnotations;

namespace AS_SRS_LMS.Models
{
    public class QuestionRequest
    {
        [Required(ErrorMessage = "Tên câu hỏi không được để trống")]
        public string QuestionName { get; set; } = string.Empty;
        [Required(ErrorMessage = "Đáp Án A không được để trống")]
        public string AnswerA { get; set; } = string.Empty;
        [Required(ErrorMessage = "Đáp Án B không được để trống")]
        public string AnswerB { get; set; } = string.Empty;
        [Required(ErrorMessage = "Đáp Án C không được để trống")]
        public string AnswerC { get; set; } = string.Empty;
        [Required(ErrorMessage = "Đáp Án D không được để trống")]
        public string AnswerD { get; set; } = string.Empty;
        [Required(ErrorMessage = "Câu trả lời đúng không được để trống")]
        public string AnswerCorrect { get; set; } = string.Empty;
    }
}
