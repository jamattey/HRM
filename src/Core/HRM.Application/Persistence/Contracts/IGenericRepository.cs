using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HRM.Application.Persistence.Contracts
{
    // Interface is implemmented relative to a class called T and is used by domain objects to access database functionality through the interface
    public interface IGenericRepository <T> where T : class
    {
        Task<T> Get (int id);

        // IReadOnlyList keeps objects in a readonly state which cannot be modified once it is loaded from database
        Task<IReadOnlyList<T>> GetAll ();

        Task<T> Add (T entity);

        Task<T> Update (T entity);

        Task<T> Delete (T entity);
    }
}