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
                .Include(c => c.CharacterTreasures)
                    .ThenInclude(cs => cs.Treasure)
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
                .Include(c => c.CharacterTreasures)
                    .ThenInclude(cs => cs.Treasure)
                .FirstOrDefaultAsync(c => c.Id == id);
        }
        public async Task<Character?> UpdateAsync(Character updatedCharacterFromController)
        {
            #region Get existing character
            var existingCharacterFromDb = await dndDbContext.Characters
                .Include(c => c.CharacterClass)
                .Include(c => c.CharacterRace)
                .Include(c => c.CharacterSkills)
                    .ThenInclude(cs => cs.Skill)
                .Include(c => c.CharacterSpells)
                    .ThenInclude(cs => cs.Spell)
                .Include(c => c.CharacterItems)
                    .ThenInclude(cs => cs.Item)
                .Include(c => c.CharacterTreasures)
                    .ThenInclude(cs => cs.Treasure)
                .FirstOrDefaultAsync(post => post.Id == updatedCharacterFromController.Id);
            #endregion

            #region Update existing character
            if (existingCharacterFromDb != null)
            {
                #region Update Character Properties
                existingCharacterFromDb.Id = updatedCharacterFromController.Id;
                existingCharacterFromDb.CharacterName = updatedCharacterFromController.CharacterName;
                existingCharacterFromDb.Strength = updatedCharacterFromController.Strength;
                existingCharacterFromDb.Dexterity = updatedCharacterFromController.Dexterity;
                existingCharacterFromDb.Constitution = updatedCharacterFromController.Constitution;
                existingCharacterFromDb.Intelligence = updatedCharacterFromController.Intelligence;
                existingCharacterFromDb.Wisdom = updatedCharacterFromController.Wisdom;
                existingCharacterFromDb.Charisma = updatedCharacterFromController.Charisma;
                existingCharacterFromDb.Level = updatedCharacterFromController.Level;
                existingCharacterFromDb.ExperiencePoints = updatedCharacterFromController.ExperiencePoints;
                existingCharacterFromDb.PassiveWisdom = updatedCharacterFromController.PassiveWisdom;
                existingCharacterFromDb.Inspiration = updatedCharacterFromController.Inspiration;
                existingCharacterFromDb.ProficiencyBonus = updatedCharacterFromController.ProficiencyBonus;
                existingCharacterFromDb.ArmorClass = updatedCharacterFromController.ArmorClass;
                existingCharacterFromDb.Speed = updatedCharacterFromController.Speed;
                existingCharacterFromDb.Age = updatedCharacterFromController.Age;
                existingCharacterFromDb.Height = updatedCharacterFromController.Height;
                existingCharacterFromDb.Weight = updatedCharacterFromController.Weight;
                existingCharacterFromDb.Eyes = updatedCharacterFromController.Eyes;
                existingCharacterFromDb.Skin = updatedCharacterFromController.Skin;
                existingCharacterFromDb.Hair = updatedCharacterFromController.Hair;
                existingCharacterFromDb.PersonalityTraits = updatedCharacterFromController.PersonalityTraits;
                existingCharacterFromDb.Ideals = updatedCharacterFromController.Ideals;
                existingCharacterFromDb.Bonds = updatedCharacterFromController.Bonds;
                existingCharacterFromDb.Flaws = updatedCharacterFromController.Flaws;
                existingCharacterFromDb.CharacterBackstory = updatedCharacterFromController.CharacterBackstory;
                existingCharacterFromDb.Alignment = updatedCharacterFromController.Alignment;
                existingCharacterFromDb.EncumbranceStatus = updatedCharacterFromController.EncumbranceStatus;
                existingCharacterFromDb.CharacterImage = updatedCharacterFromController.CharacterImage;
                existingCharacterFromDb.Gender = updatedCharacterFromController.Gender;
                existingCharacterFromDb.HitPoints_Current = updatedCharacterFromController.HitPoints_Current;
                existingCharacterFromDb.HitPoints_Total = updatedCharacterFromController.HitPoints_Total;
                existingCharacterFromDb.Initiative = updatedCharacterFromController.Initiative;
                #endregion

                #region Update Character Race & Class
                existingCharacterFromDb.CharacterRace.Name = updatedCharacterFromController.CharacterRace.Name;
                existingCharacterFromDb.CharacterClass.Name = updatedCharacterFromController.CharacterClass.Name;
                existingCharacterFromDb.CharacterRaceId = updatedCharacterFromController.CharacterRaceId;
                existingCharacterFromDb.CharacterClassId = updatedCharacterFromController.CharacterClassId;
                #endregion

                #region Update CharacterSkills
                var existingSkills = existingCharacterFromDb.CharacterSkills.ToList();
                var updatedSkills = updatedCharacterFromController.CharacterSkills.ToList();

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
                        existingCharacterFromDb.CharacterSkills.Add(new CharacterSkill
                        {
                            SkillId = skill.SkillId,
                            CharacterId = existingCharacterFromDb.Id,
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
                var existingSpells = existingCharacterFromDb.CharacterSpells.ToList();
                var updatedSpells = updatedCharacterFromController.CharacterSpells.ToList();

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
                        existingCharacterFromDb.CharacterSpells.Add(new CharacterSpell
                        {
                            SpellId = spell.SpellId,
                            CharacterId = existingCharacterFromDb.Id
                        });
                    }
                }
                #endregion

                #region Update CharacterItems
                var existingItems = existingCharacterFromDb.CharacterItems.ToList();
                var updatedItems = updatedCharacterFromController.CharacterItems.ToList();

                // Remove items that are no longer associated
                foreach (var item in existingItems)
                {
                    if (!updatedItems.Any(ei => ei.ItemId == item.ItemId))
                    {
                        dndDbContext.CharacterItems.Remove(item);
                    }
                }

                // Add or update Items
                foreach (var item in updatedItems)
                {
                    var existingItem = existingItems
                        .FirstOrDefault(cs => cs.ItemId == item.ItemId);
                    if (existingItem == null)
                    {
                        // Add new Items
                        existingCharacterFromDb.CharacterItems.Add(new CharacterItem
                        {
                            ItemId = item.ItemId,
                            CharacterId = existingCharacterFromDb.Id
                        });
                    }
                }
                #endregion

                #region Update CharacterTreasures
                var existingTreasures = existingCharacterFromDb.CharacterTreasures.ToList();
                var updatedTreasures = updatedCharacterFromController.CharacterTreasures.ToList();

                // Remove treasures that are no longer associated
                foreach (var treasure in existingTreasures)
                {
                    if (!updatedTreasures.Any(et => et.TreasureId == treasure.TreasureId))
                    {
                        dndDbContext.CharacterTreasures.Remove(treasure);
                    }
                }

                // Add or update treasure
                foreach (var treasure in updatedTreasures)
                {
                    var existingTreasure = existingTreasures
                        .FirstOrDefault(cs => cs.TreasureId == treasure.TreasureId);
                    if (existingTreasure == null)
                    {
                        // Add new treasure
                        existingCharacterFromDb.CharacterTreasures.Add(new CharacterTreasure
                        {
                            TreasureId = treasure.TreasureId,
                            CharacterId = existingCharacterFromDb.Id
                        });
                    }
                }
                #endregion
            }
            #endregion

            #region Save and Return
            await dndDbContext.SaveChangesAsync();
            return existingCharacterFromDb;
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
