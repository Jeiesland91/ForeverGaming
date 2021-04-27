using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ForeverGaming.Migrations
{
    public partial class InitialDatabaseCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Firstname = table.Column<string>(nullable: true),
                    Lastname = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Formats",
                columns: table => new
                {
                    FormatId = table.Column<string>(maxLength: 10, nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Formats", x => x.FormatId);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    GenreId = table.Column<string>(maxLength: 10, nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.GenreId);
                });

            migrationBuilder.CreateTable(
                name: "Types",
                columns: table => new
                {
                    TypeId = table.Column<string>(maxLength: 10, nullable: false),
                    Name = table.Column<string>(maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Types", x => x.TypeId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    GameId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    GenreId = table.Column<string>(nullable: false),
                    TypeId = table.Column<string>(nullable: false),
                    FormatId = table.Column<string>(nullable: false),
                    GameImage = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.GameId);
                    table.ForeignKey(
                        name: "FK_Games_Formats_FormatId",
                        column: x => x.FormatId,
                        principalTable: "Formats",
                        principalColumn: "FormatId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Games_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "GenreId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Games_Types_TypeId",
                        column: x => x.TypeId,
                        principalTable: "Types",
                        principalColumn: "TypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Formats",
                columns: new[] { "FormatId", "Name" },
                values: new object[,]
                {
                    { "ARCADE", "Arcade Game" },
                    { "CONSOLE", "Gaming console" },
                    { "MOBILE", "Mobile Device" },
                    { "PC", "Personal Computer" },
                    { "STREAMING", "Streaming" },
                    { "TV", "Television" },
                    { "VIRTUAL", "Virtual Reality" },
                    { "WEB", "Web Browser" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "GenreId", "Name" },
                values: new object[,]
                {
                    { "RTS", "Real-Time Strategy" },
                    { "RPG", "Role-Playing Game" },
                    { "SPORT", "Sports" },
                    { "MMORPG", "Massively Multiplayer Online Role-Playing Game" },
                    { "FPS", "First-Person Shooter" },
                    { "MOBAs", "Mobile Online Battle Area" }
                });

            migrationBuilder.InsertData(
                table: "Types",
                columns: new[] { "TypeId", "Name" },
                values: new object[,]
                {
                    { "RP", "Role-Play" },
                    { "SRPG", "Sandbox RPGs" },
                    { "SIM", "Simulation" },
                    { "SPORT", "Sport Games" },
                    { "STEALTH", "Stealth" },
                    { "STRATEGY", "Strategy" },
                    { "SURVIVAL", "Survival" },
                    { "TFPS", "Tactical FPS" },
                    { "TRP", "Tactical Role-Play" },
                    { "TS", "Team Sports" },
                    { "TEXT", "Text" },
                    { "RHYTHM", "Rhythm" },
                    { "SH", "Survival Horror" },
                    { "RTS", "Real Time Strategy" },
                    { "LS", "Life Sim" },
                    { "PUZZLE", "Puzzle" },
                    { "PF", "Platformer" },
                    { "PG", "Party Games" },
                    { "MOBA", "Mobile Online Battle Area" },
                    { "MMORPG", "Massively Multiplayer Online Role-Playing Game" },
                    { "TD", "Tower Defense" },
                    { "IM", "Interactive Movie" },
                    { "GS", "Grand Strategy" },
                    { "FPS", "First Person Shooter" },
                    { "FIGHTING", "Fighting" },
                    { "EX", "Exercise" },
                    { "ED", "Educational" },
                    { "CS", "Combat Sports" },
                    { "CB", "City-Building" },
                    { "RACING", "Racing" },
                    { "TRIVIA", "Trivia" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameId", "FormatId", "GameImage", "GenreId", "Name", "TypeId" },
                values: new object[,]
                {
                    { 30, "CONSOLE", "fightnight.png", "SPORT", "Fight Night Round 4", "CS" },
                    { 24, "PC", "heroesofnewerth.png", "MOBAs", "Heroes of Newerth", "MOBA" },
                    { 34, "CONSOLE", "granturismo.png", "SPORT", "Gran Turismo Sport", "RACING" },
                    { 35, "CONSOLE", "crew.png", "SPORT", "The Crew", "RACING" },
                    { 36, "CONSOLE", "forza.png", "SPORT", "Forza Horizon 4", "RACING" },
                    { 6, "CONSOLE", "agw.png", "RTS", "Age of Empires", "RTS" },
                    { 7, "CONSOLE", "ageII.png", "RTS", "Age of Empires II: Age of King", "RTS" },
                    { 23, "PC", "battlerite.png", "MOBAs", "Battlerite", "MOBA" },
                    { 8, "CONSOLE", "elder.png", "RPG", "The Elder Scrolls", "RTS" },
                    { 11, "CONSOLE", "everquest.png", "MMORPG", "EverQuest", "SRPG" },
                    { 12, "PC", "wow.png", "MMORPG", "World of Warcraft", "SRPG" },
                    { 25, "CONSOLE", "maddennfl.png", "SPORT", "Madden NFL", "SPORT" },
                    { 26, "CONSOLE", "nbajam.png", "SPORT", "NBA Jam", "SPORT" },
                    { 27, "CONSOLE", "wiisports.png", "SPORT", "Wii Sports", "SPORT" },
                    { 28, "CONSOLE", "fifa20.png", "SPORT", "FIFA 20", "SPORT" },
                    { 10, "PC", "witcher3.png", "RPG", "The Witcher 3: Wild Hunt", "SRPG" },
                    { 22, "MOBILE", "mobile.png", "MOBAs", "Mobile Legends", "MOBA" },
                    { 21, "PC", "arena.png", "MOBAs", "Arena of Valor", "MOBA" },
                    { 20, "MOBILE", "vain.png", "MOBAs", "Vainglory", "MOBA" },
                    { 31, "CONSOLE", "mma.png", "SPORT", "EA Sports MMA", "CS" },
                    { 32, "CONSOLE", "upc.png", "SPORT", "UPC 2009 Undisputed", "CS" },
                    { 33, "CONSOLE", "fightnightchampion.png", "SPORT", "Fight Night Champion", "CS" },
                    { 1, "PC", "doom.png", "FPS", "Doom", "FPS" },
                    { 2, "CONSOLE", "cod4.png", "FPS", "Call of Duty 4: Modern Warfare", "FPS" },
                    { 3, "CONSOLE", "wolfenstein.png", "FPS", "Wolfenstein: The New Order", "FPS" },
                    { 4, "PC", "overwatch.png", "FPS", "Overwatch", "FPS" },
                    { 5, "PC", "starcraft.png", "RTS", "StarCraft", "FPS" },
                    { 13, "PC", "starcraftlegacy.png", "MOBAs", "StarCraft: Legacy of the Void", "MOBA" },
                    { 14, "PC", "defense.png", "MOBAs", "Defense of the Ancients", "MOBA" },
                    { 15, "PC", "league", "MOBAs", "League of Legends", "MOBA" },
                    { 16, "CONSOLE", "smite.png", "MOBAs", "Smite", "MOBA" },
                    { 17, "PC", "heroes.png", "MOBAs", "Heroes of the Storm", "MOBA" },
                    { 18, "PC", "dota2.png", "MOBAs", "DOTA 2", "MOBA" },
                    { 19, "PC", "strife", "MOBAs", "Strife", "MOBA" },
                    { 29, "CONSOLE", "tonyhawk.png", "SPORT", "Tony Hawk's", "SPORT" },
                    { 9, "CONSOLE", "assassin.png", "RPG", "Assassin's Creed", "STEALTH" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Games_FormatId",
                table: "Games",
                column: "FormatId");

            migrationBuilder.CreateIndex(
                name: "IX_Games_GenreId",
                table: "Games",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Games_TypeId",
                table: "Games",
                column: "TypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Games");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Formats");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Types");
        }
    }
}
