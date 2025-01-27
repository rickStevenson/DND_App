using DND_App.Web.Models.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using DND_App.Web.StaticClasses;
using DND_App.Web.StaticClasses.Constants;

namespace DND_App.Web.Data.Extensions
{
    public static class SeedItemExtension
    {
        public static void SeedItems(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item>().HasData(
                new Item
                {
                    Id = 1,
                    Name = Items.Longsword,
                    Description = "A versatile blade suitable for slashing and thrusting.",
                    Weight = 3.0f,
                    Value = 15,
                    Category = Category.Weapon,
                    ArmorClass = 0,
                    Strength = "",
                    Stealth = "",
                    Properties = "Versatile (1d10)",
                    Damage = "1d8",
                    DamageType = DamageTypes.Slashing,
                    Rarity = Rarity.Common,
                    HPRegained = "",
                    Cost = "15 gp",
                    ArmorClassBonus = 0
                },
                new Item
                {
                    Id = 2,
                    Name = Items.Chainmail,
                    Description = "A suit of interlocking metal rings providing solid protection.",
                    Weight = 55.0f,
                    Value = 75,
                    Category = Category.Armor,
                    ArmorClass = 16,
                    Strength = StrengthRequirements.Strength13,
                    Stealth = StealthModifiers.Disadvantage,
                    Properties = "",
                    Damage = "",
                    DamageType = "",
                    Rarity = Rarity.Common,
                    HPRegained = "",
                    Cost = "75 gp",
                    ArmorClassBonus = 0
                },
                new Item
                {
                    Id = 3,
                    Name = Items.HealingPotion,
                    Description = "A small vial of red liquid that restores health when consumed.",
                    Weight = 0.5f,
                    Value = 50,
                    Category = Category.Potion,
                    ArmorClass = 0,
                    Strength = "",
                    Stealth = "",
                    Properties = "Consumable",
                    Damage = "",
                    DamageType = "",
                    Rarity = Rarity.Uncommon,
                    HPRegained = "2d4+2",
                    Cost = "50 gp",
                    ArmorClassBonus = 0
                },
                new Item
                {
                    Id = 4,
                    Name = Items.Backpack,
                    Description = "A sturdy container to carry your belongings.",
                    Weight = 5.0f,
                    Value = 2,
                    Category = Category.Gear,
                    ArmorClass = 0,
                    Strength = "",
                    Stealth = "",
                    Properties = "Can hold up to 30 lbs of items",
                    Damage = "",
                    DamageType = "",
                    Rarity = Rarity.Common,
                    HPRegained = "",
                    Cost = "2 gp",
                    ArmorClassBonus = 0
                },
                new Item
                {
                    Id = 5,
                    Name = Items.Lantern,
                    Description = "A hooded lantern that casts bright light in a 30-foot radius.",
                    Weight = 2.0f,
                    Value = 5,
                    Category = Category.Gear,
                    ArmorClass = 0,
                    Strength = "",
                    Stealth = "",
                    Properties = "Light source; bright light in a 30-foot radius and dim light for an additional 30 feet",
                    Damage = "",
                    DamageType = "",
                    Rarity = Rarity.Common,
                    HPRegained = "",
                    Cost = "5 gp",
                    ArmorClassBonus = 0
                },
                new Item
                {
                    Id = 6,
                    Name = Items.Shortbow,
                    Description = "A compact bow designed for quick, short-range shots.",
                    Weight = 2.0f,
                    Value = 25,
                    Category = Category.Weapon,
                    ArmorClass = 0,
                    Strength = "",
                    Stealth = "",
                    Properties = "Range (80/320), Ammunition",
                    Damage = "1d6",
                    DamageType = DamageTypes.Piercing,
                    Rarity = Rarity.Common,
                    HPRegained = "",
                    Cost = "25 gp",
                    ArmorClassBonus = 0
                },
                new Item
                {
                    Id = 7,
                    Name = Items.Spellbook,
                    Description = "A leather-bound tome containing the wizard’s spells.",
                    Weight = 3.0f,
                    Value = 50,
                    Category = Category.Gear,
                    ArmorClass = 0,
                    Strength = "",
                    Stealth = "",
                    Properties = "Holds prepared spells",
                    Damage = "",
                    DamageType = "",
                    Rarity = Rarity.Common,
                    HPRegained = "",
                    Cost = "50 gp",
                    ArmorClassBonus = 0
                },
                new Item
                {
                    Id = 8,
                    Name = Items.Rations_1day,
                    Description = "A package of dried food sufficient for one day.",
                    Weight = 2.0f,
                    Value = 0.5f,
                    Category = Category.Gear,
                    ArmorClass = 0,
                    Strength = "",
                    Stealth = "",
                    Properties = "Consumable",
                    Damage = "",
                    DamageType = "",
                    Rarity = Rarity.Common,
                    HPRegained = "",
                    Cost = "5 sp",
                    ArmorClassBonus = 0
                },
                new Item
                {
                    Id = 9,
                    Name = Items.Dagger,
                    Description = "A small, sharp blade perfect for close combat or throwing.",
                    Weight = 1.0f,
                    Value = 2,
                    Category = Category.Weapon,
                    ArmorClass = 0,
                    Strength = "",
                    Stealth = "",
                    Properties = "Finesse, Light, Thrown (range 20/60)",
                    Damage = "1d4",
                    DamageType = DamageTypes.Piercing,
                    Rarity = Rarity.Common,
                    HPRegained = "",
                    Cost = "2 gp",
                    ArmorClassBonus = 0
                },
                new Item
                {
                    Id = 10,
                    Name = Items.Rope_50feet,
                    Description = "A hemp rope useful for climbing or securing items.",
                    Weight = 10.0f,
                    Value = 1,
                    Category = Category.Gear,
                    ArmorClass = 0,
                    Strength = "",
                    Stealth = "",
                    Properties = "50 feet",
                    Damage = "",
                    DamageType = "",
                    Rarity = Rarity.Common,
                    HPRegained = "",
                    Cost = "1 gp",
                    ArmorClassBonus = 0
                },
                new Item
                {
                    Id = 11,
                    Name = Items.Battleaxe,
                    Description = "A large axe designed for heavy combat.",
                    Weight = 4.0f,
                    Value = 10,
                    Category = Category.Weapon,
                    ArmorClass = 0,
                    Strength = "",
                    Stealth = "",
                    Properties = "Versatile (1d10)",
                    Damage = "1d8",
                    DamageType = DamageTypes.Slashing,
                    Rarity = Rarity.Common,
                    HPRegained = "",
                    Cost = "10 gp",
                    ArmorClassBonus = 0
                },
                new Item
                {
                    Id = 12,
                    Name = Items.Handaxe,
                    Description = "A small axe usable in melee or as a thrown weapon.",
                    Weight = 2.0f,
                    Value = 5,
                    Category = Category.Weapon,
                    ArmorClass = 0,
                    Strength = "",
                    Stealth = "",
                    Properties = "Light, Thrown (range 20/60)",
                    Damage = "1d6",
                    DamageType = DamageTypes.Slashing,
                    Rarity = Rarity.Common,
                    HPRegained = "",
                    Cost = "5 gp",
                    ArmorClassBonus = 0
                },
                new Item
                {
                    Id = 13,
                    Name = Items.ThrowingHammer,
                    Description = "A hammer balanced for throwing.",
                    Weight = 2.0f,
                    Value = 5,
                    Category = Category.Weapon,
                    ArmorClass = 0,
                    Strength = "",
                    Stealth = "",
                    Properties = "Light, Thrown (range 20/60)",
                    Damage = "1d4",
                    DamageType = DamageTypes.Bludgeoning,
                    Rarity = Rarity.Common,
                    HPRegained = "",
                    Cost = "5 gp",
                    ArmorClassBonus = 0
                },
                new Item
                {
                    Id = 14,
                    Name = Items.Warhammer,
                    Description = "A versatile hammer used for powerful strikes.",
                    Weight = 2.0f,
                    Value = 15,
                    Category = Category.Weapon,
                    ArmorClass = 0,
                    Strength = "",
                    Stealth = "",
                    Properties = "Versatile (1d10)",
                    Damage = "1d8",
                    DamageType = DamageTypes.Bludgeoning,
                    Rarity = Rarity.Common,
                    HPRegained = "",
                    Cost = "15 gp",
                    ArmorClassBonus = 0
                },
                new Item
                {
                    Id = 15,
                    Name = Items.Shortsword,
                    Description = "A lightweight blade ideal for quick, precise strikes.",
                    Weight = 2.0f,
                    Value = 10,
                    Category = Category.Weapon,
                    ArmorClass = 0,
                    Strength = "",
                    Stealth = "",
                    Properties = "Finesse, Light",
                    Damage = "1d6",
                    DamageType = DamageTypes.Piercing,
                    Rarity = Rarity.Common,
                    HPRegained = "",
                    Cost = "10 gp",
                    ArmorClassBonus = 0
                },
                new Item
                {
                    Id = 16,
                    Name = Items.Longbow,
                    Description = "A long-range bow capable of powerful shots.",
                    Weight = 2.0f,
                    Value = 50,
                    Category = Category.Weapon,
                    ArmorClass = 0,
                    Strength = "",
                    Stealth = "",
                    Properties = "Range (150/600), Ammunition, Heavy, Two-Handed",
                    Damage = "1d8",
                    DamageType = DamageTypes.Piercing,
                    Rarity = Rarity.Common,
                    HPRegained = "",
                    Cost = "50 gp",
                    ArmorClassBonus = 0
                },
                new Item
                {
                    Id = 17,
                    Name = Items.ShieldPlusOne,
                    Description = "A magical shield that offers increased protection.",
                    Weight = 6.0f,
                    Value = 500,
                    Category = Category.Armor,
                    ArmorClass = 2, // Base shield AC
                    Strength = "",
                    Stealth = "",
                    Properties = "Magical Bonus (+1)",
                    Damage = "",
                    DamageType = "",
                    Rarity = Rarity.Rare,
                    HPRegained = "",
                    Cost = "500 gp",
                    ArmorClassBonus = 1
                },
            new Item
            {
                Id = 18,
                Name = Items.ArmorPlusTwo,
                Description = "This armor grants superior magical protection.",
                Weight = 50.0f,
                Value = 2000,
                Category = Category.Armor,
                ArmorClass = 15, 
                Strength = "Str 13",
                Stealth = "Disadvantage",
                Properties = "Magical Bonus (+2)",
                Damage = "",
                DamageType = "",
                Rarity = Rarity.VeryRare,
                HPRegained = "",
                Cost = "2000 gp",
                ArmorClassBonus = 2
            },
            new Item
            {
                Id = 19,
                Name = Items.CloakOfProtection,
                Description = "This cloak increases the wearer's AC and saving throws.",
                Weight = 1.0f,
                Value = 1500,
                Category = Category.MagicItem,
                ArmorClass = 0, 
                Strength = "",
                Stealth = "",
                Properties = "Provides +1 bonus to AC and saving throws.",
                Damage = "",
                DamageType = "",
                Rarity = Rarity.Uncommon,
                HPRegained = "",
                Cost = "1500 gp",
                ArmorClassBonus = 1
            }


            );
        }
    }

}

