namespace P03_FootballBetting.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Models;
    public class TownConfiguration : IEntityTypeConfiguration<Town>
    {
        public void Configure(EntityTypeBuilder<Town> town)
        {
            town.HasKey(k => k.TownId);

            town
                .Property(n => n.Name)
                .HasMaxLength(50)
                .IsRequired()
                .IsUnicode(false);

            town
                .HasOne(t => t.Country)
                .WithMany(c => c.Towns)
                .HasForeignKey(t => t.CountryId);
        }
    }
}