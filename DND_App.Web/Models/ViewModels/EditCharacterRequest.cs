using System.ComponentModel.DataAnnotations;

namespace DND_App.Web.Models.ViewModels
{
    public class EditCharacterRequest
    {
        public int Id { get; set; }
        public string CharacterName { get; set; }
        public int CharacterClassId { get; set; }
        public int CharacterRaceId { get; set; }
        public int Strength { get; set; } = 15;
        public int Dexterity { get; set; } = 15;
        public int Constitution { get; set; } = 15;
        public int Intelligence { get; set; } = 15;
        public int Wisdom { get; set; } = 15;
        public int Charisma { get; set; } = 15;
        public int Level { get; set; } = 2;
        public int ExperiencePoints { get; set; } = 50;
        public int PassiveWisdom { get; set; } = 15;
        public bool Inspiration { get; set; } = false;
        public int ProficiencyBonus { get; set; } = 5;
        public int ArmorClass { get; set; } = 15;
        public int Speed { get; set; } = 35;
    }
}
