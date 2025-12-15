using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ReaderyMVC.Models;

[Table("Livro")]
[Index("ISBN", Name = "UQ__Livro__447D36EAD26EA84A", IsUnique = true)]
public partial class Livro
{
    [Key]
    public int IdLivro { get; set; }

    [StringLength(150)]
    public string Titulo { get; set; } = null!;

    public string? Sinopse { get; set; }

    [StringLength(15)]
    [Unicode(false)]
    public string? ISBN { get; set; }

    public int? NumPaginas { get; set; }

    [StringLength(500)]
    public string? CapaURL { get; set; }

    public int EditoraId { get; set; }

    public int? UsuarioId { get; set; }

    [InverseProperty("Livro")]
    public virtual ICollection<Avaliacao> Avaliacaos { get; set; } = new List<Avaliacao>();

    [ForeignKey("EditoraId")]
    [InverseProperty("Livros")]
    public virtual Editora Editora { get; set; } = null!;

    [InverseProperty("Livro")]
    public virtual ICollection<Estante> Estantes { get; set; } = new List<Estante>();

    [ForeignKey("UsuarioId")]
    [InverseProperty("Livros")]
    public virtual Usuario? Usuario { get; set; }

    [ForeignKey("LivroId")]
    [InverseProperty("Livros")]
    public virtual ICollection<Autor> Autors { get; set; } = new List<Autor>();

    [ForeignKey("LivroId")]
    [InverseProperty("Livros")]
    public virtual ICollection<Genero> Generos { get; set; } = new List<Genero>();
}
