namespace PasswordAuthenticator
{
    internal class CharacterStack
    {
        public void Push(char input)
        {
            data = IncrementedData();
            InitialiseLastCharacter(input);
        }

        public int GetLength()
        {
            return length;
        }

        public char GetChar(int input)
        {
            return data[input];
        }

        private char[] IncrementedData()
        {
            length++;
            char[] output = new char[length];

            for (int i = 0; i < length - 1; i++)
            {
                output[i] = data[i];
            }

            return output;
        }

        private void InitialiseLastCharacter(char input)
        {
            data[length - 1] = input;
        }

        private int length;
        private char[] data;
    }
}
