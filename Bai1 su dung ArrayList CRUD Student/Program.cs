using System;
using System.Collections;
using System.Text;

namespace Bai1_su_dung_ArrayList_CRUD_Student
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            ArrayList studentList = new ArrayList();
            studentList.Add(new Student { Name = "Peter", Age = 20 });
            studentList.Add(new Student { Name = "John", Age = 21 });
            studentList.Add(new Student { Name = "Mark", Age = 19 });

            foreach (Student student in studentList)
                Console.WriteLine(student.Name + " " + student.Age);

            // Thay đổi phần tử ở vị trí số 0 trong ArrayList.
            Console.WriteLine("Thay đổi phần tử ở vị trí số 0 trong ArrayList.");
            studentList[0] = new Student { Name = "Michael", Age = 21 };
            foreach (Student student in studentList)
                Console.WriteLine(student.Name + " " + student.Age);

            // Xoá phần tử có index bằng 1 trong ArrayList.
            Console.WriteLine("Xoá phần tử có index bằng 1 trong ArrayList.");
            studentList.RemoveAt(1);
            foreach (Student student in studentList)
                Console.WriteLine(student.Name + " " + student.Age);
        }
    }
}
