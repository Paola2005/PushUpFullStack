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
    public class DetalleTransaccionRepository : GenericRepository<Detallestransaccion>, IDetalleTransaccion
    {
        private readonly NikeContext _context;

        public DetalleTransaccionRepository(NikeContext context) : base(context)
        {
            _context = context;
        }
    }
}
