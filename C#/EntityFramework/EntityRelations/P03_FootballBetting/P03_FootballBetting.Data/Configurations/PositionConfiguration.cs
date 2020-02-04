namespace P03_FootballBetting.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using Models;
    public class PositionConfiguration : IEntityTypeConfiguration<Position>
    {
        public void Configure(EntityTypeBuilder<Position> position)
        {
            position.HasKey(k => k.PositionId);

            position
                .Property(n => n.Name)
                .HasMaxLength(50)
                .IsRequired()
                .IsUnicode(false);
        }
    }
}
