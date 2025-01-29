using System.Reflection.Metadata;

namespace DND_App.Web.StaticClasses
{
    public static class SpellCastingExtension
    {
        public static string GetDisplayName(this SpellCastings spellCastings)
        {
            return spellCastings switch
            {
                SpellCastings.CureWounds => "Cure Wounds",
                SpellCastings.Shield => "Shield",
                SpellCastings.MagicMissle => "Magic Missle",
                SpellCastings.DetectMagic => "Detect Magic",
                SpellCastings.Bless => "Bless",
                SpellCastings.MistyStep => "Misty Step",
                SpellCastings.Invisibility => "Invisibility",
                SpellCastings.HoldPerson => "Hold Person",
                SpellCastings.ScorchingRay => "Scorching Ray",
                SpellCastings.EnhanceAbility => "Enhance Ability",
                SpellCastings.Evocation => "Evocation",
                SpellCastings.Abjuration => "Abjuration",
                SpellCastings.Divination => "Divination",
                SpellCastings.Enchantment => "Enchantment",
                SpellCastings.Conjuration => "Conjuration",
                SpellCastings.Illusion => "Illusion",
                SpellCastings.Transmutation => "Transmutation",
                SpellCastings._1Action => "1 Action",
                SpellCastings._1Reaction => "1 Reaction",
                SpellCastings.BonusAction => "Bonus Action",
                SpellCastings.Touch => "Touch",
                SpellCastings.Self => "Self",
                SpellCastings._120feet => "120 feet",
                SpellCastings._30feet => "30 feet",
                SpellCastings._60feet => "60 feet",
                SpellCastings.Instant => "Instant",
                SpellCastings._1Round => "1 Round",
                SpellCastings._10minutes => "10 minutes",
                SpellCastings._1Minute => "1 Minute",
                SpellCastings.Upto1Hour => "Up to 1 Hour",
                SpellCastings.Upto1Minute => "Up to 1 Minute",
                SpellCastings._1Hour => "1 Hour",
                SpellCastings.Verbal => "Verbal",
                SpellCastings.Somatic => "Somatic",
                SpellCastings.Material => "Material",
                SpellCastings._8Hours => "8 Hours",
                SpellCastings._24Hours => "24 Hours",
                SpellCastings.ConcentrationUpTo1Hour => "Concentration up to 1 hour",
                SpellCastings.ConcentrationUpTo1Minute => "Concentration up to 1 minute",
                SpellCastings.UntilDispelled => "Until dispelled",

                _ => throw new ArgumentOutOfRangeException(nameof(spellCastings), spellCastings, null)
            };
        }
    }

    public enum SpellCastings
    {
        CureWounds,
        Shield,
        MagicMissle,
        DetectMagic,
        Bless,
        MistyStep,
        Invisibility,
        HoldPerson,
        ScorchingRay,
        EnhanceAbility,
        Evocation,
        Abjuration,
        Divination,
        Enchantment,
        Conjuration,
        Illusion,
        Transmutation,
        _1Action,
        _1Reaction,
        BonusAction,
        Touch,
        Self,
        _120feet,
        _30feet,
        _60feet,
        Instant,
        _1Round,
        _10minutes,
        _1Minute,
        Upto1Hour,
        Upto1Minute,
        _1Hour,
        Verbal,
        Somatic,
        Material,
        Instantaneous,
        _8Hours,
        _24Hours,
        ConcentrationUpTo1Hour,
        ConcentrationUpTo1Minute,
        UntilDispelled
    }
}
