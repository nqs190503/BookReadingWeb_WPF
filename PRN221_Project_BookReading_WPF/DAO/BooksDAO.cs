using BussinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class BooksDAO
    {
        private PRN221_ProjectContext _context;
        private static BooksDAO _instance = null;
        public static BooksDAO Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new BooksDAO();
                }
                return _instance;
            }
        }
        private BooksDAO()
        {
            _context = new PRN221_ProjectContext();
        }
        public List<Book> GetAllBooks()
        {
            try
            {
                return _context.Books
                .Include(x => x.Chapters)
                .Include(x => x.CategoryInBooks)
                .Include(x => x.User)
                .ToList();
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }
        public Book GetBookById(int id)
        {
            try
            {
                return _context.Books.SingleOrDefault(b => b.BookId == id);
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }
        public int GetBookIdByBookName(string bookName)
        {
            try
            {
                var book = _context.Books.SingleOrDefault(r => r.Title.Equals(bookName));
                return book.BookId;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public void AddBook(Book book)
        {
            try
            {
                _context.Books.Add(book);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }
        public void UpdateBook(Book book)
        {
            try
            {
                var bookToUpdate = _context.Books.SingleOrDefault(b => b.BookId == book.BookId);
                if (bookToUpdate != null)
                {
                    bookToUpdate.Title = book.Title;
                    bookToUpdate.AuthorName = book.AuthorName;
                    bookToUpdate.PublishDate = book.PublishDate;

                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }
        public void DeleteBook(int id)
        {
            try
            {
                var bookToDelete = _context.Books.SingleOrDefault(b => b.BookId == id);
                if (bookToDelete != null)
                {
                    _context.Books.Remove(bookToDelete);
                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }
        public List<Book> GetBooksBySearch(string text)
        {
            try
            {
                var _res = _context.Books
                    .Include(x => x.Chapters)
                .Include(x => x.CategoryInBooks)
                .Include(x => x.User)
                .Where(u =>
                u.Title.ToLower().Contains(text) ||
                u.AuthorName.ToLower().Contains(text) ||
                u.Status.ToLower().Contains(text))
                .ToList();
                return _res;

            }
            catch (Exception ex)
            {
                throw ex;

            }
        }
        public List<Book> GetBookByApproveSatus(string status)
        {
            try
            {
                return _context.Books
                .Include(x => x.Chapters)
                .Include(x => x.CategoryInBooks)
                .Include(x => x.User)
                .Where(u => u.Approve == status).ToList();
            }
            catch (Exception ex)
            {
                throw ex;

            }
        }
        public List<Book> GetAvailableBooksForAccount(int accountId)
        {
            //var borrowedBookIds = _context.BorrowingHistories.Include(b => b.Book)
            //                               .Where(b => b.AccountId == accountId)
            //                               .Select(b => b.BookId)
            //                               .ToList();
            return _context.Books
                           //.Where(book => !.Contains(book.BookId))
                           .ToList();
        }

    }
}
