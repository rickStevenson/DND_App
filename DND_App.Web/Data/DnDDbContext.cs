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
                    HitDie = 12
                },
                new CharacterClass
                {
                    Id = 2,
                    Name = "Bard",
                    HitDie = 8
                },
                new CharacterClass
                {
                    Id = 3,
                    Name = "Cleric",
                    HitDie = 8
                },
                new CharacterClass
                {
                    Id = 4,
                    Name = "Druid",
                    HitDie = 8
                },
                new CharacterClass
                {
                    Id = 5,
                    Name = "Fighter",
                    HitDie = 10
                },
                new CharacterClass
                {
                    Id = 6,
                    Name = "Monk",
                    HitDie = 8
                },
                new CharacterClass
                {
                    Id = 7,
                    Name = "Paladin",
                    HitDie = 10
                },
                new CharacterClass
                {
                    Id = 8,
                    Name = "Ranger",
                    HitDie = 10
                },
                new CharacterClass
                {
                    Id = 9,
                    Name = "Rogue",
                    HitDie = 8
                },
                new CharacterClass
                {
                    Id = 10,
                    Name = "Sorcerer",
                    HitDie = 6
                },
                new CharacterClass
                {
                    Id = 11,
                    Name = "Warlock",
                    HitDie = 8
                },
                new CharacterClass
                {
                    Id = 12,
                    Name = "Wizard",
                    HitDie = 6
                }
            );
            modelBuilder.Entity<ClassAbility>().HasData(
                //Barbarian
                new ClassAbility { Id = 1, Name = Constants.Rage, Description = "Enter a frenzied state to gain bonus damage, resist physical damage, and advantage on Strength checks/saving throws.", CharacterClassId = 1 },
                new ClassAbility { Id = 2, Name = Constants.UnarmoredDefence, Description = "Add Constitution modifier to AC when not wearing armor.", CharacterClassId = 1 },
                new ClassAbility { Id = 3, Name = Constants.RecklessAttack, Description = "Gain advantage on melee attack rolls, but attacks against you also have advantage.", CharacterClassId = 1 },
                new ClassAbility { Id = 4, Name = Constants.DangerSense, Description = "Gain advantage on Dexterity saving throws against effects you can see.", CharacterClassId = 1 },

                //Bard
                new ClassAbility { Id = 5, Name = Constants.BardicInspiration,Description = "Inspire allies with a bonus to ability checks, attack rolls, or saving throws.",
                    CharacterClassId = 2 },
                new ClassAbility { Id = 6, Name = Constants.SongOfRest, Description = "Help allies recover additional hit points during short rests.", CharacterClassId = 2 },
                new ClassAbility{ Id = 7, Name = Constants.BardicMagic, Description = "Use a wide variety of spells to charm, inspire, and deal damage.", CharacterClassId = 2},
                new ClassAbility{ Id = 8, Name = Constants.JackOfAllTrades, Description = "Add half proficiency bonus to all ability checks you’re not proficient in.", CharacterClassId = 2 },
               
                //Cleric
                new ClassAbility { Id = 9, Name = Constants.TurnUndead, Description = "Turn undead or perform a special ability depending on your domain.", CharacterClassId = 3 },
                new ClassAbility { Id = 10, Name = Constants.DivineIntervention, Description = "Divine spells drawn from your deity’s domain.", CharacterClassId = 3 },
                new ClassAbility { Id = 11, Name = Constants.DivineDomain, Description = "Gain unique abilities based on the chosen divine domain, such as Life, Light, or War.", CharacterClassId = 3 },

                //Druid
                new ClassAbility { Id = 12, Name = Constants.WildShape, Description = "Transform into beasts you’ve seen, gaining their physical traits.", CharacterClassId = 4 },
                new ClassAbility { Id = 13, Name = Constants.DruidicCircle, Description = "Choose a focus for your abilities, such as the Circle of the Land (nature magic) or the Circle of the Moon (enhanced Wild Shape).", CharacterClassId = 4 },
                new ClassAbility { Id = 14, Name = Constants.SpellsOfNature, Description = "Use nature-themed spells to control the environment and heal.", CharacterClassId = 4 },

                //Fighter
                new ClassAbility { Id = 15, Name = Constants.SecondWind, Description = "Recover some hit points as a bonus action.", CharacterClassId = 5 },
                new ClassAbility { Id = 16, Name = Constants.ActionSurge, Description = "Take an additional action on your turn.", CharacterClassId = 5 },
                new ClassAbility { Id = 17, Name = Constants.FightingStyle, Description = "Choose a specialization like Archery or Defense.", CharacterClassId = 5 },
                new ClassAbility { Id = 18, Name = Constants.MartialArchetype, Description = "Gain unique features such as magic use (Eldritch Knight) or commanding allies (Battle Master).", CharacterClassId = 5 },

                //Monk
                new ClassAbility { Id = 19, Name = Constants.MartialArts, Description = "Use Dexterity instead of Strength for unarmed strikes and monk weapons.", CharacterClassId = 6 },
                new ClassAbility { Id = 20, Name = Constants.KiPoints, Description = "Perform extraordinary abilities like flurries of blows, increased speed, or stunning strikes.", CharacterClassId = 6 },
                new ClassAbility { Id = 21, Name = Constants.UnarmoredDefense, Description = "Add Wisdom modifier to AC when not wearing armor.", CharacterClassId = 6 },
                new ClassAbility { Id = 22, Name = Constants.DeflectMissles, Description = "Reduce damage from ranged weapon attacks.", CharacterClassId = 6 },

                //Paladin
                new ClassAbility { Id = 23, Name = Constants.LayOnHands, Description = "Heal yourself or others by expending points from a healing pool.", CharacterClassId = 7 },
                new ClassAbility { Id = 24, Name = Constants.DivineSmite, Description = " Use spell slots to deal radiant damage on weapon attacks.", CharacterClassId = 7 },
                new ClassAbility { Id = 25, Name = Constants.AuraOfProtection, Description = "Add Charisma modifier to saving throws for you and nearby allies.", CharacterClassId = 7 },
                new ClassAbility { Id = 26, Name = Constants.SacredOath, Description = "Swear an oath like Devotion, Vengeance, or Ancients for unique abilities.", CharacterClassId = 7 },

                //Ranger
                new ClassAbility { Id = 27, Name = Constants.FavoredEnemy, Description = "Gain bonuses to tracking and dealing with a specific type of creature.", CharacterClassId = 8 },
                new ClassAbility { Id = 28, Name = Constants.NaturalExplorer, Description = "Gain benefits while traveling through chosen types of terrain.", CharacterClassId = 8 },
                new ClassAbility { Id = 29, Name = Constants.RangerMagic, Description = "Use nature magic to aid exploration and combat.", CharacterClassId = 8 },
                new ClassAbility { Id = 30, Name = Constants.HuntersMark, Description = "Mark a target to deal extra damage and track it.", CharacterClassId = 8 },

                //Rogue
                new ClassAbility { Id = 31, Name = Constants.SneakAttack, Description = "Deal extra damage when you hit with an attack and have advantage or an ally nearby.", CharacterClassId = 9 },
                new ClassAbility { Id = 32, Name = Constants.CunningAction, Description = "Use a bonus action to Dash, Disengage, or Hide.", CharacterClassId = 9 },
                new ClassAbility { Id = 33, Name = Constants.UncannyDodge, Description = "Halve damage from one attack per round.", CharacterClassId = 9 },
                new ClassAbility { Id = 34, Name = Constants.Evasion, Description = "Avoid all damage on successful Dexterity saves against area effects.", CharacterClassId = 9 },

                //Sorcerer
                new ClassAbility { Id = 35, Name = Constants.Metamagic, Description = "Enhance spells by extending their range, duration, or allowing multiple targets.", CharacterClassId = 10 },
                new ClassAbility { Id = 36, Name = Constants.WildMagic, Description = " Gain features based on your origin, such as elemental resistance or chaotic magical effects.", CharacterClassId = 10 },
                new ClassAbility { Id = 37, Name = Constants.Sorcery, Description = "Use innate magical power to cast spells.", CharacterClassId = 10 },
                new ClassAbility { Id = 38, Name = Constants.SorceryPoints, Description = "Fuel unique abilities, such as Metamagic (modifying spells in unique ways).", CharacterClassId = 10 },

                //Worlock
                new ClassAbility { Id = 39, Name = Constants.PactMagic, Description = "Use limited spell slots that recharge on short rests.", CharacterClassId = 11 },
                new ClassAbility { Id = 40, Name = Constants.EldritchInvocations, Description = "Gain specialized magical abilities, such as improved Eldritch Blast.", CharacterClassId = 11 },
                new ClassAbility { Id = 41, Name = Constants.PactBoon, Description = " Choose a boon like a familiar (Pact of the Chain), a weapon (Pact of the Blade), or a magical book (Pact of the Tome).", CharacterClassId = 11 },
                new ClassAbility { Id = 42, Name = Constants.PatronFeatures, Description = "Gain abilities from a pact with an otherworldly entity like the Archfey, Fiend, or Great Old One.", CharacterClassId = 11 },

                //Wizard
                new ClassAbility { Id = 43, Name = Constants.ArcaneRecovery, Description = "Regain spell slots during a short rest.", CharacterClassId = 12 },
                new ClassAbility { Id = 44, Name = Constants.SpellMastery, Description = "Access the largest variety of spells in the game.", CharacterClassId = 12 },
                new ClassAbility { Id = 45, Name = Constants.ArcaneTradition, Description = "Choose a school of magic specialization, such as Evocation (damage spells) or Divination (seeing the future).", CharacterClassId = 12 },
                new ClassAbility { Id = 46, Name = Constants.RitualCasting, Description = "Cast certain spells without expending a spell slot.", CharacterClassId = 12 }


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
                    CharismaBonus = 1
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
                    CharismaBonus = 1
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
                    CharismaBonus = 0
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
                    CharismaBonus = 0
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
                    CharismaBonus = 0
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
                    CharismaBonus = 0
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
                    CharismaBonus = 0
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
                    CharismaBonus = 0
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
                    CharismaBonus = 0
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
                    CharismaBonus = 0
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
                    CharismaBonus = 0
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
                    CharismaBonus = 2
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
                    CharismaBonus = 0
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
                    CharismaBonus = 0
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
                    CharismaBonus = 1
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
                    CharismaBonus = 0
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
                    CharismaBonus = 0
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
                    CharismaBonus = 2
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
                    CharismaBonus = 0
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
                    CharismaBonus = 2
                }
            );
            modelBuilder.Entity<RaceAbility>().HasData(
                //Aasimar
                new RaceAbility { Id = 1, Name = Constants.DarkVision, Description = "See in dim light within 60 ft. as if it were bright light, and in darkness as if it were dim light.", CharacterRaceId = 1 },
                new RaceAbility { Id = 2, Name = Constants.CelestialResitance, Description = "Resistance to radiant and necrotic damage.", CharacterRaceId = 1 },
                new RaceAbility { Id = 3, Name = Constants.HealingHands, Description = "As an action, touch a creature to restore hit points equal to your level.", CharacterRaceId = 1 },
                new RaceAbility { Id = 4, Name = Constants.LightBearer, Description = "Gain the light cantrip.", CharacterRaceId = 1 },

                //Dragonborn
                new RaceAbility { Id = 5, Name = Constants.BreathWeapon, Description = "Exhale destructive energy in a 15 ft. cone or 30 ft. line (Dex or Con save, depending on ancestry).", CharacterRaceId = 2 },
                new RaceAbility { Id = 6, Name = Constants.DraconicResistance, Description = "Gain resistance to the damage type associated with your draconic ancestry (fire, cold, lightning, etc.).", CharacterRaceId = 2 },

                //Dwarf
                new RaceAbility { Id = 7, Name = Constants.DarkVision, Description = "See in dim light within 60 ft. as if it were bright light, and in darkness as if it were dim light.", CharacterRaceId = 3 },
                new RaceAbility { Id = 8, Name = Constants.DwarvenResilience, Description = " Advantage on saving throws against poison, and resistance to poison damage.", CharacterRaceId = 3 },
                new RaceAbility { Id = 9, Name = Constants.Stonecunning, Description = "Add double proficiency to Intelligence (History) checks related to stonework.", CharacterRaceId = 3 },

                //Elf
                new RaceAbility { Id = 10, Name = Constants.DarkVision, Description = "See in dim light within 60 ft. as if it were bright light, and in darkness as if it were dim light.", CharacterRaceId = 4 },
                new RaceAbility { Id = 11, Name = Constants.KeenSenses, Description = "Proficiency in Perception.", CharacterRaceId = 4 },
                new RaceAbility { Id = 12, Name = Constants.FeyAncestry, Description = "Advantage on saving throws against being charmed, and immunity to magical sleep.", CharacterRaceId = 4 },
                new RaceAbility { Id = 13, Name = Constants.Trance, Description = "Elves don’t need sleep. They can finish a long rest in 4 hours while meditating.", CharacterRaceId = 4 },

                //Firbolg
                new RaceAbility { Id = 14, Name = Constants.FirbolgMagic, Description = "Cast detect magic and disguise self without expending a spell slot.", CharacterRaceId = 5 },
                new RaceAbility { Id = 15, Name = Constants.HiddenStep, Description = "Turn invisible as a bonus action until the start of your next turn.", CharacterRaceId = 5 },
                new RaceAbility { Id = 16, Name = Constants.PowerfulBuild, Description = "Count as one size larger for carrying capacity.", CharacterRaceId = 5 },
                new RaceAbility { Id = 17, Name = Constants.SpeachOfBeastAndLeaf, Description = "Communicate with animals and plants (they understand you but cannot speak back).", CharacterRaceId = 5 },

                //Air Genasi
                new RaceAbility { Id = 18, Name = Constants.UnendingBreath, Description = "You can hold your breath indefinitely while not incapacitated.", CharacterRaceId = 6 },
                new RaceAbility { Id = 19, Name = Constants.MingleWithTheWind, Description = "You can cast the Levitate spell once with this trait, requiring no material components. You regain the ability to cast it this way after a long rest. Constitution is your spellcasting ability for this spell.", CharacterRaceId = 6 },

                //Earth Genasi
                new RaceAbility { Id = 20, Name = Constants.EarthWalk, Description = "You can move across difficult terrain made of earth or stone without expending extra movement.", CharacterRaceId = 7 },
                new RaceAbility { Id = 21, Name = Constants.MergeWithStone, Description = "You can cast the Pass Without Trace spell once with this trait, requiring no material components. You regain the ability to cast it this way after a long rest. Constitution is your spellcasting ability for this spell.", CharacterRaceId = 7 },

                //Fire Genasi
                new RaceAbility { Id = 22, Name = Constants.DarkVision, Description = "You can see in dim light within 60 feet as if it were bright light, and in darkness as if it were dim light. Your vision in darkness is in shades of red.", CharacterRaceId = 8 },
                new RaceAbility { Id = 23, Name = Constants.FireResistance, Description = "You have resistance to fire damage.", CharacterRaceId = 8 },
                new RaceAbility { Id = 24, Name = Constants.ReachToTheBlaze, Description = "You know the Produce Flame cantrip. Once you reach 3rd level, you can cast the Burning Hands spell once with this trait as a 1st-level spell. You regain the ability to cast it this way after a long rest. Constitution is your spellcasting ability for these spells.", CharacterRaceId = 8 },

                //Water Genasi
                new RaceAbility { Id = 25, Name = Constants.AcidResistance, Description = "You have resistance to acid damage.", CharacterRaceId = 9 },
                new RaceAbility { Id = 26, Name = Constants.Amphibious, Description = "You can breathe air and water.", CharacterRaceId = 9 },
                new RaceAbility { Id = 27, Name = Constants.CallToTheWave, Description = "You know the Shape Water cantrip. Once you reach 3rd level, you can cast the Create or Destroy Water spell once with this trait. You regain the ability to cast it this way after a long rest. Constitution is your spellcasting ability for these spells.", CharacterRaceId = 9 },

                //Gnome
                new RaceAbility { Id = 28, Name = Constants.DarkVision, Description = "See in dim light within 60 ft. as if it were bright light, and in darkness as if it were dim light.", CharacterRaceId = 10 },
                new RaceAbility { Id = 29, Name = Constants.GnomeCunning, Description = "Advantage on all Intelligence, Wisdom, and Charisma saving throws against magic.", CharacterRaceId = 10 },

                //Goliath
                new RaceAbility { Id = 30, Name = Constants.NaturalAthlete, Description = "Proficiency in Athletics.", CharacterRaceId = 11 },
                new RaceAbility { Id = 31, Name = Constants.MountainBorn, Description = "Resistance to cold damage and acclimated to high altitudes.", CharacterRaceId = 11 },
                new RaceAbility { Id = 32, Name = Constants.PowerfulBuild, Description = "Count as one size larger for carrying capacity.", CharacterRaceId = 11 },
                new RaceAbility { Id = 33, Name = Constants.StonesEndurance, Description = "Reduce damage taken by 1d12 + Constitution modifier once per short or long rest.", CharacterRaceId = 11 },

                //Half Elf
                new RaceAbility { Id = 34, Name = Constants.DarkVision, Description = "See in dim light within 60 ft. as if it were bright light, and in darkness as if it were dim light.", CharacterRaceId = 12 },
                new RaceAbility { Id = 35, Name = Constants.FeyAncestry, Description = "Advantage on saving throws against being charmed, and immunity to magical sleep.", CharacterRaceId = 12 },
                new RaceAbility { Id = 36, Name = Constants.SkillVersatility, Description = "Gain proficiency in two skills of your choice.", CharacterRaceId = 12 },

                //Halfling
                new RaceAbility { Id = 37, Name = Constants.Lucky, Description = " When you roll a 1 on an attack roll, ability check, or saving throw, you can reroll and must use the new roll.", CharacterRaceId = 13 },
                new RaceAbility { Id = 38, Name = Constants.Brave, Description = "Advantage on saving throws against being frightened.", CharacterRaceId = 13 },
                new RaceAbility { Id = 39, Name = Constants.HalflingNimbleness, Description = "Move through the space of any creature larger than you.", CharacterRaceId = 13 },

                //Half Orc
                new RaceAbility { Id = 40, Name = Constants.RelentlessEndurance, Description = "See in dim light within 60 ft. as if it were bright light, and in darkness as if it were dim light.", CharacterRaceId = 14 },
                new RaceAbility { Id = 41, Name = Constants.RelentlessEndurance, Description = "When reduced to 0 HP but not killed outright, you drop to 1 HP instead (once per long rest).", CharacterRaceId = 14 },
                new RaceAbility { Id = 42, Name = Constants.SavageAttack, Description = " When you score a critical hit with a melee weapon, roll one additional damage die.", CharacterRaceId = 14 },

                //Human
                new RaceAbility { Id = 43, Name = Constants.VersatileAbility, Description = "Gain a feat and proficiency in one skill of your choice.\r\n", CharacterRaceId = 15 },

                //Kenku
                new RaceAbility { Id = 44, Name = Constants.Mimicry, Description = "Mimic sounds you’ve heard, such as voices.", CharacterRaceId = 16 },
                new RaceAbility { Id = 45, Name = Constants.ExpertForgery, Description = "Duplicate writing and craftwork perfectly.", CharacterRaceId = 16 },
                new RaceAbility { Id = 46, Name = Constants.SkillProficiencies, Description = "Proficiency in Deception and Stealth.", CharacterRaceId = 16 },

                //Tabaxi
                new RaceAbility { Id = 47, Name = Constants.DarkVision, Description = "See in dim light within 60 ft. as if it were bright light, and in darkness as if it were dim light.", CharacterRaceId = 17 },
                new RaceAbility { Id = 48, Name = Constants.CatsClaws, Description = "Climb speed of 20 ft. and can deal slashing damage with unarmed strikes.", CharacterRaceId = 17 },
                new RaceAbility { Id = 49, Name = Constants.FelineAgility, Description = "Double your movement speed until the end of your turn (requires no movement next turn to reset).", CharacterRaceId = 17 },

                //Tiefling
                new RaceAbility { Id = 50, Name = Constants.DarkVision, Description = "See in dim light within 60 ft. as if it were bright light, and in darkness as if it were dim light.", CharacterRaceId = 18 },
                new RaceAbility { Id = 51, Name = Constants.InfernalLegacy, Description = " Resistance to fire damage.", CharacterRaceId = 18 },
                new RaceAbility { Id = 52, Name = Constants.HellishResistance, Description = "Gain the thaumaturgy cantrip and spells like hellish rebuke and darkness as you level up.", CharacterRaceId = 18 },

                //Tortle
                new RaceAbility { Id = 53, Name = Constants.ShellDefense, Description = "As an action, you can withdraw into your shell. While in your shell: Your AC increases by 4.You have advantage on Strength and Constitution saving throws.You are prone, your speed is 0, and you can't take reactions.The only actions you can take are a bonus action to emerge or actions that only affect yourself.", CharacterRaceId = 19 },
                new RaceAbility { Id = 54, Name = Constants.HoldBreath, Description = "You can hold your breath for up to 1 hour, making Tortles excellent at surviving underwater or in environments without air.", CharacterRaceId = 19 },
                new RaceAbility { Id = 55, Name = Constants.Claws, Description = "Your unarmed strikes deal 1d4 slashing damage, thanks to your sharp claws.", CharacterRaceId = 19 },

                //Yuan-ti Pureblood
                new RaceAbility { Id = 56, Name = Constants.DarkVision, Description = "See in dim light within 60 ft. as if it were bright light, and in darkness as if it were dim light.", CharacterRaceId = 20 },
                new RaceAbility { Id = 57, Name = Constants.MagicResistance, Description = "Advantage on saving throws against spells and magical effects.", CharacterRaceId = 20 },
                new RaceAbility { Id = 58, Name = Constants.PoisonImmunity, Description = "Immune to poison damage and the poisoned condition.", CharacterRaceId = 20 }
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
    }
}
