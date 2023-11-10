namespace ZooApp_Homework.Exceptions
{
    public class AnimalNotFoundException : Exception
    {
        public AnimalNotFoundException(int id) : base($"Aradığınız id'ye ({id}) sahip bir hayvan bulunamadı.")
        {
        }
    }
}
