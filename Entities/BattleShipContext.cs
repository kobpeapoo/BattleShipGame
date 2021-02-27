using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BattleShipBoard.Entities
{
    public partial class BattleShipContext : DbContext
    {
        public BattleShipContext()
        {
        }

        public BattleShipContext(DbContextOptions<BattleShipContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Attacker> Attacker { get; set; }
        public virtual DbSet<Defender> Defender { get; set; }
        public virtual DbSet<NewGame> NewGame { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=THNB-16470\\SQLEXPRESS;Database=BattleShip;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Attacker>(entity =>
            {
                entity.Property(e => e.AttackerId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DefenderId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NewGameId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShootStatus)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.NewGame)
                    .WithMany(p => p.Attacker)
                    .HasForeignKey(d => d.NewGameId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Attacker_NewGame");
            });

            modelBuilder.Entity<Defender>(entity =>
            {
                entity.Property(e => e.DefenderId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DefenderStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NewGameId)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.NewGame)
                    .WithMany(p => p.Defender)
                    .HasForeignKey(d => d.NewGameId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Defender_NewGame");
            });

            modelBuilder.Entity<NewGame>(entity =>
            {
                entity.Property(e => e.NewGameId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.AttackerWinStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.DefenderStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.EndGameDatetime).HasColumnType("datetime");

                entity.Property(e => e.StartGameDatetime).HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
