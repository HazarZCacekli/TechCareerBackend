namespace Day4_BookProject.Models
{
    public class Author : EntityBase<int>
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return $"Yazarın Id'si : {Id}, İsmi : {Name}";
        }

    }
}
