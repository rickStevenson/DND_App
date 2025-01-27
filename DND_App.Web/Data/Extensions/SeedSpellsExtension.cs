using DND_App.Web.Models.Domain;
using Microsoft.EntityFrameworkCore;
using DND_App.Web.StaticClasses.Constants;

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
                    Name = SpellCasting.CureWounds,
                    Level = 1,
                    School = SpellCasting.Evocation,
                    CastingTime = SpellCasting._1Action,
                    SpellRange = SpellCasting.Touch,
                    Duration = SpellCasting.Instant,
                    RequiresConcentration = false,
                    Description = "A creature you touch regains hit points equal to 1d8 + your spellcasting modifier."
                },
                new Spell
                {
                    Id = 2,
                    Name = SpellCasting.Shield,
                    Level = 1,
                    School = SpellCasting.Abjuration,
                    CastingTime = SpellCasting._1Reaction,
                    SpellRange = SpellCasting.Self,
                    Duration = SpellCasting._1Round,
                    RequiresConcentration = false,
                    Description = "You gain +5 to AC until the start of your next turn."
                },
                new Spell
                {
                    Id = 3,
                    Name = SpellCasting.MagicMissle,
                    Level = 1,
                    School = SpellCasting.Evocation,
                    CastingTime = SpellCasting._1Action,
                    SpellRange = SpellCasting._120feet,
                    Duration = SpellCasting.Instant,
                    RequiresConcentration = false,
                    Description = "Create three glowing darts of force, each dealing 1d4+1 damage to a target."
                },
                new Spell
                {
                    Id = 4,
                    Name = SpellCasting.DetectMagic,
                    Level = 1,
                    School = SpellCasting.Divination,
                    CastingTime = SpellCasting._1Action,
                    SpellRange = SpellCasting._30feet,
                    Duration = SpellCasting._10minutes,
                    RequiresConcentration = false,
                    Description = "Sense the presence of magic within 30 feet for up to 10 minutes."
                },
                new Spell
                {
                    Id = 5,
                    Name = SpellCasting.Bless,
                    Level = 1,
                    School = SpellCasting.Enchantment,
                    CastingTime = SpellCasting._1Action,
                    SpellRange = SpellCasting._30feet,
                    Duration = SpellCasting._1Minute,
                    RequiresConcentration = false,
                    Description = "Up to three creatures gain +1d4 to attack rolls and saving throws for 1 minute."
                },
                new Spell
                {
                    Id = 6,
                    Name = SpellCasting.MistyStep,
                    Level = 2,
                    School = SpellCasting.Conjuration,
                    CastingTime = SpellCasting.BonusAction,
                    SpellRange = SpellCasting._30feet,
                    Duration = SpellCasting.Instant,
                    RequiresConcentration = false,
                    Description = "Teleport up to 30 feet to an unoccupied space you can see."
                },
                new Spell
                {
                    Id = 7,
                    Name = SpellCasting.Invisibility,
                    Level = 2,
                    School = SpellCasting.Illusion,
                    CastingTime = SpellCasting._1Action,
                    SpellRange = SpellCasting.Touch,
                    Duration = SpellCasting.Upto1Hour,
                    RequiresConcentration = false,
                    Description = "A creature you touch becomes invisible until they attack or cast a spell."
                },
                new Spell
                {
                    Id = 8,
                    Name = SpellCasting.HoldPerson,
                    Level = 2,
                    School = SpellCasting.Enchantment,
                    CastingTime = SpellCasting._1Action,
                    SpellRange = SpellCasting._60feet,
                    Duration = SpellCasting.Upto1Minute,
                    RequiresConcentration = false,
                    Description = "Paralyze a humanoid target for 1 minute, with repeated saves to escape."
                },
                new Spell
                {
                    Id = 9,
                    Name = SpellCasting.ScorchingRay,
                    Level = 2,
                    School = SpellCasting.Evocation,
                    CastingTime = SpellCasting._1Action,
                    SpellRange = SpellCasting._120feet,
                    Duration = SpellCasting.Instant,
                    RequiresConcentration = false,
                    Description = "Fire three rays of fire, each dealing 2d6 fire damage on a hit."
                },
                new Spell
                {
                    Id = 10,
                    Name = SpellCasting.EnhanceAbility,
                    Level = 2,
                    School = SpellCasting.Transmutation,
                    CastingTime = SpellCasting._1Action,
                    SpellRange = SpellCasting.Touch,
                    Duration = SpellCasting._1Hour,
                    RequiresConcentration = false,
                    Description = "Grant advantage on ability checks or other bonuses to the target."
                }
            );
        }  
    }
}
