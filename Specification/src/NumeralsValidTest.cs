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
            PasswordAuthenticator.Facade unit;
            int output = 0;

            for (int i = 0; i < numerals.Length; i++)
            {
                unit = new PasswordAuthenticator.Implementation();
                unit.Push(numerals[i]);
                output += System.Convert.ToInt32(unit.Numerals());
            }

            return output;
        }

        private readonly string numerals = "1234567890";
    }
}
