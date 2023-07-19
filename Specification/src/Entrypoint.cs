namespace Specification
{
    internal class Entrypoint
    {
        private static void Main()
        {
            System.Console.WriteLine(Results());
            FieldTest();
        }

        private static string Results()
        {
            string output = ConcatenateTests();

            if (System.Convert.ToBoolean(output.Length))
            {
                return output;
            }

            return "all tests pass";
        }

        private static string ConcatenateTests()
        {
            string output = "";

            output += new LengthInvalidTest().Test();
            output += new LengthValidTest().Test();
            output += new NumeralsInvalidTest().Test();
            output += new NumeralsValidTest().Test();
            output += new SymbolsInvalidTest().Test();
            output += new SymbolsValidTest().Test();
            output += new LowercaseInvalidTest().Test();
            output += new LowercaseValidTest().Test();
            output += new UppercaseInvalidTest().Test();
            output += new UppercaseValidTest().Test();
            output += new SupportedInvalidTest().Test();
            output += new SupportedValidTest().Test();

            return output;
        }

        private static void FieldTest()
        {
            while (true)
            {
                PasswordAuthenticator.Facade fieldtest = new PasswordAuthenticator.Implementation();
                string password = System.Console.ReadLine();

                for (int i = 0; i < password.Length; i++)
                {
                    fieldtest.Push(password[i]);
                }

                if (!fieldtest.Length())
                {
                    System.Console.WriteLine("length: failed");
                }

                if (!fieldtest.Numerals())
                {
                    System.Console.WriteLine("numerals: failed");
                }

                if (!fieldtest.Symbols())
                {
                    System.Console.WriteLine("symbols: failed");
                }

                if (!fieldtest.Lowercase())
                {
                    System.Console.WriteLine("lowercase: failed");
                }

                if (!fieldtest.Uppercase())
                {
                    System.Console.WriteLine("uppercase: failed");
                }

                if (!fieldtest.Supported())
                {
                    System.Console.WriteLine("supported: failed");
                }
            }
        }
    }
}
