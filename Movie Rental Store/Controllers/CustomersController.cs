using Movie_Rental_Store.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Movie_Rental_Store.Controllers
{
    public class CustomersController : Controller
    {
         List<Customer> customers = new List<Customer>
            {
                new Customer{Id = 1, Name = "John Smiths"},
                new Customer{Id = 2, Name = "Mary Williams"}
            };

        // GET: Customers
        public ActionResult Index()
        {
            
            return View(customers);
        }

        public ActionResult Details(int id)
        {
            try
            {
                var customer = customers.ElementAt(id - 1);
                return View(customer);
            }
            catch (Exception e)
            {

                return HttpNotFound();
            }
                
     
          
        }
    }
}