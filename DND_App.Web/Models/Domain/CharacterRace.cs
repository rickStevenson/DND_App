namespace DND_App.Web.Models.Domain
{
    public class CharacterRace
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int StrengthBonus { get; set; }
        public int DexterityBonus { get; set; }
        public int ConstitutionBonus { get; set; }
        public int IntelligenceBonus { get; set; }
        public int WisdomBonus { get; set; }
        public int CharismaBonus { get; set; }
        public string MaleImage { get; set; }
        public string FemaleImage { get; set; }
        public ICollection<RaceAbility> RaceAbilities { get; set; } = new List<RaceAbility>();
        public ICollection<RaceWeaponProficiency> RaceWeaponProficiencies { get; set; } = new List<RaceWeaponProficiency>();
        public ICollection<RaceToolProficiency> RaceToolProficiencies { get; set; } = new List<RaceToolProficiency>();

    }
}
