using CanteenRFID.Web.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CanteenRFID.Web.Controllers;

[AllowAnonymous]
public class ReaderDisplayController : Controller
{
    private readonly ApplicationDbContext _db;

    public ReaderDisplayController(ApplicationDbContext db)
    {
        _db = db;
    }

    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var readers = await _db.Readers
            .Where(r => r.IsActive)
            .OrderBy(r => r.Name ?? r.ReaderId)
            .Select(r => new ReaderDisplayOption
            {
                ReaderId = r.ReaderId,
                DisplayName = r.Name ?? r.ReaderId,
                Location = r.Location
            })
            .ToListAsync();

        var model = new ReaderDisplayViewModel { Readers = readers };
        return View(model);
    }
}
