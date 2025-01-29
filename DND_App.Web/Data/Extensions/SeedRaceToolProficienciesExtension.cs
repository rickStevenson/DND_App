using DND_App.Web.Models.Domain;
using DND_App.Web.StaticClasses;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using DND_App.Web.StaticClasses;

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
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.AlchemistsSupplies),
                    CharacterRaceId = 1 
                },
                new RaceToolProficiency 
                { 
                    Id = 2, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.CalligraphersSupplies),
                    CharacterRaceId = 1 
                },
                new RaceToolProficiency 
                { 
                    Id = 3, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.HerbalismKit), 
                    CharacterRaceId = 1 
                },
                new RaceToolProficiency 
                { 
                    Id = 4, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.MusicalInstrument),
                    CharacterRaceId = 1 
                },
                new RaceToolProficiency 
                { 
                    Id = 5, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.PaintersSupplies), 
                    CharacterRaceId = 1 
                },
                new RaceToolProficiency 
                { 
                    Id = 6, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.SmithsTools), 
                    CharacterRaceId = 2 
                },
                new RaceToolProficiency 
                { 
                    Id = 7, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.BrewersSupplies),
                    CharacterRaceId = 2 
                },
                new RaceToolProficiency 
                { 
                    Id = 8, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.CalligraphersSupplies), 
                    CharacterRaceId = 2 
                },
                new RaceToolProficiency 
                { 
                    Id = 9, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.MasonsTools), 
                    CharacterRaceId = 2 
                },
                new RaceToolProficiency 
                { 
                    Id = 10, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.DragonchessSet),
                    CharacterRaceId = 2 
                },
                new RaceToolProficiency 
                { 
                    Id = 11, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.SmithsTools), 
                    CharacterRaceId = 3 
                },
                new RaceToolProficiency 
                { 
                    Id = 13, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.BrewersSupplies),
                    CharacterRaceId = 3 
                },
                new RaceToolProficiency 
                { 
                    Id = 14, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.MasonsTools), 
                    CharacterRaceId = 3 
                },
                new RaceToolProficiency 
                { 
                    Id = 15, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.HerbalismKit), 
                    CharacterRaceId = 4 
                },
                new RaceToolProficiency 
                { 
                    Id = 16, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.CalligraphersSupplies),
                    CharacterRaceId = 4 
                },
                new RaceToolProficiency 
                { 
                    Id = 17, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.MusicalInstrument), 
                    CharacterRaceId = 4 
                },
                new RaceToolProficiency 
                { 
                    Id = 18, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.PaintersSupplies), 
                    CharacterRaceId = 4 
                },
                new RaceToolProficiency 
                { 
                    Id = 19, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.AlchemistsSupplies), 
                    CharacterRaceId = 4 
                },
                new RaceToolProficiency 
                { 
                    Id = 20, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.HerbalismKit), 
                    CharacterRaceId = 5 
                },
                new RaceToolProficiency 
                { 
                    Id = 21, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.CarpenterTools), 
                    CharacterRaceId = 5
                },
                new RaceToolProficiency 
                { 
                    Id = 22, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.CooksUtensils), 
                    CharacterRaceId = 5 
                },
                new RaceToolProficiency 
                { 
                    Id = 23, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.MasonsTools), 
                    CharacterRaceId = 5 
                },
                new RaceToolProficiency 
                { 
                    Id = 24, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.PaintersSupplies), 
                    CharacterRaceId = 5 
                },
                new RaceToolProficiency 
                { 
                    Id = 25, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.NavigatorsTools), 
                    CharacterRaceId = 6 
                },
                new RaceToolProficiency 
                { 
                    Id = 26, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.CartographerTools), 
                    CharacterRaceId = 6 
                },
                new RaceToolProficiency 
                { 
                    Id = 27, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.TinkersTools), 
                    CharacterRaceId = 6 
                },
                new RaceToolProficiency 
                { 
                    Id = 28, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.Flute), 
                    CharacterRaceId = 6 
                },
                new RaceToolProficiency 
                { 
                    Id = 29, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.CalligraphersSupplies),
                    CharacterRaceId = 6 
                },
                new RaceToolProficiency 
                { 
                    Id = 30, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.SmithsTools), 
                    CharacterRaceId = 7 
                },
                new RaceToolProficiency 
                { 
                    Id = 31, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.MasonsTools), 
                    CharacterRaceId = 7 
                },
                new RaceToolProficiency 
                { 
                    Id = 32, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.MinersTools), 
                    CharacterRaceId = 7 
                },
                new RaceToolProficiency 
                { 
                    Id = 33, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.PottersTools), 
                    CharacterRaceId = 7 
                },
                new RaceToolProficiency 
                { 
                    Id = 34, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.CartographerTools),
                    CharacterRaceId = 7 
                },
                new RaceToolProficiency 
                { 
                    Id = 35, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.AlchemistsSupplies),
                    CharacterRaceId = 8 
                },
                new RaceToolProficiency 
                { 
                    Id = 36, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.GlassblowersTools), 
                    CharacterRaceId = 8 
                },
                new RaceToolProficiency 
                { 
                    Id = 37, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.SmithsTools), 
                    CharacterRaceId = 8 
                },
                new RaceToolProficiency 
                { 
                    Id = 38, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.CooksUtensils),
                    CharacterRaceId = 8 
                },
                new RaceToolProficiency 
                { 
                    Id = 39, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.BrewersSupplies),
                    CharacterRaceId = 8 
                },
                new RaceToolProficiency 
                { 
                    Id = 40, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.NavigatorsTools),
                    CharacterRaceId = 9 
                },
                new RaceToolProficiency 
                { 
                    Id = 41, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.FishingTackle),
                    CharacterRaceId = 9 
                },
                new RaceToolProficiency 
                { 
                    Id = 42, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.CartographerTools),
                    CharacterRaceId = 9 
                },
                new RaceToolProficiency 
                { 
                    Id = 43, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.CooksUtensils),
                    CharacterRaceId = 9 
                },
                new RaceToolProficiency 
                { 
                    Id = 44, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.BrewersSupplies),
                    CharacterRaceId = 9 
                },
                new RaceToolProficiency 
                { 
                    Id = 45, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.TinkersTools), 
                    CharacterRaceId = 10 
                },
                new RaceToolProficiency 
                { 
                    Id = 46, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.AlchemistsSupplies),
                    CharacterRaceId = 10 
                },
                new RaceToolProficiency 
                { 
                    Id = 47, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.ArtisansTools),
                    CharacterRaceId = 10 
                },
                new RaceToolProficiency 
                { 
                    Id = 48, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.CartographerTools),
                    CharacterRaceId = 10 
                },
                new RaceToolProficiency 
                { 
                    Id = 49, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.PaintersSupplies),
                    CharacterRaceId = 10 
                },
                new RaceToolProficiency 
                { 
                    Id = 50, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.SmithsTools), 
                    CharacterRaceId = 11 
                },
                new RaceToolProficiency 
                { 
                    Id = 51, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.MasonsTools), 
                    CharacterRaceId = 11 
                },
                new RaceToolProficiency 
                { 
                    Id = 52, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.CarpenterTools),
                    CharacterRaceId = 11 
                },
                new RaceToolProficiency 
                { 
                    Id = 53, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.CooksUtensils),
                    CharacterRaceId = 11 
                },
                new RaceToolProficiency 
                { 
                    Id = 54, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.BrewersSupplies),
                    CharacterRaceId = 11 
                },
                new RaceToolProficiency 
                { 
                    Id = 55, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.Fiddle), 
                    CharacterRaceId = 12 
                },
                new RaceToolProficiency 
                { 
                    Id = 56, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.CalligraphersSupplies),
                    CharacterRaceId = 12 
                },
                new RaceToolProficiency 
                { 
                    Id = 57, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.PaintersSupplies),
                    CharacterRaceId = 12 
                },
                new RaceToolProficiency 
                { 
                    Id = 58, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.AlchemistsSupplies),
                    CharacterRaceId = 12 
                },
                new RaceToolProficiency 
                { 
                    Id = 59, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.JewelersTools),
                    CharacterRaceId = 12 
                },
                new RaceToolProficiency 
                { 
                    Id = 60, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.CooksUtensils),
                    CharacterRaceId = 13 
                },
                new RaceToolProficiency 
                { 
                    Id = 61, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.BrewersSupplies),
                    CharacterRaceId = 13 
                },
                new RaceToolProficiency 
                { Id = 62, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.WeaversTools), 
                    CharacterRaceId = 13 
                },
                new RaceToolProficiency 
                { 
                    Id = 63, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.WoodcarversTools),
                    CharacterRaceId = 13 
                },
                new RaceToolProficiency 
                { 
                    Id = 64, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.HerbalismKit), 
                    CharacterRaceId = 13 
                },
                new RaceToolProficiency 
                { 
                    Id = 65, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.SmithsTools), 
                    CharacterRaceId = 14 
                },
                new RaceToolProficiency 
                { 
                    Id = 66, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.LeatherworkerTools),
                    CharacterRaceId = 14 
                },
                new RaceToolProficiency 
                { 
                    Id = 67, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.CarpenterTools),
                    CharacterRaceId = 14 
                },
                new RaceToolProficiency 
                { 
                    Id = 68,
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.CooksUtensils),
                    CharacterRaceId = 14 
                },
                new RaceToolProficiency 
                { 
                    Id = 69, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.BrewersSupplies),
                    CharacterRaceId = 14 
                },
                new RaceToolProficiency 
                { 
                    Id = 70, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.SmithsTools), 
                    CharacterRaceId = 15 
                },
                new RaceToolProficiency 
                { 
                    Id = 71, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.FarmersTools), 
                    CharacterRaceId = 15 
                },
                new RaceToolProficiency 
                { 
                    Id = 72, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.MasonsTools), 
                    CharacterRaceId = 15 
                },
                new RaceToolProficiency 
                { 
                    Id = 73, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.BrewersSupplies),
                    CharacterRaceId = 15 
                },
                new RaceToolProficiency 
                { 
                    Id = 74, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.HerbalismKit), 
                    CharacterRaceId = 15 
                },
                new RaceToolProficiency 
                { 
                    Id = 75, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.CalligraphersSupplies),
                    CharacterRaceId = 16 
                },
                new RaceToolProficiency 
                { 
                    Id = 76, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.DisguiseKit), 
                    CharacterRaceId = 16 
                },
                new RaceToolProficiency 
                { 
                    Id = 77, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.TinkersTools), 
                    CharacterRaceId = 16 
                },
                new RaceToolProficiency 
                { 
                    Id = 78, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.ThievesTools), 
                    CharacterRaceId = 16 
                },
                new RaceToolProficiency 
                { 
                    Id = 79, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.PaintersSupplies),
                    CharacterRaceId = 16 
                },
                new RaceToolProficiency 
                { 
                    Id = 80, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.CartographerTools),
                    CharacterRaceId = 17 
                },
                new RaceToolProficiency 
                { 
                    Id = 81, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.CalligraphersSupplies),
                    CharacterRaceId = 17 
                },
                new RaceToolProficiency 
                { 
                    Id = 82, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.PaintersSupplies),
                    CharacterRaceId = 17 
                },
                new RaceToolProficiency 
                { 
                    Id = 83, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.Drums), 
                    CharacterRaceId = 17 
                },
                new RaceToolProficiency 
                { 
                    Id = 84, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.ThievesTools), 
                    CharacterRaceId = 17 
                },
                new RaceToolProficiency 
                { 
                    Id = 85, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.AlchemistsSupplies),
                    CharacterRaceId = 18 
                },
                new RaceToolProficiency 
                { 
                    Id = 86, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.CalligraphersSupplies),
                    CharacterRaceId = 18 
                },
                new RaceToolProficiency 
                { 
                    Id = 87, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.DisguiseKit), 
                    CharacterRaceId = 18 
                },
                new RaceToolProficiency 
                { 
                    Id = 88, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.Lyre), 
                    CharacterRaceId = 18 
                },
                new RaceToolProficiency 
                { 
                    Id = 89, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.ForgeryKit), 
                    CharacterRaceId = 18 
                },
                new RaceToolProficiency 
                { 
                    Id = 90, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.MasonsTools), 
                    CharacterRaceId = 19 
                },
                new RaceToolProficiency 
                { 
                    Id = 91, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.CarpenterTools),
                    CharacterRaceId = 19 
                },
                new RaceToolProficiency 
                { 
                    Id = 92, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.CooksUtensils),
                    CharacterRaceId = 19 
                },
                new RaceToolProficiency 
                { 
                    Id = 93, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.FishingTackle),
                    CharacterRaceId = 19 
                },
                new RaceToolProficiency 
                { 
                    Id = 94, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.HerbalismKit), 
                    CharacterRaceId = 19 
                },
                new RaceToolProficiency 
                { 
                    Id = 95, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.PoisonersKit), 
                    CharacterRaceId = 20 
                },
                new RaceToolProficiency 
                { 
                    Id = 96, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.AlchemistsSupplies),
                    CharacterRaceId = 20 
                },
                new RaceToolProficiency 
                { 
                    Id = 97, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.DisguiseKit),
                    CharacterRaceId = 20 
                },
                new RaceToolProficiency 
                { 
                    Id = 98, 
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.ForgeryKit), 
                    CharacterRaceId = 20 
                },
                new RaceToolProficiency
                {
                    Id = 99,
                    Name = ToolProficiencyExtensions.GetDisplayName(ToolProficiency.CalligraphersSupplies),
                    CharacterRaceId = 20
                }
            );
        }
    }
}
