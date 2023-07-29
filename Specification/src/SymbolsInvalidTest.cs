namespace Specification
{
    internal class SymbolsInvalidTest
    {
        public string Test()
        {
            PasswordAuthenticator.Facade unit = new PasswordAuthenticator.Implementation();

            if (!unit.Symbols("nosymbolshere"))
            {
                return "";
            }

            return "symbols invalid test failed\n";
        }
    }
}
