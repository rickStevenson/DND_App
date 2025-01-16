using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DND_App.Web.Models.Domain
{
    public class Character
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        //Images
        public string? CharacterImage { get; set; }

        // Link PlayerName to the User entity
        public Guid UserId { get; set; }
        public IdentityUser<Guid> User { get; set; }

        //General Info
        public string CharacterName { get; set; }
        public string PlayerName { get; set; }
        public int CharacterClassId { get; set; }
        public CharacterClass CharacterClass { get; set; }

        public int CharacterRaceId { get; set; }
        public CharacterRace CharacterRace { get; set; }

        public string? Age { get; set; }
        public int Level { get; set; }
        public int ExperiencePoints { get; set; }
        public string? Alignment { get; set; } = "Good";
        public string? Gender { get; set; }

        //Backstory
        public string? CharacterBackstory { get; set; }

        //Attributes
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }

        //Combat
        public int HitPoints_Total { get; set; }
        public int HitPoints_Current { get; set; }
        public int PassiveWisdom { get; set; }
        public bool Inspiration { get; set; }
        public int ProficiencyBonus { get; set; }
        public int ArmorClass { get; set; }
        public int Speed { get; set; }
        public int Initiative { get; set; }
        public float TotalWeight { get; set; }
        public string? EncumbranceStatus { get; set; }

        //Appearance
        public string? Height { get; set; }
        public string? Weight { get; set; }
        public string? Eyes { get; set; }
        public string? Skin { get; set; }
        public string? Hair { get; set; }

        //Character Traits & Features
        public string? PersonalityTraits { get; set; }
        public string? Ideals { get; set; }
        public string? Bonds { get; set; }
        public string? Flaws { get; set; }


        //Skills
        public ICollection<CharacterSkill> CharacterSkills { get; set; } = new List<CharacterSkill>();

        public ICollection<CharacterSpell> CharacterSpells { get; set; } = new List<CharacterSpell>();

        //public string? FeaturesAndTraits { get; set; }
        //public List<string>? AlliesAndOrganizations { get; set; }
        //public List<string>? Languages { get; set; }
        //public List<string>? Equipment { get; set; }


        //public Attack? Attacks { get; set; }
        //public Treasure? Treasure { get; set; }
    }
}
