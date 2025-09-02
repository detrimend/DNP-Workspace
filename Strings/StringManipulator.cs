namespace Strings
{
    public class StringManipulator
    {
        public void MakeABBA(string a, string b)
        {
            Console.WriteLine($"{a}{b}{b}{a}");
        }
        
        public string MakeWord(string wrap, string word)
        {
            return $"{wrap.Substring(0, 2)}{word}{wrap.Substring(2)}";
        }
    }
}