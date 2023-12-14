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
    public class InventarioController : ApiBaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public InventarioController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<InventarioDto>>> Get11()
        {
            var Inventarios = await _unitOfWork.inventarios.GetAllAsync();
            return _mapper.Map<List<InventarioDto>>(Inventarios);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<InventarioDto>> Get(int id)
        {
            var Inventario = await _unitOfWork.inventarios.GetByIdAsync(id);
            if (Inventario == null)
                return NotFound(new ApiResponse(404, $"El Inventario solicitado no existe."));

            return _mapper.Map<InventarioDto>(Inventario);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Inventario>> Post(InventarioDto InventarioDto)
        {
            var Inventario = _mapper.Map<Inventario>(InventarioDto);
            _unitOfWork.inventarios.Add(Inventario);
            await _unitOfWork.SaveAsync();
            if (Inventario == null)
                return BadRequest(new ApiResponse(400));

            InventarioDto.Id = Inventario.Id;
            return CreatedAtAction(nameof(Post), new { id = InventarioDto.Id }, InventarioDto);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<InventarioDto>> Put(int id, [FromBody] InventarioDto InventarioDto)
        {
            if (InventarioDto == null)
                return NotFound(new ApiResponse(404, $"El Inventario solicitado no existe."));

            var InventarioBd = await _unitOfWork.inventarios.GetByIdAsync(id);
            if (InventarioBd == null)
                return NotFound(new ApiResponse(404, $"El Inventario solicitado no existe."));

            var Inventario = _mapper.Map<Inventario>(InventarioDto);
            _unitOfWork.inventarios.Update(Inventario);
            await _unitOfWork.SaveAsync();
            return InventarioDto;
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var Inventario = await _unitOfWork.inventarios.GetByIdAsync(id);
            if (Inventario == null)
                return NotFound(new ApiResponse(404, $"El Inventario solicitado no existe."));

            _unitOfWork.inventarios.Remove(Inventario);
            await _unitOfWork.SaveAsync();

            return NoContent();
        }
    }
}