using Microsoft.AspNetCore.Mvc;

namespace UzMovie.Controllers;

public class UserController : Controller
{
    private readonly DataContext dbContext;

    public UserController(DataContext dataContext)
    {
        this.dbContext=dataContext;
    }
    public IActionResult Index()
    {
        List<User> users = new List<User>();
        return View(users);
    }
    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Store()
    {
        return RedirectToAction ("Index");
    }
    

}