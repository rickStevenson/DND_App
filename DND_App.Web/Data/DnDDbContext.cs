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
using DND_App.Web.Data.Extensions;

namespace DND_App.Web.Data
{
    public class DnDDbContext : DbContext
    {
        public DbSet<Character> Characters { get; set; }
        
        public DbSet<CharacterClass> CharacterClasses { get; set; }
        public DbSet<ClassAbility> ClassAbilities { get; set; }
        public DbSet<ClassSavingThrow> ClassSavingThrows { get; set; }
        public DbSet<CharacterRace> CharacterRaces { get; set; }

        public DbSet<Skill> Skills { get; set; }
        public DbSet<CharacterSkill> CharacterSkills { get; set; }
        public DbSet<Spell> Spells { get; set; }
        public DbSet<CharacterSpell> CharacterSpells { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<CharacterItem> CharacterItems { get; set; }
        public DbSet<Treasure> Treasures { get; set; }
        public DbSet<CharacterTreasure> CharacterTreasures { get; set; }


        public DnDDbContext(DbContextOptions<DnDDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigureRelationships();

            modelBuilder.SeedCharacterClasses();
            modelBuilder.SeedCharacterRaces();
            modelBuilder.SeedClassAbilities();
            modelBuilder.SeedClassSavingThrows();
            modelBuilder.SeedRaceAbilities();
            modelBuilder.SeedRaceToolProficiencies();
            modelBuilder.SeedRaceWeaponProficiencies();
            modelBuilder.SeedSpells();
            modelBuilder.SeedSkills();
            modelBuilder.SeedItems();
            modelBuilder.SeedTreasures();
        }
    }
}
