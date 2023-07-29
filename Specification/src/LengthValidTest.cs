namespace Specification
{
    internal class LengthValidTest
    {
        public string Test()
        {
            PasswordAuthenticator.Facade unit = new PasswordAuthenticator.Implementation();

            if (unit.Length("thispasswordistoosho"))
            {
                return "";
            }

            return "length valid test failed\n";
        }
    }
}
