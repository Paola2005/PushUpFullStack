using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
        
namespace Domain.Interfaces
{
    public interface IUnitOfWork
    {

        ICarrito carritos{ get;}
        ICategoria categorias{get;}
        IDetallesCarrito detallescarrito{get;}
        IDetallePedido detallespedido{get;}
        IDetalleTransaccion detallestransaccion{get;}
        IInventario inventarios{get;}
        IPedido pedidos{get;}
        IProducto productos{get;}
        IRol roles{get;}
        ITransaccion transacciones{get;}
        IUsuario usuarios{get;}
        IUsuarioCompras usuarioscompras{get;}

        Task<int> SaveAsync();
    }
}
