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
    public class ActivityMap : BaseMap<Activity>
    {
        public override void Configure(EntityTypeBuilder<Activity> builder)
        {
            base.Configure(builder);
            builder.ToTable("Activities");
            builder.Property(x => x.Title).IsRequired();
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.City).IsRequired();
            builder.Property(x => x.PlaceTitle).IsRequired();
            builder.Property(x => x.MapLocation).IsRequired();
            builder.Property(x => x.Address).IsRequired();
            builder.Property(x => x.StartDate).IsRequired();
            builder.Property(x => x.EndDate).IsRequired(false);
            builder.Property(x => x.PosterPath).IsRequired(false);

            // relations
            builder.HasOne(x => x.Category).WithMany(x => x.Activities).HasForeignKey(x => x.CategoryId);
            builder.HasMany(x => x.Tickets).WithOne(x => x.Activity).HasForeignKey(x => x.ActivityId);
            builder.HasMany(x => x.Images).WithOne(x => x.Activity).HasForeignKey(x => x.ActivityId);
        }
    }
}
