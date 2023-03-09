namespace Generics
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //MaximumCheck iMax = new MaximumCheck();
            //int iResult = iMax.MaximumInteger(4, 2, 3);
            //Console.WriteLine(iResult);

            //iResult = iMax.MaximumInteger(2, 4, 3);
            //Console.WriteLine(iResult);

            //iResult = iMax.MaximumInteger(2, 3, 4);
            //Console.WriteLine(iResult);

            //MaximumCheck fMax = new MaximumCheck();
            //float fResult = fMax.MaximumFloat(4.2f, 2.2f, 2.3f);
            //Console.WriteLine(fResult);

            //fResult = fMax.MaximumFloat(2.4f, 4.6f, 3.4f);
            //Console.WriteLine(fResult);

            //fResult = fMax.MaximumFloat(2.4f, 4.6f, 6.9f);
            //Console.WriteLine(fResult);

            //MaximumCheck sMax = new MaximumCheck();
            //string sResult = sMax.MaximumString("Apple", "Peach", "Banana");
            //Console.WriteLine(sResult);

            int[] arrayOne = { 1, 111, 1255, 132, 14, 155, 167 };
            GenericsMaximum<int> intGenerics = new GenericsMaximum<int>(arrayOne);
            intGenerics.PrintMaximum();
            float[] arrayTwo = { 20.1f, 12.5f, 203.4f, 15.5f, 60.5f };
            GenericsMaximum<float> floatGenerics = new GenericsMaximum<float>(arrayTwo); 
            floatGenerics.PrintMaximum();
            string[] arrayThree = { "Tom", "John", "Smith", "Will", "Jack" };
            GenericsMaximum<string> stringGenerics = new GenericsMaximum<string>(arrayThree);
            stringGenerics.PrintMaximum();
        }
    }
}