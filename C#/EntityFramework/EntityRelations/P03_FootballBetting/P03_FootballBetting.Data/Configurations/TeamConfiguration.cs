namespace P03_FootballBetting.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Models;
    class TeamConfiguration : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> team)
        {
            team.HasKey(k => k.TeamId);

            team
                .Property(n => n.Name)
                .HasMaxLength(50)
                .IsRequired()
                .IsUnicode(true);

            team
                .Property(b => b.Budget)
                .IsRequired();

            team
                .Property(i => i.Initials)
                .IsRequired();

            team
                .Property(p => p.LogoUrl)
                .HasMaxLength(250)
                .IsUnicode(true)
                .IsRequired(true);

            team
                .HasOne(t => t.PrimaryKitColor)
                .WithMany(c => c.PrimaryKitTeams)
                .HasForeignKey(t => t.PrimaryKitColorId)
                .OnDelete(DeleteBehavior.Restrict);

            team
               .HasOne(t => t.SecondaryKitColor)
               .WithMany(c => c.SecondaryKitTeams)
               .HasForeignKey(t => t.SecondaryKitColorId)
               .OnDelete(DeleteBehavior.Restrict);

            team
                .HasOne(t => t.Town)
                .WithMany(fc => fc.Teams)
                .HasForeignKey(fk => fk.TownId);     
        }
    }
}