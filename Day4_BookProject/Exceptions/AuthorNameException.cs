using Day4_BookProject.Consts;

namespace Day4_BookProject.Exceptions
{
    public class AuthorNameException : Exception
    {
        public AuthorNameException(string name) : base(Messages.AuthorNameExceptionMessage(name))
        {
        }
    }
}
