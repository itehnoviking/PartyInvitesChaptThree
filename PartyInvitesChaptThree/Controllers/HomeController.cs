using Microsoft.AspNetCore.Mvc;
using PartyInvitesChaptThree.Models;
using System.Diagnostics;

namespace PartyInvitesChaptThree.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}