using System.Collections.Generic;
using System.Threading.Tasks;

namespace Abc.Domain.Common
{
    public interface IRepository<T>
    {

        Task<List<T>> Get();

        Task<T> Get(string id);
        Task Delete(string id);
        Task Update(T obj);




    }
}