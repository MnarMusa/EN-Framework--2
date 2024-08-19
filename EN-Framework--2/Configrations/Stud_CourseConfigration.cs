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
    internal class Stud_CourseConfigration : IEntityTypeConfiguration<Stud_Course>
    {
        public void Configure(EntityTypeBuilder<Stud_Course> sc)
        {
            sc.Property(sc => sc.id)
               .UseIdentityColumn(1, 1);
        }
    }
}
