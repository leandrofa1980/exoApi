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
    // Código para implementar o CRUD
    public void Cadastrar(Projeto projeto)
    {
      _context.Projetos.Add(projeto);
      _context.SaveChanges();
    }
    public Projeto BuscarPorId(int id)
    {
      return _context.Projetos.Find(id);
    }
    public void Atualizar(int id, Projeto projeto)
    {
      Projeto buscarProjeto = _context.Projetos.Find(id);
      if (buscarProjeto != null)
      {
        buscarProjeto.NomeDoProjeto = projeto.NomeDoProjeto;
        buscarProjeto.Area = projeto.Area;
        buscarProjeto.Status = projeto.Status;
      }
      _context.Projetos.Update(buscarProjeto);
      _context.SaveChanges();
    }
    public void Deletar(int id)
    {
      Projeto buscarProjeto = _context.Projetos.Find(id);
      _context.Projetos.Remove(buscarProjeto);
      _context.SaveChanges();
    }
  }
}