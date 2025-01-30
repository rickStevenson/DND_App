using Xunit;
using DND_App.Web.StaticClasses;

public class HelperMethodsAbilityModifierTests
{
    [Theory]
    [InlineData(1, -5)]
    [InlineData(2, -4)]
    [InlineData(5, -3)]
    [InlineData(7, -2)]
    [InlineData(9, -1)]
    [InlineData(10, 0)]
    [InlineData(12, 1)]
    [InlineData(14, 2)]
    [InlineData(17, 3)]
    [InlineData(20, 5)]
    [InlineData(30, 10)]
    public void CalculateAbilityModifier_ReturnsCorrectModifier(int attribute, int expectedModifier)
    {
        // Act
        int result = HelperMethods.CalculateAbilityModifier(attribute);

        // Assert
        Assert.Equal(expectedModifier, result);
    }

    [Fact]
    public void CalculateAbilityModifier_ThrowsExceptionForInvalidScore()
    {
        // Arrange
        int invalidScore = 31;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => HelperMethods.CalculateAbilityModifier(invalidScore));
    }
}

