namespace Specification
{
    internal class NumeralsInvalidTest
    {
        public NumeralsInvalidTest()
        {
            unit = new PasswordAuthenticator.Implementation();
            InitialiseInvalidPassword();
        }

        public string Test()
        {
            if (!unit.Numerals())
            {
                return "";
            }

            return "numerals invalid test failed\n";
        }

        private void InitialiseInvalidPassword()
        {
            string password = "nonumeralshere";

            for (int i = 0; i < password.Length; i++)
            {
                unit.Push(password[i]);
            }
        }

        private readonly PasswordAuthenticator.Facade unit;
    }
}
