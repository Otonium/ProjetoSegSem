using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ReaderyMVC.Models;

[Table("Autor")]
[Index("NomeAutor", Name = "UQ__Autor__B69C12C902045E5F", IsUnique = true)]
public partial class Autor
{
    [Key]
    public int IdAutor { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string NomeAutor { get; set; } = null!;

    [ForeignKey("AutorId")]
    [InverseProperty("Autors")]
    public virtual ICollection<Livro> Livros { get; set; } = new List<Livro>();
}
