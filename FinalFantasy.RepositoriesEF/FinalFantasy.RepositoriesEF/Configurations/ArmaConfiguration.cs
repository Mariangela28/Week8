using FinalFantasy.FinalFantasy.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinalFantasy.FinalFantasy.RepositoriesEF
{
    public class ArmaConfiguration : IEntityTypeConfiguration<Arma>
    {

        public void Configure(EntityTypeBuilder<Arma> modelbuilder)
        {
            modelbuilder.ToTable("Arma");
            modelbuilder.HasKey(i => i.Id);
            modelbuilder.Property("Id");
            modelbuilder.Property(n => n.Nome).IsRequired();
            modelbuilder.Property(p => p.PuntiDanno).IsRequired();

            modelbuilder.HasOne(m => m.Mostro).WithOne(a => a.Arma).HasForeignKey("MostroId");
            modelbuilder.HasOne(e => e.Eroe).WithOne(a => a.Arma).HasForeignKey("EroeId");

            modelbuilder.HasData(
                new Arma()
                {
                    Nome = "Ascia",
                    PuntiDanno = 8,
                    TipologiaEroe = TipologiaEroe.Soldier,
                    

                });
            modelbuilder.HasData(
                new Arma()
                {
                    Nome = "Mazza",
                    PuntiDanno = 5,
                    TipologiaEroe = TipologiaEroe.Soldier
                });
            modelbuilder.HasData(
                new Arma()
                {
                    Nome = "Spada",
                    PuntiDanno = 10,
                    TipologiaEroe = TipologiaEroe.Soldier,
                    EroeId = 1
                });
            modelbuilder.HasData(
                new Arma()
                {
                    Nome = "Arco e frecce",
                    PuntiDanno = 8,
                    TipologiaEroe = TipologiaEroe.Wizard,
                    EroeId = 2
                });
            modelbuilder.HasData(
                new Arma()
                {
                    Nome = "Bacchetta",
                    PuntiDanno = 5,
                    TipologiaEroe = TipologiaEroe.Wizard,
                    EroeId = 3
                });
            modelbuilder.HasData(
                new Arma()
                {
                    Nome = "Bastone magico",
                    PuntiDanno = 10,
                    TipologiaEroe = TipologiaEroe.Wizard,
                    EroeId = 4
                });

            modelbuilder.HasData(
                new Arma()
                {
                    Nome = "Arco",
                    PuntiDanno = 7,
                    TipologiaMostro = TipologiaMostro.Ghost,
                    MostroId = 1
                });

            modelbuilder.HasData(
                new Arma()
                {
                    Nome = "Clava",
                    PuntiDanno = 5,
                    TipologiaMostro = TipologiaMostro.Ghost,
                    MostroId = 2
                });

            modelbuilder.HasData(
                new Arma()
                {
                    Nome = "Divinazione",
                    PuntiDanno = 15,
                    TipologiaMostro = TipologiaMostro.Lucifer,
                    MostroId = 3
                });
            modelbuilder.HasData(
                new Arma()
                {
                    Nome = "Fulmine",
                    PuntiDanno = 10,
                    TipologiaMostro = TipologiaMostro.Lucifer,
                    MostroId = 4
                });

            modelbuilder.HasData(
                new Arma()
                {
                    Nome = "Tempesta",
                    PuntiDanno = 8,
                    TipologiaMostro = TipologiaMostro.Lucifer,
                    MostroId = 5
                });

            modelbuilder.HasData(
                new Arma()
                {
                    Nome = "Tempesta oscura",
                    PuntiDanno = 15,
                    TipologiaMostro = TipologiaMostro.Lucifer,
                    MostroId = 6
                });
        }
    }
}