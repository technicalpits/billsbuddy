using billsbuddy.Data;
using billsbuddy.Models;
using Microsoft.AspNetCore.Mvc;

namespace billsbuddy.Controllers
{
    public class AmountResultController : Controller
    {
        private readonly ApplicationDbContext _db;
        public AmountResultController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Amount_result> objAmtResultList = _db.AmountResults.ToList();
            return View(objAmtResultList);
        }
    }
}
