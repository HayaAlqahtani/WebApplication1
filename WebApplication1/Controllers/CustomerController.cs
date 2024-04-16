using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CustomerController : Controller


    {
        public IActionResult Index()
        {

          List<Customer> customers = new List<Customer>
           {
                     new Customer { Id = 1, Name = "haya", Email ="haya@gmail.com"}
           };
            ViewData["data"] = customers;

            return View();
        }
    }
}
