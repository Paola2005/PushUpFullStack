using API.Dtos;
using API.Helpers;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Authorize(Roles = "Employee")]
    public class ProductoController : ApiBaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ProductoController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<ProductoDto>>> Get11()
        {
            var Productos = await _unitOfWork.productos.GetAllAsync();
            return _mapper.Map<List<ProductoDto>>(Productos);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ProductoDto>> Get(int id)
        {
            var Producto = await _unitOfWork.productos.GetByIdAsync(id);
            if (Producto == null)
                return NotFound(new ApiResponse(404, $"El Producto solicitado no existe."));

            return _mapper.Map<ProductoDto>(Producto);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Producto>> Post(ProductoDto ProductoDto)
        {
            var Producto = _mapper.Map<Producto>(ProductoDto);
            _unitOfWork.productos.Add(Producto);
            await _unitOfWork.SaveAsync();
            if (Producto == null)
                return BadRequest(new ApiResponse(400));

            ProductoDto.Id = Producto.Id;
            return CreatedAtAction(nameof(Post), new { id = ProductoDto.Id }, ProductoDto);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ProductoDto>> Put(int id, [FromBody] ProductoDto ProductoDto)
        {
            if (ProductoDto == null)
                return NotFound(new ApiResponse(404, $"El Producto solicitado no existe."));

            var ProductoBd = await _unitOfWork.productos.GetByIdAsync(id);
            if (ProductoBd == null)
                return NotFound(new ApiResponse(404, $"El Producto solicitado no existe."));

            var Producto = _mapper.Map<Producto>(ProductoDto);
            _unitOfWork.productos.Update(Producto);
            await _unitOfWork.SaveAsync();
            return ProductoDto;
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var Producto = await _unitOfWork.productos.GetByIdAsync(id);
            if (Producto == null)
                return NotFound(new ApiResponse(404, $"El Producto solicitado no existe."));

            _unitOfWork.productos.Remove(Producto);
            await _unitOfWork.SaveAsync();

            return NoContent();
        }
    }
}