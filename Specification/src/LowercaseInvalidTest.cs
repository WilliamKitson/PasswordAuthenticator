namespace Specification
{
    internal class LowercaseInvalidTest
    {
        public LowercaseInvalidTest()
        {
            unit = new PasswordAuthenticator.Implementation();
            InitialiseInvalidPassword();
        }

        public string Test()
        {
            if (!unit.Lowercase())
            {
                return "";
            }

            return "lowercase invalid test failed\n";
        }

        private void InitialiseInvalidPassword()
        {
            string password = "NOLOWERCASEHERE";

            for (int i = 0; i < password.Length; i++)
            {
                unit.Push(password[i]);
            }
        }

        private readonly PasswordAuthenticator.Facade unit;
    }
}
