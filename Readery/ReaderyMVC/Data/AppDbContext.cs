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

    public virtual DbSet<LogUsuario> LogUsuarios { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Autor>(entity =>
        {
            entity.HasKey(e => e.IdAutor).HasName("PK__Autor__DD33B0314B1D3C35");
        });

        modelBuilder.Entity<Avaliacao>(entity =>
        {
            entity.HasKey(e => e.IdAvaliacao).HasName("PK__Avaliaca__78C432D88E114628");

            entity.HasOne(d => d.Livro).WithMany(p => p.Avaliacaos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Livro_Avaliado");

            entity.HasOne(d => d.Usuario).WithMany(p => p.Avaliacaos)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Usuario_Avaliador");
        });

        modelBuilder.Entity<Editora>(entity =>
        {
            entity.HasKey(e => e.IdEditora).HasName("PK__Editora__588BC4C625E2986B");
        });

        modelBuilder.Entity<EstadoLeitura>(entity =>
        {
            entity.HasKey(e => e.IdStatus).HasName("PK__EstadoLe__B450643AC1C664DB");
        });

        modelBuilder.Entity<Estante>(entity =>
        {
            entity.HasKey(e => e.IdEstante).HasName("PK__Estante__B0D80B0121063CC0");

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
            entity.HasKey(e => e.IdGenero).HasName("PK__Genero__0F834988FA77B93D");

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
            entity.HasKey(e => e.IdLivro).HasName("PK__Livro__3B69D85A1564EEF8");

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

        modelBuilder.Entity<LogUsuario>(entity =>
        {
            entity.HasKey(e => e.LogId).HasName("PK__LogUsuar__5E54864891325F9B");

            entity.Property(e => e.DataCadastro).HasDefaultValueSql("(dateadd(hour,(-3),sysutcdatetime()))");

            entity.HasOne(d => d.Usuario).WithMany(p => p.LogUsuarios).HasConstraintName("FK__LogUsuari__Usuar__6EF57B66");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PK__Usuario__5B65BF976F3D2489");

            entity.ToTable("Usuario", tb => tb.HasTrigger("trg_LogUsuario"));
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
