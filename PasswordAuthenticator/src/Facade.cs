namespace PasswordAuthenticator
{
    public abstract class Facade
    {
        public abstract void Push(char input);
        public abstract bool Length(string input);
        public abstract bool Numerals(string input);
        public abstract bool Symbols(string input);
        public abstract bool Lowercase(string input);
        public abstract bool Uppercase(string input);
    }
}
