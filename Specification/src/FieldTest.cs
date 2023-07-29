namespace Specification
{
    internal class FieldTest
    {
        public string Test(string input)
        {
            string output = "\n";

            output += LengthDiagnostics(input);
            output += NumeralsDiagnostics(input);
            output += SymbolsDiagnostics(input);
            output += LowercaseDiagnostics(input);
            output += UppercaseDiagnostics(input);

            return output;
        }

        private string LengthDiagnostics(string input)
        {
            PasswordAuthenticator.Facade unit = new PasswordAuthenticator.Implementation();

            if (!unit.Length(input))
            {
                return "length:\t\tfailed\n";
            }

            return "length:\t\tsuccess\n";
        }

        private string NumeralsDiagnostics(string input)
        {
            PasswordAuthenticator.Facade unit = new PasswordAuthenticator.Implementation();

            if (unit.Numerals(input))
            {
                return "numerals:\tsuccess\n";
            }

            return "numerals:\tfailed\n";
        }

        private string SymbolsDiagnostics(string input)
        {
            PasswordAuthenticator.Facade unit = new PasswordAuthenticator.Implementation();

            if (unit.Symbols(input))
            {
                return "symbols:\tsuccess\n";
            }

            return "symbols:\tfailed\n";
        }

        private string LowercaseDiagnostics(string input)
        {
            PasswordAuthenticator.Facade unit = new PasswordAuthenticator.Implementation();

            if (unit.Lowercase(input))
            {
                return "lowercase:\tsuccess\n";
            }

            return "lowercase:\tfailed\n";
        }

        private string UppercaseDiagnostics(string input)
        {
            PasswordAuthenticator.Facade unit = new PasswordAuthenticator.Implementation();

            if (unit.Uppercase(input))
            {
                return "uppercase:\tsuccess\n";
            }

            return "uppercase:\tfailed\n";
        }
    }
}
