using DND_App.Web.Models.Domain;

namespace DND_App.Web.Repository
{
    public interface ICharacterRepository
    {
        Task<Character> CreateAsync(Character character);
        Task<IEnumerable<Character>> ReadAllAsync();
        Task<Character?> ReadByIdAsync(int id);
        Task<Character?> UpdateAsync(Character character);
        Task<Character?> DeleteAsync(int id);
    }
}
