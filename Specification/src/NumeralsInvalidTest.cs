namespace Specification
{
    internal class NumeralsInvalidTest
    {
        public NumeralsInvalidTest()
        {
            unit = new PasswordAuthenticator.Implementation();
            string password = "nonumeralshere";

            for (int i = 0; i < password.Length; i++)
            {
                unit.Push(password[i]);
            }
        }

        public string Test()
        {
            if (!unit.Numerals())
            {
                return "";
            }

            return "numerals invalid test failed\n";
        }

        private PasswordAuthenticator.Facade unit;
    }
}
