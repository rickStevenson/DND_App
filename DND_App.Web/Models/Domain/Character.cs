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
        public string CharacterName { get; set; }
        public string PlayerName { get; set; }

        // Link PlayerName to the User entity
        public Guid UserId { get; set; }
        public IdentityUser<Guid> User { get; set; }

        // Foreign key to CharacterClass
        public int CharacterClassId { get; set; }
        public CharacterClass CharacterClass { get; set; }

        // Foreign key to CharacterRace
        public int CharacterRaceId { get; set; }
        public CharacterRace CharacterRace { get; set; }


        //Attributes
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }

        //Character Mechanics
        public int Level { get; set; }
        public int ExperiencePoints { get; set; }
        public int PassiveWisdom { get; set; }
        public bool Inspiration { get; set; }
        public int ProficiencyBonus { get; set; }
        public int ArmorClass { get; set; }
        public int Speed { get; set; }

        ////Character Traits
        //public string? Age { get; set; }
        //public string? Height { get; set; }
        //public string? Weight { get; set; }
        //public string? Eyes { get; set; }
        //public string? Skin { get; set; }
        //public string? Hair { get; set; }
        //public string? PersonalityTraits { get; set; }
        //public string? Ideals { get; set; }
        //public string? Bonds { get; set; }
        //public string? Flaws { get; set; }
        //public string? CharacterBackstory { get; set; }
        //public string? Alignment { get; set; }
        //public float TotalWeight { get; set; }
        //public string? EncumbranceStatus { get; set; }
        //public string? CharacterImage { get; set; }

        ////Skills
        //public int Athletics { get; set; }
        //public int Acrobatics { get; set; }
        //public int SleightOfHand { get; set; }
        //public int Stealth { get; set; }
        //public int Arcana { get; set; }
        //public int History { get; set; }
        //public int Investigation { get; set; }
        //public int Nature { get; set; }
        //public int Religion { get; set; }
        //public int AnimalHandling { get; set; }
        //public int Insight { get; set; }
        //public int Medicine { get; set; }
        //public int Perception { get; set; }
        //public int Survival { get; set; }
        //public int Deception { get; set; }
        //public int Intimidation { get; set; }
        //public int Performance { get; set; }
        //public int Persuasion { get; set; }



        //public string? FeaturesAndTraits { get; set; }
        //public List<string>? AlliesAndOrganizations { get; set; }
        //public List<string>? Languages { get; set; }
        //public List<string>? Equipment { get; set; }


        //public Attack? Attacks { get; set; }
        //public SpellCasting? SpellCasting { get; set; }
        //public Treasure? Treasure { get; set; }
    }
}
