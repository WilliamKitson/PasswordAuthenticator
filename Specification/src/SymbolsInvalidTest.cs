namespace Specification
{
    internal class SymbolsInvalidTest
    {
        public string Test()
        {
            PasswordAuthenticator.Facade unit = new PasswordAuthenticator.Implementation();
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
    }
}
