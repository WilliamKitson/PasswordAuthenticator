namespace PasswordAuthenticator
{
    public abstract class Facade
    {
        public abstract void Push(char input);
        public abstract bool Length();
        public abstract bool Numerals();
    }
}
