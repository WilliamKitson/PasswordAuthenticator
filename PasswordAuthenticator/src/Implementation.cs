namespace PasswordAuthenticator
{
    public class Implementation : Facade
    {
        private readonly string uppercase;

        public Implementation()
        {
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
            return ContainsCharacters(input, "1234567890");
        }

        public override bool Symbols(string input)
        {
            return ContainsCharacters(input, "!£$%^&*()-_=+[{]};:@#~,<.>/?");
        }

        public override bool Lowercase(string input)
        {
            return ContainsCharacters(input, "qwertyuiopasdfghjklzxcvbnm");
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

        private bool ContainsCharacters(string password, string comparison)
        {
            for (int i = 0; i < password.Length; i++)
            {
                for (int i2 = 0; i2 < comparison.Length; i2++)
                {
                    if (password[i] == comparison[i2])
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
