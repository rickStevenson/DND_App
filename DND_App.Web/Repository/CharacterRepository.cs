using DND_App.Web.Data;
using DND_App.Web.Models.Domain;
using DND_App.Web.Data;
using Microsoft.EntityFrameworkCore;

namespace DND_App.Web.Repository
{
    public class CharacterRepository : ICharacterRepository
    {
        private readonly DnDDbContext dndDbContext;

        public CharacterRepository(DnDDbContext dndDbContext)
        {
            this.dndDbContext = dndDbContext;
        }

        public async Task<Character> CreateAsync(Character character)
        {
            await dndDbContext.AddAsync(character);
            await dndDbContext.SaveChangesAsync();
            return character;
        }
        public async Task<IEnumerable<Character>> ReadAllAsync()
        {
            return await dndDbContext.Characters
                .Include(c => c.CharacterClass)
                .Include(c => c.CharacterRace)
                .ToListAsync();
        }
        public async Task<Character?> ReadByIdAsync(int id)
        {
           return await dndDbContext.Characters
                .Include(c => c.CharacterClass)
                .Include(c => c.CharacterRace)
                .FirstOrDefaultAsync(c => c.Id == id);
        }
        public async Task<Character?> UpdateAsync(Character character)
        {
            var existingCharacter = await dndDbContext.Characters
                .Include(c => c.CharacterClass)
                .Include(c => c.CharacterRace)
                .FirstOrDefaultAsync(post => post.Id == character.Id);

            if (existingCharacter != null)
            {
                existingCharacter.Id = character.Id;
                existingCharacter.CharacterName = character.CharacterName;
                existingCharacter.CharacterRace.Name = character.CharacterRace.Name;
                existingCharacter.CharacterClass.Name = character.CharacterClass.Name;
                existingCharacter.Strength = character.Strength;
                existingCharacter.Dexterity = character.Dexterity;
                existingCharacter.Constitution = character.Constitution;
                existingCharacter.Intelligence = character.Intelligence;
                existingCharacter.Wisdom = character.Wisdom;
                existingCharacter.Charisma = character.Charisma;
                existingCharacter.Level = character.Level;
                existingCharacter.ExperiencePoints = character.ExperiencePoints;
                existingCharacter.PassiveWisdom = character.PassiveWisdom;
                existingCharacter.Inspiration = character.Inspiration;
                existingCharacter.ProficiencyBonus = character.ProficiencyBonus;
                existingCharacter.ArmorClass = character.ArmorClass;
                existingCharacter.Speed = character.Speed;
                existingCharacter.Age = character.Age;
                existingCharacter.Height = character.Height;
                existingCharacter.Weight = character.Weight;
                existingCharacter.Eyes = character.Eyes;
                existingCharacter.Skin = character.Skin;
                existingCharacter.Hair = character.Hair;
                existingCharacter.PersonalityTraits = character.PersonalityTraits;
                existingCharacter.Ideals = character.Ideals;
                existingCharacter.Bonds = character.Bonds;
                existingCharacter.Flaws = character.Flaws;
                existingCharacter.CharacterBackstory = character.CharacterBackstory;
                existingCharacter.Alignment = character.Alignment;
                existingCharacter.EncumbranceStatus = character.EncumbranceStatus;
                existingCharacter.CharacterImage = character.CharacterImage;
            }

            await dndDbContext.SaveChangesAsync();
            return existingCharacter;
        }
        public async Task<Character?> DeleteAsync(int id)
        {
            var existingCharacter = await dndDbContext.Characters.FindAsync(id);

            if (existingCharacter != null)
            {
                dndDbContext.Characters.Remove(existingCharacter);
                await dndDbContext.SaveChangesAsync();

                return existingCharacter;
            }

            return null;
        }
    }
}
