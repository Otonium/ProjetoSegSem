using System;
using System.Collections.Generic;

namespace ReaderyMVC.Models;

public partial class Usuario
{
    public int IdUsuario { get; set; }

    public string Nome { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string SenhaHash { get; set; } = null!;

    public string? GeneroUsuario { get; set; }

    public string? DescricaoUsuario { get; set; }

    public string? FotoURL { get; set; }

    public DateTime DataCadastro { get; set; }

    public virtual ICollection<Avaliacao> Avaliacaos { get; set; } = new List<Avaliacao>();

    public virtual ICollection<Estante> Estantes { get; set; } = new List<Estante>();

    public virtual ICollection<Livro> Livros { get; set; } = new List<Livro>();

}
