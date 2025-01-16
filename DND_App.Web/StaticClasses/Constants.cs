using System;

namespace DND_App.Web.StaticClasses
{
    public class Constants
    {
        public const string None = "None";
        #region Character Attributes    
        public const string Strength = "Strength";
        public const string Dexterity = "Dexterity";
        public const string Constitution = "Constitution";
        public const string Intelligence = "Intelligence";
        public const string Wisdom = "Wisdom";
        public const string Charisma = "Charisma";
        #endregion
        #region Character Skills
        public const string Athletics = "Athletics";
        public const string Acrobatics = "Acrobatics";
        public const string SleightOfHand = "SleightOfHand";
        public const string Stealth = "Stealth";
        public const string Arcana = "Arcana";
        public const string History = "History";
        public const string Investigation = "Investigation";
        public const string Nature = "Nature";
        public const string Religion = "Religion";
        public const string AnimalHandling = "AnimalHandling";
        public const string Insight = "Insight";
        public const string Medicine = "Medicine";
        public const string Perception = "Perception";
        public const string Survival = "Survival";
        public const string Deception = "Deception";
        public const string Intimidation = "Intimidation";
        public const string Performance = "Performance";
        public const string Persuasion = "Persuasion";
        #endregion
        #region Class Abilities
        //Barbarian
        public const string Rage = "Rage";
        public const string UnarmoredDefence = "Unarmored Defense";
        public const string RecklessAttack = "Reckless Attack";
        public const string DangerSense = "Danger Sense";

        //Bard
        public const string BardicInspiration = "Bardic Inspiration";
        public const string SongOfRest = "Song of Rest";
        public const string BardicMagic = "Bardic Magic";
        public const string JackOfAllTrades = "Jack Of All Trades";

        //Cleric
        public const string TurnUndead = "Turn Undead";
        public const string DivineIntervention = "Divine Intervention";
        public const string DivineDomain = "DivineDomain";

        //Druid
        public const string WildShape = "Wild Shape";
        public const string DruidicCircle = "Druidic Circle";
        public const string SpellsOfNature = "Spells Of Nature";

        //Fighter
        public const string SecondWind = "Second Wind";
        public const string ActionSurge = "Action Surge";
        public const string FightingStyle = "Fighting Style";
        public const string MartialArchetype = "Martial Archtype";

        //Monk
        public const string MartialArts = "Martial Arts";
        public const string KiPoints = "Ki Points";
        public const string UnarmoredDefense = "Unarmored Defense";
        public const string DeflectMissles = "DeflectMissles";

        //Paladin
        public const string LayOnHands = "Lay on Hands";
        public const string DivineSmite = "Divine Smite";
        public const string AuraOfProtection = "Aura Of Protection";
        public const string SacredOath = "Sacred Oath";

        //Ranger
        public const string FavoredEnemy = "Favored Enemy";
        public const string NaturalExplorer = "Natural Explorer";
        public const string RangerMagic = "Ranger Magic";
        public const string HuntersMark = "Hunter's Mark";

        //Rogue
        public const string SneakAttack = "Sneak Attack";
        public const string CunningAction = "Cunning Action";
        public const string UncannyDodge = "UncannyDodge";
        public const string Evasion = "Evasion";

        //Sorcerer
        public const string Metamagic = "Metamagic";
        public const string WildMagic = "Wild Magic";
        public const string Sorcery = "Sorcery";
        public const string SorceryPoints = "SorceryPoints";


        //Warlock
        public const string PactMagic = "Pact Magic";
        public const string EldritchInvocations = "Eldritch Invocations";
        public const string PactBoon = "Pact Boon";
        public const string PatronFeatures = "Patron Features";

        //Wizard 
        public const string ArcaneRecovery = "Arcane Recovery";
        public const string SpellMastery = "Spell Mastery";
        public const string ArcaneTradition = "Arcane Tradition";
        public const string RitualCasting = "Ritual Casting";
        #endregion
        #region Race Abilities
        //Aasimar 1
        public const string CelestialResitance = "Celestial Resitance";
        public const string HealingHands = "Healing Hands";
        public const string LightBearer = "Light Bearer";

        //Dragonborn 2
        public const string BreathWeapon = "Breath Weapon";
        public const string DraconicResistance = "Draconic Resistance";

        //Dwarf 3
        public const string DarkVision = "Dark Vision";
        public const string DwarvenResilience = "Dwarven Resilience";
        public const string Stonecunning = "Stonecunning";

        //Elf 4
        public const string KeenSenses = "Keen Senses";
        public const string FeyAncestry = "Fey Ancestry";
        public const string Trance = "Trance";

        //Firbolg 5
        public const string FirbolgMagic = "Firbolg Magic";
        public const string HiddenStep = "Hidden Step";
        public const string PowerfulBuild = "Powerful Build";
        public const string SpeachOfBeastAndLeaf = "Speach Of Beast And Leaf";

        //Genasi
        //Air 6
        public const string UnendingBreath = "Unending Breath";
        public const string MingleWithTheWind = "Mingle with the Wind";
        //Earth 7
        public const string EarthWalk = "Earth Walk";
        public const string MergeWithStone = "Merge with Stone";
        //Fire 8
        public const string FireResistance = "Fire Resistance";
        public const string ReachToTheBlaze = "Reach to the Blaze";
        //Water 9
        public const string AcidResistance = "Acid Resistance";
        public const string Amphibious = "Amphibious";
        public const string CallToTheWave = "Call to the Wave";

