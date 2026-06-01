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
                CategoriaId = 2,
                Nome = "Tetris Effect: Connected",
                Descricao = @"O clássico jogo de blocos transformado em uma viagem visual e musical relaxante.",
                ValorCusto = 15,
                ValorVenda = 70,
                Quantidade = 400,
                Destaque = true,
                Foto = "/img/produtos/1.png"
            }, 
            new() {
                id = 4,
                CategoriaId = 2,
                Nome = "It Takes Two",
                Descricao = @"Uma aventura de quebra-cabeças cooperativa feita exclusivamente para ser jogada em dupla.",
                ValorCusto = 80,
                ValorVenda = 200,
                Quantidade = 70,
                Destaque = true,
                Foto = "/img/produtos/1.png"
            }, 
            new() {
                id = 5,
                CategoriaId = 3,
                Nome = "NARAKA BLADEPOINT",
                Descricao = @"Combate corpo a corpo de alta intensidade para 60 jogadores. Inspirado no folclore oriental, combina o batlle royale com a precisão técnica dos jogos de luta tradicionais",
                ValorCusto = 15,
                ValorVenda = 80,
                Quantidade = 20,
                Destaque = true,
                Foto = "/img/produtos/1.png"
            }, 
            new() {
                id = 6,
                CategoriaId = 3,
                Nome = "It Takes Two",
                Descricao = @"Uma aventura de quebra-cabeças cooperativa feita exclusivamente para ser jogada em dupla.",
                ValorCusto = 80,
                ValorVenda = 200,
                Quantidade = 70,
                Destaque = true,
                Foto = "/img/produtos/1.png"
            }, 
            new() {
                id = 7,
                CategoriaId = 4,
                Nome = "Uncharted",
                Descricao = @"Acompanha um caçador de tesouros em expedições arqueológicas ao redor do mundo",
                ValorCusto = 65,
                ValorVenda = 169,
                Quantidade = 40,
                Destaque = true,
                Foto = "/img/produtos/1.png"
            }, 
            new() {
                id = 8,
                CategoriaId = 4,
                Nome = "The last of Us",
                Descricao = @"Uma jornada de sorevivência em um mundo pós apocalíptico, focada na narrativa e na relação entre os protagonistas",
                ValorCusto = 75,
                ValorVenda = 179,
                Quantidade = 32,
                Destaque = true,
                Foto = "/img/produtos/1.png"
            }, 

        ];
        modelBuilder.Entity<Produto>().HasData(produtos);
    }
}
