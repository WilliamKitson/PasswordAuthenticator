namespace Specification
{
    internal class LowercaseValidTest
    {
        private PasswordAuthenticator.Facade unit;
        private readonly string prefix = "QWERTYUIOPASDFGHJKLZXCVBN";
        private readonly string lowercase = "qwertyuiopasdfghjklzxcvbnm";

        public string Test()
        {
            if (CountSuccesses() == lowercase.Length)
            {
                return "";
            }

            return "lowercase valid test failed\n";
        }

        private int CountSuccesses()
        {
            int output = 0;

            for (int i = 0; i < lowercase.Length; i++)
            {
                InitialisePrefix(i);
                unit.Push(lowercase[i]);
                output += System.Convert.ToInt32(unit.Lowercase());
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
