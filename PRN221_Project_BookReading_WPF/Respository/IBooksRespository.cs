using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Respository
{
    public interface IBooksRespository
    {
        public List<Book> GetAllBook();
        public Book GetBookById(int id);
        public void AddBook(Book book);
        public void UpdateBook(Book book);
        public void DeleteBook(int id);
        public int GetBookIdByBookName(string bookName);
        public List<Book> GetBooksBySearch(string text);
        public List<Book> GetBookByApproveSatus(string status);

        public List<Book> GetAvailableBooksForAccount(int id);
    }
}
