using Exo.WebApi.Contexts;
using Exo.WebApi.Models;

namespace Exo.WebApi.Repositories
{
  public class ProjetoRepository
  {
    // Implement repository methods for Projeto entity here
    private readonly ExoContext _context;
    public ProjetoRepository(ExoContext context)
    {
      _context = context;
    }
    public List<Projeto> Listar()
    {
      return _context.Projetos.ToList();
    }
  }
}