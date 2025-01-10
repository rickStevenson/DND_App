using DND_App.Web.Data;
using DND_App.Web.Models.Domain;
using DND_App.Web.Repository;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using DND_App.Web.Models.ViewModels;

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
            ViewBag.Classes = dndDbContext.CharacterClasses.ToList();
            ViewBag.Races = dndDbContext.CharacterRaces.ToList();
            return View(new CharacterRequest());
        }

        [HttpPost]
        public async Task<IActionResult> Create(CharacterRequest characterRequest)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Classes = dndDbContext.CharacterClasses.ToList();
                ViewBag.Races = dndDbContext.CharacterRaces.ToList();
                return View(characterRequest);
            }

            var user = await userManager.GetUserAsync(User);

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
                Level = characterRequest.Level, // Default Level to 1 if null
                ExperiencePoints = characterRequest.ExperiencePoints,
                PassiveWisdom = characterRequest.PassiveWisdom,
                Inspiration = characterRequest.Inspiration,
                ProficiencyBonus = characterRequest.ProficiencyBonus,
                ArmorClass = characterRequest.ArmorClass,
                Speed = characterRequest.Speed,

                // User-related properties
                UserId = Guid.Parse(user.Id),
                PlayerName = user.UserName

                //TotalWeight = characterRequest.TotalWeight,

                //// Nullable properties - optional mapping
                //Age = characterRequest.Age,
                //Height = characterRequest.Height,
                //Weight = characterRequest.Weight,
                //Eyes = characterRequest.Eyes,
                //Skin = characterRequest.Skin,
                //Hair = characterRequest.Hair,
                //PersonalityTraits = characterRequest.PersonalityTraits,
                //Ideals = characterRequest.Ideals,
                //Bonds = characterRequest.Bonds,
                //Flaws = characterRequest.Flaws,
                //CharacterBackstory = characterRequest.CharacterBackstory,
                //Alignment = characterRequest.Alignment,
                //EncumbranceStatus = characterRequest.EncumbranceStatus,
                //CharacterImage = characterRequest.CharacterImage,


            };

            await characterRepository.CreateAsync(character);

            return RedirectToAction("Details", new { id = character.Id });
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var character = dndDbContext.Characters
                .Include(c => c.CharacterClass)
                .Include(c => c.CharacterRace)
                .FirstOrDefault(c => c.Id == id);

            if (character == null)
                return NotFound();

            return View(character);
        }

        [HttpGet]
        public async Task<IActionResult> ReadAll()
        {
            // Call the repository 
            var listAllCharacters = await characterRepository.ReadAllAsync();

            return View(listAllCharacters);
        }
    }
}
