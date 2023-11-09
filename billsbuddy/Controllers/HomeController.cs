using billsbuddy.Data;
using billsbuddy.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace billsbuddy.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _db;

        public HomeController(ILogger<HomeController> logger, ApplicationDbContext db)
        {
            _logger = logger;
            _db = db;
        }
        
        public IActionResult Index()
        {
            //List<Net_salary> objNetsalaryList = _db.Net_Salary.ToList();
            //return View(objNetsalaryList);
            // Retrieve a single Net_salary object from your data source
            Net_salary netSalary = _db.Net_Salary.FirstOrDefault(); // You might want to implement proper logic to retrieve the appropriate object

            // Pass the single Net_salary object to the view
            return View(netSalary);
        }
        [HttpPost]
        public IActionResult Index(Net_salary obj)
        {
            if (ModelState.IsValid)
            {
                // Calculate grocery value
                double calculatedValue10 = obj.amount * 0.1;
                double calculatedValue15 = obj.amount * 0.15;

                // Store the input in the Net_salary table
                _db.Net_Salary.Add(obj);
                _db.SaveChanges();

                // Create a new Amount_target object with the calculated grocery value
                Amount_target amountTargetObj = new Amount_target
                {
                    grocery = calculatedValue10,
                    emergency_money = calculatedValue10,
                    eat_outside = calculatedValue15,
                    house = calculatedValue10,
                    donation = calculatedValue15,
                    petrol = calculatedValue10,
                    utility = calculatedValue10,
                    car = calculatedValue10,
                    saving = calculatedValue10,
                    Id_user = 1,
                    // Set other properties as needed
                };

                // Store the calculated value in the Amount_target table
                _db.Amount_target.Add(amountTargetObj);
                _db.SaveChanges();

                return RedirectToAction("Index", "AmountTarget");
            }

            // If ModelState is not valid, return the same view with validation errors
            return View(obj);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}