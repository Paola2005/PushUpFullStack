using System.ComponentModel.DataAnnotations;
using Domain.Entities;

namespace API.Dtos
{
    public class TransaccionDto
    {
                public int Id { get; set; }
    public int? UsuarioId { get; set; }

    public DateTime? FechaTransaccion { get; set; }

    public decimal Total { get; set; }

    public virtual ICollection<Detallestransaccion> Detallestransaccions { get; set; } = new List<Detallestransaccion>();

    }
}
