using System;
using System.ComponentModel;

namespace app_models
{
    public class Invoice : INotifyPropertyChanged
    {

        public int InvoiceId { get; private set; }
        public readonly DateTime CreationDateTime;
        public Customer customer;

        public event PropertyChangedEventHandler PropertyChanged;

        public double SubTotal { get; set; }
        public double FedTax {

            get { return SubTotal * 0.05; }
            set { }

        }
        public double ProvTax {

            get { return SubTotal * 0.09975; }
            set { }

        }
        public double Total {

            get { return SubTotal + FedTax + ProvTax; }
            set { }

        }

        public Invoice()
        {

            CreationDateTime = DateTime.Now;

        }

        public Invoice(Customer c)
        {

            customer = c;
            CreationDateTime = DateTime.Now;

        }


    }
}
