﻿namespace DND_App.Web.StaticClasses
{
    public static class RaceAbilitiesExtension
    {
        public static string GetDisplayName(this RaceAbilities raceAbility)
        {
            return raceAbility switch
            {
                RaceAbilities.CelestialResistance => "Celestial Resistance",
                RaceAbilities.HealingHands => "Healing Hands",
                RaceAbilities.LightBearer => "Light Bearer",
                RaceAbilities.BreathWeapon => "Breath Weapon",
                RaceAbilities.DraconicResistance => "Draconic Resistance",
                RaceAbilities.DarkVision => "Dark Vision",
                RaceAbilities.DwarvenResilience => "Dwarven Resilience",
                RaceAbilities.Stonecunning => "Stonecunning",
                RaceAbilities.KeenSenses => "Keen Senses",
                RaceAbilities.FeyAncestry => "Fey Ancestry",
                RaceAbilities.Trance => "Trance",
                RaceAbilities.FirbolgMagic => "Firbolg Magic",
                RaceAbilities.HiddenStep => "Hidden Step",
                RaceAbilities.PowerfulBuild => "Powerful Build",
                RaceAbilities.SpeechOfBeastAndLeaf => "Speech Of Beast And Leaf",
                RaceAbilities.UnendingBreath => "Unending Breath",
                RaceAbilities.MingleWithTheWind => "Mingle with the Wind",
                RaceAbilities.EarthWalk => "Earth Walk",
                RaceAbilities.MergeWithStone => "Merge with Stone",
                RaceAbilities.FireResistance => "Fire Resistance",
                RaceAbilities.ReachToTheBlaze => "Reach to the Blaze",
                RaceAbilities.AcidResistance => "Acid Resistance",
                RaceAbilities.Amphibious => "Amphibious",
                RaceAbilities.CallToTheWave => "Call to the Wave",
                RaceAbilities.GnomeCunning => "Gnome Cunning",
                RaceAbilities.MountainBorn => "Mountain Born",
                RaceAbilities.NaturalAthlete => "Natural Athlete",
                RaceAbilities.StonesEndurance => "Stone's Endurance",
                RaceAbilities.SkillVersatility => "Skill Versatility",
                RaceAbilities.Lucky => "Lucky",
                RaceAbilities.Brave => "Brave",
                RaceAbilities.HalflingNimbleness => "Halfling Nimbleness",
                RaceAbilities.RelentlessEndurance => "Relentless Endurance",
                RaceAbilities.SavageAttack => "Savage Attack",
                RaceAbilities.VersatileAbility => "Versatile Ability",
                RaceAbilities.Mimicry => "Mimicry",
                RaceAbilities.ExpertForgery => "Expert Forgery",
                RaceAbilities.SkillProficiencies => "Skill Proficiencies",
                RaceAbilities.CatsClaws => "Cat’s Claws",
                RaceAbilities.FelineAgility => "Feline Agility",
                RaceAbilities.InfernalLegacy => "Infernal Legacy",
                RaceAbilities.HellishResistance => "Hellish Resistance",
                RaceAbilities.HoldBreath => "Hold Breath",
                RaceAbilities.ShellDefense => "Shell Defense",
                RaceAbilities.Claws => "Claws",
                RaceAbilities.MagicResistance => "Magic Resistance",
                RaceAbilities.PoisonImmunity => "Poison Immunity",
                _ => throw new ArgumentOutOfRangeException(nameof(raceAbility), raceAbility, null)
            };
        }
    }

    public enum RaceAbilities
    {
        CelestialResistance,
        HealingHands,
        LightBearer,
        BreathWeapon,
        DraconicResistance,
        DarkVision,
        DwarvenResilience,
        Stonecunning,
        KeenSenses,
        FeyAncestry,
        Trance,
        FirbolgMagic,
        HiddenStep,
        PowerfulBuild,
        SpeechOfBeastAndLeaf,
        UnendingBreath,
        MingleWithTheWind,
        EarthWalk,
        MergeWithStone,
        FireResistance,
        ReachToTheBlaze,
        AcidResistance,
        Amphibious,
        CallToTheWave,
        GnomeCunning,
        MountainBorn,
        NaturalAthlete,
        StonesEndurance,
        SkillVersatility,
        Lucky,
        Brave,
        HalflingNimbleness,
        RelentlessEndurance,
        SavageAttack,
        VersatileAbility,
        Mimicry,
        ExpertForgery,
        SkillProficiencies,
        CatsClaws,
        FelineAgility,
        InfernalLegacy,
        HellishResistance,
        HoldBreath,
        ShellDefense,
        Claws,
        MagicResistance,
        PoisonImmunity
    }
}
