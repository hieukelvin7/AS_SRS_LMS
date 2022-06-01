using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AS_SRS_LMS.Models
{
    public class Class
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClassId { get; set; }
        public string ClassName { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
        public bool Status { get; set; }
        
        public int UserId { get; set; }
        public List<User> Users { get; set; }

    }
}
