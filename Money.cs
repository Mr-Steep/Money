using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Money
{
    public class Money
    {
             public int Value { get; set; }
        public double DValue { get; set; }

        public bool Equals(Money other)
        {
            return !ReferenceEquals(null, other) && (ReferenceEquals(this, other) || other.Value == Value);
        }


        public static Money operator +(Money val1, Money val2)
        {
            return val1 + val2;
        }

        public static Money operator -(Money val1, Money val2)
        {
            return val1 - val2; ;
        }

        public static Money operator /(Money val1, int val2)
        {
            return val1 / val2;
        }
        public static int operator * (Money val1, Money val2)
        {

            return val1 * val2;
        }

        public static Money operator ++(Money val)
        {           
            return new Money { DValue = val.DValue + 0.01 };
        } 
        public static Money operator --(Money val)
        {           
            return new Money { DValue = val.DValue - 0.01 };
        }


        public static bool operator == (Money val1, Money val2)
        { 
            return Equals(val1, val2) ;
        }


        public static bool operator !=(Money val1, Money val2)
        {
            return !Equals(val1, val2);
        }



    }
}