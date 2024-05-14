using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Configurations
{
    internal class Marka_CFG : IEntityTypeConfiguration<Marka>
    {
        public void Configure(EntityTypeBuilder<Marka> builder)
        {
            builder.ToTable("MARKALAR");
            builder.Property(x => x.MarkaID).UseIdentityColumn(10, 1).HasColumnName("MARKA_ID");

            builder.Property(x => x.MarkaAdi)
                .HasColumnName("MARKA_ADI")
                .HasMaxLength(50)
                .IsRequired(true);

            builder.HasData(
                new Marka { MarkaID=1, MarkaAdi="Ferrari" }, 
                new Marka { MarkaID=2, MarkaAdi="Volswagen" }, 
                new Marka { MarkaID=3, MarkaAdi="TOFAS" }
                );

        }
    }
}
