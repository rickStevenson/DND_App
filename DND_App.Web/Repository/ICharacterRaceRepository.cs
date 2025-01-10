using DND_App.Web.Models.Domain;

namespace DND_App.Web.Repository
{
    public interface ICharacterRaceRepository
    {
        Task<CharacterRace> GetRaceByIdAsync(int id);
        Task<IEnumerable<CharacterRace>> GetAllRacesAsync();
    }
}
