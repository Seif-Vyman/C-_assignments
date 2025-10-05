using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssignmentEF01.Configurations;
using AssignmentEF01.Entities;
using Microsoft.EntityFrameworkCore;

namespace AssignmentEF01.Contexts
{
    internal class ITIDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = ITI; Trusted_Connection = True; TrustServerCertificate = True");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Fluent APIs
            modelBuilder.Entity<Instructor>(I =>
            {
                I.HasKey(I => I.Id);
                I.Property(I => I.Name)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(50);

                I.Property(I => I.Salary)
                .HasColumnType("decimal(18, 2)");

                I.Property(I => I.Bouns)
                .HasColumnType("decimal(18, 2)");

                I.Property(I => I.Address)
                .HasColumnType("varchar")
                .HasMaxLength(100);

            });

            modelBuilder.ApplyConfiguration(new StudentConfigurations());

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Course_Inst> Course_Insts { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Stud_Course> Stud_Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Topic> Topics { get; set; }




    }
}

