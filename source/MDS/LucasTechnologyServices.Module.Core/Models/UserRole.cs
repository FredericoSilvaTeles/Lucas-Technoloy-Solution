using Microsoft.AspNetCore.Identity;

namespace LucasTechnologyServices.Module.Core.Models
{
    public class UserRole : IdentityUserRole<long>
    {
        public override long UserId { get; set; }
        public User User { get; private set; }
        public override long RoleId { get; set; }
        public Role Role { get; private set; }
    }
}
