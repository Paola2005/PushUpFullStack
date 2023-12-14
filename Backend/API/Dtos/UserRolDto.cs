using System.ComponentModel.DataAnnotations;

namespace API.Dtos
{
    public class UserRolDto
    {
                public int Id { get; set; }
        public int UserId { get; set; }

        public int RolId { get; set; }

    }
}
