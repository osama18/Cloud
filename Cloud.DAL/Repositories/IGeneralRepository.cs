using Cloud.DAL.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cloud.DAL.Repositories
{
    public interface IGeneralRepository<T> where T : Entity
    {
        public Task<IEnumerable<T>> RetrieveAll();
        public Task<T> Retrieve(Guid id);

        public Task Delete(Guid Id);
        public Task Create(T item);
        public Task<T> Update(T item);
    }
}
