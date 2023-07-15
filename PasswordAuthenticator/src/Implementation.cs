namespace PasswordAuthenticator
{
    public class Implementation : Facade
    {
        public Implementation()
        {
            password = new CharacterStack();
        }

        public override void Push(char input)
        {
            password.Push(input);
        }

        public override bool Length()
        {
            if (password.GetLength() < 20)
            {
                return false;
            }

            return true;
        }

        public override bool Numerals()
        {
            char[] numerals = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };

            for (int i = 0; i < password.GetLength(); i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    if (password.GetChar(i) == numerals[i2])
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private readonly CharacterStack password;
    }
}
