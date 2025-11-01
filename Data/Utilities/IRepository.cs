namespace Data;

// Defines a generic contract for CRUD operations.
//
// Purpose:
//   - Abstracts data access logic to promote loose coupling.
//   - Provides a simple and consistent way to interact with data sources.
//   - Serves as the foundation for the Repository Pattern.
//
// Key Idea:
//   Business logic depends on this abstraction rather than a specific data store.
//   This makes the code easier to test, maintain, and extend.
public interface IRepository<T> where T : class
{
    T GetById(long id);
    List<T> GetAll();
    void Add(T entity);
    void Update(T entity);
    void Delete(long id);
}
