using System.ComponentModel.DataAnnotations;

namespace DND_App.Web.Models.ViewModels
{
    public class CharacterRequest
    {
        [Required]
        public string CharacterName { get; set; }

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
        [Required]
        public int Level { get; set; } = 1;

        [Required]
        public int ExperiencePoints { get; set; } = 0;

        [Required]
        public int PassiveWisdom { get; set; } = 10;

        [Required]
        public bool Inspiration { get; set; } = false;

        [Required]
        public int ProficiencyBonus { get; set; } = 2;

        [Required]
        public int ArmorClass { get; set; } = 10;

        [Required]
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
        public string? Alignment { get; set; }
        public string? EncumbranceStatus { get; set; }
        public string? CharacterImage { get; set; }


        //public float TotalWeight { get; set; } = 0;
    }
}
