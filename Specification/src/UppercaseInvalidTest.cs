namespace Specification
{
    internal class UppercaseInvalidTest
    {
        public UppercaseInvalidTest()
        {
            unit = new PasswordAuthenticator.Implementation();
            InitialiseInvalidPassword();
        }

        public string Test()
        {
            if (!unit.Uppercase())
            {
                return "";
            }

            return "uppercase invalid test failed\n";
        }

        private void InitialiseInvalidPassword()
        {
            string password = "nouppercasehere";

            for (int i = 0; i < password.Length; i++)
            {
                unit.Push(password[i]);
            }
        }

        private readonly PasswordAuthenticator.Facade unit;
    }
}
