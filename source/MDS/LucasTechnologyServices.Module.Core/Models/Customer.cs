using LucasTechnologyServices.Module.Infrastructure.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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


        [StringLength(450)]
        public string Name { get; set; }

        [Required(ErrorMessage = "The {0} field is required.")]
        public Document Document { get; set; }

        public Email Email { get; set; }

        [Required(ErrorMessage = "The {0} field is required.")]
        [StringLength(21)]
        public string Phone { get; set; }
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
