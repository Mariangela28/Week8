using FinalFantasy.FinalFantasy.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinalFantasy.FinalFantasy.RepositoriesEF
{
    public class MostroConfiguration : IEntityTypeConfiguration<Mostro>
    {
        public void Configure(EntityTypeBuilder<Mostro> modelbuilder)
        {
            modelbuilder.ToTable("Mostro");
            modelbuilder.HasKey(k => k.Id);
            modelbuilder.Property(n => n.Nome).IsRequired();
            modelbuilder.Property("TipologiaMostro").IsRequired();
            modelbuilder.HasOne(a => a.Arma).WithOne(m => m.Mostro).HasForeignKey("ArmaId");
            
        }
    }
}