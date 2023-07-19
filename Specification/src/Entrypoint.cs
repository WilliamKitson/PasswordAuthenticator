namespace Specification
{
    internal class Entrypoint
    {
        private static void Main()
        {
            System.Console.WriteLine(Results());
            System.Console.ReadLine();
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

            return output;
        }
    }
}
