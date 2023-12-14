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
    public class DetallesCarritoController : ApiBaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DetallesCarritoController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<DetalleCarritoDto>>> Get11()
        {
            var DetallesCarritos = await _unitOfWork.detallescarrito.GetAllAsync();
            return _mapper.Map<List<DetalleCarritoDto>>(DetallesCarritos);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<DetalleCarritoDto>> Get(int id)
        {
            var DetallesCarrito = await _unitOfWork.detallescarrito.GetByIdAsync(id);
            if (DetallesCarrito == null)
                return NotFound(new ApiResponse(404, $"El DetallesCarrito solicitado no existe."));

            return _mapper.Map<DetalleCarritoDto>(DetallesCarrito);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Detallescarrito>> Post(DetalleCarritoDto DetallesCarritoDto)
        {
            var DetallesCarrito = _mapper.Map<Detallescarrito>(DetallesCarritoDto);
            _unitOfWork.detallescarrito.Add(DetallesCarrito);
            await _unitOfWork.SaveAsync();
            if (DetallesCarrito == null)
                return BadRequest(new ApiResponse(400));

            DetallesCarritoDto.Id = DetallesCarrito.Id;
            return CreatedAtAction(nameof(Post), new { id = DetallesCarritoDto.Id }, DetallesCarritoDto);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<DetalleCarritoDto>> Put(int id, [FromBody] DetalleCarritoDto DetallesCarritoDto)
        {
            if (DetallesCarritoDto == null)
                return NotFound(new ApiResponse(404, $"El DetallesCarrito solicitado no existe."));

            var DetallesCarritoBd = await _unitOfWork.detallescarrito.GetByIdAsync(id);
            if (DetallesCarritoBd == null)
                return NotFound(new ApiResponse(404, $"El DetallesCarrito solicitado no existe."));

            var DetallesCarrito = _mapper.Map<Detallescarrito>(DetallesCarritoDto);
            _unitOfWork.detallescarrito.Update(DetallesCarrito);
            await _unitOfWork.SaveAsync();
            return DetallesCarritoDto;
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var DetallesCarrito = await _unitOfWork.detallescarrito.GetByIdAsync(id);
            if (DetallesCarrito == null)
                return NotFound(new ApiResponse(404, $"El DetallesCarrito solicitado no existe."));

            _unitOfWork.detallescarrito.Remove(DetallesCarrito);
            await _unitOfWork.SaveAsync();

            return NoContent();
        }
    }
}