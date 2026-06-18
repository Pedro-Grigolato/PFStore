using Microsoft.AspNetCore.Mvc;
using PFStore.API.Data;
using PFStore.API.Models;

namespace PFStore.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProdutosController : ControllerBase
{
    private readonly AppDbContext _context;

    public ProdutosController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public ActionResult<List<Produto>> GetProdutos()
    {
        return Ok(_context.Produtos.ToList());
    }

    [HttpGet("{id}")]
    public ActionResult<Produto> GetProduto(int id)
    {
        var produto = _context.Produtos.Find(id);

        if (produto == null)
            return NotFound("Produto não encontrado");

        return Ok(produto);
    }

    [HttpPost]
    public ActionResult<Produto> PostProduto([FromBody] Produto produto)
    {
        if (!ModelState.IsValid)
            return BadRequest("Verifique os dados informados");

        _context.Produtos.Add(produto);
        _context.SaveChanges();

        return CreatedAtAction(
            nameof(GetProduto),
            new {id = produto.Id },
            produto
        );
    }

    [HttpPut("{id}")]
    public ActionResult PutProduto(int id, [FromBody] Produto produto)
    {
        if (!ModelState.IsValid)
            return BadRequest("Verifique os dados informados");

        if (id != produto.Id)
            return BadRequest("ID inválido");

        var oldProduto = _context.Produtos.Find(id);

        if (oldProduto == null)
            return NotFound("Produto não encontrado");

        // Atualizar campos aqui

        _context.SaveChanges();

        return NoContent();
    }

    [HttpDelete("{id}")]
    public ActionResult DeleteProduto(int id)
    {
        var produto = _context.Produtos.Find(id);

        if (produto == null)
            return NotFound("Produto não encontrado");

        _context.Produtos.Remove(produto);
        _context.SaveChanges();

        return NoContent();
    }
}