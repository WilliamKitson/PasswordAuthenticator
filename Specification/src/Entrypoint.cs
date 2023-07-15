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

            return output;
        }
    }
}
