using Day4_BookProject.Data;
using Day4_BookProject.Exceptions;
using Day4_BookProject.Models;

namespace Day4_BookProject.Business
{
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository _authorRepository;
        private readonly IBookRepository _bookRepository;

        public AuthorService(IAuthorRepository authorRepository, IBookRepository bookRepository)
        {
            _authorRepository = authorRepository;
            _bookRepository = bookRepository;
        }

        public void Add(Author entity)
        {
            if (entity.Name.Length < 2)
            {
                throw new AuthorNameException(entity.Name);
            }

            try
            {
                _authorRepository.Add(entity);
                GetList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Delete(int id)
        {
            try
            {
                _authorRepository.Delete(id);
                GetList();
            }
            catch (AuthorNotFoundException ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        public void GetById(int id)
        {
            try
            {
                Author author = _authorRepository.GetById(id);
                Console.WriteLine(author);
                List<Book> books = _bookRepository.GetAll();
                var authorsBooks = books.Where(x => x.AuthorId == author.Id).ToList();
                if (authorsBooks != null)
                {
                    authorsBooks.ForEach(x => Console.WriteLine(x));
                }
            }
            catch (AuthorNotFoundException exception)
            {

                Console.WriteLine(exception.Message);
            }
        }

        public void GetList()
        {
            List<Author> authors = _authorRepository.GetAll();
            authors.ForEach(author => Console.WriteLine(author));
        }

    }
}
