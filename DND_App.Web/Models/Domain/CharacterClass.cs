namespace DND_App.Web.Models.Domain
{
    public class CharacterClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int HitDie { get; set; }

        public ICollection<ClassAbility> ClassAbilities { get; set; } = new List<ClassAbility>();
        public ICollection<ClassSavingThrow> ClassSavingThrows { get; set; } = new List<ClassSavingThrow>();

        public string FeaturesAndTraitsJson { get; set; }
    }
}
