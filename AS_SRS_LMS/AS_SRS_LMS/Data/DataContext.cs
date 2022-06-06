using AS_SRS_LMS.Models;
using Microsoft.EntityFrameworkCore;

namespace AS_SRS_LMS.Data
{
    public class DataContext :DbContext
    {
        public DataContext(DbContextOptions options): base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<TypeExam> TypeExams { get; set; }
        
        public DbSet<Result> Results { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Document> Documents { get; set; }
    }
}
