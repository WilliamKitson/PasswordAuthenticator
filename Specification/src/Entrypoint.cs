namespace Specification
{
    internal class Entrypoint
    {
        private static void Main()
        {
            TestSuite suite = new TestSuite();
            System.Console.WriteLine(suite.Test());

            while (suite.GetSuccess())
            {
                System.Console.WriteLine("please type a password:");
                System.Console.WriteLine(new FieldTest().Test(System.Console.ReadLine()));
            }

            System.Console.ReadLine();
        }
    }
}
