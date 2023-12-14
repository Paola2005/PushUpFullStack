using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain.Entities;

namespace Persistence.Data.Configuration
{
    public class CategoriaConfiguration : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("categorias");

            builder.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("categoria_id");
            builder.Property(e => e.NombreCategoria)
                .HasMaxLength(50)
                .HasColumnName("nombre_categoria");
        }
    }
}

