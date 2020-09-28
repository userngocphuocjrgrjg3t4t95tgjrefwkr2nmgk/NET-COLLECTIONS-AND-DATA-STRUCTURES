using System;

namespace Bai_6_Su_dung_Generic
{
    class Program
    {

        static void Main(string[] args)
        {
            GenericTest<int> genericTest = new GenericTest<int>();
            genericTest.SoSanh<int>(5, 5);
            genericTest.SoSanh<string>("VN", "USA");
        }
    }
}
