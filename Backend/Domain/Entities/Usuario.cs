using System;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Usuario:BaseEntity
{


    public string Username { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;



    public virtual ICollection<Carrito> Carritos { get; set; } = new List<Carrito>();

    public virtual ICollection<Pedido> Pedidos { get; set; } = new List<Pedido>();

 public ICollection<Role> Rols { get; set; } = new HashSet<Role>();
    public ICollection<RefreshToken> RefreshTokens { get; set; } = new HashSet<RefreshToken>();

    public virtual ICollection<Transaccione> Transacciones { get; set; } = new List<Transaccione>();

    public virtual ICollection<UserRol> Userrols { get; set; } = new List<UserRol>();

    public virtual Usuarioscompra? Usuarioscompra { get; set; }
}
