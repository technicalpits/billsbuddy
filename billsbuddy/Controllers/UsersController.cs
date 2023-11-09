using billsbuddy.Data;
using billsbuddy.Models;
using Microsoft.AspNetCore.Mvc;

namespace billsbuddy.Controllers
{
    public class UsersController : Controller
    {
        private readonly ApplicationDbContext _db;
        public UsersController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Users> objUsersList = _db.Users.ToList();
            return View(objUsersList);
        }
    }
}
