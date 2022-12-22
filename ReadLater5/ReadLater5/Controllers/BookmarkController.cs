using Entity;
using Microsoft.AspNetCore.Mvc;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace ReadLater5.Controllers
{
    public class BookmarkController : Controller
    {
        [HttpGet]
        public IActionResult bookmark()
        {
            return View();
        }

    }
}