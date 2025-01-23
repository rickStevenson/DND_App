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
        public float Value { get; set; } // In gold or another currency
        public string Category { get; set; } // Weapon, Armor, Potion, etc.
        public int? ArmorClass { get; set; }
        public string? Strength { get; set; }
        public string?  Stealth { get; set; }
        public string? Properties { get; set; }
        public string? Damage { get; set; }
        public string? DamageType { get; set; }
        public string? Rarity { get; set; }//Potions
        public string? HPRegained { get; set; }
        public string? Cost { get; set; }
        public int ArmorClassBonus { get; set; }
    }
}
