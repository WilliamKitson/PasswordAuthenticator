namespace PasswordAuthenticator
{
    public class Implementation : Facade
    {
        public Implementation()
        {
            length = 0;
        }

        public override void Push(char input)
        {
            length++;
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
            return false;
        }

        private int length;
    }
}
