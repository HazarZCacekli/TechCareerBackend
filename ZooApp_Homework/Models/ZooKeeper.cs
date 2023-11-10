namespace ZooApp_Homework.Models
{
    public class ZooKeeper : BaseEntity
    {
        public string Surname { get; set; }
        public double Salary { get; set; }
        public int AnimalId { get; set; }

        public override string ToString()
        {
            return $"Bakıcının Id'si : {Id},Adı : {Name},Soyadı : {Surname},Yaşı : {Age},Baktığı Hayvanın Id'si {AnimalId}: ,Maaşı : {Salary},Cinsiyeti : {Gender}";
        }
    }
}
