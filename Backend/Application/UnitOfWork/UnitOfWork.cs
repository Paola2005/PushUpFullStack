using Application.Repository;
using Domain.Entities;
using Domain.Interfaces;
using Persistence.Data;
using System;
using System.Threading.Tasks;

namespace Application.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly NikeContext _context;
        private ICarrito _carrito;
        private ICategoria _categoria;
        private IDetallesCarrito _detallecarrito;
        private IDetallePedido _detallepedido;
        private IDetalleTransaccion _detalletransaccion;
        private IInventario _inventario;
        private IPedido _pedido;
        private IProducto _producto;
        private IRol _rol;
        private ITransaccion _transaccion;
        private IUsuario _usuario;
        private IUsuarioCompras _usuariocompras;

        public ICarrito carritos 
                {
            get
            {
                if (_carrito == null)
                {
                    _carrito = new CarritoRepository(_context);
                }
                return _carrito;
            }
        }

        public ICategoria categorias 
                {
            get
            {
                if (_categoria == null)
                {
                    _categoria = new CategoriaRepository(_context);
                }
                return _categoria;
            }
        }

        public IDetallesCarrito detallescarrito 
                {
            get
            {
                if (_detallecarrito == null)
                {
                    _detallecarrito = new DetalleCarritoRepository(_context);
                }
                return _detallecarrito;
            }
        }

        public IDetallePedido detallespedido 
                {
            get
            {
                if (_detallepedido == null)
                {
                    _detallepedido = new DetallePedidoRepository(_context);
                }
                return _detallepedido;
            }
        }

        public IDetalleTransaccion detallestransaccion 
                {
            get
            {
                if (_detalletransaccion == null)
                {
                    _detalletransaccion = new DetalleTransaccionRepository(_context);
                }
                return _detalletransaccion;
            }
        }

        public IInventario inventarios 
                {
            get
            {
                if (_inventario == null)
                {
                    _inventario = new InventarioRepository(_context);
                }
                return _inventario;
            }
        }

        public IPedido pedidos 
                {
            get
            {
                if (_pedido == null)
                {
                    _pedido = new PedidoRepository(_context);
                }
                return _pedido;
            }
        }

        public IProducto productos 
                {
            get
            {
                if (_producto == null)
                {
                    _producto = new ProductoRepository(_context);
                }
                return _producto;
            }
        }



        public IRol roles 
                {
            get
            {
                if (_rol == null)
                {
                    _rol = new RolRepository(_context);
                }
                return _rol;
            }
        }

        public ITransaccion transacciones 
                {
            get
            {
                if (_transaccion == null)
                {
                    _transaccion = new TransaccionRepository(_context);
                }
                return _transaccion;
            }
        }

        public IUsuario usuarios 
                {
            get
            {
                if (_usuario == null)
                {
                    _usuario = new UsuarioRepository(_context);
                }
                return _usuario;
            }
        }

        public IUsuarioCompras usuarioscompras 
                {
            get
            {
                if (_usuariocompras == null)
                {
                    _usuariocompras = new UsuarioComprasRepository(_context);
                }
                return _usuariocompras;
            }
        }

        public UnitOfWork(NikeContext context)
        {
            _context = context;
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
