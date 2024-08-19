using EN_Framework__2.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EN_Framework__2.Configrations
{
    internal class DepartmentConfigration : IEntityTypeConfiguration<Department>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Department> d)
        {
            d.Property(d => d.Id)
               .UseIdentityColumn(10, 10);

            d.Property(d => d.Name)
           .IsRequired(true)
           .HasColumnType("varchar");

            d.Property(d => d.Hiring_Date)
            .HasComputedColumnSql("GETDATE()");
        }
    }
}
