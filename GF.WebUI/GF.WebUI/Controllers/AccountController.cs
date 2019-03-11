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

        public AccountController(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }
        [HttpGet]
        public IActionResult Register() =>
            View();

        [HttpPost]
        public IActionResult Register(RegisterViewModel vm)
        {
            if(ModelState.IsValid)
            {

            }
            return View(vm);
        }
    }
}