using LibsData.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibsService
{
    public interface ILibsInterface
    {
        IEnumerable<Patron> GetAllPatrons();
        void AddPatron(Patron patron);
        Patron GetPatronById(int id );
        
        IEnumerable<Book> GetAllBooks();
        void AddBook(Book book);
        Book GetBookById(int id);

        IEnumerable<LibraryBranch> GetAllLibraryBranches();
        void AddLibraryBranch(LibraryBranch libraryBranch);
        LibraryBranch GetLibraryBranchById(int id);
    }
}
