using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using GestioneSpesaEF.Core.Entities;

namespace GestioneSpeseEF.RepositoryEF
{
    internal class CategorieConfiguration : IEntityTypeConfiguration<Categorie>
    {
        public void Configure(EntityTypeBuilder<Categorie> builder)
        {
            builder.ToTable("Categorie");
            builder.HasKey(x => x.Id);
            builder.Property(x=> x.Categoria).IsRequired();

            //relazione cat-spese
            builder.HasMany(c => c.Spese).WithOne(s => s.Categorie).HasForeignKey(s => s.CategoriaId);
        }
    }
}