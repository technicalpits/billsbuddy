using billsbuddy.Data;
using billsbuddy.Models;
using Microsoft.AspNetCore.Mvc;

namespace billsbuddy.Controllers
{
    public class AmountTargetController : Controller
    {
        private readonly ApplicationDbContext _db;
        public AmountTargetController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Amount_target> objAmtTargetList = _db.Amount_target.ToList();
            return View(objAmtTargetList);
        }
    }
}
