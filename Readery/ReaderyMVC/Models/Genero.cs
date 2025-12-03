using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ReaderyMVC.Models;

[Table("Genero")]
[Index("NomeGenero", Name = "UQ__Genero__081698E59433A497", IsUnique = true)]
public partial class Genero
{
    [Key]
    public int IdGenero { get; set; }

    [StringLength(50)]
    [Unicode(false)]
    public string NomeGenero { get; set; } = null!;

    [ForeignKey("GeneroId")]
    [InverseProperty("Generos")]
    public virtual ICollection<Livro> Livros { get; set; } = new List<Livro>();
}
