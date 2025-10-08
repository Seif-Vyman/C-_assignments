using AssEF02.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AssEF02.Contexts
{
    internal class ITIDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = ITI; Trusted_Connection = True; TrustServerCertificate = True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            // student Department Relation
            modelBuilder.Entity<Student>()
                .HasOne(S => S.Department)
                .WithMany(D => D.Students)
                .HasForeignKey(S => S.DeptId)
                .OnDelete(DeleteBehavior.Restrict);

            // topic course relationship
            modelBuilder.Entity<Course>()
                .HasOne(C => C.Topic)
                .WithMany(T => T.Courses)
                .HasForeignKey(C => C.TopicId)
                .OnDelete(DeleteBehavior.Restrict);
            
            // instructor department relationship
            modelBuilder.Entity<Instructor>()
                .HasOne(I => I.Department)
                .WithMany(D => D.Instructors)
                .HasForeignKey(I => I.DeptId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<CourseInstructor>().HasKey(CI => new {CI.CourseId,CI.InstId});
            modelBuilder.Entity<CourseInstructor>()
                .HasOne(CI =>  CI.Course)
                .WithMany(C => C.CourseInstructors)
                .HasForeignKey(CI => CI.CourseId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<CourseInstructor>()
                .HasOne(CI => CI.Instructor)
                .WithMany(I => I.CourseInstructors)
                .HasForeignKey(CI => CI.InstId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Department>()
                .HasOne(D => D.ManagedInstructor)
                .WithOne(MI => MI.DepartmentManaged)
                .HasForeignKey<Department>(D => D.ManagedInstId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<StudentCourse>().HasKey(SC => new { SC.StudentId, SC.CourseId });
            modelBuilder.Entity<StudentCourse>()
                .HasOne(SC => SC.Student)
                .WithMany(S => S.Courses)
                .HasForeignKey(SC => SC.StudentId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<StudentCourse>()
                .HasOne(SC => SC.Course)
                .WithMany(C => C.Students)
                .HasForeignKey(SC => SC.CourseId)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);
        }
    }
}
