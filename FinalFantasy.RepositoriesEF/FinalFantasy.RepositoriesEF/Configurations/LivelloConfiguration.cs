using FinalFantasy.FinalFantasy.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinalFantasy.FinalFantasy.RepositoriesEF
{
    public class LivelloConfiguration : IEntityTypeConfiguration<Livello>
    {
        public void Configure(EntityTypeBuilder<Livello> modelbuilder)
        {
            modelbuilder.ToTable("Livello");
            modelbuilder.HasKey("Id");
            modelbuilder.Property("Vita").IsRequired();
            modelbuilder.Property("LivelloAttuale").IsRequired();


        }
    }
}