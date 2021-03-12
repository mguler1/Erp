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
   public class DepoMap:EntityTypeConfiguration<Depo>
    {
        public DepoMap()
        {
            this.HasIndex(p => p.Id);
          //  this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.DepoKodu).HasMaxLength(12);
            this.Property(p => p.DepoAdi).HasMaxLength(30);
            this.Property(p => p.YetkiliKodu).HasMaxLength(12);
            this.Property(p => p.YetkiliAdi).HasMaxLength(50);
            this.Property(p => p.DepoIl).HasMaxLength(25);
            this.Property(p => p.DepoIlce).HasMaxLength(25);
            this.Property(p => p.Semt).HasMaxLength(25);
            this.Property(p => p.Adresi).HasMaxLength(100);
            this.Property(p => p.Telefon).HasMaxLength(20);
            this.Property(p => p.Aciklama).HasMaxLength(200);

            this.ToTable("Depolar");
            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.DepoKodu).HasColumnName("DepoKodu");
            this.Property(p => p.DepoAdi).HasColumnName("DepoAdi");
            this.Property(p => p.YetkiliKodu).HasColumnName("YetkiliKodu");
            this.Property(p => p.YetkiliAdi).HasColumnName("YetkiliAdi");
            this.Property(p => p.DepoIl).HasColumnName("DepoIl");
            this.Property(p => p.DepoIlce).HasColumnName("DepoIlce");
            this.Property(p => p.Semt).HasColumnName("Semt");
            this.Property(p => p.Adresi).HasColumnName("Adresi"); ;
            this.Property(p => p.Telefon).HasColumnName("Telefon");
            this.Property(p => p.Aciklama).HasColumnName("Aciklama");
        }
    }
}
