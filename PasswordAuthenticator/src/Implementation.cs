namespace PasswordAuthenticator
{
    public class Implementation : Facade
    {
        private readonly CharacterStack password;
        private readonly string numerals;
        private readonly string symbols;
        private readonly CharacterStack lowercase;
        private readonly CharacterStack uppercase;

        public Implementation()
        {
            password = new CharacterStack();
            numerals = "1234567890";
            symbols = "!£$%^&*()-_=+[{]};:@#~,<.>/?";
            lowercase = new CharacterStack();
            uppercase = new CharacterStack();
            InitialiseLowercase();
            InitialiseUppercase();
        }

        public override void Push(char input)
        {
            password.Push(input);
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

        public override bool Lowercase()
        {
            for (int i = 0; i < lowercase.GetLength(); i++)
            {
                if (password.Contains(lowercase.GetChar(i))) return true;
            }

            return false;
        }

        public override bool Uppercase()
        {
            for (int i = 0; i < uppercase.GetLength(); i++)
            {
                if (password.Contains(uppercase.GetChar(i))) return true;
            }

            return false;
        }

        private void InitialiseLowercase()
        {
            lowercase.Push('q');
            lowercase.Push('w');
            lowercase.Push('e');
            lowercase.Push('r');
            lowercase.Push('t');
            lowercase.Push('y');
            lowercase.Push('u');
            lowercase.Push('i');
            lowercase.Push('o');
            lowercase.Push('p');
            lowercase.Push('a');
            lowercase.Push('s');
            lowercase.Push('d');
            lowercase.Push('f');
            lowercase.Push('g');
            lowercase.Push('h');
            lowercase.Push('j');
            lowercase.Push('k');
            lowercase.Push('l');
            lowercase.Push('z');
            lowercase.Push('x');
            lowercase.Push('c');
            lowercase.Push('v');
            lowercase.Push('b');
            lowercase.Push('n');
            lowercase.Push('m');
        }

        private void InitialiseUppercase()
        {
            uppercase.Push('Q');
            uppercase.Push('W');
            uppercase.Push('E');
            uppercase.Push('R');
            uppercase.Push('T');
            uppercase.Push('Y');
            uppercase.Push('U');
            uppercase.Push('I');
            uppercase.Push('O');
            uppercase.Push('P');
            uppercase.Push('A');
            uppercase.Push('S');
            uppercase.Push('D');
            uppercase.Push('F');
            uppercase.Push('G');
            uppercase.Push('H');
            uppercase.Push('J');
            uppercase.Push('K');
            uppercase.Push('L');
            uppercase.Push('Z');
            uppercase.Push('X');
            uppercase.Push('C');
            uppercase.Push('V');
            uppercase.Push('B');
            uppercase.Push('N');
            uppercase.Push('M');
        }
    }
}
