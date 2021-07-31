using MVC_FIRST_PROJECT.Models;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC_FIRST_PROJECT.ViewModels;

namespace MVC_FIRST_PROJECT.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }
        
        // GET: Customers
        public ViewResult Index()
        {
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();
            return View(customers);
        }
        public ActionResult CreateNewCustomer()
        {
            return View();
        }

        public ActionResult CreateCustomer()
        {
            var membershipTypes = _context.MembershipTypes.ToList();
            var viewModel = new NewCustomerViewModel
            {
                Customer = new Customer(),
                MembershipTypes = membershipTypes
            };

            return View("CreateCustomer", viewModel);
        }
        //[HttpPost]
        //public ActionResult CreateCustomer(Customer customer)
        //{
        //    return View();
        //}
        public ActionResult Details(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
    }
}