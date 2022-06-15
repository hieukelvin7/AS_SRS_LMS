using System.ComponentModel.DataAnnotations;

namespace AS_SRS_LMS.Models
{
    public class SubjectRequest
    {
        [Required]
        public string SubjectName { get; set; } = string.Empty;  
        [Required]
        public int NumberOfPeriod { get; set; }

    }
}
