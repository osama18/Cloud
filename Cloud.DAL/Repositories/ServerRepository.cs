using Cloud.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloud.DAL.Repositories
{
    public class GeneralRepository<T> : IGeneralRepository<T> where T : Entity
    {
        private IList<T> _datastore = new List<T>();
        public async Task Create(T item)
        {
            _datastore.Add(item);
        }

        public async Task Delete(Guid id)
        {
            var itemToDelete = _datastore.FirstOrDefault(s => s.Id == id);
            if (itemToDelete != null)
                _datastore.Remove(itemToDelete);
        }

        public async Task<T> Retrieve(Guid id)
        {
            return _datastore.FirstOrDefault(s => s.Id == id);
        }

        public async Task<IEnumerable<T>> RetrieveAll()
        {
            return _datastore;
        }

        public async Task<T> Update(T item)
        {
            var itemToUpdate = _datastore.FirstOrDefault(s => s.Id == item.Id);
            itemToUpdate = item;
            return itemToUpdate;
        }
    }
}
