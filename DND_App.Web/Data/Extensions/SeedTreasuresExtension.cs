using DND_App.Web.Models.Domain;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;
using DND_App.Web.StaticClasses;

namespace DND_App.Web.Data.Extensions
{
    public static class SeedTreasuresExtension
    {
        public static void SeedTreasures(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Domain.Treasure>().HasData(
                new Models.Domain.Treasure 
                { 
                    Id = 1, 
                    Name = ItemNameExtension.GetDisplayName(ItemName.PlatnumCoin), 
                    Description = "A platnum coin.", 
                    Value = 10, 
                    Type = TreasureExtension.GetDisplayName(TreasureType.Coins), 
                    Weight = .01f, 
                    IsMagical = false 
                },
                new Models.Domain.Treasure
                {
                    Id = 2,
                    Name = ItemNameExtension.GetDisplayName(ItemName.GoldCoin),
                    Description = "A gold coin.",
                    Value = 1,
                    Type = TreasureExtension.GetDisplayName(TreasureType.Coins),
                    Weight = .01f,
                    IsMagical = false
                },
                new Models.Domain.Treasure
                {
                    Id = 3,
                    Name = ItemNameExtension.GetDisplayName(ItemName.ElectrumCoin),
                    Description = "A electrum coin.",
                    Value = .5f,
                    Type = TreasureExtension.GetDisplayName(TreasureType.Coins),
                    Weight = .01f,
                    IsMagical = false
                },
                new Models.Domain.Treasure
                {
                    Id = 4,
                    Name = ItemNameExtension.GetDisplayName(ItemName.SilverCoin),
                    Description = "A silver coin.",
                    Value = .1f,
                    Type = TreasureExtension.GetDisplayName(TreasureType.Coins),
                    Weight = .01f,
                    IsMagical = false
                },
                new Models.Domain.Treasure
                {
                    Id = 5,
                    Name = ItemNameExtension.GetDisplayName(ItemName.CopperCoin),
                    Description = "A copper coin.",
                    Value = .01f,
                    Type = TreasureExtension.GetDisplayName(TreasureType.Coins),
                    Weight = .01f,
                    IsMagical = false
                },
                new Models.Domain.Treasure 
                { 
                    Id = 6, 
                    Name = ItemNameExtension.GetDisplayName(ItemName.Diamond), 
                    Description = "A precious clear gem.", 
                    Value = 1000, 
                    Type = TreasureExtension.GetDisplayName(TreasureType.Gems), 
                    Weight = 0, 
                    IsMagical = false 
                },
                new Models.Domain.Treasure
                {
                    Id = 7,
                    Name = ItemNameExtension.GetDisplayName(ItemName.Sapphire),
                    Description = "A precious blue gem.",
                    Value = 500,
                    Type = TreasureExtension.GetDisplayName(TreasureType.Gems),
                    Weight = 0,
                    IsMagical = false
                },
                new Models.Domain.Treasure
                {
                    Id = 8,
                    Name = ItemNameExtension.GetDisplayName(ItemName.Emerald),
                    Description = "A precious green gem.",
                    Value = 100,
                    Type = TreasureExtension.GetDisplayName(TreasureType.Gems),
                    Weight = 0,
                    IsMagical = false
                },
                new Models.Domain.Treasure
                {
                    Id = 9,
                    Name = ItemNameExtension.GetDisplayName(ItemName.Ruby),
                    Description = "A precious red gem.",
                    Value = 50,
                    Type = TreasureExtension.GetDisplayName(TreasureType.Gems),
                    Weight = 0,
                    IsMagical = false
                },
                new Models.Domain.Treasure 
                { 
                    Id = 10, 
                    Name = ItemNameExtension.GetDisplayName(ItemName.SilverBraceletWithRubyInlays), 
                    Description = "A beautiful bracelet with delicate ruby inlays.",
                    Value = 100, 
                    Type = TreasureExtension.GetDisplayName(TreasureType.Jewelry), 
                    Weight = 1, 
                    IsMagical = false 
                },
                new Models.Domain.Treasure 
                { 
                    Id = 11, 
                    Name = ItemNameExtension.GetDisplayName(ItemName.AmuletOfProtection), 
                    Description = "A magical amulet that grants protection to its wearer.", 
                    Value = 5000, 
                    Type = TreasureExtension.GetDisplayName(TreasureType.Artifacts), 
                    Weight = 2, 
                    IsMagical = true 
                },
                new Models.Domain.Treasure 
                { 
                    Id = 12, 
                    Name = ItemNameExtension.GetDisplayName(ItemName.SwordOfValor), 
                    Description = "A magical sword infused with the essence of valor.", 
                    Value = 10000, 
                    Type = TreasureExtension.GetDisplayName(TreasureType.Artifacts), 
                    Weight = 10, 
                    IsMagical = true 
                }
            );
        }
    }
}
