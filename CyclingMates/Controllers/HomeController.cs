using System.Diagnostics;
using System.Security.Claims;
using CyclingMates.Areas.Identity.Data;
using CyclingMates.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CyclingMates.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly CyclingMatesContext _context;
    private readonly UserManager<CyclingMatesUser> _userManager;

    public HomeController(ILogger<HomeController> logger, CyclingMatesContext context, UserManager<CyclingMatesUser> userManager)
    {
        _logger = logger;
        _context = context;
        _userManager = userManager;
    }

    public async Task<IActionResult> Index()
    {
        if (_context.Activities != null)
        {
            List<CyclingMates.Models.Activity> activities = await _context.Activities.ToListAsync();

            List<CyclingMates.Models.ActivityDisplay> activitiesDisplay = new List<Models.ActivityDisplay>();
            List<CyclingMatesUser> users = await _userManager.Users.ToListAsync();

            foreach (CyclingMates.Models.Activity activity in activities)
            {
                CyclingMatesUser? user = users.Find(e => e.Id == activity.AuthorID);
                if (user != null)
                {
                    CyclingMates.Models.ActivityDisplay activityDisplay = new CyclingMates.Models.ActivityDisplay(activity, user);
                    activitiesDisplay.Add(activityDisplay);
                }
            }


            return View(activitiesDisplay);
        }
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new CyclingMates.Models.ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

