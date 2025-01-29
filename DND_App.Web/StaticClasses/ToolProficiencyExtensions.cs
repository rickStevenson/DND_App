using System.Reflection;

namespace DND_App.Web.StaticClasses
{
    public static class ToolProficiencyExtensions
    {
        public static string GetDisplayName(this ToolProficiency tp)
        {
            return tp switch
            {
                ToolProficiency.AlchemistsSupplies => "Alchemist's Supplies",
                ToolProficiency.CalligraphersSupplies => "Calligrapher's Supplies",
                ToolProficiency.HerbalismKit => "Herbalism Kit",
                ToolProficiency.MusicalInstrument => "Musical Instrument",
                ToolProficiency.PaintersSupplies => "Painter's Supplies",
                ToolProficiency.SmithsTools => "Smith's Tools",
                ToolProficiency.BrewersSupplies => "Brewer's Supplies",
                ToolProficiency.MasonsTools => "Mason's Tools",
                ToolProficiency.DragonchessSet => "Dragonchess Set",
                ToolProficiency.CarpenterTools => "Carpenter's Tools",
                ToolProficiency.CooksUtensils => "Cook's Utensils",
                ToolProficiency.NavigatorsTools => "Navigator's Tools",
                ToolProficiency.TinkersTools => "Tinker's Tools",
                ToolProficiency.Flute => "Flute",
                ToolProficiency.MinersTools => "Miner's Tools",
                ToolProficiency.PottersTools => "Potter's Tools",
                ToolProficiency.CartographerTools => "Cartographer's Tools",
                ToolProficiency.GlassblowersTools => "Glassblower's Tools",
                ToolProficiency.FishingTackle => "Fishing Tackle",
                ToolProficiency.Fiddle => "Fiddle",
                ToolProficiency.JewelersTools => "Jeweler's Tools",
                ToolProficiency.WeaversTools => "Weaver's Tools",
                ToolProficiency.WoodcarversTools => "Woodcarver's Tools",
                ToolProficiency.LeatherworkerTools => "Leatherworker's Tools",
                ToolProficiency.DisguiseKit => "Disguise Kit",
                ToolProficiency.ThievesTools => "Thieves' Tools",
                ToolProficiency.Lyre => "Lyre",
                ToolProficiency.ForgeryKit => "Forgery Kit",
                ToolProficiency.PoisonersKit => "Poisoner's Kit",
                ToolProficiency.ArtisansTools => "Artisan's Tools",
                ToolProficiency.FarmersTools => "Farmer's Tools",
                ToolProficiency.Drums => "Drums",
                _ => throw new ArgumentOutOfRangeException(nameof(tp), tp, null)
            };
        }
    }
    public enum ToolProficiency
    {
        AlchemistsSupplies,
        CalligraphersSupplies,
        HerbalismKit,
        MusicalInstrument,
        PaintersSupplies,
        SmithsTools,
        BrewersSupplies,
        MasonsTools,
        DragonchessSet,
        CarpenterTools,
        CooksUtensils,
        NavigatorsTools,
        TinkersTools,
        Flute,
        MinersTools,
        PottersTools,
        CartographerTools,
        GlassblowersTools,
        FishingTackle,
        Fiddle,
        JewelersTools,
        WeaversTools,
        WoodcarversTools,
        LeatherworkerTools,
        DisguiseKit,
        ThievesTools,
        Lyre,
        ForgeryKit,
        PoisonersKit,
        ArtisansTools,
        FarmersTools,
        Drums
    }
}
