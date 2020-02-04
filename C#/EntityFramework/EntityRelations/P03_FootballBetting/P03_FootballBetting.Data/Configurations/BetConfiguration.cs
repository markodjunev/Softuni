namespace P03_FootballBetting.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Models;
    class BetConfiguration : IEntityTypeConfiguration<Bet>
    {
        public void Configure(EntityTypeBuilder<Bet> bet)
        {
            bet
                .HasKey(k => k.BetId);

            bet
                .Property(a => a.Amount)
                .IsRequired(true);

            bet
                .Property(d => d.DateTime)
                .IsRequired(true);

            bet
                .Property(p => p.Prediction)
                .HasMaxLength(200)
                .IsRequired(true);

            bet
                .HasOne(u => u.User)
                .WithMany(b => b.Bets)
                .HasForeignKey(u => u.UserId);

            bet
                .HasOne(g => g.Game)
                .WithMany(b => b.Bets)
                .HasForeignKey(fk => fk.GameId);
        }
    }
}