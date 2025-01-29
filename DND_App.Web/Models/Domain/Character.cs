using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DND_App.Web.Models.Domain
{
    public class Character
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        #region General Info
        public int Id { get; set; }
        public Guid UserId { get; set; }
        public IdentityUser<Guid> User { get; set; }
        public string? CharacterImage { get; set; }
        public string CharacterName { get; set; }
        public string PlayerName { get; set; }
        public int CharacterClassId { get; set; }
        public CharacterClass CharacterClass { get; set; }
        public int CharacterRaceId { get; set; }
        public CharacterRace CharacterRace { get; set; }
        public int Age { get; set; }
        public int Level { get; set; }
        public int ExperiencePoints { get; set; }
        public string? Alignment { get; set; }
        public string? Gender { get; set; }
        #endregion
        #region Attributes
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }
        #endregion
        #region Backstory
        public string? CharacterBackstory { get; set; }
        #endregion
        #region Combat
        public int HitPoints_Total { get; set; }
        public int HitPoints_Current { get; set; }
        public int PassiveWisdom { get; set; }
        public int ProficiencyBonus { get; set; }
        public int ArmorClass { get; set; }
        public int Speed { get; set; }
        public int Initiative { get; set; }
        public float TotalWeight { get; set; }
        public string? EncumbranceStatus { get; set; }

        #endregion
        #region Appearance
        public string? Height { get; set; }
        public string? Weight { get; set; }
        public string? Eyes { get; set; }
        public string? Skin { get; set; }
        public string? Hair { get; set; }
        #endregion
        #region Features and Traits
        public string? PersonalityTraits { get; set; }
        public string? Ideals { get; set; }
        public string? Bonds { get; set; }
        public string? Flaws { get; set; }
        public string Inspiration { get; set; }
        #endregion

        public ICollection<CharacterSkill> CharacterSkills { get; set; } = new List<CharacterSkill>();
        public ICollection<CharacterSpell> CharacterSpells { get; set; } = new List<CharacterSpell>();
        public ICollection<CharacterItem> CharacterItems { get; set; } = new List<CharacterItem>();
        public ICollection<CharacterTreasure> CharacterTreasures { get; set; } = new List<CharacterTreasure>();

    }
}
