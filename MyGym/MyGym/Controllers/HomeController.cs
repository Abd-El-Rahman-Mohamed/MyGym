using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MyGym.Models;

namespace MyGym.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}