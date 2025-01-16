using System.ComponentModel.DataAnnotations;

namespace DND_App.Web.Models.ViewModels
{
    public class CharacterRequest
    {
        [Required]
        public string CharacterName { get; set; } = "Dong";

        [Required]
        public int CharacterClassId { get; set; }

        [Required]
        public int CharacterRaceId { get; set; }

        // Required Attributes
        [Required]
        public int Strength { get; set; } = 21;

        [Required]
        public int Dexterity { get; set; } = 12;

        [Required]
        public int Constitution { get; set; } = 21;

        [Required]
        public int Intelligence { get; set; } = 12;

        [Required]
        public int Wisdom { get; set; } = 12;

        [Required]
        public int Charisma { get; set; } = 21;

        // Character Mechanics
        
        public int Level { get; set; } = 1;
        public int ExperiencePoints { get; set; } = 0;
        public int PassiveWisdom { get; set; } = 10;
        public bool Inspiration { get; set; } = false;
        public int ProficiencyBonus { get; set; } = 2;
        public int ArmorClass { get; set; } = 10;
        public int Speed { get; set; } = 30;

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
        public string? Alignment { get; set; } = "Good";
        public string? EncumbranceStatus { get; set; }
        public string? CharacterImage { get; set; }

        public string Gender { get; set; } = "Male";
        public int HitPoints_Current { get; set; } = 100;
        public int HitPoints_Total { get; set; } = 100;
        public int Initiative { get; set; } = 0;
        public float TotalWeight { get; set; } = 0;

        
        public List<CharacterSkillRequest> CharacterSkills { get; set; } = new List<CharacterSkillRequest>();
    }
}
