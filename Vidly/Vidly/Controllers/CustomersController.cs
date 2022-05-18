using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using System.Data.Entity;

namespace Vidly.Controllers
{
    //decides what customer page to navigate to and what to do on load
    public class CustomersController : Controller
    {

        //database context
        private ApplicationDbContext _context;
        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }


        // navigate using controller
        // GET: Customers
        public ActionResult Index()
        {
            //include the membership type using include
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();
            return View(customers);
        }

        // GET: customer by id
        public ActionResult Details(int? id)
        {
            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(x => x.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }
    }
}