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

            return SuccessMessage();
        }

        public bool GetSuccess()
        {
            return Test() == SuccessMessage();
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

            return output;
        }

        private string SuccessMessage()
        {
            return "all tests pass!\n";
        }
    }
}
