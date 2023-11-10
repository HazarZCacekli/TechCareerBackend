using Day4_BookProject.Exceptions;
using Day4_BookProject.Models;

namespace Day4_BookProject.Data
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly List<Author> _authors;
        public AuthorRepository()
        {
            _authors = new List<Author>()
            {
                new Author{Id=1,Name = "Yaşar Kemal" },
                new Author{Id=2,Name = "Ahmet Hamdi Tanpınar" },
                new Author{Id=3,Name = "Orhan Kemal" },
                new Author{Id=4,Name = "Yunus Emre" },
                new Author{Id=5,Name = "Nazım Hikmet" }
            };
        }

        public void Add(Author entity)
        {
            _authors.Add(entity);
        }

        public void Delete(int id)
        {
            Author author = _authors.FirstOrDefault(x => x.Id == id);
            if (author == null) 
            {
                throw new AuthorNotFoundException(id);
            }
            
            _authors.Remove(author);
        }

        public List<Author> GetAll()
        {
            return _authors;
        }

        public Author? GetById(int id)
        {
            Author author = _authors.FirstOrDefault(x => x.Id == id);
            if (author != null)
            {
                return author;
            }

            throw new AuthorNotFoundException(id);
        }
    }
}
