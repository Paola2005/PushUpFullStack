using System.ComponentModel.DataAnnotations;
using Domain.Entities;

namespace API.Dtos
{
    public class InventarioDto
    {
                public int Id { get; set; }
    public int? ProductoId { get; set; }

    public int CantidadAnterior { get; set; }

    public int CantidadNueva { get; set; }

    public DateTime? FechaMovimiento { get; set; }


    }
}
