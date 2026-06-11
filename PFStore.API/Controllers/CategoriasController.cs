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


[HttpPost]

public ActionResult <Categoria> Post([FromBody] Categoria categoria )
    {
        if(!ModelState.IsValid)
            return BadRequest("Verifique os dados informados");

            _context.Categorias.Add(categoria);
            _context.SaveChanges();
            return CreatedAtAction("GetCategoria", new { id = categoria.Id }, categoria);
    }

    [HttpPut("{id}")]
    public ActionResult PutCategoria(int id, [FromBody] Categoria categoria)
    {
        if (!ModelState.IsValid)
            return BadRequest("Verifique os dados informados");
        if(id != categoria.Id)
            return BadRequest("Verifique os dados informados");
        var oldCategoria = _context.Categorias.Find(id);
        if (oldCategoria == null )
            return NotFound("Categoria não localizada");
        oldCategoria.Nome = categoria.Nome;
        oldCategoria.Foto = categoria.Foto ?? oldCategoria.Foto;
        oldCategoria.Cor = categoria.Cor ?? oldCategoria.Cor;
        _context.Entry(oldCategoria).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        _context.SaveChanges();
        return NoContent();
    }
    [HttpDelete]

    public ActionResult DeleteCategoria(int id)
    {
        var oldCategoria = _context.Categorias.Find(id);
        if (oldCategoria == null)
            return NotFound("Categoira não localizada");
        // Poseria pesquisar se existem produtos antes de excluir
        _context.Categorias.Remove(oldCategoria);
        _context.SaveChanges();
        return NoContent();
    }          
}   

