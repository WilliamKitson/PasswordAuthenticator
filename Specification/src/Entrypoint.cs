namespace Specification
{
    internal class Entrypoint
    {
        private static void Main()
        {
            System.Console.WriteLine(new TestSuite().Test());
            ExecuteFieldTest();
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
