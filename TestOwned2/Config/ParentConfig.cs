using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestOwned2.Entities;

namespace TestOwned2.Config
{
    public class ParentConfig : IEntityTypeConfiguration<Parent>
    {
        public void Configure(EntityTypeBuilder<Parent> builder)
        {
            builder.ToTable("Parents").HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedNever();

            builder.OwnsMany(p => p.Values);
        }
    }
}
