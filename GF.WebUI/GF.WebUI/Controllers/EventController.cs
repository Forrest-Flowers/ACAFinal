using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GF.Domain.Models;
using GF.Service.Services;
using GF.WebUI.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace GF.WebUI.Controllers
{
    public class EventController : Controller
    {
        private readonly IEventService _eventService;
        private readonly IGroupService _groupService;

        public EventController(IEventService eventService,
            IGroupService groupService)
        {
            _eventService = eventService;
            _groupService = groupService;
        }

        [HttpGet]
        public IActionResult Create(int Id)
        {

            Event vm = new Event();

            vm.GroupId = Id;

            return View(vm);
        }

        [HttpPost]
        public IActionResult Create(Event newEvent)
        {
            newEvent.Id = 0;

            _eventService.Create(newEvent);

            return RedirectToAction("groupindex", "group", new {id = newEvent.GroupId });
        }
    }
}