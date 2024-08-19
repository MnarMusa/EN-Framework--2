using EN_Framework__2.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EN_Framework__2.Configrations
{
    internal class CourseConfigration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> c)
        {
            c.Property(c => c.C_Id)
               .UseIdentityColumn(10, 10);

            c.Property(c => c.Name)
           .IsRequired(true)
           .HasColumnType("varchar");

            c.Property(c => c.Description)
            .HasColumnName("Description");
        }
    }
}
