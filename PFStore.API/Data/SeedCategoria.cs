using Microsoft.EntityFrameworkCore;
using PFStore.API.Models;

namespace PFStore.API.Data.Seeds;

public class SeedCategoria
{
    public SeedCategoria(ModelBuilder modelBuilder)
    {
        List<Categoria> categorias = [
            new() {Id = 1, Nome = "FPS"},
            new() {Id = 2, Nome = "Puzzle"},
            new() {Id = 3, Nome = "Battle Royale"},
            new() {Id = 4, Nome = "Aventura"}

        ];
        modelBuilder.Entity<Categoria>().HasData(categorias);
    }
}
