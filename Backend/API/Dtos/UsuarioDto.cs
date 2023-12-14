using System.ComponentModel.DataAnnotations;
using Domain.Entities;

namespace API.Dtos
{
    public class UsuarioDto
    {
                public int Id { get; set; }
    public string NombreUsuario { get; set; } = null!;

    public string CorreoElectronico { get; set; } = null!;

    public string Contrasena { get; set; } = null!;



    public virtual ICollection<Carrito> Carritos { get; set; } = new List<Carrito>();

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();

 public ICollection<Role> Rols { get; set; } = new HashSet<Role>();
    public ICollection<RefreshToken> RefreshTokens { get; set; } = new HashSet<RefreshToken>();

    public virtual ICollection<Transaccione> Transacciones { get; set; } = new List<Transaccione>();

    public virtual ICollection<UserRol> Userrols { get; set; } = new List<UserRol>();

    }
}

