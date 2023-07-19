namespace Specification
{
    internal class FieldTest
    {
        PasswordAuthenticator.Facade authenticator;

        public string Test()
        {
            System.Console.WriteLine("please type a password:");
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
            string output = "password diagnostics:\n";

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
            if (!authenticator.Numerals())
            {
                return "numerals: failed\n";
            }

            return "numerals: success\n";
        }

        private string SymbolsDiagnostics()
        {
            if (!authenticator.Symbols())
            {
                return "symbols: failed\n";
            }

            return "symbols: success\n";
        }

        private string LowercaseDiagnostics()
        {
            if (!authenticator.Lowercase())
            {
                return "lowercase: failed\n";
            }

            return "lowercase: success\n";
        }

        private string UppercaseDiagnostics()
        {
            if (!authenticator.Uppercase())
            {
                return "uppercase: failed\n";
            }

            return "uppercase: success\n";
        }

        private string SupportedDiagnostics()
        {
            if (!authenticator.Supported())
            {
                return "supported: failed\n";
            }

            return "supported: success\n";
        }
    }
}
