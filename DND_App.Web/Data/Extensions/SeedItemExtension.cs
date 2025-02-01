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
                    Name = ItemNameExtension.GetDisplayName(ItemName.Longsword),
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
                    Name = ItemNameExtension.GetDisplayName(ItemName.Chainmail),
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
                    Name = ItemNameExtension.GetDisplayName(ItemName.HealingPotion),
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
                    Name = ItemNameExtension.GetDisplayName(ItemName.Backpack),
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
                    Name = ItemNameExtension.GetDisplayName(ItemName.Lantern),
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
                    Name = ItemNameExtension.GetDisplayName(ItemName.Shortbow),
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
                    Name = ItemNameExtension.GetDisplayName(ItemName.Spellbook),
                    Description = "A leather-bound tome containing the wizard’s spells.",
                    Weight = 3.0f,
                    Value = 50,
                    Category = Category.MagicItem,
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
                    Name = ItemNameExtension.GetDisplayName(ItemName.Rations_1day),
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
                    Name = ItemNameExtension.GetDisplayName(ItemName.Dagger),
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
                    Name = ItemNameExtension.GetDisplayName(ItemName.Rope_50feet),
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
                    Name = ItemNameExtension.GetDisplayName(ItemName.Battleaxe),
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
                    Name = ItemNameExtension.GetDisplayName(ItemName.Handaxe),
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
                    Name = ItemNameExtension.GetDisplayName(ItemName.ThrowingHammer),
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
                    Name = ItemNameExtension.GetDisplayName(ItemName.Warhammer),
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
                    Name = ItemNameExtension.GetDisplayName(ItemName.Shortsword),
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
                    Name = ItemNameExtension.GetDisplayName(ItemName.Longbow),
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
                    Name = ItemNameExtension.GetDisplayName(ItemName.ShieldPlusOne),
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
                Name = ItemNameExtension.GetDisplayName(ItemName.ArmorPlusTwo),
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
                Name = ItemNameExtension.GetDisplayName(ItemName.CloakOfProtection),
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
            },
            new Item
            {
                Id = 20,
                Name = ItemNameExtension.GetDisplayName(ItemName.LeatherArmor),
                Description = "Made of supple and tanned hide, leather armor is a light armor option.",
                Weight = 10,
                Value = 10, // Gold Pieces
                Category = Category.Armor,
                ArmorClass = 11,
                Strength = "None",
                Stealth = "None",
                Properties = "Light Armor",
                Damage = "None",
                DamageType = "None",
                Rarity = Rarity.Common,
                HPRegained = "None",
                Cost = "10 GP",
                ArmorClassBonus = 0
            },
            new Item
            {
                Id = 21,
                Name = ItemNameExtension.GetDisplayName(ItemName.ChainShirt),
                Description = "A chain shirt is a flexible suit of interlocking metal rings, providing moderate protection.",
                Weight = 20,
                Value = 50, // Gold Pieces
                Category = Category.Armor,
                ArmorClass = 13,
                Strength = "None",
                Stealth = "None",
                Properties = "Medium Armor",
                Damage = "None",
                DamageType = "None",
                Rarity = Rarity.Common,
                HPRegained = "None",
                Cost = "50 GP",
                ArmorClassBonus = 0
            },
            new Item
            {
                Id = 22,
                Name = ItemNameExtension.GetDisplayName(ItemName.PlateArmor),
                Description = "Plate consists of shaped, interlocking metal plates covering the entire body. It provides the best protection available.",
                Weight = 65,
                Value = 1500, // Gold Pieces
                Category = Category.Armor,
                ArmorClass = 18,
                Strength = "15",
                Stealth = "Disadvantage",
                Properties = "Heavy Armor",
                Damage = "None",
                DamageType = "None",
                Rarity = Rarity.Common,
                HPRegained = "None",
                Cost = "1500 GP",
                ArmorClassBonus = 0
            },
            new Item
            {
                Id = 23,
                Name = ItemNameExtension.GetDisplayName(ItemName.Shield),
                Description = "A simple, sturdy shield that bolsters the wearer's defenses.",
                Weight = 6,
                Value = 10, // Gold Pieces
                Category = Category.Armor,
                ArmorClass = 0, // Shields do not have a base AC, they provide a bonus
                Strength = "None",
                Stealth = "None",
                Properties = "Shield",
                Damage = "None",
                DamageType = "None",
                Rarity = Rarity.Common,
                HPRegained = "None",
                Cost = "10 GP",
                ArmorClassBonus = 2
            }
            );
        }
    }

}

