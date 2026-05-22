using Microsoft.EntityFrameworkCore;
using PFStore.API.Models;

namespace PFStore.API.Data.Seeds;

public class SeedProduto
{
        public SeedProduto(ModelBuilder modelBuilder)
    {
        List<Produto> produtos = [
            // Jogo 1
            new() {
                id = 1,
                CategoriaId = 1,
                Nome = "Call of Duty",
                Descricao = @"",
                ValorCusto = 120,
                ValorVenda = 250m,
                Quantidade = 100,
                Destaque = true,
                Foto = "/img/produtos/1.png"
            }, 
            new() {
                id = 2,
                CategoriaId = 1,
                Nome = "Tom Clancy's Rainbow Six Siege",
                Descricao = @"",
                ValorCusto = 30,
                ValorVenda = 100,
                Quantidade = 25,
                Destaque = true,
                Foto = "/img/produtos/1.png"
            }, 
            new() {
                id = 3,
                CategoriaId = 4,
                Nome = "Tetris Effect: Connected",
                Descricao = @"O clássico jogo de blocos transformado em uma viagem visual e musical relaxante.",
                ValorCusto = 15,
                ValorVenda = 70,
                Quantidade = 400,
                Destaque = true,
                Foto = "/img/produtos/1.png"
            }, 
            new() {
                id = 5,
                CategoriaId = 3,
                Nome = "It Takes Two",
                Descricao = @"Uma aventura de quebra-cabeças cooperativa feita exclusivamente para ser jogada em dupla.",
                ValorCusto = 80,
                ValorVenda = 200,
                Quantidade = 70,
                Destaque = true,
                Foto = "/img/produtos/1.png"
            }, 


        ];
        modelBuilder.Entity<Produto>().HasData(produtos);
    }
}
