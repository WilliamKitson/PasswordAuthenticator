namespace Specification
{
    internal class Entrypoint
    {
        private static void Main()
        {
            System.Console.WriteLine(new TestSuite().Test());
            FieldTest();
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
