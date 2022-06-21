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
    public class TicketMap : BaseMap<Ticket>
    {
        public override void Configure(EntityTypeBuilder<Ticket> builder)
        {
            base.Configure(builder);
            builder.ToTable("Tickets");
            builder.Property(x => x.Title).IsRequired();
            builder.Property(x => x.Fee).IsRequired().HasColumnName("REAL");
        }
    }
}
