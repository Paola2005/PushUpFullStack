using System.ComponentModel.DataAnnotations;
using Domain.Entities;

namespace API.Dtos
{
    public class CarritoDto
    {
        public int Id { get; set; }
    public int? UsuarioId { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public virtual ICollection<Detallescarrito> Detallescarritos { get; set; } = new List<Detallescarrito>();

    }
}
