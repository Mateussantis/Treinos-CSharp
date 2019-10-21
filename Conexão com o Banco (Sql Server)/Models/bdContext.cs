using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Bd.Models
{
    public partial class bdContext : DbContext
    {
        public bdContext()
        {
        }

        public bdContext(DbContextOptions<bdContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Autor> Autor { get; set; }
        public virtual DbSet<Livro> Livro { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=KAGAMi; Database=bd; User Id=Mateussantis; Password=mateus000");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Autor>(entity =>
            {
                entity.HasKey(e => e.Idautor)
                    .HasName("PK__autor__6FC41E3C1C61C46A");

                entity.Property(e => e.Nomeautor).IsUnicode(false);
            });

            modelBuilder.Entity<Livro>(entity =>
            {
                entity.HasKey(e => e.Idlivro)
                    .HasName("PK__livro__C2F51079A76ACE91");

                entity.Property(e => e.Nomelivro).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
