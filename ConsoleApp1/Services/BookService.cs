using ConsoleApp1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Services
{
    internal class BookService
    {
        private Book[] GetAll()
        {
            Book book1 = new()
            {
                id = 1,
                Name = "Sefiller",
                Author = "Huqo",
                PageCount = 120
            };

            Book book2 = new()
            {
                id = 2,
                Name = "Iskendername",
                Author = "Nizami",
                PageCount = 156
            };


            Book book3 = new()
            {
                id = 3,
                Name = "Top10LangDev",
                Author = "Cavid",
                PageCount = 1090
            };

            return new Book[] {book1, book2, book3};
        }
        public Book[] GetByAutoor(string author)
        {


            Book[] books = GetAll();



            Book[] fildereset = books.Where(n => n.Author == author).ToArray();



            return fildereset;




        }





        public Book GetById(int id )
        {
            Book[] books = GetAll();

            Book book = books.FirstOrDefault(x=>x.id == id);

            return book;

        }

        public Book[] GetByBook(string searchText)
        {
            return GetAll().Where(n=>n.Name.ToLower().Contains(searchText.ToLower())).ToArray();    
        } 
    }


    
    
}
