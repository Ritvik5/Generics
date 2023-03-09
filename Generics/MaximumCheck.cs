using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class MaximumCheck
    {
        public int MaximumInteger(int first, int second, int third)
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                return first;
            }

            if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                return second;
            }
            if (third.CompareTo(first) > 0 && third.CompareTo(second) > 0)
            { 
                return third;
            }
            throw new Exception("first,second and third are same");
        }

        public float MaximumFloat(float first, float second, float third)
        {
            if(first.CompareTo(second) > 0 && first.CompareTo (third) > 0)
            {
                return first;
            }
            if(second.CompareTo(first) > 0 && second.CompareTo (third) > 0)
            {
                return second;
            }
            if(third.CompareTo(first) > 0 && third.CompareTo (second) > 0)
            {
                return third;
            }
            throw new Exception("first , second and third are same");
        }
    }
}
