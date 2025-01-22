using DND_App.Web.Data;
using DND_App.Web.Models.Domain;
using DND_App.Web.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using DND_App.Web.Models.ViewModels;
using Ganss.Xss;
using System.Reflection;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Text.RegularExpressions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DND_App.Web.Controllers
{
    public class CharacterController : Controller
    {
        private readonly ICharacterRepository characterRepository;
        private readonly UserManager<IdentityUser> userManager;
        private readonly DnDDbContext dndDbContext;

        public CharacterController(ICharacterRepository characterRepository, UserManager<IdentityUser> userManager, DnDDbContext dndDbContext)
        {
            this.characterRepository = characterRepository;
            this.userManager = userManager;
            this.dndDbContext = dndDbContext;
        }

        [HttpGet]
        public IActionResult Create()
        {
            // Pass classes and races to the view
            ViewBag.Classes = dndDbContext.CharacterClasses.ToList();
            ViewBag.Races = dndDbContext.CharacterRaces.ToList();
            
            // Fetch available skills
            var skills = dndDbContext.Skills.ToList();
            ViewBag.Skills = skills;

            // Fetch available spells
            var spells = dndDbContext.Spells.ToList();
            ViewBag.Spells = spells;

            // Fetch available items
            var items = dndDbContext.Items.ToList();
            ViewBag.Items = items;

            // Fetch available treasures
            var treasures = dndDbContext.Treasures.ToList();
            ViewBag.Treasures = treasures;

            // Create a CreateCharacterViewModel with initial values
            var characterViewModel = new CreateCharacterViewModel
            {
                // Initialize CharacterSkills
                CharacterSkills = skills.Select(s => new CharacterSkillRequest
                {
                    SkillId = s.Id,
                    IsProficient = false,
                    Bonus = 0
                }).ToList(),

                // Initialize CharacterSpells
                CharacterSpells = spells.Select(sp => new CharacterSpellRequest
                {
                    SpellId = sp.Id,
                    IsLearned = false 
                }).ToList(),

                // Initialize CharacterItems
                CharacterItems = items.Select(ci => new CharacterItemRequest
                {
                    ItemId = ci.Id,
                    Quantity = 0
                }).ToList(),

                // Initialize CharacterTreasures
                CharacterTreasures = treasures.Select(ct => new CharacterTreasureRequest
                {
                    TreasureId = ct.Id,
                    Quantity = 0
                }).ToList()
            };

            return View(characterViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateCharacterViewModel createCharacterViewModel)
        {
            // Check if the form submission is valid
            if (!ModelState.IsValid)
            {
                // Reload dropdown data in case of invalid submission
                //If validation fails, the lists need to be reloaded so the form can display them.
                ViewBag.Classes = dndDbContext.CharacterClasses.ToList();
                ViewBag.Races = dndDbContext.CharacterRaces.ToList();
                ViewBag.Skills = dndDbContext.Skills.ToList();
                ViewBag.Spells = dndDbContext.Spells.ToList();
                ViewBag.Items = dndDbContext.Items.ToList();
                ViewBag.Treasure = dndDbContext.Treasures.ToList();

                #region Debug to check model state
                //var spells = dndDbContext.Spells.ToList();
                //foreach (var spell in spells)
                //{
                //    Console.WriteLine($"Id: {spell.Id}, Name: {spell.Name}");
                //} 

                ////Keep this code to check for errors in ModelState!!
                //foreach (var error in ModelState.Values.SelectMany(v => v.Errors))
                //{
                //    Console.WriteLine(error.ErrorMessage);
                //}

                //Console.WriteLine($"CharacterSpells Count: {characterViewModel.CharacterSpells.Count}");
                //foreach (var spell in characterViewModel.CharacterSpells)
                //{
                //    Console.WriteLine($"Id: {spell.Id}, IsLearned: {spell.IsLearned}");
                //}
                //foreach (var key in Request.Form.Keys)
                //{
                //    Console.WriteLine($"{key}: {Request.Form[key]}");
                //}
                #endregion

                // Return the form with validation errors
                return View(createCharacterViewModel);
            }

            // Get the currently logged-in loggedInUser
            var loggedInUser = await userManager.GetUserAsync(User);

            // Sanitize the CharacterBackstory to prevent malicious input
            var sanitizer = new HtmlSanitizer();
            createCharacterViewModel.CharacterBackstory = sanitizer.Sanitize(createCharacterViewModel.CharacterBackstory);

            // Map the CreateCharacterViewModel to a new Character entity
            var characterDomainModel = new Character
            {
                // User-related properties
                UserId = Guid.Parse(loggedInUser.Id), // Associate the characterDomainModel with the logged-in loggedInUser
                PlayerName = loggedInUser.UserName, // Use the loggedInUser's username as the player name

                // General characterDomainModel properties
                CharacterName = createCharacterViewModel.CharacterName,
                CharacterClassId = createCharacterViewModel.CharacterClassId,
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
                ProficiencyBonus = createCharacterViewModel.ProficiencyBonus,
                ArmorClass = createCharacterViewModel.ArmorClass,
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
                HitPoints_Current = createCharacterViewModel.HitPoints_Current,
                HitPoints_Total = createCharacterViewModel.HitPoints_Total,
                Initiative = createCharacterViewModel.Initiative,
                TotalWeight = createCharacterViewModel.TotalWeight,

                // Map CharacterSkills from the request
                CharacterSkills = createCharacterViewModel.CharacterSkills
                    .Select(cs => new CharacterSkill
                    {
                        SkillId = cs.SkillId,
                        IsProficient = cs.IsProficient,
                        Bonus = cs.Bonus
                    }).ToList(),

                // Map CharacterSpells from the request
                CharacterSpells = createCharacterViewModel.CharacterSpells
                    .Select(cs => new CharacterSpell
                    {
                        SpellId = cs.SpellId,
                        IsLearned = cs.IsLearned
                    }).ToList(),

                // Map CharacterItems from the request
                CharacterItems = createCharacterViewModel.CharacterItems
                    .Select(ci => new CharacterItem
                    {
                        ItemId = ci.ItemId,
                        Quantity = ci.Quantity
                    }).ToList(),

                // Map CharacterTreasures from the request
                CharacterTreasures = createCharacterViewModel.CharacterTreasures
                    .Select(ct => new CharacterTreasure
                    {
                        TreasureId = ct.TreasureId,
                        Quantity = ct.Quantity
                    }).ToList()
            };

            // Save the new characterDomainModel using the repository
            await characterRepository.CreateAsync(characterDomainModel);

            // Redirect to the details page for the newly created characterDomainModel
            return RedirectToAction("Details", new { id = characterDomainModel.Id });
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            // Retrieve the characterDomainModel by ID, including related entities
            var character = dndDbContext.Characters
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
                .FirstOrDefault(c => c.Id == id);

            // Check if the characterDomainModel exists
            if (character == null)
                return NotFound();

            // Fetch all skills and spells to display in the details view
            ViewBag.Skills = dndDbContext.Skills.ToList();
            ViewBag.Spells = dndDbContext.Spells.ToList();
            ViewBag.Items = dndDbContext.Items.ToList();
            ViewBag.Treasure = dndDbContext.Treasures.ToList();

            // Pass the characterDomainModel entity to the view for display
            return View(character);
        }

        [HttpGet]
        public async Task<IActionResult> ReadAll()
        {
            // Call the repository 
            var listAllCharacters = await characterRepository.ReadAllAsync();

            return View(listAllCharacters);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            // Fetch the characterDomainModel from the repository or database
            var character = await dndDbContext.Characters
                .Include(c => c.CharacterSkills) // Eagerly load CharacterSkills
                .ThenInclude(cs => cs.Skill)
                .Include(c => c.CharacterSpells) // Eagerly load CharacterSpells
                .ThenInclude(cs => cs.Spell)
                .Include(c => c.CharacterItems) // Eagerly load CharacterItems
                .ThenInclude(cs => cs.Item)
                .Include(c => c.CharacterTreasures) // Eagerly load CharacterItems
                .ThenInclude(cs => cs.Treasure)
                .FirstOrDefaultAsync(c => c.Id == id);

            
            // Return 404 if the characterDomainModel does not exist
            if (character == null)
            {
                return NotFound();//create another view that says "Character not found"
            }

            // Populate dropdown data for classes, races, skills, and spells
            ViewBag.Classes = await dndDbContext.CharacterClasses.ToListAsync();
            ViewBag.Races = await dndDbContext.CharacterRaces.ToListAsync();
            ViewBag.Skills = await dndDbContext.Skills.ToListAsync();
            ViewBag.Spells = await dndDbContext.Spells.ToListAsync();
            ViewBag.Items = await dndDbContext.Items.ToListAsync();
            ViewBag.Treasures = await dndDbContext.Treasures.ToListAsync();

            // Sanitize the backstory to prevent malicious input
            var sanitizer = new HtmlSanitizer();

            // Map CharacterSkills
            var skills = await dndDbContext.Skills.ToListAsync();
            var skillRequests = skills.Select(skill => new CharacterSkillRequest
            {
                SkillId = skill.Id,
                IsProficient = character.CharacterSkills.Any(cs => cs.SkillId == skill.Id && cs.IsProficient),
                Bonus = character.CharacterSkills.FirstOrDefault(cs => cs.SkillId == skill.Id)?.Bonus ?? 0
            }).ToList();

            // Map CharacterSpells
            var spells = await dndDbContext.Spells.ToListAsync();
            var spellRequests = spells.Select(spell => new CharacterSpellRequest
            {
                SpellId = spell.Id,
                IsLearned = character.CharacterSpells.Any(cs => cs.SpellId == spell.Id && cs.IsLearned) 
            }).ToList();

            // Map CharacterItems
            var items = await dndDbContext.Items.ToListAsync();
            var itemRequests = items.Select(item => new CharacterItemRequest
            {
                ItemId = item.Id,
                Quantity = character.CharacterItems
                    .Where(ci => ci.ItemId == item.Id)
                    .Select(ci => ci.Quantity)
                    .FirstOrDefault() // Use FirstOrDefault to get the quantity if it exists; otherwise, default to 0
            }).ToList();

            // Map CharacterTreasures
            var treasures = await dndDbContext.Treasures.ToListAsync();
            var treasureRequests = treasures.Select(treasure => new CharacterTreasureRequest
            {
                TreasureId = treasure.Id,
                Quantity = character.CharacterTreasures
                    .Where(ct => ct.TreasureId == treasure.Id)
                    .Select(ct => ct.Quantity)
                    .FirstOrDefault() // Use FirstOrDefault to get the quantity if it exists; otherwise, default to 0
            }).ToList();

            // Map the characterDomainModel data to the EditCharacterViewModel view model
            var editCharacterRequest = new EditCharacterViewModel
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
                PassiveWisdom = character.PassiveWisdom,
                Inspiration = character.Inspiration,
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

                CharacterSkills = skillRequests, 
                CharacterSpells = spellRequests,
                CharacterItems = itemRequests,
                CharacterTreasures = treasureRequests
            };

            // Return the edit view with the characterDomainModel data
            return View(editCharacterRequest); 
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, EditCharacterViewModel editCharacterRequest)
        {
            #region Debug suggestions
            //Console.WriteLine($"Character Name: {editCharacterRequest.CharacterName}");
            //Console.WriteLine($"Skills Count: {editCharacterRequest.CharacterSkills.Count}");
            //foreach (var skill in editCharacterRequest.CharacterSkills)
            //{
            //    Console.WriteLine($"SkillId: {skill.SkillId}, IsProficient: {skill.IsProficient}, Bonus: {skill.Bonus}");
            //}

            //Console.WriteLine($"Spells Count: {editCharacterRequest.CharacterSpells.Count}");
            //foreach (var spell in editCharacterRequest.CharacterSpells)
            //{
            //    Console.WriteLine($"SpellId: {spell.SpellId}, IsLearned: {spell.IsLearned}");
            //}
            //foreach (var key in Request.Form.Keys)
            //{
            //    Console.WriteLine($"{key}: {Request.Form[key]}");
            //}
            #endregion

            #region Check ModelState
            if (!ModelState.IsValid)
            {
                foreach (var error in ModelState)
                {
                    Console.WriteLine($"Key: {error.Key}, Error: {string.Join(", ", error.Value.Errors.Select(e => e.ErrorMessage))}");
                }
                return View(editCharacterRequest);

                ViewBag.Classes = await dndDbContext.CharacterClasses.ToListAsync();
                ViewBag.Races = await dndDbContext.CharacterRaces.ToListAsync();
                ViewBag.Skills = await dndDbContext.Skills.ToListAsync();
                ViewBag.Spells = await dndDbContext.Spells.ToListAsync();
                ViewBag.Items = await dndDbContext.Items.ToListAsync();
                ViewBag.Treasures = await dndDbContext.Treasures.ToListAsync();

                foreach (var key in Request.Form.Keys)
                {
                    Console.WriteLine($"{key}: {Request.Form[key]}");
                }

                return View(editCharacterRequest);
            }
            
            if (editCharacterRequest.CharacterItems.Any(ci => ci.Quantity < 0))
            {
                ModelState.AddModelError("", "Item quantity cannot be negative.");
                return View(editCharacterRequest);
            }
            #endregion

            #region Fetch the character from the database or return not found
            var character = await dndDbContext.Characters
                .Include(c => c.CharacterSkills)
                .Include(c => c.CharacterSpells)
                .Include(c => c.CharacterItems)
                .Include(c => c.CharacterTreasures)
                .FirstOrDefaultAsync(c => c.Id == id);

            if (character == null)
            {
                return NotFound();
            }

            #endregion

            #region Update character properties
            // Sanitize the backstory
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
            character.PassiveWisdom = editCharacterRequest.PassiveWisdom;
            character.Inspiration = editCharacterRequest.Inspiration;
            character.ProficiencyBonus = editCharacterRequest.ProficiencyBonus;
            character.ArmorClass = editCharacterRequest.ArmorClass;
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
            #endregion

            #region Update CharacterSkills
            foreach (var selectedSkill in editCharacterRequest.CharacterSkills)
            {
                var existingSkill = character.CharacterSkills.FirstOrDefault(cs => cs.SkillId == selectedSkill.SkillId);
                if (existingSkill != null)
                {
                    // Update existing skill
                    existingSkill.IsProficient = selectedSkill.IsProficient;

                    // If IsProficient is unchecked, set Bonus to 0
                    if (!selectedSkill.IsProficient)
                    {
                        existingSkill.Bonus = 0;
                    }
                    else
                    {
                        existingSkill.Bonus = selectedSkill.Bonus;
                    }
                }
                else
                {
                    // Add new skill
                    character.CharacterSkills.Add(new CharacterSkill
                    {
                        SkillId = selectedSkill.SkillId,
                        IsProficient = selectedSkill.IsProficient,
                        Bonus = selectedSkill.IsProficient ? selectedSkill.Bonus : 0 // Set Bonus to 0 if not proficient
                    });
                }
            }

            #endregion

            #region Update CharacterSpells
            foreach (var selectedSpell in editCharacterRequest.CharacterSpells)
            {
                var existingSpell = character.CharacterSpells
                    .FirstOrDefault(cs => cs.SpellId == selectedSpell.SpellId);

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
            #endregion

            #region Update CharacterItems
            foreach (var selectedItem in editCharacterRequest.CharacterItems)
            {
                var existingItem = character.CharacterItems
                    .FirstOrDefault(cs => cs.ItemId == selectedItem.ItemId);

                if (existingItem != null)//This is the updating portion
                {
                    existingItem.Quantity = selectedItem.Quantity;
                }
                else if (selectedItem.Quantity > 0)//This is the adding portion
                {
                    character.CharacterItems.Add(new CharacterItem
                    {
                        ItemId = selectedItem.ItemId,
                        CharacterId = character.Id,
                        Quantity = selectedItem.Quantity
                    });
                }
            }
            #endregion

            #region Update CharacterItems
            foreach (var selectedTreasure in editCharacterRequest.CharacterTreasures)
            {
                var existingTreasure = character.CharacterTreasures
                    .FirstOrDefault(ct => ct.TreasureId == selectedTreasure.TreasureId);

                if (existingTreasure != null)//This is the updating portion
                {
                    existingTreasure.Quantity = selectedTreasure.Quantity;
                }
                else if (selectedTreasure.Quantity > 0)//This is the adding portion
                {
                    character.CharacterTreasures.Add(new CharacterTreasure
                    {
                        TreasureId = selectedTreasure.TreasureId,
                        CharacterId = character.Id,
                        Quantity = selectedTreasure.Quantity
                    });
                }
            }
            #endregion

            #region Update DB and return
            await characterRepository.UpdateAsync(character);

            return RedirectToAction("Details", new { id = character.Id });
            #endregion
        }


        [HttpPost]
        [Route("Character/Delete")]
        public async Task<IActionResult> Delete(EditCharacterViewModel editCharacterRequest)
        {
            var deletedCharacter = await characterRepository.DeleteAsync(editCharacterRequest.Id);

            if (deletedCharacter != null)
            {
                return RedirectToAction("ReadAll");
            }

            return RedirectToAction("Edit", new {id = editCharacterRequest?.Id});
        }

        [HttpGet]
        public async Task<IActionResult> UserCharacters()
        {
            // Get the currently logged-in loggedInUser
            var user = await userManager.GetUserAsync(User);

            if (user == null)
            {
                return RedirectToAction("Login", "Accounts");
            }

            // Fetch characters created by the logged-in loggedInUser
            var userCharacters = await dndDbContext.Characters
                .Include(c => c.CharacterClass)
                .Include(c => c.CharacterRace)
                .Include(c => c.CharacterSkills)
                    .ThenInclude(cs => cs.Skill)
                .Include(c => c.CharacterSpells)
                    .ThenInclude(cs => cs.Spell)
                .Where(c => c.UserId == Guid.Parse(user.Id))
                .ToListAsync();

            return View(userCharacters);
        }

    }
}
