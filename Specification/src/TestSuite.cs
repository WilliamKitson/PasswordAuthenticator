namespace Specification
{
    internal class TestSuite
    {
        public string Test()
        {
            string output = ConcatenateTests();

            if (System.Convert.ToBoolean(output.Length))
            {
                return output;
            }

            return "all tests pass\n";
        }

        private string ConcatenateTests()
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
    }
}
