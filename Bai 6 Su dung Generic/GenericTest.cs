using System;
using System.Collections.Generic;
namespace Bai_6_Su_dung_Generic
{
    public class GenericTest<T>
    {
        public T a;
        public T b;
        public void SoSanh<T>(T a, T b)
        {
            if (a.Equals(b))
            {
                Console.WriteLine($"{a} bang {b}");
            }
            else
            {
                Console.WriteLine($"{a} khong bang {b}");
            }
        }
    }
}
