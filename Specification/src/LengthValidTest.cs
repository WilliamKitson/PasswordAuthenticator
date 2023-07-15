namespace Specification
{
    internal class LengthValidTest
    {
        public string Test()
        {
            PasswordAuthenticator.Facade unit = new PasswordAuthenticator.Implementation();
            string password = "thispasswordistoosho";

            for (int i = 0; i < password.Length; i++)
            {
                unit.Push(password[i]);
            }

            if (unit.Length())
            {
                return "";
            }

            return "length valid test failed\n";
        }
    }
}
