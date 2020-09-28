using System;
using System.Collections.Generic;
using System.Text;

namespace Bai_2_sudung_Dictionary_CRUD_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Dictionary<string, Book> bookList = new Dictionary<string, Book>();
            bookList.Add("1", new Book { ISBN = "1", Name = "Giữ gìn sự trong sáng của Tiếng Việt", Author = "Hồ Chí Minh" });
            bookList.Add("2", new Book { ISBN = "2", Name = "Tây Tiến", Author = "Quang Dũng" });
            bookList.Add("3", new Book { ISBN = "3", Name = "Đất Nước", Author = "Nguyễn Khoa Điềm" });


            Console.WriteLine("Add books to Dictionary");
            PrintValue(bookList);

            bookList["1"] = new Book { ISBN = "1", Name = "Việt Bắc", Author = "Tố Hữu" };
            System.Console.WriteLine("Edit book with ISBN");
            PrintValue(bookList);

            // Tìm kiếm một phần tử trong Dictionary.Chạy chương trình và xem kết quả.

            Console.WriteLine("Search for a specific book with ISBN");
            if (bookList.ContainsKey("5") == false)
            {
                Console.WriteLine("Not found");
            }
            else
            {
                Book book = bookList["1"];
                Console.WriteLine("Found this book: " + book.Name);
            }

            // Xoá một phần tử trong Dictionary với key chỉ định và kiểm tra kết quả với phương thức PrintValue()

            bookList.Remove("3");

            Console.WriteLine("Remove book with ISBN");
            PrintValue(bookList);
        }

        public static void PrintValue(Dictionary<string, Book> bookList)
        {
            foreach (KeyValuePair<string, Book> kvp in bookList)
            {
                Book book = kvp.Value;
                Console.WriteLine("ISBN: " + book.ISBN + " - " +
                    book.Name + " - " + book.Author);
            }
            Console.WriteLine();
        }
    }
}
