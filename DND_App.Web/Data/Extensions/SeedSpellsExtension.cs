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
                    Name = Constants.SpellCasting.CureWounds,
                    Level = 1,
                    School = Constants.SpellCasting.Evocation,
                    CastingTime = Constants.SpellCasting._1Action,
                    SpellRange = Constants.SpellCasting.Touch,
                    Duration = Constants.SpellCasting.Instant,
                    RequiresConcentration = false,
                    Description = "A creature you touch regains hit points equal to 1d8 + your spellcasting modifier."
                },
                new Spell
                {
                    Id = 2,
                    Name = Constants.SpellCasting.Shield,
                    Level = 1,
                    School = Constants.SpellCasting.Abjuration,
                    CastingTime = Constants.SpellCasting._1Reaction,
                    SpellRange = Constants.SpellCasting.Self,
                    Duration = Constants.SpellCasting._1Round,
                    RequiresConcentration = false,
                    Description = "You gain +5 to AC until the start of your next turn."
                },
                new Spell
                {
                    Id = 3,
                    Name = Constants.SpellCasting.MagicMissle,
                    Level = 1,
                    School = Constants.SpellCasting.Evocation,
                    CastingTime = Constants.SpellCasting._1Action,
                    SpellRange = Constants.SpellCasting._120feet,
                    Duration = Constants.SpellCasting.Instant,
                    RequiresConcentration = false,
                    Description = "Create three glowing darts of force, each dealing 1d4+1 damage to a target."
                },
                new Spell
                {
                    Id = 4,
                    Name = Constants.SpellCasting.DetectMagic,
                    Level = 1,
                    School = Constants.SpellCasting.Divination,
                    CastingTime = Constants.SpellCasting._1Action,
                    SpellRange = Constants.SpellCasting._30feet,
                    Duration = Constants.SpellCasting._10minutes,
                    RequiresConcentration = false,
                    Description = "Sense the presence of magic within 30 feet for up to 10 minutes."
                },
                new Spell
                {
                    Id = 5,
                    Name = Constants.SpellCasting.Bless,
                    Level = 1,
                    School = Constants.SpellCasting.Enchantment,
                    CastingTime = Constants.SpellCasting._1Action,
                    SpellRange = Constants.SpellCasting._30feet,
                    Duration = Constants.SpellCasting._1Minute,
                    RequiresConcentration = false,
                    Description = "Up to three creatures gain +1d4 to attack rolls and saving throws for 1 minute."
                },
                new Spell
                {
                    Id = 6,
                    Name = Constants.SpellCasting.MistyStep,
                    Level = 2,
                    School = Constants.SpellCasting.Conjuration,
                    CastingTime = Constants.SpellCasting.BonusAction,
                    SpellRange = Constants.SpellCasting._30feet,
                    Duration = Constants.SpellCasting.Instant,
                    RequiresConcentration = false,
                    Description = "Teleport up to 30 feet to an unoccupied space you can see."
                },
                new Spell
                {
                    Id = 7,
                    Name = Constants.SpellCasting.Invisibility,
                    Level = 2,
                    School = Constants.SpellCasting.Illusion,
                    CastingTime = Constants.SpellCasting._1Action,
                    SpellRange = Constants.SpellCasting.Touch,
                    Duration = Constants.SpellCasting.Upto1Hour,
                    RequiresConcentration = false,
                    Description = "A creature you touch becomes invisible until they attack or cast a spell."
                },
                new Spell
                {
                    Id = 8,
                    Name = Constants.SpellCasting.HoldPerson,
                    Level = 2,
                    School = Constants.SpellCasting.Enchantment,
                    CastingTime = Constants.SpellCasting._1Action,
                    SpellRange = Constants.SpellCasting._60feet,
                    Duration = Constants.SpellCasting.Upto1Minute,
                    RequiresConcentration = false,
                    Description = "Paralyze a humanoid target for 1 minute, with repeated saves to escape."
                },
                new Spell
                {
                    Id = 9,
                    Name = Constants.SpellCasting.ScorchingRay,
                    Level = 2,
                    School = Constants.SpellCasting.Evocation,
                    CastingTime = Constants.SpellCasting._1Action,
                    SpellRange = Constants.SpellCasting._120feet,
                    Duration = Constants.SpellCasting.Instant,
                    RequiresConcentration = false,
                    Description = "Fire three rays of fire, each dealing 2d6 fire damage on a hit."
                },
                new Spell
                {
                    Id = 10,
                    Name = Constants.SpellCasting.EnhanceAbility,
                    Level = 2,
                    School = Constants.SpellCasting.Transmutation,
                    CastingTime = Constants.SpellCasting._1Action,
                    SpellRange = Constants.SpellCasting.Touch,
                    Duration = Constants.SpellCasting._1Hour,
                    RequiresConcentration = false,
                    Description = "Grant advantage on ability checks or other bonuses to the target."
                }
            );
        }  
    }
}
