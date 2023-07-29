namespace Specification
{
    internal class SymbolsValidTest
    {
        private readonly string prefix = "thisisapasswordprefixthisis";
        private readonly string symbols = "!£$%^&*()-_=+[{]};:@#~,<.>/?";

        public string Test()
        {
            if (CountSuccesses() == symbols.Length)
            {
                return "";
            }

            return "symbols valid test failed\n";
        }

        private int CountSuccesses()
        {
            PasswordAuthenticator.Facade unit = new PasswordAuthenticator.Implementation();
            int output = 0;

            for (int i = 0; i < symbols.Length; i++)
            {
                string password = InitialisePrefix(i);
                password += symbols[i];

                output += System.Convert.ToInt32(unit.Symbols(password));
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
