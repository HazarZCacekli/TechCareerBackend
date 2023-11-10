using Day4_BookProject.Consts;

namespace Day4_BookProject.Exceptions
{
    public class AuthorNotFoundException : Exception
    {
        public AuthorNotFoundException(int id) : base(Messages.AuthorNotFoundExceptionMessage(id))
        {
        }
    }
}
