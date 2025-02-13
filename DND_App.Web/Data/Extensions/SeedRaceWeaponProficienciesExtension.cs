﻿using DND_App.Web.Models.Domain;
using Microsoft.EntityFrameworkCore;
using DND_App.Web.StaticClasses.Constants;
using DND_App.Web.StaticClasses;

namespace DND_App.Web.Data.Extensions
{
    public static class SeedRaceWeaponProficienciesExtension
    {
        public static void SeedRaceWeaponProficiencies(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RaceWeaponProficiency>().HasData(
                new RaceWeaponProficiency 
                { 
                    Id = 1, 
                    Name = "None", 
                    CharacterRaceId = 1 },
                new RaceWeaponProficiency 
                { 
                    Id = 2, 
                    Name = "None", 
                    CharacterRaceId = 2 },
                new RaceWeaponProficiency 
                { 
                    Id = 3, 
                    Name = ItemNameExtension.GetDisplayName(ItemName.Battleaxe), 
                    CharacterRaceId = 3 },
                new RaceWeaponProficiency 
                { 
                    Id = 4, 
                    Name = ItemNameExtension.GetDisplayName(ItemName.Handaxe), 
                    CharacterRaceId = 3 },
                new RaceWeaponProficiency 
                { 
                    Id = 5, 
                    Name = ItemNameExtension.GetDisplayName(ItemName.ThrowingHammer), 
                    CharacterRaceId = 3 },
                new RaceWeaponProficiency 
                { 
                    Id = 6, 
                    Name = ItemNameExtension.GetDisplayName(ItemName.Warhammer), 
                    CharacterRaceId = 3 },
                new RaceWeaponProficiency 
                { 
                    Id = 7, 
                    Name = ItemNameExtension.GetDisplayName(ItemName.Longsword), 
                    CharacterRaceId = 4 },
                new RaceWeaponProficiency 
                { 
                    Id = 8, 
                    Name = ItemNameExtension.GetDisplayName(ItemName.Shortsword), 
                    CharacterRaceId = 4 },
                new RaceWeaponProficiency 
                { 
                    Id = 9, 
                    Name = ItemNameExtension.GetDisplayName(ItemName.Shortbow), 
                    CharacterRaceId = 4 },
                new RaceWeaponProficiency 
                { 
                    Id = 10, 
                    Name = ItemNameExtension.GetDisplayName(ItemName.Longbow), 
                    CharacterRaceId = 4 },
                new RaceWeaponProficiency 
                { 
                    Id = 11, 
                    Name = "None", 
                    CharacterRaceId = 5 },
                new RaceWeaponProficiency 
                { 
                    Id = 12, 
                    Name = "None", 
                    CharacterRaceId = 6 },
                new RaceWeaponProficiency 
                { 
                    Id = 13, 
                    Name = "None", 
                    CharacterRaceId = 7 },
                new RaceWeaponProficiency 
                { 
                    Id = 14, 
                    Name = "None", 
                    CharacterRaceId = 8 },
                new RaceWeaponProficiency 
                { 
                    Id = 15, 
                    Name = "None", 
                    CharacterRaceId = 9 },
                new RaceWeaponProficiency 
                { 
                    Id = 16, 
                    Name = "None", 
                    CharacterRaceId = 10 },
                new RaceWeaponProficiency 
                { 
                    Id = 17, 
                    Name = "None", 
                    CharacterRaceId = 11 },
                new RaceWeaponProficiency 
                { 
                    Id = 18, 
                    Name = ItemNameExtension.GetDisplayName(ItemName.Longsword), 
                    CharacterRaceId = 12 },
                new RaceWeaponProficiency 
                { 
                    Id = 19, 
                    Name = ItemNameExtension.GetDisplayName(ItemName.Shortsword), 
                    CharacterRaceId = 12 },
                new RaceWeaponProficiency 
                { 
                    Id = 20, 
                    Name = ItemNameExtension.GetDisplayName(ItemName.Shortbow), 
                    CharacterRaceId = 12 },
                new RaceWeaponProficiency 
                { 
                    Id = 21, 
                    Name = ItemNameExtension.GetDisplayName(ItemName.Longbow), 
                    CharacterRaceId = 12 },
                new RaceWeaponProficiency 
                { 
                    Id = 22, 
                    Name = "None", 
                    CharacterRaceId = 13 },
                new RaceWeaponProficiency 
                { 
                    Id = 23, 
                    Name = "None", 
                    CharacterRaceId = 14 },
                new RaceWeaponProficiency 
                { 
                    Id = 24, 
                    Name = ItemNameExtension.GetDisplayName(ItemName.Longsword), 
                    CharacterRaceId = 15 },
                new RaceWeaponProficiency 
                { 
                    Id = 25, 
                    Name = ItemNameExtension.GetDisplayName(ItemName.Shortsword), 
                    CharacterRaceId = 15 },
                new RaceWeaponProficiency 
                { 
                    Id = 26, 
                    Name = "None", 
                    CharacterRaceId = 16 },
                new RaceWeaponProficiency 
                { 
                    Id = 27, 
                    Name = "None", 
                    CharacterRaceId = 17 },
                new RaceWeaponProficiency 
                { 
                    Id = 28, 
                    Name = "None", 
                    CharacterRaceId = 18 },
                new RaceWeaponProficiency 
                { 
                    Id = 29, 
                    Name = "None", 
                    CharacterRaceId = 19 },
                new RaceWeaponProficiency 
                { 
                    Id = 30, 
                    Name = "None", 
                    CharacterRaceId = 20 }
            );
        }
    }
}
