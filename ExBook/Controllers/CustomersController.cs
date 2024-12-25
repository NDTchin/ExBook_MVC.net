using ExBook.Data;
using ExBook.Models;
using Microsoft.AspNetCore.Mvc;
namespace ExBook.Controllers;

public class CustomersController : Controller
{
    private readonly ApplicationDbContext _context;

    public CustomersController(ApplicationDbContext context)
    {
        _context = context;
    }

    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Register([Bind("FullName, PhoneNumber")] Customer customer)
    {
        if (ModelState.IsValid)
        {
            customer.Registration = DateTime.Now; 
            _context.Add(customer);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "ComicBooks");
        }
        return View(customer);
    }
}
