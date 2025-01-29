using System.ComponentModel.DataAnnotations;

namespace DND_App.Web.Models.ViewModels
{
    public class CreateCharacterViewModel
    {
        #region General Info
        public string? CharacterImage { get; set; }
        [Required]
        public string CharacterName { get; set; } = "Donger";

        [Required]
        public int CharacterClassId { get; set; }

        [Required]
        public int CharacterRaceId { get; set; }
        public int Level { get; set; } = 1;
        public int ExperiencePoints { get; set; } = 0;
        public string? Alignment { get; set; }
        public int Age { get; set; } = 0;
        public string Gender { get; set; } = "Male";

        #endregion
        #region Attributes
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

        #endregion
        #region Backstory
        public string? CharacterBackstory { get; set; }
        #endregion
        #region Appearance
        public string? Height { get; set; }
        public string? Weight { get; set; }
        public string? Eyes { get; set; }
        public string? Skin { get; set; }
        public string? Hair { get; set; }
        #endregion
        #region Combat
        public int PassiveWisdom { get; set; } = 10;
        public int ProficiencyBonus { get; set; }
        public int ArmorClass { get; set; } = 10;
        public int Speed { get; set; } = 30;
        public string? EncumbranceStatus { get; set; }
        public int HitPoints_Total { get; set; } = 100;
        public int Initiative { get; set; } = 0;
        public float TotalWeight { get; set; } = 0;
        #endregion
        #region Features and Traits
        public string? PersonalityTraits { get; set; }
        public string? Ideals { get; set; }
        public string? Bonds { get; set; }
        public string? Flaws { get; set; }
        public string? Inspiration { get; set; }

        #endregion

        public List<CharacterSkillRequest> CharacterSkills { get; set; } = new List<CharacterSkillRequest>();
        public List<CharacterSpellRequest> CharacterSpells { get; set; } = new List<CharacterSpellRequest>();
        public List<CharacterItemRequest> CharacterItems { get; set; } = new List<CharacterItemRequest>();
        public List<CharacterTreasureRequest> CharacterTreasures { get; set; } = new List<CharacterTreasureRequest>();
    }
}
