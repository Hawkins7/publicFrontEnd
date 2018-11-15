using System;
using System.Collections.Generic;

namespace publicFrontEnd.Models
{
    public class Invoice
    {
        public string Id { get; set; }
        public string InvoiceID { get; set; }
        public string InvoiceDate { get; set; }
        public string OrderRef { get; set; }
        public string OrderDate { get; set; }
        public string OrderTotal { get; set; }
        public string CustomerID { get; set; }
        public string CustoRef { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public string InvoiceTotal { get; set; }
        public Boolean InvoicePending { get; set; } = true;
        public string CustomerLastName { get; set; }

    }
}
