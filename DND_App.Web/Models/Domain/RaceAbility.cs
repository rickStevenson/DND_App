namespace DND_App.Web.Models.Domain
{
    public class RaceAbility
    {
        public int Id { get; set; } // Primary Key
        public string Name { get; set; }
        public int CharacterRaceId { get; set; } // Foreign Key
        public CharacterRace CharacterRace { get; set; } // Navigation Property
    }
}
