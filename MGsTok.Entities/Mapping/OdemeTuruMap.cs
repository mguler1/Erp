using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using MGsTok.Entities.Tables;

namespace MGsTok.Entities.Mapping
{
    class OdemeTuruMap:EntityTypeConfiguration<OdemeTuru>
    {
        public OdemeTuruMap()
        {
            this.HasIndex(p => p.Id);
           this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.OdemeTuruKodu).HasMaxLength(12);
            this.Property(p => p.OdemeTuruAdi).HasMaxLength(30);
            this.Property(p => p.Aciklama).HasMaxLength(200);

            this.ToTable("OdemeTurleri");
            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.OdemeTuruKodu).HasColumnName("OdemeTuruKodu");
            this.Property(p => p.OdemeTuruAdi).HasColumnName("OdemeTuruAdi");
            this.Property(p => p.Aciklama).HasColumnName("Aciklama");
        }
    }
}
