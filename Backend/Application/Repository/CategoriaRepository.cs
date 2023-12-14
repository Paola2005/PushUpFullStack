using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;
using Persistence.Data;

namespace Application.Repository
{
    public class CategoriaRepository : GenericRepository<Categoria>, ICategoria
    {
        private readonly NikeContext _context;

        public CategoriaRepository(NikeContext context) : base(context)
        {
            _context = context;
        }
    }
}
