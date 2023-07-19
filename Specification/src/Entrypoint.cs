namespace Specification
{
    internal class Entrypoint
    {
        private static void Main()
        {
            System.Console.WriteLine(new TestSuite().Test());
            new FieldTest().Test();
        }
    }
}
