namespace Specification
{
    internal class NumeralsValidTest
    {
        private PasswordAuthenticator.Facade unit;
        private readonly string prefix = "thisisapa";
        private readonly string lowercase = "1234567890";

        public string Test()
        {
            if (CountSuccesses() == lowercase.Length)
            {
                return "";
            }

            return "numerals valid test failed\n";
        }

        private int CountSuccesses()
        {
            int output = 0;

            for (int i = 0; i < lowercase.Length; i++)
            {
                InitialisePrefix(i);
                unit.Push(lowercase[i]);
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
    }
}
