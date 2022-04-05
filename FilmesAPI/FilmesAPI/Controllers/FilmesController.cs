using AutoMapper;
using FilmesAPI.Data;
using FilmesAPI.Data.DTOs;
using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace FilmesAPI.Controllers
{
    [ApiController] //define a classe como controlador, controladores lidam com as requisições recebidas e enviam respostas
    [Route("[controller]")] //como eu desejo fazer o chamado web, desse modo o nome da classe abaixo será utilizado
    public class FilmesController : ControllerBase
    {
        private FilmesDbContext _context;
        private IMapper _mapper;

        public FilmesController(FilmesDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost] //criação de recurso no sistema
        public IActionResult AdicionaFilme([FromBody] CreateFilmeDto filmeDto)
        {
            Filme filme = _mapper.Map<Filme>(filmeDto);
            _context.Filmes.Add(filme);
            _context.SaveChanges();
            return CreatedAtAction(nameof(RecuperaFilmeId), new {Id = filme.Id }, filme);
        }
        [HttpGet]
        public IEnumerable<Filme> RecuperaFilmes()
        {
            return _context.Filmes;
        }
        [HttpGet("{id}")]
        public IActionResult RecuperaFilmeId(int id)
        {
            Filme filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id);

            if (filme == null) return NotFound();
            ReadFilmeDto filmeDto = _mapper.Map<ReadFilmeDto>(filme);
            return Ok(filme);
            
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaFilme(int id, [FromBody] CreateFilmeDto filmeDto)
        {
            Filme filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id);

            if (filme == null) return NotFound();

            _mapper.Map(filmeDto, filme);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletaFilme(int id)
        {
            Filme filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id);

            if (filme == null) return NotFound();

            _context.Remove(filme);
            _context.SaveChanges();
            return NoContent();
        }
               

    }
}
