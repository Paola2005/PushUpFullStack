using System.ComponentModel.DataAnnotations;
using Domain.Entities;

namespace API.Dtos
{
    public class PedidoDto
    {
                public int Id { get; set; }
    public int? UsuarioId { get; set; }

    public DateOnly FechaPedido { get; set; }

    public string EstadoPedido { get; set; } = null!;

    public virtual ICollection<Detallespedido> Detallespedidos { get; set; } = new List<Detallespedido>();

    }
}
