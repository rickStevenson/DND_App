using DND_App.Web.Models.Domain;
using Microsoft.EntityFrameworkCore;
using Constants = DND_App.Web.StaticClasses.Constants;

namespace DND_App.Web.Data.Extensions
{
    public static class SeedRaceWeaponProficienciesExtension
    {
        public static void SeedRaceWeaponProficiencies(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RaceWeaponProficiency>().HasData(
                new RaceWeaponProficiency { Id = 1, Name = Constants.None, CharacterRaceId = 1 },
                new RaceWeaponProficiency { Id = 2, Name = Constants.None, CharacterRaceId = 2 },
                new RaceWeaponProficiency { Id = 3, Name = Constants.Battleaxe, CharacterRaceId = 3 },
                new RaceWeaponProficiency { Id = 4, Name = Constants.Handaxe, CharacterRaceId = 3 },
                new RaceWeaponProficiency { Id = 5, Name = Constants.ThrowingHammer, CharacterRaceId = 3 },
                new RaceWeaponProficiency { Id = 6, Name = Constants.Warhammer, CharacterRaceId = 3 },
                new RaceWeaponProficiency { Id = 7, Name = Constants.Longsword, CharacterRaceId = 4 },
                new RaceWeaponProficiency { Id = 8, Name = Constants.Shortsword, CharacterRaceId = 4 },
                new RaceWeaponProficiency { Id = 9, Name = Constants.Shortbow, CharacterRaceId = 4 },
                new RaceWeaponProficiency { Id = 10, Name = Constants.Longbow, CharacterRaceId = 4 },
                new RaceWeaponProficiency { Id = 11, Name = Constants.None, CharacterRaceId = 5 },
                new RaceWeaponProficiency { Id = 12, Name = Constants.None, CharacterRaceId = 6 },
                new RaceWeaponProficiency { Id = 13, Name = Constants.None, CharacterRaceId = 7 },
                new RaceWeaponProficiency { Id = 14, Name = Constants.None, CharacterRaceId = 8 },
                new RaceWeaponProficiency { Id = 15, Name = Constants.None, CharacterRaceId = 9 },
                new RaceWeaponProficiency { Id = 16, Name = Constants.None, CharacterRaceId = 10 },
                new RaceWeaponProficiency { Id = 17, Name = Constants.None, CharacterRaceId = 11 },
                new RaceWeaponProficiency { Id = 18, Name = Constants.Longsword, CharacterRaceId = 12 },
                new RaceWeaponProficiency { Id = 19, Name = Constants.Shortsword, CharacterRaceId = 12 },
                new RaceWeaponProficiency { Id = 20, Name = Constants.Shortbow, CharacterRaceId = 12 },
                new RaceWeaponProficiency { Id = 21, Name = Constants.Longbow, CharacterRaceId = 12 },
                new RaceWeaponProficiency { Id = 22, Name = Constants.None, CharacterRaceId = 13 },
                new RaceWeaponProficiency { Id = 23, Name = Constants.None, CharacterRaceId = 14 },
                new RaceWeaponProficiency { Id = 24, Name = Constants.Longsword, CharacterRaceId = 15 },
                new RaceWeaponProficiency { Id = 25, Name = Constants.Shortsword, CharacterRaceId = 15 },
                new RaceWeaponProficiency { Id = 26, Name = Constants.None, CharacterRaceId = 16 },
                new RaceWeaponProficiency { Id = 27, Name = Constants.None, CharacterRaceId = 17 },
                new RaceWeaponProficiency { Id = 28, Name = Constants.None, CharacterRaceId = 18 },
                new RaceWeaponProficiency { Id = 29, Name = Constants.None, CharacterRaceId = 19 },
                new RaceWeaponProficiency { Id = 30, Name = Constants.None, CharacterRaceId = 20 }
            );
        }
    }
}
