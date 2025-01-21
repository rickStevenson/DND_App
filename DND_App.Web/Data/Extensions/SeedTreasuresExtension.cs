using DND_App.Web.Models.Domain;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

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
                    Name = "Platnum Coin", 
                    Description = "A platnum coin.", 
                    Value = 10, 
                    Type = "Coins", 
                    Weight = .01f, 
                    IsMagical = false 
                },
                new Treasure
                {
                    Id = 2,
                    Name = "Gold Coin",
                    Description = "A gold coin.",
                    Value = 1,
                    Type = "Coins",
                    Weight = .01f,
                    IsMagical = false
                },
                new Treasure
                {
                    Id = 3,
                    Name = "Electrum Coin",
                    Description = "A electrum coin.",
                    Value = .5f,
                    Type = "Coins",
                    Weight = .01f,
                    IsMagical = false
                },
                new Treasure
                {
                    Id = 4,
                    Name = "Silver Coin",
                    Description = "A silver coin.",
                    Value = .1f,
                    Type = "Coins",
                    Weight = .01f,
                    IsMagical = false
                },
                new Treasure
                {
                    Id = 5,
                    Name = "Copper Coin",
                    Description = "A copper coin.",
                    Value = .01f,
                    Type = "Coins",
                    Weight = .01f,
                    IsMagical = false
                },
                new Treasure 
                { 
                    Id = 6, 
                    Name = "Diamond", 
                    Description = "A precious clear gem.", 
                    Value = 1000, 
                    Type = "Gems", 
                    Weight = 0, 
                    IsMagical = false 
                },
                new Treasure
                {
                    Id = 7,
                    Name = "Sapphire",
                    Description = "A precious blue gem.",
                    Value = 500,
                    Type = "Gems",
                    Weight = 0,
                    IsMagical = false
                },
                new Treasure
                {
                    Id = 8,
                    Name = "Emerald",
                    Description = "A precious green gem.",
                    Value = 100,
                    Type = "Gems",
                    Weight = 0,
                    IsMagical = false
                },
                new Treasure
                {
                    Id = 9,
                    Name = "Ruby",
                    Description = "A precious red gem.",
                    Value = 50,
                    Type = "Gems",
                    Weight = 0,
                    IsMagical = false
                },
                new Treasure 
                { 
                    Id = 10, 
                    Name = "Silver Bracelet with Ruby Inlays", 
                    Description = "A beautiful bracelet with delicate ruby inlays.",
                    Value = 100, 
                    Type = "Jewelry", 
                    Weight = 1, 
                    IsMagical = false 
                },
                new Treasure 
                { 
                    Id = 11, 
                    Name = "Amulet of Protection", 
                    Description = "A magical amulet that grants protection to its wearer.", 
                    Value = 5000, 
                    Type = "Artifact", 
                    Weight = 2, 
                    IsMagical = true 
                },
                new Treasure 
                { 
                    Id = 12, 
                    Name = "Sword of Valor", 
                    Description = "A magical sword infused with the essence of valor.", 
                    Value = 10000, 
                    Type = "Artifact", 
                    Weight = 10, 
                    IsMagical = true 
                }
            );
        }
    }
}
