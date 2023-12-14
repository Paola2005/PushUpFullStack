using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class UserRol
    {
        
        public int UserId { get; set; }
        public Usuario Users { get; set; }
        public int RolId { get; set; }
        public Role Rol { get; set; }
    }
}