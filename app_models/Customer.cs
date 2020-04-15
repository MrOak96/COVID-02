using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace app_models
{
    public class Customer : INotifyPropertyChanged
    {
        private string name;
        private string lastName;
        private string address;
        private string city;
        private string province;
        private string postalCode;
        private string picturePath;
        private string contactInfo;

        public List<Invoice> Invoices;

        public Customer()
        {
            picturePath = "images/user.png";
        }

        public ObservableCollection<ContactInfo> ContactInfos { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
