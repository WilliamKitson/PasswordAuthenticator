namespace Specification
{
    internal class UppercaseValidTest
    {
        private PasswordAuthenticator.Facade unit;
        private readonly string prefix = "qwertyuiopasdfghjklzxcvbnm";
        private readonly string uppercase = "QWERTYUIOPASDFGHJKLZXCVBN";

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
            PasswordAuthenticator.Facade unit = new PasswordAuthenticator.Implementation();
            int output = 0;

            for (int i = 0; i < uppercase.Length; i++)
            {
                string password = InitialisePrefix(i);
                password += uppercase[i];

                output += System.Convert.ToInt32(unit.Uppercase(password));
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
