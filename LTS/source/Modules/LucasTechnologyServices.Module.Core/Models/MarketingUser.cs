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
                public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set;}
        public string MarketingEmail { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        
     
        
        
        
    }
        
        



        
        
        
        
        
        
}