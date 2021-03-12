﻿namespace MGsTok.Entities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cariler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Durumu = c.Boolean(nullable: false),
                        CariTuru = c.String(maxLength: 15),
                        CariKodu = c.String(maxLength: 12),
                        CariAdi = c.String(maxLength: 50),
                        YetkiliKisi = c.String(maxLength: 50),
                        FaturaUnvani = c.String(maxLength: 50),
                        CepTelefonu = c.String(maxLength: 15),
                        Telefon = c.String(maxLength: 15),
                        Fax = c.String(maxLength: 15),
                        Email = c.String(maxLength: 50),
                        WebAdresi = c.String(maxLength: 50),
                        Il = c.String(maxLength: 25),
                        Ilce = c.String(maxLength: 25),
                        Semt = c.String(maxLength: 25),
                        Adres = c.String(maxLength: 100),
                        CariGrubu = c.String(maxLength: 30),
                        CariAltGrubu = c.String(maxLength: 30),
                        OzelKod1 = c.String(maxLength: 30),
                        OzelKod2 = c.String(maxLength: 30),
                        OzelKod3 = c.String(maxLength: 30),
                        OzelKod4 = c.String(maxLength: 30),
                        VergiDairesi = c.String(maxLength: 30),
                        VergiNo = c.String(maxLength: 30),
                        IskontoOrani = c.Decimal(nullable: false, precision: 5, scale: 2),
                        RiskLimit = c.Decimal(nullable: false, precision: 8, scale: 2),
                        AlisOzelFiyati = c.String(maxLength: 15),
                        SatisOzelFiyati = c.String(maxLength: 15),
                        Aciklama = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Depolar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DepoKodu = c.String(maxLength: 12),
                        DepoAdi = c.String(maxLength: 30),
                        YetkiliKodu = c.String(maxLength: 12),
                        YetkiliAdi = c.String(maxLength: 50),
                        DepoIl = c.String(maxLength: 25),
                        DepoIlce = c.String(maxLength: 25),
                        Semt = c.String(maxLength: 25),
                        Adresi = c.String(maxLength: 100),
                        Telefon = c.String(maxLength: 20),
                        Aciklama = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Fişler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FisKodu = c.String(maxLength: 12),
                        FisTuru = c.String(maxLength: 30),
                        CariTuru = c.String(),
                        CariKodu = c.String(maxLength: 12),
                        CariAdi = c.String(maxLength: 50),
                        BelgeNo = c.String(maxLength: 25),
                        Tarih = c.DateTime(nullable: false),
                        PlasiyerKodu = c.String(maxLength: 12),
                        PlasiyerAdi = c.String(maxLength: 50),
                        IskontoOrani = c.Decimal(nullable: false, precision: 5, scale: 2),
                        IskontoTutari = c.Decimal(nullable: false, precision: 12, scale: 2),
                        ToplamTutar = c.Decimal(nullable: false, precision: 12, scale: 2),
                        Aciklama = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.KasaHareketleri",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FisKodu = c.String(maxLength: 12),
                        Hareket = c.String(maxLength: 10),
                        KasaKodu = c.String(maxLength: 12),
                        KasaAdi = c.String(maxLength: 30),
                        OdemeTuruKodu = c.String(maxLength: 12),
                        OdemeTuruAdi = c.String(maxLength: 30),
                        CariKodu = c.String(maxLength: 12),
                        CariAdi = c.String(maxLength: 50),
                        Tarih = c.DateTime(nullable: false),
                        Tutar = c.Decimal(nullable: false, precision: 12, scale: 2),
                        Aciklama = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Kasalar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KasaKodu = c.String(maxLength: 12),
                        KasaAdi = c.String(maxLength: 50),
                        YetkiliKodu = c.String(maxLength: 12),
                        YetkiliAdi = c.String(maxLength: 50),
                        Aciklama = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.OdemeTurleri",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OdemeTuruKodu = c.String(maxLength: 12),
                        OdemeTuruAdi = c.String(maxLength: 30),
                        Aciklama = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.StokHareketleri",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Fiskodu = c.String(maxLength: 12),
                        Hareket = c.String(maxLength: 12),
                        StokKodu = c.String(maxLength: 12),
                        StokAdi = c.String(maxLength: 50),
                        BarkodTuru = c.String(maxLength: 15),
                        Barkod = c.String(maxLength: 20),
                        Birimi = c.String(maxLength: 15),
                        Miktari = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Kdv = c.Int(nullable: false),
                        BirimFiyati = c.Decimal(nullable: false, precision: 12, scale: 3),
                        IndirimOrani = c.Decimal(nullable: false, precision: 5, scale: 2),
                        IndirimTutari = c.Decimal(nullable: false, precision: 12, scale: 2),
                        ToplamTutar = c.Decimal(nullable: false, precision: 12, scale: 2),
                        DepoKodu = c.String(maxLength: 12),
                        DepoAdi = c.String(maxLength: 30),
                        SeriNo = c.String(maxLength: 200),
                        Tarih = c.DateTime(nullable: false),
                        Aciklama = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Stoklar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Durumu = c.Boolean(nullable: false),
                        StokKodu = c.String(maxLength: 12),
                        StokAdi = c.String(maxLength: 50),
                        Barkod = c.String(maxLength: 20),
                        BarkodTuru = c.String(maxLength: 15),
                        StokBirimi = c.String(maxLength: 15),
                        StokGrubu = c.String(maxLength: 30),
                        StokAltGrubu = c.String(maxLength: 30),
                        Marka = c.String(maxLength: 30),
                        Model = c.String(maxLength: 30),
                        OzelKod1 = c.String(maxLength: 30),
                        OzelKod2 = c.String(maxLength: 30),
                        OzelKod3 = c.String(maxLength: 30),
                        OzelKod4 = c.String(maxLength: 30),
                        GarantiSuresi = c.String(maxLength: 15),
                        UreticiKodu = c.String(maxLength: 20),
                        AlisKdv = c.Int(nullable: false),
                        SatisKdv = c.Int(nullable: false),
                        AlisFiyati1 = c.Decimal(nullable: false, precision: 12, scale: 2),
                        AlisFiyati2 = c.Decimal(nullable: false, precision: 12, scale: 2),
                        AlisFiyati3 = c.Decimal(nullable: false, precision: 12, scale: 2),
                        SatisFiyati1 = c.Decimal(nullable: false, precision: 12, scale: 2),
                        SatisFiyati2 = c.Decimal(nullable: false, precision: 12, scale: 2),
                        SatisFiyati3 = c.Decimal(nullable: false, precision: 12, scale: 2),
                        MinStokMiktari = c.Decimal(nullable: false, precision: 12, scale: 3),
                        MaxStokMiktari = c.Decimal(nullable: false, precision: 12, scale: 3),
                        Aciklama = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tanimlar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Turu = c.String(maxLength: 15),
                        Tanimi = c.String(maxLength: 30),
                        Aciklama = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Tanimlar", new[] { "Id" });
            DropIndex("dbo.StokHareketleri", new[] { "Id" });
            DropIndex("dbo.OdemeTurleri", new[] { "Id" });
            DropIndex("dbo.Kasalar", new[] { "Id" });
            DropIndex("dbo.KasaHareketleri", new[] { "Id" });
            DropIndex("dbo.Fişler", new[] { "Id" });
            DropIndex("dbo.Depolar", new[] { "Id" });
            DropIndex("dbo.Cariler", new[] { "Id" });
            DropTable("dbo.Tanimlar");
            DropTable("dbo.Stoklar");
            DropTable("dbo.StokHareketleri");
            DropTable("dbo.OdemeTurleri");
            DropTable("dbo.Kasalar");
            DropTable("dbo.KasaHareketleri");
            DropTable("dbo.Fişler");
            DropTable("dbo.Depolar");
            DropTable("dbo.Cariler");
        }
    }
}
