using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AS_SRS_LMS.Models
{
    public class ResultLearning
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ResultLearningId { get; set; }
        public float Score15Minutes { get; set; }
        public float ScoreOralTest { get; set; }
        public float ScoreCoefficient2 { get; set; }
        public float ScoreCoefficient3 { get; set; }
        public float ScoreAvg { get; set; }
        public float SumAvg { get; set; }
        public string ResultOfEvaluation { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

    }
}
