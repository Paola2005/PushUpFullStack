using API.Dtos;
using API.Helpers;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

    public class CarritoController : ApiBaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CarritoController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<CarritoDto>>> Get11()
        {
            var Carritos = await _unitOfWork.carritos.GetAllAsync();
            return _mapper.Map<List<CarritoDto>>(Carritos);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<CarritoDto>> Get(int id)
        {
            var Carrito = await _unitOfWork.carritos.GetByIdAsync(id);
            if (Carrito == null)
                return NotFound(new ApiResponse(404, $"El Carrito solicitado no existe."));

            return _mapper.Map<CarritoDto>(Carrito);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Carrito>> Post(CarritoDto CarritoDto)
        {
            var Carrito = _mapper.Map<Carrito>(CarritoDto);
            _unitOfWork.carritos.Add(Carrito);
            await _unitOfWork.SaveAsync();
            if (Carrito == null)
                return BadRequest(new ApiResponse(400));

            CarritoDto.Id = Carrito.Id;
            return CreatedAtAction(nameof(Post), new { id = CarritoDto.Id }, CarritoDto);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<CarritoDto>> Put(int id, [FromBody] CarritoDto CarritoDto)
        {
            if (CarritoDto == null)
                return NotFound(new ApiResponse(404, $"El Carrito solicitado no existe."));

            var CarritoBd = await _unitOfWork.carritos.GetByIdAsync(id);
            if (CarritoBd == null)
                return NotFound(new ApiResponse(404, $"El Carrito solicitado no existe."));

            var Carrito = _mapper.Map<Carrito>(CarritoDto);
            _unitOfWork.carritos.Update(Carrito);
            await _unitOfWork.SaveAsync();
            return CarritoDto;
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var Carrito = await _unitOfWork.carritos.GetByIdAsync(id);
            if (Carrito == null)
                return NotFound(new ApiResponse(404, $"El Carrito solicitado no existe."));

            _unitOfWork.carritos.Remove(Carrito);
            await _unitOfWork.SaveAsync();

            return NoContent();
        }
    }
}