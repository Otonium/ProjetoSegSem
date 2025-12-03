using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ReaderyMVC.Models;

[Table("Usuario")]
[Index("Email", Name = "UQ__Usuario__A9D105344165C699", IsUnique = true)]
public partial class Usuario
{
    [Key]
    public int IdUsuario { get; set; }

    [StringLength(100)]
    public string Nome { get; set; } = null!;

    [StringLength(150)]
    public string Email { get; set; } = null!;

    [MaxLength(32)]
    public byte[] SenhaHash { get; set; } = null!;

    [StringLength(500)]
    public string? FotoURL { get; set; }

    [Precision(0)]
    public DateTime DataCadastro { get; set; }

    [InverseProperty("Usuario")]
    public virtual ICollection<Avaliacao> Avaliacaos { get; set; } = new List<Avaliacao>();

    [InverseProperty("Usuario")]
    public virtual ICollection<Estante> Estantes { get; set; } = new List<Estante>();

    [InverseProperty("Usuario")]
    public virtual ICollection<Livro> Livros { get; set; } = new List<Livro>();

    [InverseProperty("Usuario")]
    public virtual ICollection<LogUsuario> LogUsuarios { get; set; } = new List<LogUsuario>();
}
