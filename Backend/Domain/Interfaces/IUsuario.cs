using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
        
namespace Domain.Interfaces
{
    public interface IUsuario:IGenericRepository<Usuario>
    {
    Task<Usuario> GetByUsernameAsync(string Username);
    Task<Usuario> GetByRefreshTokenAsync(string Username);
    }
}
