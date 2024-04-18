using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CustomerController : Controller


    {
        List<Customer> customers = new List<Customer>
           {
                     new Customer { Id = 1, Name = "haya", Email ="haya@gmail.com"},
                     new Customer { Id = 2, Name = "amar", Email ="amar@gmail.com"},
                     new Customer { Id = 3, Name = "mimi", Email ="mimi@gmail.com"}


           };
        public IActionResult Index()
        {


            ViewData["data"] = customers;

            return View();
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Register(AddCustomer form) {
            if (ModelState.IsValid)
            {
                var name = form.Name;
                var email = form.Email;
                customers.Add(new Customer { Id = 1, Name = name, Email = email });
                return RedirectToAction("Index");
            }
            return View(form);
        
        }
    }

}