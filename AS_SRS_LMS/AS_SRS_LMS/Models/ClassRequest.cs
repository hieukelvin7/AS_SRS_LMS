using System.ComponentModel.DataAnnotations;

namespace AS_SRS_LMS.Models
{
    public class ClassRequest
    {
        [Required]
        public string ClassName { get; set; } = string.Empty;
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        [Required]
        public int UserId { get; set; }
        
        
    }
}
