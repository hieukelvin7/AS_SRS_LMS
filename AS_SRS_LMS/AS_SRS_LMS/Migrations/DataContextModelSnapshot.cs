﻿// <auto-generated />
using System;
using AS_SRS_LMS.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AS_SRS_LMS.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AS_SRS_LMS.Models.Class", b =>
                {
                    b.Property<int>("ClassId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClassId"), 1L, 1);

                    b.Property<string>("ClassName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int?>("SubjectId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ClassId");

                    b.HasIndex("SubjectId");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("AS_SRS_LMS.Models.Document", b =>
                {
                    b.Property<string>("DocumentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.HasKey("DocumentId");

                    b.HasIndex("SubjectId");

                    b.ToTable("Documents");
                });

            modelBuilder.Entity("AS_SRS_LMS.Models.Exam", b =>
                {
                    b.Property<string>("ExamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("DVT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ExamDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ExamName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.Property<float>("Time")
                        .HasColumnType("real");

                    b.Property<int>("TypeExamId")
                        .HasColumnType("int");

                    b.HasKey("ExamId");

                    b.HasIndex("SubjectId")
                        .IsUnique();

                    b.HasIndex("TypeExamId");

                    b.ToTable("Exams");
                });

            modelBuilder.Entity("AS_SRS_LMS.Models.Question", b =>
                {
                    b.Property<int>("QuestionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("QuestionId"), 1L, 1);

                    b.Property<string>("AnswerA")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AnswerB")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AnswerC")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AnswerCorrect")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AnswerD")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QuestionName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.HasKey("QuestionId");

                    b.HasIndex("SubjectId");

                    b.ToTable("Questions");
                });

            modelBuilder.Entity("AS_SRS_LMS.Models.Result", b =>
                {
                    b.Property<int>("ResultId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ResultId"), 1L, 1);

                    b.Property<DateTime>("ExamDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ExamId")
                        .HasColumnType("int");

                    b.Property<string>("ExamId1")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<float>("Score")
                        .HasColumnType("real");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ResultId");

                    b.HasIndex("ExamId1");

                    b.HasIndex("UserId");

                    b.ToTable("Results");
                });

            modelBuilder.Entity("AS_SRS_LMS.Models.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RoleId"), 1L, 1);

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RoleId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("AS_SRS_LMS.Models.Schedule", b =>
                {
                    b.Property<int>("ScheduleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ScheduleId"), 1L, 1);

                    b.Property<int>("DayOfWeek")
                        .HasColumnType("int");

                    b.Property<int>("SubjectId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.HasKey("ScheduleId");

                    b.HasIndex("SubjectId");

                    b.ToTable("Schedules");
                });

            modelBuilder.Entity("AS_SRS_LMS.Models.Subject", b =>
                {
                    b.Property<int>("SubjectId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubjectId"), 1L, 1);

                    b.Property<int>("ExamId")
                        .HasColumnType("int");

                    b.Property<int>("NumberOfPeriod")
                        .HasColumnType("int");

                    b.Property<string>("SubjectName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubjectId");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("AS_SRS_LMS.Models.TypeExam", b =>
                {
                    b.Property<int>("TypeExamId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TypeExamId"), 1L, 1);

                    b.Property<int>("TypeName")
                        .HasColumnType("int");

                    b.HasKey("TypeExamId");

                    b.ToTable("TypeExams");
                });

            modelBuilder.Entity("AS_SRS_LMS.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ClassId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsEmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<int>("LastName")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.HasIndex("ClassId");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("AS_SRS_LMS.Models.Class", b =>
                {
                    b.HasOne("AS_SRS_LMS.Models.Subject", null)
                        .WithMany("Class")
                        .HasForeignKey("SubjectId");
                });

            modelBuilder.Entity("AS_SRS_LMS.Models.Document", b =>
                {
                    b.HasOne("AS_SRS_LMS.Models.Subject", "Subject")
                        .WithMany("Documents")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("AS_SRS_LMS.Models.Exam", b =>
                {
                    b.HasOne("AS_SRS_LMS.Models.Subject", "Subject")
                        .WithOne("Exam")
                        .HasForeignKey("AS_SRS_LMS.Models.Exam", "SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AS_SRS_LMS.Models.TypeExam", "TypeExam")
                        .WithMany("Exam")
                        .HasForeignKey("TypeExamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Subject");

                    b.Navigation("TypeExam");
                });

            modelBuilder.Entity("AS_SRS_LMS.Models.Question", b =>
                {
                    b.HasOne("AS_SRS_LMS.Models.Subject", "Subject")
                        .WithMany("Questions")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("AS_SRS_LMS.Models.Result", b =>
                {
                    b.HasOne("AS_SRS_LMS.Models.Exam", "Exam")
                        .WithMany()
                        .HasForeignKey("ExamId1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AS_SRS_LMS.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exam");

                    b.Navigation("User");
                });

            modelBuilder.Entity("AS_SRS_LMS.Models.Schedule", b =>
                {
                    b.HasOne("AS_SRS_LMS.Models.Subject", "Subject")
                        .WithMany("Schedules")
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("AS_SRS_LMS.Models.User", b =>
                {
                    b.HasOne("AS_SRS_LMS.Models.Class", "Class")
                        .WithMany("Users")
                        .HasForeignKey("ClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AS_SRS_LMS.Models.Role", "Role")
                        .WithMany("User")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Class");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("AS_SRS_LMS.Models.Class", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("AS_SRS_LMS.Models.Role", b =>
                {
                    b.Navigation("User");
                });

            modelBuilder.Entity("AS_SRS_LMS.Models.Subject", b =>
                {
                    b.Navigation("Class");

                    b.Navigation("Documents");

                    b.Navigation("Exam")
                        .IsRequired();

                    b.Navigation("Questions");

                    b.Navigation("Schedules");
                });

            modelBuilder.Entity("AS_SRS_LMS.Models.TypeExam", b =>
                {
                    b.Navigation("Exam");
                });
#pragma warning restore 612, 618
        }
    }
}
