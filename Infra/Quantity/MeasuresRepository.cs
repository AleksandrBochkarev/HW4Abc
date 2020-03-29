using System.Collections.Generic;
using System.Threading.Tasks;
using Abc.Domain.Quantity;

namespace Abc.Infra.Quantity
{
    public class MeasuresRepository: IMeasuresRepository

    {
        public Task<List<Measure>> Get()
        {
            throw new System.NotImplementedException();
        }

        public Task<Measure> Get(string id)
        {
            throw new System.NotImplementedException();
        }

        public Task Delete(string id)
        {
            throw new System.NotImplementedException();
        }

        public Task Update(Measure obj)
        {
            throw new System.NotImplementedException();
        }
    }
}
