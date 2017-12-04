using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2Saa.Models
{
    public class InvoiceDetail
    {
        public int Id { get; set; }

        public Invoice Invoice { get; set; }

        //public int Id_Article { get; set; }
        public Article Article { get; set; }

        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public InvoiceDetail()
        {

        }

        public InvoiceDetail(int Id, Invoice Invoice, Article Article, int Quantity, decimal Price)
        {
            this.Id = Id;
            this.Invoice = Invoice;
            this.Article = Article;
            this.Quantity = Quantity;
            this.Price = Price;
        }
    }
}