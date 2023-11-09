using billsbuddy.Data;
using billsbuddy.Models;
using Microsoft.AspNetCore.Mvc;

namespace billsbuddy.Controllers
{
    public class AmountEnterFormController : Controller
    {
        private readonly ApplicationDbContext _db;
        public AmountEnterFormController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            Amount_enter amtEnter = _db.Amount_enter.FirstOrDefault(); // You might want to implement proper logic to retrieve the appropriate object

            // Pass the single Net_salary object to the view
            return View(amtEnter);
        }

        [HttpPost]
        public IActionResult Index(Amount_enter obj)
        {
            if (ModelState.IsValid)
            {
                // Store the input in the Net_salary table
                _db.Amount_enter.Add(obj);
                _db.SaveChanges();

                // Retrieve the latest record from the amount_target table
                Amount_target latestRecord = _db.Amount_target.OrderByDescending(a => a.Id_amt_target).FirstOrDefault();
                //// Retrieve the user from the Users table (assuming you have a method to find or create a user)
                //Users user = _db.Users.FirstOrDefault(u => u.Id_user == userId);

                if (latestRecord != null)
                {
                    // You can use the latestRecord object as needed in your view or logic
                    Amount_result amountResultObj = new Amount_result
                    {
                        grocery = latestRecord.grocery - obj.grocery,
                        eat_outside = latestRecord.eat_outside - obj.eat_outside,
                        emergency_money = latestRecord.emergency_money - obj.emergency_money,
                        house = latestRecord.house - obj.house,
                        donation = latestRecord.donation - obj.donation,
                        petrol = latestRecord.petrol - obj.petrol,
                        utility = latestRecord.utility - obj.utility,
                        car = latestRecord.car - obj.car,
                        saving = latestRecord.saving - obj.saving,
                        Id_user = 1,
                        //Users = user,
                    };
                    // Store the calculated value in the Amount_target table
                    _db.AmountResults.Add(amountResultObj);
                    _db.SaveChanges();
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
                
                // Redirect to the same action to refresh the view
                return RedirectToAction("Index", "AmountResult");
            }

            // If ModelState is not valid, return the same view with validation errors
            return View(obj);
        }
    }
}
