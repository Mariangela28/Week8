using FinalFantasy.FinalFantasy.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinalFantasy.FinalFantasy.RepositoriesEF
{
    public class EroeConfiguration : IEntityTypeConfiguration<Eroe>
    {


        public void Configure(EntityTypeBuilder<Eroe> modelbuilder)
        {
            modelbuilder.ToTable("Eroe");
            modelbuilder.HasKey(k => k.Id);
            modelbuilder.Property(n => n.Nome).IsRequired();
            modelbuilder.Property("TipologiaEroe").IsRequired();
            modelbuilder.Property("Esperienza").IsRequired();
            modelbuilder.HasOne("Arma").WithOne("Eroe").HasForeignKey("ArmaId");
            

        }
    }
}