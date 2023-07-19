using System.Threading;

namespace Specification
{
    internal class SupportedValidTest
    {
        private PasswordAuthenticator.Facade unit;
        private readonly string password;

        public SupportedValidTest()
        {
            password += "1234567890";
            password += "!£$%^&*()-_=+[{]};:@#~,<.>/?";
            password += "qwertyuiopasdfghjklzxcvbnm";
            password += "QWERTYUIOPASDFGHJKLZXCVBN";
        }

        public string Test()
        {
            if (Success())
            {
                return "";
            }

            return "supported valid test failed\n";
        }

        private bool Success()
        {
            int successes = 0;

            for (int i = 0; i < password.Length; i++)
            {
                unit = new PasswordAuthenticator.Implementation();
                unit.Push(password[i]);
                successes += System.Convert.ToInt32(unit.Supported());
            }

            return successes == password.Length;
        }
    }
}
