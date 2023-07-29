using System.Runtime.CompilerServices;

namespace Specification
{
    internal class NumeralsValidTest
    {
        private readonly string prefix = "thisisapa";
        private readonly string numerals = "1234567890";

        public string Test()
        {
            if (CountSuccesses() == numerals.Length)
            {
                return "";
            }

            return "numerals valid test failed\n";
        }

        private int CountSuccesses()
        {
            PasswordAuthenticator.Facade unit = new PasswordAuthenticator.Implementation();
            int output = 0;

            for (int i = 0; i < numerals.Length; i++)
            {
                string password = InitialisePrefix(i);
                password += numerals[i];

                output += System.Convert.ToInt32(unit.Numerals(password));
            }

            return output;
        }

        private string InitialisePrefix(int input)
        {
            string output = "";

            for (int i = 0; i < input; i++)
            {
                output += prefix[i];
            }

            return output;
        }
    }
}
