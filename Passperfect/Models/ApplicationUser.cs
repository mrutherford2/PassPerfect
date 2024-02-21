using Microsoft.AspNetCore.Identity;

namespace Passperfect.Models
{
    public class ApplicationUser : IdentityUser
    {
        //Stores string value of pgp public key
        public string PgpPublicKey { get; set; }
    }
}
