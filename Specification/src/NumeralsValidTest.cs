namespace Specification
{
    internal class NumeralsValidTest
    {
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
            int output = 0;

            for (int i = 0; i < numerals.Length; i++)
            {
                PasswordAuthenticator.Facade unit = new PasswordAuthenticator.Implementation();

                for (int i2 = 0; i2 < i; i2++)
                {
                    unit.Push(prefix[i2]);
                }

                unit.Push(numerals[i]);
                output += System.Convert.ToInt32(unit.Numerals());
            }

            return output;
        }

        private readonly string prefix = "thisisapa";
        private readonly string numerals = "1234567890";
    }
}
