using DND_App.Web.Models.Domain;

namespace DND_App.Web.Repository
{
    public interface ICharacterClassRepository
    {
        Task<CharacterClass> GetClassByIdAsync(int id);
        Task<IEnumerable<CharacterClass>> GetAllClassesAsync();
    }
}
