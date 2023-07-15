namespace PasswordAuthenticator
{
    public class Implementation : Facade
    {
        public Implementation()
        {
            password = new CharacterStack();
            numerals = new CharacterStack();
            InitialiseNumerals();
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
            for (int i = 0; i < password.GetLength(); i++)
            {
                for (int i2 = 0; i2 < numerals.GetLength(); i2++)
                {
                    if (password.GetChar(i) == numerals.GetChar(i2))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public override bool Symbols()
        {
            return false;
        }

        private void InitialiseNumerals()
        {
            numerals.Push('1');
            numerals.Push('2');
            numerals.Push('3');
            numerals.Push('4');
            numerals.Push('5');
            numerals.Push('6');
            numerals.Push('7');
            numerals.Push('8');
            numerals.Push('9');
            numerals.Push('0');
        }

        private readonly CharacterStack password;
        private readonly CharacterStack numerals;
    }
}
