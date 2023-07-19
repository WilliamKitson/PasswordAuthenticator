namespace Specification
{
    internal class Entrypoint
    {
        private static void Main()
        {
            System.Console.WriteLine(new TestSuite().Test());

            while (true)
            {
                System.Console.WriteLine(new FieldTest().Test());
            }
        }
    }
}
