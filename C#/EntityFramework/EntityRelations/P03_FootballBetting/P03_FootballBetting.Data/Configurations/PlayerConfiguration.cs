namespace P03_FootballBetting.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Models;
    class PlayerConfiguration : IEntityTypeConfiguration<Player>
    {
        public void Configure(EntityTypeBuilder<Player> player)
        {
            player.HasKey(k => k.PlayerId);

            player
                .Property(n => n.Name)
                .HasMaxLength(50)
                .IsRequired()
                .IsUnicode(true);

            player
                .Property(s => s.SquadNumber)
                .IsRequired();

            player
                .Property(i => i.IsInjured)
                .IsRequired();

            player
                .HasOne(p => p.Team)
                .WithMany(t => t.Players)
                .HasForeignKey(fk => fk.TeamId);

            player
                .HasOne(po => po.Position)
                .WithMany(p => p.Players)
                .HasForeignKey(fk => fk.PositionId);
        }
    }
}