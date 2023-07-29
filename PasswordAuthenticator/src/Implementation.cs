namespace PasswordAuthenticator
{
    public class Implementation : Facade
    {
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
            return ContainsCharacters(input, "QWERTYUIOPASDFGHJKLZXCVBNM");
        }

        private bool ContainsCharacters(string password, string comparison)
        {
            for (int i = 0; i < password.Length; i++)
            {
                if (CharacterMatches(password[i], comparison)) return true;
            }

            return false;
        }

        private bool CharacterMatches(char character, string comparison)
        {
            for (int i = 0; i < comparison.Length; i++)
            {
                if (character == comparison[i]) return true;
            }

            return false;
        }
    }
}
