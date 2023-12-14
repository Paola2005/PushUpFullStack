using System.ComponentModel.DataAnnotations;
using Domain.Entities;

namespace API.Dtos
{
    public class DetalleCarritoDto
    {
                public int Id { get; set; }
 public int? CarritoId { get; set; }

    public int? ProductoId { get; set; }

    public int Cantidad { get; set; }


    }
}
