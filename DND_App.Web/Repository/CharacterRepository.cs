using DND_App.Web.Data;
using DND_App.Web.Models.Domain;
using DND_App.Web.Data;
using Microsoft.EntityFrameworkCore;

namespace DND_App.Web.Repository
{
    public class CharacterRepository : ICharacterRepository
    {
        private readonly DnDDbContext dndDbContext;

        public CharacterRepository(DnDDbContext dndDbContext)
        {
            this.dndDbContext = dndDbContext;
        }

        public async Task<Character> CreateAsync(Character character)
        {
            await dndDbContext.AddAsync(character);
            await dndDbContext.SaveChangesAsync();
            return character;
        }

        public async Task<IEnumerable<Character>> ReadAllAsync()
        {
            return await dndDbContext.Characters
                .Include(c => c.CharacterClass)
                .Include(c => c.CharacterRace)
                .ToListAsync();
        }

        public Task<Character?> ReadByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Character?> UpdateAsync(Character character)
        {
            throw new NotImplementedException();
        }
        public Task<Character?> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
