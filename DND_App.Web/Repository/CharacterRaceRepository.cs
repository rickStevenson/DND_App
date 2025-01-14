using DND_App.Web.Data;
using DND_App.Web.Models.Domain;
using DND_App.Web.Repository;
using Microsoft.EntityFrameworkCore;

namespace DND_App.Web.Repository
{
    public class CharacterRaceRepository : ICharacterRaceRepository
    {
        private readonly DnDDbContext dndDbContext;

        public CharacterRaceRepository(DnDDbContext dndDbContext)
        {
            this.dndDbContext = dndDbContext;
        }

        public async Task<IEnumerable<CharacterRace>> GetAllRacesAsync()
        {
            var races = await dndDbContext.CharacterRaces
                .Include(cr => cr.RaceAbilities)
                .Include(cr => cr.RaceWeaponProficiencies)
                .Include(cr => cr.RaceToolProficiencies)
                .ToListAsync();
            return races;
        }

        public async Task<CharacterRace> GetRaceByIdAsync(int id)
        {
            var race = await dndDbContext.CharacterRaces
                .Include(cr => cr.RaceAbilities)
                .Include(cr => cr.RaceWeaponProficiencies)
                .Include(cr => cr.RaceToolProficiencies)
                .FirstOrDefaultAsync(cr => cr.Id == id);

            if (race == null)
            {
                throw new ArgumentException("Invalid race ID");
            }
            return race;
        }
    }
}

