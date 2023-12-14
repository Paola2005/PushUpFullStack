using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Domain.Entities;

namespace Persistence.Data.Configuration
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {

            builder.HasKey(e => e.Id).HasName("PRIMARY");

            builder.ToTable("usuarios");


            builder.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("usuario_id");
            builder.Property(e => e.Password)
                .HasMaxLength(255)
                .HasColumnName("contrasena");
            builder.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("correo_electronico");
            builder.Property(e => e.Username)
                .HasMaxLength(50)
                .HasColumnName("nombre_usuario");

                
            builder
                .HasMany(p => p.Rols)
                .WithMany(r => r.Users)
                .UsingEntity<UserRol>(
                    j =>
                        j.HasOne(pt => pt.Rol)
                            .WithMany(t => t.UsersRols)
                            .HasForeignKey(ut => ut.RolId),
                    j =>
                        j.HasOne(et => et.Users)
                            .WithMany(et => et.Userrols)
                            .HasForeignKey(el => el.UserId),
                    j =>
                    {
                        j.ToTable("userRol");
                        j.HasKey(t => new { t.UserId, t.RolId });
                    }
                );
           
            
    }
}
}

