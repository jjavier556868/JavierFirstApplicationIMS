using Microsoft.AspNetCore.Identity;

namespace IMS.Domain.Models
{
    public class AppUser:IdentityUser
    {
        public string FullName { get; set; }

        public Profile Profile { get; set; }
    }
}