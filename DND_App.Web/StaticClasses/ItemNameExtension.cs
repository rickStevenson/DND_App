namespace DND_App.Web.StaticClasses
{
    public static class ItemNameExtension
    {
        public static string GetDisplayName(this ItemName itemName)
        {
            return itemName switch
            {
                ItemName.Chainmail => "Chainmail",
                ItemName.HealingPotion => "Healing Potion",
                ItemName.Backpack => "Backpack",
                ItemName.Lantern => "Lantern",
                ItemName.Spellbook => "Spellbook",
                ItemName.Rations_1day => "Rations (1 day)",
                ItemName.Dagger => "Dagger",
                ItemName.Rope_50feet => "Rope (50 feet)",
                ItemName.Shortbow => "Shortbow",
                ItemName.Longsword => "Longsword",
                ItemName.Battleaxe => "Battleaxe",
                ItemName.Handaxe => "Handaxe",
                ItemName.ThrowingHammer => "Throwing Hammer",
                ItemName.Warhammer => "Warhammer",
                ItemName.Shortsword => "Shortsword",
                ItemName.Longbow => "Longbow",
                ItemName.LeatherArmor => "Leather Armor",
                ItemName.ChainShirt => "Chain Shirt",
                ItemName.PlateArmor => "Plate Armor",
                ItemName.Shield => "Shield",
                ItemName.ShieldPlusOne => "Shield +1",
                ItemName.ArmorPlusTwo => "Armor +2",
                ItemName.CloakOfProtection => "Cloak Of Protection",
                ItemName.PlatnumCoin => "Platnum Coin",
                ItemName.GoldCoin => "Gold Coin",
                ItemName.ElectrumCoin => "Electrum Coin",
                ItemName.SilverCoin => "Silver Coin",
                ItemName.CopperCoin => "Copper Coin",
                ItemName.Diamond => "Diamond",
                ItemName.Sapphire => "Sapphire",
                ItemName.Emerald => "Emerald",
                ItemName.Ruby => "Ruby",
                ItemName.SilverBraceletWithRubyInlays => "Silver Bracelet with Ruby Inlays",
                ItemName.AmuletOfProtection => "Amulet of Protection",
                ItemName.SwordOfValor => "Sword of Valor",


                _ => throw new ArgumentOutOfRangeException(nameof(itemName), itemName, null)
            };
        }
    }
    public enum ItemName
    {
        Chainmail,
        HealingPotion,
        Backpack,
        Lantern,
        Spellbook,
        Rations_1day,
        Dagger,
        Rope_50feet,
        Shortbow,
        Longsword,
        Battleaxe,
        Handaxe,
        ThrowingHammer,
        Warhammer,
        Shortsword,
        Longbow,
        LeatherArmor,
        ChainShirt,
        PlateArmor,
        Shield,
        ShieldPlusOne,
        ArmorPlusTwo,
        CloakOfProtection,
        PlatnumCoin,
        GoldCoin,
        ElectrumCoin,
        SilverCoin,
        CopperCoin,
        Diamond,
        Sapphire,
        Emerald,
        Ruby,
        SilverBraceletWithRubyInlays,
        AmuletOfProtection,
        SwordOfValor
    }
}
