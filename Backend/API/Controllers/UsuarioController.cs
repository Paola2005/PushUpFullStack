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
    public class UsuarioController : ApiBaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public UsuarioController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<UsuarioDto>>> Get11()
        {
            var usuarios = await _unitOfWork.usuarios.GetAllAsync();
            return _mapper.Map<List<UsuarioDto>>(usuarios);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<UsuarioDto>> Get(int id)
        {
            var Usuario = await _unitOfWork.usuarios.GetByIdAsync(id);
            if (Usuario == null)
                return NotFound(new ApiResponse(404, $"El Usuario solicitado no existe."));

            return _mapper.Map<UsuarioDto>(Usuario);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Usuario>> Post(UsuarioDto UsuarioDto)
        {
            var Usuario = _mapper.Map<Usuario>(UsuarioDto);
            _unitOfWork.usuarios.Add(Usuario);
            await _unitOfWork.SaveAsync();
            if (Usuario == null)
                return BadRequest(new ApiResponse(400));

            UsuarioDto.Id = Usuario.Id;
            return CreatedAtAction(nameof(Post), new { id = UsuarioDto.Id }, UsuarioDto);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<UsuarioDto>> Put(int id, [FromBody] UsuarioDto UsuarioDto)
        {
            if (UsuarioDto == null)
                return NotFound(new ApiResponse(404, $"El Usuario solicitado no existe."));

            var UsuarioBd = await _unitOfWork.usuarios.GetByIdAsync(id);
            if (UsuarioBd == null)
                return NotFound(new ApiResponse(404, $"El Usuario solicitado no existe."));

            var Usuario = _mapper.Map<Usuario>(UsuarioDto);
            _unitOfWork.usuarios.Update(Usuario);
            await _unitOfWork.SaveAsync();
            return UsuarioDto;
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var Usuario = await _unitOfWork.usuarios.GetByIdAsync(id);
            if (Usuario == null)
                return NotFound(new ApiResponse(404, $"El Usuario solicitado no existe."));

            _unitOfWork.usuarios.Remove(Usuario);
            await _unitOfWork.SaveAsync();

            return NoContent();
        }
    }
}