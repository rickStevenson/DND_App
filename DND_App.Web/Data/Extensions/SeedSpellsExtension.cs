using DND_App.Web.Models.Domain;
using Microsoft.EntityFrameworkCore;
using Constants = DND_App.Web.StaticClasses.Constants;

namespace DND_App.Web.Data.Extensions
{
    public static class SeedSpellsExtension
    {
        public static void SeedSpells(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Spell>().HasData(
                new Spell
                {
                    Id = 1,
                    Name = Constants.CureWounds,
                    Level = 1,
                    School = Constants.Evocation,
                    CastingTime = Constants._1Action,
                    SpellRange = Constants.Touch,
                    Duration = Constants.Instant,
                    RequiresConcentration = false,
                    Description = "A creature you touch regains hit points equal to 1d8 + your spellcasting modifier."
                },
                new Spell
                {
                    Id = 2,
                    Name = Constants.Shield,
                    Level = 1,
                    School = Constants.Abjuration,
                    CastingTime = Constants._1Reaction,
                    SpellRange = Constants.Self,
                    Duration = Constants._1Round,
                    RequiresConcentration = false,
                    Description = "You gain +5 to AC until the start of your next turn."
                },
                new Spell
                {
                    Id = 3,
                    Name = Constants.MagicMissle,
                    Level = 1,
                    School = Constants.Evocation,
                    CastingTime = Constants._1Action,
                    SpellRange = Constants._120feet,
                    Duration = Constants.Instant,
                    RequiresConcentration = false,
                    Description = "Create three glowing darts of force, each dealing 1d4+1 damage to a target."
                },
                new Spell
                {
                    Id = 4,
                    Name = Constants.DetectMagic,
                    Level = 1,
                    School = Constants.Divination,
                    CastingTime = Constants._1Action,
                    SpellRange = Constants._30feet,
                    Duration = Constants._10minutes,
                    RequiresConcentration = false,
                    Description = "Sense the presence of magic within 30 feet for up to 10 minutes."
                },
                new Spell
                {
                    Id = 5,
                    Name = Constants.Bless,
                    Level = 1,
                    School = Constants.Enchantment,
                    CastingTime = Constants._1Action,
                    SpellRange = Constants._30feet,
                    Duration = Constants._1Minute,
                    RequiresConcentration = false,
                    Description = "Up to three creatures gain +1d4 to attack rolls and saving throws for 1 minute."
                },
                new Spell
                {
                    Id = 6,
                    Name = Constants.MistyStep,
                    Level = 2,
                    School = Constants.Conjuration,
                    CastingTime = Constants.BonusAction,
                    SpellRange = Constants._30feet,
                    Duration = Constants.Instant,
                    RequiresConcentration = false,
                    Description = "Teleport up to 30 feet to an unoccupied space you can see."
                },
                new Spell
                {
                    Id = 7,
                    Name = Constants.Invisibility,
                    Level = 2,
                    School = Constants.Illusion,
                    CastingTime = Constants._1Action,
                    SpellRange = Constants.Touch,
                    Duration = Constants.Upto1Hour,
                    RequiresConcentration = false,
                    Description = "A creature you touch becomes invisible until they attack or cast a spell."
                },
                new Spell
                {
                    Id = 8,
                    Name = Constants.HoldPerson,
                    Level = 2,
                    School = Constants.Enchantment,
                    CastingTime = Constants._1Action,
                    SpellRange = Constants._60feet,
                    Duration = Constants.Upto1Minute,
                    RequiresConcentration = false,
                    Description = "Paralyze a humanoid target for 1 minute, with repeated saves to escape."
                },
                new Spell
                {
                    Id = 9,
                    Name = Constants.ScorchingRay,
                    Level = 2,
                    School = Constants.Evocation,
                    CastingTime = Constants._1Action,
                    SpellRange = Constants._120feet,
                    Duration = Constants.Instant,
                    RequiresConcentration = false,
                    Description = "Fire three rays of fire, each dealing 2d6 fire damage on a hit."
                },
                new Spell
                {
                    Id = 10,
                    Name = Constants.EnhanceAbility,
                    Level = 2,
                    School = Constants.Transmutation,
                    CastingTime = Constants._1Action,
                    SpellRange = Constants.Touch,
                    Duration = Constants._1Hour,
                    RequiresConcentration = false,
                    Description = "Grant advantage on ability checks or other bonuses to the target."
                }
            );
        }  
    }
}
