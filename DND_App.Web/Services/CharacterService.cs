using DND_App.Web.Data;
using DND_App.Web.Models.Domain;
using DND_App.Web.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using DND_App.Web.Models.ViewModels;
using DND_App.Web.StaticClasses;
using Ganss.Xss;
using Microsoft.AspNetCore.Mvc.ViewFeatures;


namespace DND_App.Web.Services
{
    public class CharacterService : ICharacterService
    {
        private readonly ICharacterRepository characterRepository;
        private readonly UserManager<IdentityUser> userManager;
        private readonly DnDDbContext dndDbContext;

        public CharacterService(ICharacterRepository characterRepository, UserManager<IdentityUser> userManager, DnDDbContext dndDbContext)
        {
            this.characterRepository = characterRepository;
            this.userManager = userManager;
            this.dndDbContext = dndDbContext;
        }
        public async Task<CreateCharacterViewModel> GetCreateCharacterViewModelAsync()
        {
            // Fetch necessary data asynchronously
            var classes = await dndDbContext.CharacterClasses.ToListAsync();
            var races = await dndDbContext.CharacterRaces.ToListAsync();
            var skills = await dndDbContext.Skills.ToListAsync();
            var spells = await dndDbContext.Spells.ToListAsync();
            var items = await dndDbContext.Items.ToListAsync();
            var treasures = await dndDbContext.Treasures.ToListAsync();

            // Create and populate the ViewModel
            return new CreateCharacterViewModel
            {
                Classes = classes, // Make sure this is being set
                Races = races,
                CharacterSkills = skills.Select(s => new CharacterSkillRequest
                {
                    SkillId = s.Id,
                    IsProficient = false,
                    Bonus = 0
                }).ToList(),

                CharacterSpells = spells.Select(sp => new CharacterSpellRequest
                {
                    SpellId = sp.Id,
                    IsLearned = false
                }).ToList(),

                CharacterItems = items.Select(ci => new CharacterItemRequest
                {
                    ItemId = ci.Id,
                    Quantity = 0
                }).ToList(),

                CharacterTreasures = treasures.Select(ct => new CharacterTreasureRequest
                {
                    TreasureId = ct.Id,
                    Quantity = 0
                }).ToList()
            };
        }

        public async Task<IEnumerable<Character>> GetAllCharactersAsync()
        {
            return await characterRepository.ReadAllAsync();
        }
        public async Task<Character?> GetCharacterByIdAsync(int id)
        {
            var character = await dndDbContext.Characters
                .Include(c => c.CharacterClass)
                .Include(c => c.CharacterRace)
                .Include(c => c.CharacterSkills).ThenInclude(cs => cs.Skill)
                .Include(c => c.CharacterSpells).ThenInclude(cs => cs.Spell)
                .Include(c => c.CharacterItems).ThenInclude(ci => ci.Item)
                .Include(c => c.CharacterTreasures).ThenInclude(ct => ct.Treasure)
                .FirstOrDefaultAsync(c => c.Id == id);

            if (character != null)
            {
                // Recalculate values that depend on modifications
                character.ArmorClass = HelperMethods.CalculateArmorClass(character);
                await dndDbContext.SaveChangesAsync();  // Ensure changes persist in the DB
            }

            return character;
        }

