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
    public class FisMap: EntityTypeConfiguration<Fis>
    {
        public FisMap()
        {
            this.HasIndex(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.FisKodu).HasMaxLength(12);
            this.Property(p => p.FisTuru).HasMaxLength(30);
            this.Property(p => p.CariKodu).HasMaxLength(12);
            this.Property(p => p.CariAdi).HasMaxLength(50);
            this.Property(p => p.FaturaUnvani).HasMaxLength(50);
            this.Property(p => p.CepTelefonu).HasMaxLength(20);
            this.Property(p => p.Il).HasMaxLength(20);
            this.Property(p => p.Ilce).HasMaxLength(20);
            this.Property(p => p.CariAdi).HasMaxLength(50);
            this.Property(p => p.Semt).HasMaxLength(20);
            this.Property(p => p.Adres).HasMaxLength(100);
            this.Property(p => p.VergiDairesi).HasMaxLength(30);
            this.Property(p => p.VergiNo).HasMaxLength(15);
            this.Property(p => p.BelgeNo).HasMaxLength(20);
            this.Property(p => p.PlasiyerKodu).HasMaxLength(12);
            this.Property(p => p.PlasiyerAdi).HasMaxLength(50);
            this.Property(p => p.IskontoOrani).HasPrecision(5,2);
            this.Property(p => p.IskontoTutari).HasPrecision(12, 2);
            this.Property(p => p.ToplamTutar).HasPrecision(12, 2);
            this.Property(p => p.Aciklama).HasMaxLength(200);

            this.ToTable("Fişler");
            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.FisKodu).HasColumnName("FisKodu");
            this.Property(p => p.FisTuru).HasColumnName("FisTuru");
            this.Property(p => p.CariKodu).HasColumnName("CariKodu");
            this.Property(p => p.CariAdi).HasColumnName("CariAdi");
            this.Property(p => p.BelgeNo).HasColumnName("BelgeNo");
            this.Property(p => p.Tarih).HasColumnName("Tarih");
            this.Property(p => p.PlasiyerKodu).HasColumnName("PlasiyerKodu");
            this.Property(p => p.PlasiyerAdi).HasColumnName("PlasiyerAdi");
            this.Property(p => p.IskontoOrani).HasColumnName("IskontoOrani");
            this.Property(p => p.IskontoTutari).HasColumnName("IskontoTutari");
            this.Property(p => p.ToplamTutar).HasColumnName("ToplamTutar");
            this.Property(p => p.Aciklama).HasColumnName("Aciklama");
        }
    }
}
