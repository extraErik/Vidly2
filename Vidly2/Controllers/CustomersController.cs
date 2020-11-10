using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly2.Models;

namespace Vidly2.Controllers
{
    public class CustomersController : Controller
    {
        public ActionResult Index()
        {

            var customers = new List<Customer>
            {
                new Customer { Id = 1, Name = "Customer One" },
                new Customer { Id = 2, Name = "Customer Two" }
            };

            return View(customers);
        }

        [Route("customers/details/{id}")]
        public ActionResult Details(int id)
        {
            var customers = new List<Customer>
            {
                new Customer { Id = 1, Name = "Customer One" },
                new Customer { Id = 2, Name = "Customer Two" }
            };

            var specifiedCustomer = customers.Find(item => item.Id == id);
            if (specifiedCustomer != null)
            {
                return View(specifiedCustomer);
            }
            else
            {
                return HttpNotFound();
            }

        }
    }
}