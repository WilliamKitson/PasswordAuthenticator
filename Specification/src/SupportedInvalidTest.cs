namespace Specification
{
    internal class SupportedInvalidTest
    {
        private readonly PasswordAuthenticator.Facade unit;

        public SupportedInvalidTest()
        {
            unit = new PasswordAuthenticator.Implementation();
            InitialiseInvalidPassword();
        }

        public string Test()
        {
            if (!unit.Supported())
            {
                return "";
            }

            return "Supported invalid test failed\n";
        }

        private void InitialiseInvalidPassword()
        {
            string password = "😀";

            for (int i = 0; i < password.Length; i++)
            {
                unit.Push(password[i]);
            }
        }
    }
}
