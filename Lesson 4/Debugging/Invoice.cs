using System;
using System.Linq;
using System.Collections.Generic;

namespace Debugging
{
    public class Invoice
    {
        public int InvoiceNumber { get; set; }
        public string InvoiceCurrency { get; set; }
        public List<InvoiceDetails> Details { get; set; }
        public int CustomerID { get; set; }
        public int AddressID { get; set; }
        public decimal InvoiceAmount => Details.Sum(d => d.TotalPrice);

        public static List<Invoice> GetInvoices() {
            var invoices = new List<Invoice>();
            Invoice inv = new Invoice() {
                InvoiceNumber = 1,
                InvoiceCurrency = "USD",
                CustomerID = 1,
                AddressID = 1,
                Details = new List<InvoiceDetails>()
            };
            inv.Details.Add(new InvoiceDetails(){
                Line = 1,
                Quantity = 3,
                UnitPrice = 30.26m,
                Description = "Widgets",
                QuantityType = "Pcs"
            });
            inv.Details.Add(new InvoiceDetails(){
                Line = 2,
                Quantity = 2,
                UnitPrice = 12.99m,
                Description = "Gears",
                QuantityType = "Pcs"
            });
            inv.Details.Add(new InvoiceDetails() {
                Line = 3,
                Quantity = 5,
                UnitPrice = 4.99m,
                Description = "Lag Bolt",
                QuantityType = "Pcs"
            });
            invoices.Add(inv);
            inv = new Invoice() {
                InvoiceNumber = 2,
                InvoiceCurrency = "EUR",
                CustomerID = 3,
                AddressID = 2,
                Details = new List<InvoiceDetails>()
            };
            inv.Details.Add(new InvoiceDetails(){
                Line = 1,
                Quantity = 30,
                UnitPrice = 0.99m,
                Description = "2.5in Wood Screw",
                QuantityType = "Pcs"
            });
            inv.Details.Add(new InvoiceDetails() {
                Line = 2,
                Quantity = 600,
                UnitPrice = 0.20m,
                Description = "1/8in Nylon Cord",
                QuantityType = "Inches"
            });
            invoices.Add(inv);
            inv = new Invoice() {
                InvoiceNumber = 3,
                InvoiceCurrency = "CBP",
                CustomerID = 4,
                AddressID = 2,
                Details = new List<InvoiceDetails>()
            };
            inv.Details.Add(new InvoiceDetails(){
                Line = 1,
                Quantity = 1,
                UnitPrice = 39.99m,
                Description = "Hand Drill",
                QuantityType = "Pcs"
            });
            invoices.Add(inv);
            inv = new Invoice() {
                InvoiceNumber = 4,
                InvoiceCurrency = "GBP",
                CustomerID = 4,
                AddressID = 2,
                Details = new List<InvoiceDetails>()
            };
            inv.Details.Add(new InvoiceDetails(){
                Line = 1,
                Quantity = 1,
                UnitPrice = 22.99m,
                Description = "Saw Blade",
                QuantityType = "Pcs"
            });
            invoices.Add(inv);
            inv = new Invoice() {
                InvoiceNumber = 5,
                InvoiceCurrency = "USD",
                CustomerID = 5,
                AddressID = 12,
                Details = new List<InvoiceDetails>()
            };
            inv.Details.Add(new InvoiceDetails(){
                Line = 1,
                Quantity = 2,
                UnitPrice = 7.49m,
                Description = "Phillips Head Screwdriver",
                QuantityType = "Pcs"
            });
            invoices.Add(inv);
            return invoices;
        }
    }

    public class InvoiceDetails
    {
        public int Line { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalPrice => UnitPrice * Quantity; 
        public string Description { get; set; }
        public string QuantityType { get; set; }
    }

    
}