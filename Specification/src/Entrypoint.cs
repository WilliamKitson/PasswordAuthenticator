using System;

namespace Specification
{
    internal class Entrypoint
    {
        static void Main()
        {
            string results = new LengthInvalidTest().Test();

            if (Convert.ToBoolean(results.Length))
            {
                Console.WriteLine(results);
                Console.ReadLine();
                return;
            }

            Console.WriteLine("all tests passed");
            Console.ReadLine();
        }
    }
}
