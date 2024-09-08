using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyFirstApi.Entities;

namespace MyFirstApi.Configurations;

internal class FilmConfiguration : IEntityTypeConfiguration<FilmEntity>
{
    public void Configure(EntityTypeBuilder<FilmEntity> builder)
    {
        builder.HasKey(e => e.Id);

        builder.HasMany(e => e.ActorFilms)
            .WithOne(e => e.Film)
            .HasForeignKey(e => e.FilmId);

        builder.HasOne(e => e.Company)
            .WithMany(e => e.Films)
            .HasForeignKey(e => e.CompanyId);
    }
}