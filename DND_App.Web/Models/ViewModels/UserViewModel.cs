using DND_App.Web.Models.Domain;
using Microsoft.AspNetCore.Identity;

namespace DND_App.Web.Models.ViewModels
{
    public class UserViewModel
    {
        public List<User> Users { get; set; }

        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsDungeonMaster { get; set; }
    }
}
