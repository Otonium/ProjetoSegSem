using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ReaderyMVC.Models;

[Table("Avaliacao")]
public partial class Avaliacao
{
    [Key]
    public int IdAvaliacao { get; set; }

    public byte Nota { get; set; }

    [Precision(0)]
    public DateTime DataAvaliacao { get; set; }

    public int UsuarioId { get; set; }

    public int LivroId { get; set; }

    [ForeignKey("LivroId")]
    [InverseProperty("Avaliacaos")]
    public virtual Livro Livro { get; set; } = null!;

    [ForeignKey("UsuarioId")]
    [InverseProperty("Avaliacaos")]
    public virtual Usuario Usuario { get; set; } = null!;
}
