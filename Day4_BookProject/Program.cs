// Kitap ekleme listeleme ve silme gibi operasyonları simüle edeceğiz
// veri tabanı gibi çalışan bir liste kullanacağız

using Day4_BookProject.Business;
using Day4_BookProject.Data;
using Day4_BookProject.Models;
// Dapper


IBookService bookService = new BookService(new BookRepository());
IAuthorService authorService = new AuthorService(new AuthorRepository(),new BookRepository());
authorService.GetList();
//bookService.GetList();
Console.WriteLine("-----------------------------------");
Author newAuthor = new()
{
    Id = 7,
    Name = "Namık Kemal"
};
authorService.Add(newAuthor);
Console.WriteLine("----------------------------------");
authorService.Delete(3);
Console.WriteLine("----------------------------------");
authorService.GetById(1);
Console.WriteLine("----------------------------------");
bookService.GetByIsbn("abc123");
//Book book = new Book()
//{
//    Id = 5,
//    Description = "Test",
//    Price=2500,
//    Stock=-2000,
//    Title= "Test"
//};

//Console.WriteLine("Kayıt ekleme : ");
//bookService.Add(book);
//Console.WriteLine("Kayıt silme : ");
//bookService.Delete(2);

//Console.WriteLine("Id ye göre getirme:");
//bookService.GetById(2);


//Console.WriteLine("Kitapların listesi");
//bookService.GetList();