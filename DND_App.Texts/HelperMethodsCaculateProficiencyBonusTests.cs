using Xunit;
using DND_App.Web.StaticClasses;

public class HelperMethodsCaculateProficiencyBonusTests
{
    [Theory]
    [InlineData(1, 2)]
    [InlineData(5, 3)]
    [InlineData(10, 4)]
    public void CalculateProficiencyBonus_ReturnsCorrectValue(int level, int expectedBonus)
    {
        // Act
        var result = HelperMethods.CalculateProficiencyBonus(level);

        // Assert
        Assert.Equal(expectedBonus, result);
    }
}
