namespace StudentTrackSystem
{
    public interface IRepository<T>
{
    void Add(T entity);
    T GetById(int id);
    IEnumerable<T> GetAll();
}

public class InMemoryRepository<T> : IRepository<T> where T : class
{
    private readonly List<T> _storage = new List<T>();

    public void Add(T entity)
    {
        _storage.Add(entity);
    }

    public T GetById(int id)
    {
        var propertyInfo = typeof(T).GetProperty("Id");
        return _storage.FirstOrDefault(e => (int)propertyInfo.GetValue(e) == id);
    }

    public IEnumerable<T> GetAll()
    {
        return _storage;
    }
}

}
