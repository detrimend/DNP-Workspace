namespace Numbers
{
    public class NumberWriter
    {
        public NumberWriter(){}
        
        public void PrintEven(int x)
        {
            for (int i = 0; i <= x; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public void PrintUneven(int x)
        {
            for (int i = 0; i <= x; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public void PrintDivisibleByY(int x, int y)
        {
            for (int i = 0; i <= x; i++)
            {
                if (i % y == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}