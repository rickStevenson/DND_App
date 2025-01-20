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
                .Include(c => c.CharacterSpells)
                    .ThenInclude(cs => cs.Spell)
                .ToListAsync();
        }
        public async Task<Character?> ReadByIdAsync(int id)
        {
           return await dndDbContext.Characters
                .Include(c => c.CharacterClass)
                .Include(c => c.CharacterRace)
                .Include(c => c.CharacterSkills)
                    .ThenInclude(cs => cs.Skill)
                .Include(c => c.CharacterSpells)
                    .ThenInclude(cs => cs.Spell)
                .FirstOrDefaultAsync(c => c.Id == id);
        }
        

        public async Task<Character?> UpdateAsync(Character character)
        {
            #region Get existing character
            var existingCharacter = await dndDbContext.Characters
                .Include(c => c.CharacterClass)
                .Include(c => c.CharacterRace)
                .Include(c => c.CharacterSkills)
                    .ThenInclude(cs => cs.Skill)
                .Include(c => c.CharacterSpells)
                    .ThenInclude(cs => cs.Spell)
                .Include(c => c.CharacterItems)
                    .ThenInclude(cs => cs.Item)
                .FirstOrDefaultAsync(post => post.Id == character.Id);
            #endregion

            #region Update existing character
            if (existingCharacter != null)
            {
                #region Update Character Properties
                existingCharacter.Id = character.Id;
                existingCharacter.CharacterName = character.CharacterName;
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
                #endregion

                #region Update Character Race & Class
                existingCharacter.CharacterRace.Name = character.CharacterRace.Name;
                existingCharacter.CharacterClass.Name = character.CharacterClass.Name;
                existingCharacter.CharacterRaceId = character.CharacterRaceId;
                existingCharacter.CharacterClassId = character.CharacterClassId;
                #endregion

                #region Update CharacterSkills
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
                    var existingSkill = existingSkills
                        .FirstOrDefault(cs => cs.SkillId == skill.SkillId);
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
                #endregion

                #region Update CharacterSpells
                var existingSpells = existingCharacter.CharacterSpells.ToList();
                var updatedSpells = character.CharacterSpells.ToList();

                // Remove spells that are no longer associated
                foreach (var spell in existingSpells)
                {
                    if (!updatedSpells.Any(cs => cs.SpellId == spell.SpellId))
                    {
                        dndDbContext.CharacterSpells.Remove(spell);
                    }
                }

                // Add or update spells
                foreach (var spell in updatedSpells)
                {
                    var existingSpell = existingSpells
                        .FirstOrDefault(cs => cs.SpellId == spell.SpellId);
                    if (existingSpell == null)
                    {
                        // Add new spell
                        existingCharacter.CharacterSpells.Add(new CharacterSpell
                        {
                            SpellId = spell.SpellId,
                            CharacterId = existingCharacter.Id
                        });
                    }
                }
                #endregion

                #region Update CharacterItems
                var existingItems = existingCharacter.CharacterItems.ToList();
                var updatedItems = character.CharacterItems.ToList();

                // Remove items that are no longer associated
                foreach (var item in existingItems)
                {
                    if (!updatedItems.Any(cs => cs.ItemId == item.ItemId))
                    {
                        dndDbContext.CharacterItems.Remove(item);
                    }
                }

                // Add or update Item
                foreach (var item in updatedItems)
                {
                    var existingItem = existingItems
                        .FirstOrDefault(cs => cs.ItemId == item.ItemId);
                    if (existingItem == null)
                    {
                        // Add new Item
                        existingCharacter.CharacterItems.Add(new CharacterItem
                        {
                            ItemId = item.ItemId,
                            CharacterId = existingCharacter.Id
                        });
                    }
                }
                #endregion
            }
            #endregion

            #region Save and Return
            await dndDbContext.SaveChangesAsync();
            return existingCharacter;
            #endregion
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
