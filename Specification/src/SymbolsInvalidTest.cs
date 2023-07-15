namespace Specification
{
    internal class SymbolsInvalidTest
    {
        private readonly PasswordAuthenticator.Facade unit;

        public SymbolsInvalidTest()
        {
            unit = new PasswordAuthenticator.Implementation();
            InitialiseInvalidPassword();
        }

        public string Test()
        {
            if (!unit.Symbols())
            {
                return "";
            }

            return "symbols invalid test failed\n";
        }

        private void InitialiseInvalidPassword()
        {
            string password = "nosymbolshere";

            for (int i = 0; i < password.Length; i++)
            {
                unit.Push(password[i]);
            }
        }
    }
}
