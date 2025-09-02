namespace Strings
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            StringManipulator manipulator = new StringManipulator();
            
            manipulator.MakeABBA("Hello", "Martin");

            Console.WriteLine(manipulator.MakeWord("(::)", "kekw"));
        }
    }
}