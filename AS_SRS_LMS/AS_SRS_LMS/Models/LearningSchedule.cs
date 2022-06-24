using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AS_SRS_LMS.Models
{
    public class LearningSchedule
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LearningScheduleId { get; set; }
        public string LearningScheduleName { get; set; }
        public DayOfWeek DayOfWeek { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        
        public List<Schedule> Schedules { get; set; }
    }
}
