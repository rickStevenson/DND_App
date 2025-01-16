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
                   Name = Constants.Athletics,
                   Description = "Covers climbing, jumping, and swimming.",
                   AlignedAttribute = Constants.Strength
               },
               new Skill
               {
                   Id = 2,
                   Name = Constants.Acrobatics,
                   Description = "Covers balancing, tumbling, and avoiding falls.",
                   AlignedAttribute = Constants.Dexterity
               },
               new Skill
               {
                   Id = 3,
                   Name = Constants.SleightOfHand,
                   Description = "Covers manual trickery like pickpocketing.",
                   AlignedAttribute = Constants.Dexterity
               },
               new Skill
               {
                   Id = 4,
                   Name = Constants.Stealth,
                   Description = "Covers hiding and moving silently.",
                   AlignedAttribute = Constants.Dexterity
               },
                new Skill
                {
                    Id = 5,
                    Name = Constants.Arcana,
                    Description = "Covers knowledge of magic, spells, and artifacts.",
                    AlignedAttribute = Constants.Intelligence
                },
                new Skill
                {
                    Id = 6,
                    Name = Constants.History,
                    Description = "Covers knowledge of historical events and lore.",
                    AlignedAttribute = Constants.Intelligence
                },
                new Skill
                {
                    Id = 7,
                    Name = Constants.Investigation,
                    Description = "Covers finding clues and solving mysteries.",
                    AlignedAttribute = Constants.Intelligence
                },
                new Skill
                {
                    Id = 8,
                    Name = Constants.Nature,
                    Description = "Covers knowledge of plants, animals, and natural phenomena.",
                    AlignedAttribute = Constants.Intelligence
                },
                new Skill
                {
                    Id = 9,
                    Name = Constants.Religion,
                    Description = "Covers knowledge of deities, rites, and holy symbols.",
                    AlignedAttribute = Constants.Intelligence
                },
                new Skill
                {
                    Id = 10,
                    Name = Constants.AnimalHandling,
                    Description = "Covers calming, controlling, and training animals.",
                    AlignedAttribute = Constants.Wisdom
                },
                new Skill
                {
                    Id = 11,
                    Name = Constants.Insight,
                    Description = "Covers reading body language and intentions.",
                    AlignedAttribute = Constants.Wisdom
                },
                new Skill
                {
                    Id = 12,
                    Name = Constants.Medicine,
                    Description = "Covers stabilizing creatures and diagnosing ailments.",
                    AlignedAttribute = Constants.Wisdom
                },
                new Skill
                {
                    Id = 13,
                    Name = Constants.Perception,
                    Description = "Covers noticing details and detecting hidden creatures or objects.",
                    AlignedAttribute = Constants.Wisdom
                },
                new Skill
                {
                    Id = 14,
                    Name = Constants.Survival,
                    Description = "Covers tracking, foraging, and surviving in the wild.",
                    AlignedAttribute = Constants.Wisdom
                },
                new Skill
                {
                    Id = 15,
                    Name = Constants.Deception,
                    Description = "Covers convincing others of falsehoods.",
                    AlignedAttribute = Constants.Charisma
                },
                new Skill
                {
                    Id = 16,
                    Name = Constants.Intimidation,
                    Description = "Covers coercing others through threats or force.",
                    AlignedAttribute = Constants.Charisma
                },
                new Skill
                {
                    Id = 17,
                    Name = Constants.Performance,
                    Description = "Covers entertaining others through music, dance, or acting.",
                    AlignedAttribute = Constants.Charisma
                },
                new Skill
                {
                    Id = 18,
                    Name = Constants.Persuasion,
                    Description = "Covers influencing others with tact and social grace.",
                    AlignedAttribute = Constants.Charisma
                }
            );
        }
    }
}
