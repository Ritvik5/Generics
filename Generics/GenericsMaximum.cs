using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class GenericsMaximum<Type> where Type : IComparable
    {
        public Type[] value;

        public GenericsMaximum(Type[] value)
        {
            this.value = value;
        }

        public Type[] Sort(Type[] value)
        {
            Array.Sort(value);
            return value;
        }

        public Type Maximum(Type[] value)
        {
            var sortedValues = Sort(value);
            return sortedValues[sortedValues.Length - 1];
        }

        public void PrintMaximum()
        {
            var max = Maximum(value);
            Console.WriteLine("Maximum value is : " +max);
        }
    }
}