        //Gnome 10
        public const string GnomeCunning = "Gnome Cunning";

        //Goliath 11
        public const string MountainBorn = "Mountain Born";
        public const string NaturalAthlete = "Natual Athlete";
        public const string StonesEndurance = "Stone's Endurance";

        //Half Elf 12
        public const string SkillVersatility = "Skill Versatility";

        //Halfling 13
        public const string Lucky = "Lucky";
        public const string Brave = "Brave";
        public const string HalflingNimbleness = "Halfling Nimbleness";

        //Half Orc 14
        public const string RelentlessEndurance = "Relentless Endurance";
        public const string SavageAttack = "Savage Attack";

        //Human 15
        public const string VersatileAbility = "Versatile Ability";

        //Kenku 16
        public const string Mimicry = "Mimicry";
        public const string ExpertForgery = "Expert Forgery";
        public const string SkillProficiencies = "Skill Proficiencies";

        //Tabaxi 17
        public const string CatsClaws = "Cat’s Claws";
        public const string FelineAgility = "Feline Agility";

        //Tiefling 18
        public const string InfernalLegacy = "Infernal Legacy";
        public const string HellishResistance = "Hellish Resistance";

        //Tortle 19
        public const string HoldBreath = "Hold Breath";
        public const string ShellDefense = "Shell Defense";
        public const string Claws = "Claws";

        //Yuan-ti Pureblood 20
        public const string MagicResistance = "Magic Resistance";
        public const string PoisonImmunity = "Poison Immunity";
        #endregion
        #region Race Tool Proficiencies
        public const string AlchemistsSupplies = "Alchemist's Supplies";
        public const string CalligraphersSupplies = "Calligrapher's Supplies";
        public const string HerbalismKit = "Herbalism Kit";
        public const string MusicalInstrument = "Musical Instrument";
        public const string PaintersSupplies = "Painter's Supplies";
        public const string SmithsTools = "Smith's Tools";
        public const string BrewersSupplies = "Brewer's Supplies";
        public const string MasonsTools = "Mason's Tools";
        public const string DragonchessSet = "Dragonchess Set";
        public const string CarpenterTools = "Carpenter's Tools";
        public const string CooksUtensils = "Cook's Utensils";
        public const string NavigatorsTools = "Navigator's Tools";
        public const string TinkersTools = "Tinker's Tools";
        public const string Flute = "Flute";
        public const string MinersTools = "Miner's Tools";
        public const string PottersTools = "Potter's Tools";
        public const string CartographerTools = "Cartographer's Tools";
        public const string GlassblowersTools = "Glassblower's Tools";
        public const string FishingTackle = "Fishing Tackle";
        public const string Fiddle = "Fiddle";
        public const string JewelersTools = "Jeweler's Tools";
        public const string WeaversTools = "Weaver's Tools";
        public const string WoodcarversTools = "Woodcarver's Tools";
        public const string LeatherworkerTools = "Leatherworker's Tools";
        public const string DisguiseKit = "Disguise Kit";
        public const string ThievesTools = "Thieves' Tools";
        public const string Lyre = "Lyre";
        public const string ForgeryKit = "Forgery Kit";
        public const string PoisonersKit = "Poisoner's Kit";
        public const string ArtisansTools = "Artisan's Tools";
        public const string FarmersTools = "Farmer's Tools";
        public const string Drums = "Drums";
        #endregion
        #region Spell Casting
        public const string CureWounds = "Cure Wounds";
        public const string Shield = "Shield";
        public const string MagicMissle = "Magic Missle";
        public const string DetectMagic = "Detect Magic";
        public const string Bless = "Bless";
        public const string MistyStep = "Misty Step";
        public const string Invisibility = "Invisibility";
        public const string HoldPerson = "Hold Person";
        public const string ScorchingRay = "Scorching Ray";
        public const string EnhanceAbility = "Enhance Ability";
        public const string Evocation = "Evocation";
        public const string Abjuration = "Abjuration";
        public const string Divination = "Divination";
        public const string Enchantment = "Enchantment";
        public const string Conjuration = "Conjuration";
        public const string Illusion = "Illusion";
        public const string Transmutation = "Transmutation";
        public const string _1Action = "1 Action";
        public const string _1Reaction = "1 Reaction";
        public const string BonusAction = "Bonus Action";
        public const string Touch = "Touch";
        public const string Self = "Self";
        public const string _120feet = "120 feet";
        public const string _30feet = "30 feet";
        public const string _60feet = "60 feet";
        public const string Instant = "Instant";
        public const string _1Round = "1 Round";
        public const string _10minutes = "10 minutes";
        public const string _1Minute = "1 Minute";
        public const string Upto1Hour = "Up to 1 Hour";
        public const string Upto1Minute = "Up to 1 Minute";
        public const string _1Hour = "1 Hour";
        #endregion

        public const string Battleaxe = "Battleaxe";
        public const string Handaxe = "Handaxe";
        public const string ThrowingHammer = "Throwing Hammer";
        public const string Warhammer = "Warhammer";
        public const string Longsword = "Longsword";
        public const string Shortsword = "Shortsword";
        public const string Shortbow = "Shortbow";
        public const string Longbow = "Longbow";

        
    }
}

