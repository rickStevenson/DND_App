using Xunit;
using Moq;
using Microsoft.AspNetCore.Mvc;
using DND_App.Web.Controllers;
using DND_App.Web.Repository;
using Microsoft.AspNetCore.Identity;
using DND_App.Web.Models.Domain;
using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;

public class CharacterControllerTests
{
    private readonly CharacterController _controller;
    private readonly Mock<ICharacterRepository> _mockRepo;
    private readonly Mock<UserManager<IdentityUser>> _mockUserManager;

    public CharacterControllerTests()
    {
        _mockRepo = new Mock<ICharacterRepository>();
        _mockUserManager = new Mock<UserManager<IdentityUser>>(
            new Mock<IUserStore<IdentityUser>>().Object, null, null, null, null, null, null, null, null
        );

        _controller = new CharacterController(_mockRepo.Object, _mockUserManager.Object, null);
    }

    [Fact]
    public async Task ReadAll_ReturnsViewWithCharacters()
    {
        // Arrange
        var characters = new List<Character>
        {
            new Character { CharacterName = "Hero", Level = 5 },
            new Character { CharacterName = "Mage", Level = 3 }
        };

        _mockRepo.Setup(repo => repo.ReadAllAsync()).ReturnsAsync(characters);

        // Act
        var result = await _controller.ReadAll() as ViewResult;

        // Assert
        Assert.NotNull(result);
        Assert.IsType<List<Character>>(result.Model);
    }
}
