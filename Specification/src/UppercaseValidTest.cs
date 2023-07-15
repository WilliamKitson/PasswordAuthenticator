namespace Specification
{
    internal class UppercaseValidTest
    {
        public string Test()
        {
            if (CountSuccesses() == uppercase.Length)
            {
                return "";
            }

            return "lowercase valid test failed\n";
        }

        private int CountSuccesses()
        {
            int output = 0;

            for (int i = 0; i < uppercase.Length; i++)
            {
                InitialisePrefix(i);
                unit.Push(uppercase[i]);
                output += System.Convert.ToInt32(unit.Uppercase());
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
        private readonly string prefix = "qwertyuiopasdfghjklzxcvbnm";
        private readonly string uppercase = "QWERTYUIOPASDFGHJKLZXCVBN";
    }
}
