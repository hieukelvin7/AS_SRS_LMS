using System.ComponentModel.DataAnnotations;

namespace AS_SRS_LMS.Models
{
    public class ClassRequest
    {
        [Required]
        public string ClassName { get; set; } = string.Empty;

        
    }
}
