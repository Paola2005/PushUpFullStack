using System.ComponentModel.DataAnnotations;

namespace API.Dtos
{
    public class UsuarioscompraDto
    {
                public int Id { get; set; }
    public int UsuarioId { get; set; }

    public decimal TotalCompras { get; set; }

    }
}
