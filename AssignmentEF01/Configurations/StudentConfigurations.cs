using AssignmentEF01.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentEF01.Configurations
{
    internal class StudentConfigurations : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasKey(b =>  b.Id);
            builder.Property(b => b.FName)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(20);
            builder.Property(b => b.LName)
                .IsRequired()
                .HasColumnType("varchar")
                .HasMaxLength(20);
            builder.Property(b => b.Age)
                    .IsRequired();


        }
    }
}
