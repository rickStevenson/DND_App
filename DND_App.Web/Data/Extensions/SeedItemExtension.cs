using DND_App.Web.Models.Domain;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;
using Constants = DND_App.Web.StaticClasses.Constants;

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
                    Name = Constants.Items.Longsword, 
                    Description = "A versatile blade suitable for slashing and thrusting.", 
                    Weight = 3.0f, 
                    Value = 15, 
                    Category = Constants.Items.Weapon 
                },
                new Item
                { 
                    Id = 2, 
                    Name = Constants.Items.Chainmail, 
                    Description = "A suit of interlocking metal rings providing solid protection.", 
                    Weight = 55.0f, 
                    Value = 75, 
                    Category = Constants.Items.Armor 
                },
                new Item
                { 
                    Id = 3, 
                    Name = Constants.Items.HealingPotion, 
                    Description = "A small vial of red liquid that restores health when consumed.", 
                    Weight = 0.5f, 
                    Value = 50, 
                    Category = Constants.Items.Potion 
                },
                new Item
                { 
                    Id = 4, 
                    Name = Constants.Items.Backpack, 
                    Description = "A sturdy container to carry your belongings.", 
                    Weight = 5.0f, 
                    Value = 2, 
                    Category = Constants.Items.Gear 
                },
                new Item
                { 
                    Id = 5, 
                    Name = Constants.Items.Lantern, 
                    Description = "A hooded lantern that casts bright light in a 30-foot radius.", 
                    Weight = 2.0f, 
                    Value = 5, 
                    Category = Constants.Items.Gear
                },
                new Item
                { 
                    Id = 6, 
                    Name = Constants.Items.Shortbow, 
                    Description = "A compact bow designed for quick, short-range shots.", 
                    Weight = 2.0f, 
                    Value = 25, 
                    Category = Constants.Items.Weapon 
                },
                new Item
                { 
                    Id = 7, 
                    Name = Constants.Items.Spellbook, 
                    Description = "A leather-bound tome containing the wizard’s spells.", 
                    Weight = 3.0f, 
                    Value = 50,
                    Category = Constants.Items.Gear 
                },
                new Item
                { 
                    Id = 8, 
                    Name = Constants.Items.Rations_1day, 
                    Description = "A package of dried food sufficient for one day.", 
                    Weight = 2.0f, 
                    Value = 0.5f, 
                    Category = Constants.Items.Gear
                },
                new Item
                { 
                    Id = 9, 
                    Name = Constants.Items.Dagger,
                    Description = "A small, sharp blade perfect for close combat or throwing.", 
                    Weight = 1.0f, 
                    Value = 2, 
                    Category = Constants.Items.Weapon 
                },
                new Item
                { 
                    Id = 10, 
                    Name = Constants.Items.Rope_50feet, 
                    Description = "A hemp rope useful for climbing or securing items.",
                    Weight = 10.0f, 
                    Value = 1, 
                    Category = Constants.Items.Gear 
                },
                new Item
                { 
                    Id = 11, 
                    Name = Constants.Items.Battleaxe, 
                    Description = "A large axe designed for heavy combat.", 
                    Weight = 4.0f, 
                    Value = 10, 
                    Category = Constants.Items.Weapon 
                },
                new Item
                { 
                    Id = 12, 
                    Name = Constants.Items.Handaxe, 
                    Description = "A small axe usable in melee or as a thrown weapon.",
                    Weight = 2.0f, 
                    Value = 5, 
                    Category = Constants.Items.Weapon 
                },
                new Item
                { 
                    Id = 13, 
                    Name = Constants.Items.ThrowingHammer, 
                    Description = "A hammer balanced for throwing.",
                    Weight = 2.0f, 
                    Value = 5, 
                    Category = Constants.Items.Weapon 
                },
                new Item
                { 
                    Id = 14, 
                    Name = Constants.Items.Warhammer, 
                    Description = "A versatile hammer used for powerful strikes.",
                    Weight = 2.0f, Value = 15, 
                    Category = Constants.Items.Weapon 
                },
                new Item
                { 
                    Id = 15, 
                    Name = Constants.Items.Shortsword, 
                    Description = "A lightweight blade ideal for quick, precise strikes.", 
                    Weight = 2.0f, 
                    Value = 10, 
                    Category = Constants.Items.Weapon 
                },
                new Item
                { 
                    Id = 16, 
                    Name = Constants.Items.Longbow, 
                    Description = "A long-range bow capable of powerful shots.", 
                    Weight = 2.0f, 
                    Value = 50, 
                    Category = Constants.Items.Weapon 
                }
            );
        }
    }
}
