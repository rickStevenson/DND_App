using System.ComponentModel.DataAnnotations;

namespace DND_App.Web.Models.ViewModels
{
    public class EditCharacterViewModel
    {
        #region General Info
        public int Id { get; set; }
        public string? CharacterImage { get; set; }
        [Required(ErrorMessage = "Character Name is required.")]
        public string CharacterName { get; set; }

        [Required(ErrorMessage = "Character Class is required.")]
        public int CharacterClassId { get; set; }

        [Required(ErrorMessage = "Character Race is required.")]
        public int CharacterRaceId { get; set; }
        
        [Range(1, 30, ErrorMessage = "Level must be between 1 and 30.")]
        public int Level { get; set; } = 1;
        public int ExperiencePoints { get; set; } = 0;

        [Required(ErrorMessage = "Alignment is required.")]
        public string Alignment { get; set; }
        public int Age { get; set; }

        [Required(ErrorMessage = "Gender is required.")]
        public string Gender { get; set; }
        #endregion
        #region Attributes
        [Range(1, 20, ErrorMessage = "Strength must be between 1 and 20.")]
        public int Strength { get; set; } = 1;
        [Range(1, 20, ErrorMessage = "Dexterity must be between 1 and 20.")]
        public int Dexterity { get; set; } = 1;
        [Range(1, 20, ErrorMessage = "Constitution must be between 1 and 20.")]
        public int Constitution { get; set; } = 1;
        [Range(1, 20, ErrorMessage = "Intelligence must be between 1 and 20.")]
        public int Intelligence { get; set; } = 1;
        [Range(1, 20, ErrorMessage = "Wisdom must be between 1 and 20.")]
        public int Wisdom { get; set; } = 1;
        [Range(1, 20, ErrorMessage = "Charisma must be between 1 and 20.")]
        public int Charisma { get; set; } = 1;
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
        [Range(10, 40, ErrorMessage = "Attributes must be between 10 and 40.")]
        public int ArmorClass { get; set; } = 10;
        public int Speed { get; set; } = 30;
        public int HitPoints_Total { get; set; }

        public int HitPoints_Current { get; set; }
        public int PassiveWisdom { get; set; }
        public int ProficiencyBonus { get; set; }
        public string? EncumbranceStatus { get; set; }
        public int Initiative { get; set; }
        public float TotalWeight { get; set; }
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
