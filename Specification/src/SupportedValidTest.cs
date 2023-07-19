namespace Specification
{
    internal class SupportedValidTest
    {
        private PasswordAuthenticator.Facade unit;
        private readonly string password = "1234567890!£$%^&*()-_=+[{]};:@#~,<.>/?qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBN";

        public string Test()
        {
            int successes = 0;

            for(int i = 0; i < password.Length; i++)
            {
                unit = new PasswordAuthenticator.Implementation();
                unit.Push(password[i]);
                successes += System.Convert.ToInt32(unit.Supported());
            }

            if (successes == password.Length)
            {
                return "";
            }

            return "supported valid test failed\n";
        }
    }
}
