using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Bai_4_Su_dung_Linq_voi_ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            ArrayList arrayList = new ArrayList();
            arrayList.Add(new Staff { id = 1, name = "Nam ", age = 24 });
            arrayList.Add(new Staff { id = 2, name = "Kiên", age = 21 });
            arrayList.Add(new Staff { id = 3, name = "Việt", age = 21 });
            arrayList.Add(new Staff { id = 4, name = "Hằng", age = 21 });
            arrayList.Add(new Staff { id = 5, name = "Tiến", age = 21 });

            System.Console.WriteLine("Id   Tên       Tuổi");
            System.Console.WriteLine("---------------------------");
            foreach (Staff item in arrayList)
            {
                System.Console.WriteLine(item.id + "  | " + item.name + "   |   " + item.age);
            }

            // Lọc ra danh sách những người nhỏ hơn 24 tuổi và sắp xếp theo tên.
            System.Console.WriteLine("Lọc ra danh sách những người nhỏ hơn 24 tuổi và sắp xếp theo tên.");
            var nv = arrayList.OfType<Staff>();

            var loc = from nhanvien in nv
                      where nhanvien.age < 24
                      orderby nhanvien.name
                      select nhanvien;

            foreach (Staff item in loc)
            {
                System.Console.WriteLine("Id:{0}, Name: {1}, Age: {2}", item.id, item.name, item.age);
            }

        }
    }
}