        public async Task<Character?> CreateCharacterAsync(CreateCharacterViewModel createCharacterViewModel, IdentityUser loggedInUser)
        {
            var sanitizer = new HtmlSanitizer();
            createCharacterViewModel.CharacterBackstory = sanitizer.Sanitize(createCharacterViewModel.CharacterBackstory);

            var characterClass = await dndDbContext.CharacterClasses
                .FirstOrDefaultAsync(c => c.Id == createCharacterViewModel.CharacterClassId);

            if (characterClass == null)
            {
                return null; // Ensure a valid class is selected
            }

            var character = new Character
            {
                // User-related properties
                UserId = Guid.Parse(loggedInUser.Id),
                PlayerName = loggedInUser.UserName,

                // Core properties
                CharacterName = createCharacterViewModel.CharacterName,
                CharacterClassId = createCharacterViewModel.CharacterClassId,
                CharacterClass = characterClass,
                CharacterRaceId = createCharacterViewModel.CharacterRaceId,
                Strength = createCharacterViewModel.Strength,
                Dexterity = createCharacterViewModel.Dexterity,
                Constitution = createCharacterViewModel.Constitution,
                Intelligence = createCharacterViewModel.Intelligence,
                Wisdom = createCharacterViewModel.Wisdom,
                Charisma = createCharacterViewModel.Charisma,
                Level = createCharacterViewModel.Level,
                ExperiencePoints = createCharacterViewModel.ExperiencePoints,
                PassiveWisdom = createCharacterViewModel.PassiveWisdom,
                Inspiration = createCharacterViewModel.Inspiration,
                ProficiencyBonus = HelperMethods.CalculateProficiencyBonus(createCharacterViewModel.Level),
                Speed = createCharacterViewModel.Speed,
                Age = createCharacterViewModel.Age,
                Height = createCharacterViewModel.Height,
                Weight = createCharacterViewModel.Weight,
                Eyes = createCharacterViewModel.Eyes,
                Skin = createCharacterViewModel.Skin,
                Hair = createCharacterViewModel.Hair,
                PersonalityTraits = createCharacterViewModel.PersonalityTraits,
                Ideals = createCharacterViewModel.Ideals,
                Bonds = createCharacterViewModel.Bonds,
                Flaws = createCharacterViewModel.Flaws,
                CharacterBackstory = createCharacterViewModel.CharacterBackstory,
                Alignment = createCharacterViewModel.Alignment,
                EncumbranceStatus = createCharacterViewModel.EncumbranceStatus,
                CharacterImage = createCharacterViewModel.CharacterImage,
                Gender = createCharacterViewModel.Gender,
                HitPoints_Total = createCharacterViewModel.HitPoints_Total,
                Initiative = createCharacterViewModel.Initiative,
                TotalWeight = createCharacterViewModel.TotalWeight,

                // Character Relationships
                CharacterSkills = createCharacterViewModel.CharacterSkills
                    .Select(cs => new CharacterSkill
                    {
                        SkillId = cs.SkillId,
                        IsProficient = cs.IsProficient,
                        Bonus = HelperMethods.CalculateProficiencyBonus(createCharacterViewModel.Level)
                    }).ToList(),

                CharacterSpells = createCharacterViewModel.CharacterSpells
                    .Select(cs => new CharacterSpell
                    {
                        SpellId = cs.SpellId,
                        IsLearned = cs.IsLearned
                    }).ToList(),

                CharacterItems = createCharacterViewModel.CharacterItems
                    .Where(ci => ci.Quantity > 0) // Only include items with quantity > 0
                    .Select(ci => new CharacterItem
                    {
                        ItemId = ci.ItemId,
                        Quantity = ci.Quantity
                    }).ToList(),

                CharacterTreasures = createCharacterViewModel.CharacterTreasures
                    .Select(ct => new CharacterTreasure
                    {
                        TreasureId = ct.TreasureId,
                        Quantity = ct.Quantity
                    }).ToList()
            };

            // Ensure calculated fields are updated
            character.ArmorClass = HelperMethods.CalculateArmorClass(character);

            // Save the new character to the database
            await characterRepository.CreateAsync(character);

            return character;
        }

        public async Task<bool> DeleteCharacterAsync(int id)
        {
            var deletedCharacter = await characterRepository.DeleteAsync(id);
            return deletedCharacter != null;
        }

