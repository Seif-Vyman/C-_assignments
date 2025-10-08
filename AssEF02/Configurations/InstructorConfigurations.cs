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
    internal class InstructorConfigurations : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> instructor)
        {
            instructor.HasKey(I => I.Id);
            instructor.Property(I => I.Name)
            .IsRequired()
            .HasColumnType("varchar")
            .HasMaxLength(50);

            instructor.Property(I => I.Salary)
            .HasColumnType("decimal(18, 2)");

            instructor.Property(I => I.Bouns)
            .HasColumnType("decimal(18, 2)");

            instructor.Property(I => I.Address)
            .HasColumnType("varchar")
            .HasMaxLength(100);
        }
    }
}
