using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using tp.Data;
using tp.Models;

namespace tp.Controllers
{
    public class MembershipTypeController : Controller
    {


        private readonly ILogger<Movies> _logger;
        private readonly ApplicationDBContext _db;
        public MembershipTypeController(ApplicationDBContext db, ILogger<Movies> logger)
        {
            _logger = logger;
            _db = db;
        }

        //********************************************   GET  MembershipType    ******************************************************
        public IActionResult Index()
        {


            var MembershipTypes = _db.Membershiptype.ToList();
            return View(MembershipTypes);
        }
        //********************************************   ADD MembershipType    ******************************************************
        [HttpGet]

        public IActionResult Create()
        {
            return View();
        }
            [HttpPost]
        [ValidateAntiForgeryToken]

        public IActionResult Create(Membershiptype mem)
        {
            _logger.LogInformation("inside the create action");

            if (!ModelState.IsValid)
            {
                
                _logger.LogInformation("invalid model statae");

                foreach (var key in ModelState.Keys)
                {
                    foreach (var error in ModelState[key].Errors)
                    {
                        _logger.LogError($"Validation Error - Property: {key}, Error: {error.ErrorMessage}");
                    }
                }

                return View();
            }

            _logger.LogInformation("valid model statae");

            //c.Id = new Guid();
            _db.Membershiptype.Add(mem);
            _db.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}
