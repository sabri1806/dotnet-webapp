using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2Saa.Models;

namespace WebApplication2Saa.Controllers
{
    public class InvoiceController : Controller
    {

        private DataContext context = new DataContext();

       /* public InvoiceController(DataContext context)
        {
            this.context = context;
        }*/

        public InvoiceController()
        {

        }

        [HttpGet]
        public ActionResult AddInvoice()
        {
            ViewData["Message"] = "Add new invoices.";
            ViewBag.Articles = context.Articles;
            
            return View(new Invoice());
        }

        [HttpPost]
        public ActionResult AddInvoice(Invoice invoice)
        {
            ViewData["Message"] = "Here you can put new invoices.";

            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Check the inputs please.");
                return View();
            }
            invoice.DateInvoice = DateTime.Now;
            context.Invoices.Add(invoice);
            context.SaveChanges();

            ModelState.Clear();
            invoice = new Invoice();

            ViewBag.Articles = context.Articles;
            return View(invoice);
        }



    }
}