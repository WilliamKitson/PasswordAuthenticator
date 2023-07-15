namespace PasswordAuthenticator
{
    public class Implementation : Facade
    {
        public Implementation()
        {
            length = 0;
            password = null;
        }

        public override void Push(char input)
        {
            length++;

            char[] temp = new char[length];

            for (int i = 0; i < length - 1; i++)
            {
                temp[i] = password[i];
            }

            password = temp;
            password[length - 1] = input;
        }

        public override bool Length()
        {
            if (length < 20)
            {
                return false;
            }

            return true;
        }

        public override bool Numerals()
        {
            char[] numerals = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };

            for (int i = 0; i < length; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    if (password[i] == numerals[i2])
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private int length;
        private char[] password;
    }
}
