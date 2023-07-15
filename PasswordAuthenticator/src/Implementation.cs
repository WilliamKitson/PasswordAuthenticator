namespace PasswordAuthenticator
{
    public class Implementation : Facade
    {
        public Implementation()
        {
            password = new CharacterStack();
            numerals = new CharacterStack();
            symbols = new CharacterStack();
            lowercase = new CharacterStack();
            InitialiseNumerals();
            InitialiseSymbols();
            InitialiseLowercase();
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
            for (int i = 0; i < password.GetLength(); i++)
            {
                for (int i2 = 0; i2 < symbols.GetLength(); i2++)
                {
                    if (password.GetChar(i) == symbols.GetChar(i2))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public override bool Lowercase()
        {
            for (int i = 0; i < password.GetLength(); i++)
            {
                for (int i2 = 0; i2 < lowercase.GetLength(); i2++)
                {
                    if (password.GetChar(i) == lowercase.GetChar(i2))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        public override bool Uppercase()
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

        private void InitialiseSymbols()
        {
            symbols.Push('!');
            symbols.Push('£');
            symbols.Push('$');
            symbols.Push('%');
            symbols.Push('^');
            symbols.Push('&');
            symbols.Push('*');
            symbols.Push('(');
            symbols.Push(')');
            symbols.Push('-');
            symbols.Push('_');
            symbols.Push('=');
            symbols.Push('+');
            symbols.Push('[');
            symbols.Push('{');
            symbols.Push(']');
            symbols.Push('}');
            symbols.Push(';');
            symbols.Push(':');
            symbols.Push('@');
            symbols.Push('#');
            symbols.Push('~');
            symbols.Push(',');
            symbols.Push('<');
            symbols.Push('.');
            symbols.Push('>');
            symbols.Push('/');
            symbols.Push('?');
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

        private readonly CharacterStack password;
        private readonly CharacterStack numerals;
        private readonly CharacterStack symbols;
        private readonly CharacterStack lowercase;
    }
}
