using Exo.WebApi.Models;
using Exo.WebApi.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Exo.WebApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ProjetosController : ControllerBase
  {
    private readonly ProjetoRepository _porjetoRepository;
    public ProjetosController(ProjetoRepository projetoRepository)
    {
      _porjetoRepository = projetoRepository;
    }
    [HttpGet]
    public IActionResult Listar()
    {
      return Ok(_porjetoRepository.Listar());
    }
    [HttpPost]
    public IActionResult Cadastrar(Projeto projeto)
    {
      _porjetoRepository.Cadastrar(projeto);
      return StatusCode(201);
    }
    [HttpGet("{id}")]
    public IActionResult BuscarPorId(int id)
    {
      Projeto projeto = _porjetoRepository.BuscarPorId(id);
      if (projeto == null)
      {
        return NotFound();
      }
      return Ok(projeto);
    }
    [HttpPut("/{id}")]
    public IActionResult Atualizar(int id, Projeto projeto)
    {
      _porjetoRepository.Atualizar(id, projeto);
      return StatusCode(204);
    }
    [HttpDelete("/{id}")]
    public IActionResult Deletar(int id)
    {
      try
      {
        _porjetoRepository.Deletar(id);
        return StatusCode(204);
      }
      catch (Exception ex)
      {
        return BadRequest();
      }
    }
  }
}