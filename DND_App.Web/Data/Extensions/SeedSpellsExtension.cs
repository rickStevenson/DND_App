using DND_App.Web.Models.Domain;
using Microsoft.EntityFrameworkCore;
using DND_App.Web.StaticClasses.Constants;
using DND_App.Web.StaticClasses;

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
                    Name = SpellCastingExtension.GetDisplayName(SpellCastings.CureWounds),
                    Level = 1,
                    School = SpellCastingExtension.GetDisplayName(SpellCastings.Evocation),
                    CastingTime = SpellCastingExtension.GetDisplayName(SpellCastings._1Action),
                    SpellRange = SpellCastingExtension.GetDisplayName(SpellCastings.Touch),
                    Duration = SpellCastingExtension.GetDisplayName(SpellCastings.Instant),
                    RequiresConcentration = false,
                    Description = "A creature you touch regains hit points equal to 1d8 + your spellcasting modifier."
                },
                new Spell
                {
                    Id = 2,
                    Name = SpellCastingExtension.GetDisplayName(SpellCastings.Shield),
                    Level = 1,
                    School = SpellCastingExtension.GetDisplayName(SpellCastings.Abjuration),
                    CastingTime = SpellCastingExtension.GetDisplayName(SpellCastings._1Reaction),
                    SpellRange = SpellCastingExtension.GetDisplayName(SpellCastings.Self),
                    Duration = SpellCastingExtension.GetDisplayName(SpellCastings._1Round),
                    RequiresConcentration = false,
                    Description = "You gain +5 to AC until the start of your next turn."
                },
                new Spell
                {
                    Id = 3,
                    Name = SpellCastingExtension.GetDisplayName(SpellCastings.MagicMissle),
                    Level = 1,
                    School = SpellCastingExtension.GetDisplayName(SpellCastings.Evocation),
                    CastingTime = SpellCastingExtension.GetDisplayName(SpellCastings._1Action),
                    SpellRange = SpellCastingExtension.GetDisplayName(SpellCastings._120feet),
                    Duration = SpellCastingExtension.GetDisplayName(SpellCastings.Instant),
                    RequiresConcentration = false,
                    Description = "Create three glowing darts of force, each dealing 1d4+1 damage to a target."
                },
                new Spell
                {
                    Id = 4,
                    Name = SpellCastingExtension.GetDisplayName(SpellCastings.DetectMagic),
                    Level = 1,
                    School = SpellCastingExtension.GetDisplayName(SpellCastings.Divination),
                    CastingTime = SpellCastingExtension.GetDisplayName(SpellCastings._1Action),
                    SpellRange = SpellCastingExtension.GetDisplayName(SpellCastings._30feet),
                    Duration = SpellCastingExtension.GetDisplayName(SpellCastings._10minutes),
                    RequiresConcentration = false,
                    Description = "Sense the presence of magic within 30 feet for up to 10 minutes."
                },
                new Spell
                {
                    Id = 5,
                    Name = SpellCastingExtension.GetDisplayName(SpellCastings.Bless),
                    Level = 1,
                    School = SpellCastingExtension.GetDisplayName(SpellCastings.Enchantment),
                    CastingTime = SpellCastingExtension.GetDisplayName(SpellCastings._1Action),
                    SpellRange = SpellCastingExtension.GetDisplayName(SpellCastings._30feet),
                    Duration = SpellCastingExtension.GetDisplayName(SpellCastings._1Minute),
                    RequiresConcentration = false,
                    Description = "Up to three creatures gain +1d4 to attack rolls and saving throws for 1 minute."
                },
                new Spell
                {
                    Id = 6,
                    Name = SpellCastingExtension.GetDisplayName(SpellCastings.MistyStep),
                    Level = 2,
                    School = SpellCastingExtension.GetDisplayName(SpellCastings.Conjuration),
                    CastingTime = SpellCastingExtension.GetDisplayName(SpellCastings.BonusAction),
                    SpellRange = SpellCastingExtension.GetDisplayName(SpellCastings._30feet),
                    Duration = SpellCastingExtension.GetDisplayName(SpellCastings.Instant),
                    RequiresConcentration = false,
                    Description = "Teleport up to 30 feet to an unoccupied space you can see."
                },
                new Spell
                {
                    Id = 7,
                    Name = SpellCastingExtension.GetDisplayName(SpellCastings.Invisibility),
                    Level = 2,
                    School = SpellCastingExtension.GetDisplayName(SpellCastings.Illusion),
                    CastingTime = SpellCastingExtension.GetDisplayName(SpellCastings._1Action),
                    SpellRange = SpellCastingExtension.GetDisplayName(SpellCastings.Touch),
                    Duration = SpellCastingExtension.GetDisplayName(SpellCastings.Upto1Hour),
                    RequiresConcentration = false,
                    Description = "A creature you touch becomes invisible until they attack or cast a spell."
                },
                new Spell
                {
                    Id = 8,
                    Name = SpellCastingExtension.GetDisplayName(SpellCastings.HoldPerson),
                    Level = 2,
                    School = SpellCastingExtension.GetDisplayName(SpellCastings.Enchantment),
                    CastingTime = SpellCastingExtension.GetDisplayName(SpellCastings._1Action),
                    SpellRange = SpellCastingExtension.GetDisplayName(SpellCastings._60feet),
                    Duration = SpellCastingExtension.GetDisplayName(SpellCastings.Upto1Minute),
                    RequiresConcentration = false,
                    Description = "Paralyze a humanoid target for 1 minute, with repeated saves to escape."
                },
                new Spell
                {
                    Id = 9,
                    Name = SpellCastingExtension.GetDisplayName(SpellCastings.ScorchingRay),
                    Level = 2,
                    School = SpellCastingExtension.GetDisplayName(SpellCastings.Evocation),
                    CastingTime = SpellCastingExtension.GetDisplayName(SpellCastings._1Action),
                    SpellRange = SpellCastingExtension.GetDisplayName(SpellCastings._120feet),
                    Duration = SpellCastingExtension.GetDisplayName(SpellCastings.Instant),
                    RequiresConcentration = false,
                    Description = "Fire three rays of fire, each dealing 2d6 fire damage on a hit."
                },
                new Spell
                {
                    Id = 10,
                    Name = SpellCastingExtension.GetDisplayName(SpellCastings.EnhanceAbility),
                    Level = 2,
                    School = SpellCastingExtension.GetDisplayName(SpellCastings.Transmutation),
                    CastingTime = SpellCastingExtension.GetDisplayName(SpellCastings._1Action),
                    SpellRange = SpellCastingExtension.GetDisplayName(SpellCastings.Touch),
                    Duration = SpellCastingExtension.GetDisplayName(SpellCastings._1Hour),
                    RequiresConcentration = false,
                    Description = "Grant advantage on ability checks or other bonuses to the target."
                }
            );
        }  
    }
}
