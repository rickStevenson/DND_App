using DND_App.Web.Models.Domain;
using Microsoft.EntityFrameworkCore;
using Constants = DND_App.Web.StaticClasses.Constants;

namespace DND_App.Web.Data.Extensions
{
    public static class SeedClassSavingThrowsExtension
    {
        public static void SeedClassSavingThrows(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClassSavingThrow>().HasData(
                new ClassSavingThrow { Id = 1, Name = Constants.Strength, CharacterClassId = 1 },
                new ClassSavingThrow { Id = 2, Name = Constants.Constitution, CharacterClassId = 1 },
                new ClassSavingThrow { Id = 3, Name = Constants.Dexterity, CharacterClassId = 2 },
                new ClassSavingThrow { Id = 4, Name = Constants.Charisma, CharacterClassId = 2 },
                new ClassSavingThrow { Id = 5, Name = Constants.Wisdom, CharacterClassId = 3 },
                new ClassSavingThrow { Id = 6, Name = Constants.Charisma, CharacterClassId = 3 },
                new ClassSavingThrow { Id = 7, Name = Constants.Intelligence, CharacterClassId = 4 },
                new ClassSavingThrow { Id = 8, Name = Constants.Wisdom, CharacterClassId = 4 },
                new ClassSavingThrow { Id = 9, Name = Constants.Strength, CharacterClassId = 5 },
                new ClassSavingThrow { Id = 10, Name = Constants.Constitution, CharacterClassId = 5 },
                new ClassSavingThrow { Id = 11, Name = Constants.Strength, CharacterClassId = 6 },
                new ClassSavingThrow { Id = 12, Name = Constants.Dexterity, CharacterClassId = 6 },
                new ClassSavingThrow { Id = 13, Name = Constants.Wisdom, CharacterClassId = 7 },
                new ClassSavingThrow { Id = 14, Name = Constants.Charisma, CharacterClassId = 7 },
                new ClassSavingThrow { Id = 15, Name = Constants.Strength, CharacterClassId = 8 },
                new ClassSavingThrow { Id = 16, Name = Constants.Dexterity, CharacterClassId = 8 },
                new ClassSavingThrow { Id = 17, Name = Constants.Dexterity, CharacterClassId = 9 },
                new ClassSavingThrow { Id = 18, Name = Constants.Intelligence, CharacterClassId = 9 },
                new ClassSavingThrow { Id = 19, Name = Constants.Constitution, CharacterClassId = 10 },
                new ClassSavingThrow { Id = 20, Name = Constants.Charisma, CharacterClassId = 10 },
                new ClassSavingThrow { Id = 21, Name = Constants.Wisdom, CharacterClassId = 11 },
                new ClassSavingThrow { Id = 22, Name = Constants.Charisma, CharacterClassId = 11 },
                new ClassSavingThrow { Id = 23, Name = Constants.Intelligence, CharacterClassId = 12 },
                new ClassSavingThrow { Id = 24, Name = Constants.Wisdom, CharacterClassId = 12 }
            );
        }
    }
}
