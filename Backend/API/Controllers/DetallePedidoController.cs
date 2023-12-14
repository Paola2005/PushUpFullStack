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
    public class DetallePedidoController : ApiBaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DetallePedidoController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<DetallePedidoDto>>> Get11()
        {
            var DetallePedidos = await _unitOfWork.detallespedido.GetAllAsync();
            return _mapper.Map<List<DetallePedidoDto>>(DetallePedidos);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<DetallePedidoDto>> Get(int id)
        {
            var DetallePedido = await _unitOfWork.detallespedido.GetByIdAsync(id);
            if (DetallePedido == null)
                return NotFound(new ApiResponse(404, $"El DetallePedido solicitado no existe."));

            return _mapper.Map<DetallePedidoDto>(DetallePedido);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Detallespedido>> Post(DetallePedidoDto DetallePedidoDto)
        {
            var DetallePedido = _mapper.Map<Detallespedido>(DetallePedidoDto);
            _unitOfWork.detallespedido.Add(DetallePedido);
            await _unitOfWork.SaveAsync();
            if (DetallePedido == null)
                return BadRequest(new ApiResponse(400));

            DetallePedidoDto.Id = DetallePedido.Id;
            return CreatedAtAction(nameof(Post), new { id = DetallePedidoDto.Id }, DetallePedidoDto);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<DetallePedidoDto>> Put(int id, [FromBody] DetallePedidoDto DetallePedidoDto)
        {
            if (DetallePedidoDto == null)
                return NotFound(new ApiResponse(404, $"El DetallePedido solicitado no existe."));

            var DetallePedidoBd = await _unitOfWork.detallespedido.GetByIdAsync(id);
            if (DetallePedidoBd == null)
                return NotFound(new ApiResponse(404, $"El DetallePedido solicitado no existe."));

            var DetallePedido = _mapper.Map<Detallespedido>(DetallePedidoDto);
            _unitOfWork.detallespedido.Update(DetallePedido);
            await _unitOfWork.SaveAsync();
            return DetallePedidoDto;
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var DetallePedido = await _unitOfWork.detallespedido.GetByIdAsync(id);
            if (DetallePedido == null)
                return NotFound(new ApiResponse(404, $"El DetallePedido solicitado no existe."));

            _unitOfWork.detallespedido.Remove(DetallePedido);
            await _unitOfWork.SaveAsync();

            return NoContent();
        }
    }
}