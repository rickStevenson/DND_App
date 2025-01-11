using DND_App.Web.Data;
using DND_App.Web.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace DND_App.Web.Repository
{
    public class CharacterClassRepository : ICharacterClassRepository
    {
        private readonly DnDDbContext dnDDbContext;

        public CharacterClassRepository(DnDDbContext dndDbContext)
        {
            this.dnDDbContext = dndDbContext;
        }

        public async Task<IEnumerable<CharacterClass>> GetAllClassesAsync()
        {
            var classes = await dnDDbContext.CharacterClasses
                .Include(a => a.ClassAbilities)
                .Include(st => st.ClassSavingThrows)
                .ToListAsync();

            return classes;
        }

        public async Task<CharacterClass> GetClassByIdAsync(int id)
        {
            var characterClass = await dnDDbContext.CharacterClasses.FindAsync(id);

            if (characterClass == null)
            {
                throw new ArgumentException("Invalid class ID");
            }
            return characterClass;
        }
    }
}
