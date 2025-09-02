namespace MathLib
{
    public class Calculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Add(int[] integers)
        {
            int sum = 0;
            foreach (int i in integers)
            {
                sum += i;
            }

            return sum;
        }

        public void PrintHigherInt()
        {
            Console.WriteLine("Enter the first number: ");
            string firstNumberAsString = Console.ReadLine();
            int firstNumberAsInt = Convert.ToInt32(firstNumberAsString);
            
            Console.WriteLine("Enter the second number: ");
            string secondNumberAsString = Console.ReadLine();
            int secondNumberAsInt = Convert.ToInt32(secondNumberAsString);
            
            Console.WriteLine($"The highest number is: {Math.Max(firstNumberAsInt, secondNumberAsInt)}");
        }
    }
}