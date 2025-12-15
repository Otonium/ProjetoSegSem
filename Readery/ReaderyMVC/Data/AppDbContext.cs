using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ReaderyMVC.Models;

namespace ReaderyMVC.Data;

public partial class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Autor> Autors { get; set; }

    public virtual DbSet<Avaliacao> Avaliacaos { get; set; }

    public virtual DbSet<Editora> Editoras { get; set; }

    public virtual DbSet<EstadoLeitura> EstadoLeituras { get; set; }

    public virtual DbSet<Estante> Estantes { get; set; }

    public virtual DbSet<Genero> Generos { get; set; }

    public virtual DbSet<Livro> Livros { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Autor>(entity =>
        {
            entity.HasKey(e => e.IdAutor).HasName("PK__Autor__DD33B0310AB4ECFF");
        });

        modelBuilder.Entity<Avaliacao>(entity =>
        {
            entity.HasKey(e => e.IdAvaliacao).HasName("PK__Avaliaca__78C432D8F8062B6C");

            entity.HasOne(d => d.Livro).WithMany(p => p.Avaliacaos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Livro_Avaliado");

            entity.HasOne(d => d.Usuario).WithMany(p => p.Avaliacaos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Usuario_Avaliador");
        });

        modelBuilder.Entity<Editora>(entity =>
        {
            entity.HasKey(e => e.IdEditora).HasName("PK__Editora__588BC4C663F0050E");
        });

        modelBuilder.Entity<EstadoLeitura>(entity =>
        {
            entity.HasKey(e => e.IdStatus).HasName("PK__EstadoLe__B450643A98039E31");
        });

        modelBuilder.Entity<Estante>(entity =>
        {
            entity.HasKey(e => e.IdEstante).HasName("PK__Estante__B0D80B01855E219A");

            entity.HasOne(d => d.Livro).WithMany(p => p.Estantes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Livro_Estante");

            entity.HasOne(d => d.Status).WithMany(p => p.Estantes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Status_Estante");

            entity.HasOne(d => d.Usuario).WithMany(p => p.Estantes)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Usuario_Estante");
        });

        modelBuilder.Entity<Genero>(entity =>
        {
            entity.HasKey(e => e.IdGenero).HasName("PK__Genero__0F8349880B852029");

            entity.HasMany(d => d.Livros).WithMany(p => p.Generos)
                .UsingEntity<Dictionary<string, object>>(
                    "LivroGenero",
                    r => r.HasOne<Livro>().WithMany()
                        .HasForeignKey("LivroId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_Livro_Genero"),
                    l => l.HasOne<Genero>().WithMany()
                        .HasForeignKey("GeneroId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_Genero_Livro"),
                    j =>
                    {
                        j.HasKey("GeneroId", "LivroId").HasName("PK_Genero_Livro");
                        j.ToTable("LivroGenero");
                    });
        });

        modelBuilder.Entity<Livro>(entity =>
        {
            entity.HasKey(e => e.IdLivro).HasName("PK__Livro__3B69D85A16620631");

            entity.HasOne(d => d.Editora).WithMany(p => p.Livros)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Livro_Editora");

            entity.HasOne(d => d.Usuario).WithMany(p => p.Livros).HasConstraintName("FK_Criado_Por_Usuario");

            entity.HasMany(d => d.Autors).WithMany(p => p.Livros)
                .UsingEntity<Dictionary<string, object>>(
                    "LivroAutor",
                    r => r.HasOne<Autor>().WithMany()
                        .HasForeignKey("AutorId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_Autor_Livro"),
                    l => l.HasOne<Livro>().WithMany()
                        .HasForeignKey("LivroId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_Livro_Autor"),
                    j =>
                    {
                        j.HasKey("LivroId", "AutorId").HasName("PK_Autor_Livro");
                        j.ToTable("LivroAutor");
                    });
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PK__Usuario__5B65BF97C091030A");

            entity.Property(e => e.DataCadastro).HasDefaultValueSql("(dateadd(hour,(-3),sysutcdatetime()))");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
