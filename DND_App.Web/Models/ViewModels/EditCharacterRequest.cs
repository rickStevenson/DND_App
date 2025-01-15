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

        //Character Traits
        public string? Age { get; set; }
        public string? Height { get; set; }
        public string? Weight { get; set; }
        public string? Eyes { get; set; }
        public string? Skin { get; set; }
        public string? Hair { get; set; }
        public string? PersonalityTraits { get; set; }
        public string? Ideals { get; set; }
        public string? Bonds { get; set; }
        public string? Flaws { get; set; }
        public string? CharacterBackstory { get; set; }
        public string? Alignment { get; set; }
        public string? EncumbranceStatus { get; set; }
        public float TotalWeight { get; set; } = 0;
        public string? CharacterImage { get; set; }
        public string Gender { get; set; }
        public int HitPoints_Current { get; set; }
        public int HitPoints_Total { get; set; }
        public int Initiative { get; set; }

        public List<CharacterSkillRequest> CharacterSkills { get; set; } = new List<CharacterSkillRequest>();
    }
}
