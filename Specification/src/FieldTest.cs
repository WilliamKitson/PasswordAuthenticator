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

            return output;
        }

        private string LengthDiagnostics()
        {
            if (!authenticator.Length())
            {
                return "length:\t\tfailed\n";
            }

            return "length:\t\tsuccess\n";
        }

        private string NumeralsDiagnostics()
        {
            if (authenticator.Numerals())
            {
                return "numerals:\tsuccess\n";
            }

            return "numerals:\tfailed\n";
        }

        private string SymbolsDiagnostics()
        {
            if (authenticator.Symbols())
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
