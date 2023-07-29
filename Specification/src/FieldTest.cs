namespace Specification
{
    internal class FieldTest
    {
        PasswordAuthenticator.Facade authenticator;

        public string Test(string input)
        {
            InitialisePassword(input);
            return GetDiagnostics(input);
        }

        private void InitialisePassword(string input)
        {
            authenticator = new PasswordAuthenticator.Implementation();

            for (int i = 0; i < input.Length; i++)
            {
                authenticator.Push(input[i]);
            }
        }

        private string GetDiagnostics(string input)
        {
            string output = "\n";

            output += LengthDiagnostics(input);
            output += NumeralsDiagnostics(input);
            output += SymbolsDiagnostics(input);
            output += LowercaseDiagnostics();
            output += UppercaseDiagnostics();

            return output;
        }

        private string LengthDiagnostics(string input)
        {
            if (!authenticator.Length(input))
            {
                return "length:\t\tfailed\n";
            }

            return "length:\t\tsuccess\n";
        }

        private string NumeralsDiagnostics(string input)
        {
            if (authenticator.Numerals(input))
            {
                return "numerals:\tsuccess\n";
            }

            return "numerals:\tfailed\n";
        }

        private string SymbolsDiagnostics(string input)
        {
            if (authenticator.Symbols(input))
            {
                return "symbols:\tsuccess\n";
            }

            return "symbols:\tfailed\n";
        }

        private string LowercaseDiagnostics()
        {
            if (authenticator.Lowercase())
            {
                return "lowercase:\tsuccess\n";
            }

            return "lowercase:\tfailed\n";
        }

        private string UppercaseDiagnostics()
        {
            if (authenticator.Uppercase())
            {
                return "uppercase:\tsuccess\n";
            }

            return "uppercase:\tfailed\n";
        }
    }
}
