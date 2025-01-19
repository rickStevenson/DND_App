using System.ComponentModel.DataAnnotations;

namespace DND_App.Web.Models.Domain
{
    public class CharacterItem
    {
        public int CharacterId { get; set; }
        public Character Character { get; set; }

        public int ItemId { get; set; }
        public Item Item { get; set; }

        public int Quantity { get; set; }
    }
}
