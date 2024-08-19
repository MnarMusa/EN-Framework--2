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
    internal class InstructorConfigration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> i)
        {
            i.Property(i => i.Id)
                .UseIdentityColumn(1, 1);

            i.Property(i => i.Name)
           .IsRequired(true)
           .HasColumnType("varchar");
        }
    }
}
