using System;
using System.Collections.Generic;
using System.Text;
using LibsData.Models;
using LibsData;
using System.Linq;

namespace LibsService
{
    public class LibsMethodsServices : ILibsInterface
    {
        private LibraryContext _context;
        public LibsMethodsServices(LibraryContext context)
        {
            _context = context;
        }
      
        public void AddBook(Book newBook)
        {
            _context.Add(newBook);
        }

        public void AddLibraryBranch(LibraryBranch libraryBranch)
        {
            _context.Add(libraryBranch);
        }

        

        public void AddPatron(Patron newPatron)
        {
            _context.Add(newPatron);
        }

      

        public IEnumerable<Book> GetAllBooks()
        {
            return _context.Books;
        }

        public IEnumerable<LibraryBranch> GetAllLibraryBranches()
        {
            return _context.LibraryBranches;
        }

        public IEnumerable<Patron> GetAllPatrons()
        {
            return _context.Patrons;
        }

        public Book GetBookById(int id )
        {
            return _context.Books.FirstOrDefault(Book => Book.Id == id);
        }


        public LibraryBranch GetLibraryBranchById(int id)
        {
            return _context.LibraryBranches.FirstOrDefault(LibraryBranch => LibraryBranch.Id == id);
        }


        public Patron GetPatronById(int id)
        {
            return _context.Patrons.FirstOrDefault(Patron => Patron.id == id);
        }

    }
}
