namespace Specification
{
    internal class LengthInvalidTest
    {
        public string Test()
        {
            PasswordAuthenticator.Facade unit = new PasswordAuthenticator.Implementation();

            if (!unit.Length("thispasswordistoosh"))
            {
                return "";
            }

            return "length invalid test failed\n";
        }
    }
}
