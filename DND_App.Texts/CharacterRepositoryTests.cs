using DND_App.Web.Data;
using DND_App.Web.Models.Domain;
using DND_App.Web.Repository;
using Microsoft.EntityFrameworkCore;
using Xunit;
using System.Threading.Tasks;

public class CharacterRepositoryTests
{
    private readonly DbContextOptions<DnDDbContext> _options;
    private readonly DnDDbContext _dbContext;
    private readonly CharacterRepository _characterRepository;

    public CharacterRepositoryTests()
    {
        // Set up in-memory database
        _options = new DbContextOptionsBuilder<DnDDbContext>()
            .UseInMemoryDatabase(databaseName: "TestDatabase")
            .Options;

        _dbContext = new DnDDbContext(_options);
        _characterRepository = new CharacterRepository(_dbContext);
    }

    [Fact]
    public async Task CreateAsync_AddsCharacter()
    {
        // Arrange
        var character = new Character
        {
            CharacterName = "Test Character",
            Level = 1,
            PlayerName = "Test Player"
        };

        // Act
        await _characterRepository.CreateAsync(character);
        var result = await _dbContext.Characters.FirstOrDefaultAsync(c => c.CharacterName == "Test Character");

        // Assert
        Assert.NotNull(result);
        Assert.Equal("Test Character", result.CharacterName);
        Assert.Equal("Test Player", result.PlayerName);
    }

}
