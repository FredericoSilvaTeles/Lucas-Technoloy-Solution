using LucasTechnologyService.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucasTechnologyServices.Module.Core.Models
{
    public class Email : EntityBase
    {
        
        public Email(long id, string emailAddress)
        {
            EmailAddress = emailAddress;
        }
        public string EmailAddress { get; private set; }
    }
}
