using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AS_SRS_LMS.Models
{
    public class Schedule
    {
        
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ScheduleId { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }

        public int ClassId { get; set; }
        public Class Class { get; set; }

       public int LearningScheduleId { get; set; }
        public LearningSchedule LearningSchedule { get; set; }
    }
}
