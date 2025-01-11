namespace DND_App.Web.Models.Domain
{
    public class SpellCasting
    {
        public int Id { get; set; }
        public string SpellName { get; set; }
        public int Level { get; set; }
        public int SpellSlot { get; set; }
        public string Description { get; set; }

        public int CharacterId { get; set; }
        public Character Character { get; set; }
    }
}
