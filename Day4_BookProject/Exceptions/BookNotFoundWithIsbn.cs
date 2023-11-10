using Day4_BookProject.Consts;

namespace Day4_BookProject.Exceptions
{
    public class BookNotFoundWithIsbn : Exception
    {
        public BookNotFoundWithIsbn(string isbn) : base(Messages.BookNotFounWithIsbnExceptionMessage(isbn))
        {
        }
    }
}
