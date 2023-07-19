namespace Specification
{
    internal class FieldTest
    {
        PasswordAuthenticator.Facade authenticator;

        public string Test()
        {
            InitialisePassword(System.Console.ReadLine());
            return GetDiagnostics();
        }

        private void InitialisePassword(string input)
        {
            authenticator = new PasswordAuthenticator.Implementation();

            for (int i = 0; i < input.Length; i++)
            {
                authenticator.Push(input[i]);
            }
        }

        private string GetDiagnostics()
        {
            string output = "\n";

            output += LengthDiagnostics();
            output += NumeralsDiagnostics();
            output += SymbolsDiagnostics();
            output += LowercaseDiagnostics();
            output += UppercaseDiagnostics();
            output += SupportedDiagnostics();

            return output;
        }

        private string LengthDiagnostics()
        {
            if (!authenticator.Length())
            {
                return "length: failed\n";
            }

            return "length: success\n";
        }

        private string NumeralsDiagnostics()
        {
            if (authenticator.Numerals())
            {
                return "numerals: success\n";
            }

            return "numerals: failed\n";
        }

        private string SymbolsDiagnostics()
        {
            if (authenticator.Symbols())
            {
                return "symbols: success\n";
            }

            return "symbols: failed\n";
        }

        private string LowercaseDiagnostics()
        {
            if (authenticator.Lowercase())
            {
                return "lowercase: success\n";
            }

            return "lowercase: failed\n";
        }

        private string UppercaseDiagnostics()
        {
            if (authenticator.Uppercase())
            {
                return "uppercase: success\n";
            }

            return "uppercase: failed\n";
        }

        private string SupportedDiagnostics()
        {
            if (authenticator.Supported())
            {
                return "supported: suuccess\n";
            }

            return "supported: failed\n";
        }
    }
}
