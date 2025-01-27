using DND_App.Web.Data;
using DND_App.Web.Models.Domain;
using DND_App.Web.Models.ViewModels;
using DND_App.Web.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DND_App.Web.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminUserController : Controller
    {
        private readonly IUserRepository userRepository;
        private readonly UserManager<IdentityUser> userManager;
        private readonly DnDDbContext dnDDbContext;

        public AdminUserController(IUserRepository userRepository, UserManager<IdentityUser> userManager, DnDDbContext dnDDbContext)
        {
            this.userRepository = userRepository;
            this.userManager = userManager;
            this.dnDDbContext = dnDDbContext;
        }
        [HttpGet]
        public async Task<IActionResult> List()
        {
            var users = await userRepository.GetAllUsers();

            var usersViewModel = new UserViewModel();
            usersViewModel.Users = new List<User>();

            foreach (var user in users)
            {
                usersViewModel.Users.Add(new User
                {
                    Id = Guid.Parse(user.Id),
                    Username = user.UserName,
                    EmailAddress = user.Email
                });
            }
            
            return View(usersViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> List(UserViewModel request)
        {
            var identityUser = new IdentityUser
            {
                UserName = request.Username,
                Email = request.Email
            };

            var identityResult = await userManager.CreateAsync(identityUser, request.Password);

            if (identityResult != null)
            {
                if (identityResult.Succeeded)
                {
                    var roles = new List<string> { "User" };

                    if (request.IsDungeonMaster)
                    {
                        roles.Add("DM");
                    }

                    identityResult =
                        await userManager.AddToRolesAsync(identityUser, roles);

                    if (identityResult != null && identityResult.Succeeded)
                    {
                        return RedirectToAction("List", "AdminUser");
                    }
                }
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Delete(Guid id)
        {
            var user = await userManager.FindByIdAsync(id.ToString());

            if (user != null)
            {
                var identityResult = await userManager.DeleteAsync(user);

                if (identityResult != null && identityResult.Succeeded)
                {
                    return RedirectToAction("List", "AdminUser");
                }
            }

            return View();
        }

        [HttpGet]
        public IActionResult CreateRace()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateRace(CharacterRace model, IFormFile MaleImage, IFormFile FemaleImage)
        {
            if (ModelState.IsValid)
            {
                if (MaleImage != null && MaleImage.Length > 0)
                {
                    var uniqueFileName = Guid.NewGuid().ToString() + Path.GetExtension(MaleImage.FileName);
                    var maleImagePath = Path.Combine("wwwroot/images", uniqueFileName);
                    using (var stream = new FileStream(maleImagePath, FileMode.Create))
                    {
                        await MaleImage.CopyToAsync(stream);
                    }
                    model.MaleImage = "/images/" + uniqueFileName;
                }

                if (FemaleImage != null && FemaleImage.Length > 0)
                {
                    var uniqueFileName = Guid.NewGuid().ToString() + Path.GetExtension(FemaleImage.FileName);
                    var femaleImagePath = Path.Combine("wwwroot/images", uniqueFileName);
                    using (var stream = new FileStream(femaleImagePath, FileMode.Create))
                    {
                        await FemaleImage.CopyToAsync(stream);
                    }
                    model.FemaleImage = "/images/" + uniqueFileName;
                }

                dnDDbContext.CharacterRaces.Add(model);
                await dnDDbContext.SaveChangesAsync();

                return RedirectToAction("GetAllRaces", "CharacterRace");
            }

            return View(model); // Return the same view in case of errors
        }

    }
}
