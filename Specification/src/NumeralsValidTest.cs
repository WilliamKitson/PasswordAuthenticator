namespace Specification
{
    internal class NumeralsValidTest
    {
        public string Test()
        {
            PasswordAuthenticator.Facade unit;
            string numerals = "1234567890";
            int successes = 0;

            for (int i = 0; i < numerals.Length; i++)
            {
                unit = new PasswordAuthenticator.Implementation();
                unit.Push(numerals[i]);
                successes += System.Convert.ToInt32(unit.Numerals());
            }

            if (successes == numerals.Length)
            {
                return "";
            }

            return "numerals valid test failed\n";
        }
    }
}
