namespace ZooApp_Homework.Models
{
    public class Animal : BaseEntity
    {
        public string Type { get; set; }
        public string FoodType { get; set; }

        public override string ToString()
        {
            return $"Hayvanın Id'si : {Id},Adı : {Name},Yaşı : {Age},Cinsi : {Type},Yediği Yemek Türü : {FoodType},Cinsiyeti : {Gender}";
        }
    }
}
