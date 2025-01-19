using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DND_App.Web.Models.Domain
{
    public class Item
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Weight { get; set; }
        public int Value { get; set; } // In gold or another currency
        public string? Category { get; set; } // Weapon, Armor, Potion, etc.

        // Navigation property for the characters who own this item
        public ICollection<CharacterItem> CharacterInventories { get; set; } = new List<CharacterItem>();
    }
}
