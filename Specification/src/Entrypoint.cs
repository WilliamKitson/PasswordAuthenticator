using System;

namespace Specification
{
    internal class Entrypoint
    {
        private static void Main()
        {
            Console.WriteLine(Results());
            Console.ReadLine();
        }

        private static string Results()
        {
            string output = ConcatenateTests();

            if (Convert.ToBoolean(output.Length))
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

            return output;
        }
    }
}
