using Microsoft.AspNetCore.Mvc;
using PFStore.API.Models;
using PFStore.API.Data;

namespace PFStore.API.Controllers;

[ApiController]
[Route("api/[controller]")]

public class CategoriasController : ControllerBase
{
private readonly AppDbContext _context;

public CategoriasController(AppDbContext context)
{
    _context = context;
}

    [HttpGet]
    public ActionResult<List<Categoria>> GetCategoria()
    {
        return Ok(_context.Categorias.ToList());
    }

    [HttpGet("{id}")]
    public ActionResult<Categoria> GetCategoria(int id)
    {
        var categoria = _context.Categorias.Find(id);
        return categoria == null ? NotFound("Categoria não encontrada") : Ok(categoria);
    }
}
