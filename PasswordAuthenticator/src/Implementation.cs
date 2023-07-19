namespace PasswordAuthenticator
{
    public class Implementation : Facade
    {
        private readonly CharacterStack password;
        private readonly CharacterStack numerals;
        private readonly CharacterStack symbols;
        private readonly CharacterStack lowercase;
        private readonly CharacterStack uppercase;
        private readonly CharacterStack supported;

        public Implementation()
        {
            password = new CharacterStack();
            numerals = new CharacterStack();
            symbols = new CharacterStack();
            lowercase = new CharacterStack();
            uppercase = new CharacterStack();
            supported = new CharacterStack();
            InitialiseNumerals();
            InitialiseSymbols();
            InitialiseLowercase();
            InitialiseUppercase();
            InitialiseSupported();
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
            for (int i = 0; i < numerals.GetLength(); i++)
            {
                if (password.Contains(numerals.GetChar(i))) return true;
            }

            return false;
        }

        public override bool Symbols()
        {
            for (int i = 0; i < symbols.GetLength(); i++)
            {
                if (password.Contains(symbols.GetChar(i))) return true;
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

        public override bool Supported()
        {
            for (int i = 0; i < supported.GetLength(); i++)
            {
                if (password.Contains(supported.GetChar(i))) return true;
            }

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

        private void InitialiseSupported()
        {
            supported.Push('1');
            supported.Push('2');
            supported.Push('3');
            supported.Push('4');
            supported.Push('5');
            supported.Push('6');
            supported.Push('7');
            supported.Push('8');
            supported.Push('9');
            supported.Push('0');
            supported.Push('!');
            supported.Push('£');
            supported.Push('$');
            supported.Push('%');
            supported.Push('^');
            supported.Push('&');
            supported.Push('*');
            supported.Push('(');
            supported.Push(')');
            supported.Push('-');
            supported.Push('_');
            supported.Push('=');
            supported.Push('+');
            supported.Push('[');
            supported.Push('{');
            supported.Push(']');
            supported.Push('}');
            supported.Push(';');
            supported.Push(':');
            supported.Push('@');
            supported.Push('#');
            supported.Push('~');
            supported.Push(',');
            supported.Push('<');
            supported.Push('.');
            supported.Push('>');
            supported.Push('/');
            supported.Push('?');
            supported.Push('q');
            supported.Push('w');
            supported.Push('e');
            supported.Push('r');
            supported.Push('t');
            supported.Push('y');
            supported.Push('u');
            supported.Push('i');
            supported.Push('o');
            supported.Push('p');
            supported.Push('a');
            supported.Push('s');
            supported.Push('d');
            supported.Push('f');
            supported.Push('g');
            supported.Push('h');
            supported.Push('j');
            supported.Push('k');
            supported.Push('l');
            supported.Push('z');
            supported.Push('x');
            supported.Push('c');
            supported.Push('v');
            supported.Push('b');
            supported.Push('n');
            supported.Push('m');
            supported.Push('Q');
            supported.Push('W');
            supported.Push('E');
            supported.Push('R');
            supported.Push('T');
            supported.Push('Y');
            supported.Push('U');
            supported.Push('I');
            supported.Push('O');
            supported.Push('P');
            supported.Push('A');
            supported.Push('S');
            supported.Push('D');
            supported.Push('F');
            supported.Push('G');
            supported.Push('H');
            supported.Push('J');
            supported.Push('K');
            supported.Push('L');
            supported.Push('Z');
            supported.Push('X');
            supported.Push('C');
            supported.Push('V');
            supported.Push('B');
            supported.Push('N');
            supported.Push('M');
        }
    }
}
