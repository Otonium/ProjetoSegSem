using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ReaderyMVC.Models;

[Table("Estante")]
public partial class Estante
{
    [Key]
    public int IdEstante { get; set; }

    public int? PaginaAtual { get; set; }

    public int UsuarioId { get; set; }

    public int LivroId { get; set; }

    public int StatusId { get; set; }

    [ForeignKey("LivroId")]
    [InverseProperty("Estantes")]
    public virtual Livro Livro { get; set; } = null!;

    [ForeignKey("StatusId")]
    [InverseProperty("Estantes")]
    public virtual EstadoLeitura Status { get; set; } = null!;

    [ForeignKey("UsuarioId")]
    [InverseProperty("Estantes")]
    public virtual Usuario Usuario { get; set; } = null!;
}
