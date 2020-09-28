using System;
using System.Collections.Generic;
using System.Text;

namespace Bai_5_Thao_tac_voi_List_T
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            // Bước 1: Khai báo và khởi tạo một List<string>.
            List<string> animal = new List<string>();
            // Bước 2: Thêm các phần tử "lion", "cat", "dog", "elephant" vào danh sách vừa tạo. 
            // In ra danh sách vừa được thêm.
            animal.Add("Lion");
            animal.Add("Cat");
            animal.Add("Dog");
            animal.Add("Elephant");
            foreach (string item in animal)
            {
                System.Console.WriteLine(item);
            }

            // Bước 3: Xoá phần tử "dog" trong danh sách. In ra danh sách hiện tại.
            System.Console.WriteLine("Xoá phần tử Dog trong danh sách. In ra danh sách hiện tại.");
            animal.Remove("Dog");
            foreach (string item in animal)
            {
                System.Console.WriteLine(item);
            }

            // Bước 4: Sắp xếp các phần tử và in ra.
            System.Console.WriteLine("Sắp xếp các phần tử và in ra.");
            animal.Sort();
            foreach (string item in animal)
            {
                System.Console.WriteLine(item);
            }

            // Bước 5: In ra index của "cat".
            System.Console.Write("Chỉ số index của Cat là: ");
            System.Console.WriteLine(animal.IndexOf("Cat")); 
        
        }
    }
}
