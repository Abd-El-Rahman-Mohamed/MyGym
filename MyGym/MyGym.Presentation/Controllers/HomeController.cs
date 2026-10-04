using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyGym.DataAccess.Models;

namespace MyGym.Presentation.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}