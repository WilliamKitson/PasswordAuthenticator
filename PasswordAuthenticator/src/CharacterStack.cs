namespace PasswordAuthenticator
{
    internal class CharacterStack
    {
        public void Push(char input)
        {
            IncrementLength();
            data = PushedData();
            data[length - 1] = input;
        }

        public int GetLength()
        {
            return length;
        }

        public char GetChar(int input)
        {
            return data[input];
        }

        private void IncrementLength()
        {
            length++;
        }

        private char[] PushedData()
        {
            char[] output = new char[length];

            for (int i = 0; i < length - 1; i++)
            {
                output[i] = data[i];
            }

            return output;
        }

        private int length;
        private char[] data;
    }
}
