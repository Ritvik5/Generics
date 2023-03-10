using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class GenericsMaximum<Type> where Type : IComparable
    {
        public Type value1;
        public Type value2;
        public Type value3;


        public GenericsMaximum(Type value1, Type value2, Type value3)
        {
            this.value1 = value1;
            this.value2 = value2;
            this.value3 = value3;
        }

        public Type GetMax()
        {
            Type max = value1;
            if(value2.CompareTo(max) > 0) 
            {
                max = value2;
            }
            if(value3.CompareTo(max) > 0)
            {
                max = value3;
            }
            return max;
        }

        //public Type[] Sort(Type[] value)
        //{
        //    Array.Sort(value);
        //    return value;
        //}

        //public Type Maximum(Type[] value)
        //{
        //    var sortedValues = Sort(value);
        //    return sortedValues[sortedValues.Length - 1];
        //}

        //public void PrintMaximum()
        //{

        //    var max = Maximum(value);
        //    Console.WriteLine("Maximum value is : " +max);
        //}
    }
}
