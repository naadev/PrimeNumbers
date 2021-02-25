using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeNumbers
{
    static class PrimeNumber
    {
        //static public bool IsPrime(int number)
        //{
        //    throw new NotImplementedException();
        //}
        //static public bool IsPrime(int number)
        //{
        //    return true;
        //}
        //static public bool IsPrime(int number)
        //{
        //    return number != 4;
        //}
        //static public bool IsPrime(int number)
        //{
        //    return number != 4 && number != 6;
        //}
        //static public bool IsPrime(int number)
        //{
        //    return number%2 != 0;
        //}
        //static public bool IsPrime(int number)
        //{
        //    return !(number % 2 != 0 || number != 2);
        //}
        static public bool IsPrime(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
