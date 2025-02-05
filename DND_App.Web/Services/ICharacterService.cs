using DND_App.Web.Models.Domain;
using DND_App.Web.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace DND_App.Web.Services
{
    public interface ICharacterService
    {
        Task<CreateCharacterViewModel> GetCreateCharacterViewModelAsync();
        Task<IEnumerable<Character>> GetAllCharactersAsync();
        Task<Character?> GetCharacterByIdAsync(int id);
        Task<Character?> CreateCharacterAsync(CreateCharacterViewModel createCharacterViewModel, IdentityUser loggedInUser);
        Task<Character?> UpdateCharacterAsync(int id, EditCharacterViewModel editCharacterViewModel);
        Task<bool> DeleteCharacterAsync(int id);
        Task<List<Character>> GetUserCharactersAsync(string userId);
        Task<EditCharacterViewModel?> GetCharacterForEditAsync(int id);
        Task LoadViewBagDataAsync(ViewDataDictionary viewData);
        
    }
}
