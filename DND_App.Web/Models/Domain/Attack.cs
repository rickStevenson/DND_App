namespace DND_App.Web.Models.Domain
{
    public class Attack
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Damage { get; set; }
        public string DamageType { get; set; }
        public int AttackBonus { get; set; }

        public int CharacterId { get; set; }
        public Character Character { get; set; }
    }
}
