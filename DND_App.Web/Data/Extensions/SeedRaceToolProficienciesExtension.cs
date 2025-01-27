using DND_App.Web.Models.Domain;
using DND_App.Web.StaticClasses;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using DND_App.Web.StaticClasses.Constants;

namespace DND_App.Web.Data.Extensions
{
    public static class SeedRaceToolProficienciesExtension
    {
        public static void SeedRaceToolProficiencies(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RaceToolProficiency>().HasData(
                new RaceToolProficiency 
                { 
                    Id = 1, 
                    Name = ToolProficiency.AlchemistsSupplies,
                    CharacterRaceId = 1 
                },
                new RaceToolProficiency 
                { 
                    Id = 2, 
                    Name = ToolProficiency.CalligraphersSupplies,
                    CharacterRaceId = 1 
                },
                new RaceToolProficiency 
                { 
                    Id = 3, 
                    Name = ToolProficiency.HerbalismKit, 
                    CharacterRaceId = 1 
                },
                new RaceToolProficiency 
                { 
                    Id = 4, 
                    Name = ToolProficiency.MusicalInstrument,
                    CharacterRaceId = 1 
                },
                new RaceToolProficiency 
                { 
                    Id = 5, 
                    Name = ToolProficiency.PaintersSupplies, 
                    CharacterRaceId = 1 
                },
                new RaceToolProficiency 
                { 
                    Id = 6, 
                    Name = ToolProficiency.SmithsTools, 
                    CharacterRaceId = 2 
                },
                new RaceToolProficiency 
                { 
                    Id = 7, 
                    Name = ToolProficiency.BrewersSupplies,
                    CharacterRaceId = 2 
                },
                new RaceToolProficiency 
                { 
                    Id = 8, 
                    Name = ToolProficiency.CalligraphersSupplies, 
                    CharacterRaceId = 2 
                },
                new RaceToolProficiency 
                { 
                    Id = 9, 
                    Name = ToolProficiency.MasonsTools, 
                    CharacterRaceId = 2 
                },
                new RaceToolProficiency 
                { 
                    Id = 10, 
                    Name = ToolProficiency.DragonchessSet,
                    CharacterRaceId = 2 
                },
                new RaceToolProficiency 
                { 
                    Id = 11, 
                    Name = ToolProficiency.SmithsTools, 
                    CharacterRaceId = 3 
                },
                new RaceToolProficiency 
                { 
                    Id = 13, 
                    Name = ToolProficiency.BrewersSupplies,
                    CharacterRaceId = 3 
                },
                new RaceToolProficiency 
                { 
                    Id = 14, 
                    Name = ToolProficiency.MasonsTools, 
                    CharacterRaceId = 3 
                },
                new RaceToolProficiency 
                { 
                    Id = 15, 
                    Name = ToolProficiency.HerbalismKit, 
                    CharacterRaceId = 4 
                },
                new RaceToolProficiency 
                { 
                    Id = 16, 
                    Name = ToolProficiency.CalligraphersSupplies,
                    CharacterRaceId = 4 
                },
                new RaceToolProficiency 
                { 
                    Id = 17, 
                    Name = ToolProficiency.MusicalInstrument, 
                    CharacterRaceId = 4 
                },
                new RaceToolProficiency 
                { 
                    Id = 18, 
                    Name = ToolProficiency.PaintersSupplies, 
                    CharacterRaceId = 4 
                },
                new RaceToolProficiency 
                { 
                    Id = 19, 
                    Name = ToolProficiency.AlchemistsSupplies, 
                    CharacterRaceId = 4 
                },
                new RaceToolProficiency 
                { 
                    Id = 20, 
                    Name = ToolProficiency.HerbalismKit, 
                    CharacterRaceId = 5 
                },
                new RaceToolProficiency 
                { 
                    Id = 21, 
                    Name = ToolProficiency.CarpenterTools, 
                    CharacterRaceId = 5
                },
                new RaceToolProficiency 
                { 
                    Id = 22, 
                    Name = ToolProficiency.CooksUtensils, 
                    CharacterRaceId = 5 
                },
                new RaceToolProficiency 
                { 
                    Id = 23, 
                    Name = ToolProficiency.MasonsTools, 
                    CharacterRaceId = 5 
                },
                new RaceToolProficiency 
                { 
                    Id = 24, 
                    Name = ToolProficiency.PaintersSupplies, 
                    CharacterRaceId = 5 
                },
                new RaceToolProficiency 
                { 
                    Id = 25, 
                    Name = ToolProficiency.NavigatorsTools, 
                    CharacterRaceId = 6 
                },
                new RaceToolProficiency 
                { 
                    Id = 26, 
                    Name = ToolProficiency.CartographerTools, 
                    CharacterRaceId = 6 
                },
                new RaceToolProficiency 
                { 
                    Id = 27, 
                    Name = ToolProficiency.TinkersTools, 
                    CharacterRaceId = 6 
                },
                new RaceToolProficiency 
                { 
                    Id = 28, 
                    Name = ToolProficiency.Flute, 
                    CharacterRaceId = 6 
                },
                new RaceToolProficiency 
                { 
                    Id = 29, 
                    Name = ToolProficiency.CalligraphersSupplies,
                    CharacterRaceId = 6 
                },
                new RaceToolProficiency 
                { 
                    Id = 30, 
                    Name = ToolProficiency.SmithsTools, 
                    CharacterRaceId = 7 
                },
                new RaceToolProficiency 
                { 
                    Id = 31, 
                    Name = ToolProficiency.MasonsTools, 
                    CharacterRaceId = 7 
                },
                new RaceToolProficiency 
                { 
                    Id = 32, 
                    Name = ToolProficiency.MinersTools, 
                    CharacterRaceId = 7 
                },
                new RaceToolProficiency 
                { 
                    Id = 33, 
                    Name = ToolProficiency.PottersTools, 
                    CharacterRaceId = 7 
                },
                new RaceToolProficiency 
                { 
                    Id = 34, 
                    Name = ToolProficiency.CartographerTools,
                    CharacterRaceId = 7 
                },
                new RaceToolProficiency 
                { 
                    Id = 35, 
                    Name = ToolProficiency.AlchemistsSupplies,
                    CharacterRaceId = 8 
                },
                new RaceToolProficiency 
                { 
                    Id = 36, 
                    Name = ToolProficiency.GlassblowersTools, 
                    CharacterRaceId = 8 
                },
                new RaceToolProficiency 
                { 
                    Id = 37, 
                    Name = ToolProficiency.SmithsTools, 
                    CharacterRaceId = 8 
                },
                new RaceToolProficiency 
                { 
                    Id = 38, 
                    Name = ToolProficiency.CooksUtensils,
                    CharacterRaceId = 8 
                },
                new RaceToolProficiency 
                { 
                    Id = 39, 
                    Name = ToolProficiency.BrewersSupplies,
                    CharacterRaceId = 8 
                },
                new RaceToolProficiency 
                { 
                    Id = 40, 
                    Name = ToolProficiency.NavigatorsTools,
                    CharacterRaceId = 9 
                },
                new RaceToolProficiency 
                { 
                    Id = 41, 
                    Name = ToolProficiency.FishingTackle,
                    CharacterRaceId = 9 
                },
                new RaceToolProficiency 
                { 
                    Id = 42, 
                    Name = ToolProficiency.CartographerTools,
                    CharacterRaceId = 9 
                },
                new RaceToolProficiency 
                { 
                    Id = 43, 
                    Name = ToolProficiency.CooksUtensils,
                    CharacterRaceId = 9 
                },
                new RaceToolProficiency 
                { 
                    Id = 44, 
                    Name = ToolProficiency.BrewersSupplies,
                    CharacterRaceId = 9 
                },
                new RaceToolProficiency 
                { 
                    Id = 45, 
                    Name = ToolProficiency.TinkersTools, 
                    CharacterRaceId = 10 
                },
                new RaceToolProficiency 
                { 
                    Id = 46, 
                    Name = ToolProficiency.AlchemistsSupplies,
                    CharacterRaceId = 10 
                },
                new RaceToolProficiency 
                { 
                    Id = 47, 
                    Name = ToolProficiency.ArtisansTools,
                    CharacterRaceId = 10 
                },
                new RaceToolProficiency 
                { 
                    Id = 48, 
                    Name = ToolProficiency.CartographerTools,
                    CharacterRaceId = 10 
                },
                new RaceToolProficiency 
                { 
                    Id = 49, 
                    Name = ToolProficiency.PaintersSupplies,
                    CharacterRaceId = 10 
                },
                new RaceToolProficiency 
                { 
                    Id = 50, 
                    Name = ToolProficiency.SmithsTools, 
                    CharacterRaceId = 11 
                },
                new RaceToolProficiency 
                { 
                    Id = 51, 
                    Name = ToolProficiency.MasonsTools, 
                    CharacterRaceId = 11 
                },
                new RaceToolProficiency 
                { 
                    Id = 52, 
                    Name = ToolProficiency.CarpenterTools,
                    CharacterRaceId = 11 
                },
                new RaceToolProficiency 
                { 
                    Id = 53, 
                    Name = ToolProficiency.CooksUtensils,
                    CharacterRaceId = 11 
                },
                new RaceToolProficiency 
                { 
                    Id = 54, 
                    Name = ToolProficiency.BrewersSupplies,
                    CharacterRaceId = 11 
                },
                new RaceToolProficiency 
                { 
                    Id = 55, 
                    Name = ToolProficiency.Fiddle, 
                    CharacterRaceId = 12 
                },
                new RaceToolProficiency 
                { 
                    Id = 56, 
                    Name = ToolProficiency.CalligraphersSupplies,
                    CharacterRaceId = 12 
                },
                new RaceToolProficiency 
                { 
                    Id = 57, 
                    Name = ToolProficiency.PaintersSupplies,
                    CharacterRaceId = 12 
                },
                new RaceToolProficiency 
                { 
                    Id = 58, 
                    Name = ToolProficiency.AlchemistsSupplies,
                    CharacterRaceId = 12 
                },
                new RaceToolProficiency 
                { 
                    Id = 59, 
                    Name = ToolProficiency.JewelersTools,
                    CharacterRaceId = 12 
                },
                new RaceToolProficiency 
                { 
                    Id = 60, 
                    Name = ToolProficiency.CooksUtensils,
                    CharacterRaceId = 13 
                },
                new RaceToolProficiency 
                { 
                    Id = 61, 
                    Name = ToolProficiency.BrewersSupplies,
                    CharacterRaceId = 13 
                },
                new RaceToolProficiency 
                { Id = 62, 
                    Name = ToolProficiency.WeaversTools, 
                    CharacterRaceId = 13 
                },
                new RaceToolProficiency 
                { 
                    Id = 63, 
                    Name = ToolProficiency.WoodcarversTools,
                    CharacterRaceId = 13 
                },
                new RaceToolProficiency 
                { 
                    Id = 64, 
                    Name = ToolProficiency.HerbalismKit, 
                    CharacterRaceId = 13 
                },
                new RaceToolProficiency 
                { 
                    Id = 65, 
                    Name = ToolProficiency.SmithsTools, 
                    CharacterRaceId = 14 
                },
                new RaceToolProficiency 
                { 
                    Id = 66, 
                    Name = ToolProficiency.LeatherworkerTools,
                    CharacterRaceId = 14 
                },
                new RaceToolProficiency 
                { 
                    Id = 67, 
                    Name = ToolProficiency.CarpenterTools,
                    CharacterRaceId = 14 
                },
                new RaceToolProficiency 
                { 
                    Id = 68,
                    Name = ToolProficiency.CooksUtensils,
                    CharacterRaceId = 14 
                },
                new RaceToolProficiency 
                { 
                    Id = 69, 
                    Name = ToolProficiency.BrewersSupplies,
                    CharacterRaceId = 14 
                },
                new RaceToolProficiency 
                { 
                    Id = 70, 
                    Name = ToolProficiency.SmithsTools, 
                    CharacterRaceId = 15 
                },
                new RaceToolProficiency 
                { 
                    Id = 71, 
                    Name = ToolProficiency.FarmersTools, 
                    CharacterRaceId = 15 
                },
                new RaceToolProficiency 
                { 
                    Id = 72, 
                    Name = ToolProficiency.MasonsTools, 
                    CharacterRaceId = 15 
                },
                new RaceToolProficiency 
                { 
                    Id = 73, 
                    Name = ToolProficiency.BrewersSupplies,
                    CharacterRaceId = 15 
                },
                new RaceToolProficiency 
                { 
                    Id = 74, 
                    Name = ToolProficiency.HerbalismKit, 
                    CharacterRaceId = 15 
                },
                new RaceToolProficiency 
                { 
                    Id = 75, 
                    Name = ToolProficiency.CalligraphersSupplies,
                    CharacterRaceId = 16 
                },
                new RaceToolProficiency 
                { 
                    Id = 76, 
                    Name = ToolProficiency.DisguiseKit, 
                    CharacterRaceId = 16 
                },
                new RaceToolProficiency 
                { 
                    Id = 77, 
                    Name = ToolProficiency.TinkersTools, 
                    CharacterRaceId = 16 
                },
                new RaceToolProficiency 
                { 
                    Id = 78, 
                    Name = ToolProficiency.ThievesTools, 
                    CharacterRaceId = 16 
                },
                new RaceToolProficiency 
                { 
                    Id = 79, 
                    Name = ToolProficiency.PaintersSupplies,
                    CharacterRaceId = 16 
                },
                new RaceToolProficiency 
                { 
                    Id = 80, 
                    Name = ToolProficiency.CartographerTools,
                    CharacterRaceId = 17 
                },
                new RaceToolProficiency 
                { 
                    Id = 81, 
                    Name = ToolProficiency.CalligraphersSupplies,
                    CharacterRaceId = 17 
                },
                new RaceToolProficiency 
                { 
                    Id = 82, 
                    Name = ToolProficiency.PaintersSupplies,
                    CharacterRaceId = 17 
                },
                new RaceToolProficiency 
                { 
                    Id = 83, 
                    Name = ToolProficiency.Drums, 
                    CharacterRaceId = 17 
                },
                new RaceToolProficiency 
                { 
                    Id = 84, 
                    Name = ToolProficiency.ThievesTools, 
                    CharacterRaceId = 17 
                },
                new RaceToolProficiency 
                { 
                    Id = 85, 
                    Name = ToolProficiency.AlchemistsSupplies,
                    CharacterRaceId = 18 
                },
                new RaceToolProficiency 
                { 
                    Id = 86, 
                    Name = ToolProficiency.CalligraphersSupplies,
                    CharacterRaceId = 18 
                },
                new RaceToolProficiency 
                { 
                    Id = 87, 
                    Name = ToolProficiency.DisguiseKit, 
                    CharacterRaceId = 18 
                },
                new RaceToolProficiency 
                { 
                    Id = 88, 
                    Name = ToolProficiency.Lyre, 
                    CharacterRaceId = 18 
                },
                new RaceToolProficiency 
                { 
                    Id = 89, 
                    Name = ToolProficiency.ForgeryKit, 
                    CharacterRaceId = 18 
                },
                new RaceToolProficiency 
                { 
                    Id = 90, 
                    Name = ToolProficiency.MasonsTools, 
                    CharacterRaceId = 19 
                },
                new RaceToolProficiency 
                { 
                    Id = 91, 
                    Name = ToolProficiency.CarpenterTools,
                    CharacterRaceId = 19 
                },
                new RaceToolProficiency 
                { 
                    Id = 92, 
                    Name = ToolProficiency.CooksUtensils,
                    CharacterRaceId = 19 
                },
                new RaceToolProficiency 
                { 
                    Id = 93, 
                    Name = ToolProficiency.FishingTackle,
                    CharacterRaceId = 19 
                },
                new RaceToolProficiency 
                { 
                    Id = 94, 
                    Name = ToolProficiency.HerbalismKit, 
                    CharacterRaceId = 19 
                },
                new RaceToolProficiency 
                { 
                    Id = 95, 
                    Name = ToolProficiency.PoisonersKit, 
                    CharacterRaceId = 20 
                },
                new RaceToolProficiency 
                { 
                    Id = 96, 
                    Name = ToolProficiency.AlchemistsSupplies,
                    CharacterRaceId = 20 
                },
                new RaceToolProficiency 
                { 
                    Id = 97, 
                    Name = ToolProficiency.DisguiseKit,
                    CharacterRaceId = 20 
                },
                new RaceToolProficiency 
                { 
                    Id = 98, 
                    Name = ToolProficiency.ForgeryKit, 
                    CharacterRaceId = 20 
                },
                new RaceToolProficiency
                {
                    Id = 99,
                    Name = ToolProficiency.CalligraphersSupplies,
                    CharacterRaceId = 20
                }
            );
        }
    }
}
