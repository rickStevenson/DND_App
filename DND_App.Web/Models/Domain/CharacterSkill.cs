namespace DND_App.Web.Models.Domain
{
    public class CharacterSkill
    {
        public int CharacterId { get; set; } // Foreign Key
        public Character Character { get; set; } // Navigation Property

        public int SkillId { get; set; }
        public Skill Skill { get; set; }

        public bool IsProficient { get; set; }
        public int Bonus { get; set; }
    }
}
