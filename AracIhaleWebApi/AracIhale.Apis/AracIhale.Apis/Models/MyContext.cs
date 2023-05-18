using AracIhale.Apis.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace AracIhale.Apis.Models
{
    public class MyContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"data source=NESE\SQLEXPRESS;initial catalog=IkinciElAracSatis;integrated security=True; TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           

            modelBuilder.Entity<IhaleyeAracEkleme>()
               .HasKey(a => new {
                   a.AracID,
                   a.AracIhaleID
               });

            modelBuilder.Entity<IhaleyeAracEkleme>()
                .HasOne(a => a.Arac)
                .WithMany(a => a.IhaleyeAracEkleme)
                .HasForeignKey(a => a.AracID);

            modelBuilder.Entity<IhaleyeAracEkleme>()
               .HasOne(a => a.AracIhale)
               .WithMany(a => a.IhaleyeAracEkleme)
               .HasForeignKey(a => a.AracIhaleID);



            modelBuilder.Entity<AracIhaleSahip>()
               .HasKey(a => new {
                   a.AracIhaleID,
                   a.KullaniciID
               });

            modelBuilder.Entity<AracIhaleSahip>()
                .HasOne(a => a.Kullanici)
                .WithMany(a => a.AracIhaleSahipleri)
                .HasForeignKey(a => a.KullaniciID);

            modelBuilder.Entity<AracIhaleSahip>()
               .HasOne(a => a.AracIhale)
               .WithMany(a => a.AracIhaleSahipleri)
               .HasForeignKey(a => a.AracIhaleID);




            modelBuilder.Entity<Rol>()
                .HasMany<Kullanici>(c => c.Kullanicilar)
                .WithOne(o => o.Rol)
                .HasForeignKey(o => o.RolID);

            modelBuilder.Entity<Kullanici>()
              .HasMany<AracIhale.Apis.Models.Entities.AracIhale>(c => c.AracIhaleleri)
              .WithOne(o => o.Kullanici)
              .HasForeignKey(o => o.KullaniciID);

            modelBuilder.Entity<Sirket>()
             .HasMany<AracIhale.Apis.Models.Entities.AracIhale>(c => c.AracIhaleleri)
             .WithOne(o => o.Sirket)
             .HasForeignKey(o => o.SirketID);

           


            base.OnModelCreating(modelBuilder);
        }


        public DbSet<Arac> Aracs { get; set; }
        public DbSet<AracDetay> AracDetays { get; set; }
        public DbSet<AracStatu> AracStatus { get; set; }
        public DbSet<AracFoto> AracFotoes { get; set; }
        public DbSet<AracIhale.Apis.Models.Entities.AracIhale> AracIhales { get; set; }

        public DbSet<OpsiyonelDonanim> OpsiyonelDonanims { get; set; }
        public DbSet<GovdeTip> GovdeTips { get; set; }
        public DbSet<IhaleFiyatBelirleme> IhaleFiyatBelirlemes { get; set; }
        public DbSet<IhaleStatu> IhaleStatus { get; set; }
        public DbSet<IhaleyeAracEkleme> IhaleyeAracEklemes { get; set; }
        public DbSet<KurumsalKullaniciAracDetay> KurumsalKullaniciAracDetays { get; set; }
        public DbSet<Marka> Markas { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Plaka> Plakas { get; set; }
        public DbSet<Renk> Renks { get; set; }
        public DbSet<Rol> Rols { get; set; }
        public DbSet<Versiyon> Versiyons { get; set; }
        public DbSet<VitesTip> VitesTips { get; set; }
        public DbSet<YakitTip> YakitTips { get; set; }
        public DbSet<ParaBirim> ParaBirims { get; set; }
        public DbSet<Sirket> Sirkets { get; set; }
        public DbSet<IhaleFiyat> IhaleFiyats { get; set; }
        public DbSet<Kullanici> Kullanicis { get; set; }
        public DbSet<AracIhaleSahip> AracIhaleSahips { get; set; }
    }
}
