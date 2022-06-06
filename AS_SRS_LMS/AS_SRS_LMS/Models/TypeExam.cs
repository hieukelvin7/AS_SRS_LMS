using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AS_SRS_LMS.Models
{
    public class TypeExam
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TypeExamId { get; set; } 
        public int TypeName { get; set; }
        public List<Exam> Exam { get; set; }
    }
}
