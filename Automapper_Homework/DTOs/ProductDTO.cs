namespace Automapper_Homework.DTOs
{
    public class ProductDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return $"Ürün Id : {Id},Ürün İsmi : {Name}, Ürün Fiyatı : {Price}";
        }
    }
}
