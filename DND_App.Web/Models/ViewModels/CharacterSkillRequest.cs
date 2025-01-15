namespace DND_App.Web.Models.ViewModels
{
    public class CharacterSkillRequest
    {
        public int SkillId { get; set; } // ID of the Skill
        public bool IsProficient { get; set; } // Indicates if proficient
        public int Bonus { get; set; } // Any additional bonus
    }
}
