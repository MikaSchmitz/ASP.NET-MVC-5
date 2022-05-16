using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    //decides what customer page to navigate to and what to do on load
    public class CustomersController : Controller
    {
        IEnumerable<Customer> customers = new List<Customer>()
        {
            new Customer() { Id=1, FirstName = "Mika", LastName = "Schmitz" },
            new Customer() { Id=2, FirstName = "Melissa", LastName = "Jagers" }
        };

        // GET: Customers
        public ActionResult Index()
        {
            return View(customers);
        }

        // GET: customer by id
        public ActionResult Details(int? id)
        {
            foreach (Customer customer in customers.Where(customer => customer.Id == id))
            {
                return View(customer);
            }
            return HttpNotFound();
        }
    }
}