namespace Specification
{
    internal class UppercaseInvalidTest
    {
        public string Test()
        {
            PasswordAuthenticator.Facade unit = new PasswordAuthenticator.Implementation();

            if (!unit.Uppercase("nouppercasehere"))
            {
                return "";
            }

            return "uppercase invalid test failed\n";
        }
    }
}
