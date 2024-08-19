using EN_Framework__2.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EN_Framework__2.Configrations
{
    internal class StudentConfigration : IEntityTypeConfiguration<Student>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Student> S)
        {
            S.Property(S => S.Address)
                .HasDefaultValue("Cairo");

            S.Property(S => S.FName)
           .IsRequired(true)
           .HasColumnType("varchar");
        }
    }
}
