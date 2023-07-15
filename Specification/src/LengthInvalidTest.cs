namespace Specification
{
    internal class LengthInvalidTest
    {
        public LengthInvalidTest()
        {
            unit = new PasswordAuthenticator.Implementation();
        }

        public string Test()
        {
            string password = "thispasswordistoosh";
            for (int i = 0; i < password.Length; i++)
            {
                unit.Push(password[i]);
            }

            if (!unit.Length())
            {
                return "";
            }

            return "length invalid test failed\n";
        }

        private PasswordAuthenticator.Facade unit;
    }
}
