namespace ZooApp_Homework.Exceptions
{
    public class ZooKeeperNotFoundException : Exception
    {
        public ZooKeeperNotFoundException(int id) : base($"Aradığınız id'ye ({id}) sahip bir bakıcı bulunamadı.")
        {
        }
    }
}
