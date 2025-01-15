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
                .Include(c => c.CharacterSkills)
                    .ThenInclude(cs => cs.Skill)
                .ToListAsync();
        }
        public async Task<Character?> ReadByIdAsync(int id)
        {
           return await dndDbContext.Characters
                .Include(c => c.CharacterClass)
                .Include(c => c.CharacterRace)
                .Include(c => c.CharacterSkills)
                    .ThenInclude(cs => cs.Skill)
                .FirstOrDefaultAsync(c => c.Id == id);
        }
        public async Task<Character?> UpdateAsync(Character character)
        {
            var existingCharacter = await dndDbContext.Characters
                .Include(c => c.CharacterClass)
                .Include(c => c.CharacterRace)
                .Include(c => c.CharacterSkills)
                    .ThenInclude(cs => cs.Skill)
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
                existingCharacter.Gender = character.Gender;
                existingCharacter.HitPoints_Current = character.HitPoints_Current;
                existingCharacter.HitPoints_Total = character.HitPoints_Total;
                existingCharacter.Initiative = character.Initiative;

                // Update relationships
                existingCharacter.CharacterRaceId = character.CharacterRaceId;
                existingCharacter.CharacterClassId = character.CharacterClassId;

                // Update CharacterSkills
                var existingSkills = existingCharacter.CharacterSkills.ToList();
                var updatedSkills = character.CharacterSkills.ToList();

                // Remove skills that are no longer associated
                foreach (var skill in existingSkills)
                {
                    if (!updatedSkills.Any(cs => cs.SkillId == skill.SkillId))
                    {
                        dndDbContext.CharacterSkills.Remove(skill);
                    }
                }

                // Add or update skills
                foreach (var skill in updatedSkills)
                {
                    var existingSkill = existingSkills.FirstOrDefault(cs => cs.SkillId == skill.SkillId);
                    if (existingSkill == null)
                    {
                        // Add new skill
                        existingCharacter.CharacterSkills.Add(new CharacterSkill
                        {
                            SkillId = skill.SkillId,
                            CharacterId = existingCharacter.Id,
                            IsProficient = skill.IsProficient,
                            Bonus = skill.Bonus
                        });
                    }
                    else
                    {
                        // Update existing skill
                        existingSkill.IsProficient = skill.IsProficient;
                        existingSkill.Bonus = skill.Bonus;
                    }
                }
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
