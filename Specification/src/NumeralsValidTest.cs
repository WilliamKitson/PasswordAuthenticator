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
                InitialisePrefix(i);
                unit.Push(numerals[i]);
                output += System.Convert.ToInt32(unit.Numerals());
            }

            return output;
        }

        private void InitialisePrefix(int input)
        {
            unit = new PasswordAuthenticator.Implementation();

            for (int i = 0; i < input; i++)
            {
                unit.Push(prefix[i]);
            }
        }

        private PasswordAuthenticator.Facade unit;
        private readonly string prefix = "thisisapa";
        private readonly string numerals = "1234567890";
    }
}
