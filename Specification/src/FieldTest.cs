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

                if (!authenticator.Length())
                {
                    System.Console.WriteLine("length: failed");
                }

                if (!authenticator.Numerals())
                {
                    System.Console.WriteLine("numerals: failed");
                }

                if (!authenticator.Symbols())
                {
                    System.Console.WriteLine("symbols: failed");
                }

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
    }
}
