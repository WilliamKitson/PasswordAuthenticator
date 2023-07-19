namespace Specification
{
    internal class Entrypoint
    {
        private static void Main()
        {
            ExecuteTestSuite();
            ExecuteFieldTest();
        }

        private static void ExecuteTestSuite()
        {
            System.Console.WriteLine(new TestSuite().Test());
        }

        private static void ExecuteFieldTest()
        {
            while (true)
            {
                System.Console.WriteLine("please type a password:");
                System.Console.WriteLine(new FieldTest().Test());
            }
        }
    }
}
