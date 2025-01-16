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
            var skills = dndDbContext.Skills.ToList();
            ViewBag.Skills = skills;

            var characterRequest = new CharacterRequest
            {
                CharacterSkills = skills.Select(s => new CharacterSkillRequest
                {
                    SkillId = s.Id,
                    IsProficient = false,
                    Bonus = 0
                }).ToList()
            };

            ViewBag.Classes = dndDbContext.CharacterClasses.ToList();
            ViewBag.Races = dndDbContext.CharacterRaces.ToList();

            return View(characterRequest);
        }


        [HttpPost]
        public async Task<IActionResult> Create(CharacterRequest characterRequest)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Classes = dndDbContext.CharacterClasses.ToList();
                ViewBag.Races = dndDbContext.CharacterRaces.ToList();
                ViewBag.Skills = dndDbContext.Skills.ToList();
                return View(characterRequest);
            }

            var user = await userManager.GetUserAsync(User);

            var sanitizer = new HtmlSanitizer();
            characterRequest.CharacterBackstory = sanitizer.Sanitize(characterRequest.CharacterBackstory);

            var character = new Character
            {
                CharacterName = characterRequest.CharacterName,
                CharacterClassId = characterRequest.CharacterClassId,
                CharacterRaceId = characterRequest.CharacterRaceId,
                Strength = characterRequest.Strength,
                Dexterity = characterRequest.Dexterity,
                Constitution = characterRequest.Constitution,
                Intelligence = characterRequest.Intelligence,
                Wisdom = characterRequest.Wisdom,
                Charisma = characterRequest.Charisma,
                Level = characterRequest.Level,
                ExperiencePoints = characterRequest.ExperiencePoints,
                PassiveWisdom = characterRequest.PassiveWisdom,
                Inspiration = characterRequest.Inspiration,
                ProficiencyBonus = characterRequest.ProficiencyBonus,
                ArmorClass = characterRequest.ArmorClass,
                Speed = characterRequest.Speed,

                // User-related properties
                UserId = Guid.Parse(user.Id),
                PlayerName = user.UserName,

                // Nullable properties - optional mapping
                Age = characterRequest.Age,
                Height = characterRequest.Height,
                Weight = characterRequest.Weight,
                Eyes = characterRequest.Eyes,
                Skin = characterRequest.Skin,
                Hair = characterRequest.Hair,
                PersonalityTraits = characterRequest.PersonalityTraits,
                Ideals = characterRequest.Ideals,
                Bonds = characterRequest.Bonds,
                Flaws = characterRequest.Flaws,
                CharacterBackstory = characterRequest.CharacterBackstory,
                Alignment = characterRequest.Alignment,
                EncumbranceStatus = characterRequest.EncumbranceStatus,
                CharacterImage = characterRequest.CharacterImage,
                Gender = characterRequest.Gender,
                HitPoints_Current = characterRequest.HitPoints_Current,
                HitPoints_Total = characterRequest.HitPoints_Total,
                Initiative = characterRequest.Initiative,
                TotalWeight = characterRequest.TotalWeight,

                CharacterSkills = characterRequest.CharacterSkills.Select(cs => new CharacterSkill
                {
                    SkillId = cs.SkillId,
                    IsProficient = cs.IsProficient,
                    Bonus = cs.Bonus
                }).ToList()

            };
            foreach (var key in Request.Form.Keys)
            {
                Console.WriteLine($"{key}: {Request.Form[key]}");
            }
            foreach (var skill in characterRequest.CharacterSkills)
            {
                Console.WriteLine($"SkillId: {skill.SkillId}, IsProficient: {skill.IsProficient}, Bonus: {skill.Bonus}");
            }
            await characterRepository.CreateAsync(character);

            return RedirectToAction("Details", new { id = character.Id });
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var character = dndDbContext.Characters
                .Include(c => c.CharacterClass)
                .Include(c => c.CharacterRace)
                .Include(c => c.CharacterSkills)
                    .ThenInclude(cs => cs.Skill)
                .FirstOrDefault(c => c.Id == id);

            if (character != null)
            {
                foreach(var skill in character.CharacterSkills)
                {
                    Console.WriteLine($"SkillId: {skill.SkillId}, IsProficient: {skill.IsProficient}, Bonus: {skill.Bonus}");
                }
            }
            if (character == null)
                return NotFound();

            ViewBag.Skills = dndDbContext.Skills.ToList();

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
            // Fetch the character from the repository or database
            var character = await characterRepository.ReadByIdAsync(id);

            if (character == null)
            {
                return NotFound();
            }

            var sanitizer = new HtmlSanitizer();

            // Prepare the view model with the character's current data
            var editCharacterRequest = new EditCharacterRequest
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

                CharacterSkills = character.CharacterSkills.Select(cs => new CharacterSkillRequest
                {
                    SkillId = cs.SkillId,
                    IsProficient = cs.IsProficient,
                    Bonus = cs.Bonus
                }).ToList()
            };

            // Populate the ViewBag for dropdowns (Character Classes and Races)
            ViewBag.Classes = dndDbContext.CharacterClasses.ToList();
            ViewBag.Races = dndDbContext.CharacterRaces.ToList();
            ViewBag.Skills = dndDbContext.Skills.ToList();

            return View(editCharacterRequest); // Return the edit view
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, EditCharacterRequest editCharacterRequest)
        {
            if (!ModelState.IsValid)
            {
                // Repopulate the ViewBag if validation fails
                ViewBag.Classes = dndDbContext.CharacterClasses.ToList();
                ViewBag.Races = dndDbContext.CharacterRaces.ToList();
                ViewBag.Skills = dndDbContext.Skills.ToList();

                return View(editCharacterRequest); // Return the view with errors
            }

            // Fetch the character from the repository
            var character = await characterRepository.ReadByIdAsync(id);

            if (character == null)
            {
                return NotFound(); // Return 404 if character doesn't exist
            }

            var sanitizer = new HtmlSanitizer();
            editCharacterRequest.CharacterBackstory = sanitizer.Sanitize(editCharacterRequest.CharacterBackstory);

            // Update the character properties with the new data
            character.Id = editCharacterRequest.Id;
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

            character.CharacterSkills = editCharacterRequest.CharacterSkills.Select(cs => new CharacterSkill
            {
                SkillId = cs.SkillId,
                IsProficient = cs.IsProficient,
                Bonus = cs.Bonus
            }).ToList();

            // Save changes via the repository
            await characterRepository.UpdateAsync(character);

            // Redirect to the Details view or another appropriate page
            return RedirectToAction("Details", new { id = character.Id });
        }

        [HttpPost]
        [Route("Character/Delete")]
        public async Task<IActionResult> Delete(EditCharacterRequest editCharacterRequest)
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
            // Get the currently logged-in user
            var user = await userManager.GetUserAsync(User);

            if (user == null)
            {
                return RedirectToAction("Login", "Accounts");
            }

            // Fetch characters created by the logged-in user
            var userCharacters = await dndDbContext.Characters
                .Include(c => c.CharacterClass)
                .Include(c => c.CharacterRace)
                .Include(c => c.CharacterSkills)
                    .ThenInclude(cs => cs.Skill)
                .Where(c => c.UserId == Guid.Parse(user.Id))
                .ToListAsync();

            return View(userCharacters);
        }

    }
}
