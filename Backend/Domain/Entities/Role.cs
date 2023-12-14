﻿using System;
using System.Buffers.Text;
using System.Collections.Generic;

namespace Domain.Entities;

public partial class Role:BaseEntity
{
   
    public string NombreRol { get; set; } = null!;

   public ICollection<Usuario> Users { get; set; } = new HashSet<Usuario>();
        public ICollection<UserRol> UsersRols { get; set; }
}
