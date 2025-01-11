using DND_App.Web.Models.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Diagnostics;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Reflection.Emit;
using Constants = DND_App.Web.StaticClasses.Constants;

namespace DND_App.Web.Data
{
    public class DnDDbContext : DbContext
    {
        public DbSet<Character> Characters { get; set; }
        public DbSet<CharacterClass> CharacterClasses { get; set; }
        public DbSet<ClassAbility> ClassAbilities { get; set; }
        public DbSet<ClassSavingThrow> ClassSavingThrows { get; set; }
        public DbSet<CharacterRace> CharacterRaces { get; set; }

        public DnDDbContext(DbContextOptions<DnDDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure relationships
            modelBuilder.Entity<Character>()
                .HasOne(c => c.CharacterClass)
                .WithMany()
                .HasForeignKey(c => c.CharacterClassId);

            modelBuilder.Entity<Character>()
                .HasOne(c => c.CharacterRace)
                .WithMany()
                .HasForeignKey(c => c.CharacterRaceId);

            modelBuilder.Entity<ClassAbility>()
               .HasOne(ca => ca.CharacterClass)
               .WithMany(cc => cc.ClassAbilities)
               .HasForeignKey(ca => ca.CharacterClassId);

            modelBuilder.Entity<ClassSavingThrow>()
                .HasOne(cst => cst.CharacterClass)
                .WithMany(cc => cc.ClassSavingThrows)
                .HasForeignKey(cst => cst.CharacterClassId);

            modelBuilder.Entity<RaceAbility>()
                .HasOne(ra => ra.CharacterRace)
                .WithMany(ra => ra.RaceAbilities)
                .HasForeignKey(ra => ra.CharacterRaceId);

            modelBuilder.Entity<RaceWeaponProficiency>()
                .HasOne(rwp => rwp.CharacterRace)
                .WithMany(rwp => rwp.RaceWeaponProficiencies)
                .HasForeignKey(rwp => rwp.CharacterRaceId);

            modelBuilder.Entity<RaceToolProficiency>()
                .HasOne(rtp => rtp.CharacterRace)
                .WithMany(rtp => rtp.RaceToolProficiencies)
                .HasForeignKey(rtp => rtp.CharacterRaceId);

            modelBuilder.Entity<Character>()
                .HasOne(c => c.User)
                .WithMany()
                .HasForeignKey(c => c.UserId)
                .OnDelete(DeleteBehavior.Cascade);


            modelBuilder.Entity<CharacterClass>().HasData(
                new CharacterClass
                {
                    Id = 1,
                    Name = "Barbarian",
                    HitDie = 12,
                    FeaturesAndTraitsJson = LoadJsonFile("featuresAndTraits.json")
                },
                new CharacterClass
                {
                    Id = 2,
                    Name = "Bard",
                    HitDie = 8,
                    FeaturesAndTraitsJson = LoadJsonFile("featuresAndTraits.json")
                },
                new CharacterClass
                {
                    Id = 3,
                    Name = "Cleric",
                    HitDie = 8,
                    FeaturesAndTraitsJson = LoadJsonFile("featuresAndTraits.json")
                },
                new CharacterClass
                {
                    Id = 4,
                    Name = "Druid",
                    HitDie = 8,
                    FeaturesAndTraitsJson = LoadJsonFile("featuresAndTraits.json")
                },
                new CharacterClass
                {
                    Id = 5,
                    Name = "Fighter",
                    HitDie = 10,
                    FeaturesAndTraitsJson = LoadJsonFile("featuresAndTraits.json")
                },
                new CharacterClass
                {
                    Id = 6,
                    Name = "Monk",
                    HitDie = 8,
                    FeaturesAndTraitsJson = LoadJsonFile("featuresAndTraits.json")
                },
                new CharacterClass
                {
                    Id = 7,
                    Name = "Paladin",
                    HitDie = 10,
                    FeaturesAndTraitsJson = LoadJsonFile("featuresAndTraits.json")
                },
                new CharacterClass
                {
                    Id = 8,
                    Name = "Ranger",
                    HitDie = 10,
                    FeaturesAndTraitsJson = LoadJsonFile("featuresAndTraits.json")
                },
                new CharacterClass
                {
                    Id = 9,
                    Name = "Rogue",
                    HitDie = 8,
                    FeaturesAndTraitsJson = LoadJsonFile("featuresAndTraits.json")
                },
                new CharacterClass
                {
                    Id = 10,
                    Name = "Sorcerer",
                    HitDie = 6,
                    FeaturesAndTraitsJson = LoadJsonFile("featuresAndTraits.json")
                },
                new CharacterClass
                {
                    Id = 11,
                    Name = "Warlock",
                    HitDie = 8,
                    FeaturesAndTraitsJson = LoadJsonFile("featuresAndTraits.json")
                },
                new CharacterClass
                {
                    Id = 12,
                    Name = "Wizard",
                    HitDie = 6,
                    FeaturesAndTraitsJson = LoadJsonFile("featuresAndTraits.json")
                }
            );
            modelBuilder.Entity<ClassAbility>().HasData(
                new ClassAbility { Id = 1, Name = Constants.Rage, CharacterClassId = 1 },
                new ClassAbility { Id = 2, Name = Constants.UnarmoredDefence, CharacterClassId = 1 },
                new ClassAbility { Id = 3, Name = Constants.BardicInspiration, CharacterClassId = 2 },
                new ClassAbility { Id = 4, Name = Constants.SongOfRest, CharacterClassId = 2 },
                new ClassAbility { Id = 5, Name = Constants.TurnUndead, CharacterClassId = 3 },
                new ClassAbility { Id = 6, Name = Constants.DivineIntervention, CharacterClassId = 3 },
                new ClassAbility { Id = 7, Name = Constants.WildShape, CharacterClassId = 4 },
                new ClassAbility { Id = 8, Name = Constants.Druidic, CharacterClassId = 4 },
                new ClassAbility { Id = 9, Name = Constants.SecondWind, CharacterClassId = 5 },
                new ClassAbility { Id = 10, Name = Constants.ActionSurge, CharacterClassId = 5 },
                new ClassAbility { Id = 11, Name = Constants.MartialArts, CharacterClassId = 6 },
                new ClassAbility { Id = 12, Name = Constants.KiPoints, CharacterClassId = 6 },
                new ClassAbility { Id = 13, Name = Constants.LayOnHands, CharacterClassId = 7 },
                new ClassAbility { Id = 14, Name = Constants.DivineSmite, CharacterClassId = 7 },
                new ClassAbility { Id = 15, Name = Constants.FavoredEnemy, CharacterClassId = 8 },
                new ClassAbility { Id = 16, Name = Constants.NaturalExplorer, CharacterClassId = 8 },
                new ClassAbility { Id = 17, Name = Constants.SneakAttack, CharacterClassId = 9 },
                new ClassAbility { Id = 18, Name = Constants.CunningAction, CharacterClassId = 9 },
                new ClassAbility { Id = 19, Name = Constants.Metamagic, CharacterClassId = 10 },
                new ClassAbility { Id = 20, Name = Constants.FontOfMagic, CharacterClassId = 10 },
                new ClassAbility { Id = 21, Name = Constants.EldritchInvocations, CharacterClassId = 11 },
                new ClassAbility { Id = 22, Name = Constants.PactMagic, CharacterClassId = 11 },
                new ClassAbility { Id = 23, Name = Constants.ArcaneRecovery, CharacterClassId = 12 },
                new ClassAbility { Id = 24, Name = Constants.SpellMastery, CharacterClassId = 12 }
            );
            modelBuilder.Entity<ClassSavingThrow>().HasData(
                new ClassSavingThrow { Id = 1, Name = Constants.Strength, CharacterClassId = 1 },
                new ClassSavingThrow { Id = 2, Name = Constants.Constitution, CharacterClassId = 1 },
                new ClassSavingThrow { Id = 3, Name = Constants.Dexterity, CharacterClassId = 2 },
                new ClassSavingThrow { Id = 4, Name = Constants.Charisma, CharacterClassId = 2 },
                new ClassSavingThrow { Id = 5, Name = Constants.Wisdom, CharacterClassId = 3 },
                new ClassSavingThrow { Id = 6, Name = Constants.Charisma, CharacterClassId = 3 },
                new ClassSavingThrow { Id = 7, Name = Constants.Intelligence, CharacterClassId = 4 },
                new ClassSavingThrow { Id = 8, Name = Constants.Wisdom, CharacterClassId = 4 },
                new ClassSavingThrow { Id = 9, Name = Constants.Strength, CharacterClassId = 5 },
                new ClassSavingThrow { Id = 10, Name = Constants.Constitution, CharacterClassId = 5 },
                new ClassSavingThrow { Id = 11, Name = Constants.Strength, CharacterClassId = 6 },
                new ClassSavingThrow { Id = 12, Name = Constants.Dexterity, CharacterClassId = 6 },
                new ClassSavingThrow { Id = 13, Name = Constants.Wisdom, CharacterClassId = 7 },
                new ClassSavingThrow { Id = 14, Name = Constants.Charisma, CharacterClassId = 7 },
                new ClassSavingThrow { Id = 15, Name = Constants.Strength, CharacterClassId = 8 },
                new ClassSavingThrow { Id = 16, Name = Constants.Dexterity, CharacterClassId = 8 },
                new ClassSavingThrow { Id = 17, Name = Constants.Dexterity, CharacterClassId = 9 },
                new ClassSavingThrow { Id = 18, Name = Constants.Intelligence, CharacterClassId = 9 },
                new ClassSavingThrow { Id = 19, Name = Constants.Constitution, CharacterClassId = 10 },
                new ClassSavingThrow { Id = 20, Name = Constants.Charisma, CharacterClassId = 10 },
                new ClassSavingThrow { Id = 21, Name = Constants.Wisdom, CharacterClassId = 11 },
                new ClassSavingThrow { Id = 22, Name = Constants.Charisma, CharacterClassId = 11 },
                new ClassSavingThrow { Id = 23, Name = Constants.Intelligence, CharacterClassId = 12 },
                new ClassSavingThrow { Id = 24, Name = Constants.Wisdom, CharacterClassId = 12 }
            );

            modelBuilder.Entity<CharacterRace>().HasData(
                new CharacterRace
                {
                    Id = 1,
                    Name = "Aasimar",
                    StrengthBonus = 0,
                    DexterityBonus = 0,
                    ConstitutionBonus = 0,
                    IntelligenceBonus = 2,
                    WisdomBonus = 0,
                    CharismaBonus = 1,
                    FeaturesAndTraitsJson = LoadJsonFile("featuresAndTraits.json")
                },
                new CharacterRace
                {
                    Id = 2,
                    Name = "Dragonborn",
                    StrengthBonus = 2,
                    DexterityBonus = 0,
                    ConstitutionBonus = 0,
                    IntelligenceBonus = 0,
                    WisdomBonus = 0,
                    CharismaBonus = 1,
                    FeaturesAndTraitsJson = LoadJsonFile("featuresAndTraits.json")
                },
                new CharacterRace
                {
                    Id = 3,
                    Name = "Dwarf",
                    StrengthBonus = 0,
                    DexterityBonus = 0,
                    ConstitutionBonus = 2,
                    IntelligenceBonus = 0,
                    WisdomBonus = 0,
                    CharismaBonus = 0,
                    FeaturesAndTraitsJson = LoadJsonFile("featuresAndTraits.json")
                },
                new CharacterRace
                {
                    Id = 4,
                    Name = "Elf",
                    StrengthBonus = 0,
                    DexterityBonus = 2,
                    ConstitutionBonus = 0,
                    IntelligenceBonus = 0,
                    WisdomBonus = 0,
                    CharismaBonus = 0,
                    FeaturesAndTraitsJson = LoadJsonFile("featuresAndTraits.json")
                },
                new CharacterRace
                {
                    Id = 5,
                    Name = "Firbolg",
                    StrengthBonus = 1,
                    DexterityBonus = 0,
                    ConstitutionBonus = 0,
                    IntelligenceBonus = 0,
                    WisdomBonus = 2,
                    CharismaBonus = 0,
                    FeaturesAndTraitsJson = LoadJsonFile("featuresAndTraits.json")
                },
                new CharacterRace
                {
                    Id = 6,
                    Name = "Air Genasi",
                    StrengthBonus = 0,
                    DexterityBonus = 1,
                    ConstitutionBonus = 0,
                    IntelligenceBonus = 0,
                    WisdomBonus = 0,
                    CharismaBonus = 0,
                    FeaturesAndTraitsJson = LoadJsonFile("featuresAndTraits.json")
                },
                new CharacterRace
                {
                    Id = 7,
                    Name = "Earth Genasi",
                    StrengthBonus = 1,
                    DexterityBonus = 0,
                    ConstitutionBonus = 0,
                    IntelligenceBonus = 0,
                    WisdomBonus = 0,
                    CharismaBonus = 0,
                    FeaturesAndTraitsJson = LoadJsonFile("featuresAndTraits.json")
                },
                new CharacterRace
                {
                    Id = 8,
                    Name = "Fire Genasi",
                    StrengthBonus = 0,
                    DexterityBonus = 1,
                    ConstitutionBonus = 0,
                    IntelligenceBonus = 0,
                    WisdomBonus = 0,
                    CharismaBonus = 0,
                    FeaturesAndTraitsJson = LoadJsonFile("featuresAndTraits.json")
                },
                new CharacterRace
                {
                    Id = 9,
                    Name = "Water Genasi",
                    StrengthBonus = 0,
                    DexterityBonus = 0,
                    ConstitutionBonus = 1,
                    IntelligenceBonus = 0,
                    WisdomBonus = 0,
                    CharismaBonus = 0,
                    FeaturesAndTraitsJson = LoadJsonFile("featuresAndTraits.json")
                },
                new CharacterRace
                {
                    Id = 10,
                    Name = "Gnome",
                    StrengthBonus = 0,
                    DexterityBonus = 0,
                    ConstitutionBonus = 0,
                    IntelligenceBonus = 2,
                    WisdomBonus = 0,
                    CharismaBonus = 0,
                    FeaturesAndTraitsJson = LoadJsonFile("featuresAndTraits.json")
                },
                new CharacterRace
                {
                    Id = 11,
                    Name = "Goliath",
                    StrengthBonus = 2,
                    DexterityBonus = 0,
                    ConstitutionBonus = 1,
                    IntelligenceBonus = 0,
                    WisdomBonus = 0,
                    CharismaBonus = 0,
                    FeaturesAndTraitsJson = LoadJsonFile("featuresAndTraits.json")
                },
                new CharacterRace
                {
                    Id = 12,
                    Name = "Half-Elf",
                    StrengthBonus = 0,
                    DexterityBonus = 0,
                    ConstitutionBonus = 0,
                    IntelligenceBonus = 0,
                    WisdomBonus = 0,
                    CharismaBonus = 2,
                    FeaturesAndTraitsJson = LoadJsonFile("featuresAndTraits.json")
                },
                new CharacterRace
                {
                    Id = 13,
                    Name = "Halfling",
                    StrengthBonus = 0,
                    DexterityBonus = 2,
                    ConstitutionBonus = 0,
                    IntelligenceBonus = 0,
                    WisdomBonus = 0,
                    CharismaBonus = 0,
                    FeaturesAndTraitsJson = LoadJsonFile("featuresAndTraits.json")
                },
                new CharacterRace
                {
                    Id = 14,
                    Name = "Half-Orc",
                    StrengthBonus = 2,
                    DexterityBonus = 0,
                    ConstitutionBonus = 1,
                    IntelligenceBonus = 0,
                    WisdomBonus = 0,
                    CharismaBonus = 0,
                    FeaturesAndTraitsJson = LoadJsonFile("featuresAndTraits.json")
                },
                new CharacterRace
                {
                    Id = 15,
                    Name = "Human",
                    StrengthBonus = 1,
                    DexterityBonus = 1,
                    ConstitutionBonus = 1,
                    IntelligenceBonus = 1,
                    WisdomBonus = 1,
                    CharismaBonus = 1,
                    FeaturesAndTraitsJson = LoadJsonFile("featuresAndTraits.json")
                },
                new CharacterRace
                {
                    Id = 16,
                    Name = "Kenku",
                    StrengthBonus = 0,
                    DexterityBonus = 2,
                    ConstitutionBonus = 0,
                    IntelligenceBonus = 0,
                    WisdomBonus = 0,
                    CharismaBonus = 0,
                    FeaturesAndTraitsJson = LoadJsonFile("featuresAndTraits.json")
                },
                new CharacterRace
                {
                    Id = 17,
                    Name = "Tabaxi",
                    StrengthBonus = 0,
                    DexterityBonus = 2,
                    ConstitutionBonus = 0,
                    IntelligenceBonus = 0,
                    WisdomBonus = 0,
                    CharismaBonus = 0,
                    FeaturesAndTraitsJson = LoadJsonFile("featuresAndTraits.json")
                },
                new CharacterRace
                {
                    Id = 18,
                    Name = "Tiefling",
                    StrengthBonus = 0,
                    DexterityBonus = 0,
                    ConstitutionBonus = 0,
                    IntelligenceBonus = 1,
                    WisdomBonus = 0,
                    CharismaBonus = 2,
                    FeaturesAndTraitsJson = LoadJsonFile("featuresAndTraits.json")
                },
                new CharacterRace
                {
                    Id = 19,
                    Name = "Tortle",
                    StrengthBonus = 2,
                    DexterityBonus = 0,
                    ConstitutionBonus = 1,
                    IntelligenceBonus = 0,
                    WisdomBonus = 0,
                    CharismaBonus = 0,
                    FeaturesAndTraitsJson = LoadJsonFile("featuresAndTraits.json")
                },
                new CharacterRace
                {
                    Id = 20,
                    Name = "Yuan-Ti Pureblood",
                    StrengthBonus = 0,
                    DexterityBonus = 0,
                    ConstitutionBonus = 0,
                    IntelligenceBonus = 1,
                    WisdomBonus = 0,
                    CharismaBonus = 2,
                    FeaturesAndTraitsJson = LoadJsonFile("featuresAndTraits.json")
                }
            );
            modelBuilder.Entity<RaceAbility>().HasData(
                new RaceAbility { Id = 1, Name = Constants.Darkvision, CharacterRaceId = 1 },
                new RaceAbility { Id = 2, Name = Constants.HealingHands, CharacterRaceId = 1 },
                new RaceAbility { Id = 3, Name = Constants.BreathWeapon, CharacterRaceId = 2 },
                new RaceAbility { Id = 4, Name = Constants.DraconicAncestry, CharacterRaceId = 2 },
                new RaceAbility { Id = 5, Name = Constants.Darkvision, CharacterRaceId = 3 },
                new RaceAbility { Id = 6, Name = Constants.DwarvenResilience, CharacterRaceId = 3 },
                new RaceAbility { Id = 7, Name = Constants.KeenSenses, CharacterRaceId = 4 },
                new RaceAbility { Id = 8, Name = Constants.FeyAncestry, CharacterRaceId = 4 },
                new RaceAbility { Id = 9, Name = Constants.FirbolgMagic, CharacterRaceId = 5 },
                new RaceAbility { Id = 10, Name = Constants.HiddenStep, CharacterRaceId = 5 },
                new RaceAbility { Id = 11, Name = Constants.UnendingBreath, CharacterRaceId = 6 },
                new RaceAbility { Id = 12, Name = Constants.MingleWithTheWind, CharacterRaceId = 6 },
                new RaceAbility { Id = 13, Name = Constants.EarthWalk, CharacterRaceId = 7 },
                new RaceAbility { Id = 14, Name = Constants.MergeWithStone, CharacterRaceId = 7 },
                new RaceAbility { Id = 15, Name = Constants.Darkvision, CharacterRaceId = 8 },
                new RaceAbility { Id = 16, Name = Constants.FireResistance, CharacterRaceId = 8 },
                new RaceAbility { Id = 17, Name = Constants.AcidResistance, CharacterRaceId = 9 },
                new RaceAbility { Id = 18, Name = Constants.Amphibious, CharacterRaceId = 9 },
                new RaceAbility { Id = 19, Name = Constants.GnomeCunning, CharacterRaceId = 10 },
                new RaceAbility { Id = 20, Name = Constants.Darkvision, CharacterRaceId = 10 },
                new RaceAbility { Id = 21, Name = Constants.MountainBorn, CharacterRaceId = 11 },
                new RaceAbility { Id = 22, Name = Constants.PowerfulBuild, CharacterRaceId = 11 },
                new RaceAbility { Id = 23, Name = Constants.Darkvision, CharacterRaceId = 12 },
                new RaceAbility { Id = 24, Name = Constants.SkillVersatility, CharacterRaceId = 12 },
                new RaceAbility { Id = 25, Name = Constants.Lucky, CharacterRaceId = 13 },
                new RaceAbility { Id = 26, Name = Constants.Brave, CharacterRaceId = 13 },
                new RaceAbility { Id = 27, Name = Constants.RelentlessEndurance, CharacterRaceId = 14 },
                new RaceAbility { Id = 28, Name = Constants.SavageAttack, CharacterRaceId = 14 },
                new RaceAbility { Id = 29, Name = Constants.VersatileAbility, CharacterRaceId = 15 },
                new RaceAbility { Id = 30, Name = Constants.Mimicry, CharacterRaceId = 16 },
                new RaceAbility { Id = 31, Name = Constants.ExpertForgery, CharacterRaceId = 16 },
                new RaceAbility { Id = 32, Name = Constants.CatsClaws, CharacterRaceId = 17 },
                new RaceAbility { Id = 33, Name = Constants.FelineAgility, CharacterRaceId = 17 },
                new RaceAbility { Id = 34, Name = Constants.InfernalLegacy, CharacterRaceId = 18 },
                new RaceAbility { Id = 35, Name = Constants.HellishResistance, CharacterRaceId = 18 },
                new RaceAbility { Id = 36, Name = Constants.NaturalArmor, CharacterRaceId = 19 },
                new RaceAbility { Id = 37, Name = Constants.HoldBreath, CharacterRaceId = 19 },
                new RaceAbility { Id = 38, Name = Constants.MagicResistance, CharacterRaceId = 20 },
                new RaceAbility { Id = 39, Name = Constants.PoisonImmunity, CharacterRaceId = 20 }
            );
            modelBuilder.Entity<RaceWeaponProficiency>().HasData(
                new RaceWeaponProficiency { Id = 1, Name = Constants.None, CharacterRaceId = 1 },
                new RaceWeaponProficiency { Id = 2, Name = Constants.None, CharacterRaceId = 2 },
                new RaceWeaponProficiency { Id = 3, Name = Constants.Battleaxe, CharacterRaceId = 3 },
                new RaceWeaponProficiency { Id = 4, Name = Constants.Handaxe, CharacterRaceId = 3 },
                new RaceWeaponProficiency { Id = 5, Name = Constants.ThrowingHammer, CharacterRaceId = 3 },
                new RaceWeaponProficiency { Id = 6, Name = Constants.Warhammer, CharacterRaceId = 3 },
                new RaceWeaponProficiency { Id = 7, Name = Constants.Longsword, CharacterRaceId = 4 },
                new RaceWeaponProficiency { Id = 8, Name = Constants.Shortsword, CharacterRaceId = 4 },
                new RaceWeaponProficiency { Id = 9, Name = Constants.Shortbow, CharacterRaceId = 4 },
                new RaceWeaponProficiency { Id = 10, Name = Constants.Longbow, CharacterRaceId = 4 },
                new RaceWeaponProficiency { Id = 11, Name = Constants.None, CharacterRaceId = 5 },
                new RaceWeaponProficiency { Id = 12, Name = Constants.None, CharacterRaceId = 6 },
                new RaceWeaponProficiency { Id = 13, Name = Constants.None, CharacterRaceId = 7 },
                new RaceWeaponProficiency { Id = 14, Name = Constants.None, CharacterRaceId = 8 },
                new RaceWeaponProficiency { Id = 15, Name = Constants.None, CharacterRaceId = 9 },
                new RaceWeaponProficiency { Id = 16, Name = Constants.None, CharacterRaceId = 10 },
                new RaceWeaponProficiency { Id = 17, Name = Constants.None, CharacterRaceId = 11 },
                new RaceWeaponProficiency { Id = 18, Name = Constants.Longsword, CharacterRaceId = 12 },
                new RaceWeaponProficiency { Id = 19, Name = Constants.Shortsword, CharacterRaceId = 12 },
                new RaceWeaponProficiency { Id = 20, Name = Constants.Shortbow, CharacterRaceId = 12 },
                new RaceWeaponProficiency { Id = 21, Name = Constants.Longbow, CharacterRaceId = 12 },
                new RaceWeaponProficiency { Id = 22, Name = Constants.None, CharacterRaceId = 13 },
                new RaceWeaponProficiency { Id = 23, Name = Constants.None, CharacterRaceId = 14 },
                new RaceWeaponProficiency { Id = 24, Name = Constants.Longsword, CharacterRaceId = 15 },
                new RaceWeaponProficiency { Id = 25, Name = Constants.Shortsword, CharacterRaceId = 15 },
                new RaceWeaponProficiency { Id = 26, Name = Constants.None, CharacterRaceId = 16 },
                new RaceWeaponProficiency { Id = 27, Name = Constants.None, CharacterRaceId = 17 },
                new RaceWeaponProficiency { Id = 28, Name = Constants.None, CharacterRaceId = 18 },
                new RaceWeaponProficiency { Id = 29, Name = Constants.None, CharacterRaceId = 19 },
                new RaceWeaponProficiency { Id = 30, Name = Constants.None, CharacterRaceId = 20 }
            );
            modelBuilder.Entity<RaceToolProficiency>().HasData(
                new RaceToolProficiency { Id = 1, Name = Constants.AlchemistsSupplies, CharacterRaceId = 1 },
                new RaceToolProficiency { Id = 2, Name = Constants.CalligraphersSupplies, CharacterRaceId = 1 },
                new RaceToolProficiency { Id = 3, Name = Constants.HerbalismKit, CharacterRaceId = 1 },
                new RaceToolProficiency { Id = 4, Name = Constants.MusicalInstrument, CharacterRaceId = 1 },
                new RaceToolProficiency { Id = 5, Name = Constants.PaintersSupplies, CharacterRaceId = 1 },
                new RaceToolProficiency { Id = 6, Name = Constants.SmithsTools, CharacterRaceId = 2 },
                new RaceToolProficiency { Id = 7, Name = Constants.BrewersSupplies, CharacterRaceId = 2 },
                new RaceToolProficiency { Id = 8, Name = Constants.CalligraphersSupplies, CharacterRaceId = 2 },
                new RaceToolProficiency { Id = 9, Name = Constants.MasonsTools, CharacterRaceId = 2 },
                new RaceToolProficiency { Id = 10, Name = Constants.DragonchessSet, CharacterRaceId = 2 },
                new RaceToolProficiency { Id = 11, Name = Constants.SmithsTools, CharacterRaceId = 3 },
                new RaceToolProficiency { Id = 13, Name = Constants.BrewersSupplies, CharacterRaceId = 3 },
                new RaceToolProficiency { Id = 14, Name = Constants.MasonsTools, CharacterRaceId = 3 },
                new RaceToolProficiency { Id = 15, Name = Constants.HerbalismKit, CharacterRaceId = 4 },
                new RaceToolProficiency { Id = 16, Name = Constants.CalligraphersSupplies, CharacterRaceId = 4 },
                new RaceToolProficiency { Id = 17, Name = Constants.MusicalInstrument, CharacterRaceId = 4 },
                new RaceToolProficiency { Id = 18, Name = Constants.PaintersSupplies, CharacterRaceId = 4 },
                new RaceToolProficiency { Id = 19, Name = Constants.AlchemistsSupplies, CharacterRaceId = 4 },
                new RaceToolProficiency { Id = 20, Name = Constants.HerbalismKit, CharacterRaceId = 5 },
                new RaceToolProficiency { Id = 21, Name = Constants.CarpenterTools, CharacterRaceId = 5 },
                new RaceToolProficiency { Id = 22, Name = Constants.CooksUtensils, CharacterRaceId = 5 },
                new RaceToolProficiency { Id = 23, Name = Constants.MasonsTools, CharacterRaceId = 5 },
                new RaceToolProficiency { Id = 24, Name = Constants.PaintersSupplies, CharacterRaceId = 5 },
                new RaceToolProficiency { Id = 25, Name = Constants.NavigatorsTools, CharacterRaceId = 6 },
                new RaceToolProficiency { Id = 26, Name = Constants.CartographerTools, CharacterRaceId = 6 },
                new RaceToolProficiency { Id = 27, Name = Constants.TinkersTools, CharacterRaceId = 6 },
                new RaceToolProficiency { Id = 28, Name = Constants.Flute, CharacterRaceId = 6 },
                new RaceToolProficiency { Id = 29, Name = Constants.CalligraphersSupplies, CharacterRaceId = 6 },
                new RaceToolProficiency { Id = 30, Name = Constants.SmithsTools, CharacterRaceId = 7 },
                new RaceToolProficiency { Id = 31, Name = Constants.MasonsTools, CharacterRaceId = 7 },
                new RaceToolProficiency { Id = 32, Name = Constants.MinersTools, CharacterRaceId = 7 },
                new RaceToolProficiency { Id = 33, Name = Constants.PottersTools, CharacterRaceId = 7 },
                new RaceToolProficiency { Id = 34, Name = Constants.CartographerTools, CharacterRaceId = 7 },
                new RaceToolProficiency { Id = 35, Name = Constants.AlchemistsSupplies, CharacterRaceId = 8 },
                new RaceToolProficiency { Id = 36, Name = Constants.GlassblowersTools, CharacterRaceId = 8 },
                new RaceToolProficiency { Id = 37, Name = Constants.SmithsTools, CharacterRaceId = 8 },
                new RaceToolProficiency { Id = 38, Name = Constants.CooksUtensils, CharacterRaceId = 8 },
                new RaceToolProficiency { Id = 39, Name = Constants.BrewersSupplies, CharacterRaceId = 8 },
                new RaceToolProficiency { Id = 40, Name = Constants.NavigatorsTools, CharacterRaceId = 9 },
                new RaceToolProficiency { Id = 41, Name = Constants.FishingTackle, CharacterRaceId = 9 },
                new RaceToolProficiency { Id = 42, Name = Constants.CartographerTools, CharacterRaceId = 9 },
                new RaceToolProficiency { Id = 43, Name = Constants.CooksUtensils, CharacterRaceId = 9 },
                new RaceToolProficiency { Id = 44, Name = Constants.BrewersSupplies, CharacterRaceId = 9 },
                new RaceToolProficiency { Id = 45, Name = Constants.TinkersTools, CharacterRaceId = 10 },
                new RaceToolProficiency { Id = 46, Name = Constants.AlchemistsSupplies, CharacterRaceId = 10 },
                new RaceToolProficiency { Id = 47, Name = Constants.ArtisansTools, CharacterRaceId = 10 },
                new RaceToolProficiency { Id = 48, Name = Constants.CartographerTools, CharacterRaceId = 10 },
                new RaceToolProficiency { Id = 49, Name = Constants.PaintersSupplies, CharacterRaceId = 10 },
                new RaceToolProficiency { Id = 50, Name = Constants.SmithsTools, CharacterRaceId = 11 },
                new RaceToolProficiency { Id = 51, Name = Constants.MasonsTools, CharacterRaceId = 11 },
                new RaceToolProficiency { Id = 52, Name = Constants.CarpenterTools, CharacterRaceId = 11 },
                new RaceToolProficiency { Id = 53, Name = Constants.CooksUtensils, CharacterRaceId = 11 },
                new RaceToolProficiency { Id = 54, Name = Constants.BrewersSupplies, CharacterRaceId = 11 },
                new RaceToolProficiency { Id = 55, Name = Constants.Fiddle, CharacterRaceId = 12 },
                new RaceToolProficiency { Id = 56, Name = Constants.CalligraphersSupplies, CharacterRaceId = 12 },
                new RaceToolProficiency { Id = 57, Name = Constants.PaintersSupplies, CharacterRaceId = 12 },
                new RaceToolProficiency { Id = 58, Name = Constants.AlchemistsSupplies, CharacterRaceId = 12 },
                new RaceToolProficiency { Id = 59, Name = Constants.JewelersTools, CharacterRaceId = 12 },
                new RaceToolProficiency { Id = 60, Name = Constants.CooksUtensils, CharacterRaceId = 13 },
                new RaceToolProficiency { Id = 61, Name = Constants.BrewersSupplies, CharacterRaceId = 13 },
                new RaceToolProficiency { Id = 62, Name = Constants.WeaversTools, CharacterRaceId = 13 },
                new RaceToolProficiency { Id = 63, Name = Constants.WoodcarversTools, CharacterRaceId = 13 },
                new RaceToolProficiency { Id = 64, Name = Constants.HerbalismKit, CharacterRaceId = 13 },
                new RaceToolProficiency { Id = 65, Name = Constants.SmithsTools, CharacterRaceId = 14 },
                new RaceToolProficiency { Id = 66, Name = Constants.LeatherworkerTools, CharacterRaceId = 14 },
                new RaceToolProficiency { Id = 67, Name = Constants.CarpenterTools, CharacterRaceId = 14 },
                new RaceToolProficiency { Id = 68, Name = Constants.CooksUtensils, CharacterRaceId = 14 },
                new RaceToolProficiency { Id = 69, Name = Constants.BrewersSupplies, CharacterRaceId = 14 },
                new RaceToolProficiency { Id = 70, Name = Constants.SmithsTools, CharacterRaceId = 15 },
                new RaceToolProficiency { Id = 71, Name = Constants.FarmersTools, CharacterRaceId = 15 },
                new RaceToolProficiency { Id = 72, Name = Constants.MasonsTools, CharacterRaceId = 15 },
                new RaceToolProficiency { Id = 73, Name = Constants.BrewersSupplies, CharacterRaceId = 15 },
                new RaceToolProficiency { Id = 74, Name = Constants.HerbalismKit, CharacterRaceId = 15 },
                new RaceToolProficiency { Id = 75, Name = Constants.CalligraphersSupplies, CharacterRaceId = 16 },
                new RaceToolProficiency { Id = 76, Name = Constants.DisguiseKit, CharacterRaceId = 16 },
                new RaceToolProficiency { Id = 77, Name = Constants.TinkersTools, CharacterRaceId = 16 },
                new RaceToolProficiency { Id = 78, Name = Constants.ThievesTools, CharacterRaceId = 16 },
                new RaceToolProficiency { Id = 79, Name = Constants.PaintersSupplies, CharacterRaceId = 16 },
                new RaceToolProficiency { Id = 80, Name = Constants.CartographerTools, CharacterRaceId = 17 },
                new RaceToolProficiency { Id = 81, Name = Constants.CalligraphersSupplies, CharacterRaceId = 17 },
                new RaceToolProficiency { Id = 82, Name = Constants.PaintersSupplies, CharacterRaceId = 17 },
                new RaceToolProficiency { Id = 83, Name = Constants.Drums, CharacterRaceId = 17 },
                new RaceToolProficiency { Id = 84, Name = Constants.ThievesTools, CharacterRaceId = 17 },
                new RaceToolProficiency { Id = 85, Name = Constants.AlchemistsSupplies, CharacterRaceId = 18 },
                new RaceToolProficiency { Id = 86, Name = Constants.CalligraphersSupplies, CharacterRaceId = 18 },
                new RaceToolProficiency { Id = 87, Name = Constants.DisguiseKit, CharacterRaceId = 18 },
                new RaceToolProficiency { Id = 88, Name = Constants.Lyre, CharacterRaceId = 18 },
                new RaceToolProficiency { Id = 89, Name = Constants.ForgeryKit, CharacterRaceId = 18 },
                new RaceToolProficiency { Id = 90, Name = Constants.MasonsTools, CharacterRaceId = 19 },
                new RaceToolProficiency { Id = 91, Name = Constants.CarpenterTools, CharacterRaceId = 19 },
                new RaceToolProficiency { Id = 92, Name = Constants.CooksUtensils, CharacterRaceId = 19 },
                new RaceToolProficiency { Id = 93, Name = Constants.FishingTackle, CharacterRaceId = 19 },
                new RaceToolProficiency { Id = 94, Name = Constants.HerbalismKit, CharacterRaceId = 19 },
                new RaceToolProficiency { Id = 95, Name = Constants.PoisonersKit, CharacterRaceId = 20 },
                new RaceToolProficiency { Id = 96, Name = Constants.AlchemistsSupplies, CharacterRaceId = 20 },
                new RaceToolProficiency { Id = 97, Name = Constants.DisguiseKit, CharacterRaceId = 20 },
                new RaceToolProficiency { Id = 98, Name = Constants.ForgeryKit, CharacterRaceId = 20 },
                new RaceToolProficiency { Id = 99, Name = Constants.CalligraphersSupplies, CharacterRaceId = 20 }
            );
        }


        private static string LoadJsonFile(string fileName)
        {
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "SeedData", fileName);
            return File.Exists(filePath) ? File.ReadAllText(filePath) : string.Empty;
        }

    }
}
