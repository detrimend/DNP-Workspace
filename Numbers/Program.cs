namespace Numbers
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            NumberWriter writer = new NumberWriter();
            
            Console.WriteLine("Even:");
            writer.PrintEven(16);
            Console.WriteLine("Uneven:");
            writer.PrintUneven(16);
            Console.WriteLine("Divisible by y");
            writer.PrintDivisibleByY(16, 3);
        }
        
        
    }
}