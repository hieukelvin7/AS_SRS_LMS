using AS_SRS_LMS.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AS_SRS_LMS.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Question> Questions { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<TypeExam> TypeExams { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<DetailClass> DetailClass { get; set; }
        public DbSet<ContentExam> ContentExams { get; set; }
        public DbSet<Semester> Semesters { get; set; }
        public DbSet<ResultLearning> ResultLearnings { get; set; }
        public DbSet<LearningSchedule> LearningSchedules { get; set; }
        public DbSet<Result> Results { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Exam>()
            //    .HasOne(b => b.ContentExam)
            //    .WithOne(i => i.Exam)
            //    .HasForeignKey<ContentExam>(b => b.ExamId);

            modelBuilder.Entity<User>()
               .HasOne(b => b.ResultLearning)
               .WithOne(i => i.User)
               .HasForeignKey<ResultLearning>(b => b.UserId);
            
            modelBuilder.Entity<DetailClass>()
                .HasKey(bc => new { bc.UserId, bc.ClassId });
            modelBuilder.Entity<DetailClass>()
                .HasOne(bc => bc.User)
                .WithMany(b => b.DetailClasses)
                .HasForeignKey(bc => bc.UserId);
            modelBuilder.Entity<DetailClass>()
                .HasOne(bc => bc.Class)
                .WithMany(c => c.DetailClasses)
                .HasForeignKey(bc => bc.ClassId);

          
        }
    }

}
