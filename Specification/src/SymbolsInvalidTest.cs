namespace Specification
{
    internal class SymbolsInvalidTest
    {
        public SymbolsInvalidTest()
        {
            unit = new PasswordAuthenticator.Implementation();
        }

        public string Test()
        {
            string password = "nosymbolshere";

            for (int i = 0; i < password.Length; i++)
            {
                unit.Push(password[i]);
            }

            if (!unit.Symbols())
            {
                return "";
            }

            return "symbols invalid test failed\n";
        }

        private readonly PasswordAuthenticator.Facade unit;
    }
}
