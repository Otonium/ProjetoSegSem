using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ReaderyMVC.Models;

[Table("LogUsuario")]
public partial class LogUsuario
{
    [Key]
    public int LogId { get; set; }

    public int? UsuarioId { get; set; }

    [StringLength(100)]
    public string? Nome { get; set; }

    [Precision(0)]
    public DateTime? DataCadastro { get; set; }

    [ForeignKey("UsuarioId")]
    [InverseProperty("LogUsuarios")]
    public virtual Usuario? Usuario { get; set; }
}
