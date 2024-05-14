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
    internal class Model_CFG : IEntityTypeConfiguration<Model>
    {
        public void Configure(EntityTypeBuilder<Model> builder)
        {
            //ID yada ModelID den farklı olan bir sutunu PK
            // yapmak istiyorsak
            //builder.HasKey(x => x.ModelID);
            // Ya da DataAnnotation => [Key]

            builder.ToTable("MODELLER");
            builder.Property(x => x.ModelID).UseIdentityColumn(10, 1).HasColumnName("MODEL_ID");

            builder.Property(x => x.ModelAdi)
                .HasColumnName("MODEL_ADI")
                .HasMaxLength(100)
                .IsRequired(true);

            builder.Property(x => x.MarkaID).HasColumnName("MARKA_ID");

            builder.Property(x => x.ModelYili).HasColumnName("MODEL_YILI");

            builder.HasData(
                new Model { ModelID=1, MarkaID = 1, ModelAdi= "Enzo", ModelYili=2010 },
                new Model { ModelID=2, MarkaID = 1, ModelAdi= "California", ModelYili=2016 },
                new Model { ModelID=3, MarkaID = 2, ModelAdi= "Golf", ModelYili=2010 },
                new Model { ModelID=4, MarkaID = 2, ModelAdi= "Tiguan", ModelYili=2018 },
                new Model { ModelID=5, MarkaID = 3, ModelAdi= "Kartal", ModelYili=2000 },
                new Model { ModelID=6, MarkaID = 3, ModelAdi= "Dogan", ModelYili=1999 },
                new Model { ModelID=7, MarkaID = 3, ModelAdi= "Serce", ModelYili=1985 }
             
                );
        }
    }
}
