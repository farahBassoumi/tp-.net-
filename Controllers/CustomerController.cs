using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using tp.Data;
using tp.Models;
// the membership does not add in the customer as an attribute
namespace tp.Controllers
{
    public class CustomerController : Controller
    {


        private readonly ILogger<Movies> _logger;
        private readonly ApplicationDBContext _db;
        public CustomerController(ApplicationDBContext db, ILogger<Movies> logger)
        {
            _logger = logger;
            _db = db;
        }

        //********************************************   GET  CUSTOMERS    ******************************************************
        public IActionResult Index()
        {


            var customers = _db.Customers.ToList();
            return View(customers);
        }
   
      

        //********************************************   CREATE  CUSTOMERS    ******************************************************


        [HttpGet]
        public IActionResult Create()
        {
            var members = _db.Membershiptype.ToList();

            ViewBag.member = members.Select(m => new SelectListItem()
            {
                Text = m.Name,
                Value = m.Id.ToString()
            });

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        
        public IActionResult Create(Customers c)
        {
            _logger.LogInformation("inside the create action");

            if (!ModelState.IsValid)
            {
                var members = _db.Membershiptype.ToList();
                ViewBag.member = members.Select(m => new SelectListItem()
                {
                    Text = m.Name,
                    Value = m.Id.ToString()
                });
                _logger.LogInformation("invalid model statae");

                /*  foreach (var key in ModelState.Keys)
                  {
                      foreach (var error in ModelState[key].Errors)
                      {
                          _logger.LogError($"Validation Error - Property: {key}, Error: {error.ErrorMessage}");
                      }
                  }*/

                ViewBag.Errors = ModelState.Values
              .SelectMany(v => v.Errors)
              .Select(e => e.ErrorMessage)
              .ToList();

                return View();
            }

            _logger.LogInformation("valid model statae");

            //c.Id = new Guid();
            _db.Customers.Add(c);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }



        // GET: CustomerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CustomerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
