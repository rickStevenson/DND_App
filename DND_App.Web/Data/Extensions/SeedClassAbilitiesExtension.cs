using DND_App.Web.Models.Domain;
using Microsoft.EntityFrameworkCore;
using Constants = DND_App.Web.StaticClasses.Constants;

namespace DND_App.Web.Data.Extensions
{
    public static class SeedClassAbilitiesExtension
    {
        public static void SeedClassAbilities(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ClassAbility>().HasData(
                            //Barbarian
                            new ClassAbility { Id = 1, Name = Constants.ClassAbilities.Rage, Description = "Enter a frenzied state to gain bonus damage, resist physical damage, and advantage on Strength checks/saving throws.", CharacterClassId = 1 },
                            new ClassAbility { Id = 2, Name = Constants.ClassAbilities.UnarmoredDefence, Description = "Add Constitution modifier to AC when not wearing armor.", CharacterClassId = 1 },
                            new ClassAbility { Id = 3, Name = Constants.ClassAbilities.RecklessAttack, Description = "Gain advantage on melee attack rolls, but attacks against you also have advantage.", CharacterClassId = 1 },
                            new ClassAbility { Id = 4, Name = Constants.ClassAbilities.DangerSense, Description = "Gain advantage on Dexterity saving throws against effects you can see.", CharacterClassId = 1 },

                            //Bard
                            new ClassAbility
                            {
                                Id = 5,
                                Name = Constants.ClassAbilities.BardicInspiration,
                                Description = "Inspire allies with a bonus to ability checks, attack rolls, or saving throws.",
                                CharacterClassId = 2
                            },
                            new ClassAbility { Id = 6, Name = Constants.ClassAbilities.SongOfRest, Description = "Help allies recover additional hit points during short rests.", CharacterClassId = 2 },
                            new ClassAbility { Id = 7, Name = Constants.ClassAbilities.BardicMagic, Description = "Use a wide variety of spells to charm, inspire, and deal damage.", CharacterClassId = 2 },
                            new ClassAbility { Id = 8, Name = Constants.ClassAbilities.JackOfAllTrades, Description = "Add half proficiency bonus to all ability checks you’re not proficient in.", CharacterClassId = 2 },

                            //Cleric
                            new ClassAbility { Id = 9, Name = Constants.ClassAbilities.TurnUndead, Description = "Turn undead or perform a special ability depending on your domain.", CharacterClassId = 3 },
                            new ClassAbility { Id = 10, Name = Constants.ClassAbilities.DivineIntervention, Description = "Divine spells drawn from your deity’s domain.", CharacterClassId = 3 },
                            new ClassAbility { Id = 11, Name = Constants.ClassAbilities.DivineDomain, Description = "Gain unique abilities based on the chosen divine domain, such as Life, Light, or War.", CharacterClassId = 3 },

                            //Druid
                            new ClassAbility { Id = 12, Name = Constants.ClassAbilities.WildShape, Description = "Transform into beasts you’ve seen, gaining their physical traits.", CharacterClassId = 4 },
                            new ClassAbility { Id = 13, Name = Constants.ClassAbilities.DruidicCircle, Description = "Choose a focus for your abilities, such as the Circle of the Land (nature magic) or the Circle of the Moon (enhanced Wild Shape).", CharacterClassId = 4 },
                            new ClassAbility { Id = 14, Name = Constants.ClassAbilities.SpellsOfNature, Description = "Use nature-themed spells to control the environment and heal.", CharacterClassId = 4 },

                            //Fighter
                            new ClassAbility { Id = 15, Name = Constants.ClassAbilities.SecondWind, Description = "Recover some hit points as a bonus action.", CharacterClassId = 5 },
                            new ClassAbility { Id = 16, Name = Constants.ClassAbilities.ActionSurge, Description = "Take an additional action on your turn.", CharacterClassId = 5 },
                            new ClassAbility { Id = 17, Name = Constants.ClassAbilities.FightingStyle, Description = "Choose a specialization like Archery or Defense.", CharacterClassId = 5 },
                            new ClassAbility { Id = 18, Name = Constants.ClassAbilities.MartialArchetype, Description = "Gain unique features such as magic use (Eldritch Knight) or commanding allies (Battle Master).", CharacterClassId = 5 },

                            //Monk
                            new ClassAbility { Id = 19, Name = Constants.ClassAbilities.MartialArts, Description = "Use Dexterity instead of Strength for unarmed strikes and monk weapons.", CharacterClassId = 6 },
                            new ClassAbility { Id = 20, Name = Constants.ClassAbilities.KiPoints, Description = "Perform extraordinary abilities like flurries of blows, increased speed, or stunning strikes.", CharacterClassId = 6 },
                            new ClassAbility { Id = 21, Name = Constants.ClassAbilities.UnarmoredDefense, Description = "Add Wisdom modifier to AC when not wearing armor.", CharacterClassId = 6 },
                            new ClassAbility { Id = 22, Name = Constants.ClassAbilities.DeflectMissles, Description = "Reduce damage from ranged weapon attacks.", CharacterClassId = 6 },

                            //Paladin
                            new ClassAbility { Id = 23, Name = Constants.ClassAbilities.LayOnHands, Description = "Heal yourself or others by expending points from a healing pool.", CharacterClassId = 7 },
                            new ClassAbility { Id = 24, Name = Constants.ClassAbilities.DivineSmite, Description = " Use spell slots to deal radiant damage on weapon attacks.", CharacterClassId = 7 },
                            new ClassAbility { Id = 25, Name = Constants.ClassAbilities.AuraOfProtection, Description = "Add Charisma modifier to saving throws for you and nearby allies.", CharacterClassId = 7 },
                            new ClassAbility { Id = 26, Name = Constants.ClassAbilities.SacredOath, Description = "Swear an oath like Devotion, Vengeance, or Ancients for unique abilities.", CharacterClassId = 7 },

                            //Ranger
                            new ClassAbility { Id = 27, Name = Constants.ClassAbilities.FavoredEnemy, Description = "Gain bonuses to tracking and dealing with a specific type of creature.", CharacterClassId = 8 },
                            new ClassAbility { Id = 28, Name = Constants.ClassAbilities.NaturalExplorer, Description = "Gain benefits while traveling through chosen types of terrain.", CharacterClassId = 8 },
                            new ClassAbility { Id = 29, Name = Constants.ClassAbilities.RangerMagic, Description = "Use nature magic to aid exploration and combat.", CharacterClassId = 8 },
                            new ClassAbility { Id = 30, Name = Constants.ClassAbilities.HuntersMark, Description = "Mark a target to deal extra damage and track it.", CharacterClassId = 8 },

                            //Rogue
                            new ClassAbility { Id = 31, Name = Constants.ClassAbilities.SneakAttack, Description = "Deal extra damage when you hit with an attack and have advantage or an ally nearby.", CharacterClassId = 9 },
                            new ClassAbility { Id = 32, Name = Constants.ClassAbilities.CunningAction, Description = "Use a bonus action to Dash, Disengage, or Hide.", CharacterClassId = 9 },
                            new ClassAbility { Id = 33, Name = Constants.ClassAbilities.UncannyDodge, Description = "Halve damage from one attack per round.", CharacterClassId = 9 },
                            new ClassAbility { Id = 34, Name = Constants.ClassAbilities.Evasion, Description = "Avoid all damage on successful Dexterity saves against area effects.", CharacterClassId = 9 },

                            //Sorcerer
                            new ClassAbility { Id = 35, Name = Constants.ClassAbilities.Metamagic, Description = "Enhance spells by extending their range, duration, or allowing multiple targets.", CharacterClassId = 10 },
                            new ClassAbility { Id = 36, Name = Constants.ClassAbilities.WildMagic, Description = " Gain features based on your origin, such as elemental resistance or chaotic magical effects.", CharacterClassId = 10 },
                            new ClassAbility { Id = 37, Name = Constants.ClassAbilities.Sorcery, Description = "Use innate magical power to cast spells.", CharacterClassId = 10 },
                            new ClassAbility { Id = 38, Name = Constants.ClassAbilities.SorceryPoints, Description = "Fuel unique abilities, such as Metamagic (modifying spells in unique ways).", CharacterClassId = 10 },

                            //Worlock
                            new ClassAbility { Id = 39, Name = Constants.ClassAbilities.PactMagic, Description = "Use limited spell slots that recharge on short rests.", CharacterClassId = 11 },
                            new ClassAbility { Id = 40, Name = Constants.ClassAbilities.EldritchInvocations, Description = "Gain specialized magical abilities, such as improved Eldritch Blast.", CharacterClassId = 11 },
                            new ClassAbility { Id = 41, Name = Constants.ClassAbilities.PactBoon, Description = " Choose a boon like a familiar (Pact of the Chain), a weapon (Pact of the Blade), or a magical book (Pact of the Tome).", CharacterClassId = 11 },
                            new ClassAbility { Id = 42, Name = Constants.ClassAbilities.PatronFeatures, Description = "Gain abilities from a pact with an otherworldly entity like the Archfey, Fiend, or Great Old One.", CharacterClassId = 11 },

                            //Wizard
                            new ClassAbility { Id = 43, Name = Constants.ClassAbilities.ArcaneRecovery, Description = "Regain spell slots during a short rest.", CharacterClassId = 12 },
                            new ClassAbility { Id = 44, Name = Constants.ClassAbilities.SpellMastery, Description = "Access the largest variety of spells in the game.", CharacterClassId = 12 },
                            new ClassAbility { Id = 45, Name = Constants.ClassAbilities.ArcaneTradition, Description = "Choose a school of magic specialization, such as Evocation (damage spells) or Divination (seeing the future).", CharacterClassId = 12 },
                            new ClassAbility { Id = 46, Name = Constants.ClassAbilities.RitualCasting, Description = "Cast certain spells without expending a spell slot.", CharacterClassId = 12 }


                        );
        }
    }
}
