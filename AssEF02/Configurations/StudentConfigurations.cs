using AssEF02.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssEF02.Configurations
{
    internal class StudentConfigurations : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> student)
        {
            student.HasKey(b => b.Id);
            student.Property(b => b.FName)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(20);
            student.Property(b => b.LName)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(20);
            student.Property(b => b.Age)
                    .IsRequired();
        }
    }
}
