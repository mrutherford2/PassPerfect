using Microsoft.AspNetCore.Identity;

namespace Passperfect.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string PgpPublicKey { get; set; }
    }
}
