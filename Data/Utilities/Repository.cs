using Data.Models;

namespace Data;


// Implements IRepository<T> and demonstrates
// the Template Method Pattern in action.
//
// Purpose:
//   - Provides a reusable base implementation of CRUD operations.
//   - Defines a fixed algorithm (template) while allowing derived
//     classes to customize certain steps.
//
// Key Features:
//   - Uses in-memory data storage for simplicity.
//   - Methods are marked 'virtual' for easy overriding.
//   - Demonstrates reflection-based ID handling (for demo purposes only).
//
// Design Pattern:
//   Template Method Pattern — defines the skeleton of an operation,
//   letting subclasses redefine specific steps without changing the structure.
public abstract class BaseRepository<T> : IRepository<T> where T : class
{
    protected readonly List<T> Data = new();

    public virtual List<T> GetAll()
    {
        return Data;
    }

    public virtual T GetById(long id)
    {
        // Generic reflection-based ID search for demo purposes
        return Data.FirstOrDefault(e =>
            (long)e.GetType().GetProperty("Id")!.GetValue(e)! == id);
    }

    public virtual void Add(T entity)
    {
        Data.Add(entity);
    }

    public virtual void Update(T entity)
    {
        var id = (long)entity.GetType().GetProperty("Id")!.GetValue(entity)!;
        var existing = GetById(id);
        if (existing != null)
        {
            var index = Data.IndexOf(existing);
            Data[index] = entity;
        }
    }

    public virtual void Delete(long id)
    {
        var entity = GetById(id);
        if (entity != null)
            Data.Remove(entity);
    }
}