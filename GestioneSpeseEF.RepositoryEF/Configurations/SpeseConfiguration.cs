using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using GestioneSpesaEF.Core.Entities;

namespace GestioneSpeseEF.RepositoryEF
{
    internal class SpeseConfiguration : IEntityTypeConfiguration<Spese>
    {
        public void Configure(EntityTypeBuilder<Spese> builder)
        {
            builder.ToTable("Spese");
            builder.HasKey(x => x.Id);
            builder.Property(s=>s.Data).IsRequired();
            builder.Property(s=>s.CategoriaId).IsRequired();
            builder.Property(s=>s.Descrizione).IsRequired();
            builder.Property(s=>s.Utente).IsRequired();
            builder.Property(s=>s.Importo).IsRequired();
            builder.Property(s=>s.Approvato).IsRequired();

            //relazione
            builder.HasOne(s=>s.Categorie).WithMany(c=>c.Spese).HasForeignKey(s=>s.CategoriaId);
        }
    }
}