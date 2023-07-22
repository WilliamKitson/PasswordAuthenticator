namespace Specification
{
    internal class TestSuite
    {
        bool success = false;

        public string Test()
        {
            string output = ConcatenateTests();

            if (output.Length > 0)
            {
                return output;
            }

            success = true;
            return "all tests pass!\n";
        }

        public bool GetSuccess()
        {
            return success;
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
    }
}
