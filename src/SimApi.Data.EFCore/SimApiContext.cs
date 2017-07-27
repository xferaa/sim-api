using Microsoft.EntityFrameworkCore;
using SimApi.Data.Entities;

namespace SimApi.Data.EFCore
{
    public class SimApiContext : DbContext
    {
        public SimApiContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
               .Entity<Publisher>()
               .Property(p => p.PublisherName)
               .HasMaxLength(150)
               .IsRequired();

            modelBuilder
                .Entity<Game>()
                .Property(g => g.Name)
                .HasMaxLength(150)
                .IsRequired();

            modelBuilder
                .Entity<Game>()
                .Property(g => g.ApiKey)
                .HasMaxLength(64)
                .IsRequired();

            modelBuilder
               .Entity<Game>()
               .Property(g => g.PublisherId)
               .IsRequired();

            modelBuilder
                .Entity<Game>()
                .HasOne(g => g.Publisher)
                .WithMany(p => p.Games)
                .HasForeignKey(g => g.PublisherId);


            modelBuilder
                .Entity<Player>()
                .HasIndex(p => p.Nickname)
                .IsUnique();

            modelBuilder
                .Entity<Player>()
                .HasIndex(p => p.Email)
                .IsUnique();

            modelBuilder
                .Entity<Player>()
                .Property(p => p.Nickname)
                .HasMaxLength(50)
                .IsRequired();

            modelBuilder
                .Entity<Player>()
                .Property(p => p.Email)
                .HasMaxLength(180)
                .IsRequired();

            modelBuilder
                .Entity<Player>()
                .Property(p => p.Password)
                .HasMaxLength(64)
                .IsRequired();

            modelBuilder
                .Entity<Player>()
                .Property(p => p.Salt)
                .HasMaxLength(64)
                .IsRequired();

            modelBuilder
                .Entity<Player>()
                .Property(p => p.ApiKey)
                .HasMaxLength(64);

            modelBuilder
                .Entity<Player>()
                .Property(p => p.CreatedOn)
                .IsRequired();

            modelBuilder
                .Entity<PlayerAchievement>()
                .Property(p => p.PlayerId)
                .IsRequired();

            modelBuilder
                .Entity<PlayerAchievement>()
                .Property(p => p.AchievementId)
                .IsRequired();

            modelBuilder
                .Entity<PlayerAchievement>()
                .Property(p => p.Value)
                .IsRequired();

            modelBuilder
               .Entity<PlayerAchievement>()
               .Property(p => p.AchievedOn)
               .IsRequired();

            modelBuilder
                .Entity<PlayerAchievement>()
                .HasOne(p => p.Player)
                .WithMany(p => p.PlayerAchievements)
                .HasForeignKey(p => p.PlayerId);

            modelBuilder
                .Entity<PlayerAchievement>()
                .HasOne(p => p.Achievement)
                .WithMany(p => p.PlayerAchievements)
                .HasForeignKey(p => p.AchievementId);

            modelBuilder
                .Entity<Achievement>()
                .Property(a => a.Name)
                .HasMaxLength(100)
                .IsRequired();

            modelBuilder
                .Entity<Achievement>()
                .Property(a => a.Value)
                .IsRequired();

            modelBuilder
                .Entity<Achievement>()
                .Property(a => a.GameId)
                .IsRequired();

            modelBuilder
               .Entity<Achievement>()
               .HasOne(p => p.Game)
               .WithMany(g => g.Achievements)
               .HasForeignKey(p => p.GameId);

            modelBuilder
               .Entity<PlayerHighScores>()
               .Property(p => p.PlayerId)
               .IsRequired();

            modelBuilder
                .Entity<PlayerHighScores>()
                .Property(p => p.HighScoreId)
                .IsRequired();

            modelBuilder
                .Entity<PlayerHighScores>()
                .Property(p => p.Score)
                .IsRequired();

            modelBuilder
               .Entity<PlayerHighScores>()
               .Property(p => p.AchievedOn)
               .IsRequired();

            modelBuilder
                .Entity<PlayerHighScores>()
                .HasOne(p => p.Player)
                .WithMany(p => p.PlayerHighScores)
                .HasForeignKey(p => p.PlayerId);

            modelBuilder
                .Entity<PlayerHighScores>()
                .HasOne(p => p.Player)
                .WithMany(p => p.PlayerHighScores)
                .HasForeignKey(p => p.HighScoreId);

            modelBuilder
                .Entity<HighScore>()
                .Property(a => a.Name)
                .HasMaxLength(100)
                .IsRequired();

            modelBuilder
                .Entity<HighScore>()
                .Property(a => a.GameId)
                .IsRequired();

            modelBuilder
               .Entity<HighScore>()
               .HasOne(p => p.Game)
               .WithMany(g => g.HighScores)
               .HasForeignKey(p => p.GameId);
        }

        public DbSet<Achievement> Achievements { get; set;  }
        public DbSet<Game> Games { get; set; }
        public DbSet<HighScore> HighScores { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<PlayerAchievement> PlayerAchievements { get; set; }
        public DbSet<PlayerHighScores> PlayerHighScores { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
    }
}