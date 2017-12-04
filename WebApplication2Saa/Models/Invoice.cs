using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace WebApplication2Saa.Models
{
    public class Invoice
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime DateInvoice { get; set; }
        public decimal Amount { get; set; }

        public virtual ICollection<InvoiceDetail> InvoiceDetails { get; set; }

        public Invoice()
        {
            InvoiceDetails = new List<InvoiceDetail>()
            {
                new InvoiceDetail()
            };
        }
    }
}