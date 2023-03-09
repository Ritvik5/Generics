namespace Generics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            MaximumCheck max = new MaximumCheck();
            int result = max.MaximumInteger(4, 2, 3);
            Console.WriteLine(result);

            result = max.MaximumInteger(2, 4, 3);
            Console.WriteLine(result);

            result = max.MaximumInteger(2, 3, 4);
            Console.WriteLine(result);
        }
    }
}