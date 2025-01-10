using DND_App.Web.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DND_App.Web.Controllers
{
    public class CharacterClassController : Controller
    {
        private readonly ICharacterClassRepository characterClassRepository;

        public CharacterClassController(ICharacterClassRepository characterClassRepository)
        {
            this.characterClassRepository = characterClassRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetClassById(int id)
        {
            var characterClass = await characterClassRepository.GetClassByIdAsync(id);
            return View(characterClass);
        }
        [HttpGet]
        public async Task<IActionResult> GetAllClasses()
        {
            var allClasses = await characterClassRepository.GetAllClassesAsync();
            return View(allClasses);
        }
    }
}
