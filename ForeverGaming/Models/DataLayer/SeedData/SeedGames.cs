using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ForeverGaming.Models
{
    internal class SeedGames : IEntityTypeConfiguration<Game>
    {
        public void Configure(EntityTypeBuilder<Game> entity)
        {
            entity.HasData(
                new Game { GameId = 1, Name = "Doom", GenreId = "FPS", TypeId = "FPS", FormatId = "PC", GameImage = "doom.png" },
                new Game { GameId = 2, Name = "Call of Duty 4: Modern Warfare", GenreId = "FPS", TypeId = "FPS", FormatId = "CONSOLE", GameImage = "cod4.png" },
                new Game { GameId = 3, Name = "Wolfenstein: The New Order", GenreId = "FPS", TypeId = "FPS", FormatId = "CONSOLE", GameImage = "wolfenstein.png" },
                new Game { GameId = 4, Name = "Overwatch", GenreId = "FPS", TypeId = "FPS", FormatId = "PC", GameImage = "overwatch.png" },
                new Game { GameId = 5, Name = "StarCraft", GenreId = "RTS", TypeId = "FPS", FormatId = "PC", GameImage = "starcraft.png" },
                new Game { GameId = 6, Name = "Age of Empires", GenreId = "RTS", TypeId = "RTS", FormatId = "CONSOLE", GameImage = "agw.png" },
                new Game { GameId = 7, Name = "Age of Empires II: Age of King", GenreId = "RTS", TypeId = "RTS", FormatId = "CONSOLE", GameImage = "ageII.png" },
                new Game { GameId = 8, Name = "The Elder Scrolls", GenreId = "RPG", TypeId = "RTS", FormatId = "CONSOLE", GameImage = "elder.png" },
                new Game { GameId = 9, Name = "Assassin's Creed", GenreId = "RPG", TypeId = "STEALTH", FormatId = "CONSOLE", GameImage = "assassin.png" },
                new Game { GameId = 10, Name = "The Witcher 3: Wild Hunt", GenreId = "RPG", TypeId = "SRPG", FormatId = "PC", GameImage = "witcher3.png" },
                new Game { GameId = 11, Name = "EverQuest", GenreId = "MMORPG", TypeId = "SRPG", FormatId = "CONSOLE", GameImage = "everquest.png" },
                new Game { GameId = 12, Name = "World of Warcraft", GenreId = "MMORPG", TypeId = "SRPG", FormatId = "PC", GameImage = "wow.png" },
                new Game { GameId = 13, Name = "StarCraft: Legacy of the Void", GenreId = "MOBAs", TypeId = "MOBA", FormatId = "PC", GameImage = "starcraftlegacy.png" },
                new Game { GameId = 14, Name = "Defense of the Ancients", GenreId = "MOBAs", TypeId = "MOBA", FormatId = "PC", GameImage = "defense.png" },
                new Game { GameId = 15, Name = "League of Legends", GenreId = "MOBAs", TypeId = "MOBA", FormatId = "PC", GameImage = "league" },
                new Game { GameId = 16, Name = "Smite", GenreId = "MOBAs", TypeId = "MOBA", FormatId = "CONSOLE", GameImage = "smite.png" },
                new Game { GameId = 17, Name = "Heroes of the Storm", GenreId = "MOBAs", TypeId = "MOBA", FormatId = "PC", GameImage = "heroes.png" },
                new Game { GameId = 18, Name = "DOTA 2", GenreId = "MOBAs", TypeId = "MOBA", FormatId = "PC", GameImage = "dota2.png" },
                new Game { GameId = 19, Name = "Strife", GenreId = "MOBAs", TypeId = "MOBA", FormatId = "PC", GameImage = "strife" },
                new Game { GameId = 20, Name = "Vainglory", GenreId = "MOBAs", TypeId = "MOBA", FormatId = "MOBILE", GameImage = "vain.png" },
                new Game { GameId = 21, Name = "Arena of Valor", GenreId = "MOBAs", TypeId = "MOBA", FormatId = "PC", GameImage = "arena.png" },
                new Game { GameId = 22, Name = "Mobile Legends", GenreId = "MOBAs", TypeId = "MOBA", FormatId = "MOBILE", GameImage = "mobile.png" },
                new Game { GameId = 23, Name = "Battlerite", GenreId = "MOBAs", TypeId = "MOBA", FormatId = "PC", GameImage = "battlerite.png" },
                new Game { GameId = 24, Name = "Heroes of Newerth", GenreId = "MOBAs", TypeId = "MOBA", FormatId = "PC", GameImage = "heroesofnewerth.png" },
                new Game { GameId = 25, Name = "Madden NFL", GenreId = "SPORT", TypeId = "SPORT", FormatId = "CONSOLE", GameImage = "maddennfl.png" },
                new Game { GameId = 26, Name = "NBA Jam", GenreId = "SPORT", TypeId = "SPORT", FormatId = "CONSOLE", GameImage = "nbajam.png" },
                new Game { GameId = 27, Name = "Wii Sports", GenreId = "SPORT", TypeId = "SPORT", FormatId = "CONSOLE", GameImage = "wiisports.png" },
                new Game { GameId = 28, Name = "FIFA 20", GenreId = "SPORT", TypeId = "SPORT", FormatId = "CONSOLE", GameImage = "fifa20.png" },
                new Game { GameId = 29, Name = "Tony Hawk's", GenreId = "SPORT", TypeId = "SPORT", FormatId = "CONSOLE", GameImage = "tonyhawk.png" },
                new Game { GameId = 30, Name = "Fight Night Round 4", GenreId = "SPORT", TypeId = "CS", FormatId = "CONSOLE", GameImage = "fightnight.png" },
                new Game { GameId = 31, Name = "EA Sports MMA", GenreId = "SPORT", TypeId = "CS", FormatId = "CONSOLE", GameImage = "mma.png" },
                new Game { GameId = 32, Name = "UPC 2009 Undisputed", GenreId = "SPORT", TypeId = "CS", FormatId = "CONSOLE", GameImage = "upc.png" },
                new Game { GameId = 33, Name = "Fight Night Champion", GenreId = "SPORT", TypeId = "CS", FormatId = "CONSOLE", GameImage = "fightnightchampion.png" },
                new Game { GameId = 34, Name = "Gran Turismo Sport", GenreId = "SPORT", TypeId = "RACING", FormatId = "CONSOLE", GameImage = "granturismo.png" },
                new Game { GameId = 35, Name = "The Crew", GenreId = "SPORT", TypeId = "RACING", FormatId = "CONSOLE", GameImage = "crew.png" },
                new Game { GameId = 36, Name = "Forza Horizon 4", GenreId = "SPORT", TypeId = "RACING", FormatId = "CONSOLE", GameImage = "forza.png" }
            );
        }
    }
}