        public async Task<EditCharacterViewModel?> GetCharacterForEditAsync(int id)
        {
            var character = await dndDbContext.Characters
                .Include(c => c.CharacterClass)
                .Include(c => c.CharacterRace)
                .Include(c => c.CharacterSkills).ThenInclude(cs => cs.Skill)
                .Include(c => c.CharacterSpells).ThenInclude(cs => cs.Spell)
                .Include(c => c.CharacterItems).ThenInclude(ci => ci.Item)
                .Include(c => c.CharacterTreasures).ThenInclude(ct => ct.Treasure)
                .FirstOrDefaultAsync(c => c.Id == id);

            if (character == null)
                return null;

            // Load all available skills, spells, items, and treasures
            var allSkills = await dndDbContext.Skills.ToListAsync();
            var allSpells = await dndDbContext.Spells.ToListAsync();
            var allItems = await dndDbContext.Items.ToListAsync();
            var allTreasures = await dndDbContext.Treasures.ToListAsync();

            return new EditCharacterViewModel
            {
                Id = character.Id,
                CharacterName = character.CharacterName,
                CharacterClassId = character.CharacterClassId,
                CharacterRaceId = character.CharacterRaceId,
                Strength = character.Strength,
                Dexterity = character.Dexterity,
                Constitution = character.Constitution,
                Intelligence = character.Intelligence,
                Wisdom = character.Wisdom,
                Charisma = character.Charisma,
                Level = character.Level,
                ExperiencePoints = character.ExperiencePoints,
                ProficiencyBonus = character.ProficiencyBonus,
                ArmorClass = character.ArmorClass,
                Speed = character.Speed,
                Age = character.Age,
                Height = character.Height,
                Weight = character.Weight,
                Eyes = character.Eyes,
                Skin = character.Skin,
                Hair = character.Hair,
                PersonalityTraits = character.PersonalityTraits,
                Ideals = character.Ideals,
                Bonds = character.Bonds,
                Flaws = character.Flaws,
                CharacterBackstory = character.CharacterBackstory,
                Alignment = character.Alignment,
                EncumbranceStatus = character.EncumbranceStatus,
                CharacterImage = character.CharacterImage,
                Gender = character.Gender,
                HitPoints_Current = character.HitPoints_Current,
                HitPoints_Total = character.HitPoints_Total,
                Initiative = character.Initiative,
                TotalWeight = character.TotalWeight,

                // Ensure all skills are listed, including unselected ones
                CharacterSkills = allSkills.Select(skill => new CharacterSkillRequest
                {
                    SkillId = skill.Id,
                    IsProficient = character.CharacterSkills.Any(cs => cs.SkillId == skill.Id && cs.IsProficient),
                    Bonus = character.CharacterSkills.FirstOrDefault(cs => cs.SkillId == skill.Id)?.Bonus ?? 0
                }).ToList(),

                // Ensure all spells are listed, including unselected ones
                CharacterSpells = allSpells.Select(spell => new CharacterSpellRequest
                {
                    SpellId = spell.Id,
                    IsLearned = character.CharacterSpells.Any(cs => cs.SpellId == spell.Id && cs.IsLearned)
                }).ToList(),

                // Ensure all items are listed, including unselected ones
                CharacterItems = allItems.Select(item => new CharacterItemRequest
                {
                    ItemId = item.Id,
                    Quantity = character.CharacterItems.FirstOrDefault(ci => ci.ItemId == item.Id)?.Quantity ?? 0
                }).ToList(),

                // Ensure all treasures are listed, including unselected ones
                CharacterTreasures = allTreasures.Select(treasure => new CharacterTreasureRequest
                {
                    TreasureId = treasure.Id,
                    Quantity = character.CharacterTreasures.FirstOrDefault(ct => ct.TreasureId == treasure.Id)?.Quantity ?? 0
                }).ToList()
            };
        }

