using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customers = getCustomers();

            return View(customers);
        }

        public ActionResult Details(int id)
        {
            var customer = getCustomers().SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }

        public IEnumerable<Customer> getCustomers()
        {
            return new List<Customer>
            {
                new Customer { Id = 1, Name = "Andrea Contreras"},
                new Customer { Id = 2, Name = "Atahualpa Silva"},
                new Customer { Id = 3, Name = "Brayan Padrino"},
                new Customer { Id = 4, Name = "José Recchiuti"},
                new Customer { Id = 5, Name = "Fernando Obregón"}
            };
        }
    }
}