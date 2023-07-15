namespace Specification
{
    internal class LengthValidTest
    {
        private readonly PasswordAuthenticator.Facade unit;

        public LengthValidTest()
        {
            unit = new PasswordAuthenticator.Implementation();
            InitialiseValidPassword();
        }

        public string Test()
        {
            if (unit.Length())
            {
                return "";
            }

            return "length valid test failed\n";
        }

        private void InitialiseValidPassword()
        {
            string password = "thispasswordistoosho";

            for (int i = 0; i < password.Length; i++)
            {
                unit.Push(password[i]);
            }
        }
    }
}
