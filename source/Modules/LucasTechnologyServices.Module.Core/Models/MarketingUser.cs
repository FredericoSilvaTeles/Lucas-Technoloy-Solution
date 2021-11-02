namespace LucasTechnologyServices.Module.Core.Models
{
    public class MarketingUser : Entity
    {
        public MarketingUser
        (
            string firstName,
            string middleName,
            string lastName,
            string marketingEmail,
            string login,
            string password)
        {
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            MarketingEmail = marketingEmail;
            Login = login;
            Password = password;
               
        }
                public string FirstName { get; private set; }
        public string MiddleName { get; private set; }
        public string LastName { get; private set;}
        public string MarketingEmail { get; private set; }
        public string Login { get; private set; }
        public string Password { get; private set; }
        
     
        
        
        
    }
        
        



        
        
        
        
        
        
}