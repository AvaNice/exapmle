using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyFirstApi.Entities;

namespace MyFirstApi.Configurations;

internal class ActorFilmConfiguration : IEntityTypeConfiguration<ActorFilmEntity>
{
    public void Configure(EntityTypeBuilder<ActorFilmEntity> builder)
    {
        builder.HasKey(e => new { e.ActorId, e.FilmId });

        builder.HasOne(e => e.Actor)
            .WithMany(e => e.ActorFilms)
            .HasForeignKey(e => e.ActorId);

        builder.HasOne(e => e.Film)
            .WithMany(e => e.ActorFilms)
            .HasForeignKey(e => e.FilmId);
    }
}