using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;//eklemek lazım dbcontex için
using System.Threading.Tasks;
using MGsTok.Entities.Tables;//Eklemek lazım tablolar için
using MGsTok.Entities.Mapping;

namespace MGsTok.Entities.Contex
{
    public class MGsTOKContex:DbContext
    {
        public DbSet<Stok> Stoklar { get; set; }
        public DbSet<Cari> Cariler { get; set; }
        public DbSet<Fis> Fisler { get; set; }
        public DbSet<StokHareket> StokHareketleri { get; set; }
        public DbSet<KasaHareket> KasaHareketleri { get; set; }
        public DbSet<Depo> Depolar { get; set; }
        public DbSet<Kasa> kasalar { get; set; }
        public DbSet<OdemeTuru> OdemeTurleri { get; set; }
        public DbSet<Tanim> Tanımlar { get; set; }
        public DbSet<Personel> Personeller { get; set; }
        public DbSet<Indirim> Indirimler { get; set; }
        public DbSet<EFAppointment> EFAppointments { get; set; }
        public DbSet<EFResource> EFResources { get; set; }
        public DbSet<Il> Il { get; set; }
        public DbSet<Ilceler> Ilceler { get; set; }

        //map ettiğimiz tabloları database de oluşturma
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new StokMap());
            modelBuilder.Configurations.Add(new CariMap());
            modelBuilder.Configurations.Add(new FisMap());
            modelBuilder.Configurations.Add(new KasaHareketMap());
            modelBuilder.Configurations.Add(new StokHareketMap());
            modelBuilder.Configurations.Add(new DepoMap());
            modelBuilder.Configurations.Add(new KasaMap());
            modelBuilder.Configurations.Add(new OdemeTuruMap());
            modelBuilder.Configurations.Add(new TanimMap());
            modelBuilder.Configurations.Add(new PersonelMap());
            modelBuilder.Configurations.Add(new IndirimMap());
        }
    }
}
