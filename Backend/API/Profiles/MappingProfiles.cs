using API.Dtos;
using AutoMapper;
using Domain.Entities;

namespace API.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Carrito, CarritoDto>().ReverseMap();
            CreateMap<Categoria, CategoriaDto>().ReverseMap();
            CreateMap<Detallescarrito, DetalleCarritoDto>().ReverseMap();
            CreateMap<Detallespedido, DetallePedidoDto>().ReverseMap();
            CreateMap<Detallestransaccion, DetalleTransaccionDto>().ReverseMap();
            CreateMap<Inventario, InventarioDto>().ReverseMap();
            CreateMap<Pedido, PedidoDto>().ReverseMap();
            CreateMap<Producto, ProductoDto>().ReverseMap();
            CreateMap<Role, RolDto>().ReverseMap();
            CreateMap<Transaccione, TransaccionDto>().ReverseMap();
            CreateMap<UserRol, UserRolDto>().ReverseMap();
            CreateMap<Usuarioscompra, UsuarioscompraDto>().ReverseMap();
            CreateMap<Usuario, UsuarioDto>().ReverseMap();


        }

    }
}