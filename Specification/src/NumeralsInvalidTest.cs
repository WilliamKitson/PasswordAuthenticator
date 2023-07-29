namespace Specification
{
    internal class NumeralsInvalidTest
    {
        public string Test()
        {
            PasswordAuthenticator.Facade unit = new PasswordAuthenticator.Implementation();

            if (!unit.Numerals("nonumeralshere"))
            {
                return "";
            }

            return "numerals invalid test failed\n";
        }
    }
}
