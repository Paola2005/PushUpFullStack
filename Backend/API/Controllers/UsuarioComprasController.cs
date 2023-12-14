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
    public class UsuarioscompraController : ApiBaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UsuarioscompraController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<UsuarioscompraDto>>> Get11()
        {
            var usuarioscompras = await _unitOfWork.usuarioscompras.GetAllAsync();
            return _mapper.Map<List<UsuarioscompraDto>>(usuarioscompras);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<UsuarioscompraDto>> Get(int id)
        {
            var Usuarioscompra = await _unitOfWork.usuarioscompras.GetByIdAsync(id);
            if (Usuarioscompra == null)
                return NotFound(new ApiResponse(404, $"El Usuarioscompra solicitado no existe."));

            return _mapper.Map<UsuarioscompraDto>(Usuarioscompra);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Usuarioscompra>> Post(UsuarioscompraDto UsuarioscompraDto)
        {
            var Usuarioscompra = _mapper.Map<Usuarioscompra>(UsuarioscompraDto);
            _unitOfWork.usuarioscompras.Add(Usuarioscompra);
            await _unitOfWork.SaveAsync();
            if (Usuarioscompra == null)
                return BadRequest(new ApiResponse(400));

            UsuarioscompraDto.Id = Usuarioscompra.Id;
            return CreatedAtAction(nameof(Post), new { id = UsuarioscompraDto.Id }, UsuarioscompraDto);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<UsuarioscompraDto>> Put(int id, [FromBody] UsuarioscompraDto UsuarioscompraDto)
        {
            if (UsuarioscompraDto == null)
                return NotFound(new ApiResponse(404, $"El Usuarioscompra solicitado no existe."));

            var UsuarioscompraBd = await _unitOfWork.usuarioscompras.GetByIdAsync(id);
            if (UsuarioscompraBd == null)
                return NotFound(new ApiResponse(404, $"El Usuarioscompra solicitado no existe."));

            var Usuarioscompra = _mapper.Map<Usuarioscompra>(UsuarioscompraDto);
            _unitOfWork.usuarioscompras.Update(Usuarioscompra);
            await _unitOfWork.SaveAsync();
            return UsuarioscompraDto;
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var Usuarioscompra = await _unitOfWork.usuarioscompras.GetByIdAsync(id);
            if (Usuarioscompra == null)
                return NotFound(new ApiResponse(404, $"El Usuarioscompra solicitado no existe."));

            _unitOfWork.usuarioscompras.Remove(Usuarioscompra);
            await _unitOfWork.SaveAsync();

            return NoContent();
        }
    }
}