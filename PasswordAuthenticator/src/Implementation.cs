namespace PasswordAuthenticator
{
    public class Implementation : Facade
    {
        private readonly string numerals;
        private readonly string symbols;
        private readonly string lowercase;
        private readonly string uppercase;

        public Implementation()
        {
            numerals = "1234567890";
            symbols = "!£$%^&*()-_=+[{]};:@#~,<.>/?";
            lowercase = "qwertyuiopasdfghjklzxcvbnm";
            uppercase = "QWERTYUIOPASDFGHJKLZXCVBNM";
        }

        public override bool Length(string input)
        {
            if (input.Length < 20)
            {
                return false;
            }

            return true;
        }

        public override bool Numerals(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                for (int i2 = 0; i2 < numerals.Length; i2++)
                {
                    if (input[i] == numerals[i2])
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public override bool Symbols(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                for (int i2 = 0; i2 < symbols.Length; i2++)
                {
                    if (input[i] == symbols[i2])
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public override bool Lowercase(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                for (int i2 = 0; i2 < lowercase.Length; i2++)
                {
                    if (input[i] == lowercase[i2])
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public override bool Uppercase(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                for (int i2 = 0; i2 < uppercase.Length; i2++)
                {
                    if (input[i] == uppercase[i2])
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
