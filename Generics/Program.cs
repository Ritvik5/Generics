namespace Generics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //MaximumCheck imax = new MaximumCheck();
            //int iresult = imax.MaximumInteger(4, 2, 3);
            //Console.WriteLine(iresult);

            //iresult = imax.MaximumInteger(2, 4, 3);
            //Console.WriteLine(iresult);

            //iresult = imax.MaximumInteger(2, 3, 4);
            //Console.WriteLine(iresult);

            MaximumCheck fmax = new MaximumCheck();
            float fresult = fmax.MaximumFloat(4.2f, 2.2f, 2.3f);
            Console.WriteLine(fresult);

            fresult = fmax.MaximumFloat(2.4f, 4.6f, 3.4f);
            Console.WriteLine(fresult);

            fresult = fmax.MaximumFloat(2.4f, 4.6f, 6.9f);
            Console.WriteLine(fresult);
        }
    }
}