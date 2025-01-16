using System.ComponentModel.DataAnnotations;

namespace DND_App.Web.Models.ViewModels
{
    public class CharacterSkillRequest
    {
        [Required]
        public int SkillId { get; set; }

        public bool IsProficient { get; set; }

        [Range(0, 20, ErrorMessage = "Bonus must be between 0 and 20.")]
        public int Bonus { get; set; } = 0;

    }
}
