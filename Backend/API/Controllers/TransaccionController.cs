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
    public class TransaccionController : ApiBaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public TransaccionController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<TransaccionDto>>> Get11()
        {
            var Transaccions = await _unitOfWork.transacciones.GetAllAsync();
            return _mapper.Map<List<TransaccionDto>>(Transaccions);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<TransaccionDto>> Get(int id)
        {
            var Transaccion = await _unitOfWork.transacciones.GetByIdAsync(id);
            if (Transaccion == null)
                return NotFound(new ApiResponse(404, $"El Transaccion solicitado no existe."));

            return _mapper.Map<TransaccionDto>(Transaccion);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Transaccione>> Post(TransaccionDto TransaccionDto)
        {
            var Transaccion = _mapper.Map<Transaccione>(TransaccionDto);
            _unitOfWork.transacciones.Add(Transaccion);
            await _unitOfWork.SaveAsync();
            if (Transaccion == null)
                return BadRequest(new ApiResponse(400));

            TransaccionDto.Id = Transaccion.Id;
            return CreatedAtAction(nameof(Post), new { id = TransaccionDto.Id }, TransaccionDto);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<TransaccionDto>> Put(int id, [FromBody] TransaccionDto TransaccionDto)
        {
            if (TransaccionDto == null)
                return NotFound(new ApiResponse(404, $"El Transaccion solicitado no existe."));

            var TransaccionBd = await _unitOfWork.transacciones.GetByIdAsync(id);
            if (TransaccionBd == null)
                return NotFound(new ApiResponse(404, $"El Transaccion solicitado no existe."));

            var Transaccion = _mapper.Map<Transaccione>(TransaccionDto);
            _unitOfWork.transacciones.Update(Transaccion);
            await _unitOfWork.SaveAsync();
            return TransaccionDto;
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var Transaccion = await _unitOfWork.transacciones.GetByIdAsync(id);
            if (Transaccion == null)
                return NotFound(new ApiResponse(404, $"El Transaccion solicitado no existe."));

            _unitOfWork.transacciones.Remove(Transaccion);
            await _unitOfWork.SaveAsync();

            return NoContent();
        }
    }
}