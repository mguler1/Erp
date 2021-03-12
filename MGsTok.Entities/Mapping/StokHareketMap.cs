﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using MGsTok.Entities.Tables;


namespace MGsTok.Entities.Mapping
{
    public class StokHareketMap : EntityTypeConfiguration<StokHareket>
    {
        public StokHareketMap()
        {
            this.HasIndex(p => p.Id);
            this.Property(p => p.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.Property(p => p.Fiskodu).HasMaxLength(12);
            this.Property(p => p.Hareket).HasMaxLength(12);
            this.Property(p => p.StokKodu).HasMaxLength(12);
            this.Property(p => p.StokAdi).HasMaxLength(50);
            this.Property(p => p.BarkodTuru).HasMaxLength(15);
            this.Property(p => p.Barkod).HasMaxLength(20);
            this.Property(p => p.Birimi).HasMaxLength(15);
            this.Property(p => p.BirimFiyati).HasPrecision(12, 3);
            this.Property(p => p.IndirimOrani).HasPrecision(5, 2);
            this.Property(p => p.DepoKodu).HasMaxLength(12);
            this.Property(p => p.DepoAdi).HasMaxLength(30);
            this.Property(p => p.SeriNo).HasMaxLength(200);
            this.Property(p => p.Aciklama).HasMaxLength(200);

            this.ToTable("StokHareketleri");
            this.Property(p => p.Id).HasColumnName("Id");
            this.Property(p => p.Fiskodu).HasColumnName("Fiskodu");
            this.Property(p => p.Hareket).HasColumnName("Hareket");
            this.Property(p => p.StokKodu).HasColumnName("StokKodu");
            this.Property(p => p.StokAdi).HasColumnName("StokAdi");
            this.Property(p => p.BarkodTuru).HasColumnName("BarkodTuru");
            this.Property(p => p.Barkod).HasColumnName("Barkod");
            this.Property(p => p.Birimi).HasColumnName("Birimi");
            this.Property(p => p.Kdv).HasColumnName("Kdv");
            this.Property(p => p.BirimFiyati).HasColumnName("BirimFiyati");
            this.Property(p => p.IndirimOrani).HasColumnName("IndirimOrani");
           
            this.Property(p => p.DepoKodu).HasColumnName("DepoKodu");
            this.Property(p => p.DepoAdi).HasColumnName("DepoAdi");
            this.Property(p => p.SeriNo).HasColumnName("SeriNo");
            this.Property(p => p.Tarih).HasColumnName("Tarih");
            this.Property(p => p.Aciklama).HasColumnName("Aciklama");
        }
    }
}
