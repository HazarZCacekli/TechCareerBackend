

using Day4_BookProject.Models;

namespace Day4_BookProject.Business;

internal interface IBookService : IEntityBaseService<Book,int>
{
    public void GetByIsbn(string isbn);
}
