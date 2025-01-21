using DND_App.Web.Models.Domain;
using Microsoft.EntityFrameworkCore;
using Constants = DND_App.Web.StaticClasses.Constants;

namespace DND_App.Web.Data.Extensions
{
    public static class SeedCharacterClassesExtension
    {
        public static void SeedCharacterClasses(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CharacterClass>().HasData(
                 new CharacterClass
                 {
                     Id = 1,
                     Name = Constants.ClassNames.Barbarian,
                     HitDie = 12,
                     Description = "Barbarians are fierce warriors driven by primal instincts and raw rage. They thrive in the heat of battle, using their fury to fuel their strength and durability. Barbarians often hail from wild, untamed lands and have a deep connection to their ancestors or the forces of nature. Their unbridled rage makes them a force to be reckoned with on the battlefield, capable of shrugging off damage that would fell lesser warriors."
                 },
                 new CharacterClass
                 {
                     Id = 2,
                     Name = Constants.ClassNames.Bard,
                     HitDie = 8,
                     Description = "Bards are versatile spellcasters and performers who weave magic through music, storytelling, or art. They are masters of inspiration, using their talents to bolster allies, deceive enemies, and shape the flow of battle. Bards are naturally charismatic and adaptable, often serving as diplomats, spies, or leaders. Their broad skill set allows them to thrive in almost any situation."
                 },
                 new CharacterClass
                 {
                     Id = 3,
                     Name = Constants.ClassNames.Cleric,
                     HitDie = 8,
                     Description = "Clerics are divine spellcasters who draw their power from their connection to a deity or cosmic force. They serve as healers, protectors, and champions of their faith, often embodying the ideals of their chosen domain. Clerics can wield both divine magic and martial weapons, making them a versatile class capable of supporting allies or smiting foes."
                 },
                 new CharacterClass
                 {
                     Id = 4,
                     Name = Constants.ClassNames.Druid,
                     HitDie = 8,
                     Description = "Druids are mystical spellcasters who draw power from nature and the elements. They are guardians of the natural world, using their magic to protect the balance between civilization and wilderness. Druids can shapeshift into animals, summon the forces of nature, and wield elemental magic, making them highly adaptable."
                 },
                 new CharacterClass
                 {
                     Id = 5,
                     Name = Constants.ClassNames.Fighter,
                     HitDie = 10,
                     Description = "Fighters are masters of combat, trained in a wide variety of weapons and fighting techniques. They are highly versatile warriors who excel in physical confrontations, whether using brute strength, precise technique, or advanced tactics. Fighters can specialize in many styles, from sword-and-shield defense to dual-wielding offense or archery."
                 },
                 new CharacterClass
                 {
                     Id = 6,
                     Name = Constants.ClassNames.Monk,
                     HitDie = 8,
                     Description = "Monks are disciplined martial artists who channel their inner energy, or ki, to perform extraordinary feats. They are masters of unarmed combat and agility, moving with precision and speed to outmaneuver their enemies. Monks often hail from monasteries or other ascetic traditions, devoting their lives to physical and spiritual perfection."
                 },
                 new CharacterClass
                 {
                     Id = 7,
                     Name = Constants.ClassNames.Paladin,
                     HitDie = 10,
                     Description = "Paladins are holy warriors bound by a sacred oath to uphold justice, protect the innocent, and smite evil. They combine divine magic with martial prowess, serving as paragons of virtue or champions of their sworn cause. Their devotion grants them supernatural abilities to heal, protect allies, and punish foes with divine retribution."
                 },
                 new CharacterClass
                 {
                     Id = 8,
                     Name = Constants.ClassNames.Ranger,
                     HitDie = 10,
                     Description = "Rangers are expert trackers and hunters who thrive in the wilderness. They are adept at surviving in harsh environments and are skilled at hunting specific foes. Rangers use a combination of martial skill and nature magic to protect the wilds or navigate it as part of their adventuring lifestyle. They often form deep connections with nature, animals, or specific terrains."
                 },
                 new CharacterClass
                 {
                     Id = 9,
                     Name = Constants.ClassNames.Rogue,
                     HitDie = 8,
                     Description = "Rogues are cunning and resourceful characters who excel in stealth, agility, and precision. They are masters of subterfuge and deception, capable of striking where it hurts the most. Rogues thrive in a variety of roles, from infiltrators and assassins to treasure hunters and thieves. Their ability to deal devastating damage with sneak attacks makes them a formidable presence in combat."
                 },
                 new CharacterClass
                 {
                     Id = 10,
                     Name = Constants.ClassNames.Sorcerer,
                     HitDie = 6,
                     Description = "Sorcerers are innate spellcasters who wield magic drawn from a powerful bloodline or a mystical source within them. Unlike other spellcasters, sorcerers do not study or practice magic; instead, they manipulate raw magical energy through sheer willpower. Their mastery of metamagic allows them to shape spells in unique and devastating ways."
                 },
                 new CharacterClass
                 {
                     Id = 11,
                     Name = Constants.ClassNames.Warlock,
                     HitDie = 8,
                     Description = "Warlocks gain their power through pacts with mysterious patrons—powerful entities such as fiends, fey, or eldritch beings. Their bond with their patron grants them unique magical abilities and spells, often reflecting the nature of the pact. Warlocks are versatile and adaptable, wielding both potent spells and eldritch invocations to shape their magic in creative ways."
                 },
                 new CharacterClass
                 {
                     Id = 12,
                     Name = Constants.ClassNames.Wizard,
                     HitDie = 6,
                     Description = "Wizards are scholarly spellcasters who dedicate their lives to mastering the arcane. They study spellbooks to learn and prepare a vast array of spells, making them the most versatile magic-users. Wizards rely on their intelligence and preparation to control the battlefield, protect their allies, or destroy their enemies. Their mastery of magic is unparalleled in variety and depth."
                 }
             );
        }
    }
}
