using Microsoft.AspNetCore.Identity;

namespace DND_App.Web.Repository
{
    public interface IUserRepository
    {
        Task<IEnumerable<IdentityUser>> GetAllUsers();
    }
}
