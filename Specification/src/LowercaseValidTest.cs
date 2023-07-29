namespace Specification
{
    internal class LowercaseValidTest
    {
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
            PasswordAuthenticator.Facade unit = new PasswordAuthenticator.Implementation();
            int output = 0;

            for (int i = 0; i < lowercase.Length; i++)
            {
                string password = InitialisePrefix(i);
                password += lowercase[i];

                output += System.Convert.ToInt32(unit.Lowercase(password));
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