        public async Task<List<Character>> GetUserCharactersAsync(string userId)
        {
            if (!Guid.TryParse(userId, out var userGuid))
            {
                return new List<Character>(); // Prevent error by returning an empty list
            }

            return await dndDbContext.Characters
                .Where(c => c.UserId == userGuid)  // Apply filtering first for performance
                .Include(c => c.CharacterClass)
                .Include(c => c.CharacterRace)
                .Include(c => c.CharacterSkills).ThenInclude(cs => cs.Skill)
                .Include(c => c.CharacterSpells).ThenInclude(cs => cs.Spell)
                .Include(c => c.CharacterItems).ThenInclude(ci => ci.Item)
                .Include(c => c.CharacterTreasures).ThenInclude(ct => ct.Treasure)
                .ToListAsync();
        }

        public async Task<Character?> UpdateCharacterAsync(int id, EditCharacterViewModel editCharacterRequest)
        {
            var character = await dndDbContext.Characters
                .Include(c => c.CharacterClass)
                .Include(c => c.CharacterRace)
                .Include(c => c.CharacterSkills)
                .Include(c => c.CharacterSpells)
                .Include(c => c.CharacterItems)
                .Include(c => c.CharacterTreasures)
                .FirstOrDefaultAsync(c => c.Id == id);

            if (character == null)
                return null;

            var sanitizer = new HtmlSanitizer();
            editCharacterRequest.CharacterBackstory = sanitizer.Sanitize(editCharacterRequest.CharacterBackstory);

            character.CharacterName = editCharacterRequest.CharacterName;
            character.CharacterClassId = editCharacterRequest.CharacterClassId;
            character.CharacterRaceId = editCharacterRequest.CharacterRaceId;
            character.Strength = editCharacterRequest.Strength;
            character.Dexterity = editCharacterRequest.Dexterity;
            character.Constitution = editCharacterRequest.Constitution;
            character.Intelligence = editCharacterRequest.Intelligence;
            character.Wisdom = editCharacterRequest.Wisdom;
            character.Charisma = editCharacterRequest.Charisma;
            character.Level = editCharacterRequest.Level;
            character.ExperiencePoints = editCharacterRequest.ExperiencePoints;
            character.Speed = editCharacterRequest.Speed;
            character.Age = editCharacterRequest.Age;
            character.Height = editCharacterRequest.Height;
            character.Weight = editCharacterRequest.Weight;
            character.Eyes = editCharacterRequest.Eyes;
            character.Skin = editCharacterRequest.Skin;
            character.Hair = editCharacterRequest.Hair;
            character.PersonalityTraits = editCharacterRequest.PersonalityTraits;
            character.Ideals = editCharacterRequest.Ideals;
            character.Bonds = editCharacterRequest.Bonds;
            character.Flaws = editCharacterRequest.Flaws;
            character.CharacterBackstory = editCharacterRequest.CharacterBackstory;
            character.Alignment = editCharacterRequest.Alignment;
            character.CharacterImage = editCharacterRequest.CharacterImage;
            character.Gender = editCharacterRequest.Gender;
            character.HitPoints_Current = editCharacterRequest.HitPoints_Current;
            character.HitPoints_Total = editCharacterRequest.HitPoints_Total;
            character.Initiative = editCharacterRequest.Initiative;
            character.TotalWeight = editCharacterRequest.TotalWeight;

            // Fetch and update CharacterClass reference
            var newCharacterClass = await dndDbContext.CharacterClasses.FirstOrDefaultAsync(c => c.Id == editCharacterRequest.CharacterClassId);
            if (newCharacterClass != null)
                character.CharacterClass = newCharacterClass;

            // Update Character Skills
            foreach (var selectedSkill in editCharacterRequest.CharacterSkills)
            {
                var existingSkill = character.CharacterSkills.FirstOrDefault(cs => cs.SkillId == selectedSkill.SkillId);
                if (existingSkill != null)
                {
                    existingSkill.IsProficient = selectedSkill.IsProficient;
                    existingSkill.Bonus = selectedSkill.IsProficient ? HelperMethods.CalculateProficiencyBonus(character.Level) : 0;
                }
                else
                {
                    character.CharacterSkills.Add(new CharacterSkill
                    {
                        SkillId = selectedSkill.SkillId,
                        IsProficient = selectedSkill.IsProficient,
                        Bonus = selectedSkill.IsProficient ? HelperMethods.CalculateProficiencyBonus(character.Level) : 0
                    });
                }
            }

            // Update Character Spells
            foreach (var selectedSpell in editCharacterRequest.CharacterSpells)
            {
                var existingSpell = character.CharacterSpells.FirstOrDefault(cs => cs.SpellId == selectedSpell.SpellId);
                if (existingSpell != null)
                {
                    existingSpell.IsLearned = selectedSpell.IsLearned;
                }
                else if (selectedSpell.IsLearned)
                {
                    character.CharacterSpells.Add(new CharacterSpell
                    {
                        SpellId = selectedSpell.SpellId,
                        CharacterId = character.Id,
                        IsLearned = true
                    });
                }
            }

            // Update Character Items safely
            var itemsToRemove = new List<CharacterItem>();
            foreach (var selectedItem in editCharacterRequest.CharacterItems)
            {
                var existingItem = character.CharacterItems.FirstOrDefault(ci => ci.ItemId == selectedItem.ItemId);
                if (existingItem != null)
                {
                    if (selectedItem.Quantity > 0)
                        existingItem.Quantity = selectedItem.Quantity;
                    else
                        itemsToRemove.Add(existingItem);
                }
                else if (selectedItem.Quantity > 0)
                {
                    character.CharacterItems.Add(new CharacterItem
                    {
                        ItemId = selectedItem.ItemId,
                        CharacterId = character.Id,
                        Quantity = selectedItem.Quantity
                    });
                }
            }
            foreach (var item in itemsToRemove)
                character.CharacterItems.Remove(item);

            // Update Character Treasures safely
            var treasuresToRemove = new List<CharacterTreasure>();
            foreach (var selectedTreasure in editCharacterRequest.CharacterTreasures)
            {
                var existingTreasure = character.CharacterTreasures.FirstOrDefault(ct => ct.TreasureId == selectedTreasure.TreasureId);
                if (existingTreasure != null)
                {
                    if (selectedTreasure.Quantity > 0)
                        existingTreasure.Quantity = selectedTreasure.Quantity;
                    else
                        treasuresToRemove.Add(existingTreasure);
                }
                else if (selectedTreasure.Quantity > 0)
                {
                    character.CharacterTreasures.Add(new CharacterTreasure
                    {
                        TreasureId = selectedTreasure.TreasureId,
                        CharacterId = character.Id,
                        Quantity = selectedTreasure.Quantity
                    });
                }
            }
            foreach (var treasure in treasuresToRemove)
                character.CharacterTreasures.Remove(treasure);

            // Recalculate Armor Class and Proficiency Bonus at the end
            character.ArmorClass = HelperMethods.CalculateArmorClass(character);
            character.ProficiencyBonus = HelperMethods.CalculateProficiencyBonus(character.Level);

            await dndDbContext.SaveChangesAsync();
            return character;
        }

        public async Task LoadViewBagDataAsync(ViewDataDictionary viewData)
        {
            viewData["Classes"] = await dndDbContext.CharacterClasses.ToListAsync();
            viewData["Races"] = await dndDbContext.CharacterRaces.ToListAsync();
            viewData["Skills"] = await dndDbContext.Skills.ToListAsync();
            viewData["Spells"] = await dndDbContext.Spells.ToListAsync();
            viewData["Items"] = await dndDbContext.Items.ToListAsync();
            viewData["Treasures"] = await dndDbContext.Treasures.ToListAsync();
            // Ensure these are properly assigned
            var alignments = HelperMethods.GetAlignments();
            var genders = HelperMethods.GetGender();

            if (alignments != null) viewData["Alignments"] = alignments;
            if (genders != null) viewData["Gender"] = genders;
        }


    }
}
