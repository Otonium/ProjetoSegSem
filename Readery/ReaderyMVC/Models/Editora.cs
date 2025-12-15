using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ReaderyMVC.Models;

[Table("Editora")]
[Index("NomeEditora", Name = "UQ__Editora__27B73C15CDFD4953", IsUnique = true)]
public partial class Editora
{
    [Key]
    public int IdEditora { get; set; }

    [StringLength(100)]
    public string NomeEditora { get; set; } = null!;

    [InverseProperty("Editora")]
    public virtual ICollection<Livro> Livros { get; set; } = new List<Livro>();
}
