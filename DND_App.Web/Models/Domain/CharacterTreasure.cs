namespace DND_App.Web.Models.Domain
{
    public class CharacterTreasure
    {
        public int CharacterId { get; set; }
        public Character Character { get; set; }

        public int TreasureId { get; set; }
        public Treasure Treasure { get; set; }

        public int Quantity { get; set; }
    }
}
