using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using GF.Domain.Models;
using GF.Service.Services;
using GF.WebUI.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace GF.WebUI.Controllers
{
    public class GroupController : Controller
    {
        private readonly IGroupService _groupService;
        private readonly IGroupUserLinkService _groupUserLinkService;
        private readonly IHostingEnvironment _environment;
        private readonly UserManager<User> _userManager;

        public GroupController(IGroupService groupService,
            IGroupUserLinkService groupUserLinkService,
            IHostingEnvironment environment,
            UserManager<User> userManager
            )
        {
            _groupService = groupService;
            _groupUserLinkService = groupUserLinkService;
            _environment = environment;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CreateGroup() => View();
        [HttpPost]
        public IActionResult CreateGroup(CreateGroupViewModel vm)
        {
            Group newGroup = vm.Group;
            IFormFile image = vm.Image;

            //upload image.
            if (image != null && image.Length > 0)
            {
                string storageFolder = Path.Combine(_environment.WebRootPath, "images/groups");

                string newImageName = $"{Guid.NewGuid().ToString()}{Path.GetExtension(image.FileName)}";

                string fullPath = Path.Combine(storageFolder, newImageName);

                using (var stream = new FileStream(fullPath, FileMode.Create))
                {
                    image.CopyTo(stream);
                }

                //Image is successfully uploaded.
                //append new image location to new home.
                newGroup.ImageURL = $"/images/groups/{newImageName}";
            }

            GroupUserLink newGroupUserLink = new GroupUserLink
            {
                GroupId = newGroup.Id,
                UserId = _userManager.GetUserId(User)
            };

            _groupUserLinkService.Create(newGroupUserLink);
            // save newGroup
            _groupService.Create(newGroup);

            

            return RedirectToAction("grouplist");
        }
        public IActionResult GroupList()
        {
            var groups = _groupService.GetAll();

            return View(groups); //ICollection<Groups>
        }

    }
}