using DND_App.Web.Models.Domain;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;
using DND_App.Web.StaticClasses.Constants;

namespace DND_App.Web.Data.Extensions
{
    public static class SeedTreasuresExtension
    {
        public static void SeedTreasures(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Treasure>().HasData(
                new Treasure 
                { 
                    Id = 1, 
                    Name = Items.PlatnumCoin, 
                    Description = "A platnum coin.", 
                    Value = 10, 
                    Type = Treasures.Coins, 
                    Weight = .01f, 
                    IsMagical = false 
                },
                new Treasure
                {
                    Id = 2,
                    Name = Items.GoldCoin,
                    Description = "A gold coin.",
                    Value = 1,
                    Type = Treasures.Coins,
                    Weight = .01f,
                    IsMagical = false
                },
                new Treasure
                {
                    Id = 3,
                    Name = Items.ElectrumCoin,
                    Description = "A electrum coin.",
                    Value = .5f,
                    Type = Treasures.Coins,
                    Weight = .01f,
                    IsMagical = false
                },
                new Treasure
                {
                    Id = 4,
                    Name = Items.SilverCoin,
                    Description = "A silver coin.",
                    Value = .1f,
                    Type = Treasures.Coins,
                    Weight = .01f,
                    IsMagical = false
                },
                new Treasure
                {
                    Id = 5,
                    Name = Items.CopperCoin,
                    Description = "A copper coin.",
                    Value = .01f,
                    Type = Treasures.Coins,
                    Weight = .01f,
                    IsMagical = false
                },
                new Treasure 
                { 
                    Id = 6, 
                    Name = Items.Diamond, 
                    Description = "A precious clear gem.", 
                    Value = 1000, 
                    Type = Treasures.Gems, 
                    Weight = 0, 
                    IsMagical = false 
                },
                new Treasure
                {
                    Id = 7,
                    Name = Items.Sapphire,
                    Description = "A precious blue gem.",
                    Value = 500,
                    Type = Treasures.Gems,
                    Weight = 0,
                    IsMagical = false
                },
                new Treasure
                {
                    Id = 8,
                    Name = Items.Emerald,
                    Description = "A precious green gem.",
                    Value = 100,
                    Type = Treasures.Gems,
                    Weight = 0,
                    IsMagical = false
                },
                new Treasure
                {
                    Id = 9,
                    Name = Items.Ruby,
                    Description = "A precious red gem.",
                    Value = 50,
                    Type = Treasures.Gems,
                    Weight = 0,
                    IsMagical = false
                },
                new Treasure 
                { 
                    Id = 10, 
                    Name = Items.SilverBraceletWithRubyInlays, 
                    Description = "A beautiful bracelet with delicate ruby inlays.",
                    Value = 100, 
                    Type = Treasures.Jewelry, 
                    Weight = 1, 
                    IsMagical = false 
                },
                new Treasure 
                { 
                    Id = 11, 
                    Name = Items.AmuletOfProtection, 
                    Description = "A magical amulet that grants protection to its wearer.", 
                    Value = 5000, 
                    Type = Treasures.Artifacts, 
                    Weight = 2, 
                    IsMagical = true 
                },
                new Treasure 
                { 
                    Id = 12, 
                    Name = Items.SwordOfValor, 
                    Description = "A magical sword infused with the essence of valor.", 
                    Value = 10000, 
                    Type = Treasures.Artifacts, 
                    Weight = 10, 
                    IsMagical = true 
                }
            );
        }
    }
}
