using app_models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BillingManagement.Business
{
    public class InvoicesDataService : IDataService<Invoice>
    {

        readonly List<Invoice> invoices;

        List<Customer> _customers = new CustomersDataService().GetAll().ToList();

        public InvoicesDataService(){

            initValues();

        }

        public IEnumerable<Invoice> GetAll()
        {
            foreach (Invoice i in invoices)
            {
                yield return i;
            }
        }

        private void initValues()
        {
            Random rnd = new Random();


            foreach (var customer in _customers)
            {
                int nbInvoices = rnd.Next(10);

                for (int i = 0; i < nbInvoices; i++)
                {
                    var invoice = new Invoice(customer);
                    invoice.SubTotal = rnd.NextDouble() * 100 + 50;
                    customer.Invoices.Add(invoice);
                    invoices.Add(invoice);
                }
            }
        }

    }
}
