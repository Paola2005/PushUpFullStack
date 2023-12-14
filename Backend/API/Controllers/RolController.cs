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
    public class RolController : ApiBaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public RolController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<RolDto>>> Get11()
        {
            var Rols = await _unitOfWork.roles.GetAllAsync();
            return _mapper.Map<List<RolDto>>(Rols);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<RolDto>> Get(int id)
        {
            var Rol = await _unitOfWork.roles.GetByIdAsync(id);
            if (Rol == null)
                return NotFound(new ApiResponse(404, $"El Rol solicitado no existe."));

            return _mapper.Map<RolDto>(Rol);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Role>> Post(RolDto RolDto)
        {
            var Rol = _mapper.Map<Role>(RolDto);
            _unitOfWork.roles.Add(Rol);
            await _unitOfWork.SaveAsync();
            if (Rol == null)
                return BadRequest(new ApiResponse(400));

            RolDto.Id = Rol.Id;
            return CreatedAtAction(nameof(Post), new { id = RolDto.Id }, RolDto);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<RolDto>> Put(int id, [FromBody] RolDto RolDto)
        {
            if (RolDto == null)
                return NotFound(new ApiResponse(404, $"El Rol solicitado no existe."));

            var RolBd = await _unitOfWork.roles.GetByIdAsync(id);
            if (RolBd == null)
                return NotFound(new ApiResponse(404, $"El Rol solicitado no existe."));

            var Rol = _mapper.Map<Role>(RolDto);
            _unitOfWork.roles.Update(Rol);
            await _unitOfWork.SaveAsync();
            return RolDto;
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var Rol = await _unitOfWork.roles.GetByIdAsync(id);
            if (Rol == null)
                return NotFound(new ApiResponse(404, $"El Rol solicitado no existe."));

            _unitOfWork.roles.Remove(Rol);
            await _unitOfWork.SaveAsync();

            return NoContent();
        }
    }
}