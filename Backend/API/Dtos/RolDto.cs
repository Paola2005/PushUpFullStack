using System.ComponentModel.DataAnnotations;
using Domain.Entities;

namespace API.Dtos
{
    public class RolDto
    {
                public int Id { get; set; }
    public string NombreRol { get; set; } = null!;

   public ICollection<Usuario> Users { get; set; } = new HashSet<Usuario>();
        public ICollection<UserRol> UsersRols { get; set; }
    }
}
