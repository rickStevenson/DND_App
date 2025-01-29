namespace DND_App.Web.StaticClasses
{
    public static class TreasureExtension
    {
        public static string GetDisplayName(this TreasureType treasureType)
        {
            return treasureType switch
            {
                TreasureType.Coins => "Coin",
                TreasureType.Gems => "Gems",
                TreasureType.Jewelry => "Jewelry",
                TreasureType.Art => "Art",
                TreasureType.Miscellaneous => "Miscellaneous",
                TreasureType.MagicItem => "Magic CharacterItems",
                TreasureType.SpellComponents => "Spell Components",
                TreasureType.Relics => "Relics",
                TreasureType.TradeGoods => "Trade Goods",
                TreasureType.QuestItem => "Quest Items",
                TreasureType.RareItems => "Rare CharacterItems",
                TreasureType.Artifacts => "Artifacts",

                _ => throw new ArgumentOutOfRangeException(nameof(treasureType), treasureType, null)
            };
        }
    }
    public enum TreasureType
    {
        Coins,
        Gems,
        Jewelry,
        Art,
        Miscellaneous,
        MagicItem,
        SpellComponents,
        Relics,
        TradeGoods,
        QuestItem,
        RareItems,
        Artifacts
    }
}
