using GF.Domain.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GF.WebUI.ViewModels
{
    public class UpdateGroupViewModel
    {
        public Group Group { get; set; }
        public IFormFile Image { get; set; }
    }
}
