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
    public class CategoriaController : ApiBaseController
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public CategoriaController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<CategoriaDto>>> Get11()
        {
            var Categorias = await _unitOfWork.categorias.GetAllAsync();
            return _mapper.Map<List<CategoriaDto>>(Categorias);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<CategoriaDto>> Get(int id)
        {
            var Categoria = await _unitOfWork.categorias.GetByIdAsync(id);
            if (Categoria == null)
                return NotFound(new ApiResponse(404, $"El Categoria solicitado no existe."));

            return _mapper.Map<CategoriaDto>(Categoria);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<Categoria>> Post(CategoriaDto CategoriaDto)
        {
            var Categoria = _mapper.Map<Categoria>(CategoriaDto);
            _unitOfWork.categorias.Add(Categoria);
            await _unitOfWork.SaveAsync();
            if (Categoria == null)
                return BadRequest(new ApiResponse(400));

            CategoriaDto.Id = Categoria.Id;
            return CreatedAtAction(nameof(Post), new { id = CategoriaDto.Id }, CategoriaDto);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<CategoriaDto>> Put(int id, [FromBody] CategoriaDto CategoriaDto)
        {
            if (CategoriaDto == null)
                return NotFound(new ApiResponse(404, $"El Categoria solicitado no existe."));

            var CategoriaBd = await _unitOfWork.categorias.GetByIdAsync(id);
            if (CategoriaBd == null)
                return NotFound(new ApiResponse(404, $"El Categoria solicitado no existe."));

            var Categoria = _mapper.Map<Categoria>(CategoriaDto);
            _unitOfWork.categorias.Update(Categoria);
            await _unitOfWork.SaveAsync();
            return CategoriaDto;
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var Categoria = await _unitOfWork.categorias.GetByIdAsync(id);
            if (Categoria == null)
                return NotFound(new ApiResponse(404, $"El Categoria solicitado no existe."));

            _unitOfWork.categorias.Remove(Categoria);
            await _unitOfWork.SaveAsync();

            return NoContent();
        }
    }
}