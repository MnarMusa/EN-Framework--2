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
    internal class TopicConfigration : IEntityTypeConfiguration<Topic>
    {
        public void Configure(EntityTypeBuilder<Topic> t)
        {
            t.Property(t => t.Id)
               .UseIdentityColumn(1, 1);

            t.Property(t => t.Name)
           .IsRequired(true)
           .HasColumnType("varchar");
        }
    }
}
