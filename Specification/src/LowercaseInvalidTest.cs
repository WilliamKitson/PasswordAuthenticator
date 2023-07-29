namespace Specification
{
    internal class LowercaseInvalidTest
    {
        public string Test()
        {
            PasswordAuthenticator.Facade unit = new PasswordAuthenticator.Implementation();

            if (!unit.Lowercase("NOLOWERCASEHERE"))
            {
                return "";
            }

            return "lowercase invalid test failed\n";
        }
    }
}
