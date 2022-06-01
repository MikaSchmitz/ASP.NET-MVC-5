using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;
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

        // redirect to blank form page
        public ActionResult New()
        {
            var membershipTypes = _context.MembershipTypes.ToList();
            var viewModel = new CustomerFormViewModel
            {
                Customer = new Customer(),
                MembershipTypes = membershipTypes
            };
            return View("Form", viewModel);
        }

        // CREATE: new user. make sure it can only be called using a post (always do this when modifying data)
        [HttpPost]
        public ActionResult Save(Customer customer)
        {
            //return view if modelstate is not valid
            if (!ModelState.IsValid)
            {
                var viewModel = new CustomerFormViewModel
                {
                    Customer = customer,
                    MembershipTypes = _context.MembershipTypes.ToList()
                };
                return View("Form", viewModel);
            }

            //create new
            if (customer.Id == 0)
                _context.Customers.Add(customer);
            //save changes to existing
            else
            {
                var customerInDb = _context.Customers.Single(x => x.Id == customer.Id);
                customerInDb.FirstName = customer.FirstName;
                customerInDb.LastName = customer.LastName;
                customerInDb.Birthdate = customer.Birthdate;
                customerInDb.MembershipTypeId = customer.MembershipTypeId;
                customerInDb.IsSubscribedToNewsletter = customer.IsSubscribedToNewsletter;
            }
            _context.SaveChanges();

            //redirect back to index
            return RedirectToAction("Index", "Customers");
        }

        //redirect to form page with customer selected
        public ActionResult Edit(int id)
        {
            var customer = _context.Customers.SingleOrDefault(x => x.Id == id);

            if (customer == null)
                return HttpNotFound();

            var viewModel = new CustomerFormViewModel
            {
                Customer = customer,
                MembershipTypes = _context.MembershipTypes.ToList()
            };

            return View("Form", viewModel);
        }
    }
}