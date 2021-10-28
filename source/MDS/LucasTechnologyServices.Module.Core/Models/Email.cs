using LucasTechnologyServices.Module.Infrastructure.Models;

namespace LucasTechnologyServices.Module.Core.Models
{
    public class Email : EntityBase
    {
        public Email(long id, string emailAddress)
        {
            EmailAddress = emailAddress;
        }
        public string EmailAddress { get; set; }
    }
}
