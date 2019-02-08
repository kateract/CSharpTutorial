using System;
using System.Threading.Tasks;
using System.Linq;
using ForeignExchange;
using Debugging;

namespace Debugging
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var invoices = Invoice.GetInvoices();
            var rates =  await ExchangeRates.GetRatesForBaseAsync("USD");
            invoices.Select(i => new { invoice = i, amtInUSD = (rates.rates[i.InvoiceCurrency]) * i.InvoiceAmount}).ToList()
                .ForEach(i => Console.WriteLine($"Invoice Number {i.invoice.InvoiceNumber} - {i.invoice.InvoiceAmount}({i.invoice.InvoiceCurrency:F2}) = {i.amtInUSD:F2}(USD)"));
            Console.ReadLine();
        }
    }
}
