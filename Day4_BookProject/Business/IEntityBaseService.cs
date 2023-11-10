namespace Day4_BookProject.Business
{
    public interface IEntityBaseService<Entity,TId>
    {
        void GetList();
        void Add(Entity entity);
        void Delete(TId id);
        void GetById(TId id);
    }
}
