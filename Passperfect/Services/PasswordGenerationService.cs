using System.Security.Cryptography;

namespace Passperfect.Services
{
    public interface IPasswordGenerationService
    {
        string GenerateRandomPassword();
    }

    public class PasswordGenerationService : IPasswordGenerationService
    {
        public string GenerateRandomPassword()
        {
            byte[] randomBytes = RandomNumberGenerator.GetBytes(16);

            string base64String = Convert.ToBase64String(randomBytes);

            return base64String;
        }
    }
}
