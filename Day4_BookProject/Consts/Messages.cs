namespace Day4_BookProject.Consts;

public  class Messages
{
    public static string BookTitleExceptionMessage(string title)
    {
        return $"{title} , minimum 2 karakterli olmalıdır girdiğiniz karakter sayısı : {title.Length}";
    }

    public static string BookPriceAndStockExceptionMessage(double price, int stock)
    {
        return $"girdiğiniz stok ve değer bilgisi negatif değerler olamaz. Stok :{stock}, Kitap değeri : {price}";
    }

    public static string AuthorNameExceptionMessage (string name)
    {
        return $"Girdiğiniz yazar adı en az 2 karakterli olmalıdır. Girdiğiniz karakter sayısı : {name.Length}";
    }

    public static string AuthorNotFoundExceptionMessage(int id)
    {
        return $"Aradığınız id'ye ({id}) ait yazar bulunamadi";
    }

    public static string BookNotFounWithIsbnExceptionMessage(string isbn)
    {
        return $"Aradığınız ISBN {isbn} numarasına ait kitap bulunamadı.";
    }

}
