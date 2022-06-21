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
    public class ActivityImageMap : BaseMap<ActivityImage>
    {
        public override void Configure(EntityTypeBuilder<ActivityImage> builder)
        {
            base.Configure(builder);
            builder.ToTable("ActivityImages");
            builder.Property(x => x.Path).IsRequired();
        }
    }
}
