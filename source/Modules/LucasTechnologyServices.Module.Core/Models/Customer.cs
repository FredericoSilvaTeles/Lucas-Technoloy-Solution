using LucasTechnologyService.Infrastructure.Models;
using System.Collections.Generic;
using System.Linq;

namespace LucasTechnologyServices.Module.Core.Models
{
    public class Customer : EntityBase
    {
        private readonly IList<Address> _addresses;

        public Customer(string name, Document document, Email email, string phone)
        {
            Name = name;
            Document = document;
            Email = email;
            Phone = phone;
            _addresses = new List<Address>();
        }

        public string Name { get; private set; }
        public Document Document { get; private set; }
        public Email Email { get; private set; }
        public string Phone { get; private set; }
        public IReadOnlyCollection<Address> Addresses => _addresses.ToArray();

        public void AddAddress(Address address)
        {
            _addresses.Add(address);
        }

        public override string ToString()
        {
            return Name.ToString();
        }



    }
}