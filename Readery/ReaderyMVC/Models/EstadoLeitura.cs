using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ReaderyMVC.Models;

[Table("EstadoLeitura")]
[Index("Estado", Name = "UQ__EstadoLe__36DF552FDE25A8EC", IsUnique = true)]
public partial class EstadoLeitura
{
    [Key]
    public int IdStatus { get; set; }

    [StringLength(20)]
    public string Estado { get; set; } = null!;

    [InverseProperty("Status")]
    public virtual ICollection<Estante> Estantes { get; set; } = new List<Estante>();
}
