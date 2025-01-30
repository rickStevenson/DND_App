using Xunit;
using Moq;
using System.Collections.Generic;
using DND_App.Web.Models.Domain;
using DND_App.Web.StaticClasses;
using DND_App.Web.StaticClasses.Constants;

public class HelperMethodsArmorClassTests
{
    [Fact]
    public void CalculateArmorClass_NoArmor_ReturnsDefaultAC()
    {
        // Arrange
        var character = new Character
        {
            Dexterity = 10,
            CharacterClass = new CharacterClass { Name = "Fighter" },
            CharacterItems = new List<CharacterItem>()
        };

        // Act
        int result = HelperMethods.CalculateArmorClass(character);

        // Assert
        Assert.Equal(10, result);
    }

    [Fact]
    public void CalculateArmorClass_WithLeatherArmor_ReturnsCorrectAC()
    {
        // Arrange
        var character = new Character
        {
            Dexterity = 14,
            CharacterClass = new CharacterClass { Name = "Fighter" },
            CharacterItems = new List<CharacterItem>
            {
                new CharacterItem { Item = new Item { Name = "Leather Armor", Category = Category.Armor } }
            }
        };

        // Act
        int result = HelperMethods.CalculateArmorClass(character);

        // Assert
        Assert.Equal(13, result); // 11 + Dex modifier (2)
    }

    [Fact]
    public void CalculateArmorClass_WithChainmail_ReturnsCorrectAC()
    {
        // Arrange
        var character = new Character
        {
            Dexterity = 16,
            CharacterClass = new CharacterClass { Name = "Fighter" },
            CharacterItems = new List<CharacterItem>
            {
                new CharacterItem { Item = new Item { Name = "Chainmail", Category = Category.Armor } }
            }
        };

        // Act
        int result = HelperMethods.CalculateArmorClass(character);

        // Assert
        Assert.Equal(16, result); // Chainmail is fixed at 16 AC
    }

    [Fact]
    public void CalculateArmorClass_WithShield_ReturnsCorrectAC()
    {
        // Arrange
        var character = new Character
        {
            Dexterity = 14,
            CharacterClass = new CharacterClass { Name = "Fighter" },
            CharacterItems = new List<CharacterItem>
            {
                new CharacterItem { Item = new Item { Name = "Leather Armor", Category = Category.Armor } },
                new CharacterItem { Item = new Item { Name = "Shield" } }
            }
        };

        // Act
        int result = HelperMethods.CalculateArmorClass(character);

        // Assert
        Assert.Equal(15, result); // 11 + Dex modifier (2) + Shield bonus (2)
    }

    [Fact]
    public void CalculateArmorClass_WithBarbarianUnarmoredDefense_ReturnsCorrectAC()
    {
        // Arrange
        var character = new Character
        {
            Dexterity = 14,
            Constitution = 16,
            CharacterClass = new CharacterClass { Name = Classes.Barbarian },
            CharacterItems = new List<CharacterItem>()
        };

        // Act
        int result = HelperMethods.CalculateArmorClass(character);

        // Assert
        Assert.Equal(15, result); // 10 + Dex (2) + Con (3)
    }

    [Fact]
    public void CalculateArmorClass_WithMagicArmorBonus_ReturnsCorrectAC()
    {
        // Arrange
        var character = new Character
        {
            Dexterity = 14,
            CharacterClass = new CharacterClass { Name = "Fighter" },
            CharacterItems = new List<CharacterItem>
            {
                new CharacterItem { Item = new Item { Name = "Leather Armor", Category = Category.Armor, ArmorClassBonus = 1 } }
            }
        };

        // Act
        int result = HelperMethods.CalculateArmorClass(character);

        // Assert
        Assert.Equal(14, result); // 11 + Dex modifier (2) + Magic bonus (1)
    }
}
