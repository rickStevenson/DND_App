using DND_App.Web.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace DND_App.Web.Data.Extensions
{
    public static class RelationshipConfigurationExtension
    {
        public static void ConfigureRelationships(this ModelBuilder modelBuilder)
        {
           
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



            // Configure the many-to-many skill relationship
            modelBuilder.Entity<CharacterSkill>()
                .HasKey(cs => new { cs.CharacterId, cs.SkillId }); // Composite Primary Key

            modelBuilder.Entity<CharacterSkill>()
                .HasOne(cs => cs.Character)
                .WithMany(c => c.CharacterSkills)
                .HasForeignKey(cs => cs.CharacterId);

            modelBuilder.Entity<CharacterSkill>()
                .HasOne(cs => cs.Skill)
                .WithMany()
                .HasForeignKey(cs => cs.SkillId);


            // CharacterSpell many-to-many relationship configuration
            modelBuilder.Entity<CharacterSpell>()
                .HasKey(cs => new { cs.CharacterId, cs.SpellId });

            modelBuilder.Entity<CharacterSpell>()
                .HasOne(cs => cs.Character)
                .WithMany(c => c.CharacterSpells)
                .HasForeignKey(cs => cs.CharacterId);

            modelBuilder.Entity<CharacterSpell>()
                .HasOne(cs => cs.Spell)
                .WithMany()
                .HasForeignKey(cs => cs.SpellId);
        }
    }
}
