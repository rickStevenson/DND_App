using DND_App.Web.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DND_App.Web.Controllers
{
    public class CharacterRaceController : Controller
    {
        private readonly ICharacterRaceRepository characterRaceRepository;

        public CharacterRaceController(ICharacterRaceRepository characterRaceRepository)
        {
            this.characterRaceRepository = characterRaceRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetRaceById(int id)
        {
            var race = await characterRaceRepository.GetRaceByIdAsync(id);
            return View(race);
        }
        [HttpGet]
        public async Task<IActionResult> GetAllRaces()
        {
            var races = await characterRaceRepository.GetAllRacesAsync();
            return View(races);
        }
    }
}
