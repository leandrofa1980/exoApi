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
  }
}