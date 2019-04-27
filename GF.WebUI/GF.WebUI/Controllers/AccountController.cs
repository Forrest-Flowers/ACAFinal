using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GF.Domain.Models;
using GF.WebUI.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace GF.WebUI.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<User> _signInManager;
        private readonly List<IdentityRole> _roles;

        public AccountController(UserManager<User> userManager, 
            RoleManager<IdentityRole> roleManager, 
            SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;

            _roles = roleManager.Roles.ToList();
        }
        [HttpGet]
        public IActionResult Register() =>
            View();

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel vm)
        {
            if (ModelState.IsValid)
            {
                var user = new User
                {
                    Email = vm.Email,
                    UserName = vm.Email
                };

                var result = await _userManager.CreateAsync(user, vm.Password);

                if (result.Succeeded)
                {
                    //await _userManager.AddToRoleAsync(AppUser, "APPUSER");

                    await _signInManager.SignInAsync(user, true);
                    return RedirectToAction("Index", "Home"); //default to current controller
                }
                else
                {
                    foreach (var error in result.Errors)
                    {
                        ModelState.AddModelError(error.Code, error.Description);
                    }
                }
            }
            return View(vm);
        }

        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(SignInViewModel vm)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(vm.Email, vm.Password, vm.RememberMe, false);

                if (result.Succeeded)
                {
                    //get user
                    var user = await _userManager.FindByEmailAsync(vm.Email);

                    return RedirectToAction("Index" , "Home");
                }
                else
                {
                    ModelState.AddModelError("SignIn", "Username or Password is incorrect.");
                }
            }
            return View(vm);
        }

        public async Task<IActionResult> SignOut()
        {
            await _signInManager.SignOutAsync();

            return RedirectToAction("Index", "Home");
        }
    }
}