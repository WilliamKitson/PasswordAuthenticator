namespace Specification
{
    internal class NumeralsInvalidTest
    {
        public string Test()
        {
            PasswordAuthenticator.Facade unit = new PasswordAuthenticator.Implementation();
            string password = "nonumeralshere";

            for (int i = 0; i < password.Length; i++)
            {
                unit.Push(password[i]);
            }

            if (!unit.Numerals())
            {
                return "";
            }

            return "numerals invalid test failed\n";
        }
    }
}
