using System.ComponentModel.DataAnnotations;

namespace AS_SRS_LMS.Models
{
    public class LearningScheduleRequest
    {
        [Required]
        public string LearningScheduleName { get; set; }
        [Required]
        public DayOfWeek DayOfWeek { get; set; }
        [Required]
        public string StartDate { get; set; }
        [Required]
        public string EndDate { get; set; }
    }
}
