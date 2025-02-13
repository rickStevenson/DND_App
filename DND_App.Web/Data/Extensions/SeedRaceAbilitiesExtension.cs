﻿using DND_App.Web.Models.Domain;
using Microsoft.EntityFrameworkCore;
//using Constants = DND_App.Web.StaticClasses.Constants;
using DND_App.Web.StaticClasses;

namespace DND_App.Web.Data.Extensions
{
    public static class SeedRaceAbilitiesExtension
    {
        public static void SeedRaceAbilities(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RaceAbility>().HasData(
                //Aasimar
                new RaceAbility 
                { 
                    Id = 1, 
                    Name = RaceAbilitiesExtension.GetDisplayName(RaceAbilities.DarkVision),
                    Description = "See in dim light within 60 ft. as if it were bright light, and in darkness as if it were dim light.",
                    CharacterRaceId = 1 },
                new RaceAbility 
                { 
                    Id = 2, 
                    Name = RaceAbilitiesExtension.GetDisplayName(RaceAbilities.CelestialResistance),
                    Description = "Resistance to radiant and necrotic damage.",
                    CharacterRaceId = 1 },
                new RaceAbility 
                { 
                    Id = 3, 
                    Name = RaceAbilitiesExtension.GetDisplayName(RaceAbilities.HealingHands),
                    Description = "As an action, touch a creature to restore hit points equal to your level.",
                    CharacterRaceId = 1 },
                new RaceAbility 
                { 
                    Id = 4, 
                    Name = RaceAbilitiesExtension.GetDisplayName(RaceAbilities.LightBearer),
                    Description = "Gain the light cantrip.",
                    CharacterRaceId = 1 },

                //Dragonborn
                new RaceAbility 
                { 
                    Id = 5, 
                    Name = RaceAbilitiesExtension.GetDisplayName(RaceAbilities.BreathWeapon),
                    Description = "Exhale destructive energy in a 15 ft. cone or 30 ft. line (Dex or Con save, depending on ancestry).",
                    CharacterRaceId = 2 },
                new RaceAbility 
                { 
                    Id = 6, 
                    Name = RaceAbilitiesExtension.GetDisplayName(RaceAbilities.DraconicResistance),
                    Description = "Gain resistance to the damage type associated with your draconic ancestry (fire, cold, lightning, etc.).",
                    CharacterRaceId = 2 },

                //Dwarf
                new RaceAbility 
                { 
                    Id = 7, 
                    Name = RaceAbilitiesExtension.GetDisplayName(RaceAbilities.DarkVision),
                    Description = "See in dim light within 60 ft. as if it were bright light, and in darkness as if it were dim light.",
                    CharacterRaceId = 3 },
                new RaceAbility 
                { 
                    Id = 8, 
                    Name = RaceAbilitiesExtension.GetDisplayName(RaceAbilities.DwarvenResilience),
                    Description = " Advantage on saving throws against poison, and resistance to poison damage.",
                    CharacterRaceId = 3 },
                new RaceAbility 
                { 
                    Id = 9, 
                    Name = RaceAbilitiesExtension.GetDisplayName(RaceAbilities.Stonecunning),
                    Description = "Add double proficiency to Intelligence (History) checks related to stonework.",
                    CharacterRaceId = 3 },

                //Elf
                new RaceAbility 
                { 
                    Id = 10, 
                    Name = RaceAbilitiesExtension.GetDisplayName(RaceAbilities.DarkVision),
                    Description = "See in dim light within 60 ft. as if it were bright light, and in darkness as if it were dim light.", 
                    CharacterRaceId = 4 },
                new RaceAbility 
                { 
                    Id = 11, 
                    Name = RaceAbilitiesExtension.GetDisplayName(RaceAbilities.KeenSenses),
                    Description = "Proficiency in Perception.",
                    CharacterRaceId = 4 },
                new RaceAbility 
                { 
                    Id = 12, 
                    Name = RaceAbilitiesExtension.GetDisplayName(RaceAbilities.FeyAncestry),
                    Description = "Advantage on saving throws against being charmed, and immunity to magical sleep.",
                    CharacterRaceId = 4 },
                new RaceAbility 
                { 
                    Id = 13, 
                    Name = RaceAbilitiesExtension.GetDisplayName(RaceAbilities.Trance),
                    Description = "Elves don’t need sleep. They can finish a long rest in 4 hours while meditating.",
                    CharacterRaceId = 4 },

                //Firbolg
                new RaceAbility 
                { 
                    Id = 14, 
                    Name = RaceAbilitiesExtension.GetDisplayName(RaceAbilities.FirbolgMagic),
                    Description = "Cast detect magic and disguise self without expending a spell slot.",
                    CharacterRaceId = 5 },
                new RaceAbility 
                { 
                    Id = 15, 
                    Name = RaceAbilitiesExtension.GetDisplayName(RaceAbilities.HiddenStep),
                    Description = "Turn invisible as a bonus action until the start of your next turn.",
                    CharacterRaceId = 5 },
                new RaceAbility 
                { 
                    Id = 16, 
                    Name = RaceAbilitiesExtension.GetDisplayName(RaceAbilities.PowerfulBuild),
                    Description = "Count as one size larger for carrying capacity.",
                    CharacterRaceId = 5 },
                new RaceAbility 
                { 
                    Id = 17, 
                    Name = RaceAbilitiesExtension.GetDisplayName(RaceAbilities.SpeechOfBeastAndLeaf),
                    Description = "Communicate with animals and plants (they understand you but cannot speak back).",
                    CharacterRaceId = 5 },

                //Air Genasi
                new RaceAbility 
                { 
                    Id = 18, 
                    Name = RaceAbilitiesExtension.GetDisplayName(RaceAbilities.UnendingBreath),
                    Description = "You can hold your breath indefinitely while not incapacitated.",
                    CharacterRaceId = 6 },
                new RaceAbility 
                { 
                    Id = 19, 
                    Name = RaceAbilitiesExtension.GetDisplayName(RaceAbilities.MingleWithTheWind),
                    Description = "You can cast the Levitate spell once with this trait, requiring no material components. You regain the ability to cast it this way after a long rest. Constitution is your spellcasting ability for this spell.",
                    CharacterRaceId = 6 },

                //Earth Genasi
                new RaceAbility 
                { 
                    Id = 20, 
                    Name = RaceAbilitiesExtension.GetDisplayName(RaceAbilities.EarthWalk),
                    Description = "You can move across difficult terrain made of earth or stone without expending extra movement.",
                    CharacterRaceId = 7 },
                new RaceAbility 
                { 
                    Id = 21, 
                    Name = RaceAbilitiesExtension.GetDisplayName(RaceAbilities.MergeWithStone), 
                    Description = "You can cast the Pass Without Trace spell once with this trait, requiring no material components. You regain the ability to cast it this way after a long rest. Constitution is your spellcasting ability for this spell.",
                    CharacterRaceId = 7 },

                //Fire Genasi
                new RaceAbility 
                { 
                    Id = 22, 
                    Name = RaceAbilitiesExtension.GetDisplayName(RaceAbilities.DarkVision), 
                    Description = "You can see in dim light within 60 feet as if it were bright light, and in darkness as if it were dim light. Your vision in darkness is in shades of red.",
                    CharacterRaceId = 8 },
                new RaceAbility 
                { 
                    Id = 23, 
                    Name = RaceAbilitiesExtension.GetDisplayName(RaceAbilities.FireResistance), 
                    Description = "You have resistance to fire damage.",
                    CharacterRaceId = 8 },
                new RaceAbility 
                { 
                    Id = 24, 
                    Name = RaceAbilitiesExtension.GetDisplayName(RaceAbilities.ReachToTheBlaze), 
                    Description = "You know the Produce Flame cantrip. Once you reach 3rd level, you can cast the Burning Hands spell once with this trait as a 1st-level spell. You regain the ability to cast it this way after a long rest. Constitution is your spellcasting ability for these spells.",
                    CharacterRaceId = 8 },

                //Water Genasi
                new RaceAbility 
                { 
                    Id = 25, 
                    Name = RaceAbilitiesExtension.GetDisplayName(RaceAbilities.AcidResistance), 
                    Description = "You have resistance to acid damage.",
                    CharacterRaceId = 9 },
                new RaceAbility 
                { 
                    Id = 26, 
                    Name = RaceAbilitiesExtension.GetDisplayName(RaceAbilities.Amphibious), 
                    Description = "You can breathe air and water.", 
                    CharacterRaceId = 9 },
                new RaceAbility 
                { 
                    Id = 27, 
                    Name = RaceAbilitiesExtension.GetDisplayName(RaceAbilities.CallToTheWave), 
                    Description = "You know the Shape Water cantrip. Once you reach 3rd level, you can cast the Create or Destroy Water spell once with this trait. You regain the ability to cast it this way after a long rest. Constitution is your spellcasting ability for these spells.",
                    CharacterRaceId = 9 },

                //Gnome
                new RaceAbility 
                { 
                    Id = 28, 
                    Name = RaceAbilitiesExtension.GetDisplayName(RaceAbilities.DarkVision), 
                    Description = "See in dim light within 60 ft. as if it were bright light, and in darkness as if it were dim light.",
                    CharacterRaceId = 10 },
                new RaceAbility 
                { 
                    Id = 29, 
                    Name = RaceAbilitiesExtension.GetDisplayName(RaceAbilities.GnomeCunning), 
                    Description = "Advantage on all Intelligence, Wisdom, and Charisma saving throws against magic.",
                    CharacterRaceId = 10 },

                //Goliath
                new RaceAbility 
                { 
                    Id = 30, 
                    Name = RaceAbilitiesExtension.GetDisplayName(RaceAbilities.NaturalAthlete), 
                    Description = "Proficiency in Athletics.",
                    CharacterRaceId = 11 },
                new RaceAbility 
                { 
                    Id = 31, 
                    Name = RaceAbilitiesExtension.GetDisplayName(RaceAbilities.MountainBorn), 
                    Description = "Resistance to cold damage and acclimated to high altitudes.",
                    CharacterRaceId = 11 },
                new RaceAbility 
                { 
                    Id = 32, 
                    Name = RaceAbilitiesExtension.GetDisplayName(RaceAbilities.PowerfulBuild), 
                    Description = "Count as one size larger for carrying capacity.",
                    CharacterRaceId = 11 },
                new RaceAbility 
                { 
                    Id = 33, 
                    Name = RaceAbilitiesExtension.GetDisplayName(RaceAbilities.StonesEndurance), 
                    Description = "Reduce damage taken by 1d12 + Constitution modifier once per short or long rest.",
                    CharacterRaceId = 11 },

                //Half Elf
                new RaceAbility 
                { 
                    Id = 34, 
                    Name = RaceAbilitiesExtension.GetDisplayName(RaceAbilities.DarkVision), 
                    Description = "See in dim light within 60 ft. as if it were bright light, and in darkness as if it were dim light.",
                    CharacterRaceId = 12 },
                new RaceAbility 
                { 
                    Id = 35, 
                    Name = RaceAbilitiesExtension.GetDisplayName(RaceAbilities.FeyAncestry), 
                    Description = "Advantage on saving throws against being charmed, and immunity to magical sleep.",
                    CharacterRaceId = 12 },
                new RaceAbility 
                { 
                    Id = 36, 
                    Name = RaceAbilitiesExtension.GetDisplayName(RaceAbilities.SkillVersatility), 
                    Description = "Gain proficiency in two skills of your choice.",
                    CharacterRaceId = 12 },

                //Halfling
                new RaceAbility 
                { 
                    Id = 37, 
                    Name = RaceAbilitiesExtension.GetDisplayName(RaceAbilities.Lucky), 
                    Description = " When you roll a 1 on an attack roll, ability check, or saving throw, you can reroll and must use the new roll.",
                    CharacterRaceId = 13 },
                new RaceAbility 
                { 
                    Id = 38, 
                    Name = RaceAbilitiesExtension.GetDisplayName(RaceAbilities.Brave), 
                    Description = "Advantage on saving throws against being frightened.",
                    CharacterRaceId = 13 },
                new RaceAbility 
                { 
                    Id = 39, 
                    Name = RaceAbilitiesExtension.GetDisplayName(RaceAbilities.HalflingNimbleness), 
                    Description = "Move through the space of any creature larger than you.",
                    CharacterRaceId = 13 },

                //Half Orc
                new RaceAbility 
                { 
                    Id = 40, 
                    Name = RaceAbilitiesExtension.GetDisplayName(RaceAbilities.RelentlessEndurance), 
                    Description = "See in dim light within 60 ft. as if it were bright light, and in darkness as if it were dim light.",
                    CharacterRaceId = 14 },
                new RaceAbility 
                { 
                    Id = 41, 
                    Name = RaceAbilitiesExtension.GetDisplayName(RaceAbilities.RelentlessEndurance), 
                    Description = "When reduced to 0 HP but not killed outright, you drop to 1 HP instead (once per long rest).",
                    CharacterRaceId = 14 },
                new RaceAbility 
                { 
                    Id = 42, 
                    Name = RaceAbilitiesExtension.GetDisplayName(RaceAbilities.SavageAttack), 
                    Description = " When you score a critical hit with a melee weapon, roll one additional damage die.", 
                    CharacterRaceId = 14 },

                //Human
                new RaceAbility 
                { 
                    Id = 43, 
                    Name = RaceAbilitiesExtension.GetDisplayName(RaceAbilities.VersatileAbility), 
                    Description = "Gain a feat and proficiency in one skill of your choice.\r\n", 
                    CharacterRaceId = 15 },

                //Kenku
                new RaceAbility 
                { 
                    Id = 44, 
                    Name = RaceAbilitiesExtension.GetDisplayName(RaceAbilities.Mimicry), 
                    Description = "Mimic sounds you’ve heard, such as voices.",
                    CharacterRaceId = 16 },
                new RaceAbility 
                { 
                    Id = 45, 
                    Name = RaceAbilitiesExtension.GetDisplayName(RaceAbilities.ExpertForgery), 
                    Description = "Duplicate writing and craftwork perfectly.",
                    CharacterRaceId = 16 },
                new RaceAbility 
                { 
                    Id = 46, 
                    Name = RaceAbilitiesExtension.GetDisplayName(RaceAbilities.SkillProficiencies), 
                    Description = "Proficiency in Deception and Stealth.",
                    CharacterRaceId = 16 },

                //Tabaxi
                new RaceAbility 
                { 
                    Id = 47, 
                    Name = RaceAbilitiesExtension.GetDisplayName(RaceAbilities.DarkVision), 
                    Description = "See in dim light within 60 ft. as if it were bright light, and in darkness as if it were dim light.", 
                    CharacterRaceId = 17 },
                new RaceAbility 
                { 
                    Id = 48, 
                    Name = RaceAbilitiesExtension.GetDisplayName(RaceAbilities.CatsClaws), 
                    Description = "Climb speed of 20 ft. and can deal slashing damage with unarmed strikes.",
                    CharacterRaceId = 17 },
                new RaceAbility 
                { 
                    Id = 49, 
                    Name = RaceAbilitiesExtension.GetDisplayName(RaceAbilities.FelineAgility), 
                    Description = "Double your movement speed until the end of your turn (requires no movement next turn to reset).",
                    CharacterRaceId = 17 },

                //Tiefling
                new RaceAbility 
                { 
                    Id = 50, 
                    Name = RaceAbilitiesExtension.GetDisplayName(RaceAbilities.DarkVision), 
                    Description = "See in dim light within 60 ft. as if it were bright light, and in darkness as if it were dim light.",
                    CharacterRaceId = 18 },
                new RaceAbility 
                { 
                    Id = 51, 
                    Name = RaceAbilitiesExtension.GetDisplayName(RaceAbilities.InfernalLegacy), 
                    Description = " Resistance to fire damage.", 
                    CharacterRaceId = 18 },
                new RaceAbility 
                { 
                    Id = 52, 
                    Name = RaceAbilitiesExtension.GetDisplayName(RaceAbilities.HellishResistance), 
                    Description = "Gain the thaumaturgy cantrip and spells like hellish rebuke and darkness as you level up.", 
                    CharacterRaceId = 18 },

                //Tortle
                new RaceAbility 
                { 
                    Id = 53, 
                    Name = RaceAbilitiesExtension.GetDisplayName(RaceAbilities.ShellDefense), 
                    Description = "As an action, you can withdraw into your shell. While in your shell: Your AC increases by 4.You have advantage on Strength and Constitution saving throws.You are prone, your speed is 0, and you can't take reactions.The only actions you can take are a bonus action to emerge or actions that only affect yourself.", 
                    CharacterRaceId = 19 },
                new RaceAbility 
                { 
                    Id = 54, 
                    Name = RaceAbilitiesExtension.GetDisplayName(RaceAbilities.HoldBreath), 
                    Description = "You can hold your breath for up to 1 hour, making Tortles excellent at surviving underwater or in environments without air.", 
                    CharacterRaceId = 19 },
                new RaceAbility 
                { 
                    Id = 55, 
                    Name = RaceAbilitiesExtension.GetDisplayName(RaceAbilities.Claws), 
                    Description = "Your unarmed strikes deal 1d4 slashing damage, thanks to your sharp claws.", 
                    CharacterRaceId = 19 },

                //Yuan-ti Pureblood
                new RaceAbility 
                { 
                    Id = 56, 
                    Name = RaceAbilitiesExtension.GetDisplayName(RaceAbilities.DarkVision), 
                    Description = "See in dim light within 60 ft. as if it were bright light, and in darkness as if it were dim light.", 
                    CharacterRaceId = 20 },
                new RaceAbility 
                { 
                    Id = 57, 
                    Name = RaceAbilitiesExtension.GetDisplayName(RaceAbilities.MagicResistance), 
                    Description = "Advantage on saving throws against spells and magical effects.", 
                    CharacterRaceId = 20 },
                new RaceAbility 
                { 
                    Id = 58, 
                    Name = RaceAbilitiesExtension.GetDisplayName(RaceAbilities.PoisonImmunity), 
                    Description = "Immune to poison damage and the poisoned condition.", 
                    CharacterRaceId = 20 }
            );
        }
    }
}
