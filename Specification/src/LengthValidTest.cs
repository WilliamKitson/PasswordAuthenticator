namespace Specification
{
    internal class LengthValidTest
    {
        public LengthValidTest()
        {
            unit = new PasswordAuthenticator.Implementation();
            string password = "thispasswordistoosho";

            for (int i = 0; i < password.Length; i++)
            {
                unit.Push(password[i]);
            }
        }

        public string Test()
        {
            if (unit.Length())
            {
                return "";
            }

            return "length valid test failed\n";
        }

        private PasswordAuthenticator.Facade unit;
    }
}
