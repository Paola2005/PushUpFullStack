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
    public class PedidoController : ApiBaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public PedidoController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<PedidoDto>>> Get11()
        {
            var Pedidos = await _unitOfWork.pedidos.GetAllAsync();
            return _mapper.Map<List<PedidoDto>>(Pedidos);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<PedidoDto>> Get(int id)
        {
            var Pedido = await _unitOfWork.pedidos.GetByIdAsync(id);
            if (Pedido == null)
                return NotFound(new ApiResponse(404, $"El Pedido solicitado no existe."));

            return _mapper.Map<PedidoDto>(Pedido);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Pedido>> Post(PedidoDto PedidoDto)
        {
            var Pedido = _mapper.Map<Pedido>(PedidoDto);
            _unitOfWork.pedidos.Add(Pedido);
            await _unitOfWork.SaveAsync();
            if (Pedido == null)
                return BadRequest(new ApiResponse(400));

            PedidoDto.Id = Pedido.Id;
            return CreatedAtAction(nameof(Post), new { id = PedidoDto.Id }, PedidoDto);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<PedidoDto>> Put(int id, [FromBody] PedidoDto PedidoDto)
        {
            if (PedidoDto == null)
                return NotFound(new ApiResponse(404, $"El Pedido solicitado no existe."));

            var PedidoBd = await _unitOfWork.pedidos.GetByIdAsync(id);
            if (PedidoBd == null)
                return NotFound(new ApiResponse(404, $"El Pedido solicitado no existe."));

            var Pedido = _mapper.Map<Pedido>(PedidoDto);
            _unitOfWork.pedidos.Update(Pedido);
            await _unitOfWork.SaveAsync();
            return PedidoDto;
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var Pedido = await _unitOfWork.pedidos.GetByIdAsync(id);
            if (Pedido == null)
                return NotFound(new ApiResponse(404, $"El Pedido solicitado no existe."));

            _unitOfWork.pedidos.Remove(Pedido);
            await _unitOfWork.SaveAsync();

            return NoContent();
        }
    }
}