using DND_App.Web.Models.Domain;
using Microsoft.EntityFrameworkCore;
using Constants = DND_App.Web.StaticClasses.Constants;

namespace DND_App.Web.Data.Extensions
{
    public static class SeedCharacterClassesExtension
    {
        public static void SeedCharacterClasses(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CharacterClass>().HasData(
                 new CharacterClass
                 {
                     Id = 1,
                     Name = "Barbarian",
                     HitDie = 12
                 },
                 new CharacterClass
                 {
                     Id = 2,
                     Name = "Bard",
                     HitDie = 8
                 },
                 new CharacterClass
                 {
                     Id = 3,
                     Name = "Cleric",
                     HitDie = 8
                 },
                 new CharacterClass
                 {
                     Id = 4,
                     Name = "Druid",
                     HitDie = 8
                 },
                 new CharacterClass
                 {
                     Id = 5,
                     Name = "Fighter",
                     HitDie = 10
                 },
                 new CharacterClass
                 {
                     Id = 6,
                     Name = "Monk",
                     HitDie = 8
                 },
                 new CharacterClass
                 {
                     Id = 7,
                     Name = "Paladin",
                     HitDie = 10
                 },
                 new CharacterClass
                 {
                     Id = 8,
                     Name = "Ranger",
                     HitDie = 10
                 },
                 new CharacterClass
                 {
                     Id = 9,
                     Name = "Rogue",
                     HitDie = 8
                 },
                 new CharacterClass
                 {
                     Id = 10,
                     Name = "Sorcerer",
                     HitDie = 6
                 },
                 new CharacterClass
                 {
                     Id = 11,
                     Name = "Warlock",
                     HitDie = 8
                 },
                 new CharacterClass
                 {
                     Id = 12,
                     Name = "Wizard",
                     HitDie = 6
                 }
             );
        }
    }
}
