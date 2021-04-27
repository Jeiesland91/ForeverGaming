using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ForeverGaming.Models
{
    internal class SeedGenres : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> entity)
        {
            entity.HasData(
                new Genre { GenreId = "FPS", Name = "First-Person Shooter" },
                new Genre { GenreId = "MMORPG", Name = "Massively Multiplayer Online Role-Playing Game" },
                new Genre { GenreId = "MOBAs", Name = "Mobile Online Battle Area" },
                new Genre { GenreId = "RPG", Name = "Role-Playing Game" },
                new Genre { GenreId = "RTS", Name = "Real-Time Strategy" },
                new Genre { GenreId = "SPORT", Name = "Sports" }
            );
        }
    }
}
