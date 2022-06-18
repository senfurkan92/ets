using DOMAIN.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Map
{
    public class CategoryMap : BaseMap<Category>
    {
        public override void Configure(EntityTypeBuilder<Category> builder)
        {
            base.Configure(builder);
            builder.ToTable("Categories");
            builder.Property(x => x.Name);
        }
    }
}
