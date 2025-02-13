﻿using DND_App.Web.Data;
using DND_App.Web.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace DND_App.Web.Controllers
{
    public class AccountsController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;

        public AccountsController(UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel registerViewModel)
        {
            if (ModelState.IsValid)
            {
                // Create the user in the `AspNetUsers` table (DND_UserAuth_Db)
                var identityUser = new IdentityUser
                {
                    UserName = registerViewModel.Username,
                    Email = registerViewModel.Email
                };

                var identityResult = await userManager.CreateAsync(identityUser, registerViewModel.Password);

                if (identityResult.Succeeded)
                {
                    // Assign the "User" role
                    var roleIdentityResult = await userManager.AddToRoleAsync(identityUser, "User");

                    if (roleIdentityResult.Succeeded)
                    {
                        // Insert user into `IdentityUser<Guid>` table in `DND_Db`
                        using (var scope = HttpContext.RequestServices.CreateScope())
                        {
                                var dndDbContext =              scope.ServiceProvider.GetRequiredService<DnDDbContext>();

                            var guidUser = new IdentityUser<Guid>
                            {
                                Id = Guid.Parse(identityUser.Id),
                                UserName = identityUser.UserName,
                                NormalizedUserName = identityUser.NormalizedUserName,
                                Email = identityUser.Email,
                                NormalizedEmail = identityUser.NormalizedEmail,
                                PasswordHash = identityUser.PasswordHash,
                                SecurityStamp = identityUser.SecurityStamp,
                                ConcurrencyStamp = identityUser.ConcurrencyStamp
                            };

                            dndDbContext.Set<IdentityUser<Guid>>().Add(guidUser);
                            await dndDbContext.SaveChangesAsync();
                        }

                        // Sign in the user
                        await signInManager.SignInAsync(identityUser, isPersistent: false);
                        // Redirect to home page after successful registration
                        return RedirectToAction("Index", "Home");
                    }

                    foreach (var error in roleIdentityResult.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
                else
                {
                    foreach (var error in identityResult.Errors)
                    {
                        ModelState.AddModelError(string.Empty, error.Description);
                    }
                }
            }

            // Return the view with errors if registration fails
            return View(registerViewModel);
        }


        [HttpGet]
        public IActionResult Login(string ReturnUrl)
        {
            var model = new LoginViewModel
            {
                ReturnUrl = ReturnUrl
            };

            
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var signInResult = await signInManager.PasswordSignInAsync(
                loginViewModel.Username,
                loginViewModel.Password,
                false,
                false);

            //var user = await signInManager.UserManager.FindByNameAsync(loginViewModel.Username);
            //if (user != null)
            //{
            //    var roles = await signInManager.UserManager.GetRolesAsync(user);
            //    Console.WriteLine($"Roles for user {user.UserName}: {string.Join(", ", roles)}");
            //}
            //else
            //{
            //    Console.WriteLine("User not found.");
            //}

            if (signInResult != null && signInResult.Succeeded)
            {
                var user = await userManager.FindByNameAsync(loginViewModel.Username);
                if (user != null)
                {
                    await signInManager.RefreshSignInAsync(user);
                }

                if (!string.IsNullOrWhiteSpace(loginViewModel.ReturnUrl))
                {
                    return Redirect(loginViewModel.ReturnUrl);
                }
                return RedirectToAction("Index", "Home");
            }

            
            //Show errors
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
