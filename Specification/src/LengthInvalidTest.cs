namespace Specification
{
    internal class LengthInvalidTest
    {
        public string Test()
        {
            string password = "thispasswordistoosh";
            PasswordAuthenticator.Facade unit = new PasswordAuthenticator.Implementation();

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
    }
}
