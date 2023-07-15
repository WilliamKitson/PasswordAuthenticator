namespace Specification
{
    internal class LengthInvalidTest
    {
        public LengthInvalidTest()
        {
            unit = new PasswordAuthenticator.Implementation();
            InitialiseInvalidPassword();
        }

        public string Test()
        {
            if (!unit.Length())
            {
                return "";
            }

            return "length invalid test failed\n";
        }

        private void InitialiseInvalidPassword()
        {
            string password = "thispasswordistoosh";

            for (int i = 0; i < password.Length; i++)
            {
                unit.Push(password[i]);
            }
        }

        private readonly PasswordAuthenticator.Facade unit;
    }
}
