namespace DND_App.Web.Models.Domain
{
    public class CharacterClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int HitDie { get; set; }

        public ICollection<ClassAbility> Abilities { get; set; } = new List<ClassAbility>();
        public ICollection<ClassSavingThrow> SavingThrows { get; set; } = new List<ClassSavingThrow>();

    }
}
