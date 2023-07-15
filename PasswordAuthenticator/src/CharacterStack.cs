namespace PasswordAuthenticator
{
    internal class CharacterStack
    {
        public void Push(char input)
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

        public int GetLength()
        {
            return length;
        }

        public char GetChar(int input)
        {
            return password[input];
        }

        private int length;
        private char[] password;
    }
}
