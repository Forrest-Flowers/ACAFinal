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
        private readonly IHostingEnvironment _environment;

        public GroupController(IGroupService groupService,
            IHostingEnvironment environment
            )
        {
            _groupService = groupService;
            _environment = environment;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}