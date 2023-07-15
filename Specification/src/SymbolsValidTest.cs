namespace Specification
{
    internal class SymbolsValidTest
    {
        private PasswordAuthenticator.Facade unit;
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
            int output = 0;

            for (int i = 0; i < symbols.Length; i++)
            {
                InitialisePrefix(i);
                unit.Push(symbols[i]);
                output += System.Convert.ToInt32(unit.Symbols());
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
