using System.ComponentModel.DataAnnotations;

namespace AS_SRS_LMS.Models
{
    public class ScheduleRequest
    {
        [Required]
        public int SubjectId { get; set; }
        [Required]
        public int ClassId { get; set; }
        [Required]
        public int LearningScheduleId { get; set; }
    }
}
