using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyFirstApi.Entities;

namespace MyFirstApi.Configurations;

internal class ActorConfiguration : IEntityTypeConfiguration<ActorEntity>
{
    public void Configure(EntityTypeBuilder<ActorEntity> builder)
    {
        builder.HasKey(e => e.Id);

        builder.HasMany(e => e.ActorFilms)
            .WithOne(e => e.Actor)
            .HasForeignKey(e => e.ActorId);
    }
}