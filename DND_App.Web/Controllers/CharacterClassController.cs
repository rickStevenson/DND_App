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
        public async Task<IActionResult> ClassDetails(int id)
        {
            try
            {
                var characterClass = await characterClassRepository.GetClassByIdAsync(id);
                return View(characterClass);
            }
            catch (ArgumentException)
            {
                return NotFound(); // Handle invalid ID
            }
        }


        [HttpGet]
        public async Task<IActionResult> GetAllClasses()
        {
            var allClasses = await characterClassRepository.GetAllClassesAsync();
            return View(allClasses);
        }
    }
}
