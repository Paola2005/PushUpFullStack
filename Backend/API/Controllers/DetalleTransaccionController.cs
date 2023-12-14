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
    public class DetalleTransaccionController : ApiBaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public DetalleTransaccionController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<DetalleTransaccionDto>>> Get11()
        {
            var DetalleTransaccions = await _unitOfWork.detallestransaccion.GetAllAsync();
            return _mapper.Map<List<DetalleTransaccionDto>>(DetalleTransaccions);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<DetalleTransaccionDto>> Get(int id)
        {
            var DetalleTransaccion = await _unitOfWork.detallestransaccion.GetByIdAsync(id);
            if (DetalleTransaccion == null)
                return NotFound(new ApiResponse(404, $"El DetalleTransaccion solicitado no existe."));

            return _mapper.Map<DetalleTransaccionDto>(DetalleTransaccion);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Detallestransaccion>> Post(DetalleTransaccionDto DetalleTransaccionDto)
        {
            var DetalleTransaccion = _mapper.Map<Detallestransaccion>(DetalleTransaccionDto);
            _unitOfWork.detallestransaccion.Add(DetalleTransaccion);
            await _unitOfWork.SaveAsync();
            if (DetalleTransaccion == null)
                return BadRequest(new ApiResponse(400));

            DetalleTransaccionDto.Id = DetalleTransaccion.Id;
            return CreatedAtAction(nameof(Post), new { id = DetalleTransaccionDto.Id }, DetalleTransaccionDto);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<DetalleTransaccionDto>> Put(int id, [FromBody] DetalleTransaccionDto DetalleTransaccionDto)
        {
            if (DetalleTransaccionDto == null)
                return NotFound(new ApiResponse(404, $"El DetalleTransaccion solicitado no existe."));

            var DetalleTransaccionBd = await _unitOfWork.detallestransaccion.GetByIdAsync(id);
            if (DetalleTransaccionBd == null)
                return NotFound(new ApiResponse(404, $"El DetalleTransaccion solicitado no existe."));

            var DetalleTransaccion = _mapper.Map<Detallestransaccion>(DetalleTransaccionDto);
            _unitOfWork.detallestransaccion.Update(DetalleTransaccion);
            await _unitOfWork.SaveAsync();
            return DetalleTransaccionDto;
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var DetalleTransaccion = await _unitOfWork.detallestransaccion.GetByIdAsync(id);
            if (DetalleTransaccion == null)
                return NotFound(new ApiResponse(404, $"El DetalleTransaccion solicitado no existe."));

            _unitOfWork.detallestransaccion.Remove(DetalleTransaccion);
            await _unitOfWork.SaveAsync();

            return NoContent();
        }
    }
}