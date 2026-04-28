using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PFStore.API.Models;

[Table("Produtos")]
public class Produto
{
    [Key]
    public int id { get; set; }

    [Required]
    public int CategoriaId { get; set; }
    [ForeignKey(nameof(CategoriaId))]

    public Categoria Categoria { get; set; }

    [Required]
    [StringLength(100)]

    public string Nome { get; set; }

    [StringLength(300)]
    public string Descricao { get; set; }

    [Required]
    public int Quantidade { get; set; } = 0;

    [Required]
    [Column(TypeName = "decimal(12,2)")]
    public decimal ValorCusto { get; set; } = 0;

    [Required]
    [Column(TypeName = "decimal(12,2)")]
    public decimal ValorVenda { get; set; } = 0;

    public bool Destaque { get; set; } = false;

    [StringLength(300)]
    public string Foto { get; set; }

}

