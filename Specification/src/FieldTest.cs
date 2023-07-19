namespace Specification
{
    internal class FieldTest
    {
        PasswordAuthenticator.Facade authenticator;

        public void Test()
        {
            while (true)
            {
                System.Console.WriteLine("please type a password:");
                InitialisePassword(System.Console.ReadLine());

                string diagnostics = "password diagnostics:\n";

                diagnostics += LengthDiagnostics();
                diagnostics += NumeralsDiagnostics();
                diagnostics += SymbolsDiagnostics();

                System.Console.WriteLine(diagnostics);

                if (!authenticator.Lowercase())
                {
                    System.Console.WriteLine("lowercase: failed");
                }

                if (!authenticator.Uppercase())
                {
                    System.Console.WriteLine("uppercase: failed");
                }

                if (!authenticator.Supported())
                {
                    System.Console.WriteLine("supported: failed");
                }
            }
        }

        private void InitialisePassword(string input)
        {
            authenticator = new PasswordAuthenticator.Implementation();

            for (int i = 0; i < input.Length; i++)
            {
                authenticator.Push(input[i]);
            }
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
    }
}
