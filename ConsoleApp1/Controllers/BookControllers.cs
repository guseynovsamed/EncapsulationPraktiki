using ConsoleApp1.Models;
using ConsoleApp1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Controllers
{
    internal class BookControllers
    {
        public  void GetAllByAutor()
        {
            string nameAuthor = "Huqo";

            BookService bookService = new();

            Book[] result = bookService.GetByAutoor(nameAuthor);


            foreach(var item in result)
            {
                Console.WriteLine(item.Name);
            }

             

        }   




        public void GetBook()
        {
            int id = 2;
                
            BookService bookService = new();

            Book result = bookService.GetById(id);

            Console.WriteLine(result.Name);
        }


        public void Search()
        {
            BookService bookService = new BookService();

            var result = bookService.GetByBook("t");
            foreach (var book in result)
            {

                Console.WriteLine(book.Name);
            }
        }
    }
}
