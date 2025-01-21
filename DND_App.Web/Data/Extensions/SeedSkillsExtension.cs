using DND_App.Web.Models.Domain;
using Microsoft.EntityFrameworkCore;
using Constants = DND_App.Web.StaticClasses.Constants;

namespace DND_App.Web.Data.Extensions
{
    public static class SeedSkillsExtension
    {
        public static void SeedSkills(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Skill>().HasData(
               new Skill
               {
                   Id = 1,
                   Name = Constants.Skills.Athletics,
                   Description = "Covers climbing, jumping, and swimming.",
                   AlignedAttribute = Constants.Attributes.Strength
               },
               new Skill
               {
                   Id = 2,
                   Name = Constants.Skills.Acrobatics,
                   Description = "Covers balancing, tumbling, and avoiding falls.",
                   AlignedAttribute = Constants.Attributes.Dexterity
               },
               new Skill
               {
                   Id = 3,
                   Name = Constants.Skills.SleightOfHand,
                   Description = "Covers manual trickery like pickpocketing.",
                   AlignedAttribute = Constants.Attributes.Dexterity
               },
               new Skill
               {
                   Id = 4,
                   Name = Constants.Skills.Stealth,
                   Description = "Covers hiding and moving silently.",
                   AlignedAttribute = Constants.Attributes.Dexterity
               },
                new Skill
                {
                    Id = 5,
                    Name = Constants.Skills.Arcana,
                    Description = "Covers knowledge of magic, spells, and artifacts.",
                    AlignedAttribute = Constants.Attributes.Intelligence
                },
                new Skill
                {
                    Id = 6,
                    Name = Constants.Skills.History,
                    Description = "Covers knowledge of historical events and lore.",
                    AlignedAttribute = Constants.Attributes.Intelligence
                },
                new Skill
                {
                    Id = 7,
                    Name = Constants.Skills.Investigation,
                    Description = "Covers finding clues and solving mysteries.",
                    AlignedAttribute = Constants.Attributes.Intelligence
                },
                new Skill
                {
                    Id = 8,
                    Name = Constants.Skills.Nature,
                    Description = "Covers knowledge of plants, animals, and natural phenomena.",
                    AlignedAttribute = Constants.Attributes.Intelligence
                },
                new Skill
                {
                    Id = 9,
                    Name = Constants.Skills.Religion,
                    Description = "Covers knowledge of deities, rites, and holy symbols.",
                    AlignedAttribute = Constants.Attributes.Intelligence
                },
                new Skill
                {
                    Id = 10,
                    Name = Constants.Skills.AnimalHandling,
                    Description = "Covers calming, controlling, and training animals.",
                    AlignedAttribute = Constants.Attributes.Wisdom
                },
                new Skill
                {
                    Id = 11,
                    Name = Constants.Skills.Insight,
                    Description = "Covers reading body language and intentions.",
                    AlignedAttribute = Constants.Attributes.Wisdom
                },
                new Skill
                {
                    Id = 12,
                    Name = Constants.Skills.Medicine,
                    Description = "Covers stabilizing creatures and diagnosing ailments.",
                    AlignedAttribute = Constants.Attributes.Wisdom
                },
                new Skill
                {
                    Id = 13,
                    Name = Constants.Skills.Perception,
                    Description = "Covers noticing details and detecting hidden creatures or objects.",
                    AlignedAttribute = Constants.Attributes.Wisdom
                },
                new Skill
                {
                    Id = 14,
                    Name = Constants.Skills.Survival,
                    Description = "Covers tracking, foraging, and surviving in the wild.",
                    AlignedAttribute = Constants.Attributes.Wisdom
                },
                new Skill
                {
                    Id = 15,
                    Name = Constants.Skills.Deception,
                    Description = "Covers convincing others of falsehoods.",
                    AlignedAttribute = Constants.Attributes.Charisma
                },
                new Skill
                {
                    Id = 16,
                    Name = Constants.Skills.Intimidation,
                    Description = "Covers coercing others through threats or force.",
                    AlignedAttribute = Constants.Attributes.Charisma
                },
                new Skill
                {
                    Id = 17,
                    Name = Constants.Skills.Performance,
                    Description = "Covers entertaining others through music, dance, or acting.",
                    AlignedAttribute = Constants.Attributes.Charisma
                },
                new Skill
                {
                    Id = 18,
                    Name = Constants.Skills.Persuasion,
                    Description = "Covers influencing others with tact and social grace.",
                    AlignedAttribute = Constants.Attributes.Charisma
                }
            );
        }
    }
}
