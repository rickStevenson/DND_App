using DND_App.Web.Models.Domain;
using Microsoft.EntityFrameworkCore;
using Constants = DND_App.Web.StaticClasses.Constants;

namespace DND_App.Web.Data.Extensions
{
    public static class SeedCharacterRacesExtension
    {
        public static void SeedCharacterRaces (this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CharacterRace>().HasData(
                new CharacterRace
                {
                    Id = 1,
                    Name = "Aasimar",
                    StrengthBonus = 0,
                    DexterityBonus = 0,
                    ConstitutionBonus = 0,
                    IntelligenceBonus = 2,
                    WisdomBonus = 0,
                    CharismaBonus = 1
                },
                new CharacterRace
                {
                    Id = 2,
                    Name = "Dragonborn",
                    StrengthBonus = 2,
                    DexterityBonus = 0,
                    ConstitutionBonus = 0,
                    IntelligenceBonus = 0,
                    WisdomBonus = 0,
                    CharismaBonus = 1
                },
                new CharacterRace
                {
                    Id = 3,
                    Name = "Dwarf",
                    StrengthBonus = 0,
                    DexterityBonus = 0,
                    ConstitutionBonus = 2,
                    IntelligenceBonus = 0,
                    WisdomBonus = 0,
                    CharismaBonus = 0
                },
                new CharacterRace
                {
                    Id = 4,
                    Name = "Elf",
                    StrengthBonus = 0,
                    DexterityBonus = 2,
                    ConstitutionBonus = 0,
                    IntelligenceBonus = 0,
                    WisdomBonus = 0,
                    CharismaBonus = 0
                },
                new CharacterRace
                {
                    Id = 5,
                    Name = "Firbolg",
                    StrengthBonus = 1,
                    DexterityBonus = 0,
                    ConstitutionBonus = 0,
                    IntelligenceBonus = 0,
                    WisdomBonus = 2,
                    CharismaBonus = 0
                },
                new CharacterRace
                {
                    Id = 6,
                    Name = "Air Genasi",
                    StrengthBonus = 0,
                    DexterityBonus = 1,
                    ConstitutionBonus = 0,
                    IntelligenceBonus = 0,
                    WisdomBonus = 0,
                    CharismaBonus = 0
                },
                new CharacterRace
                {
                    Id = 7,
                    Name = "Earth Genasi",
                    StrengthBonus = 1,
                    DexterityBonus = 0,
                    ConstitutionBonus = 0,
                    IntelligenceBonus = 0,
                    WisdomBonus = 0,
                    CharismaBonus = 0
                },
                new CharacterRace
                {
                    Id = 8,
                    Name = "Fire Genasi",
                    StrengthBonus = 0,
                    DexterityBonus = 1,
                    ConstitutionBonus = 0,
                    IntelligenceBonus = 0,
                    WisdomBonus = 0,
                    CharismaBonus = 0
                },
                new CharacterRace
                {
                    Id = 9,
                    Name = "Water Genasi",
                    StrengthBonus = 0,
                    DexterityBonus = 0,
                    ConstitutionBonus = 1,
                    IntelligenceBonus = 0,
                    WisdomBonus = 0,
                    CharismaBonus = 0
                },
                new CharacterRace
                {
                    Id = 10,
                    Name = "Gnome",
                    StrengthBonus = 0,
                    DexterityBonus = 0,
                    ConstitutionBonus = 0,
                    IntelligenceBonus = 2,
                    WisdomBonus = 0,
                    CharismaBonus = 0
                },
                new CharacterRace
                {
                    Id = 11,
                    Name = "Goliath",
                    StrengthBonus = 2,
                    DexterityBonus = 0,
                    ConstitutionBonus = 1,
                    IntelligenceBonus = 0,
                    WisdomBonus = 0,
                    CharismaBonus = 0
                },
                new CharacterRace
                {
                    Id = 12,
                    Name = "Half-Elf",
                    StrengthBonus = 0,
                    DexterityBonus = 0,
                    ConstitutionBonus = 0,
                    IntelligenceBonus = 0,
                    WisdomBonus = 0,
                    CharismaBonus = 2
                },
                new CharacterRace
                {
                    Id = 13,
                    Name = "Halfling",
                    StrengthBonus = 0,
                    DexterityBonus = 2,
                    ConstitutionBonus = 0,
                    IntelligenceBonus = 0,
                    WisdomBonus = 0,
                    CharismaBonus = 0
                },
                new CharacterRace
                {
                    Id = 14,
                    Name = "Half-Orc",
                    StrengthBonus = 2,
                    DexterityBonus = 0,
                    ConstitutionBonus = 1,
                    IntelligenceBonus = 0,
                    WisdomBonus = 0,
                    CharismaBonus = 0
                },
                new CharacterRace
                {
                    Id = 15,
                    Name = "Human",
                    StrengthBonus = 1,
                    DexterityBonus = 1,
                    ConstitutionBonus = 1,
                    IntelligenceBonus = 1,
                    WisdomBonus = 1,
                    CharismaBonus = 1
                },
                new CharacterRace
                {
                    Id = 16,
                    Name = "Kenku",
                    StrengthBonus = 0,
                    DexterityBonus = 2,
                    ConstitutionBonus = 0,
                    IntelligenceBonus = 0,
                    WisdomBonus = 0,
                    CharismaBonus = 0
                },
                new CharacterRace
                {
                    Id = 17,
                    Name = "Tabaxi",
                    StrengthBonus = 0,
                    DexterityBonus = 2,
                    ConstitutionBonus = 0,
                    IntelligenceBonus = 0,
                    WisdomBonus = 0,
                    CharismaBonus = 0
                },
                new CharacterRace
                {
                    Id = 18,
                    Name = "Tiefling",
                    StrengthBonus = 0,
                    DexterityBonus = 0,
                    ConstitutionBonus = 0,
                    IntelligenceBonus = 1,
                    WisdomBonus = 0,
                    CharismaBonus = 2
                },
                new CharacterRace
                {
                    Id = 19,
                    Name = "Tortle",
                    StrengthBonus = 2,
                    DexterityBonus = 0,
                    ConstitutionBonus = 1,
                    IntelligenceBonus = 0,
                    WisdomBonus = 0,
                    CharismaBonus = 0
                },
                new CharacterRace
                {
                    Id = 20,
                    Name = "Yuan-Ti Pureblood",
                    StrengthBonus = 0,
                    DexterityBonus = 0,
                    ConstitutionBonus = 0,
                    IntelligenceBonus = 1,
                    WisdomBonus = 0,
                    CharismaBonus = 2
                }
            );
        }
    }
}
