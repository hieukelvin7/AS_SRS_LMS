

namespace AS_SRS_LMS.Models
{
    public class DetailClass
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int  ClassId { get; set; }
        public Class Class { get; set; }
        public string Teacher { get; set; }
    }
}
